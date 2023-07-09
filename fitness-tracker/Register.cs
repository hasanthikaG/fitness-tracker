using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness_tracker
{
    public partial class Register : Form
    {
        private static User user = new User();
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            this.Hide();
            mn.Activate();
            mn.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbFName.Text) || String.IsNullOrEmpty(tbLName.Text) || String.IsNullOrEmpty(tbFName.Text) || String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrEmpty(tbPwd.Text))
            {
                MessageBox.Show("Please fill all the fields!");
            }
            else if (!new EmailAddressAttribute().IsValid(tbEmail.Text))
            {
                MessageBox.Show("Email is invalid!");
            }
            else if (tbPwd.Text.Length < 3)
            {
                MessageBox.Show("Password must contain atleast 3 characters!");
            }
            else
            {
                user.UserId = 1;
                user.FName = tbFName.Text;
                user.LName = tbLName.Text;
                user.Email = tbEmail.Text;
                user.Password = tbPwd.Text;

                Login lgn = new Login();
                this.Hide();
                lgn.Activate();
                lgn.ShowDialog();
                this.Close();

            }


        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        public static User GetUser()
        {
            return user;
        }
    }
}
