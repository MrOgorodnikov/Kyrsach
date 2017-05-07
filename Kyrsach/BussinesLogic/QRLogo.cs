using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach.BussinesLogic
{
    public class QRLogo : IAdd
    {
        private Image Logo { get; set; }
        private Image QRCodeImage { get; set; }
        public Image QRWithLogo { get; set; }
        public QRLogo(Image logo, Image QRCodeImage)
        {
            Logo = logo;
            this.QRCodeImage = QRCodeImage;
        }

        public void Add()
        {
            var QR = GenerateQR(QRCodeImage, Logo.Height < Logo.Width ? Logo.Height : Logo.Width);
            var left = (Logo.Width - QR.Width) / 2;
            var top = (Logo.Height - QR.Height) / 2;

            Graphics g = Graphics.FromImage(Logo);
            g.DrawImage(QR, left, top);
            QRWithLogo = Logo;
        }

        private static Bitmap GenerateQR(Image QR, int logoSize)
        {
            return Img.ResizeImage(QR, logoSize/2, logoSize/2);
        }

    }
}
