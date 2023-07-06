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
            tableLayoutPanel1 = new TableLayoutPanel();
            loginBtn = new Button();
            clearBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 117);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbEmail.Location = new Point(21, 145);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(445, 23);
            tbEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 195);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(21, 222);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(445, 23);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(143, 48);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 4;
            label3.Text = "USER LOGIN";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(loginBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(clearBtn, 0, 0);
            tableLayoutPanel1.Location = new Point(21, 385);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(445, 37);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.Location = new Point(225, 3);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(217, 23);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.Location = new Point(3, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(216, 23);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Back";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 452);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(tbEmail);
            Controls.Add(label1);
            MaximumSize = new Size(494, 491);
            MinimumSize = new Size(436, 491);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbEmail;
        private Label label2;
        private TextBox tbPassword;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button loginBtn;
        private Button clearBtn;
    }
}