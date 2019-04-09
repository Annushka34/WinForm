namespace SimpleMouse
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
            this.butTestMouse = new System.Windows.Forms.Button();
            this.lblTrapMouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butTestMouse
            // 
            this.butTestMouse.Location = new System.Drawing.Point(55, 170);
            this.butTestMouse.Name = "butTestMouse";
            this.butTestMouse.Size = new System.Drawing.Size(173, 42);
            this.butTestMouse.TabIndex = 0;
            this.butTestMouse.Text = "Кнопка для опытов";
            this.butTestMouse.UseVisualStyleBackColor = true;
            this.butTestMouse.MouseLeave += new System.EventHandler(this.butTestMouse_MouseLeave);
            this.butTestMouse.Click += new System.EventHandler(this.butTestMouse_Click);
            this.butTestMouse.MouseEnter += new System.EventHandler(this.butTestMouse_MouseEnter);
            // 
            // lblTrapMouse
            // 
            this.lblTrapMouse.BackColor = System.Drawing.Color.Aquamarine;
            this.lblTrapMouse.Location = new System.Drawing.Point(55, 44);
            this.lblTrapMouse.Name = "lblTrapMouse";
            this.lblTrapMouse.Size = new System.Drawing.Size(173, 84);
            this.lblTrapMouse.TabIndex = 1;
            this.lblTrapMouse.Text = "Помести сюда мышь";
            this.lblTrapMouse.MouseEnter += new System.EventHandler(this.lblTrapMouse_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 260);
            this.Controls.Add(this.lblTrapMouse);
            this.Controls.Add(this.butTestMouse);
            this.Name = "Form1";
            this.Text = "Операции с мышью";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butTestMouse;
        private System.Windows.Forms.Label lblTrapMouse;
    }
}

