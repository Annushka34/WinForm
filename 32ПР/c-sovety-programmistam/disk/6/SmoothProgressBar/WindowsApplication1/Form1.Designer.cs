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
            this.components = new System.ComponentModel.Container();
            this.smoothProgressBar1 = new SmoothProgressBar.SmoothProgressBar();
            this.smoothProgressBar2 = new SmoothProgressBar.SmoothProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smoothProgressBar1
            // 
            this.smoothProgressBar1.Location = new System.Drawing.Point(12, 12);
            this.smoothProgressBar1.Maximum = 100;
            this.smoothProgressBar1.Minimum = 0;
            this.smoothProgressBar1.Name = "smoothProgressBar1";
            this.smoothProgressBar1.ProgressBarColor = System.Drawing.Color.Violet;
            this.smoothProgressBar1.Size = new System.Drawing.Size(600, 60);
            this.smoothProgressBar1.TabIndex = 0;
            this.smoothProgressBar1.Value = 0;
            // 
            // smoothProgressBar2
            // 
            this.smoothProgressBar2.Location = new System.Drawing.Point(12, 177);
            this.smoothProgressBar2.Maximum = 100;
            this.smoothProgressBar2.Minimum = 0;
            this.smoothProgressBar2.Name = "smoothProgressBar2";
            this.smoothProgressBar2.ProgressBarColor = System.Drawing.Color.Blue;
            this.smoothProgressBar2.Size = new System.Drawing.Size(600, 60);
            this.smoothProgressBar2.TabIndex = 1;
            this.smoothProgressBar2.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.smoothProgressBar2);
            this.Controls.Add(this.smoothProgressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SmoothProgressBar.SmoothProgressBar smoothProgressBar1;
        private SmoothProgressBar.SmoothProgressBar smoothProgressBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

