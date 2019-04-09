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
            this.butTo16 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butBin = new System.Windows.Forms.Button();
            this.butConvert = new System.Windows.Forms.Button();
            this.butGuid = new System.Windows.Forms.Button();
            this.butIsNumericVB = new System.Windows.Forms.Button();
            this.butIsNumericCS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butTo16
            // 
            this.butTo16.Location = new System.Drawing.Point(12, 23);
            this.butTo16.Name = "butTo16";
            this.butTo16.Size = new System.Drawing.Size(134, 50);
            this.butTo16.TabIndex = 0;
            this.butTo16.Text = "Шестнадцатеричное значение";
            this.butTo16.UseVisualStyleBackColor = true;
            this.butTo16.Click += new System.EventHandler(this.butToString_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 22);
            this.textBox1.TabIndex = 1;
            // 
            // butBin
            // 
            this.butBin.Location = new System.Drawing.Point(12, 79);
            this.butBin.Name = "butBin";
            this.butBin.Size = new System.Drawing.Size(134, 42);
            this.butBin.TabIndex = 2;
            this.butBin.Text = "Двоичная запись";
            this.butBin.UseVisualStyleBackColor = true;
            this.butBin.Click += new System.EventHandler(this.butBin_Click);
            // 
            // butConvert
            // 
            this.butConvert.Location = new System.Drawing.Point(152, 27);
            this.butConvert.Name = "butConvert";
            this.butConvert.Size = new System.Drawing.Size(134, 46);
            this.butConvert.TabIndex = 3;
            this.butConvert.Text = "Конвертировать";
            this.butConvert.UseVisualStyleBackColor = true;
            this.butConvert.Click += new System.EventHandler(this.butConvert_Click);
            // 
            // butGuid
            // 
            this.butGuid.Location = new System.Drawing.Point(152, 80);
            this.butGuid.Name = "butGuid";
            this.butGuid.Size = new System.Drawing.Size(134, 41);
            this.butGuid.TabIndex = 4;
            this.butGuid.Text = "GUID";
            this.butGuid.UseVisualStyleBackColor = true;
            this.butGuid.Click += new System.EventHandler(this.butGuid_Click);
            // 
            // butIsNumericVB
            // 
            this.butIsNumericVB.Location = new System.Drawing.Point(12, 175);
            this.butIsNumericVB.Name = "butIsNumericVB";
            this.butIsNumericVB.Size = new System.Drawing.Size(134, 35);
            this.butIsNumericVB.TabIndex = 5;
            this.butIsNumericVB.Text = "Это число? (VB)";
            this.butIsNumericVB.UseVisualStyleBackColor = true;
            this.butIsNumericVB.Click += new System.EventHandler(this.butIsNumericVB_Click);
            // 
            // butIsNumericCS
            // 
            this.butIsNumericCS.Location = new System.Drawing.Point(12, 216);
            this.butIsNumericCS.Name = "butIsNumericCS";
            this.butIsNumericCS.Size = new System.Drawing.Size(134, 35);
            this.butIsNumericCS.TabIndex = 6;
            this.butIsNumericCS.Text = "Это число? (C#)";
            this.butIsNumericCS.UseVisualStyleBackColor = true;
            this.butIsNumericCS.Click += new System.EventHandler(this.butIsNumericCS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 303);
            this.Controls.Add(this.butIsNumericCS);
            this.Controls.Add(this.butIsNumericVB);
            this.Controls.Add(this.butGuid);
            this.Controls.Add(this.butConvert);
            this.Controls.Add(this.butBin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butTo16);
            this.Name = "Form1";
            this.Text = "Примеры с числами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butTo16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butBin;
        private System.Windows.Forms.Button butConvert;
        private System.Windows.Forms.Button butGuid;
        private System.Windows.Forms.Button butIsNumericVB;
        private System.Windows.Forms.Button butIsNumericCS;
    }
}

