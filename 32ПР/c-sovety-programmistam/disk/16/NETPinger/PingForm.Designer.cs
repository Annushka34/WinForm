namespace NetPinger
{
	partial class PingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingForm));
			this._lvHosts = new System.Windows.Forms.ListView();
			this._colIpAddr = new System.Windows.Forms.ColumnHeader();
			this._colHostName = new System.Windows.Forms.ColumnHeader();
			this._colStatus = new System.Windows.Forms.ColumnHeader();
			this._colStatusDuration = new System.Windows.Forms.ColumnHeader();
			this._colPacketSent = new System.Windows.Forms.ColumnHeader();
			this._colPacketLost = new System.Windows.Forms.ColumnHeader();
			this._colPacketLostPercent = new System.Windows.Forms.ColumnHeader();
			this._colCurrentResponseTime = new System.Windows.Forms.ColumnHeader();
			this._colAvargeResponseTime = new System.Windows.Forms.ColumnHeader();
			this._colTestDuration = new System.Windows.Forms.ColumnHeader();
			this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this._notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._nimRestore = new System.Windows.Forms.ToolStripMenuItem();
			this._nimMaximize = new System.Windows.Forms.ToolStripMenuItem();
			this._nimMinimize = new System.Windows.Forms.ToolStripMenuItem();
			this._nimExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this._nimStartAll = new System.Windows.Forms.ToolStripMenuItem();
			this._nimStopAll = new System.Windows.Forms.ToolStripMenuItem();
			this._toolbar = new System.Windows.Forms.ToolStrip();
			this._tbStartAll = new System.Windows.Forms.ToolStripButton();
			this._tbStopAll = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this._tbStartHost = new System.Windows.Forms.ToolStripButton();
			this._tbStopHost = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this._tbAddNewHost = new System.Windows.Forms.ToolStripButton();
			this._tbHostOptions = new System.Windows.Forms.ToolStripButton();
			this._tbRemoveHost = new System.Windows.Forms.ToolStripButton();
			this._tbAbout = new System.Windows.Forms.ToolStripButton();
			this._notifyIconMenu.SuspendLayout();
			this._toolbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// _lvHosts
			// 
			this._lvHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._lvHosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._colIpAddr,
            this._colHostName,
            this._colStatus,
            this._colStatusDuration,
            this._colPacketSent,
            this._colPacketLost,
            this._colPacketLostPercent,
            this._colCurrentResponseTime,
            this._colAvargeResponseTime,
            this._colTestDuration});
			this._lvHosts.FullRowSelect = true;
			this._lvHosts.GridLines = true;
			this._lvHosts.Location = new System.Drawing.Point(0, 34);
			this._lvHosts.MultiSelect = false;
			this._lvHosts.Name = "_lvHosts";
			this._lvHosts.Size = new System.Drawing.Size(760, 218);
			this._lvHosts.TabIndex = 0;
			this._lvHosts.UseCompatibleStateImageBehavior = false;
			this._lvHosts.View = System.Windows.Forms.View.Details;
			this._lvHosts.SelectedIndexChanged += new System.EventHandler(this._lvHosts_SelectedIndexChanged);
			this._lvHosts.MouseUp += new System.Windows.Forms.MouseEventHandler(this._lvHosts_MouseUp);
			// 
			// _colIpAddr
			// 
			this._colIpAddr.Text = "IP Address";
			this._colIpAddr.Width = 108;
			// 
			// _colHostName
			// 
			this._colHostName.Text = "Host Name";
			this._colHostName.Width = 127;
			// 
			// _colStatus
			// 
			this._colStatus.Text = "Status";
			this._colStatus.Width = 61;
			// 
			// _colStatusDuration
			// 
			this._colStatusDuration.Text = "Status Duration";
			this._colStatusDuration.Width = 86;
			// 
			// _colPacketSent
			// 
			this._colPacketSent.Text = "Sent";
			this._colPacketSent.Width = 50;
			// 
			// _colPacketLost
			// 
			this._colPacketLost.Text = "Lost";
			this._colPacketLost.Width = 50;
			// 
			// _colPacketLostPercent
			// 
			this._colPacketLostPercent.Text = "Lost %";
			this._colPacketLostPercent.Width = 55;
			// 
			// _colCurrentResponseTime
			// 
			this._colCurrentResponseTime.Text = "Current R.T.";
			this._colCurrentResponseTime.Width = 70;
			// 
			// _colAvargeResponseTime
			// 
			this._colAvargeResponseTime.Text = "Avarge R.T.";
			this._colAvargeResponseTime.Width = 70;
			// 
			// _colTestDuration
			// 
			this._colTestDuration.Text = "Test Duration";
			this._colTestDuration.Width = 76;
			// 
			// _notifyIcon
			// 
			this._notifyIcon.ContextMenuStrip = this._notifyIconMenu;
			this._notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_notifyIcon.Icon")));
			this._notifyIcon.Text = "Coolsoft NetPinger";
			this._notifyIcon.Visible = true;
			this._notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this._notifyIcon_MouseClick);
			this._notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._notifyIcon_MouseDoubleClick);
			// 
			// _notifyIconMenu
			// 
			this._notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._nimRestore,
            this._nimMaximize,
            this._nimMinimize,
            this._nimExit,
            this.toolStripMenuItem1,
            this._nimStartAll,
            this._nimStopAll});
			this._notifyIconMenu.Name = "_notifyIconMenu";
			this._notifyIconMenu.Size = new System.Drawing.Size(125, 142);
			// 
			// _nimRestore
			// 
			this._nimRestore.Name = "_nimRestore";
			this._nimRestore.Size = new System.Drawing.Size(124, 22);
			this._nimRestore.Text = "Restore";
			this._nimRestore.Click += new System.EventHandler(this._nimRestore_Click);
			// 
			// _nimMaximize
			// 
			this._nimMaximize.Name = "_nimMaximize";
			this._nimMaximize.Size = new System.Drawing.Size(124, 22);
			this._nimMaximize.Text = "Maximize";
			this._nimMaximize.Click += new System.EventHandler(this._nimMaximize_Click);
			// 
			// _nimMinimize
			// 
			this._nimMinimize.Name = "_nimMinimize";
			this._nimMinimize.Size = new System.Drawing.Size(124, 22);
			this._nimMinimize.Text = "Minimize";
			this._nimMinimize.Click += new System.EventHandler(this._nimMinimize_Click);
			// 
			// _nimExit
			// 
			this._nimExit.Name = "_nimExit";
			this._nimExit.Size = new System.Drawing.Size(124, 22);
			this._nimExit.Text = "Exit";
			this._nimExit.Click += new System.EventHandler(this._nimExit_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
			// 
			// _nimStartAll
			// 
			this._nimStartAll.Name = "_nimStartAll";
			this._nimStartAll.Size = new System.Drawing.Size(124, 22);
			this._nimStartAll.Text = "Start All";
			this._nimStartAll.Click += new System.EventHandler(this._tbStartAll_Click);
			// 
			// _nimStopAll
			// 
			this._nimStopAll.Name = "_nimStopAll";
			this._nimStopAll.Size = new System.Drawing.Size(124, 22);
			this._nimStopAll.Text = "Stop All";
			this._nimStopAll.Click += new System.EventHandler(this._tbStopAll_Click);
			// 
			// _toolbar
			// 
			this._toolbar.ImageScalingSize = new System.Drawing.Size(24, 24);
			this._toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tbStartAll,
            this._tbStopAll,
            this.toolStripSeparator1,
            this._tbStartHost,
            this._tbStopHost,
            this.toolStripSeparator2,
            this._tbAddNewHost,
            this._tbHostOptions,
            this._tbRemoveHost,
            this._tbAbout});
			this._toolbar.Location = new System.Drawing.Point(0, 0);
			this._toolbar.Name = "_toolbar";
			this._toolbar.Size = new System.Drawing.Size(760, 31);
			this._toolbar.TabIndex = 3;
			this._toolbar.Text = "Toolbar";
			// 
			// _tbStartAll
			// 
			this._tbStartAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tbStartAll.Image = ((System.Drawing.Image)(resources.GetObject("_tbStartAll.Image")));
			this._tbStartAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tbStartAll.Name = "_tbStartAll";
			this._tbStartAll.Size = new System.Drawing.Size(28, 28);
			this._tbStartAll.Text = "Start All";
			this._tbStartAll.Click += new System.EventHandler(this._tbStartAll_Click);
			// 
			// _tbStopAll
			// 
			this._tbStopAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tbStopAll.Image = ((System.Drawing.Image)(resources.GetObject("_tbStopAll.Image")));
			this._tbStopAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tbStopAll.Name = "_tbStopAll";
			this._tbStopAll.Size = new System.Drawing.Size(28, 28);
			this._tbStopAll.Text = "Stop All";
			this._tbStopAll.Click += new System.EventHandler(this._tbStopAll_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// _tbStartHost
			// 
			this._tbStartHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tbStartHost.Enabled = false;
			this._tbStartHost.Image = ((System.Drawing.Image)(resources.GetObject("_tbStartHost.Image")));
			this._tbStartHost.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tbStartHost.Name = "_tbStartHost";
			this._tbStartHost.Size = new System.Drawing.Size(28, 28);
			this._tbStartHost.Text = "Start Host";
			this._tbStartHost.Click += new System.EventHandler(this._tbStartHost_Click);
			// 
			// _tbStopHost
			// 
			this._tbStopHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tbStopHost.Enabled = false;
			this._tbStopHost.Image = ((System.Drawing.Image)(resources.GetObject("_tbStopHost.Image")));
			this._tbStopHost.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tbStopHost.Name = "_tbStopHost";
			this._tbStopHost.Size = new System.Drawing.Size(28, 28);
			this._tbStopHost.Text = "Stop Host";
			this._tbStopHost.Click += new System.EventHandler(this._tbStopHost_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
			// 
			// _tbAddNewHost
			// 
			this._tbAddNewHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tbAddNewHost.Image = ((System.Drawing.Image)(resources.GetObject("_tbAddNewHost.Image")));
			this._tbAddNewHost.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tbAddNewHost.Name = "_tbAddNewHost";
			this._tbAddNewHost.Size = new System.Drawing.Size(28, 28);
			this._tbAddNewHost.Text = "Add New Host";
			this._tbAddNewHost.Click += new System.EventHandler(this._tbAddNewHost_Click);
			// 
			// _tbHostOptions
			// 
			this._tbHostOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tbHostOptions.Enabled = false;
			this._tbHostOptions.Image = ((System.Drawing.Image)(resources.GetObject("_tbHostOptions.Image")));
			this._tbHostOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tbHostOptions.Name = "_tbHostOptions";
			this._tbHostOptions.Size = new System.Drawing.Size(28, 28);
			this._tbHostOptions.Text = "Host Options";
			this._tbHostOptions.Click += new System.EventHandler(this._tbHostOptions_Click);
			// 
			// _tbRemoveHost
			// 
			this._tbRemoveHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tbRemoveHost.Enabled = false;
			this._tbRemoveHost.Image = ((System.Drawing.Image)(resources.GetObject("_tbRemoveHost.Image")));
			this._tbRemoveHost.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tbRemoveHost.Name = "_tbRemoveHost";
			this._tbRemoveHost.Size = new System.Drawing.Size(28, 28);
			this._tbRemoveHost.Text = "Remove Host";
			this._tbRemoveHost.Click += new System.EventHandler(this._tbRemoveHost_Click);
			// 
			// _tbAbout
			// 
			this._tbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._tbAbout.Image = ((System.Drawing.Image)(resources.GetObject("_tbAbout.Image")));
			this._tbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._tbAbout.Name = "_tbAbout";
			this._tbAbout.Size = new System.Drawing.Size(28, 28);
			this._tbAbout.Text = "About NetPinger";
			this._tbAbout.Click += new System.EventHandler(this._tbAbout_Click);
			// 
			// PingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 252);
			this.Controls.Add(this._toolbar);
			this.Controls.Add(this._lvHosts);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PingForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Coolsoft NetPinger";
			this.SizeChanged += new System.EventHandler(this.PingForm_SizeChanged);
			this._notifyIconMenu.ResumeLayout(false);
			this._toolbar.ResumeLayout(false);
			this._toolbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView _lvHosts;
		private System.Windows.Forms.ColumnHeader _colHostName;
		private System.Windows.Forms.ColumnHeader _colIpAddr;
		private System.Windows.Forms.ColumnHeader _colStatus;
		private System.Windows.Forms.ColumnHeader _colPacketSent;
		private System.Windows.Forms.ColumnHeader _colPacketLost;
		private System.Windows.Forms.ColumnHeader _colPacketLostPercent;
		private System.Windows.Forms.ColumnHeader _colCurrentResponseTime;
		private System.Windows.Forms.ColumnHeader _colAvargeResponseTime;
		private System.Windows.Forms.ColumnHeader _colStatusDuration;
		private System.Windows.Forms.ColumnHeader _colTestDuration;
		private System.Windows.Forms.NotifyIcon _notifyIcon;
		private System.Windows.Forms.ToolStrip _toolbar;
		private System.Windows.Forms.ToolStripButton _tbStartAll;
		private System.Windows.Forms.ToolStripButton _tbStopAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton _tbStartHost;
		private System.Windows.Forms.ToolStripButton _tbStopHost;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton _tbAddNewHost;
		private System.Windows.Forms.ToolStripButton _tbHostOptions;
		private System.Windows.Forms.ToolStripButton _tbRemoveHost;
		private System.Windows.Forms.ContextMenuStrip _notifyIconMenu;
		private System.Windows.Forms.ToolStripMenuItem _nimRestore;
		private System.Windows.Forms.ToolStripMenuItem _nimMaximize;
		private System.Windows.Forms.ToolStripMenuItem _nimMinimize;
		private System.Windows.Forms.ToolStripMenuItem _nimStartAll;
		private System.Windows.Forms.ToolStripMenuItem _nimStopAll;
		private System.Windows.Forms.ToolStripMenuItem _nimExit;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripButton _tbAbout;
	}
}

