namespace RichTextDemo
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butGetRTF = new System.Windows.Forms.Button();
            this.butScrollExist = new System.Windows.Forms.Button();
            this.butFormatRTF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 195);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 156);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 147);
            this.textBox1.TabIndex = 1;
            // 
            // butGetRTF
            // 
            this.butGetRTF.Location = new System.Drawing.Point(352, 12);
            this.butGetRTF.Name = "butGetRTF";
            this.butGetRTF.Size = new System.Drawing.Size(129, 46);
            this.butGetRTF.TabIndex = 2;
            this.butGetRTF.Text = "Получить строку";
            this.butGetRTF.UseVisualStyleBackColor = true;
            this.butGetRTF.Click += new System.EventHandler(this.butGetRTF_Click);
            // 
            // butScrollExist
            // 
            this.butScrollExist.Location = new System.Drawing.Point(352, 64);
            this.butScrollExist.Name = "butScrollExist";
            this.butScrollExist.Size = new System.Drawing.Size(128, 45);
            this.butScrollExist.TabIndex = 3;
            this.butScrollExist.Text = "Наличие прокрутки";
            this.butScrollExist.UseVisualStyleBackColor = true;
            this.butScrollExist.Click += new System.EventHandler(this.butScrollExist_Click);
            // 
            // butFormatRTF
            // 
            this.butFormatRTF.Location = new System.Drawing.Point(352, 115);
            this.butFormatRTF.Name = "butFormatRTF";
            this.butFormatRTF.Size = new System.Drawing.Size(127, 44);
            this.butFormatRTF.TabIndex = 4;
            this.butFormatRTF.Text = "Изменить текст";
            this.butFormatRTF.UseVisualStyleBackColor = true;
            this.butFormatRTF.Click += new System.EventHandler(this.butFormatRTF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 545);
            this.Controls.Add(this.butFormatRTF);
            this.Controls.Add(this.butScrollExist);
            this.Controls.Add(this.butGetRTF);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "RichTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butGetRTF;
        private System.Windows.Forms.Button butScrollExist;
        private System.Windows.Forms.Button butFormatRTF;
    }
}

