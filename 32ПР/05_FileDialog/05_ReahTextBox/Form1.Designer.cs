namespace _05_ReahTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnLined = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.txtBackColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 147);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(459, 233);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 386);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(241, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(241, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnColor
            // 
            this.btnColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColor.BackgroundImage")));
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnColor.Location = new System.Drawing.Point(55, 13);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(31, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(12, 70);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 5;
            this.btnFont.Text = "FONT";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnBold
            // 
            this.btnBold.Location = new System.Drawing.Point(12, 100);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(36, 23);
            this.btnBold.TabIndex = 6;
            this.btnBold.Text = "Ж";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Location = new System.Drawing.Point(55, 100);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(32, 23);
            this.btnItalic.TabIndex = 7;
            this.btnItalic.Text = "К";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnLined
            // 
            this.btnLined.Location = new System.Drawing.Point(94, 100);
            this.btnLined.Name = "btnLined";
            this.btnLined.Size = new System.Drawing.Size(39, 23);
            this.btnLined.TabIndex = 8;
            this.btnLined.Text = "__";
            this.btnLined.UseVisualStyleBackColor = true;
            this.btnLined.Click += new System.EventHandler(this.btnLined_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(94, 15);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 9;
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(94, 70);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(100, 20);
            this.txtFont.TabIndex = 11;
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "40",
            "80"});
            this.cmbSize.Location = new System.Drawing.Point(94, 41);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(100, 21);
            this.cmbSize.TabIndex = 12;
            this.cmbSize.SelectedValueChanged += new System.EventHandler(this.cmbSize_SelectedValueChanged);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(245, 12);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(108, 23);
            this.btnBackColor.TabIndex = 13;
            this.btnBackColor.Text = "BACK COLOR";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // txtBackColor
            // 
            this.txtBackColor.Location = new System.Drawing.Point(360, 12);
            this.txtBackColor.Name = "txtBackColor";
            this.txtBackColor.Size = new System.Drawing.Size(100, 20);
            this.txtBackColor.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "SIZE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBackColor);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnLined);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnLined;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.TextBox txtBackColor;
        private System.Windows.Forms.Label label1;
    }
}

