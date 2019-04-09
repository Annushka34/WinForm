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
            this.butHideStart = new System.Windows.Forms.Button();
            this.butShowStart = new System.Windows.Forms.Button();
            this.butPressStart = new System.Windows.Forms.Button();
            this.butHideTray = new System.Windows.Forms.Button();
            this.butShowTray = new System.Windows.Forms.Button();
            this.butHideClock = new System.Windows.Forms.Button();
            this.butTaskbar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butHideStart
            // 
            this.butHideStart.Location = new System.Drawing.Point(15, 94);
            this.butHideStart.Name = "butHideStart";
            this.butHideStart.Size = new System.Drawing.Size(129, 36);
            this.butHideStart.TabIndex = 0;
            this.butHideStart.Text = "Спрятать Пуск";
            this.butHideStart.UseVisualStyleBackColor = true;
            this.butHideStart.Click += new System.EventHandler(this.butHideStart_Click);
            // 
            // butShowStart
            // 
            this.butShowStart.Location = new System.Drawing.Point(16, 136);
            this.butShowStart.Name = "butShowStart";
            this.butShowStart.Size = new System.Drawing.Size(128, 35);
            this.butShowStart.TabIndex = 1;
            this.butShowStart.Text = "Показать Пуск";
            this.butShowStart.UseVisualStyleBackColor = true;
            this.butShowStart.Click += new System.EventHandler(this.butShowStart_Click);
            // 
            // butPressStart
            // 
            this.butPressStart.Location = new System.Drawing.Point(16, 177);
            this.butPressStart.Name = "butPressStart";
            this.butPressStart.Size = new System.Drawing.Size(128, 39);
            this.butPressStart.TabIndex = 2;
            this.butPressStart.Text = "Нажать на Пуск";
            this.butPressStart.UseVisualStyleBackColor = true;
            this.butPressStart.Click += new System.EventHandler(this.butPressStart_Click);
            // 
            // butHideTray
            // 
            this.butHideTray.Location = new System.Drawing.Point(16, 254);
            this.butHideTray.Name = "butHideTray";
            this.butHideTray.Size = new System.Drawing.Size(164, 42);
            this.butHideTray.TabIndex = 3;
            this.butHideTray.Text = "Спрятать область уведомлений";
            this.butHideTray.UseVisualStyleBackColor = true;
            this.butHideTray.Click += new System.EventHandler(this.butHideTray_Click);
            // 
            // butShowTray
            // 
            this.butShowTray.Location = new System.Drawing.Point(15, 302);
            this.butShowTray.Name = "butShowTray";
            this.butShowTray.Size = new System.Drawing.Size(160, 43);
            this.butShowTray.TabIndex = 4;
            this.butShowTray.Text = "Показать область уведомлений";
            this.butShowTray.UseVisualStyleBackColor = true;
            this.butShowTray.Click += new System.EventHandler(this.butShowTray_Click);
            // 
            // butHideClock
            // 
            this.butHideClock.Location = new System.Drawing.Point(272, 254);
            this.butHideClock.Name = "butHideClock";
            this.butHideClock.Size = new System.Drawing.Size(158, 42);
            this.butHideClock.TabIndex = 5;
            this.butHideClock.Text = "Спрятать часики";
            this.butHideClock.UseVisualStyleBackColor = true;
            this.butHideClock.Click += new System.EventHandler(this.butHideClock_Click);
            // 
            // butTaskbar
            // 
            this.butTaskbar.Location = new System.Drawing.Point(16, 21);
            this.butTaskbar.Name = "butTaskbar";
            this.butTaskbar.Size = new System.Drawing.Size(132, 38);
            this.butTaskbar.TabIndex = 6;
            this.butTaskbar.Text = "Панель задач";
            this.butTaskbar.UseVisualStyleBackColor = true;
            this.butTaskbar.Click += new System.EventHandler(this.butTaskbar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 472);
            this.Controls.Add(this.butTaskbar);
            this.Controls.Add(this.butHideClock);
            this.Controls.Add(this.butShowTray);
            this.Controls.Add(this.butHideTray);
            this.Controls.Add(this.butPressStart);
            this.Controls.Add(this.butShowStart);
            this.Controls.Add(this.butHideStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butHideStart;
        private System.Windows.Forms.Button butShowStart;
        private System.Windows.Forms.Button butPressStart;
        private System.Windows.Forms.Button butHideTray;
        private System.Windows.Forms.Button butShowTray;
        private System.Windows.Forms.Button butHideClock;
        private System.Windows.Forms.Button butTaskbar;
    }
}

