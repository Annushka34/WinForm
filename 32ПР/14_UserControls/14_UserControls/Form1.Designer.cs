namespace _14_UserControls
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
            this.myButton1 = new _14_UserControls.MyButton();
            this.myButton2 = new _14_UserControls.MyButton();
            this.myButton3 = new _14_UserControls.MyButton();
            this.btnGetState = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.Location = new System.Drawing.Point(26, 13);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(226, 76);
            this.myButton1.TabIndex = 0;
            // 
            // myButton2
            // 
            this.myButton2.Location = new System.Drawing.Point(26, 149);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(226, 76);
            this.myButton2.TabIndex = 1;
            // 
            // myButton3
            // 
            this.myButton3.Location = new System.Drawing.Point(26, 283);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(226, 76);
            this.myButton3.TabIndex = 2;
            // 
            // btnGetState
            // 
            this.btnGetState.Location = new System.Drawing.Point(446, 13);
            this.btnGetState.Name = "btnGetState";
            this.btnGetState.Size = new System.Drawing.Size(111, 158);
            this.btnGetState.TabIndex = 3;
            this.btnGetState.Text = "GetState";
            this.btnGetState.UseVisualStyleBackColor = true;
            this.btnGetState.Click += new System.EventHandler(this.btnGetState_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(271, 208);
            this.lblState.MinimumSize = new System.Drawing.Size(200, 200);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(200, 200);
            this.lblState.TabIndex = 4;
            this.lblState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(26, 394);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(161, 28);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "ChangeLbl1Text";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnGetState);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton myButton1;
        private MyButton myButton2;
        private MyButton myButton3;
        private System.Windows.Forms.Button btnGetState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnTest;
    }
}

