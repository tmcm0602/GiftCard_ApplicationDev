namespace GiftCard
{
    public partial class Form1 : Form
    {
        public Form1()
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
                    //MainForm mainform = new MainForm();
                    //mainform.Show();
                    HomePage homePage = new HomePage();
                    homePage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }
    }
}