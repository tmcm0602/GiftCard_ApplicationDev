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
                    listBox1.Items.Add(getGiftCardName(userGiftCard.Giftcard_id) + ", " + userGiftCard.Giftcard_code + ""); //adds giftcards to the listbox excluding the original giftcard selected in the MyGiftCard page
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

        private string getGiftCardName(int id) //returns the giftcard name in the giftcard table for the usergiftcard by using the giftcard_id
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

        private UserGiftCards GetUserGiftCard() //retrieves the giftcard selected in the MyGiftCard page
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
                selectedGiftCardCode = listBox1.SelectedItem.ToString().Replace(" ", ""); //retrieves the giftcard selected in the list box and removes whitespace

                string[] codeParts = selectedGiftCardCode.Split(','); //splits the giftcard name and giftcard code

                if (codeParts.Length > 0)
                {
                    code = codeParts[codeParts.Length - 1]; //returns the giftcard code
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

            if (Decimal.TryParse(textBox1.Text, out decimal amount)) // converts the amount entered in the textbox to the type decimal
            {
                if (GetUserGiftCard().Giftcard_availablefunds >= amount)
                {
                    using (var context = new GiftCardContext())
                    {

                        var originalUserGiftCard = context.UserGiftCards.FirstOrDefault(usergiftcard => usergiftcard.Giftcard_code == this.code);


                        var selectedUserGiftCard = context.UserGiftCards.FirstOrDefault(usergiftcard => usergiftcard.Giftcard_code == code);

                        if (originalUserGiftCard != null && selectedUserGiftCard != null)
                        {
                            originalUserGiftCard.Giftcard_availablefunds -= amount; //removes the funds from the original giftcard

                            selectedUserGiftCard.Giftcard_availablefunds += amount; //adds those funds to the giftcard selected

                            context.SaveChanges(); //updates the table

                            MessageBox.Show("Funds Successfully transferred");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Not enough funds");
                }
            }
            else
            {
                MessageBox.Show("Couldn't convert to Decimal");
            }
            MyGiftCards mygiftcards = new MyGiftCards(GetUserGiftCard().username);
            mygiftcards.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
