namespace Hebrew_date_test
{
    partial class Dashboard
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
            label_title = new Label();
            label_day_in_month = new Label();
            comboBox_dayInWeek = new ComboBox();
            comboBox_dayInMonth = new ComboBox();
            label3 = new Label();
            comboBox_month = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button_submit = new Button();
            comboBox_year = new ComboBox();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 15F);
            label_title.Location = new Point(525, 32);
            label_title.Name = "label_title";
            label_title.Size = new Size(162, 35);
            label_title.TabIndex = 0;
            label_title.Text = "כתיבת תאריך";
            // 
            // label_day_in_month
            // 
            label_day_in_month.AutoSize = true;
            label_day_in_month.Location = new Point(235, 101);
            label_day_in_month.Name = "label_day_in_month";
            label_day_in_month.Size = new Size(84, 20);
            label_day_in_month.TabIndex = 1;
            label_day_in_month.Text = "היום בשבוע";
            // 
            // comboBox_dayInWeek
            // 
            comboBox_dayInWeek.FormattingEnabled = true;
            comboBox_dayInWeek.Location = new Point(207, 140);
            comboBox_dayInWeek.Name = "comboBox_dayInWeek";
            comboBox_dayInWeek.Size = new Size(132, 28);
            comboBox_dayInWeek.TabIndex = 2;
            // 
            // comboBox_dayInMonth
            // 
            comboBox_dayInMonth.FormattingEnabled = true;
            comboBox_dayInMonth.Location = new Point(433, 140);
            comboBox_dayInMonth.Name = "comboBox_dayInMonth";
            comboBox_dayInMonth.Size = new Size(132, 28);
            comboBox_dayInMonth.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 101);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 7;
            label3.Text = "היום בחודש";
            // 
            // comboBox_month
            // 
            comboBox_month.FormattingEnabled = true;
            comboBox_month.Location = new Point(655, 140);
            comboBox_month.Name = "comboBox_month";
            comboBox_month.Size = new Size(132, 28);
            comboBox_month.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(697, 101);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 9;
            label1.Text = "חודש";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(931, 101);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 11;
            label2.Text = "שנה";
            // 
            // button_submit
            // 
            button_submit.Font = new Font("Segoe UI", 12F);
            button_submit.Location = new Point(525, 271);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(197, 54);
            button_submit.TabIndex = 13;
            button_submit.Text = "הוסף תאריך עברי";
            button_submit.UseVisualStyleBackColor = true;
            button_submit.Click += Button_submit_Click;
            // 
            // comboBox_year
            // 
            comboBox_year.FormattingEnabled = true;
            comboBox_year.Location = new Point(887, 140);
            comboBox_year.Name = "comboBox_year";
            comboBox_year.Size = new Size(132, 28);
            comboBox_year.TabIndex = 14;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 497);
            Controls.Add(comboBox_year);
            Controls.Add(button_submit);
            Controls.Add(label2);
            Controls.Add(comboBox_month);
            Controls.Add(label1);
            Controls.Add(comboBox_dayInMonth);
            Controls.Add(label3);
            Controls.Add(comboBox_dayInWeek);
            Controls.Add(label_day_in_month);
            Controls.Add(label_title);
            Name = "Dashboard";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Label label_day_in_month;
        private ComboBox comboBox_dayInWeek;
        private ComboBox comboBox_dayInMonth;
        private Label label3;
        private ComboBox comboBox_month;
        private Label label1;
        private Label label2;
        private Button button_submit;
        private ComboBox comboBox_year;
    }
}
