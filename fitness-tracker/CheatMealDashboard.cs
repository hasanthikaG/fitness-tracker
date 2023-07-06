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
    public partial class CheatMealDashboard : Form
    {
        public CheatMealDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainDashboard md = new MainDashboard();
            this.Hide();
            md.Activate();
            md.ShowDialog();
            this.Close();
        }
    }
}
