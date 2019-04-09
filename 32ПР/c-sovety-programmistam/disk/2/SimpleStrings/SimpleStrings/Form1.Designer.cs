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
            this.butInsert = new System.Windows.Forms.Button();
            this.butRemove = new System.Windows.Forms.Button();
            this.butSubstring = new System.Windows.Forms.Button();
            this.butIndexOf = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butConvert = new System.Windows.Forms.Button();
            this.butSpecial = new System.Windows.Forms.Button();
            this.butRepeat = new System.Windows.Forms.Button();
            this.butColorName = new System.Windows.Forms.Button();
            this.butReverseVB = new System.Windows.Forms.Button();
            this.butReverseCS = new System.Windows.Forms.Button();
            this.butFormatStr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(12, 12);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(151, 40);
            this.butInsert.TabIndex = 0;
            this.butInsert.Text = "Вставка";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // butRemove
            // 
            this.butRemove.Location = new System.Drawing.Point(12, 58);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(151, 42);
            this.butRemove.TabIndex = 1;
            this.butRemove.Text = "Удаление подстроки";
            this.butRemove.UseVisualStyleBackColor = true;
            this.butRemove.Click += new System.EventHandler(this.butRemove_Click);
            // 
            // butSubstring
            // 
            this.butSubstring.Location = new System.Drawing.Point(12, 106);
            this.butSubstring.Name = "butSubstring";
            this.butSubstring.Size = new System.Drawing.Size(151, 43);
            this.butSubstring.TabIndex = 2;
            this.butSubstring.Text = "Извлечение подстроки";
            this.butSubstring.UseVisualStyleBackColor = true;
            this.butSubstring.Click += new System.EventHandler(this.butSubstring_Click);
            // 
            // butIndexOf
            // 
            this.butIndexOf.Location = new System.Drawing.Point(12, 155);
            this.butIndexOf.Name = "butIndexOf";
            this.butIndexOf.Size = new System.Drawing.Size(151, 46);
            this.butIndexOf.TabIndex = 3;
            this.butIndexOf.Text = "Вхождение строки";
            this.butIndexOf.UseVisualStyleBackColor = true;
            this.butIndexOf.Click += new System.EventHandler(this.butIndexOf_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(200, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 49);
            this.textBox1.TabIndex = 4;
            // 
            // butConvert
            // 
            this.butConvert.Location = new System.Drawing.Point(12, 207);
            this.butConvert.Name = "butConvert";
            this.butConvert.Size = new System.Drawing.Size(151, 47);
            this.butConvert.TabIndex = 5;
            this.butConvert.Text = "Преобразование в число";
            this.butConvert.UseVisualStyleBackColor = true;
            this.butConvert.Click += new System.EventHandler(this.butConvert_Click);
            // 
            // butSpecial
            // 
            this.butSpecial.Location = new System.Drawing.Point(12, 260);
            this.butSpecial.Name = "butSpecial";
            this.butSpecial.Size = new System.Drawing.Size(151, 42);
            this.butSpecial.TabIndex = 6;
            this.butSpecial.Text = "Специальный символ";
            this.butSpecial.UseVisualStyleBackColor = true;
            this.butSpecial.Click += new System.EventHandler(this.butSpecial_Click);
            // 
            // butRepeat
            // 
            this.butRepeat.Location = new System.Drawing.Point(12, 308);
            this.butRepeat.Name = "butRepeat";
            this.butRepeat.Size = new System.Drawing.Size(151, 41);
            this.butRepeat.TabIndex = 7;
            this.butRepeat.Text = "Повтор символов";
            this.butRepeat.UseVisualStyleBackColor = true;
            this.butRepeat.Click += new System.EventHandler(this.butRepeat_Click);
            // 
            // butColorName
            // 
            this.butColorName.Location = new System.Drawing.Point(12, 355);
            this.butColorName.Name = "butColorName";
            this.butColorName.Size = new System.Drawing.Size(151, 43);
            this.butColorName.TabIndex = 8;
            this.butColorName.Text = "Имя цвета";
            this.butColorName.UseVisualStyleBackColor = true;
            this.butColorName.Click += new System.EventHandler(this.butColorName_Click);
            // 
            // butReverseVB
            // 
            this.butReverseVB.Location = new System.Drawing.Point(200, 308);
            this.butReverseVB.Name = "butReverseVB";
            this.butReverseVB.Size = new System.Drawing.Size(139, 42);
            this.butReverseVB.TabIndex = 9;
            this.butReverseVB.Text = "Перевернуть строку (VB)";
            this.butReverseVB.UseVisualStyleBackColor = true;
            this.butReverseVB.Click += new System.EventHandler(this.butReverseVB_Click);
            // 
            // butReverseCS
            // 
            this.butReverseCS.Location = new System.Drawing.Point(364, 308);
            this.butReverseCS.Name = "butReverseCS";
            this.butReverseCS.Size = new System.Drawing.Size(146, 42);
            this.butReverseCS.TabIndex = 10;
            this.butReverseCS.Text = "Перевернуть строку (C#)";
            this.butReverseCS.UseVisualStyleBackColor = true;
            this.butReverseCS.Click += new System.EventHandler(this.butReverseCS_Click);
            // 
            // butFormatStr
            // 
            this.butFormatStr.Location = new System.Drawing.Point(255, 366);
            this.butFormatStr.Name = "butFormatStr";
            this.butFormatStr.Size = new System.Drawing.Size(139, 31);
            this.butFormatStr.TabIndex = 11;
            this.butFormatStr.Text = "Format";
            this.butFormatStr.UseVisualStyleBackColor = true;
            this.butFormatStr.Click += new System.EventHandler(this.butFormatStr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 410);
            this.Controls.Add(this.butFormatStr);
            this.Controls.Add(this.butReverseCS);
            this.Controls.Add(this.butReverseVB);
            this.Controls.Add(this.butColorName);
            this.Controls.Add(this.butRepeat);
            this.Controls.Add(this.butSpecial);
            this.Controls.Add(this.butConvert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butIndexOf);
            this.Controls.Add(this.butSubstring);
            this.Controls.Add(this.butRemove);
            this.Controls.Add(this.butInsert);
            this.Name = "Form1";
            this.Text = "Простейшие операции со строками";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.Button butRemove;
        private System.Windows.Forms.Button butSubstring;
        private System.Windows.Forms.Button butIndexOf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butConvert;
        private System.Windows.Forms.Button butSpecial;
        private System.Windows.Forms.Button butRepeat;
        private System.Windows.Forms.Button butColorName;
        private System.Windows.Forms.Button butReverseVB;
        private System.Windows.Forms.Button butReverseCS;
        private System.Windows.Forms.Button butFormatStr;
    }
}

