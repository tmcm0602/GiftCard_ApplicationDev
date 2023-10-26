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
            
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(username);
            mainForm.Show();
        }

        private void GiftButton_Click(Object sender, EventArgs e)
        {

        }
    }
}
