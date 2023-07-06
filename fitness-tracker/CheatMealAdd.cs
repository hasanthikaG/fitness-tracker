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
    public partial class CheatMeal : Form
    {
        public CheatMeal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheatMealDashboard cm = new CheatMealDashboard();

            this.Hide();
            cm.Activate();
            cm.ShowDialog();
            this.Close();
        }
    }
}
