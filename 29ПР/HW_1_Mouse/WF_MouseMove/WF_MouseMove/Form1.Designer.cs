namespace WF_MouseMove
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_catch = new System.Windows.Forms.Label();
            this.tTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_catch
            // 
            this.lbl_catch.AutoSize = true;
            this.lbl_catch.Location = new System.Drawing.Point(104, 120);
            this.lbl_catch.Name = "lbl_catch";
            this.lbl_catch.Size = new System.Drawing.Size(67, 13);
            this.lbl_catch.TabIndex = 0;
            this.lbl_catch.Text = "Злови мене";
            this.lbl_catch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_catch_MouseMove);
            // 
            // tTimer
            // 
            this.tTimer.Interval = 4000;
            this.tTimer.Tick += new System.EventHandler(this.tTimer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(96, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_catch);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ловилка";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_catch;
        private System.Windows.Forms.Timer tTimer;
        private System.Windows.Forms.Button button1;
    }
}

