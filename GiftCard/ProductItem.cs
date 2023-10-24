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
    public partial class ProductItem : UserControl
    {

        public string ImagePath
        {
            get { return pictureBoxProduct.ImageLocation; }
            set { pictureBoxProduct.ImageLocation = value; }
        }

        // Property to set the price label text
        public double Price
        {
            get { return double.Parse(buttonPrice.Text); }
            set { buttonPrice.Text = value.ToString("C"); pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom; } // Display price as currency
        }

        // Event handler for the purchase button
        public event EventHandler PurchaseClicked;

        public ProductItem()
        {
            InitializeComponent();
        }


        private void ProductItem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseClicked?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("You have bought this product");
        }
    }
}
