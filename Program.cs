using QRCoder;
using System.Drawing;

namespace QRCodeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

         QRCodeGenerator qrGenerator = new QRCodeGenerator();
         QRCodeData qrCodeData = qrGenerator.CreateQrCode("Te quiero Golondrina!", QRCodeGenerator.ECCLevel.Q);

         QRCode qrCode = new QRCode(qrCodeData);
         Bitmap qrCodeImage = qrCode.GetGraphic(20);
         qrCodeImage.Save("QR.png", System.Drawing.Imaging.ImageFormat.Png);

        }
    }
}
