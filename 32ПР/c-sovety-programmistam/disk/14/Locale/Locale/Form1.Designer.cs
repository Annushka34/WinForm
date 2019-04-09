namespace Locale
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
            this.butGoodMorning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butGoodMorning
            // 
            this.butGoodMorning.AccessibleDescription = null;
            this.butGoodMorning.AccessibleName = null;
            resources.ApplyResources(this.butGoodMorning, "butGoodMorning");
            this.butGoodMorning.BackgroundImage = null;
            this.butGoodMorning.Font = null;
            this.butGoodMorning.Name = "butGoodMorning";
            this.butGoodMorning.UseVisualStyleBackColor = true;
            this.butGoodMorning.Click += new System.EventHandler(this.butGoodMorning_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.butGoodMorning);
            this.Font = null;
            this.Icon = null;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butGoodMorning;
    }
}

