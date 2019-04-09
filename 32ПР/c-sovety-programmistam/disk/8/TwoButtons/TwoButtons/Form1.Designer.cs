namespace TwoButtons
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
            this.butYes = new System.Windows.Forms.Button();
            this.butNo = new System.Windows.Forms.Button();
            this.lblGoToSite = new System.Windows.Forms.Label();
            this.lnkSite = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // butYes
            // 
            this.butYes.Location = new System.Drawing.Point(12, 87);
            this.butYes.Name = "butYes";
            this.butYes.Size = new System.Drawing.Size(103, 35);
            this.butYes.TabIndex = 0;
            this.butYes.Text = "Да";
            this.butYes.UseVisualStyleBackColor = true;
            this.butYes.Click += new System.EventHandler(this.butYes_Click);
            // 
            // butNo
            // 
            this.butNo.Location = new System.Drawing.Point(375, 87);
            this.butNo.Name = "butNo";
            this.butNo.Size = new System.Drawing.Size(104, 35);
            this.butNo.TabIndex = 1;
            this.butNo.Text = "Нет";
            this.butNo.UseVisualStyleBackColor = true;
            this.butNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.butNo_MouseMove);
            // 
            // lblGoToSite
            // 
            this.lblGoToSite.Location = new System.Drawing.Point(12, 23);
            this.lblGoToSite.Name = "lblGoToSite";
            this.lblGoToSite.Size = new System.Drawing.Size(467, 40);
            this.lblGoToSite.TabIndex = 2;
            this.lblGoToSite.Text = "Вы хотите посетить сайт http://rusproject.narod.ru/?";
            this.lblGoToSite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnkSite
            // 
            this.lnkSite.AutoSize = true;
            this.lnkSite.Location = new System.Drawing.Point(149, 172);
            this.lnkSite.Name = "lnkSite";
            this.lnkSite.Size = new System.Drawing.Size(165, 17);
            this.lnkSite.TabIndex = 3;
            this.lnkSite.TabStop = true;
            this.lnkSite.Text = "http://rusproject.narod.ru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 260);
            this.Controls.Add(this.lnkSite);
            this.Controls.Add(this.lblGoToSite);
            this.Controls.Add(this.butNo);
            this.Controls.Add(this.butYes);
            this.Name = "Form1";
            this.Text = "Мышь и две кнопки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butYes;
        private System.Windows.Forms.Button butNo;
        private System.Windows.Forms.Label lblGoToSite;
        private System.Windows.Forms.LinkLabel lnkSite;
    }
}

