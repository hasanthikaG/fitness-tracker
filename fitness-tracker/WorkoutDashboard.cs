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
    public partial class WorkoutDashboard : Form
    {
        string selectedWorkoutId = "";
        public WorkoutDashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Workout_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = WorkoutAdd.GetWorkOutList();
            label1.Text = Register.GetUser().FName;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WorkoutAdd newWorkout = new WorkoutAdd();

            this.Hide();
            newWorkout.Activate();
            newWorkout.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            selectedWorkoutId = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString()!;
            WorkOutDetails w = WorkoutAdd.GetWorkOutList().FirstOrDefault(p => p.WorkoutId.ToString() == selectedWorkoutId)!;

            if (WorkoutAdd.GetWorkOutList().Remove(w))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = WorkoutAdd.GetWorkOutList();
            }


        }

   
        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            selectedWorkoutId = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString()!;
            WorkoutUpdate wk = new WorkoutUpdate(selectedWorkoutId);
            this.Hide();
            wk.Activate();
            wk.ShowDialog();
            this.Close();
        }

   
        private void clearBtn_Click(object sender, EventArgs e)
        {
            MainDashboard db = new MainDashboard();
            this.Hide();
            db.Activate();
            db.ShowDialog();
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

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
