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
    public partial class ProductDetail : Form
    {
        private string cardBrand;
        private string userName;
        public ProductDetail(string cardName, string username)
        {
            InitializeComponent();
            userName = username;
            cardBrand = cardName;
            label1.Text = cardName + " Gift Card";
            DisplayDetails(cardName);
            DisplayWalletOptions(cardName);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void DisplayDetails(string cardName)
        {
            using (var context = new GiftCardContext())
            {
                //var giftCardData = context.GiftCards.Where(giftCard => giftCard.GiftCardBrand == cardName);
                var giftCardData = context.GIFTCARD.Where(giftCard => giftCard.Brand == cardName)
                                .Select(giftCard => new
                                {
                                    giftCard.Brand,
                                    giftCard.GiftCardName,
                                    giftCard.GiftCardDescription
                                }).ToList();

                if (giftCardData != null)
                {
                    textBox2.Text = giftCardData[0].Brand;
                    textBox3.Text = giftCardData[0].GiftCardName;
                    richTextBox1.Text = giftCardData[0].GiftCardDescription;
                }


            }
        }

        private void DisplayWalletOptions(string cardName)
        {
            using (var context = new GiftCardContext())
            {
                var giftCardWallet = context.GIFTCARD.Where(giftcard => giftcard.Brand == cardName)
                                    .Select(giftCard => giftCard.GiftCardValue).ToList();

                foreach (var item in giftCardWallet)
                {
                    walletOptions.Items.Add(item);
                }
            }


        }

        private string SelectWallet()
        {
            double totalPrice = 0.0;
            string receipt = "Your Order Details: \n\n";


            foreach (int item in walletOptions.SelectedIndices)
            {
                receipt = receipt + "$" + walletOptions.Items[item].ToString() + " Gift Card" + "\n";
                totalPrice += Convert.ToDouble(walletOptions.Items[item].ToString());
                using (var context = new GiftCardContext())
                {
                    var userGiftCard = context.GIFTCARD
                                      .Where(giftCard => giftCard.Brand == cardBrand && giftCard.GiftCardValue == Convert.ToInt32(walletOptions.Items[item]))
                                      .Select(giftCard => new
                                      {
                                          giftCard.Id,
                                          giftCard.GiftCardValue
                                      }).ToList();
                    Random random = new Random();
                    int num = random.Next(50000, 100000);
                    var userCard = new UserGiftCards() { id = num, username = userName, Giftcard_id = userGiftCard[0].Id, Giftcard_availablefunds = userGiftCard[0].GiftCardValue };
                    context.UserGiftCards.Add(userCard);
                    context.SaveChanges();
                }
                //var userCard = new UserGiftCard () {id = 1111, username = "Matt22", GiftCard_Id = userGiftCar }
            }
            receipt += "Total Price is $" + totalPrice + ".\n\nSuccessfully Purchased Gift Cards!!";
            return receipt;
        }

        private void Purchase_Click(Object sender, EventArgs e)
        {
            string receipt = SelectWallet();
            richTextBox2.Text = receipt;
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}