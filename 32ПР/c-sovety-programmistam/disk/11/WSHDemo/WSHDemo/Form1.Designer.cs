namespace WSHDemo
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
            this.butNetworkDrives = new System.Windows.Forms.Button();
            this.butCreateShortcut = new System.Windows.Forms.Button();
            this.butGetPrinters = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.butSetDefaultPrinter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butNetworkDrives
            // 
            this.butNetworkDrives.Location = new System.Drawing.Point(12, 184);
            this.butNetworkDrives.Name = "butNetworkDrives";
            this.butNetworkDrives.Size = new System.Drawing.Size(185, 53);
            this.butNetworkDrives.TabIndex = 0;
            this.butNetworkDrives.Text = "Получить список сетевых дисков";
            this.butNetworkDrives.UseVisualStyleBackColor = true;
            this.butNetworkDrives.Click += new System.EventHandler(this.butNetworkDrives_Click);
            // 
            // butCreateShortcut
            // 
            this.butCreateShortcut.Location = new System.Drawing.Point(12, 12);
            this.butCreateShortcut.Name = "butCreateShortcut";
            this.butCreateShortcut.Size = new System.Drawing.Size(185, 51);
            this.butCreateShortcut.TabIndex = 1;
            this.butCreateShortcut.Text = "Создать ярлык";
            this.butCreateShortcut.UseVisualStyleBackColor = true;
            this.butCreateShortcut.Click += new System.EventHandler(this.butCreateShortcut_Click);
            // 
            // butGetPrinters
            // 
            this.butGetPrinters.Location = new System.Drawing.Point(12, 69);
            this.butGetPrinters.Name = "butGetPrinters";
            this.butGetPrinters.Size = new System.Drawing.Size(185, 52);
            this.butGetPrinters.TabIndex = 2;
            this.butGetPrinters.Text = "Список принтеров";
            this.butGetPrinters.UseVisualStyleBackColor = true;
            this.butGetPrinters.Click += new System.EventHandler(this.butGetPrinters_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(232, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 196);
            this.listBox1.TabIndex = 3;
            // 
            // butSetDefaultPrinter
            // 
            this.butSetDefaultPrinter.Location = new System.Drawing.Point(12, 127);
            this.butSetDefaultPrinter.Name = "butSetDefaultPrinter";
            this.butSetDefaultPrinter.Size = new System.Drawing.Size(185, 51);
            this.butSetDefaultPrinter.TabIndex = 4;
            this.butSetDefaultPrinter.Text = "Принтер по умолчанию";
            this.butSetDefaultPrinter.UseVisualStyleBackColor = true;
            this.butSetDefaultPrinter.Click += new System.EventHandler(this.butSetDefaultPrinter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 302);
            this.Controls.Add(this.butSetDefaultPrinter);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.butGetPrinters);
            this.Controls.Add(this.butCreateShortcut);
            this.Controls.Add(this.butNetworkDrives);
            this.Name = "Form1";
            this.Text = "WSH";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butNetworkDrives;
        private System.Windows.Forms.Button butCreateShortcut;
        private System.Windows.Forms.Button butGetPrinters;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button butSetDefaultPrinter;
    }
}

