using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness_tracker
{
    public partial class WorkoutAdd : Form
    {
        User newUser = Register.GetUser();
        private static List<WorkOutDetails> workoutList = new List<WorkOutDetails>();
        public WorkoutAdd()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            validateInputFields();
            List<DateTime> workoutDays = new List<DateTime>();
            if (cmWKType.Text == "Recurring")
            {
                workoutDays = calculateRecurringWorkoutDays();
            }
            else if (cmWKType.Text == "One-Off")
            {
                workoutDays.Add(dateTimePicker1.Value);
            }

            foreach (DateTime day in workoutDays)
            {
                WorkOutDetails workout = new WorkOutDetails();
                Random random = new Random();
                workout.UserId = newUser.UserId;
                workout.WorkoutId = $"Workout-{random.Next(0, 100)}";
                workout.WorkoutName = tbWKName.Text;
                workout.WorkoutDescription = tbWKDescription.Text;
                workout.BodyWeight = Double.Parse(tbBodyWeight.Text);
                workout.Status = cbStatus.Text;
                workout.DurationInHours = Double.Parse(tbDuration.Text);
                workout.Date = day;
                workoutList.Add(workout);
            }

            WorkoutDashboard wk = new WorkoutDashboard();
            this.Hide();
            wk.Activate();
            wk.ShowDialog();
            this.Close();

        }

        private void validateInputFields()
        {

            if (
                string.IsNullOrEmpty(tbBodyWeight.Text) ||
                string.IsNullOrEmpty(tbWKName.Text) ||
                string.IsNullOrEmpty(cmWKType.Text) ||
                string.IsNullOrEmpty(tbDuration.Text) ||
                string.IsNullOrEmpty(cbStatus.Text)
                )
            {
                MessageBox.Show("Enter all required fields");

            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewWorkout_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
            label11.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            checkedListBox1.Visible = false;
            label12.Visible = false;

            if (newUser != null)
            {
                label1.Text = newUser.UserId.ToString();
                label6.Text = newUser.FName;
            }
            else
            {
                label1.Text = "";
                userId.Text = "";
            }

        }

        public static List<WorkOutDetails> GetWorkOutList()
        {
            return workoutList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkoutDashboard wk = new WorkoutDashboard();
            this.Hide();
            wk.Activate();
            wk.ShowDialog();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmWKType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmWKType.SelectedItem.ToString()!;


            if (selectedType == "Recurring")
            {
                label10.Visible = true;
                label11.Visible = true;
                dateTimePicker2.Visible = true;
                dateTimePicker3.Visible = true;
                checkedListBox1.Visible = true;
                label12.Visible = true;
                dateTimePicker1.Visible = false;
                label9.Visible = false;
            }
            else if (selectedType == "One-Off")
            {
                label10.Visible = false;
                label11.Visible = false;
                dateTimePicker2.Visible = false;
                dateTimePicker3.Visible = false;
                checkedListBox1.Visible = false;
                label12.Visible = false;
                label9.Visible = true;
                dateTimePicker1.Visible = true;
            }


        }

        private List<DateTime> calculateRecurringWorkoutDays()
        {
            List<DateTime> workoutDays = new List<DateTime>();
            List<string> selectedDays = getSelectedDays();
            DateTime fromDate = dateTimePicker2.Value;
            DateTime toDate = dateTimePicker3.Value;

            workoutDays.Add(fromDate);
            DateTime currentDate = fromDate;
            while (currentDate <= toDate)
            {
                foreach (string day in selectedDays)
                {
                    if (currentDate.DayOfWeek.ToString() == day)
                    {
                        workoutDays.Add(currentDate);
                    }
                }

                currentDate = currentDate.AddDays(1);

            }


            return workoutDays;

        }

        private List<string> getSelectedDays()
        {
            List<string> selectedDays = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string day = checkedListBox1.Items[i].ToString()!;
                    selectedDays.Add(day);
                }
            }
            return selectedDays;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainDashboard db = new MainDashboard();
            this.Hide();
            db.Activate();
            db.ShowDialog();
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            WorkoutDashboard wk = new WorkoutDashboard();
            this.Hide();
            wk.Activate();
            wk.ShowDialog();
            this.Close();
        }
    }
}
