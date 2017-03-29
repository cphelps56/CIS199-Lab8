namespace Lab8
{
    partial class DateForm
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
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.date1Label = new System.Windows.Forms.Label();
            this.updateMonthBtn = new System.Windows.Forms.Button();
            this.updateDayBtn = new System.Windows.Forms.Button();
            this.updateYearBtn = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.yearTxtBox = new System.Windows.Forms.TextBox();
            this.dayTxtBox = new System.Windows.Forms.TextBox();
            this.monthTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(23, 138);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 0;
            this.monthLabel.Text = "Month:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(23, 178);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(29, 13);
            this.dayLabel.TabIndex = 1;
            this.dayLabel.Text = "Day:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(23, 217);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "Year:";
            // 
            // date1Label
            // 
            this.date1Label.AutoSize = true;
            this.date1Label.Location = new System.Drawing.Point(62, 64);
            this.date1Label.Name = "date1Label";
            this.date1Label.Size = new System.Drawing.Size(33, 13);
            this.date1Label.TabIndex = 3;
            this.date1Label.Text = "Date:";
            // 
            // updateMonthBtn
            // 
            this.updateMonthBtn.Location = new System.Drawing.Point(190, 133);
            this.updateMonthBtn.Name = "updateMonthBtn";
            this.updateMonthBtn.Size = new System.Drawing.Size(90, 23);
            this.updateMonthBtn.TabIndex = 4;
            this.updateMonthBtn.Text = "Update Month";
            this.updateMonthBtn.UseVisualStyleBackColor = true;
            this.updateMonthBtn.Click += new System.EventHandler(this.updateMonthBtn_Click);
            // 
            // updateDayBtn
            // 
            this.updateDayBtn.Location = new System.Drawing.Point(190, 173);
            this.updateDayBtn.Name = "updateDayBtn";
            this.updateDayBtn.Size = new System.Drawing.Size(90, 23);
            this.updateDayBtn.TabIndex = 5;
            this.updateDayBtn.Text = "Update Day";
            this.updateDayBtn.UseVisualStyleBackColor = true;
            this.updateDayBtn.Click += new System.EventHandler(this.updateDayBtn_Click);
            // 
            // updateYearBtn
            // 
            this.updateYearBtn.Location = new System.Drawing.Point(190, 212);
            this.updateYearBtn.Name = "updateYearBtn";
            this.updateYearBtn.Size = new System.Drawing.Size(90, 23);
            this.updateYearBtn.TabIndex = 6;
            this.updateYearBtn.Text = "Update Year";
            this.updateYearBtn.UseVisualStyleBackColor = true;
            this.updateYearBtn.Click += new System.EventHandler(this.updateYearBtn_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Location = new System.Drawing.Point(101, 63);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 18);
            this.dateLabel.TabIndex = 7;
            // 
            // yearTxtBox
            // 
            this.yearTxtBox.Location = new System.Drawing.Point(75, 214);
            this.yearTxtBox.Name = "yearTxtBox";
            this.yearTxtBox.Size = new System.Drawing.Size(100, 20);
            this.yearTxtBox.TabIndex = 8;
            // 
            // dayTxtBox
            // 
            this.dayTxtBox.Location = new System.Drawing.Point(75, 175);
            this.dayTxtBox.Name = "dayTxtBox";
            this.dayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.dayTxtBox.TabIndex = 9;
            // 
            // monthTxtBox
            // 
            this.monthTxtBox.Location = new System.Drawing.Point(75, 135);
            this.monthTxtBox.Name = "monthTxtBox";
            this.monthTxtBox.Size = new System.Drawing.Size(100, 20);
            this.monthTxtBox.TabIndex = 10;
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.monthTxtBox);
            this.Controls.Add(this.dayTxtBox);
            this.Controls.Add(this.yearTxtBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.updateYearBtn);
            this.Controls.Add(this.updateDayBtn);
            this.Controls.Add(this.updateMonthBtn);
            this.Controls.Add(this.date1Label);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Name = "DateForm";
            this.Text = "Lab 8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label date1Label;
        private System.Windows.Forms.Button updateMonthBtn;
        private System.Windows.Forms.Button updateDayBtn;
        private System.Windows.Forms.Button updateYearBtn;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox yearTxtBox;
        private System.Windows.Forms.TextBox dayTxtBox;
        private System.Windows.Forms.TextBox monthTxtBox;
    }
}

