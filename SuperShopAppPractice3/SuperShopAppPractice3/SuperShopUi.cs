using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopAppPractice3
{
    public partial class SuperShopUi : Form
    {
        private SuperShop superShop;
        private Product product;
        public SuperShopUi()
        {
            InitializeComponent();
        }

        
        private void ShopSaveButton_Click(object sender, EventArgs e)
        {
            superShop = new SuperShop();
            superShop.Name = nameTextBox.Text;
            superShop.Address = addressTextBox.Text;
            MessageBox.Show("Saved");
        }
        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            product = new Product();
            product.Product_id = Convert.ToInt32(itemTextBox.Text);
            product.Quantity = Convert.ToDouble(quantityTextBox.Text);
            superShop.AddProduct(product);
            itemTextBox.Clear();
            quantityTextBox.Clear();
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            //superShop = new SuperShop();
            ////superShop.GetProducts();
            MessageBox.Show(superShop.GetProducts());
        }
    }
}
