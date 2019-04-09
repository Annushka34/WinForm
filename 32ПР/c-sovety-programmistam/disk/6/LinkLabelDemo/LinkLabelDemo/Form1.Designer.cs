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
            this.lnkMySite = new System.Windows.Forms.LinkLabel();
            this.lnkSearchUrl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkMySite
            // 
            this.lnkMySite.LinkArea = new System.Windows.Forms.LinkArea(3, 11);
            this.lnkMySite.Location = new System.Drawing.Point(67, 18);
            this.lnkMySite.Name = "lnkMySite";
            this.lnkMySite.Size = new System.Drawing.Size(230, 65);
            this.lnkMySite.TabIndex = 0;
            this.lnkMySite.TabStop = true;
            this.lnkMySite.Text = "На нашем сайте вы можете найти дополнительную информацию";
            this.lnkMySite.UseCompatibleTextRendering = true;
            this.lnkMySite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMySite_LinkClicked);
            // 
            // lnkSearchUrl
            // 
            this.lnkSearchUrl.AutoSize = true;
            this.lnkSearchUrl.Location = new System.Drawing.Point(12, 121);
            this.lnkSearchUrl.Name = "lnkSearchUrl";
            this.lnkSearchUrl.Size = new System.Drawing.Size(206, 17);
            this.lnkSearchUrl.TabIndex = 1;
            this.lnkSearchUrl.TabStop = true;
            this.lnkSearchUrl.Text = "Yandex Googgle Rambler gogo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 260);
            this.Controls.Add(this.lnkSearchUrl);
            this.Controls.Add(this.lnkMySite);
            this.Name = "Form1";
            this.Text = "Примеры с LinkLabel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkMySite;
        private System.Windows.Forms.LinkLabel lnkSearchUrl;
    }
}

