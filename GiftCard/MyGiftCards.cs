using Azure.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GiftCard
{
    public partial class MyGiftCards : Form
    {
        private string loggedInUser;
        public MyGiftCards(string loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            viewMyGiftCards();
        }

        private void viewMyGiftCards()
        {

            List<GiftCardItem> giftCardItems = new List<GiftCardItem>();

            using (var context = new GiftCardContext())
            {
                var userGiftCards = context.UserGiftCards.Where(userGiftCard => userGiftCard.username == this.loggedInUser)
                    .Select(userGiftCard => new
                    {
                        giftCardId = userGiftCard.Giftcard_id,
                        AvailableFunds = userGiftCard.Giftcard_availablefunds
                    })
            .ToList();



                foreach (var userGiftCard in userGiftCards)
                {
                    var giftCard = context.GIFTCARD.FirstOrDefault(g => g.Id == userGiftCard.giftCardId);
                    if (giftCard != null)
                    {
                        var giftCardItem = new GiftCardItem
                        {
                            AvailableFunds = userGiftCard.AvailableFunds
                        };
                        string imagePath = GetImagePathByBrand(giftCard.Brand);

                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            giftCardItem.image = new Bitmap(imagePath);
                        }

                        giftCardItems.Add(giftCardItem);

                        giftCardItem.ItemClicked += (sender, e) =>
                        {
                            string imagePath = GetImagePathByBrand(giftCard.Brand);

                            GiftCardDetails giftcarddetails = new GiftCardDetails(giftCard, imagePath, this.loggedInUser);
                            giftcarddetails.Show();
                            this.Close();
                        };
                    }
                }
            }

            foreach (var giftCardItem in giftCardItems)
            {
                flowLayoutPanel1.Controls.Add(giftCardItem);
            }
        }

        private string GetImagePathByBrand(string brand)
        {
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
