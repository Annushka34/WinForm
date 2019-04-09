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
            this.butOpenFirefox = new System.Windows.Forms.Button();
            this.butOpenUrl = new System.Windows.Forms.Button();
            this.butTab = new System.Windows.Forms.Button();
            this.butMozillaSite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butOpenFirefox
            // 
            this.butOpenFirefox.Location = new System.Drawing.Point(25, 12);
            this.butOpenFirefox.Name = "butOpenFirefox";
            this.butOpenFirefox.Size = new System.Drawing.Size(144, 43);
            this.butOpenFirefox.TabIndex = 0;
            this.butOpenFirefox.Text = "Запустить Firefox";
            this.butOpenFirefox.UseVisualStyleBackColor = true;
            this.butOpenFirefox.Click += new System.EventHandler(this.butOpenFirefox_Click);
            // 
            // butOpenUrl
            // 
            this.butOpenUrl.Location = new System.Drawing.Point(227, 12);
            this.butOpenUrl.Name = "butOpenUrl";
            this.butOpenUrl.Size = new System.Drawing.Size(144, 43);
            this.butOpenUrl.TabIndex = 1;
            this.butOpenUrl.Text = "Открыть страницу";
            this.butOpenUrl.UseVisualStyleBackColor = true;
            this.butOpenUrl.Click += new System.EventHandler(this.button1_Click);
            // 
            // butTab
            // 
            this.butTab.Location = new System.Drawing.Point(25, 61);
            this.butTab.Name = "butTab";
            this.butTab.Size = new System.Drawing.Size(144, 45);
            this.butTab.TabIndex = 2;
            this.butTab.Text = "Открыть в новой вкладке";
            this.butTab.UseVisualStyleBackColor = true;
            this.butTab.Click += new System.EventHandler(this.butTab_Click);
            // 
            // butMozillaSite
            // 
            this.butMozillaSite.Location = new System.Drawing.Point(227, 61);
            this.butMozillaSite.Name = "butMozillaSite";
            this.butMozillaSite.Size = new System.Drawing.Size(144, 46);
            this.butMozillaSite.TabIndex = 3;
            this.butMozillaSite.Text = "Сайт Firefox (ru)";
            this.butMozillaSite.UseVisualStyleBackColor = true;
            this.butMozillaSite.Click += new System.EventHandler(this.butMozillaSite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 151);
            this.Controls.Add(this.butMozillaSite);
            this.Controls.Add(this.butTab);
            this.Controls.Add(this.butOpenUrl);
            this.Controls.Add(this.butOpenFirefox);
            this.Name = "Form1";
            this.Text = "Примеры с Firefox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butOpenFirefox;
        private System.Windows.Forms.Button butOpenUrl;
        private System.Windows.Forms.Button butTab;
        private System.Windows.Forms.Button butMozillaSite;
    }
}

