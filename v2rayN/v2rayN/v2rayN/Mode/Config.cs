using System;
using System.Collections.Generic;

namespace v2rayN.Mode
{
    /// <summary>
    /// 本软件配置文件实体类
    /// </summary>
    [Serializable]
    public class Config
    {
        /// <summary>
        /// 本地监听
        /// </summary>
        public List<InItem> inbound { get; set; }

        /// <summary>
        /// 允许日志
        /// </summary>
        public bool logEnabled { get; set; }

        /// <summary>
        /// 日志等级
        /// </summary>
        public string loglevel { get; set; }

        /// <summary>
        /// 活动配置序号
        /// </summary>
        public int index { get; set; }

        /// <summary>
        /// vmess服务器信息
        /// </summary>
        public List<VmessItem> vmess { get; set; }

        /// <summary>
        /// 允许Mux多路复用
        /// </summary>
        public bool muxEnabled { get; set; }

        /// <summary>
        /// 路由=>绕过大陆网址
        /// </summary>
        public bool chinasites { get; set; }

        /// <summary>
        /// 路由=>绕过大陆ip
        /// </summary>
        public bool chinaip { get; set; }

        /// <summary>
        /// 用户自定义需代理的网址或ip
        /// </summary>
        public List<string> useragent { get; set; }

        /// <summary>
        /// 用户自定义直连的网址或ip
        /// </summary>
        public List<string> userdirect { get; set; }

        /// <summary>
        /// 用户自定义阻止的网址或ip
        /// </summary>
        public List<string> userblock { get; set; }

        /// <summary>
        /// KcpItem
        /// </summary>
        public KcpItem kcpItem { get; set; }

        /// <summary>
        /// 自动从网络同步本地时间
        /// </summary>
        public bool autoSyncTime { get; set; }

        /// <summary>
        /// 启用系统代理
        /// </summary>
        public bool sysAgentEnabled { get; set; }

        /// <summary>
        /// 监听状态 0-不改变 1-全局 2-PAC
        /// </summary>
        public int listenerType { get; set; }
                
        /// <summary>
        /// 自定义GFWList url
        /// </summary>
        public string urlGFWList { get; set; }
        
        #region 函数

        public string address()
        {
            if (index < 0)
            {
                return string.Empty;
            }
            return vmess[index].address;
        }

        public int port()
        {
            if (index < 0)
            {
                return 1080;
            }
            return vmess[index].port;
        }

        public string id()
        {
            if (index < 0)
            {
                return string.Empty;
            }
            return vmess[index].id;
        }

        public int alterId()
        {
            if (index < 0)
            {
                return 0;
            }
            return vmess[index].alterId;
        }

        public string security()
        {
            if (index < 0)
            {
                return string.Empty;
            }
            return vmess[index].security;
        }

        public string remarks()
        {
            if (index < 0)
            {
                return string.Empty;
            }
            return vmess[index].remarks;
        }
        public string network()
        {
            if (index < 0 || Utils.IsNullOrEmpty(vmess[index].network))
            {
                return Global.DefaultNetwork;
            }
            return vmess[index].network;
        }
        public string headerType()
        {
            if (index < 0 || Utils.IsNullOrEmpty(vmess[index].headerType))
            {
                return Global.None;
            }
            return vmess[index].headerType;
        }
        public string requestHost()
        {
            if (index < 0 || Utils.IsNullOrEmpty(vmess[index].requestHost))
            {
                return string.Empty;
            }
            return vmess[index].requestHost;
        }
        public string streamSecurity()
        {
            if (index < 0 || Utils.IsNullOrEmpty(vmess[index].streamSecurity))
            {
                return string.Empty;
            }
            return vmess[index].streamSecurity;
        }

        public int GetLocalPort(string protocol)
        {
            int localPort = 0;
            foreach (InItem inItem in inbound)
            {
                if (inItem.protocol.Equals(protocol))
                {
                    localPort = inItem.localPort;
                    break;
                }
            }
            return localPort;
        }
        #endregion

    }

    [Serializable]
    public class VmessItem
    {
        /// <summary>
        /// 远程服务器地址
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 远程服务器端口
        /// </summary>
        public int port { get; set; }
        /// <summary>
        /// 远程服务器ID
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 远程服务器额外ID
        /// </summary>
        public int alterId { get; set; }
        /// <summary>
        /// 本地安全策略
        /// </summary>
        public string security { get; set; }
        /// <summary>
        /// tcp,kcp,ws
        /// </summary>
        public string network { get; set; }
        /// <summary>
        /// 备注或别名
        /// </summary>
        public string remarks { get; set; }

        /// <summary>
        /// 伪装类型
        /// </summary>
        public string headerType { get; set; }

        /// <summary>
        /// 伪装的域名
        /// </summary>
        public string requestHost { get; set; }

        /// <summary>
        /// 底层传输安全
        /// </summary>
        public string streamSecurity { get; set; }

    }

    [Serializable]
    public class InItem
    {
        /// <summary>
        /// 本地监听端口
        /// </summary>
        public int localPort { get; set; }

        /// <summary>
        /// 协议，默认为socks
        /// </summary>
        public string protocol { get; set; }

        /// <summary>
        /// 允许udp
        /// </summary>
        public bool udpEnabled { get; set; }
    }

    [Serializable]
    public class KcpItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int mtu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tti { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int uplinkCapacity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int downlinkCapacity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool congestion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int readBufferSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int writeBufferSize { get; set; }
    }
}
