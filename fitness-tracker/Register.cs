using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            user.UserId = 1;
            user.FName = tbFName.Text;
            user.LName = tbLName.Text;
            user.Email = tbEmail.Text;
            user.Password = tbPwd.Text;

            MessageBox.Show("User Registered Successfully!");

            Login lgn = new Login();

            this.Hide();
            lgn.Activate();
            lgn.ShowDialog();
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
