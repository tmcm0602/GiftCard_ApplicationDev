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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


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

                /* usergiftCardIds = context.UserGiftCards.Where(usergiftCardIds => usergiftCardIds.username == this.loggedInUser)
                                 .Select(usergiftCardIds => usergiftCardIds.Giftcard_id).ToList();

                 List<Double> usergiftCardFunds = context.UserGiftCards.Where(usergiftCardFunds => usergiftCardFunds.username == this.loggedInUser)
                                 .Select(usergiftCardFunds => usergiftCardFunds.Giftcard_availablefunds).ToList();*/

                foreach (var userGiftCard in userGiftCards)
                    {
                    var giftCard = context.GIFTCARD.FirstOrDefault(g => g.Id == userGiftCard.giftCardId);
                        if (giftCard != null)
                        {
                            var giftCardItem = new GiftCardItem
                            {
                                AvailableFunds = userGiftCard.AvailableFunds // Retrieve available funds from UserGiftCards
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
                flowLayoutPanel1.Controls.Add(giftCardItem);
            }




            //Form form = new Form(giftcard GiftCard) 
            //form.show();

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
                    return null; // You can return a default image for unknown brands if needed.
            }
        }
    }
}
