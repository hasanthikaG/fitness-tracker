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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainDashboard wk = new MainDashboard();
            this.Hide();
            wk.Activate();
            wk.ShowDialog();
            this.Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Workout";
            tabPage2.Text = "CheatMeal";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value || dateTimePicker2.Value == dateTimePicker1.Value)
            {
                MessageBox.Show("Date Selection is Invalid!");
            }
            else
            {
                List<WorkOutDetails> workoutList = WorkoutAdd.GetWorkOutList().
                    Where(item => item.Date >= dateTimePicker1.Value && item.Date <= dateTimePicker2.Value).ToList();

                List<CheatMealDetails> cheatMealList = CheatMealAdd.GetCheatMealList().
                   Where(item => item.Date >= dateTimePicker1.Value && item.Date <= dateTimePicker2.Value).ToList();

                dataGridView1.DataSource = workoutList;
                dataGridView2.DataSource = cheatMealList;
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            MainDashboard wk = new MainDashboard();
            this.Hide();
            wk.Activate();
            wk.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            this.Hide();
            mn.Activate();
            mn.ShowDialog();
            this.Close();
        }
    }
}
