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
            this.butGetDNS = new System.Windows.Forms.Button();
            this.butGetLocalIP = new System.Windows.Forms.Button();
            this.butGetNETBIOS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butGetDNS
            // 
            this.butGetDNS.Location = new System.Drawing.Point(12, 12);
            this.butGetDNS.Name = "butGetDNS";
            this.butGetDNS.Size = new System.Drawing.Size(142, 33);
            this.butGetDNS.TabIndex = 0;
            this.butGetDNS.Text = "Получить DNS";
            this.butGetDNS.UseVisualStyleBackColor = true;
            this.butGetDNS.Click += new System.EventHandler(this.butGetDNS_Click);
            // 
            // butGetLocalIP
            // 
            this.butGetLocalIP.Location = new System.Drawing.Point(12, 51);
            this.butGetLocalIP.Name = "butGetLocalIP";
            this.butGetLocalIP.Size = new System.Drawing.Size(142, 30);
            this.butGetLocalIP.TabIndex = 1;
            this.butGetLocalIP.Text = "IP локальной машины";
            this.butGetLocalIP.UseVisualStyleBackColor = true;
            this.butGetLocalIP.Click += new System.EventHandler(this.butGetLocalIP_Click_1);
            // 
            // butGetNETBIOS
            // 
            this.butGetNETBIOS.Location = new System.Drawing.Point(12, 87);
            this.butGetNETBIOS.Name = "butGetNETBIOS";
            this.butGetNETBIOS.Size = new System.Drawing.Size(142, 30);
            this.butGetNETBIOS.TabIndex = 2;
            this.butGetNETBIOS.Text = "NETBIOS";
            this.butGetNETBIOS.UseVisualStyleBackColor = true;
            this.butGetNETBIOS.Click += new System.EventHandler(this.butGetNETBIOS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 260);
            this.Controls.Add(this.butGetNETBIOS);
            this.Controls.Add(this.butGetLocalIP);
            this.Controls.Add(this.butGetDNS);
            this.Name = "Form1";
            this.Text = "DNS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butGetDNS;
        private System.Windows.Forms.Button butGetLocalIP;
        private System.Windows.Forms.Button butGetNETBIOS;
    }
}

