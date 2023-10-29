using Microsoft.IdentityModel.Tokens;
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
    public partial class GiftFriends : Form
    {
        private string loggedInUser;
        private string friendUsername;
        private List<GiftCardItem> giftCardItems;
        private bool userExist = false;
        public GiftFriends(string loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            ViewMyGiftCards();
            SelectGiftCard();

                
        }
        private void viewGiftCardsPanel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            friendUsername = usernameBox.Text;
            using (var context = new GiftCardContext())
            {
                var user = context.users.FirstOrDefault(user => user.username == friendUsername);

                if (user != null)
                {
                    userExist = true;
                    informationBox.Text = "The user exists. Please select one of your following gift cards to send to your friend!";
                }
                else
                {
                    MessageBox.Show("The user does not exist. Please enter a valid username.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void SelectGiftCard()
        {
            foreach (var card in giftCardItems)
            {

                card.ItemClicked += (sender, e) =>
                {
                    if (usernameBox.Text == string.Empty || userExist == false)
                    {
                        MessageBox.Show("Please enter valid username of the user that you want to gift!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure that you want to send it?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            using (var context = new GiftCardContext())
                            {
                                var userGiftCard = context.UserGiftCards.FirstOrDefault(userGiftCard => userGiftCard.id == card.Id);

                                Random random = new Random();
                                int num = random.Next(50000, 100000);
                                if (userGiftCard != null)
                                {
                                    var newUserGiftCard = new UserGiftCards() { id = num, username = usernameBox.Text, Giftcard_id = userGiftCard.Giftcard_id, Giftcard_availablefunds = userGiftCard.Giftcard_availablefunds, Giftcard_code = userGiftCard.Giftcard_code };
                                    context.UserGiftCards.Add(newUserGiftCard);

                                    context.UserGiftCards.Remove(userGiftCard);
                                    context.SaveChanges();
                                }

                            }
                            this.Close();


                        }
                        else if (result == DialogResult.No)
                        {
                            userExist = false;       //set this to false again to prevent working again the user inputs invalid username
                            usernameBox.Text = string.Empty;
                            informationBox.Text = string.Empty; 
                        }
                    }

                };

            }
        }



        private void ViewMyGiftCards()
        {

            giftCardItems = new List<GiftCardItem>();

            using (var context = new GiftCardContext())
            {
                var userGiftCards = context.UserGiftCards.Where(userGiftCard => userGiftCard.username == this.loggedInUser)
                    .Select(userGiftCard => new
                    {
                        giftCardId = userGiftCard.Giftcard_id,
                        AvailableFunds = userGiftCard.Giftcard_availablefunds,
                        id = userGiftCard.id

                    })
            .ToList();

                foreach (var userGiftCard in userGiftCards)
                {
                    var giftCard = context.GIFTCARD.FirstOrDefault(g => g.Id == userGiftCard.giftCardId);
                    if (giftCard != null)
                    {
                        var giftCardItem = new GiftCardItem
                        {
                            AvailableFunds = userGiftCard.AvailableFunds, // Retrieve available funds from UserGiftCards
                            Id = userGiftCard.id
                        };
                        string imagePath = GetImagePathByBrand(giftCard.Brand);

                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            giftCardItem.image = new Bitmap(imagePath);
                        }

                        giftCardItems.Add(giftCardItem);
                    }
                }
            }

            foreach (var giftCardItem in giftCardItems)
            {
                viewGiftCardsPanel.Controls.Add(giftCardItem);
            }
        }

        private string GetImagePathByBrand(string brand)
        {
            // Map the brand name to the corresponding image path.
            switch (brand.ToLower())
            {
                case "kayo":
                    return "Images/KayoGiftCard.png";
                case "binge":
                    return "Images/BingeGiftCard.png";
                case "rebel":
                    return "Images/RebelGiftCard.png";
                case "westfield":
                    return "Images/WestfieldGiftCard.png";
                case "amazon":
                    return "Images/AmazonGiftCard.png";
                case "jbhifi":
                    return "Images/JBhifiGiftCard.png";
                default:
                    return null;
            }
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
