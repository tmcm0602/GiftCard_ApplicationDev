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
        private string username;
        public MainForm(string username)
        {
            this.username = username;
            InitializeComponent();
            AddProductItems();
            
        }

        private void AddProductItems()
        {
            // Create a list of product information (image path, price, etc.)
            string[] giftCards = new[] { "JBhifi", "Amazon", "Binge", "Kayo", "Rebel", "WestField", "JBhifi", "Amazon", "Binge", "Kayo", "Rebel", "WestField" };
            var products = new[]
            {   
                //needed to add my own paths to access the image
                /*new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\JBhifiGiftCard.png"},
                new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\AmzaonGiftCard.png"},
                new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\BingeGiftCard.png"},
                new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\KayoGiftCard.png"},
                new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\RebelGiftCard.png"},
                new { ImagePath  = "C:\\Users\\Pyae\\Documents\\GitHub\\GiftCard_ApplicationDev\\GiftCard\\Images\\WestfieldGiftCard.png"},*/


                new { ImagePath = "Images/AmzaonGiftCard.png" },
                new { ImagePath = "Images/KayoGiftCard.png" },
                new { ImagePath = "Images/BingeGiftCard.png" },
                new { ImagePath = "Images/WestfieldGiftCard.png" },
                new { ImagePath = "Images/JBhifiGiftCard.png" },
                new { ImagePath = "Images/RebelGiftCard.png" },
            };

            int n = 0;
            // Loop through the list of products and create a product item for each
            foreach (var product in products)
            {
                // Create a ProductItem UserControl or Panel containing an image, price, and a purchase button
                var productItem = new ProductItem
                {
                    ImagePath = product.ImagePath,
                    GiftcardName = giftCards[n],
                    //Price = product.Price
                };
                n++;


                productItem.ItemClicked += (sender, e) =>
                {
                    //MessageBox.Show(productItem.GiftcardName);
                    ProductDetail productDetail = new ProductDetail(productItem.GiftcardName, username);
                    productDetail.Show();


                };

                flowLayoutPanel1.Controls.Add(productItem);

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myGiftCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
