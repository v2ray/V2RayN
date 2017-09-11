using System.Collections.Generic;
using v2rayN.Mode;

namespace v2rayN.Handler
{
    /// <summary>
    /// 本软件配置文件处理类
    /// </summary>
    class ConfigHandler
    {
        private static string configRes = Global.ConfigFileName;

        /// <summary>
        /// 载入配置文件
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static int LoadConfig(ref Config config)
        {
            //载入配置文件 
            string result = Utils.LoadResource(Utils.GetPath(configRes));
            if (!Utils.IsNullOrEmpty(result))
            {
                //转成Json
                config = Utils.FromJson<Config>(result);
            }
            if (config == null)
            {
                config = new Config();
                config.index = -1;
                config.logEnabled = false;
                config.loglevel = "warning";
                config.vmess = new List<VmessItem>();

                //路由
                config.chinasites = false;
                config.chinaip = false;

                //Mux
                config.muxEnabled = true;

                ////默认监听端口
                //config.pacPort = 8888;
            }

            //本地监听
            if (config.inbound == null)
            {
                config.inbound = new List<InItem>();
                InItem inItem = new InItem();
                inItem.protocol = "socks";
                inItem.localPort = 1080;
                inItem.udpEnabled = true;

                config.inbound.Add(inItem);

                //inItem = new InItem();
                //inItem.protocol = "http";
                //inItem.localPort = 1081;
                //inItem.udpEnabled = true;

                //config.inbound.Add(inItem);
            }
            else
            {
                //http协议不由core提供,只保留socks
                if (config.inbound.Count > 0)
                {
                    config.inbound[0].protocol = "socks";
                }
            }
            //路由规则
            if (config.useragent == null)
            {
                config.useragent = new List<string>();
            }
            if (config.userdirect == null)
            {
                config.userdirect = new List<string>();
            }
            if (config.userblock == null)
            {
                config.userblock = new List<string>();
            }
            //kcp
            if (config.kcpItem == null)
            {
                config.kcpItem = new KcpItem();
                config.kcpItem.mtu = 1350;
                config.kcpItem.tti = 50;
                config.kcpItem.uplinkCapacity = 12;
                config.kcpItem.downlinkCapacity = 100;
                config.kcpItem.readBufferSize = 2;
                config.kcpItem.writeBufferSize = 2;
                config.kcpItem.congestion = false;
            }

            //// 如果是用户升级，首次会有端口号为0的情况，不可用，这里处理
            //if (config.pacPort == 0)
            //{
            //    config.pacPort = 8888;
            //}

            if (config == null
                || config.index < 0
                || config.vmess.Count <= 0
                || config.index > config.vmess.Count - 1
                )
            {
                Global.reloadV2ray = false;
            }
            else
            {
                Global.reloadV2ray = true;
            }

            return 0;
        }

        /// <summary>
        /// 添加服务器或编辑
        /// </summary>
        /// <param name="config"></param>
        /// <param name="vmessItem"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int AddServer(ref Config config, VmessItem vmessItem, int index)
        {
            if (index >= 0)
            {
                //修改
                config.vmess[index] = vmessItem;
                if (config.index.Equals(index))
                {
                    Global.reloadV2ray = true;
                }
            }
            else
            {
                //添加
                config.vmess.Add(vmessItem);
                if (config.vmess.Count == 1)
                {
                    config.index = 0;
                    Global.reloadV2ray = true;
                }
            }

            ToJsonFile(config);

            return 0;
        }

        /// <summary>
        /// 移除服务器
        /// </summary>
        /// <param name="config"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int RemoveServer(ref Config config, int index)
        {
            if (index < 0 || index > config.vmess.Count - 1)
            {
                return -1;
            }

            //删除
            config.vmess.RemoveAt(index);


            //移除的是活动的
            if (config.index.Equals(index))
            {
                if (config.vmess.Count > 0)
                {
                    config.index = 0;
                }
                else
                {
                    config.index = -1;
                }
                Global.reloadV2ray = true;
            }
            else if (index < config.index)//移除活动之前的
            {
                config.index--;
                Global.reloadV2ray = true;
            }

            ToJsonFile(config);

            return 0;
        }

        /// <summary>
        /// 复制服务器
        /// </summary>
        /// <param name="config"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int CopyServer(ref Config config, int index)
        {
            if (index < 0 || index > config.vmess.Count - 1)
            {
                return -1;
            }

            VmessItem vmessItem = new VmessItem();
            vmessItem.address = config.vmess[index].address;
            vmessItem.port = config.vmess[index].port;
            vmessItem.id = config.vmess[index].id;
            vmessItem.alterId = config.vmess[index].alterId;
            vmessItem.security = config.vmess[index].security;
            vmessItem.network = config.vmess[index].network;
            vmessItem.headerType = config.vmess[index].headerType;
            vmessItem.requestHost = config.vmess[index].requestHost;
            vmessItem.streamSecurity = config.vmess[index].streamSecurity;
            vmessItem.remarks = string.Format("{0}-副本", config.vmess[index].remarks);
            config.vmess.Add(vmessItem);

            ToJsonFile(config);

            return 0;
        }

        /// <summary>
        /// 设置活动服务器
        /// </summary>
        /// <param name="config"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int SetDefaultServer(ref Config config, int index)
        {
            if (index < 0 || index > config.vmess.Count - 1)
            {
                return -1;
            }

            ////和现在相同
            //if (config.index.Equals(index))
            //{
            //    return -1;
            //}
            config.index = index;
            Global.reloadV2ray = true;

            ToJsonFile(config);

            return 0;
        }

        /// <summary>
        /// 保参数
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static int SaveConfig(ref Config config)
        {
            Global.reloadV2ray = true;

            ToJsonFile(config);

            return 0;
        }

        /// <summary>
        /// 存储文件
        /// </summary>
        /// <param name="config"></param>
        public static void ToJsonFile(Config config)
        {
            Utils.ToJsonFile(config, Utils.GetPath(configRes));
        }

        /// <summary>
        /// 取得服务器QRCode配置
        /// </summary>
        /// <param name="config"></param>
        /// <param name="index"></param>
        /// <param name="vmessQRCode"></param>
        /// <returns></returns>
        public static int GetVmessQRCode(Config config, int index, ref VmessQRCode vmessQRCode)
        {
            try
            {
                VmessItem vmessItem = config.vmess[index];

                vmessQRCode = new VmessQRCode();
                vmessQRCode.ps = vmessItem.remarks.Trim(); //备注也许很长 ;
                vmessQRCode.add = vmessItem.address;
                vmessQRCode.port = vmessItem.port.ToString();
                vmessQRCode.id = vmessItem.id;
                vmessQRCode.aid = vmessItem.alterId.ToString();
                vmessQRCode.net = vmessItem.network;
                vmessQRCode.type = vmessItem.headerType;
                vmessQRCode.host = vmessItem.requestHost;
                vmessQRCode.tls = vmessItem.streamSecurity;

                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>
        /// 移动服务器
        /// </summary>
        /// <param name="config"></param>
        /// <param name="index"></param>
        /// <param name="eMove"></param>
        /// <returns></returns>
        public static int MoveServer(ref Config config, int index, EMove eMove)
        {
            int count = config.vmess.Count;
            if (index < 0 || index > config.vmess.Count - 1)
            {
                return -1;
            }
            switch (eMove)
            {
                case EMove.Top:
                    {
                        if (index == 0)
                        {
                            return 0;
                        }
                        VmessItem vmess = Utils.DeepCopy<VmessItem>(config.vmess[index]);
                        config.vmess.RemoveAt(index);
                        config.vmess.Insert(0, vmess);
                        if (index < config.index)
                        {
                            //
                        }
                        else if (config.index == index)
                        {
                            config.index = 0;
                        }
                        else
                        {
                            config.index++;
                        }
                        break;
                    }
                case EMove.Up:
                    {
                        if (index == 0)
                        {
                            return 0;
                        }
                        VmessItem vmess = Utils.DeepCopy<VmessItem>(config.vmess[index]);
                        config.vmess.RemoveAt(index);
                        config.vmess.Insert(index - 1, vmess);
                        if (index == config.index + 1)
                        {
                            config.index++;
                        }
                        else if (config.index == index)
                        {
                            config.index--;
                        }
                        break;
                    }

                case EMove.Down:
                    {
                        if (index == count - 1)
                        {
                            return 0;
                        }
                        VmessItem vmess = Utils.DeepCopy<VmessItem>(config.vmess[index]);
                        config.vmess.RemoveAt(index);
                        config.vmess.Insert(index + 1, vmess);
                        if (index == config.index - 1)
                        {
                            config.index--;
                        }
                        else if (config.index == index)
                        {
                            config.index++;
                        }
                        break;
                    }
                case EMove.Bottom:
                    {
                        if (index == count - 1)
                        {
                            return 0;
                        }
                        VmessItem vmess = Utils.DeepCopy<VmessItem>(config.vmess[index]);
                        config.vmess.RemoveAt(index);
                        config.vmess.Add(vmess);
                        if (index < config.index)
                        {
                            config.index--;
                        }
                        else if (config.index == index)
                        {
                            config.index = count - 1;
                        }
                        else
                        {
                            //
                        }
                        break;
                    }

            }
            Global.reloadV2ray = true;

            ToJsonFile(config);

            return 0;
        }

    }
}
