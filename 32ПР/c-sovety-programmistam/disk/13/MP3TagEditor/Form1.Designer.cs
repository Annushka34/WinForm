namespace MP3TagEditor
{
    partial class MP3Form
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
            this.butSaveMP3 = new System.Windows.Forms.Button();
            this.butLoadMP3 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.cboGenres = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // butSaveMP3
            // 
            this.butSaveMP3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSaveMP3.Location = new System.Drawing.Point(537, 79);
            this.butSaveMP3.Margin = new System.Windows.Forms.Padding(4);
            this.butSaveMP3.Name = "butSaveMP3";
            this.butSaveMP3.Size = new System.Drawing.Size(136, 28);
            this.butSaveMP3.TabIndex = 12;
            this.butSaveMP3.Text = "Сохранить MP3";
            this.butSaveMP3.UseVisualStyleBackColor = true;
            this.butSaveMP3.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // butLoadMP3
            // 
            this.butLoadMP3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butLoadMP3.Location = new System.Drawing.Point(537, 43);
            this.butLoadMP3.Margin = new System.Windows.Forms.Padding(4);
            this.butLoadMP3.Name = "butLoadMP3";
            this.butLoadMP3.Size = new System.Drawing.Size(136, 28);
            this.butLoadMP3.TabIndex = 11;
            this.butLoadMP3.Text = "Открыть MP3";
            this.butLoadMP3.UseVisualStyleBackColor = true;
            this.butLoadMP3.Click += new System.EventHandler(this.butLoadMP3_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(37, 43);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(97, 18);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Заголовок";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(157, 39);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(300, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArtist.Location = new System.Drawing.Point(37, 87);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(64, 18);
            this.lblArtist.TabIndex = 4;
            this.lblArtist.Text = "Артист";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(157, 83);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(4);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(300, 22);
            this.txtArtist.TabIndex = 5;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAlbum.Location = new System.Drawing.Point(37, 130);
            this.lblAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(72, 18);
            this.lblAlbum.TabIndex = 4;
            this.lblAlbum.Text = "Альбом";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(157, 129);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(300, 22);
            this.txtAlbum.TabIndex = 5;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYear.Location = new System.Drawing.Point(37, 178);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 18);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Год";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(157, 177);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(300, 22);
            this.txtYear.TabIndex = 7;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComment.Location = new System.Drawing.Point(37, 226);
            this.lblComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(117, 18);
            this.lblComment.TabIndex = 8;
            this.lblComment.Text = "Комментарий";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(157, 222);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(300, 22);
            this.txtComment.TabIndex = 9;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGenre.Location = new System.Drawing.Point(37, 281);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(50, 18);
            this.lblGenre.TabIndex = 13;
            this.lblGenre.Text = "Жанр";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(157, 276);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(45, 22);
            this.txtGenre.TabIndex = 14;
            // 
            // cboGenres
            // 
            this.cboGenres.FormattingEnabled = true;
            this.cboGenres.Location = new System.Drawing.Point(262, 275);
            this.cboGenres.Name = "cboGenres";
            this.cboGenres.Size = new System.Drawing.Size(194, 24);
            this.cboGenres.TabIndex = 15;
            // 
            // MP3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 373);
            this.Controls.Add(this.cboGenres);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.butSaveMP3);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.butLoadMP3);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.txtArtist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MP3Form";
            this.Text = "MP3 Tag Editor";
            this.Load += new System.EventHandler(this.MP3Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSaveMP3;
        private System.Windows.Forms.Button butLoadMP3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.ComboBox cboGenres;
    }
}

