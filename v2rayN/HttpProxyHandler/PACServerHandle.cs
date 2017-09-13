using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using v2rayN.Mode;
using v2rayN.Properties;
using v2rayN.Tool;

namespace v2rayN.HttpProxyHandler
{
    /// <summary>
    /// 提供PAC功能支持
    /// </summary>
    class PACServerHandle
    {
        public const string PAC_FILE = "pac.txt";

        private static HttpListener pacLinstener;

        public static void Init(Config config)
        {
            pacLinstener = new HttpListener(); //创建监听实例  
            pacLinstener.Prefixes.Add(string.Format("http://127.0.0.1:{0}/pac/", Global.pacPort)); //添加监听地址 注意是以/结尾。  
            pacLinstener.Start(); //允许该监听地址接受请求的传入。  
            Thread threadpacLinstener = new Thread(new ParameterizedThreadStart(GetPacList)); //创建开启一个线程监听该地址得请求  
            threadpacLinstener.IsBackground = true;
            threadpacLinstener.Start(config);

        }

        public static void Stop()
        {
            if (pacLinstener != null && pacLinstener.IsListening)
            {
                pacLinstener.Abort();
                pacLinstener = null;
            }
        }

        private static void GetPacList(object config)
        {
            var cfg = config as Config;
            var port = Global.sysAgentPort;
            if (port <= 0)
            {
                return;
            }
            var proxy = string.Format("PROXY 127.0.0.1:{0};", port);
            while (pacLinstener != null && pacLinstener.IsListening)
            {
                HttpListenerContext requestContext = null;
                try
                {
                    requestContext = pacLinstener.GetContext(); //接受到新的请求  
                    //reecontext 为开启线程传入的 requestContext请求对象  
                    Thread subthread = new Thread(new ParameterizedThreadStart((reecontext) =>
                    {
                        requestContext.Response.StatusCode = 200;
                        requestContext.Response.ContentType = "application/x-ns-proxy-autoconfig";
                        requestContext.Response.ContentEncoding = Encoding.UTF8;
                        if (!File.Exists(PAC_FILE))
                        {
                            //TODO:暂时没解决更新PAC列表的问题，用直接解压现有PAC解决
                            //new PACListHandle().UpdatePACFromGFWList(cfg);
                            FileManager.UncompressFile(PAC_FILE, Resources.pac_txt);
                        }
                        var pac = File.ReadAllText(PAC_FILE, Encoding.UTF8);
                        pac = pac.Replace("__PROXY__", proxy);
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(pac);
                        //对客户端输出相应信息.  
                        requestContext.Response.ContentLength64 = buffer.Length;
                        System.IO.Stream output = requestContext.Response.OutputStream;
                        output.Write(buffer, 0, buffer.Length);
                        //关闭输出流，释放相应资源  
                        output.Close();
                    }));
                    subthread.Start(requestContext); //开启处理线程处理下载文件  
                }
                catch (HttpListenerException)
                {
                    continue;
                }
                catch (Exception ex)
                {
                    try
                    {
                        requestContext.Response.StatusCode = 500;
                        requestContext.Response.ContentType = "application/text";
                        requestContext.Response.ContentEncoding = Encoding.UTF8;
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes("System Error");
                        //对客户端输出相应信息.  
                        requestContext.Response.ContentLength64 = buffer.Length;
                        System.IO.Stream output = requestContext.Response.OutputStream;
                        output.Write(buffer, 0, buffer.Length);
                        //关闭输出流，释放相应资源  
                        output.Close();
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}
