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
        private string giftcardName;
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

        //public string[] ItemName
        //{
        //    get { return itemName; }
        //}

        public string GiftcardName
        {
            get { return giftcardName;}
            set { giftcardName = value;}
        }


        public event EventHandler buttonClicked;
        public event EventHandler ItemClicked;

        public ProductItem()
        {
            //itemName = new[] { "JBhifi", "Amazon", "Binge", "Kayo", "Rebel", "WestField" }; 
            InitializeComponent();

        }


        private void ProductItem_Load(object sender, EventArgs e)
        {

        }

        //private void pictureBoxProduct_Click(object sender, EventArgs e)
        //{
        //    //ProductDetails productDetails = new ProductDetails();
        //    //productDetails.Show();

        //    ProductDetail productDetail = new ProductDetail();
        //    productDetail.Show();


        //}

        private void product_CLick(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
