namespace _01_Form
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
            this.btnPressMe = new System.Windows.Forms.Button();
            this.lblMsgBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPressMe
            // 
            this.btnPressMe.BackColor = System.Drawing.Color.Red;
            this.btnPressMe.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnPressMe.Location = new System.Drawing.Point(288, 166);
            this.btnPressMe.Name = "btnPressMe";
            this.btnPressMe.Size = new System.Drawing.Size(225, 66);
            this.btnPressMe.TabIndex = 0;
            this.btnPressMe.Text = "PRESS ME";
            this.btnPressMe.UseVisualStyleBackColor = false;
            this.btnPressMe.Visible = false;
            // 
            // lblMsgBox
            // 
            this.lblMsgBox.AutoSize = true;
            this.lblMsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMsgBox.Location = new System.Drawing.Point(29, 23);
            this.lblMsgBox.Name = "lblMsgBox";
            this.lblMsgBox.Size = new System.Drawing.Size(2, 15);
            this.lblMsgBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMsgBox);
            this.Controls.Add(this.btnPressMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DoubleClick += new System.EventHandler(this.button1_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPressMe;
        private System.Windows.Forms.Label lblMsgBox;
    }
}

