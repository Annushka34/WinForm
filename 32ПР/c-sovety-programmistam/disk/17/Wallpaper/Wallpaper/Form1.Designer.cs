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
            this.butSetWallpaper = new System.Windows.Forms.Button();
            this.cboStyleWallpaper = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // butSetWallpaper
            // 
            this.butSetWallpaper.Location = new System.Drawing.Point(260, 22);
            this.butSetWallpaper.Name = "butSetWallpaper";
            this.butSetWallpaper.Size = new System.Drawing.Size(160, 52);
            this.butSetWallpaper.TabIndex = 0;
            this.butSetWallpaper.Text = "Установить новые обои";
            this.butSetWallpaper.UseVisualStyleBackColor = true;
            this.butSetWallpaper.Click += new System.EventHandler(this.butSetWallpaper_Click);
            // 
            // cboStyleWallpaper
            // 
            this.cboStyleWallpaper.FormattingEnabled = true;
            this.cboStyleWallpaper.Location = new System.Drawing.Point(23, 22);
            this.cboStyleWallpaper.Name = "cboStyleWallpaper";
            this.cboStyleWallpaper.Size = new System.Drawing.Size(167, 24);
            this.cboStyleWallpaper.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 180);
            this.Controls.Add(this.cboStyleWallpaper);
            this.Controls.Add(this.butSetWallpaper);
            this.Name = "Form1";
            this.Text = "Обои Рабочего стола";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butSetWallpaper;
        private System.Windows.Forms.ComboBox cboStyleWallpaper;
    }
}

