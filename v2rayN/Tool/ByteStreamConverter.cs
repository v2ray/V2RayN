using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using v2rayN.Mode;

namespace v2rayN.Tool
{
    public static class ByteStreamRegulator
    {
        public static void vItem2Bs(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            Address2Byte(ref ByteStream, vmessItem);
            Port2Byte(ref ByteStream, vmessItem);
            uID2Byte(ref ByteStream, vmessItem);
            alterID2Byte(ref ByteStream, vmessItem);
            security2Byte(ref ByteStream, vmessItem);
            network2Byte(ref ByteStream, vmessItem);
            headerType2Byte(ref ByteStream, vmessItem);
            requestHost2Byte(ref ByteStream, vmessItem);
            streamSecurity2Byte(ref ByteStream, vmessItem);
        }

        private static void Address2Byte (ref List<byte> ByteStream, VmessItem vmessItem)
        {
            try
            {
                string[] Address_buf = vmessItem.address.Split('.');
                ByteStream.Add(0xFF);
                ByteStream.Add(0xF0);
                foreach (string s in Address_buf)
                {
                    ByteStream.Add(Convert.ToByte(Int32.Parse(s)));
                }
            }

            catch (FormatException e)
            {
                ByteStream.Clear();
                byte[] Address_buf = Encoding.ASCII.GetBytes(vmessItem.address);
                ByteStream.Add(0xFF);
                ByteStream.Add(0xF1);
                ByteStream.Add(Convert.ToByte(Address_buf.Length));
                foreach (byte b in Address_buf)
                {
                    ByteStream.Add(b);
                }
            }
        }

        private static void Port2Byte(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF2);
            ByteStream.Add(Convert.ToByte(vmessItem.port >> 8));
            ByteStream.Add(Convert.ToByte(vmessItem.port % 0x100));
        }

        private static void uID2Byte(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF3);
            string hexID = vmessItem.id.Replace("-", "");
            for (int i = 0; i < hexID.Length; i += 2)
                ByteStream.Add(Convert.ToByte(hexID.Substring(i, 2), 16));
        }

        private static void alterID2Byte(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF4);
            ByteStream.Add(Convert.ToByte(vmessItem.alterId));
        }

        private static void security2Byte(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF5);
            switch (vmessItem.security)
            {
                case "none":
                    ByteStream.Add(0x00);
                    break;
                case "aes-128-cfb":
                    ByteStream.Add(0x01);
                    break;
                case "aes-128-gcm":
                    ByteStream.Add(0x02);
                    break;
                case "chacha20-poly1305":
                    ByteStream.Add(0x03);
                    break;
            }
        }

        private static void network2Byte(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF6);
            switch (vmessItem.network)
            {
                case "tcp":
                    ByteStream.Add(0x00);
                    break;
                case "kcp":
                    ByteStream.Add(0x01);
                    break;
                case "ws":
                    ByteStream.Add(0x02);
                    break;
            }
        }

        private static void headerType2Byte(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF7);
            switch (vmessItem.headerType)
            {
                case "none":
                    ByteStream.Add(0x00);
                    break;
                case "http":
                    ByteStream.Add(0x01);
                    break;
                case "srtp":
                    ByteStream.Add(0x02);
                    break;
                case "utp":
                    ByteStream.Add(0x03);
                    break;
                case "wechat-video":
                    ByteStream.Add(0x04);
                    break;
            }
        }

        private static void requestHost2Byte(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            try
            {
                byte[] Host_buf = Encoding.ASCII.GetBytes(vmessItem.requestHost);
                ByteStream.Add(0xFF);
                ByteStream.Add(0xF8);
                ByteStream.Add(Convert.ToByte(Host_buf.Length));
                foreach (byte b in Host_buf)
                {
                    ByteStream.Add(b);
                }
            }
            catch (ArgumentNullException e) { return; }
        }

        private static void streamSecurity2Byte(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF9);
            switch (vmessItem.streamSecurity)
            {
                case "none":
                    ByteStream.Add(0x00);
                    break;
                case "tls":
                    ByteStream.Add(0x01);
                    break;
            }
        }

    }

    public static class ByteStreamInverter
    {
        public static void Bs2vItem(ref byte[] Bytestream, VmessItem vmessItem)
        {
            Byte2Address(ref Bytestream, vmessItem);
            Byte2Port(ref Bytestream, vmessItem);
            Byte2uID(ref Bytestream, vmessItem);
            Byte2alterID(ref Bytestream, vmessItem);
            Byte2security(ref Bytestream, vmessItem);
            Byte2Network(ref Bytestream, vmessItem);
            Byte2headerType(ref Bytestream, vmessItem);
            Byte2requestHost(ref Bytestream, vmessItem);
            Byte2streamSecurity(ref Bytestream, vmessItem);
        }

        private static void Byte2Address(ref byte[] Bytestream, VmessItem vmessItem)
        {
            byte[] tgt = { 0xFF, 0xF0 };
            int idx = ByteSearch(Bytestream, tgt);
            if (idx>=0)
            {
                vmessItem.address =Convert.ToString(Convert.ToInt32(Bytestream[idx+2]))+'.'+
                    Convert.ToString(Convert.ToInt32(Bytestream[idx + 3])) + '.'+
                    Convert.ToString(Convert.ToInt32(Bytestream[idx + 4])) + '.'+
                    Convert.ToString(Convert.ToInt32(Bytestream[idx + 5]));
            }
            else
            {
                
                byte[] www = { 0xFF, 0xF1 };
                idx = ByteSearch(Bytestream, www);
                byte[] buff = new byte[Bytestream[idx + 2]];
                Buffer.BlockCopy(Bytestream, idx + 3, buff, 0, Bytestream[idx + 2]);
                vmessItem.address = Encoding.ASCII.GetString(buff);
            }
        }

        private static void Byte2Port(ref byte[] Bytestream, VmessItem vmessItem)
        {
            byte[] tgt = { 0xFF, 0xF2 };
            int idx = ByteSearch(Bytestream, tgt);
            vmessItem.port = (Convert.ToInt32(Bytestream[idx + 2] << 8)) + Convert.ToInt32(Bytestream[idx + 3]);
        }

        private static void Byte2uID(ref byte[] Bytestream, VmessItem vmessItem)
        {
            byte[] tgt = { 0xFF, 0xF3 };
            int idx = ByteSearch(Bytestream, tgt);

            byte[] buff = new byte[4];
            Buffer.BlockCopy(Bytestream, idx + 2, buff, 0, 4);
            string uuid = BitConverter.ToString(buff).Replace("-","");
            uuid += '-';

            buff = new byte[2];
            Buffer.BlockCopy(Bytestream, idx + 6, buff, 0, 2);
            uuid += BitConverter.ToString(buff).Replace("-", "");
            uuid += '-';

            Buffer.BlockCopy(Bytestream, idx + 8, buff, 0, 2);
            uuid += BitConverter.ToString(buff).Replace("-", "");
            uuid += '-';

            Buffer.BlockCopy(Bytestream, idx + 10, buff, 0, 2);
            uuid += BitConverter.ToString(buff).Replace("-", "");
            uuid += '-';

            buff = new byte[6];
            Buffer.BlockCopy(Bytestream, idx + 12, buff, 0, 6);
            uuid += BitConverter.ToString(buff).Replace("-", "");

            vmessItem.id = uuid.ToLower();
        }

        private static void Byte2alterID(ref byte[] Bytestream, VmessItem vmessItem)
        {
            byte[] tgt = { 0xFF, 0xF4 };
            int idx = ByteSearch(Bytestream, tgt);
            int aid = Convert.ToInt32(Bytestream[idx + 2]);
            vmessItem.alterId = aid;
        }

        private static void Byte2security(ref byte[] Bytestream, VmessItem vmessItem)
        {
            byte[] tgt = { 0xFF, 0xF5 };
            int idx = ByteSearch(Bytestream, tgt);
            switch (Bytestream[idx+2])
            {
                case 0x00:
                    vmessItem.security = "none";
                    break;
                case 0x01:
                    vmessItem.security = "aes-128-cfb";
                    break;
                case 0x02:
                    vmessItem.security = "aes-128-gcm";
                    break;
                case 0x03:
                    vmessItem.security = "chacha20-poly1305";
                    break;
            }
        }

        private static void Byte2Network(ref byte[] Bytestream, VmessItem vmessItem)
        {
            byte[] tgt = { 0xFF, 0xF6 };
            int idx = ByteSearch(Bytestream, tgt);
            switch (Bytestream[idx + 2])
            {
                case 0x00:
                    vmessItem.network = "tcp";
                    break;
                case 0x01:
                    vmessItem.network = "kcp";
                    break;
                case 0x02:
                    vmessItem.network = "ws";
                    break;
            }
        }

        private static void Byte2headerType(ref byte[] Bytestream, VmessItem vmessItem)
        {
            byte[] tgt = { 0xFF, 0xF7 };
            int idx = ByteSearch(Bytestream, tgt);
            switch (Bytestream[idx + 2])
            {
                case 0x00:
                    vmessItem.headerType = "none";
                    break;
                case 0x01:
                    vmessItem.headerType = "http";
                    break;
                case 0x02:
                    vmessItem.headerType = "srtp";
                    break;
                case 0x03:
                    vmessItem.headerType = "utp";
                    break;
                case 0x04:
                    vmessItem.headerType = "wechat-video";
                    break;
            }
        }

        private static void Byte2requestHost(ref byte[] Bytestream, VmessItem vmessItem)
        {
            byte[] route = { 0xFF, 0xF8 };
            int idx = ByteSearch(Bytestream, route);
            byte[] buff = new byte[Bytestream[idx + 2]];
            Buffer.BlockCopy(Bytestream, idx + 3, buff, 0, Bytestream[idx + 2]);
            vmessItem.requestHost = Encoding.ASCII.GetString(buff);
        }

        private static void Byte2streamSecurity(ref byte[] Bytestream, VmessItem vmessItem)
        {
            byte[] tgt = { 0xFF, 0xF9 };
            int idx = ByteSearch(Bytestream, tgt);
            switch (Bytestream[idx + 2])
            {
                case 0x00:
                    vmessItem.streamSecurity = "none";
                    break;
                case 0x01:
                    vmessItem.streamSecurity = "tls";
                    break;
            }
        }

        private static int ByteSearch(byte[] source, byte[] target, int start = 0)
        {
            int found = -1;
            bool matched = false;
            if (source.Length > 0 && target.Length > 0 && start <= (source.Length - target.Length) && source.Length >= target.Length)
            {
                for (int i = start; i <= source.Length - target.Length; i++)
                {
                    if (source[i] == target[0])
                    {
                        if (source.Length > 1)
                        {
                            matched = true;
                            for (int y = 1; y <= target.Length - 1; y++)
                            {
                                if (source[i + y] != target[y])
                                {
                                    matched = false;
                                    break;
                                }
                            }
                            if (matched)
                            {
                                found = i;
                                break;
                            }

                        }
                        else
                        {
                            found = i;
                            break;
                        }
                    }
                }
            }
            return found;
        }
    }

}
