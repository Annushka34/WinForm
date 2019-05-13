namespace _14_UserControls
{
    partial class Form2
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
            this.myButton1 = new _14_UserControls.MyButton();
            this.myButton2 = new _14_UserControls.MyButton();
            this.myProgressBar1 = new _14_UserControls.MyProgressBar();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.Location = new System.Drawing.Point(549, 40);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(226, 76);
            this.myButton1.TabIndex = 0;
            // 
            // myButton2
            // 
            this.myButton2.Location = new System.Drawing.Point(28, 323);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(226, 76);
            this.myButton2.TabIndex = 1;
            // 
            // myProgressBar1
            // 
            this.myProgressBar1.Location = new System.Drawing.Point(28, 23);
            this.myProgressBar1.Name = "myProgressBar1";
            this.myProgressBar1.Size = new System.Drawing.Size(273, 63);
            this.myProgressBar1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myProgressBar1);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton myButton1;
        private MyButton myButton2;
        private MyProgressBar myProgressBar1;
    }
}