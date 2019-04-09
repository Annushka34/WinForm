namespace AboutScreen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butScreenRes = new System.Windows.Forms.Button();
            this.butWorkArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 63);
            this.textBox1.TabIndex = 0;
            // 
            // butScreenRes
            // 
            this.butScreenRes.Location = new System.Drawing.Point(78, 103);
            this.butScreenRes.Name = "butScreenRes";
            this.butScreenRes.Size = new System.Drawing.Size(141, 49);
            this.butScreenRes.TabIndex = 1;
            this.butScreenRes.Text = "Разрешение экрана";
            this.butScreenRes.UseVisualStyleBackColor = true;
            this.butScreenRes.Click += new System.EventHandler(this.butScreenRes_Click);
            // 
            // butWorkArea
            // 
            this.butWorkArea.Location = new System.Drawing.Point(78, 169);
            this.butWorkArea.Name = "butWorkArea";
            this.butWorkArea.Size = new System.Drawing.Size(141, 46);
            this.butWorkArea.TabIndex = 2;
            this.butWorkArea.Text = "Рабочая область экрана";
            this.butWorkArea.UseVisualStyleBackColor = true;
            this.butWorkArea.Click += new System.EventHandler(this.butWorkArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 246);
            this.Controls.Add(this.butWorkArea);
            this.Controls.Add(this.butScreenRes);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Примеры для экрана";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butScreenRes;
        private System.Windows.Forms.Button butWorkArea;
    }
}

