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
        string workoutId = "";
        List<WorkOutDetails> wk = WorkoutAdd.GetWorkOutList();
        public WorkoutUpdate(string workoutID)
        {
            this.workoutId = workoutID;
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

        private void WorkoutUpdate_Load(object sender, EventArgs e)
        {
            label6.Text = Register.GetUser().FName;
            WorkOutDetails workOutDetails = wk.Find(item => item.WorkoutId == workoutId)!;
            label1.Text = workOutDetails.WorkoutId.ToString();
            tbBodyWeight.Text = workOutDetails.BodyWeight.ToString();
            tbWKName.Text = workOutDetails.WorkoutName.ToString();
            tbWKDescription.Text = workOutDetails.WorkoutDescription.ToString();
            tbDuration.Text = workOutDetails.DurationInHours.ToString();
            cbStatus.Text = workOutDetails.Status.ToString();
            dateTimePicker1.Value = workOutDetails.Date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkOutDetails workOutDetails = wk.Find(item => item.WorkoutId == workoutId)!;
            workOutDetails.UserId = workOutDetails.UserId;
            workOutDetails.WorkoutId = workoutId;
            workOutDetails.WorkoutName = tbWKName.Text;
            workOutDetails.WorkoutDescription = tbWKDescription.Text;
            workOutDetails.BodyWeight = Double.Parse(tbBodyWeight.Text);
            workOutDetails.Status = cbStatus.Text;
            workOutDetails.DurationInHours = Double.Parse(tbDuration.Text);
            workOutDetails.Date = dateTimePicker1.Value;
            WorkoutDashboard wkdb = new WorkoutDashboard();
            this.Hide();
            wkdb.Activate();
            wkdb.ShowDialog();
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

        private void button5_Click(object sender, EventArgs e)
        {
            MainDashboard db = new MainDashboard();
            this.Hide();
            db.Activate();
            db.ShowDialog();
            this.Close();
        }
    }
}
