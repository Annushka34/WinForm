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
            this.cboCulture = new System.Windows.Forms.ComboBox();
            this.lstMonth = new System.Windows.Forms.ListBox();
            this.lstWeek = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboCulture
            // 
            this.cboCulture.FormattingEnabled = true;
            this.cboCulture.Location = new System.Drawing.Point(12, 22);
            this.cboCulture.Name = "cboCulture";
            this.cboCulture.Size = new System.Drawing.Size(267, 24);
            this.cboCulture.TabIndex = 0;
            this.cboCulture.SelectedValueChanged += new System.EventHandler(this.cboCulture_SelectedValueChanged);
            // 
            // lstMonth
            // 
            this.lstMonth.FormattingEnabled = true;
            this.lstMonth.ItemHeight = 16;
            this.lstMonth.Location = new System.Drawing.Point(12, 67);
            this.lstMonth.Name = "lstMonth";
            this.lstMonth.Size = new System.Drawing.Size(104, 196);
            this.lstMonth.TabIndex = 1;
            // 
            // lstWeek
            // 
            this.lstWeek.FormattingEnabled = true;
            this.lstWeek.ItemHeight = 16;
            this.lstWeek.Location = new System.Drawing.Point(174, 67);
            this.lstWeek.Name = "lstWeek";
            this.lstWeek.Size = new System.Drawing.Size(105, 196);
            this.lstWeek.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 303);
            this.Controls.Add(this.lstWeek);
            this.Controls.Add(this.lstMonth);
            this.Controls.Add(this.cboCulture);
            this.Name = "Form1";
            this.Text = "Названия месяцев и недель";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCulture;
        private System.Windows.Forms.ListBox lstMonth;
        private System.Windows.Forms.ListBox lstWeek;
    }
}

