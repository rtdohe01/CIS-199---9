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
            this.label1 = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mnth = new System.Windows.Forms.TextBox();
            this.dy = new System.Windows.Forms.TextBox();
            this.yr = new System.Windows.Forms.TextBox();
            this.updateMonth = new System.Windows.Forms.Button();
            this.updateDay = new System.Windows.Forms.Button();
            this.updateYear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(191, 54);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(179, 26);
            this.dateText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Day:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Year:";
            // 
            // mnth
            // 
            this.mnth.Location = new System.Drawing.Point(153, 115);
            this.mnth.Name = "mnth";
            this.mnth.Size = new System.Drawing.Size(139, 26);
            this.mnth.TabIndex = 5;
            // 
            // dy
            // 
            this.dy.Location = new System.Drawing.Point(153, 174);
            this.dy.Name = "dy";
            this.dy.Size = new System.Drawing.Size(138, 26);
            this.dy.TabIndex = 6;
            // 
            // yr
            // 
            this.yr.Location = new System.Drawing.Point(152, 233);
            this.yr.Name = "yr";
            this.yr.Size = new System.Drawing.Size(138, 26);
            this.yr.TabIndex = 7;
            // 
            // updateMonth
            // 
            this.updateMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMonth.Location = new System.Drawing.Point(327, 114);
            this.updateMonth.Name = "updateMonth";
            this.updateMonth.Size = new System.Drawing.Size(152, 35);
            this.updateMonth.TabIndex = 8;
            this.updateMonth.Text = "Update Month";
            this.updateMonth.UseVisualStyleBackColor = true;
            this.updateMonth.Click += new System.EventHandler(this.updateMonth_Click);
            // 
            // updateDay
            // 
            this.updateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDay.Location = new System.Drawing.Point(327, 174);
            this.updateDay.Name = "updateDay";
            this.updateDay.Size = new System.Drawing.Size(152, 36);
            this.updateDay.TabIndex = 9;
            this.updateDay.Text = "Update Day";
            this.updateDay.UseVisualStyleBackColor = true;
            this.updateDay.Click += new System.EventHandler(this.updateDay_Click);
            // 
            // updateYear
            // 
            this.updateYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateYear.Location = new System.Drawing.Point(327, 233);
            this.updateYear.Name = "updateYear";
            this.updateYear.Size = new System.Drawing.Size(152, 39);
            this.updateYear.TabIndex = 10;
            this.updateYear.Text = "Update Year";
            this.updateYear.UseVisualStyleBackColor = true;
            this.updateYear.Click += new System.EventHandler(this.updateYear_Click);
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 314);
            this.Controls.Add(this.updateYear);
            this.Controls.Add(this.updateDay);
            this.Controls.Add(this.updateMonth);
            this.Controls.Add(this.yr);
            this.Controls.Add(this.dy);
            this.Controls.Add(this.mnth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.label1);
            this.Name = "DateForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mnth;
        private System.Windows.Forms.TextBox dy;
        private System.Windows.Forms.TextBox yr;
        private System.Windows.Forms.Button updateMonth;
        private System.Windows.Forms.Button updateDay;
        private System.Windows.Forms.Button updateYear;
    }
}

