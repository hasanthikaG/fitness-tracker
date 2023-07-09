namespace fitness_tracker
{
    partial class CheatMealAdd
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
            checkedListBox1 = new CheckedListBox();
            label12 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            button3 = new Button();
            cbStatus = new ComboBox();
            tbBodyWeight = new TextBox();
            cmWKType = new ComboBox();
            tbWKDescription = new TextBox();
            tbWKName = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            userId = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            button5 = new Button();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            checkedListBox1.Location = new Point(185, 373);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(221, 64);
            checkedListBox1.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 0, 64);
            label12.Location = new Point(132, 373);
            label12.Name = "label12";
            label12.Size = new Size(36, 17);
            label12.TabIndex = 48;
            label12.Text = "Days";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(507, 324);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(242, 25);
            dateTimePicker3.TabIndex = 47;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(185, 324);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(221, 25);
            dateTimePicker2.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 0, 64);
            label11.Location = new Point(479, 324);
            label11.Name = "label11";
            label11.Size = new Size(22, 17);
            label11.TabIndex = 45;
            label11.Text = "To";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 0, 64);
            label10.Location = new Point(130, 324);
            label10.Name = "label10";
            label10.Size = new Size(38, 17);
            label10.TabIndex = 44;
            label10.Text = "From";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(507, 275);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 25);
            dateTimePicker1.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(466, 278);
            label9.Name = "label9";
            label9.Size = new Size(35, 17);
            label9.TabIndex = 42;
            label9.Text = "Date";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 64);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(595, 533);
            button3.Name = "button3";
            button3.Size = new Size(154, 38);
            button3.TabIndex = 40;
            button3.Text = "Add Cheat Meal";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Planned", "Completed", "Cancelled" });
            cbStatus.Location = new Point(185, 234);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(217, 25);
            cbStatus.TabIndex = 39;
            // 
            // tbBodyWeight
            // 
            tbBodyWeight.Location = new Point(185, 81);
            tbBodyWeight.Name = "tbBodyWeight";
            tbBodyWeight.Size = new Size(217, 25);
            tbBodyWeight.TabIndex = 38;
            tbBodyWeight.TextChanged += tbBodyWeight_TextChanged;
            // 
            // cmWKType
            // 
            cmWKType.FormattingEnabled = true;
            cmWKType.Items.AddRange(new object[] { "Recurring", "One-Off" });
            cmWKType.Location = new Point(185, 278);
            cmWKType.Name = "cmWKType";
            cmWKType.Size = new Size(221, 25);
            cmWKType.TabIndex = 37;
            cmWKType.SelectedIndexChanged += cmWKType_SelectedIndexChanged;
            // 
            // tbWKDescription
            // 
            tbWKDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbWKDescription.Location = new Point(185, 164);
            tbWKDescription.Name = "tbWKDescription";
            tbWKDescription.Size = new Size(217, 25);
            tbWKDescription.TabIndex = 36;
            // 
            // tbWKName
            // 
            tbWKName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbWKName.Location = new Point(185, 121);
            tbWKName.Name = "tbWKName";
            tbWKName.Size = new Size(217, 25);
            tbWKName.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, -35);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 34;
            label1.Text = "label1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(132, 234);
            label8.Name = "label8";
            label8.Size = new Size(43, 17);
            label8.TabIndex = 33;
            label8.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(70, 84);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 31;
            label5.Text = "Body Weight(Kg)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(140, 278);
            label4.Name = "label4";
            label4.Size = new Size(35, 17);
            label4.TabIndex = 30;
            label4.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(138, 172);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 29;
            label3.Text = "Note";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(62, 129);
            label2.Name = "label2";
            label2.Size = new Size(113, 17);
            label2.TabIndex = 28;
            label2.Text = "Cheat Meal Name";
            // 
            // userId
            // 
            userId.AutoSize = true;
            userId.Location = new Point(42, -35);
            userId.Name = "userId";
            userId.Size = new Size(51, 17);
            userId.TabIndex = 27;
            userId.Text = "User ID";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner", "Snack" });
            comboBox1.Location = new Point(185, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 25);
            comboBox1.TabIndex = 50;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(81, 203);
            label6.Name = "label6";
            label6.Size = new Size(94, 17);
            label6.TabIndex = 51;
            label6.Text = "Meal Category";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(0, 0, 64);
            label13.Location = new Point(125, 50);
            label13.Name = "label13";
            label13.Size = new Size(50, 17);
            label13.TabIndex = 54;
            label13.Text = "User Id";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 0, 64);
            label14.Location = new Point(185, 50);
            label14.Name = "label14";
            label14.Size = new Size(50, 17);
            label14.TabIndex = 55;
            label14.Text = "label14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(0, 0, 64);
            label15.Location = new Point(737, 3);
            label15.Name = "label15";
            label15.Size = new Size(50, 17);
            label15.TabIndex = 57;
            label15.Text = "label15";
            label15.Click += label15_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 0, 64);
            button5.Location = new Point(721, 26);
            button5.Name = "button5";
            button5.Size = new Size(75, 34);
            button5.TabIndex = 56;
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
            clearBtn.Location = new Point(12, 12);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(93, 26);
            clearBtn.TabIndex = 58;
            clearBtn.Text = "Back";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click_1;
            // 
            // CheatMealAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(808, 606);
            Controls.Add(clearBtn);
            Controls.Add(label15);
            Controls.Add(button5);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(label12);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(cbStatus);
            Controls.Add(tbBodyWeight);
            Controls.Add(cmWKType);
            Controls.Add(tbWKDescription);
            Controls.Add(tbWKName);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(userId);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 0, 64);
            Name = "CheatMealAdd";
            Text = "CheatMeal";
            Load += CheatMealAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private Label label12;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private Label label11;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Button button3;
        private ComboBox cbStatus;
        private TextBox tbBodyWeight;
        private ComboBox cmWKType;
        private TextBox tbWKDescription;
        private TextBox tbWKName;
        private Label label1;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label userId;
        private ComboBox comboBox1;
        private Label label6;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button button5;
        private Button clearBtn;
    }
}