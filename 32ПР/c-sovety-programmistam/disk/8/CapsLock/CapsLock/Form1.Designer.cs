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
            this.butCapsLock = new System.Windows.Forms.Button();
            this.butNumLock = new System.Windows.Forms.Button();
            this.butScrollLock = new System.Windows.Forms.Button();
            this.lblCapsLock = new System.Windows.Forms.Label();
            this.butStatus = new System.Windows.Forms.Button();
            this.butNumLockState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butCapsLock
            // 
            this.butCapsLock.Location = new System.Drawing.Point(40, 185);
            this.butCapsLock.Name = "butCapsLock";
            this.butCapsLock.Size = new System.Drawing.Size(130, 45);
            this.butCapsLock.TabIndex = 0;
            this.butCapsLock.Text = "Caps Lock";
            this.butCapsLock.UseVisualStyleBackColor = true;
            this.butCapsLock.Click += new System.EventHandler(this.butCapsLock_Click);
            // 
            // butNumLock
            // 
            this.butNumLock.Location = new System.Drawing.Point(186, 185);
            this.butNumLock.Name = "butNumLock";
            this.butNumLock.Size = new System.Drawing.Size(143, 45);
            this.butNumLock.TabIndex = 1;
            this.butNumLock.Text = "Num Lock";
            this.butNumLock.UseVisualStyleBackColor = true;
            this.butNumLock.Click += new System.EventHandler(this.butNumLock_Click);
            // 
            // butScrollLock
            // 
            this.butScrollLock.Location = new System.Drawing.Point(348, 185);
            this.butScrollLock.Name = "butScrollLock";
            this.butScrollLock.Size = new System.Drawing.Size(144, 42);
            this.butScrollLock.TabIndex = 2;
            this.butScrollLock.Text = "Scroll Lock";
            this.butScrollLock.UseVisualStyleBackColor = true;
            this.butScrollLock.Click += new System.EventHandler(this.butScrollLock_Click);
            // 
            // lblCapsLock
            // 
            this.lblCapsLock.AutoSize = true;
            this.lblCapsLock.Location = new System.Drawing.Point(24, 23);
            this.lblCapsLock.Name = "lblCapsLock";
            this.lblCapsLock.Size = new System.Drawing.Size(78, 17);
            this.lblCapsLock.TabIndex = 3;
            this.lblCapsLock.Text = "Caps Lock:";
            // 
            // butStatus
            // 
            this.butStatus.Location = new System.Drawing.Point(40, 245);
            this.butStatus.Name = "butStatus";
            this.butStatus.Size = new System.Drawing.Size(170, 47);
            this.butStatus.TabIndex = 4;
            this.butStatus.Text = "Состояние Caps Lock (API)";
            this.butStatus.UseVisualStyleBackColor = true;
            this.butStatus.Click += new System.EventHandler(this.butStatus_Click);
            // 
            // butNumLockState
            // 
            this.butNumLockState.Location = new System.Drawing.Point(334, 245);
            this.butNumLockState.Name = "butNumLockState";
            this.butNumLockState.Size = new System.Drawing.Size(158, 47);
            this.butNumLockState.TabIndex = 5;
            this.butNumLockState.Text = "Состояние Caps Lock (.NET)";
            this.butNumLockState.UseVisualStyleBackColor = true;
            this.butNumLockState.Click += new System.EventHandler(this.butNumLockState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 313);
            this.Controls.Add(this.butNumLockState);
            this.Controls.Add(this.butStatus);
            this.Controls.Add(this.lblCapsLock);
            this.Controls.Add(this.butScrollLock);
            this.Controls.Add(this.butNumLock);
            this.Controls.Add(this.butCapsLock);
            this.Name = "Form1";
            this.Text = "Caps Lock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCapsLock;
        private System.Windows.Forms.Button butNumLock;
        private System.Windows.Forms.Button butScrollLock;
        private System.Windows.Forms.Label lblCapsLock;
        private System.Windows.Forms.Button butStatus;
        private System.Windows.Forms.Button butNumLockState;
    }
}

