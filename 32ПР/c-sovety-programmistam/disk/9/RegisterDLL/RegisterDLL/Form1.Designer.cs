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
            this.butRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butRegister
            // 
            this.butRegister.Location = new System.Drawing.Point(178, 67);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(173, 32);
            this.butRegister.TabIndex = 0;
            this.butRegister.Text = "Регистрировать";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 260);
            this.Controls.Add(this.butRegister);
            this.Name = "Form1";
            this.Text = "Регистрация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butRegister;
    }
}

