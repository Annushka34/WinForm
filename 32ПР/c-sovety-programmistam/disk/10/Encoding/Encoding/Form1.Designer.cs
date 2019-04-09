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
            this.butKOI8R = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butSaveWin1251 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butKOI8R
            // 
            this.butKOI8R.Location = new System.Drawing.Point(12, 138);
            this.butKOI8R.Name = "butKOI8R";
            this.butKOI8R.Size = new System.Drawing.Size(129, 44);
            this.butKOI8R.TabIndex = 0;
            this.butKOI8R.Text = "Прочитать KOI8-R";
            this.butKOI8R.UseVisualStyleBackColor = true;
            this.butKOI8R.Click += new System.EventHandler(this.butKOI8R_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 120);
            this.textBox1.TabIndex = 1;
            // 
            // butSaveWin1251
            // 
            this.butSaveWin1251.Location = new System.Drawing.Point(12, 188);
            this.butSaveWin1251.Name = "butSaveWin1251";
            this.butSaveWin1251.Size = new System.Drawing.Size(129, 45);
            this.butSaveWin1251.TabIndex = 2;
            this.butSaveWin1251.Text = "Сохранить в Windows-1251";
            this.butSaveWin1251.UseVisualStyleBackColor = true;
            this.butSaveWin1251.Click += new System.EventHandler(this.butSaveWin1251_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 260);
            this.Controls.Add(this.butSaveWin1251);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butKOI8R);
            this.Name = "Form1";
            this.Text = "Кодировки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butKOI8R;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butSaveWin1251;
    }
}

