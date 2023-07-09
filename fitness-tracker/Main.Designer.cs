namespace fitness_tracker
{
    partial class Main
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(359, 65);
            label1.TabIndex = 1;
            label1.Text = "Fitness Tracker";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(593, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 2;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(54, 75, 109);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(684, 37);
            button2.Name = "button2";
            button2.Size = new Size(89, 37);
            button2.TabIndex = 3;
            button2.Text = "Sign in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(156, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 311);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 75, 109);
            ClientSize = new Size(800, 479);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}