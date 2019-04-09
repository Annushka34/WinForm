namespace MovingMouse
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
            this.butStart = new System.Windows.Forms.Button();
            this.butShowBorderForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(40, 289);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(188, 32);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Вдоль окружности";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butShowBorderForm
            // 
            this.butShowBorderForm.Location = new System.Drawing.Point(254, 289);
            this.butShowBorderForm.Name = "butShowBorderForm";
            this.butShowBorderForm.Size = new System.Drawing.Size(192, 31);
            this.butShowBorderForm.TabIndex = 1;
            this.butShowBorderForm.Text = "Показать границы формы";
            this.butShowBorderForm.UseVisualStyleBackColor = true;
            this.butShowBorderForm.Click += new System.EventHandler(this.butShowBorderForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 345);
            this.Controls.Add(this.butShowBorderForm);
            this.Controls.Add(this.butStart);
            this.Name = "Form1";
            this.Text = "Управление курсором";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butShowBorderForm;
    }
}

