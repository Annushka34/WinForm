namespace WMIDemo
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
            this.butOS = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butComputer = new System.Windows.Forms.Button();
            this.butProduct = new System.Windows.Forms.Button();
            this.butProc = new System.Windows.Forms.Button();
            this.butVideo = new System.Windows.Forms.Button();
            this.butCDRom = new System.Windows.Forms.Button();
            this.butAdapter = new System.Windows.Forms.Button();
            this.butMonitor = new System.Windows.Forms.Button();
            this.butBoard = new System.Windows.Forms.Button();
            this.butShare = new System.Windows.Forms.Button();
            this.butLogDisk = new System.Windows.Forms.Button();
            this.butReboot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butOS
            // 
            this.butOS.Location = new System.Drawing.Point(23, 34);
            this.butOS.Name = "butOS";
            this.butOS.Size = new System.Drawing.Size(162, 51);
            this.butOS.TabIndex = 1;
            this.butOS.Text = "Операционная система";
            this.butOS.UseVisualStyleBackColor = true;
            this.butOS.Click += new System.EventHandler(this.butOS_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 301);
            this.textBox1.TabIndex = 2;
            // 
            // butComputer
            // 
            this.butComputer.Location = new System.Drawing.Point(191, 34);
            this.butComputer.Name = "butComputer";
            this.butComputer.Size = new System.Drawing.Size(162, 49);
            this.butComputer.TabIndex = 3;
            this.butComputer.Text = "Информация о компьютере";
            this.butComputer.UseVisualStyleBackColor = true;
            this.butComputer.Click += new System.EventHandler(this.butComputer_Click);
            // 
            // butProduct
            // 
            this.butProduct.Location = new System.Drawing.Point(23, 91);
            this.butProduct.Name = "butProduct";
            this.butProduct.Size = new System.Drawing.Size(162, 46);
            this.butProduct.TabIndex = 4;
            this.butProduct.Text = "Начинка компьютера";
            this.butProduct.UseVisualStyleBackColor = true;
            this.butProduct.Click += new System.EventHandler(this.butProduct_Click);
            // 
            // butProc
            // 
            this.butProc.Location = new System.Drawing.Point(191, 91);
            this.butProc.Name = "butProc";
            this.butProc.Size = new System.Drawing.Size(162, 46);
            this.butProc.TabIndex = 5;
            this.butProc.Text = "Процессоры";
            this.butProc.UseVisualStyleBackColor = true;
            this.butProc.Click += new System.EventHandler(this.butProc_Click);
            // 
            // butVideo
            // 
            this.butVideo.Location = new System.Drawing.Point(23, 143);
            this.butVideo.Name = "butVideo";
            this.butVideo.Size = new System.Drawing.Size(162, 50);
            this.butVideo.TabIndex = 6;
            this.butVideo.Text = "Видеоконтроллер";
            this.butVideo.UseVisualStyleBackColor = true;
            this.butVideo.Click += new System.EventHandler(this.butVideo_Click);
            // 
            // butCDRom
            // 
            this.butCDRom.Location = new System.Drawing.Point(191, 143);
            this.butCDRom.Name = "butCDRom";
            this.butCDRom.Size = new System.Drawing.Size(162, 50);
            this.butCDRom.TabIndex = 7;
            this.butCDRom.Text = "Приводы CD-ROM";
            this.butCDRom.UseVisualStyleBackColor = true;
            this.butCDRom.Click += new System.EventHandler(this.butCDRom_Click);
            // 
            // butAdapter
            // 
            this.butAdapter.Location = new System.Drawing.Point(23, 199);
            this.butAdapter.Name = "butAdapter";
            this.butAdapter.Size = new System.Drawing.Size(162, 43);
            this.butAdapter.TabIndex = 8;
            this.butAdapter.Text = "Адаптер";
            this.butAdapter.UseVisualStyleBackColor = true;
            this.butAdapter.Click += new System.EventHandler(this.butAdapter_Click);
            // 
            // butMonitor
            // 
            this.butMonitor.Location = new System.Drawing.Point(191, 199);
            this.butMonitor.Name = "butMonitor";
            this.butMonitor.Size = new System.Drawing.Size(162, 43);
            this.butMonitor.TabIndex = 9;
            this.butMonitor.Text = "Монитор";
            this.butMonitor.UseVisualStyleBackColor = true;
            this.butMonitor.Click += new System.EventHandler(this.butMonitor_Click);
            // 
            // butBoard
            // 
            this.butBoard.Location = new System.Drawing.Point(23, 248);
            this.butBoard.Name = "butBoard";
            this.butBoard.Size = new System.Drawing.Size(162, 44);
            this.butBoard.TabIndex = 10;
            this.butBoard.Text = "Материнская плата";
            this.butBoard.UseVisualStyleBackColor = true;
            this.butBoard.Click += new System.EventHandler(this.butBoard_Click);
            // 
            // butShare
            // 
            this.butShare.Location = new System.Drawing.Point(191, 248);
            this.butShare.Name = "butShare";
            this.butShare.Size = new System.Drawing.Size(162, 44);
            this.butShare.TabIndex = 11;
            this.butShare.Text = "Общие ресурсы";
            this.butShare.UseVisualStyleBackColor = true;
            this.butShare.Click += new System.EventHandler(this.butShare_Click);
            // 
            // butLogDisk
            // 
            this.butLogDisk.Location = new System.Drawing.Point(23, 298);
            this.butLogDisk.Name = "butLogDisk";
            this.butLogDisk.Size = new System.Drawing.Size(162, 37);
            this.butLogDisk.TabIndex = 12;
            this.butLogDisk.Text = "Логические диски";
            this.butLogDisk.UseVisualStyleBackColor = true;
            this.butLogDisk.Click += new System.EventHandler(this.butLogDisk_Click);
            // 
            // butReboot
            // 
            this.butReboot.Location = new System.Drawing.Point(191, 298);
            this.butReboot.Name = "butReboot";
            this.butReboot.Size = new System.Drawing.Size(162, 37);
            this.butReboot.TabIndex = 13;
            this.butReboot.Text = "Перезагрузка";
            this.butReboot.UseVisualStyleBackColor = true;
            this.butReboot.Click += new System.EventHandler(this.butReboot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 378);
            this.Controls.Add(this.butReboot);
            this.Controls.Add(this.butLogDisk);
            this.Controls.Add(this.butShare);
            this.Controls.Add(this.butBoard);
            this.Controls.Add(this.butMonitor);
            this.Controls.Add(this.butAdapter);
            this.Controls.Add(this.butCDRom);
            this.Controls.Add(this.butVideo);
            this.Controls.Add(this.butProc);
            this.Controls.Add(this.butProduct);
            this.Controls.Add(this.butComputer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butOS);
            this.Name = "Form1";
            this.Text = "WMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butComputer;
        private System.Windows.Forms.Button butProduct;
        private System.Windows.Forms.Button butProc;
        private System.Windows.Forms.Button butVideo;
        private System.Windows.Forms.Button butCDRom;
        private System.Windows.Forms.Button butAdapter;
        private System.Windows.Forms.Button butMonitor;
        private System.Windows.Forms.Button butBoard;
        private System.Windows.Forms.Button butShare;
        private System.Windows.Forms.Button butLogDisk;
        private System.Windows.Forms.Button butReboot;
    }
}

