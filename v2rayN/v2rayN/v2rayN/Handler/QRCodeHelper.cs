using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace v2rayN.Handler
{
    /// <summary>
    /// 含有QR码的描述类和包装编码和渲染
    /// </summary>
    public class QRCodeHelper
    {
        /// <summary>
        /// 获取二维码
        /// </summary>
        /// <param name="strContent">待编码的字符</param>
        /// <param name="ms">输出流</param>
        ///<returns>True if the encoding succeeded, false if the content is empty or too large to fit in a QR code</returns>
        public static bool GetQRCode(string strContent, MemoryStream ms)
        {
            try
            {
                ErrorCorrectionLevel Ecl = ErrorCorrectionLevel.M; //误差校正水平 
                string Content = strContent;//待编码内容
                QuietZoneModules QuietZones = QuietZoneModules.Two;  //空白区域 
                int ModuleSize = 12;//大小
                var encoder = new QrEncoder(Ecl);
                QrCode qr;
                if (encoder.TryEncode(Content, out qr))//对内容进行编码，并保存生成的矩阵
                {
                    var render = new GraphicsRenderer(new FixedModuleSize(ModuleSize, QuietZones));
                    render.WriteToStream(qr.Matrix, ImageFormat.Png, ms);
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取二维码
        /// </summary>
        /// <param name="strContent"></param>
        /// <returns></returns>
        public static Image GetQRCode(string strContent)
        {
            Image img = null;
            try
            {
                using (var ms = new MemoryStream())
                {
                    QRCodeHelper.GetQRCode(strContent, ms);
                    img = Image.FromStream(ms);
                    return img;
                }
            }
            catch
            {
                return img;
            }
        }
    }
}
