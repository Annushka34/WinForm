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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.butProcessIE = new System.Windows.Forms.Button();
            this.butRemoteProcess = new System.Windows.Forms.Button();
            this.butWindowProcess = new System.Windows.Forms.Button();
            this.butSendMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 260);
            this.listBox1.TabIndex = 0;
            // 
            // butProcessIE
            // 
            this.butProcessIE.Location = new System.Drawing.Point(12, 278);
            this.butProcessIE.Name = "butProcessIE";
            this.butProcessIE.Size = new System.Drawing.Size(150, 48);
            this.butProcessIE.TabIndex = 1;
            this.butProcessIE.Text = "Процессы для IE";
            this.butProcessIE.UseVisualStyleBackColor = true;
            this.butProcessIE.Click += new System.EventHandler(this.butProcessIE_Click);
            // 
            // butRemoteProcess
            // 
            this.butRemoteProcess.Location = new System.Drawing.Point(12, 332);
            this.butRemoteProcess.Name = "butRemoteProcess";
            this.butRemoteProcess.Size = new System.Drawing.Size(150, 50);
            this.butRemoteProcess.TabIndex = 2;
            this.butRemoteProcess.Text = "Процессы на удаленной машине";
            this.butRemoteProcess.UseVisualStyleBackColor = true;
            this.butRemoteProcess.Click += new System.EventHandler(this.butRemoteProcess_Click);
            // 
            // butWindowProcess
            // 
            this.butWindowProcess.Location = new System.Drawing.Point(168, 278);
            this.butWindowProcess.Name = "butWindowProcess";
            this.butWindowProcess.Size = new System.Drawing.Size(160, 48);
            this.butWindowProcess.TabIndex = 3;
            this.butWindowProcess.Text = "Оконные процессы";
            this.butWindowProcess.UseVisualStyleBackColor = true;
            this.butWindowProcess.Click += new System.EventHandler(this.butWindowProcess_Click);
            // 
            // butSendMail
            // 
            this.butSendMail.Location = new System.Drawing.Point(168, 332);
            this.butSendMail.Name = "butSendMail";
            this.butSendMail.Size = new System.Drawing.Size(155, 49);
            this.butSendMail.TabIndex = 4;
            this.butSendMail.Text = "Послать письмо";
            this.butSendMail.UseVisualStyleBackColor = true;
            this.butSendMail.Click += new System.EventHandler(this.butSendMail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 453);
            this.Controls.Add(this.butSendMail);
            this.Controls.Add(this.butWindowProcess);
            this.Controls.Add(this.butRemoteProcess);
            this.Controls.Add(this.butProcessIE);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Процессы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button butProcessIE;
        private System.Windows.Forms.Button butRemoteProcess;
        private System.Windows.Forms.Button butWindowProcess;
        private System.Windows.Forms.Button butSendMail;
    }
}

