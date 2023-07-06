using System.Text.Json;

namespace fitness_tracker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            User newUser = Register.GetUser();

            if (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Enter values for all fields");
            }
            else if (newUser.Email != tbEmail.Text || newUser.Password != tbPassword.Text)
            {
                MessageBox.Show("Email or Password is incorrect!");
            }
            else
            {
                MessageBox.Show("Login Successful");
                MainDashboard dBoard = new MainDashboard();

                this.Hide();
                dBoard.Activate();
                dBoard.ShowDialog();
                this.Close();
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
           Main mn = new Main();
            this.Hide();
            mn.Activate();
            mn.ShowDialog();
            this.Close();
        }
    }
}