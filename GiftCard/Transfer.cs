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
    public partial class Transfer : Form
    {

        private List<UserGiftCards> giftcards;
        private string code;
        public Transfer(List<UserGiftCards> usergiftCards, string code)
        {
            InitializeComponent();

            this.giftcards = usergiftCards;
            this.code = code;

            foreach (var userGiftCard in giftcards)
            {
                if (!userGiftCard.Giftcard_code.Equals(code))
                {
                    listBox1.Items.Add(getGiftCardName(userGiftCard.Giftcard_id) + ", " + userGiftCard.Giftcard_code + "");
                }
                else
                {
                    continue;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string getGiftCardName(int id)
        {
            string giftcard = "";
            using (var context = new GiftCardContext())
            {

                giftcard = context.GIFTCARD.Where(giftcard => giftcard.Id == id)
                    .Select(giftcard => giftcard.GiftCardName).FirstOrDefault();
            }
            return giftcard;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private UserGiftCards GetUserGiftCard()
        {
            foreach (var userGiftCard in giftcards)
            {
                if (userGiftCard.Giftcard_code.Equals(this.code))
                {
                    return userGiftCard;
                }
            }

            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedGiftCardCode = "";
            string code = "";

            if (listBox1.SelectedItem != null)
            {
                selectedGiftCardCode = listBox1.SelectedItem.ToString().Replace(" ", "");
                
                string[] codeParts = selectedGiftCardCode.Split(',');

                if (codeParts.Length > 0)
                {
                    code = codeParts[codeParts.Length - 1];
                    MessageBox.Show(code);
                }
                else
                {
                    MessageBox.Show("No comma-separated elements found.");
                }
            }
            else
            {
                MessageBox.Show("No GiftCard Selected");
            }

            if (Decimal.TryParse(textBox1.Text, out decimal amount))
            {
                using (var context = new GiftCardContext())
                {

                    var originalUserGiftCard = context.UserGiftCards.FirstOrDefault(ugc => ugc.Giftcard_code == this.code);

                    // Find the selected user gift card
                    var selectedUserGiftCard = context.UserGiftCards.FirstOrDefault(ugc => ugc.Giftcard_code == code);

                    if (originalUserGiftCard != null && selectedUserGiftCard != null)
                    {
                        originalUserGiftCard.Giftcard_availablefunds -= amount;
                        // Update the AvailableFunds with the new amount
                        selectedUserGiftCard.Giftcard_availablefunds += amount;

                        context.SaveChanges();

                        MessageBox.Show("Funds Successfully transferred");
                    }
                }
            }
            else
            {
                MessageBox.Show("Couldn't convert to Decimal");
            }
        }
    }
}
