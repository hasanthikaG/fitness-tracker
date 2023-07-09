namespace fitness_tracker
{
    partial class WorkoutDashboard
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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button5 = new Button();
            clearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(226, 62);
            button1.Name = "button1";
            button1.Size = new Size(156, 26);
            button1.TabIndex = 0;
            button1.Text = "Add New Workout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(388, 64);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 3;
            button3.Text = "Update Workout";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 64);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(550, 64);
            button4.Name = "button4";
            button4.Size = new Size(156, 23);
            button4.TabIndex = 4;
            button4.Text = "Delete Workout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(786, 374);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(729, 6);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 11;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 0, 64);
            button5.Location = new Point(713, 26);
            button5.Name = "button5";
            button5.Size = new Size(75, 30);
            button5.TabIndex = 10;
            button5.Text = "Sign Out";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = Color.FromArgb(0, 0, 64);
            clearBtn.Location = new Point(12, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(83, 25);
            clearBtn.TabIndex = 12;
            clearBtn.Text = "Back";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // WorkoutDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(808, 479);
            Controls.Add(clearBtn);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "WorkoutDashboard";
            Text = "Workout";
            Load += Workout_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button5;
        private Button clearBtn;
    }
}