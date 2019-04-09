namespace NetPinger
{
	partial class HostOptions
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
			this.label1 = new System.Windows.Forms.Label();
			this._spTtl = new System.Windows.Forms.NumericUpDown();
			this._chkbDontFragent = new System.Windows.Forms.CheckBox();
			this._spBufferSize = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this._spPingsBeforeDeath = new System.Windows.Forms.NumericUpDown();
			this._spInterval = new System.Windows.Forms.NumericUpDown();
			this._spTimeout = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._btnCancel = new System.Windows.Forms.Button();
			this._btnOk = new System.Windows.Forms.Button();
			this._tbHostName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this._btnResolve = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this._tbHostIp = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this._spTtl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._spBufferSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._spPingsBeforeDeath)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._spInterval)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._spTimeout)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(92, 201);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "TTL:";
			// 
			// _spTtl
			// 
			this._spTtl.Location = new System.Drawing.Point(133, 197);
			this._spTtl.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this._spTtl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._spTtl.Name = "_spTtl";
			this._spTtl.Size = new System.Drawing.Size(98, 20);
			this._spTtl.TabIndex = 8;
			this._spTtl.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
			// 
			// _chkbDontFragent
			// 
			this._chkbDontFragent.AutoSize = true;
			this._chkbDontFragent.Location = new System.Drawing.Point(133, 224);
			this._chkbDontFragent.Name = "_chkbDontFragent";
			this._chkbDontFragent.Size = new System.Drawing.Size(98, 17);
			this._chkbDontFragent.TabIndex = 9;
			this._chkbDontFragent.Text = "Don\'t Fragment";
			this._chkbDontFragent.UseVisualStyleBackColor = true;
			// 
			// _spBufferSize
			// 
			this._spBufferSize.Location = new System.Drawing.Point(133, 171);
			this._spBufferSize.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this._spBufferSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._spBufferSize.Name = "_spBufferSize";
			this._spBufferSize.Size = new System.Drawing.Size(98, 20);
			this._spBufferSize.TabIndex = 7;
			this._spBufferSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 175);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Buffer Size:";
			// 
			// _spPingsBeforeDeath
			// 
			this._spPingsBeforeDeath.Location = new System.Drawing.Point(133, 145);
			this._spPingsBeforeDeath.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this._spPingsBeforeDeath.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._spPingsBeforeDeath.Name = "_spPingsBeforeDeath";
			this._spPingsBeforeDeath.Size = new System.Drawing.Size(98, 20);
			this._spPingsBeforeDeath.TabIndex = 6;
			this._spPingsBeforeDeath.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// _spInterval
			// 
			this._spInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this._spInterval.Location = new System.Drawing.Point(133, 119);
			this._spInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this._spInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this._spInterval.Name = "_spInterval";
			this._spInterval.Size = new System.Drawing.Size(98, 20);
			this._spInterval.TabIndex = 5;
			this._spInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// _spTimeout
			// 
			this._spTimeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this._spTimeout.Location = new System.Drawing.Point(133, 93);
			this._spTimeout.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this._spTimeout.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this._spTimeout.Name = "_spTimeout";
			this._spTimeout.Size = new System.Drawing.Size(98, 20);
			this._spTimeout.TabIndex = 4;
			this._spTimeout.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Pings Before Death:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(77, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Interval:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(74, 97);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Timeout:";
			// 
			// _btnCancel
			// 
			this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCancel.Location = new System.Drawing.Point(156, 247);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(75, 23);
			this._btnCancel.TabIndex = 11;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			// 
			// _btnOk
			// 
			this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._btnOk.Location = new System.Drawing.Point(75, 247);
			this._btnOk.Name = "_btnOk";
			this._btnOk.Size = new System.Drawing.Size(75, 23);
			this._btnOk.TabIndex = 10;
			this._btnOk.Text = "OK";
			this._btnOk.UseVisualStyleBackColor = true;
			// 
			// _tbHostName
			// 
			this._tbHostName.Location = new System.Drawing.Point(133, 12);
			this._tbHostName.Name = "_tbHostName";
			this._tbHostName.Size = new System.Drawing.Size(98, 20);
			this._tbHostName.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(59, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Host Name:";
			// 
			// _btnResolve
			// 
			this._btnResolve.Location = new System.Drawing.Point(156, 38);
			this._btnResolve.Name = "_btnResolve";
			this._btnResolve.Size = new System.Drawing.Size(75, 23);
			this._btnResolve.TabIndex = 2;
			this._btnResolve.Text = "Resolve";
			this._btnResolve.UseVisualStyleBackColor = true;
			this._btnResolve.Click += new System.EventHandler(this._btnResolve_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(77, 71);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Host IP:";
			// 
			// _tbHostIp
			// 
			this._tbHostIp.Location = new System.Drawing.Point(133, 67);
			this._tbHostIp.Name = "_tbHostIp";
			this._tbHostIp.Size = new System.Drawing.Size(98, 20);
			this._tbHostIp.TabIndex = 3;
			// 
			// HostOptions
			// 
			this.AcceptButton = this._btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._btnCancel;
			this.ClientSize = new System.Drawing.Size(254, 285);
			this.Controls.Add(this._tbHostIp);
			this.Controls.Add(this.label7);
			this.Controls.Add(this._btnResolve);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._tbHostName);
			this.Controls.Add(this._btnOk);
			this.Controls.Add(this._btnCancel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._spTimeout);
			this.Controls.Add(this._spInterval);
			this.Controls.Add(this._spPingsBeforeDeath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._spBufferSize);
			this.Controls.Add(this._chkbDontFragent);
			this.Controls.Add(this._spTtl);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HostOptions";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Host Options";
			this.Load += new System.EventHandler(this.HostOptions_Load);
			((System.ComponentModel.ISupportInitialize)(this._spTtl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._spBufferSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._spPingsBeforeDeath)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._spInterval)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._spTimeout)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown _spTtl;
		private System.Windows.Forms.CheckBox _chkbDontFragent;
		private System.Windows.Forms.NumericUpDown _spBufferSize;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown _spPingsBeforeDeath;
		private System.Windows.Forms.NumericUpDown _spInterval;
		private System.Windows.Forms.NumericUpDown _spTimeout;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.Button _btnOk;
		private System.Windows.Forms.TextBox _tbHostName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button _btnResolve;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox _tbHostIp;
	}
}