namespace _04_Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPswd = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblValidEmail = new System.Windows.Forms.Label();
            this.lblValidPswd = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter password";
            // 
            // txtPswd
            // 
            this.txtPswd.Location = new System.Drawing.Point(16, 111);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.PasswordChar = '*';
            this.txtPswd.Size = new System.Drawing.Size(294, 20);
            this.txtPswd.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 40);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblValidEmail
            // 
            this.lblValidEmail.AutoSize = true;
            this.lblValidEmail.ForeColor = System.Drawing.Color.Red;
            this.lblValidEmail.Location = new System.Drawing.Point(122, 12);
            this.lblValidEmail.Name = "lblValidEmail";
            this.lblValidEmail.Size = new System.Drawing.Size(0, 13);
            this.lblValidEmail.TabIndex = 5;
            // 
            // lblValidPswd
            // 
            this.lblValidPswd.AutoSize = true;
            this.lblValidPswd.ForeColor = System.Drawing.Color.Red;
            this.lblValidPswd.Location = new System.Drawing.Point(125, 81);
            this.lblValidPswd.Name = "lblValidPswd";
            this.lblValidPswd.Size = new System.Drawing.Size(0, 13);
            this.lblValidPswd.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(125, 148);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 187);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblValidPswd);
            this.Controls.Add(this.lblValidEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPswd;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.Label lblValidEmail;
        private System.Windows.Forms.Label lblValidPswd;
        private System.Windows.Forms.Button btnLogin;
    }
}

