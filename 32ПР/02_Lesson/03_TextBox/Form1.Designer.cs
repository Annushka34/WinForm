namespace _03_TextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtView = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(38, 12);
            this.txtWrite.Margin = new System.Windows.Forms.Padding(100);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWrite.Size = new System.Drawing.Size(719, 67);
            this.txtWrite.TabIndex = 0;
            this.txtWrite.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtWrite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWrite_KeyPress);
            this.txtWrite.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtWrite_MouseUp);
            // 
            // txtSelected
            // 
            this.txtSelected.AutoCompleteCustomSource.AddRange(new string[] {
            "як проспати 8 годин за 2 години",
            "як приготовити суп з топора",
            "як зробити курсак за день",
            "як вивчити с++ за годину"});
            this.txtSelected.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSelected.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSelected.Location = new System.Drawing.Point(783, 153);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(399, 20);
            this.txtSelected.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(38, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 168);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(392, 153);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.ReadOnly = true;
            this.txtView.Size = new System.Drawing.Size(365, 246);
            this.txtView.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(38, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ж";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pBar1
            // 
            this.pBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pBar1.Location = new System.Drawing.Point(38, 415);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(719, 23);
            this.pBar1.Step = 1;
            this.pBar1.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(38, 466);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(719, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Ivanov",
            "Petrov",
            "Sidorov"});
            this.listBox1.Location = new System.Drawing.Point(783, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 121);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 516);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.txtWrite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

