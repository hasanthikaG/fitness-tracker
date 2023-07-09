namespace fitness_tracker
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbEmail = new TextBox();
            label2 = new Label();
            tbPassword = new TextBox();
            label3 = new Label();
            loginBtn = new Button();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(181, 152);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.Location = new Point(259, 150);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(355, 23);
            tbEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(153, 210);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(259, 208);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(355, 23);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(311, 44);
            label3.Name = "label3";
            label3.Size = new Size(202, 52);
            label3.TabIndex = 4;
            label3.Text = "USER LOGIN";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginBtn.BackColor = Color.FromArgb(0, 0, 64);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = SystemColors.ControlLightLight;
            loginBtn.Location = new Point(369, 281);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(102, 33);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = Color.FromArgb(0, 0, 64);
            clearBtn.Location = new Point(12, 20);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 25);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Back";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 479);
            Controls.Add(clearBtn);
            Controls.Add(loginBtn);
            Controls.Add(label3);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(tbEmail);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbEmail;
        private Label label2;
        private TextBox tbPassword;
        private Label label3;
        private Button loginBtn;
        private Button clearBtn;
    }
}