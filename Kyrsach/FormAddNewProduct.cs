using Kyrsach.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach
{
    public partial class FormAddNewProduct : Form
    {
        private List<ProductType> allProductTypes = new List<ProductType>();
        public FormAddNewProduct(string ean13)
        {
            InitializeComponent();
            EAN13TextBox.Text = ean13;
        }

        private void FormAddNewProduct_Load(object sender, EventArgs e)
        {
            allProductTypes = BussinesLogic.ProductType.GetAllProductTypes();
            foreach (var type in allProductTypes)
            {
                productTypeComboBox.Items.Add(type.Type);
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            BussinesLogic.Product.Add(
                new Product
                {
                    Name = nameTextBox.Text,
                    EAN13 = EAN13TextBox.Text,
                    Manufacturer = ManufacturerTextBox.Text,
                    Price = Convert.ToDouble(PriceTextBox.Text),
                    ShelfLifeInDays = Convert.ToInt32(ShelfLifeTextBox.Text),
                    ProductTypeId = allProductTypes
                        .FirstOrDefault(pt => pt.Type == productTypeComboBox.SelectedItem.ToString())
                        .Id
                });
        }
    }
}
