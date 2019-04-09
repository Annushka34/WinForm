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
            this.components = new System.ComponentModel.Container();
            this.butShowPickDial = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butSHGetFileInfo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butShowPickDial
            // 
            this.butShowPickDial.Location = new System.Drawing.Point(12, 26);
            this.butShowPickDial.Name = "butShowPickDial";
            this.butShowPickDial.Size = new System.Drawing.Size(120, 40);
            this.butShowPickDial.TabIndex = 0;
            this.butShowPickDial.Text = "Смена значка";
            this.butShowPickDial.UseVisualStyleBackColor = true;
            this.butShowPickDial.Click += new System.EventHandler(this.butShowPickDial_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(169, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // butSHGetFileInfo
            // 
            this.butSHGetFileInfo.Location = new System.Drawing.Point(12, 72);
            this.butSHGetFileInfo.Name = "butSHGetFileInfo";
            this.butSHGetFileInfo.Size = new System.Drawing.Size(120, 39);
            this.butSHGetFileInfo.TabIndex = 2;
            this.butSHGetFileInfo.Text = "SHGetFileInfo";
            this.butSHGetFileInfo.UseVisualStyleBackColor = true;
            this.butSHGetFileInfo.Click += new System.EventHandler(this.butSHGetFileInfo_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(11, 135);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(258, 97);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butSHGetFileInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butShowPickDial);
            this.Name = "Form1";
            this.Text = "Значки";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butShowPickDial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butSHGetFileInfo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

