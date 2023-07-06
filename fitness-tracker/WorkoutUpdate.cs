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
    public partial class WorkoutUpdate : Form
    {
        public WorkoutUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkoutDashboard wk = new WorkoutDashboard();
            this.Hide();
            wk.Activate();
            wk.ShowDialog();
            this.Close();
        }
    }
}
