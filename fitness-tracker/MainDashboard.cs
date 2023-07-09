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
            CheatMealDashboard cm = new CheatMealDashboard();

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

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            label1.Text = Register.GetUser().FName;
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill all the fields!");
            }else
            {
                double weight = Double.Parse(textBox3.Text);
                double height = Double.Parse(textBox1.Text);

                double bmi = weight / (height * height);

                string fitnesStatus = "";
                string comment = "";

                if (bmi < 18.5)
                {
                    fitnesStatus = "Underweight";
                    comment = "Insufficient body weight relative to height";
                }
                else if (18.5 > bmi && bmi < 24.9)
                {
                    fitnesStatus = "Normal Weight";
                    comment = "Considered as a healthy fitness";
                }
                else if (25.0 > bmi && bmi < 29.9)
                {
                    fitnesStatus = "Overweight";
                    comment = "Excess body weight relative to height";
                }
                else if (bmi > 30.0)
                {
                    fitnesStatus = "Obese";
                    comment = "Significantly increased level of body weight relative to height";
                }

                label3.Text = "Fitness Status";
                label5.Text = "Comment";
                label4.Text = fitnesStatus;
                label6.Text = comment;
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
