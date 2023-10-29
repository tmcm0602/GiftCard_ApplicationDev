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
    public partial class GiftCardItem : UserControl //class is used to display all the gift cards in the mygiftcards form by creating a small form to represent each card
    {
        private int id;
        public event EventHandler CardClicked;
        public Image image
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; } //sets the image for the picture box 
        }

        // Property to set the price label text
        public decimal AvailableFunds
        {
            get { return decimal.Parse(label1.Text); }
            set { label1.Text = value.ToString("C"); } //sets the label to the funds for that specific card
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public GiftCardItem()
        {
            InitializeComponent();
            pictureBox1.Width = this.Width; //sizes the image to the size of the user control
        }

        public event EventHandler ItemClicked;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, EventArgs.Empty); //when an giftcard is selected in the MyGiftCard page it activates this tell the MyGiftCard page that it was selected
            CardClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
