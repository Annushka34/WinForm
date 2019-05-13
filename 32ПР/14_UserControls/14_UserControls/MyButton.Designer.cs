namespace _14_UserControls
{
    partial class MyButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_OK_Cancel = new System.Windows.Forms.Button();
            this.lbl_Ok_Cancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK_Cancel
            // 
            this.btn_OK_Cancel.Location = new System.Drawing.Point(3, 5);
            this.btn_OK_Cancel.Name = "btn_OK_Cancel";
            this.btn_OK_Cancel.Size = new System.Drawing.Size(75, 68);
            this.btn_OK_Cancel.TabIndex = 0;
            this.btn_OK_Cancel.Text = "OK";
            this.btn_OK_Cancel.UseVisualStyleBackColor = true;
            this.btn_OK_Cancel.Click += new System.EventHandler(this.btn_OK_Cancel_Click);
            // 
            // lbl_Ok_Cancel
            // 
            this.lbl_Ok_Cancel.AutoSize = true;
            this.lbl_Ok_Cancel.Location = new System.Drawing.Point(85, 5);
            this.lbl_Ok_Cancel.Name = "lbl_Ok_Cancel";
            this.lbl_Ok_Cancel.Size = new System.Drawing.Size(0, 17);
            this.lbl_Ok_Cancel.TabIndex = 1;
            // 
            // MyButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Ok_Cancel);
            this.Controls.Add(this.btn_OK_Cancel);
            this.Name = "MyButton";
            this.Size = new System.Drawing.Size(226, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Ok_Cancel;
        public System.Windows.Forms.Button btn_OK_Cancel;
    }
}
