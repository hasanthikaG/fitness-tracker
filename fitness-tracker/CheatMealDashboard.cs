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
    public partial class CheatMealDashboard : Form
    {
        string selectedCheatMealId = "";
        public CheatMealDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainDashboard md = new MainDashboard();
            this.Hide();
            md.Activate();
            md.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheatMealAdd md = new CheatMealAdd();
            this.Hide();
            md.Activate();
            md.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            selectedCheatMealId = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString()!;
            CheatMealUpdate md = new CheatMealUpdate(selectedCheatMealId);
            this.Hide();
            md.Activate();
            md.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            selectedCheatMealId = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString()!;
            CheatMealDetails w = CheatMealAdd.GetCheatMealList().FirstOrDefault(p => p.CheatMealId.ToString() == selectedCheatMealId)!;

            if (CheatMealAdd.GetCheatMealList().Remove(w))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = CheatMealAdd.GetCheatMealList();
            }

        }

        private void CheatMealDashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CheatMealAdd.GetCheatMealList();
            label6.Text = Register.GetUser().FName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            MainDashboard md = new MainDashboard();
            this.Hide();
            md.Activate();
            md.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            this.Hide();
            mn.Activate();
            mn.ShowDialog();
            this.Close();
        }
    }
}
