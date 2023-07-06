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
            dataGridView1.DataSource = Workout.GetWorkOutList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainDashboard db = new MainDashboard();
            this.Hide();
            db.Activate();
            db.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Workout newWorkout = new Workout();

            this.Hide();
            newWorkout.Activate();
            newWorkout.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Console.WriteLine("row" + row);
                if (row != null)
                {
                    selectedWorkoutId = row.Cells["WorkoutId"].Value.ToString()!;

                }
            }
        }


        private void button4_Click_1(object sender, EventArgs e)
        {


            Console.WriteLine("selectedWorkoutId" + selectedWorkoutId);
            WorkOutDetails w = Workout.GetWorkOutList().FirstOrDefault(p => p.WorkoutId.ToString() == selectedWorkoutId)!;


            if (Workout.GetWorkOutList().Remove(w))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Workout.GetWorkOutList();
            }
            else
            {
                Console.WriteLine("Not deleted");
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
