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
            this.butExePath = new System.Windows.Forms.Button();
            this.butBaseDirectory = new System.Windows.Forms.Button();
            this.butRunNotepad = new System.Windows.Forms.Button();
            this.butRunIE = new System.Windows.Forms.Button();
            this.butProcCount = new System.Windows.Forms.Button();
            this.butRunNotepad2 = new System.Windows.Forms.Button();
            this.butCloseNotepad = new System.Windows.Forms.Button();
            this.butProcCount2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butExePath
            // 
            this.butExePath.Location = new System.Drawing.Point(12, 24);
            this.butExePath.Name = "butExePath";
            this.butExePath.Size = new System.Drawing.Size(150, 34);
            this.butExePath.TabIndex = 0;
            this.butExePath.Text = "Путь к файлу EXE";
            this.butExePath.UseVisualStyleBackColor = true;
            this.butExePath.Click += new System.EventHandler(this.butExePath_Click);
            // 
            // butBaseDirectory
            // 
            this.butBaseDirectory.Location = new System.Drawing.Point(12, 64);
            this.butBaseDirectory.Name = "butBaseDirectory";
            this.butBaseDirectory.Size = new System.Drawing.Size(150, 35);
            this.butBaseDirectory.TabIndex = 1;
            this.butBaseDirectory.Text = "Путь к папке";
            this.butBaseDirectory.UseVisualStyleBackColor = true;
            this.butBaseDirectory.Click += new System.EventHandler(this.butBaseDirectory_Click);
            // 
            // butRunNotepad
            // 
            this.butRunNotepad.Location = new System.Drawing.Point(228, 24);
            this.butRunNotepad.Name = "butRunNotepad";
            this.butRunNotepad.Size = new System.Drawing.Size(141, 46);
            this.butRunNotepad.TabIndex = 2;
            this.butRunNotepad.Text = "Запустить Блокнот";
            this.butRunNotepad.UseVisualStyleBackColor = true;
            this.butRunNotepad.Click += new System.EventHandler(this.butRunNotepad_Click);
            // 
            // butRunIE
            // 
            this.butRunIE.Location = new System.Drawing.Point(228, 130);
            this.butRunIE.Name = "butRunIE";
            this.butRunIE.Size = new System.Drawing.Size(141, 42);
            this.butRunIE.TabIndex = 3;
            this.butRunIE.Text = "Запустить IE";
            this.butRunIE.UseVisualStyleBackColor = true;
            this.butRunIE.Click += new System.EventHandler(this.butRunIE_Click);
            // 
            // butProcCount
            // 
            this.butProcCount.Location = new System.Drawing.Point(12, 105);
            this.butProcCount.Name = "butProcCount";
            this.butProcCount.Size = new System.Drawing.Size(150, 41);
            this.butProcCount.TabIndex = 4;
            this.butProcCount.Text = "Число процессоров";
            this.butProcCount.UseVisualStyleBackColor = true;
            this.butProcCount.Click += new System.EventHandler(this.butProcCount_Click);
            // 
            // butRunNotepad2
            // 
            this.butRunNotepad2.Location = new System.Drawing.Point(229, 76);
            this.butRunNotepad2.Name = "butRunNotepad2";
            this.butRunNotepad2.Size = new System.Drawing.Size(140, 45);
            this.butRunNotepad2.TabIndex = 5;
            this.butRunNotepad2.Text = "Запустить Блокнот-2";
            this.butRunNotepad2.UseVisualStyleBackColor = true;
            this.butRunNotepad2.Click += new System.EventHandler(this.butRunNotepad2_Click);
            // 
            // butCloseNotepad
            // 
            this.butCloseNotepad.Location = new System.Drawing.Point(228, 178);
            this.butCloseNotepad.Name = "butCloseNotepad";
            this.butCloseNotepad.Size = new System.Drawing.Size(137, 44);
            this.butCloseNotepad.TabIndex = 6;
            this.butCloseNotepad.Text = "Закрыть все Блокноты";
            this.butCloseNotepad.UseVisualStyleBackColor = true;
            this.butCloseNotepad.Click += new System.EventHandler(this.butCloseNotepad_Click);
            // 
            // butProcCount2
            // 
            this.butProcCount2.Location = new System.Drawing.Point(12, 152);
            this.butProcCount2.Name = "butProcCount2";
            this.butProcCount2.Size = new System.Drawing.Size(150, 43);
            this.butProcCount2.TabIndex = 7;
            this.butProcCount2.Text = "Число процессоров-2";
            this.butProcCount2.UseVisualStyleBackColor = true;
            this.butProcCount2.Click += new System.EventHandler(this.butProcCount2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 307);
            this.Controls.Add(this.butProcCount2);
            this.Controls.Add(this.butCloseNotepad);
            this.Controls.Add(this.butRunNotepad2);
            this.Controls.Add(this.butProcCount);
            this.Controls.Add(this.butRunIE);
            this.Controls.Add(this.butRunNotepad);
            this.Controls.Add(this.butBaseDirectory);
            this.Controls.Add(this.butExePath);
            this.Name = "Form1";
            this.Text = "Примеры с приложениями";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butExePath;
        private System.Windows.Forms.Button butBaseDirectory;
        private System.Windows.Forms.Button butRunNotepad;
        private System.Windows.Forms.Button butRunIE;
        private System.Windows.Forms.Button butProcCount;
        private System.Windows.Forms.Button butRunNotepad2;
        private System.Windows.Forms.Button butCloseNotepad;
        private System.Windows.Forms.Button butProcCount2;
    }
}

