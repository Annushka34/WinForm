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
            this.butDenyAccess = new System.Windows.Forms.Button();
            this.butAllowAccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butDenyAccess
            // 
            this.butDenyAccess.Location = new System.Drawing.Point(91, 42);
            this.butDenyAccess.Name = "butDenyAccess";
            this.butDenyAccess.Size = new System.Drawing.Size(163, 52);
            this.butDenyAccess.TabIndex = 19;
            this.butDenyAccess.Text = "Отказать в доступе";
            this.butDenyAccess.UseVisualStyleBackColor = true;
            this.butDenyAccess.Click += new System.EventHandler(this.butDenyAccess_Click);
            // 
            // butAllowAccess
            // 
            this.butAllowAccess.Location = new System.Drawing.Point(95, 119);
            this.butAllowAccess.Name = "butAllowAccess";
            this.butAllowAccess.Size = new System.Drawing.Size(159, 51);
            this.butAllowAccess.TabIndex = 20;
            this.butAllowAccess.Text = "Разрешить доступ";
            this.butAllowAccess.UseVisualStyleBackColor = true;
            this.butAllowAccess.Click += new System.EventHandler(this.butAllowAccess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 260);
            this.Controls.Add(this.butAllowAccess);
            this.Controls.Add(this.butDenyAccess);
            this.Name = "Form1";
            this.Text = "Доступ к файлам";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butDenyAccess;
        private System.Windows.Forms.Button butAllowAccess;
    }
}

