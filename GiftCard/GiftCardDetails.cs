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
                pictureBox1.Image = value; pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;//sets the image to the imagepath and makes it fit the picturebox element
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewGiftCardDetails()
        {

            string name = this.giftcard.GiftCardName; //retrieves giftcard name
            label2.Text = name; // sets the giftcard name
            string description = this.giftcard.GiftCardDescription; //retrieves giftcard description
            label5.Text = description; //sets giftcard description

            using (var context = new GiftCardContext())
            {
                var usergiftCard = context.UserGiftCards.Where(usergiftcard => usergiftcard.Giftcard_id == this.giftcard.Id && usergiftcard.username == this.loggedInUser)
                    .Select(usergiftcard => new
                    {
                        usergiftcard.Giftcard_availablefunds,
                        usergiftcard.Giftcard_code
                    }).FirstOrDefault(); // searches UserGiftCard table for the giftcard that matches that giftcard id and belongs to the logged in user

                label3.Text = "$" + usergiftCard.Giftcard_availablefunds.ToString(); //sets the label to the available funds for the giftcard found above
                label1.Text = usergiftCard.Giftcard_code.ToString(); //sets the label to the giftcard code for that specific card found above
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
            Transfer transfer = new Transfer(getUserGiftCards(), label1.Text); // opens the transfer form for a specific giftcard and giftcard code
            transfer.Show();
            this.Close();
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
                    }).ToList(); // Searches Usergiftcards table with the username to find all the gift cards assigned to that user


            }
            return usergiftcard;
        }

    }
}
