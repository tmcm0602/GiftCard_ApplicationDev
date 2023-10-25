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
        public ProductDetail(string cardName)
        {
            InitializeComponent();
            label1.Text = cardName + " Gift Card";
            DisplayDetails(cardName);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DisplayDetails(string cardName)

        {
            using (var context = new GiftCardContext())

            {
                //var giftCardData = context.GiftCards.Where(giftCard => giftCard.GiftCardBrand == cardName);


                //stuck here
                //var giftCardData = context.GiftCards.Where(giftCard => giftCard.GiftCardBrand == cardName)
                //                .Select(giftCard => new
                //                {
                //                    giftCard.GiftCardBrand,
                //                    giftCard.GiftCardName,
                //                    giftCard.GiftCardDescription
                //                }).ToList();

                //textBox3.Text = giftCardData.GiftCardBrand;
                //richTextBox1.Text = giftCardData;

            }
        }
    }
}
