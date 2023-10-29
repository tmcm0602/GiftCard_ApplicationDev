using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftCard
{
    public partial class GiftCardDetails : Form
    {
        private GiftCard giftcard;
        private string loggedInUser;
        public GiftCardDetails(GiftCard giftcard, string imagePath, string username)
        {
            InitializeComponent();
            this.giftcard = giftcard;
            this.loggedInUser = username;
            viewGiftCardDetails();

            if (!string.IsNullOrEmpty(imagePath))
            {
                Image value = Image.FromFile(imagePath);
                pictureBox1.Image = value; pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewGiftCardDetails()
        {

            string name = this.giftcard.GiftCardName;
            label2.Text = name;
            string description = this.giftcard.GiftCardDescription;
            label5.Text = description;

            using (var context = new GiftCardContext())
            {
                var usergiftCard = context.UserGiftCards.Where(usergiftcard => usergiftcard.Giftcard_id == this.giftcard.Id && usergiftcard.username == this.loggedInUser)
                    .Select(usergiftcard => new
                    {
                        usergiftcard.Giftcard_availablefunds,
                        usergiftcard.Giftcard_code
                    }).FirstOrDefault();

                label3.Text = "$" + usergiftCard.Giftcard_availablefunds.ToString();
                label1.Text = usergiftCard.Giftcard_code.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GiftCardDetails_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer(getUserGiftCards(), label1.Text);
            transfer.Show();
        }

        private List<UserGiftCards> getUserGiftCards()
        {
            List<UserGiftCards> usergiftcard = new List<UserGiftCards>();

            using (var context = new GiftCardContext())
            {

                usergiftcard = context.UserGiftCards.Where(usergiftcard => usergiftcard.username == this.loggedInUser)
                    .Select(usergiftcard => new UserGiftCards
                    {
                        id = usergiftcard.id,
                        username = usergiftcard.username,
                        Giftcard_id = usergiftcard.Giftcard_id,
                        Giftcard_availablefunds = usergiftcard.Giftcard_availablefunds,
                        Giftcard_code = usergiftcard.Giftcard_code.ToString()
                    }).ToList();


            }
            return usergiftcard;
        }
        
    }
}
