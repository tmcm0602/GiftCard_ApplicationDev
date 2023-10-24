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
            set { pictureBoxProduct.ImageLocation = value; pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom; }
        }

        // Property to set the price label text
        /*public double Price
        {
            get { return double.Parse(buttonPrice.Text); }
            set { buttonPrice.Text = value.ToString("C"); pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom; }
        }*/


        public event EventHandler buttonClicked;

        public ProductItem()
        {
            InitializeComponent();

        }


        private void ProductItem_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxProduct_Click(object sender, EventArgs e)
        {
            // Handle the click event. For example, open a new form.

            MessageBox.Show("You have selected this item"); // Show a product details form or perform your action here.
        }
    }
}
