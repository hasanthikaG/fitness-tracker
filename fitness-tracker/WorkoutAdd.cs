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
    public partial class Workout : Form
    {
        User newUser = Register.GetUser();
        private static List<WorkOutDetails> workoutList = new List<WorkOutDetails>();
        public Workout()
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

            List<DateTime> workoutDays = new List<DateTime>();
            if (cmWKType.Text == "Recurring")
            {
                workoutDays = calculateRecurringWorkoutDays();
            }
            else if (cmWKType.Text == "One-Off")
            {
                workoutDays.Add(dateTimePicker3.Value);
            }

          

            //foreach (DateTime day in workoutDays)
            //{
            //    workout.Date = day;
            //    workoutList.Add(workout);
            //}

            foreach (DateTime day in workoutDays)
            {
                WorkOutDetails workout = new WorkOutDetails();
                Random random = new Random();
                workout.UserId = newUser.UserId;
                workout.WorkoutId = random.Next(0, 100);
                workout.WorkoutName = tbWKName.Text;
                workout.WorkoutDescription = tbWKDescription.Text;
                workout.BodyWeight = Double.Parse(tbBodyWeight.Text);
                workout.Status = cbStatus.Text;
                workout.DurationInHours = Double.Parse(tbDuration.Text);
                workout.WorkoutType = cmWKType.Text;
                workout.Date = day;
                workoutList.Add(workout);
            }

            WorkoutDashboard wk = new WorkoutDashboard();
            this.Hide();
            wk.Activate();
            wk.ShowDialog();
            this.Close();
            //
            //    if (
            //        string.IsNullOrEmpty(tbBodyWeight.Text) ||
            //        string.IsNullOrEmpty(tbWKName.Text) ||
            //        string.IsNullOrEmpty(cmWKType.Text) ||
            //        string.IsNullOrEmpty(tbDuration.Text) ||
            //        string.IsNullOrEmpty(cbStatus.Text)

            //        )
            //    {
            //        MessageBox.Show("Enter all required fields");

            //    }
            //    else
            //    {
            //        WorkOutDetails workout = new WorkOutDetails();
            //        Random random = new Random();
            //        workout.UserId = newUser.UserId;
            //        workout.WorkoutId = random.Next(0, 100);
            //        workout.WorkoutName = tbWKName.Text;
            //        workout.WorkoutDescription = tbWKDescription.Text;
            //        workout.BodyWeight = Double.Parse(tbBodyWeight.Text);
            //        workout.Status = cbStatus.Text;
            //        workout.DurationInHours = Double.Parse(tbDuration.Text);
            //        workout.WorkoutType = cmWKType.Text;
            //        workoutList.Add(workout);



            //    }

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
            string selectedWorkType = cmWKType.SelectedItem.ToString()!;


            if (selectedWorkType == "Recurring")
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
            else if (selectedWorkType == "One-Off")
            {
                label10.Visible = false;
                label11.Visible = false;
                dateTimePicker2.Visible = false;
                dateTimePicker3.Visible = false;
                checkedListBox1.Visible = false;
                label12.Visible = false;
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
    }
}
