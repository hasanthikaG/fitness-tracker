﻿using System;
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
    }
}