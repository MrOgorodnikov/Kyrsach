using BarcodeLib.Barcode;
using BarcodeLib.BarcodeReader;
using Kyrsach.BussinesLogic;
using Kyrsach.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();        

        private List<string> allEAN13 = new List<string>();
        private TransferProduct product;

        private void Form1_Load(object sender, EventArgs e) => allEAN13 = BussinesLogic.Product.GetAllEAN13();

        private string currentEAN13 = "";
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (allEAN13.Contains(ean13TextBox.Text))
            {
                DrawQR(Color.Black, Color.White);
                trackBar1.Visible = true;
                backgruondColorButton.Visible = true;
                moduleColorButton.Visible = true;
                applyButton.Visible = true;
            }
            else
            {
                DialogResult result = MessageBox.Show("Додати до бази даних новий товар?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)                
                    new FormAddNewProduct(ean13TextBox.Text).ShowDialog();
                else
                {
                    QRCode barcode = Img.QRCodeInit();
                    barcode.Data = ean13TextBox.Text;
                    QRPictureBox.Image = barcode.drawBarcode();
                    trackBar1.Visible = true;
                    backgruondColorButton.Visible = true;
                    moduleColorButton.Visible = true;
                    applyButton.Visible = true;
                }
            }
        }
       
        private void DrawQR(Color backgroundColor, Color moduleColor)
        {
            var product = new BussinesLogic.Product(ean13TextBox.Text);
            QRCode barcode = Img.QRCodeInit(backgroundColor, moduleColor);
            barcode.Data = ean13TextBox.Text;
            currentEAN13 = ean13TextBox.Text;
            var x = product.GetProductType();

            var logoPath = $@"{System.IO.Directory.GetCurrentDirectory()}\Logos\{x.Type.ToString()}.png";
            var QRWithLogo = new QRLogo(Image.FromFile(logoPath), barcode.drawBarcode());
            QRWithLogo.Add();
            QRPictureBox.Image = QRWithLogo.QRWithLogo;            
        }

        private void Form1_Activated(object sender, EventArgs e) => allEAN13 = BussinesLogic.Product.GetAllEAN13();
        
        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {   
                EAN13PictureBox.Image = new Bitmap(open.FileName);
                ean13TextBox.Text = Img.ReadEAN13(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            using (var form = new FormCamera())
            {
                try
                {                    
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        product = form.Product;
                        EAN13PictureBox.Image = product.EAN13Image;
                        if (product.EAN13.Length == 0)
                            try { ean13TextBox.Text = Img.ReadEAN13(product.EAN13Image); }
                            catch { MessageBox.Show("Error, make new photo"); }
                        else
                            ean13TextBox.Text = product.EAN13;
                    }
                }
                catch { }                
            }
        }
        double previousZoom = 1;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var currentZoom = (double)trackBar1.Value / 100;
            var zoom = currentZoom / previousZoom;
            previousZoom = currentZoom;
            var lastImg = QRPictureBox.Image;
            
            QRPictureBox.Size = new Size(
                Convert.ToInt32(QRPictureBox.Width * zoom), 
                Convert.ToInt32(QRPictureBox.Height * zoom)
                );
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void backgruondColorButton_Click(object sender, EventArgs e)
        {            
            DialogResult result = colorDialog1.ShowDialog();            
            if (result == DialogResult.OK)            
                backgruondColorButton.BackColor = colorDialog1.Color;               
            
        }

        private void moduleColorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                moduleColorButton.BackColor = colorDialog1.Color;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            DrawQR(backgruondColorButton.BackColor, moduleColorButton.BackColor);
        }
    }
}
