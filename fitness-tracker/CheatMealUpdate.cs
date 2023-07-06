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
    public partial class CheatMealUpdate : Form
    {
        public CheatMealUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheatMealDashboard md = new CheatMealDashboard();
            this.Hide();
            md.Activate();
            md.ShowDialog();
            this.Close();
        }
    }
}
