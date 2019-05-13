namespace _14_UserControlComboBox
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
            this.myComboBox1 = new _14_UserControlComboBox.MyComboBox();
            this.btnAplly = new System.Windows.Forms.Button();
            this.lblSelectedRegion = new System.Windows.Forms.Label();
            this.comboBoxWithImg1 = new _14_UserControlComboBox.ComboBoxWithImg();
            this.SuspendLayout();
            // 
            // myComboBox1
            // 
            this.myComboBox1.Location = new System.Drawing.Point(29, 22);
            this.myComboBox1.Name = "myComboBox1";
            this.myComboBox1.Size = new System.Drawing.Size(220, 203);
            this.myComboBox1.TabIndex = 0;
            // 
            // btnAplly
            // 
            this.btnAplly.BackColor = System.Drawing.Color.Green;
            this.btnAplly.Location = new System.Drawing.Point(29, 296);
            this.btnAplly.Name = "btnAplly";
            this.btnAplly.Size = new System.Drawing.Size(220, 42);
            this.btnAplly.TabIndex = 1;
            this.btnAplly.Text = "Apply";
            this.btnAplly.UseVisualStyleBackColor = false;
            this.btnAplly.Click += new System.EventHandler(this.btnAplly_Click);
            // 
            // lblSelectedRegion
            // 
            this.lblSelectedRegion.AutoSize = true;
            this.lblSelectedRegion.Location = new System.Drawing.Point(337, 44);
            this.lblSelectedRegion.Name = "lblSelectedRegion";
            this.lblSelectedRegion.Size = new System.Drawing.Size(0, 17);
            this.lblSelectedRegion.TabIndex = 2;
            // 
            // comboBoxWithImg1
            // 
            this.comboBoxWithImg1.Location = new System.Drawing.Point(364, 44);
            this.comboBoxWithImg1.Name = "comboBoxWithImg1";
            this.comboBoxWithImg1.Size = new System.Drawing.Size(322, 187);
            this.comboBoxWithImg1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxWithImg1);
            this.Controls.Add(this.lblSelectedRegion);
            this.Controls.Add(this.btnAplly);
            this.Controls.Add(this.myComboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyComboBox myComboBox1;
        private System.Windows.Forms.Button btnAplly;
        private System.Windows.Forms.Label lblSelectedRegion;
        private ComboBoxWithImg comboBoxWithImg1;
    }
}

