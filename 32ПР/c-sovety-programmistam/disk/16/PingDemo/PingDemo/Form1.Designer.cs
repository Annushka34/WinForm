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
            this.butPing = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // butPing
            // 
            this.butPing.Location = new System.Drawing.Point(66, 12);
            this.butPing.Name = "butPing";
            this.butPing.Size = new System.Drawing.Size(132, 39);
            this.butPing.TabIndex = 0;
            this.butPing.Text = "Ping";
            this.butPing.UseVisualStyleBackColor = true;
            this.butPing.Click += new System.EventHandler(this.butPing_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 180);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 260);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.butPing);
            this.Name = "Form1";
            this.Text = "Ping Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butPing;
        private System.Windows.Forms.ListBox listBox1;
    }
}

