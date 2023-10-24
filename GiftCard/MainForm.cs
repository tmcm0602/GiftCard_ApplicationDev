using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftCard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddProductItems();
           
        }

        private void AddProductItems()
        {
            // Create a list of product information (image path, price, etc.)
            var products = new[]
            {
                new { ImagePath = "C:\\Users\\tmcm0\\OneDrive\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\KayoGiftCard.png", Price = 25.00 },
                new { ImagePath = "C:\\Users\\tmcm0\\OneDrive\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\KayoGiftCard.png", Price = 50.00 },
                // Add more products here
            };

            // Loop through the list of products and create a product item for each
            foreach (var product in products)
            {
                // Create a ProductItem UserControl or Panel containing an image, price, and a purchase button
                var productItem = new ProductItem
                {
                    ImagePath = product.ImagePath,
                    Price = product.Price
                };

                // Add the product item to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(productItem);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
