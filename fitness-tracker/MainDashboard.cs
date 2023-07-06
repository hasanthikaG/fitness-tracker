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
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkoutDashboard wk = new WorkoutDashboard();

            this.Hide();
            wk.Activate();
            wk.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            this.Hide();
            mn.Activate();
            mn.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheatMeal cm = new CheatMeal();

            this.Hide();
            cm.Activate();
            cm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report report = new Report();

            this.Hide();
            report.Activate();
            report.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FitnessStatusPrediction report = new FitnessStatusPrediction();

            this.Hide();
            report.Activate();
            report.ShowDialog();
            this.Close();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            label1.Text = Register.GetUser().FName;
        }
    }
}
