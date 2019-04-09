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
            this.butGetUserInfo = new System.Windows.Forms.Button();
            this.butGetUserInfo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butGetUserInfo
            // 
            this.butGetUserInfo.Location = new System.Drawing.Point(68, 27);
            this.butGetUserInfo.Name = "butGetUserInfo";
            this.butGetUserInfo.Size = new System.Drawing.Size(139, 47);
            this.butGetUserInfo.TabIndex = 0;
            this.butGetUserInfo.Text = "Текущий пользователь";
            this.butGetUserInfo.UseVisualStyleBackColor = true;
            this.butGetUserInfo.Click += new System.EventHandler(this.butGetUserInfo_Click);
            // 
            // butGetUserInfo2
            // 
            this.butGetUserInfo2.Location = new System.Drawing.Point(68, 94);
            this.butGetUserInfo2.Name = "butGetUserInfo2";
            this.butGetUserInfo2.Size = new System.Drawing.Size(139, 41);
            this.butGetUserInfo2.TabIndex = 1;
            this.butGetUserInfo2.Text = "Второй способ";
            this.butGetUserInfo2.UseVisualStyleBackColor = true;
            this.butGetUserInfo2.Click += new System.EventHandler(this.butGetUserInfo2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 260);
            this.Controls.Add(this.butGetUserInfo2);
            this.Controls.Add(this.butGetUserInfo);
            this.Name = "Form1";
            this.Text = "User";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butGetUserInfo;
        private System.Windows.Forms.Button butGetUserInfo2;
    }
}

