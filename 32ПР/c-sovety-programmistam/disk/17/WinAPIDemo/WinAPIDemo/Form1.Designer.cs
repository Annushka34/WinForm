namespace WinAPIDemo
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
            this.butLockComp = new System.Windows.Forms.Button();
            this.butFlashWindow = new System.Windows.Forms.Button();
            this.butOpenCD = new System.Windows.Forms.Button();
            this.butCloseCD = new System.Windows.Forms.Button();
            this.butIsAdmin = new System.Windows.Forms.Button();
            this.butFormatDiskDial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butLockComp
            // 
            this.butLockComp.Location = new System.Drawing.Point(12, 12);
            this.butLockComp.Name = "butLockComp";
            this.butLockComp.Size = new System.Drawing.Size(124, 43);
            this.butLockComp.TabIndex = 4;
            this.butLockComp.Text = "Блокировка";
            this.butLockComp.UseVisualStyleBackColor = true;
            this.butLockComp.Click += new System.EventHandler(this.butLockComp_Click);
            // 
            // butFlashWindow
            // 
            this.butFlashWindow.Location = new System.Drawing.Point(12, 110);
            this.butFlashWindow.Name = "butFlashWindow";
            this.butFlashWindow.Size = new System.Drawing.Size(124, 43);
            this.butFlashWindow.TabIndex = 5;
            this.butFlashWindow.Text = "Мигнуть";
            this.butFlashWindow.UseVisualStyleBackColor = true;
            this.butFlashWindow.Click += new System.EventHandler(this.butFlashWindow_Click);
            // 
            // butOpenCD
            // 
            this.butOpenCD.Location = new System.Drawing.Point(271, 28);
            this.butOpenCD.Name = "butOpenCD";
            this.butOpenCD.Size = new System.Drawing.Size(124, 43);
            this.butOpenCD.TabIndex = 6;
            this.butOpenCD.Text = "Открыть CD";
            this.butOpenCD.UseVisualStyleBackColor = true;
            this.butOpenCD.Click += new System.EventHandler(this.butOpenCD_Click);
            // 
            // butCloseCD
            // 
            this.butCloseCD.Location = new System.Drawing.Point(271, 92);
            this.butCloseCD.Name = "butCloseCD";
            this.butCloseCD.Size = new System.Drawing.Size(124, 43);
            this.butCloseCD.TabIndex = 7;
            this.butCloseCD.Text = "Закрыть CD";
            this.butCloseCD.UseVisualStyleBackColor = true;
            this.butCloseCD.Click += new System.EventHandler(this.butCloseCD_Click);
            // 
            // butIsAdmin
            // 
            this.butIsAdmin.Location = new System.Drawing.Point(12, 61);
            this.butIsAdmin.Name = "butIsAdmin";
            this.butIsAdmin.Size = new System.Drawing.Size(124, 43);
            this.butIsAdmin.TabIndex = 8;
            this.butIsAdmin.Text = "Вы админ?";
            this.butIsAdmin.UseVisualStyleBackColor = true;
            this.butIsAdmin.Click += new System.EventHandler(this.butIsAdmin_Click);
            // 
            // butFormatDiskDial
            // 
            this.butFormatDiskDial.Location = new System.Drawing.Point(12, 159);
            this.butFormatDiskDial.Name = "butFormatDiskDial";
            this.butFormatDiskDial.Size = new System.Drawing.Size(124, 43);
            this.butFormatDiskDial.TabIndex = 9;
            this.butFormatDiskDial.Text = "Форматировать диск";
            this.butFormatDiskDial.UseVisualStyleBackColor = true;
            this.butFormatDiskDial.Click += new System.EventHandler(this.butFormatDiskDial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 252);
            this.Controls.Add(this.butFormatDiskDial);
            this.Controls.Add(this.butIsAdmin);
            this.Controls.Add(this.butCloseCD);
            this.Controls.Add(this.butOpenCD);
            this.Controls.Add(this.butFlashWindow);
            this.Controls.Add(this.butLockComp);
            this.Name = "Form1";
            this.Text = "WinAPI Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butLockComp;
        private System.Windows.Forms.Button butFlashWindow;
        private System.Windows.Forms.Button butOpenCD;
        private System.Windows.Forms.Button butCloseCD;
        private System.Windows.Forms.Button butIsAdmin;
        private System.Windows.Forms.Button butFormatDiskDial;
    }
}

