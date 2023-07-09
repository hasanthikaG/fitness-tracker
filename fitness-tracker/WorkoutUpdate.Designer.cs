namespace fitness_tracker
{
    partial class WorkoutUpdate
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
            tbDuration = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            cbStatus = new ComboBox();
            tbBodyWeight = new TextBox();
            tbWKDescription = new TextBox();
            tbWKName = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            userId = new Label();
            button2 = new Button();
            clearBtn = new Button();
            label6 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // tbDuration
            // 
            tbDuration.Location = new Point(318, 268);
            tbDuration.Name = "tbDuration";
            tbDuration.Size = new Size(306, 23);
            tbDuration.TabIndex = 48;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(318, 359);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 23);
            dateTimePicker1.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(226, 361);
            label9.Name = "label9";
            label9.Size = new Size(42, 21);
            label9.TabIndex = 40;
            label9.Text = "Date";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Planned", "Completed", "Cancelled" });
            cbStatus.Location = new Point(318, 309);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(242, 23);
            cbStatus.TabIndex = 39;
            // 
            // tbBodyWeight
            // 
            tbBodyWeight.Location = new Point(318, 137);
            tbBodyWeight.Name = "tbBodyWeight";
            tbBodyWeight.Size = new Size(306, 23);
            tbBodyWeight.TabIndex = 38;
            // 
            // tbWKDescription
            // 
            tbWKDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbWKDescription.Location = new Point(318, 226);
            tbWKDescription.Name = "tbWKDescription";
            tbWKDescription.Size = new Size(306, 23);
            tbWKDescription.TabIndex = 36;
            // 
            // tbWKName
            // 
            tbWKName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbWKName.Location = new Point(318, 183);
            tbWKName.Name = "tbWKName";
            tbWKName.Size = new Size(306, 23);
            tbWKName.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(318, 100);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 34;
            label1.Text = "label1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(216, 311);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 33;
            label8.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(126, 268);
            label7.Name = "label7";
            label7.Size = new Size(142, 21);
            label7.TabIndex = 32;
            label7.Text = "Duration (In hours)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(138, 135);
            label5.Name = "label5";
            label5.Size = new Size(130, 21);
            label5.TabIndex = 31;
            label5.Text = "Body Weight (Kg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(115, 226);
            label3.Name = "label3";
            label3.Size = new Size(153, 21);
            label3.TabIndex = 29;
            label3.Text = "Workout Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(152, 183);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 28;
            label2.Text = "Workout Name";
            // 
            // userId
            // 
            userId.AutoSize = true;
            userId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userId.ForeColor = Color.FromArgb(0, 0, 64);
            userId.Location = new Point(179, 100);
            userId.Name = "userId";
            userId.Size = new Size(89, 21);
            userId.TabIndex = 27;
            userId.Text = "Workout ID";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(525, 451);
            button2.Name = "button2";
            button2.Size = new Size(178, 43);
            button2.TabIndex = 49;
            button2.Text = "Update Workout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = Color.FromArgb(0, 0, 64);
            clearBtn.Location = new Point(12, 12);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(83, 25);
            clearBtn.TabIndex = 50;
            clearBtn.Text = "Back";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(698, 5);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 52;
            label6.Text = "label6";
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 0, 64);
            button5.Location = new Point(682, 25);
            button5.Name = "button5";
            button5.Size = new Size(75, 30);
            button5.TabIndex = 51;
            button5.Text = "Sign Out";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // WorkoutUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(769, 525);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(clearBtn);
            Controls.Add(button2);
            Controls.Add(tbDuration);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(cbStatus);
            Controls.Add(tbBodyWeight);
            Controls.Add(tbWKDescription);
            Controls.Add(tbWKName);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(userId);
            Name = "WorkoutUpdate";
            Text = "UpdateWorkout";
            Load += WorkoutUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbDuration;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private ComboBox cbStatus;
        private TextBox tbBodyWeight;
        private TextBox tbWKDescription;
        private TextBox tbWKName;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label userId;
        private Button button2;
        private Button clearBtn;
        private Label label6;
        private Button button5;
    }
}