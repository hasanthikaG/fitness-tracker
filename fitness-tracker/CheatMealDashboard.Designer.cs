namespace fitness_tracker
{
    partial class CheatMealDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            label6 = new Label();
            button1 = new Button();
            clearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 64);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(545, 61);
            button4.Name = "button4";
            button4.Size = new Size(156, 23);
            button4.TabIndex = 9;
            button4.Text = "Delete Cheat Meal";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(383, 61);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 8;
            button3.Text = "Update Cheat Meal";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(777, 374);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 0, 64);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(221, 61);
            button5.Name = "button5";
            button5.Size = new Size(156, 26);
            button5.TabIndex = 5;
            button5.Text = "Add Cheat Meal";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(730, 7);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 30;
            label6.Text = "label6";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 0, 64);
            button1.Location = new Point(714, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 29;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = Color.FromArgb(0, 0, 64);
            clearBtn.Location = new Point(12, 7);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(83, 25);
            clearBtn.TabIndex = 31;
            clearBtn.Text = "Back";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // CheatMealDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(808, 479);
            Controls.Add(clearBtn);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Name = "CheatMealDashboard";
            Text = "ChealMealDashboard";
            Load += CheatMealDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button5;
        private Label label6;
        private Button button1;
        private Button clearBtn;
    }
}