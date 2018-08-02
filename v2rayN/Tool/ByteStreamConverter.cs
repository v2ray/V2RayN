using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using v2rayN.Mode;

namespace v2rayN.Tool
{
    public static class ByteStreamConverter
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
                ByteStream.Add(0x00);
                ByteStream.Add(0xFF);
                ByteStream.Add(0xF0);
                ByteStream.Add(0x04);
                foreach (string s in Address_buf)
                {
                    ByteStream.Add(Convert.ToByte(Int32.Parse(s)));
                }
            }

            catch (FormatException e)
            {
                ByteStream.Clear();
                byte[] Address_buf = Encoding.ASCII.GetBytes(vmessItem.address);
                ByteStream.Add(0x00);
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
            ByteStream.Add(0x00);
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF2);
            ByteStream.Add(Convert.ToByte(vmessItem.port >> 8));
            ByteStream.Add(Convert.ToByte(vmessItem.port % 0x100));
        }

        private static void uID2Byte(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            ByteStream.Add(0x00);
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF3);
            ByteStream.Add(0x10);
            string hexID = vmessItem.id.Replace("-", "");
            for (int i = 0; i < hexID.Length; i += 2)
                ByteStream.Add(Convert.ToByte(hexID.Substring(i, 2), 16));
        }

        private static void alterID2Byte(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            ByteStream.Add(0x00);
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF4);
            ByteStream.Add(Convert.ToByte(vmessItem.alterId));
        }

        private static void security2Byte(ref List<byte> ByteStream, VmessItem vmessItem)
        {
            ByteStream.Add(0x00);
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
            ByteStream.Add(0x00);
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
            ByteStream.Add(0x00);
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF7);
            switch (vmessItem.security)
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
                ByteStream.Add(0x00);
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
            ByteStream.Add(0x00);
            ByteStream.Add(0xFF);
            ByteStream.Add(0xF9);
            switch (vmessItem.security)
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
}
