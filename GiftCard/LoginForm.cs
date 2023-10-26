namespace GiftCard
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            using (var context = new GiftCardContext())
            {
                var user = context.users.FirstOrDefault(user => user.username == username && user.password == password);

                if (user != null)
                {
<<<<<<< HEAD:GiftCard/LoginForm.cs
                    //MainForm mainform = new MainForm();
                    //mainform.Show();
                    HomePage homePage = new HomePage(user.username);
=======
                    HomePage homePage = new HomePage(username);
>>>>>>> f10a3ed4a91f7a4c9b83237b185a7712c9618c5b:GiftCard/Form1.cs
                    homePage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}