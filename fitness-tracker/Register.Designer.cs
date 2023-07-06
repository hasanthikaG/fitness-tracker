namespace fitness_tracker
{
    partial class Register
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
            fName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbFName = new TextBox();
            tbLName = new TextBox();
            tbEmail = new TextBox();
            tbPwd = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // fName
            // 
            fName.AutoSize = true;
            fName.Location = new Point(36, 92);
            fName.Name = "fName";
            fName.Size = new Size(64, 15);
            fName.TabIndex = 0;
            fName.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 153);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 205);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 265);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // tbFName
            // 
            tbFName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFName.Location = new Point(37, 110);
            tbFName.Name = "tbFName";
            tbFName.Size = new Size(421, 23);
            tbFName.TabIndex = 4;
            // 
            // tbLName
            // 
            tbLName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLName.Location = new Point(37, 171);
            tbLName.Name = "tbLName";
            tbLName.Size = new Size(421, 23);
            tbLName.TabIndex = 5;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.Location = new Point(37, 223);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(421, 23);
            tbEmail.TabIndex = 6;
            // 
            // tbPwd
            // 
            tbPwd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPwd.Location = new Point(37, 283);
            tbPwd.Name = "tbPwd";
            tbPwd.Size = new Size(421, 23);
            tbPwd.TabIndex = 7;
            tbPwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 34);
            label1.Name = "label1";
            label1.Size = new Size(213, 45);
            label1.TabIndex = 8;
            label1.Text = "User Register";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.42085F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.57915F));
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new Point(37, 408);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(421, 32);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(211, 3);
            button2.Name = "button2";
            button2.Size = new Size(207, 23);
            button2.TabIndex = 1;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(202, 26);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 452);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(tbPwd);
            Controls.Add(tbEmail);
            Controls.Add(tbLName);
            Controls.Add(tbFName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(fName);
            MaximumSize = new Size(494, 491);
            MinimumSize = new Size(436, 491);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbFName;
        private TextBox tbLName;
        private TextBox tbEmail;
        private TextBox tbPwd;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
    }
}