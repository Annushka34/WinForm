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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butPrint = new System.Windows.Forms.Button();
            this.butPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "������ ���������";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(358, 265);
            this.textBox1.TabIndex = 1;
            // 
            // butPrint
            // 
            this.butPrint.Location = new System.Drawing.Point(251, 311);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(128, 44);
            this.butPrint.TabIndex = 2;
            this.butPrint.Text = "������";
            this.butPrint.UseVisualStyleBackColor = true;
            this.butPrint.Click += new System.EventHandler(this.butPrint_Click);
            // 
            // butPreview
            // 
            this.butPreview.Location = new System.Drawing.Point(254, 379);
            this.butPreview.Name = "butPreview";
            this.butPreview.Size = new System.Drawing.Size(124, 38);
            this.butPreview.TabIndex = 3;
            this.butPreview.Text = "Preview";
            this.butPreview.UseVisualStyleBackColor = true;
            this.butPreview.Click += new System.EventHandler(this.butPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 473);
            this.Controls.Add(this.butPreview);
            this.Controls.Add(this.butPrint);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "��������";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butPrint;
        private System.Windows.Forms.Button butPreview;
    }
}

