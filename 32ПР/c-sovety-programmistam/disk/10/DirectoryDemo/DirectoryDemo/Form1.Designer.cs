namespace DirectoryDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.butFolderExist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butRenameFolder = new System.Windows.Forms.Button();
            this.butBrowseFolder = new System.Windows.Forms.Button();
            this.butMyDoc = new System.Windows.Forms.Button();
            this.butFolderSize = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Список каталогов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(156, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 260);
            this.listBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Список папок по маске";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить папку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Свойства папки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // butFolderExist
            // 
            this.butFolderExist.Location = new System.Drawing.Point(12, 144);
            this.butFolderExist.Name = "butFolderExist";
            this.butFolderExist.Size = new System.Drawing.Size(124, 44);
            this.butFolderExist.TabIndex = 5;
            this.butFolderExist.Text = "Проверка";
            this.butFolderExist.UseVisualStyleBackColor = true;
            this.butFolderExist.Click += new System.EventHandler(this.butFolderExist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Папка C:\\windows?";
            // 
            // butRenameFolder
            // 
            this.butRenameFolder.Location = new System.Drawing.Point(12, 194);
            this.butRenameFolder.Name = "butRenameFolder";
            this.butRenameFolder.Size = new System.Drawing.Size(124, 43);
            this.butRenameFolder.TabIndex = 7;
            this.butRenameFolder.Text = "Переименовать";
            this.butRenameFolder.UseVisualStyleBackColor = true;
            this.butRenameFolder.Click += new System.EventHandler(this.butRenameFolder_Click);
            // 
            // butBrowseFolder
            // 
            this.butBrowseFolder.Location = new System.Drawing.Point(12, 296);
            this.butBrowseFolder.Name = "butBrowseFolder";
            this.butBrowseFolder.Size = new System.Drawing.Size(124, 41);
            this.butBrowseFolder.TabIndex = 8;
            this.butBrowseFolder.Text = "Выбор папки...";
            this.butBrowseFolder.UseVisualStyleBackColor = true;
            this.butBrowseFolder.Click += new System.EventHandler(this.butBrowseFolder_Click);
            // 
            // butMyDoc
            // 
            this.butMyDoc.Location = new System.Drawing.Point(12, 343);
            this.butMyDoc.Name = "butMyDoc";
            this.butMyDoc.Size = new System.Drawing.Size(124, 44);
            this.butMyDoc.TabIndex = 9;
            this.butMyDoc.Text = "Мои документы";
            this.butMyDoc.UseVisualStyleBackColor = true;
            this.butMyDoc.Click += new System.EventHandler(this.butMyDoc_Click);
            // 
            // butFolderSize
            // 
            this.butFolderSize.Location = new System.Drawing.Point(12, 442);
            this.butFolderSize.Name = "butFolderSize";
            this.butFolderSize.Size = new System.Drawing.Size(124, 44);
            this.butFolderSize.TabIndex = 10;
            this.butFolderSize.Text = "Размеры папок";
            this.butFolderSize.UseVisualStyleBackColor = true;
            this.butFolderSize.Click += new System.EventHandler(this.butFolderSize_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 498);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butFolderSize);
            this.Controls.Add(this.butMyDoc);
            this.Controls.Add(this.butBrowseFolder);
            this.Controls.Add(this.butRenameFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butFolderExist);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Папки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button butFolderExist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butRenameFolder;
        private System.Windows.Forms.Button butBrowseFolder;
        private System.Windows.Forms.Button butMyDoc;
        private System.Windows.Forms.Button butFolderSize;
        private System.Windows.Forms.TextBox textBox1;
    }
}

