namespace fitness_tracker
{
    partial class WorkoutAdd
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
            userId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label1 = new Label();
            tbWKName = new TextBox();
            tbWKDescription = new TextBox();
            cmWKType = new ComboBox();
            tbBodyWeight = new TextBox();
            cbStatus = new ComboBox();
            button1 = new Button();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label12 = new Label();
            checkedListBox1 = new CheckedListBox();
            tbDuration = new TextBox();
            label6 = new Label();
            button5 = new Button();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // userId
            // 
            userId.AutoSize = true;
            userId.BackColor = Color.Transparent;
            userId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userId.ForeColor = Color.FromArgb(0, 0, 64);
            userId.Location = new Point(153, 82);
            userId.Name = "userId";
            userId.Size = new Size(61, 21);
            userId.TabIndex = 0;
            userId.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(111, 159);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 1;
            label2.Text = "Workout Name";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(74, 194);
            label3.Name = "label3";
            label3.Size = new Size(153, 21);
            label3.TabIndex = 2;
            label3.Text = "Workout Description";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(185, 319);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 3;
            label4.Text = "Type";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(93, 119);
            label5.Name = "label5";
            label5.Size = new Size(134, 21);
            label5.TabIndex = 4;
            label5.Text = "Body Weight (Kg) ";
            label5.TextAlign = ContentAlignment.MiddleRight;
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(85, 233);
            label7.Name = "label7";
            label7.Size = new Size(142, 21);
            label7.TabIndex = 6;
            label7.Text = "Duration (In hours)";
            label7.TextAlign = ContentAlignment.MiddleRight;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(175, 274);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 7;
            label8.Text = "Status";
            label8.TextAlign = ContentAlignment.MiddleRight;
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(273, 82);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // tbWKName
            // 
            tbWKName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbWKName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbWKName.Location = new Point(270, 159);
            tbWKName.Name = "tbWKName";
            tbWKName.Size = new Size(224, 25);
            tbWKName.TabIndex = 9;
            // 
            // tbWKDescription
            // 
            tbWKDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbWKDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbWKDescription.Location = new Point(270, 196);
            tbWKDescription.Multiline = true;
            tbWKDescription.Name = "tbWKDescription";
            tbWKDescription.Size = new Size(224, 23);
            tbWKDescription.TabIndex = 10;
            // 
            // cmWKType
            // 
            cmWKType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmWKType.FormattingEnabled = true;
            cmWKType.Items.AddRange(new object[] { "Recurring", "One-Off" });
            cmWKType.Location = new Point(270, 317);
            cmWKType.Name = "cmWKType";
            cmWKType.Size = new Size(224, 25);
            cmWKType.TabIndex = 11;
            cmWKType.SelectedIndexChanged += cmWKType_SelectedIndexChanged;
            // 
            // tbBodyWeight
            // 
            tbBodyWeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbBodyWeight.Location = new Point(270, 117);
            tbBodyWeight.Name = "tbBodyWeight";
            tbBodyWeight.Size = new Size(224, 25);
            tbBodyWeight.TabIndex = 12;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Planned", "Completed", "Cancelled" });
            cbStatus.Location = new Point(270, 272);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(224, 25);
            cbStatus.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(609, 489);
            button1.Name = "button1";
            button1.Size = new Size(154, 43);
            button1.TabIndex = 16;
            button1.Text = "Add Workout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(512, 319);
            label9.Name = "label9";
            label9.Size = new Size(42, 21);
            label9.TabIndex = 18;
            label9.Text = "Date";
            label9.TextAlign = ContentAlignment.MiddleRight;
            label9.Click += label9_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(560, 317);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(224, 25);
            dateTimePicker1.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 0, 64);
            label10.Location = new Point(180, 368);
            label10.Name = "label10";
            label10.Size = new Size(47, 21);
            label10.TabIndex = 20;
            label10.Text = "From";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 0, 64);
            label11.Location = new Point(529, 370);
            label11.Name = "label11";
            label11.Size = new Size(25, 21);
            label11.TabIndex = 21;
            label11.Text = "To";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(273, 368);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(221, 25);
            dateTimePicker2.TabIndex = 22;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(560, 370);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(224, 25);
            dateTimePicker3.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 0, 64);
            label12.Location = new Point(183, 408);
            label12.Name = "label12";
            label12.Size = new Size(44, 21);
            label12.TabIndex = 24;
            label12.Text = "Days";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            checkedListBox1.Location = new Point(273, 408);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(221, 44);
            checkedListBox1.TabIndex = 25;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // tbDuration
            // 
            tbDuration.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDuration.Location = new Point(270, 235);
            tbDuration.Name = "tbDuration";
            tbDuration.Size = new Size(224, 25);
            tbDuration.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(737, 7);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 28;
            label6.Text = "label6";
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 0, 64);
            button5.Location = new Point(721, 27);
            button5.Name = "button5";
            button5.Size = new Size(75, 30);
            button5.TabIndex = 27;
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
            clearBtn.Location = new Point(12, 7);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(83, 25);
            clearBtn.TabIndex = 29;
            clearBtn.Text = "Back";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // WorkoutAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(808, 561);
            Controls.Add(clearBtn);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(tbDuration);
            Controls.Add(checkedListBox1);
            Controls.Add(label12);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(cbStatus);
            Controls.Add(tbBodyWeight);
            Controls.Add(cmWKType);
            Controls.Add(tbWKDescription);
            Controls.Add(tbWKName);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(userId);
            Name = "WorkoutAdd";
            Text = "NewWorkout";
            Load += NewWorkout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label1;
        private TextBox tbWKName;
        private TextBox tbWKDescription;
        private ComboBox cmWKType;
        private TextBox tbBodyWeight;
        private ComboBox cbStatus;
        private Button button1;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label label12;
        private CheckedListBox checkedListBox1;
        private TextBox tbDuration;
        private Label label6;
        private Button button5;
        private Button clearBtn;
    }
}