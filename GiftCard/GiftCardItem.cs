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
    public partial class GiftCardItem : UserControl
    {
        private int id;
        public event EventHandler CardClicked;
        public Image image
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; }
        }

        // Property to set the price label text
        public decimal AvailableFunds
        {
            get { return decimal.Parse(label1.Text); }
            set { label1.Text = value.ToString("C"); }
        }

        public int Id
        {
            get { return id;}
            set { id = value;}
        }

        public GiftCardItem()
        {
            InitializeComponent();
            pictureBox1.Width = this.Width;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
