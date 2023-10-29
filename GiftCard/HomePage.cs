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
    public partial class HomePage : Form
    {
        private string username;
        public HomePage(string username)
        {
            this.username = username;
            InitializeComponent();
        }


        private void ViewButton_Click(object sender, EventArgs e)
        {
            new MyGiftCards(this.username).Show();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(this.username);
            mainForm.Show();
        }

        private void GiftButton_Click(Object sender, EventArgs e)
        {
            GiftFriends giftFriends = new GiftFriends(this.username);
            giftFriends.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void ExitButton_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
