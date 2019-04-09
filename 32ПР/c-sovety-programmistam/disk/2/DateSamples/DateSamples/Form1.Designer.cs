namespace WindowsApplication1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.butCompare = new System.Windows.Forms.Button();
            this.butTimeSpan = new System.Windows.Forms.Button();
            this.butDateDiffVB = new System.Windows.Forms.Button();
            this.butDateDiffCS = new System.Windows.Forms.Button();
            this.butLeapYear = new System.Windows.Forms.Button();
            this.butEaster = new System.Windows.Forms.Button();
            this.butDateTime = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Текущее время";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butCompare
            // 
            this.butCompare.Location = new System.Drawing.Point(12, 81);
            this.butCompare.Name = "butCompare";
            this.butCompare.Size = new System.Drawing.Size(159, 49);
            this.butCompare.TabIndex = 1;
            this.butCompare.Text = "Сравниваем производительность";
            this.butCompare.UseVisualStyleBackColor = true;
            this.butCompare.Click += new System.EventHandler(this.butCompare_Click);
            // 
            // butTimeSpan
            // 
            this.butTimeSpan.Location = new System.Drawing.Point(12, 136);
            this.butTimeSpan.Name = "butTimeSpan";
            this.butTimeSpan.Size = new System.Drawing.Size(159, 44);
            this.butTimeSpan.TabIndex = 2;
            this.butTimeSpan.Text = "+ 7 дней";
            this.butTimeSpan.UseVisualStyleBackColor = true;
            this.butTimeSpan.Click += new System.EventHandler(this.butTimeSpan_Click);
            // 
            // butDateDiffVB
            // 
            this.butDateDiffVB.Location = new System.Drawing.Point(208, 26);
            this.butDateDiffVB.Name = "butDateDiffVB";
            this.butDateDiffVB.Size = new System.Drawing.Size(159, 47);
            this.butDateDiffVB.TabIndex = 3;
            this.butDateDiffVB.Text = "DateDiff (VB)";
            this.butDateDiffVB.UseVisualStyleBackColor = true;
            this.butDateDiffVB.Click += new System.EventHandler(this.butDateDiffVB_Click);
            // 
            // butDateDiffCS
            // 
            this.butDateDiffCS.Location = new System.Drawing.Point(431, 28);
            this.butDateDiffCS.Name = "butDateDiffCS";
            this.butDateDiffCS.Size = new System.Drawing.Size(159, 47);
            this.butDateDiffCS.TabIndex = 4;
            this.butDateDiffCS.Text = "DateDiff (C#)";
            this.butDateDiffCS.UseVisualStyleBackColor = true;
            this.butDateDiffCS.Click += new System.EventHandler(this.butDateDiffCS_Click);
            // 
            // butLeapYear
            // 
            this.butLeapYear.Location = new System.Drawing.Point(12, 186);
            this.butLeapYear.Name = "butLeapYear";
            this.butLeapYear.Size = new System.Drawing.Size(159, 46);
            this.butLeapYear.TabIndex = 5;
            this.butLeapYear.Text = "Високосный ли год?";
            this.butLeapYear.UseVisualStyleBackColor = true;
            this.butLeapYear.Click += new System.EventHandler(this.butLeapYear_Click);
            // 
            // butEaster
            // 
            this.butEaster.Location = new System.Drawing.Point(12, 238);
            this.butEaster.Name = "butEaster";
            this.butEaster.Size = new System.Drawing.Size(159, 37);
            this.butEaster.TabIndex = 6;
            this.butEaster.Text = "Пасха";
            this.butEaster.UseVisualStyleBackColor = true;
            this.butEaster.Click += new System.EventHandler(this.butEaster_Click);
            // 
            // butDateTime
            // 
            this.butDateTime.Location = new System.Drawing.Point(307, 105);
            this.butDateTime.Name = "butDateTime";
            this.butDateTime.Size = new System.Drawing.Size(194, 34);
            this.butDateTime.TabIndex = 7;
            this.butDateTime.Text = "Форматы даты и времени";
            this.butDateTime.UseVisualStyleBackColor = true;
            this.butDateTime.Click += new System.EventHandler(this.butDateTime_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(208, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(500, 484);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 652);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.butDateTime);
            this.Controls.Add(this.butEaster);
            this.Controls.Add(this.butLeapYear);
            this.Controls.Add(this.butDateDiffCS);
            this.Controls.Add(this.butDateDiffVB);
            this.Controls.Add(this.butTimeSpan);
            this.Controls.Add(this.butCompare);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Работа с датами";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butCompare;
        private System.Windows.Forms.Button butTimeSpan;
        private System.Windows.Forms.Button butDateDiffVB;
        private System.Windows.Forms.Button butDateDiffCS;
        private System.Windows.Forms.Button butLeapYear;
        private System.Windows.Forms.Button butEaster;
        private System.Windows.Forms.Button butDateTime;
        private System.Windows.Forms.ListBox listBox1;
    }
}

