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
                //needed to add my own paths to access the image
                new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\JBhifiGiftCard.png"},
                new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\AmzaonGiftCard.png"},
                new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\BingeGiftCard.png"},
                new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\KayoGiftCard.png"},
                new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\RebelGiftCard.png"},
                new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\WestfieldGiftCard.png"},

                new { ImagePath = "C:\\Users\\tmcm0\\OneDrive\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\KayoGiftCard.png" },
                new { ImagePath = "C:\\Users\\tmcm0\\OneDrive\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\KayoGiftCard.png" },
                new { ImagePath = "C:\\Users\\tmcm0\\OneDrive\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\BingeGiftCard.png" },
                new { ImagePath = "C:\\Users\\tmcm0\\OneDrive\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\WestfieldGiftCard.png" },
                new { ImagePath = "C:\\Users\\tmcm0\\OneDrive\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\JBhifiGiftCard.png" },
                new { ImagePath = "C:\\Users\\tmcm0\\OneDrive\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\RebelGiftCard.png" },
            };

            // Loop through the list of products and create a product item for each
            foreach (var product in products)
            {
                // Create a ProductItem UserControl or Panel containing an image, price, and a purchase button
                var productItem = new ProductItem
                {
                    ImagePath = product.ImagePath,
                    //Price = product.Price
                };


                flowLayoutPanel1.Controls.Add(productItem);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myGiftCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
