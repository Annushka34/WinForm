namespace AdvancedMouse
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
            this.butSwapMouse = new System.Windows.Forms.Button();
            this.butRestoreMouse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butSwapMouse
            // 
            this.butSwapMouse.Location = new System.Drawing.Point(56, 197);
            this.butSwapMouse.Name = "butSwapMouse";
            this.butSwapMouse.Size = new System.Drawing.Size(113, 42);
            this.butSwapMouse.TabIndex = 0;
            this.butSwapMouse.Text = "Поменять местами";
            this.butSwapMouse.UseVisualStyleBackColor = true;
            this.butSwapMouse.Click += new System.EventHandler(this.butSwapMouse_Click);
            // 
            // butRestoreMouse
            // 
            this.butRestoreMouse.Location = new System.Drawing.Point(242, 197);
            this.butRestoreMouse.Name = "butRestoreMouse";
            this.butRestoreMouse.Size = new System.Drawing.Size(107, 42);
            this.butRestoreMouse.TabIndex = 1;
            this.butRestoreMouse.Text = "Восстановить";
            this.butRestoreMouse.UseVisualStyleBackColor = true;
            this.butRestoreMouse.Click += new System.EventHandler(this.butRestoreMouse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Щелкните здесь правой кнопкой мыши";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 260);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butRestoreMouse);
            this.Controls.Add(this.butSwapMouse);
            this.Name = "Form1";
            this.Text = "Продвинутые примеры для мыши";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSwapMouse;
        private System.Windows.Forms.Button butRestoreMouse;
        private System.Windows.Forms.TextBox textBox1;
    }
}

