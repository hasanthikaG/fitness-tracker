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
    public partial class CheatMealUpdate : Form
    {
        string cheatMealID = "";
        List<CheatMealDetails> cm = CheatMealAdd.GetCheatMealList();
        public CheatMealUpdate(string cheatMealId)
        {
            this.cheatMealID = cheatMealId;
            InitializeComponent();
        }

        private void CheatMealUpdate_Load(object sender, EventArgs e)
        {
            label6.Text = Register.GetUser().FName;
            CheatMealDetails cheatMealDetails = cm.Find(item => item.CheatMealId == cheatMealID)!;
            label1.Text = cheatMealDetails.CheatMealId.ToString();
            tbBodyWeight.Text = cheatMealDetails.BodyWeight.ToString();
            tbWKName.Text = cheatMealDetails.CheatMealName.ToString();
            tbWKDescription.Text = cheatMealDetails.Note.ToString();
            comboBox1.Text = cheatMealDetails.MealCategory.ToString();
            cbStatus.Text = cheatMealDetails.Status.ToString();
            dateTimePicker1.Value = cheatMealDetails.Date;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            CheatMealDashboard md = new CheatMealDashboard();
            this.Hide();
            md.Activate();
            md.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheatMealDetails cheatMealDetails = cm.Find(item => item.CheatMealId == cheatMealID)!;
            cheatMealDetails.UserId = cheatMealDetails.UserId;
            cheatMealDetails.CheatMealId = cheatMealID;
            cheatMealDetails.CheatMealName = tbWKName.Text;
            cheatMealDetails.Note = tbWKDescription.Text;
            cheatMealDetails.BodyWeight = Double.Parse(tbBodyWeight.Text);
            cheatMealDetails.Status = cbStatus.Text;
            cheatMealDetails.MealCategory = comboBox1.Text;
            cheatMealDetails.Date = dateTimePicker1.Value;
            CheatMealDashboard wkdb = new CheatMealDashboard();
            this.Hide();
            wkdb.Activate();
            wkdb.ShowDialog();
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

            CheatMealDashboard md = new CheatMealDashboard();
            this.Hide();
            md.Activate();
            md.ShowDialog();
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
