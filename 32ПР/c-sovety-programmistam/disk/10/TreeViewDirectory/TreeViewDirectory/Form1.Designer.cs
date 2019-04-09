namespace TreeViewDirectory
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
            this.treeDirectory = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeDirectory
            // 
            this.treeDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDirectory.Location = new System.Drawing.Point(0, 0);
            this.treeDirectory.Name = "treeDirectory";
            this.treeDirectory.Size = new System.Drawing.Size(323, 400);
            this.treeDirectory.TabIndex = 0;
            this.treeDirectory.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeDirectory_BeforeExpand);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 400);
            this.Controls.Add(this.treeDirectory);
            this.Name = "Form1";
            this.Text = "TreeViewDirectory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeDirectory;
    }
}

