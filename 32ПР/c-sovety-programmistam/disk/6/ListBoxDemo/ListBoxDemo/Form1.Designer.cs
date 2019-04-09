namespace ListBoxDemo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.butInsert = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstColor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 196);
            this.listBox1.TabIndex = 0;
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(12, 248);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(90, 36);
            this.butInsert.TabIndex = 1;
            this.butInsert.Text = "Вставить";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(108, 248);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(87, 36);
            this.butDelete.TabIndex = 2;
            this.butDelete.Text = "Удалить";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lstColor
            // 
            this.lstColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstColor.FormattingEnabled = true;
            this.lstColor.Location = new System.Drawing.Point(223, 12);
            this.lstColor.Name = "lstColor";
            this.lstColor.Size = new System.Drawing.Size(198, 199);
            this.lstColor.TabIndex = 4;
            this.lstColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstColor_DrawItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 413);
            this.Controls.Add(this.lstColor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Примеры с ListBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstColor;
    }
}

