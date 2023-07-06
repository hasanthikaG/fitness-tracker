using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness_tracker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string currentFolder = AppDomain.CurrentDomain.BaseDirectory;
            Console.Out.WriteLine(currentFolder);
            string image = Path.Combine(currentFolder, "main_fitness_tracker.png");
            pictureBox1.Image = Image.FromFile(image);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            this.Hide();
            register.Activate();
            register.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();
            login.Activate();
            login.ShowDialog();
            this.Close();
        }
    }
}
