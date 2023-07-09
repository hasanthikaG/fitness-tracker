namespace fitness_tracker
{
    partial class CheatMealUpdate
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
            button2 = new Button();
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
            comboBox1 = new ComboBox();
            label6 = new Label();
            button5 = new Button();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(528, 403);
            button2.Name = "button2";
            button2.Size = new Size(169, 51);
            button2.TabIndex = 65;
            button2.Text = "Update Cheat Meal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(298, 310);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 23);
            dateTimePicker1.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(237, 312);
            label9.Name = "label9";
            label9.Size = new Size(42, 21);
            label9.TabIndex = 62;
            label9.Text = "Date";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Planned", "Completed", "Cancelled" });
            cbStatus.Location = new Point(298, 266);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(242, 23);
            cbStatus.TabIndex = 61;
            // 
            // tbBodyWeight
            // 
            tbBodyWeight.Location = new Point(298, 107);
            tbBodyWeight.Name = "tbBodyWeight";
            tbBodyWeight.Size = new Size(321, 23);
            tbBodyWeight.TabIndex = 60;
            // 
            // tbWKDescription
            // 
            tbWKDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbWKDescription.Location = new Point(298, 180);
            tbWKDescription.Name = "tbWKDescription";
            tbWKDescription.Size = new Size(321, 23);
            tbWKDescription.TabIndex = 59;
            // 
            // tbWKName
            // 
            tbWKName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbWKName.Location = new Point(298, 140);
            tbWKName.Name = "tbWKName";
            tbWKName.Size = new Size(321, 23);
            tbWKName.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(298, 75);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 57;
            label1.Text = "label1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(229, 266);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 56;
            label8.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(170, 224);
            label7.Name = "label7";
            label7.Size = new Size(111, 21);
            label7.TabIndex = 55;
            label7.Text = "Meal Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(162, 109);
            label5.Name = "label5";
            label5.Size = new Size(130, 21);
            label5.TabIndex = 54;
            label5.Text = "Body Weight (Kg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(237, 182);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 53;
            label3.Text = "Note";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(147, 142);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 52;
            label2.Text = "Cheat Meal Name";
            // 
            // userId
            // 
            userId.AutoSize = true;
            userId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userId.ForeColor = Color.FromArgb(0, 0, 64);
            userId.Location = new Point(189, 75);
            userId.Name = "userId";
            userId.Size = new Size(103, 21);
            userId.TabIndex = 51;
            userId.Text = "CheatMeal ID";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner", "Snack" });
            comboBox1.Location = new Point(298, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 23);
            comboBox1.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(729, 10);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 68;
            label6.Text = "label6";
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 0, 64);
            button5.Location = new Point(713, 30);
            button5.Name = "button5";
            button5.Size = new Size(75, 30);
            button5.TabIndex = 67;
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
            clearBtn.Size = new Size(83, 25);
            clearBtn.TabIndex = 69;
            clearBtn.Text = "Back";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // CheatMealUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 483);
            Controls.Add(clearBtn);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(button2);
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
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "CheatMealUpdate";
            Text = "CheatMealUpdate";
            Load += CheatMealUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
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
        private ComboBox comboBox1;
        private Label label6;
        private Button button5;
        private Button clearBtn;
    }
}