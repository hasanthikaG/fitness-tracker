namespace fitness_tracker
{
    partial class Workout
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
            button2 = new Button();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label12 = new Label();
            checkedListBox1 = new CheckedListBox();
            tbDuration = new TextBox();
            SuspendLayout();
            // 
            // userId
            // 
            userId.AutoSize = true;
            userId.Location = new Point(12, 19);
            userId.Name = "userId";
            userId.Size = new Size(44, 15);
            userId.TabIndex = 0;
            userId.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 99);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Workout Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 153);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 2;
            label3.Text = "Workout Description";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 266);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "Workout Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 45);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "Body Weight";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 210);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 6;
            label7.Text = "Duration (In hours)";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 210);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 7;
            label8.Text = "Status";
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // tbWKName
            // 
            tbWKName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbWKName.Location = new Point(39, 117);
            tbWKName.Name = "tbWKName";
            tbWKName.Size = new Size(557, 23);
            tbWKName.TabIndex = 9;
            // 
            // tbWKDescription
            // 
            tbWKDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbWKDescription.Location = new Point(39, 171);
            tbWKDescription.Name = "tbWKDescription";
            tbWKDescription.Size = new Size(557, 23);
            tbWKDescription.TabIndex = 10;
            // 
            // cmWKType
            // 
            cmWKType.FormattingEnabled = true;
            cmWKType.Items.AddRange(new object[] { "Recurring", "One-Off" });
            cmWKType.Location = new Point(39, 287);
            cmWKType.Name = "cmWKType";
            cmWKType.Size = new Size(221, 23);
            cmWKType.TabIndex = 11;
            cmWKType.SelectedIndexChanged += cmWKType_SelectedIndexChanged;
            // 
            // tbBodyWeight
            // 
            tbBodyWeight.Location = new Point(39, 63);
            tbBodyWeight.Name = "tbBodyWeight";
            tbBodyWeight.Size = new Size(557, 23);
            tbBodyWeight.TabIndex = 12;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Planned", "Completed", "Cancelled" });
            cbStatus.Location = new Point(354, 228);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(242, 23);
            cbStatus.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(461, 509);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 16;
            button1.Text = "Add Workout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(316, 509);
            button2.Name = "button2";
            button2.Size = new Size(135, 23);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 266);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 18;
            label9.Text = "Date";
            label9.Click += label9_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(354, 284);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 325);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 20;
            label10.Text = "From";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(339, 325);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 21;
            label11.Text = "To";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(39, 343);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(221, 23);
            dateTimePicker2.TabIndex = 22;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(354, 343);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(242, 23);
            dateTimePicker3.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 396);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 24;
            label12.Text = "Days";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            checkedListBox1.Location = new Point(39, 425);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(221, 58);
            checkedListBox1.TabIndex = 25;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // tbDuration
            // 
            tbDuration.Location = new Point(39, 228);
            tbDuration.Name = "tbDuration";
            tbDuration.Size = new Size(221, 23);
            tbDuration.TabIndex = 26;
            // 
            // NewWorkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 540);
            Controls.Add(tbDuration);
            Controls.Add(checkedListBox1);
            Controls.Add(label12);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(button2);
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
            Name = "NewWorkout";
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
        private Button button2;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label label12;
        private CheckedListBox checkedListBox1;
        private TextBox tbDuration;
    }
}