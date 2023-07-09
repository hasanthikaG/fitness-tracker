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
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // fName
            // 
            fName.AutoSize = true;
            fName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fName.ForeColor = Color.FromArgb(0, 0, 64);
            fName.Location = new Point(154, 134);
            fName.Name = "fName";
            fName.Size = new Size(86, 21);
            fName.TabIndex = 0;
            fName.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(154, 176);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(190, 209);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(162, 247);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // tbFName
            // 
            tbFName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFName.Location = new Point(246, 136);
            tbFName.Name = "tbFName";
            tbFName.Size = new Size(366, 23);
            tbFName.TabIndex = 4;
            // 
            // tbLName
            // 
            tbLName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLName.Location = new Point(246, 174);
            tbLName.Name = "tbLName";
            tbLName.Size = new Size(366, 23);
            tbLName.TabIndex = 5;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.Location = new Point(246, 211);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(366, 23);
            tbEmail.TabIndex = 6;
            // 
            // tbPwd
            // 
            tbPwd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPwd.Location = new Point(246, 249);
            tbPwd.Name = "tbPwd";
            tbPwd.Size = new Size(366, 23);
            tbPwd.TabIndex = 7;
            tbPwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(295, 45);
            label1.Name = "label1";
            label1.Size = new Size(216, 38);
            label1.TabIndex = 8;
            label1.Text = "User Register";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(533, 322);
            button2.Name = "button2";
            button2.Size = new Size(143, 44);
            button2.TabIndex = 1;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 0, 64);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(50, 25);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 479);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(tbPwd);
            Controls.Add(tbEmail);
            Controls.Add(tbLName);
            Controls.Add(tbFName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(fName);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
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
        private Button button1;
        private Button button2;
    }
}