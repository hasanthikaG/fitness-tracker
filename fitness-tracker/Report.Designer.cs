namespace fitness_tracker
{
    partial class Report
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            Workout = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            clearBtn = new Button();
            label15 = new Label();
            button5 = new Button();
            Workout.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(372, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(113, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(531, 79);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(117, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(316, 61);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 3;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(508, 55);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 4;
            label2.Text = "To";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(670, 76);
            button2.Name = "button2";
            button2.Size = new Size(108, 33);
            button2.TabIndex = 7;
            button2.Text = "Generate Report";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Workout
            // 
            Workout.Controls.Add(tabPage1);
            Workout.Controls.Add(tabPage2);
            Workout.Location = new Point(12, 108);
            Workout.Name = "Workout";
            Workout.SelectedIndex = 0;
            Workout.Size = new Size(776, 319);
            Workout.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 291);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(754, 279);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 291);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(756, 279);
            dataGridView2.TabIndex = 0;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = Color.FromArgb(0, 0, 64);
            clearBtn.Location = new Point(12, 23);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(93, 26);
            clearBtn.TabIndex = 61;
            clearBtn.Text = "Back";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(0, 0, 64);
            label15.Location = new Point(728, 9);
            label15.Name = "label15";
            label15.Size = new Size(50, 17);
            label15.TabIndex = 60;
            label15.Text = "label15";
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 0, 64);
            button5.Location = new Point(713, 29);
            button5.Name = "button5";
            button5.Size = new Size(75, 34);
            button5.TabIndex = 59;
            button5.Text = "Sign Out";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Report
            // 
            AccessibleName = "ttt";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(clearBtn);
            Controls.Add(label15);
            Controls.Add(button5);
            Controls.Add(Workout);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "Report";
            Text = "Report";
            Load += Report_Load;
            Workout.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Button button2;
        private TabControl Workout;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button clearBtn;
        private Label label15;
        private Button button5;
    }
}