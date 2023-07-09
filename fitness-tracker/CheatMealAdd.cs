using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CheatMealAdd : Form
    {
        User newUser = Register.GetUser();
        private static List<CheatMealDetails> cheatMealList = new List<CheatMealDetails>();
        public CheatMealAdd()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CheatMealDashboard cm = new CheatMealDashboard();

            this.Hide();
            cm.Activate();
            cm.ShowDialog();
            this.Close();
        }

        private void CheatMealAdd_Load(object sender, EventArgs e)
        {
            label15.Text = newUser.FName;
            label14.Text = newUser.UserId.ToString();
            label10.Visible = false;
            label11.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            checkedListBox1.Visible = false;
            label12.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            this.Hide();
            mn.Activate();
            mn.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<DateTime> cheatMealDays = new List<DateTime>();
            if (cmWKType.Text == "Recurring")
            {
                cheatMealDays = calculateRecurringWorkoutDays();
            }
            else if (cmWKType.Text == "One-Off")
            {
                cheatMealDays.Add(dateTimePicker1.Value);
            }

            foreach (DateTime day in cheatMealDays)
            {
                CheatMealDetails cheatMeal = new CheatMealDetails();
                Random random = new Random();
                cheatMeal.UserId = newUser.UserId;
                cheatMeal.CheatMealId = $"CheatMeal-{random.Next(0, 100)}";
                cheatMeal.CheatMealName = tbWKName.Text;
                cheatMeal.Note = tbWKDescription.Text;
                cheatMeal.BodyWeight = Double.Parse(tbBodyWeight.Text);
                cheatMeal.Status = cbStatus.Text;
                cheatMeal.MealCategory = comboBox1.Text;
                cheatMeal.Date = day;
                cheatMealList.Add(cheatMeal);
            }

            CheatMealDashboard wk = new CheatMealDashboard();
            this.Hide();
            wk.Activate();
            wk.ShowDialog();
            this.Close();
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

        public static List<CheatMealDetails> GetCheatMealList()
        {
            return cheatMealList;
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

        private void button5_Click(object sender, EventArgs e)
        {

            Main mn = new Main();
            this.Hide();
            mn.Activate();
            mn.ShowDialog();
            this.Close();
        }

        private void tbBodyWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            CheatMealDashboard cm = new CheatMealDashboard();

            this.Hide();
            cm.Activate();
            cm.ShowDialog();
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
