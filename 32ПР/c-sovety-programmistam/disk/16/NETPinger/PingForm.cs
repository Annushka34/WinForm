using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using System.IO;

namespace NetPinger
{
	public partial class PingForm : Form
	{
		Hashtable _table = new Hashtable();

		List<HostPinger> _hosts = new List<HostPinger>();

		public PingForm()
		{
			InitializeComponent();

			XmlDocument config = new XmlDocument();
			config.Load("hosts.cfg");
			XmlNode hostsNode = config.ChildNodes[0];
			foreach (XmlNode node in hostsNode.ChildNodes)
			{
				try
				{
					HostPinger hp = new HostPinger(node);
					hp.OnPing += new PingDelegate(OnHostPing);
					_hosts.Add(hp);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public static void NotifyMessage(HostPinger host, string message)
		{
			if (Application.OpenForms.Count > 0)
			{
				PingForm frm = ((PingForm)Application.OpenForms[0]);
				if (frm != null)
					frm._notifyIcon.ShowBalloonTip(10000, host.HostName + "(" + host.HostIP.ToString() + ")", 
						message, ToolTipIcon.Info);
			}
		}

		string DurationToString(TimeSpan duration)
		{
			StringBuilder builder = new StringBuilder();
			if (duration.Days > 0)
			{
				builder.Append(duration.Days);
				builder.Append(duration.Days > 1 ? "days " : "day ");
			}

			builder.AppendFormat("{0:d2} : {1:d2} : {2:d2}", duration.Hours, duration.Minutes, duration.Seconds);

			return builder.ToString();
		}

		void OnHostPing(HostPinger host)
		{
			if (InvokeRequired)
			{
				Invoke(new PingDelegate(OnHostPing), new object[] { host });
				return;
			}

			lock (_table)
			{
				ListViewItem item = (ListViewItem)_table[host.HostIP];
				if (item != null)
				{
					item.SubItems[0].Text = host.HostIP.ToString();
					item.SubItems[1].Text = host.HostName;
					item.SubItems[2].Text = host.Status.ToString();
					item.SubItems[3].Text = DurationToString(host.StatusDuration);

					item.SubItems[4].Text = host.SentPackets.ToString();
					item.SubItems[5].Text = host.LostPackets.ToString();
					item.SubItems[6].Text = String.Format("{0:P}", host.LostPacketsPercent / 100);
					item.SubItems[7].Text = host.CurrentResponseTime.ToString();
					item.SubItems[8].Text = host.AvargeResponseTime.ToString("F");
					item.SubItems[9].Text = DurationToString(host.TestDuration);
				}
				else
				{
					item = new ListViewItem(new string[] 
					{ 
						host.HostIP.ToString(), host.HostName, host.Status.ToString(), DurationToString(host.StatusDuration), 
						host.SentPackets.ToString(), host.LostPackets.ToString(), String.Format( "{0:P}", host.LostPacketsPercent/100), 
						host.CurrentResponseTime.ToString(), host.AvargeResponseTime.ToString("F"), DurationToString(host.TestDuration)
					});

					_table.Add(host.HostIP, item);
					item.Tag = host;
					_lvHosts.Items.Insert(0, item);
				}

				switch (host.Status)
				{
					case HostStatus.Dead:
						item.BackColor = Color.Red;
						item.ForeColor = Color.White;
						break;
					case HostStatus.Alive:
						item.BackColor = Color.LightGreen;
						item.ForeColor = Color.Black;
						break;
					case HostStatus.Unknown:
						item.BackColor = Color.Yellow;
						item.ForeColor = Color.Black;
						break;
				}

				if (host == _selectedPinger)
				{
					_tbStartHost.Enabled = !_selectedPinger.IsRunning;
					_tbRemoveHost.Enabled = !_selectedPinger.IsRunning;
					_tbStopHost.Enabled = _selectedPinger.IsRunning;
				}
			}
		}

		private void _btnStart_Click(object sender, EventArgs e)
		{
			foreach (HostPinger hp in _hosts)
				hp.Start();
		}

		private void _btnStop_Click(object sender, EventArgs e)
		{
			foreach (HostPinger hp in _hosts)
				hp.Stop();
		}

		private void _lvHosts_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				ContextMenu menu = new ContextMenu();

				menu.MenuItems.Add(new MenuItem("Add new host...", new EventHandler(_tbAddNewHost_Click)));

				if (_selectedPinger != null)
				{
					menu.MenuItems.Add(new MenuItem("Host options...", new EventHandler(_tbHostOptions_Click)));
					if (_selectedPinger.IsRunning)
						menu.MenuItems.Add(new MenuItem("Stop ping", new EventHandler(_tbStopHost_Click)));
					else
					{
						menu.MenuItems.Add(new MenuItem("Start ping", new EventHandler(_tbStopHost_Click)));
						menu.MenuItems.Add(new MenuItem("Remove host", new EventHandler(_tbRemoveHost_Click)));
					}
				}

				menu.Show(this, e.Location);
			}
		}

		private FormWindowState _oldState = FormWindowState.Normal;

		private void _notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				Visible = true;
				WindowState = _oldState;
			}
			else
			{
				WindowState = FormWindowState.Minimized;
				Visible = false;
			}
		}

		private void _notifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (WindowState != FormWindowState.Minimized)
					Activate();
			}
		}

		private void PingForm_SizeChanged(object sender, EventArgs e)
		{
			if (WindowState != FormWindowState.Minimized)
				_oldState = WindowState;

			Visible = WindowState != FormWindowState.Minimized;
		}

		private void _tbStartAll_Click(object sender, EventArgs e)
		{
			foreach (HostPinger hp in _hosts)
				hp.Start();
		}

		private void _tbStopAll_Click(object sender, EventArgs e)
		{
			foreach (HostPinger hp in _hosts)
				hp.Stop();
		}

		private void _tbStartHost_Click(object sender, EventArgs e)
		{
			if (_selectedPinger != null)
				_selectedPinger.Start();
		}

		private void _tbStopHost_Click(object sender, EventArgs e)
		{
			if (_selectedPinger != null)
				_selectedPinger.Stop();
		}

		private void _tbAddNewHost_Click(object sender, EventArgs e)
		{
			HostOptions dlg = new HostOptions();
			if (dlg.ShowDialog(this, null) == DialogResult.OK)
			{
				foreach (HostPinger hp in _hosts)
				{
					if (hp.HostIP == dlg.Host.HostIP)
					{
						MessageBox.Show("Host already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}

				_hosts.Add(dlg.Host);
				dlg.Host.OnPing += new PingDelegate(OnHostPing);
			}
		}

		private void _tbHostOptions_Click(object sender, EventArgs e)
		{
			if (_selectedPinger != null)
			{
				HostOptions dlg = new HostOptions();
				dlg.ShowDialog(this, _selectedPinger);
			}
		}

		private void _tbRemoveHost_Click(object sender, EventArgs e)
		{
			if (_selectedPinger != null && !_selectedPinger.IsRunning)
			{
				lock (_table)
				{
					_hosts.Remove(_selectedPinger);
					ListViewItem hi = (ListViewItem)_table[_selectedPinger.HostIP];
					_table.Remove(_selectedPinger.HostIP);
					_lvHosts.Items.Remove(hi);
				}
			}
		}

		private HostPinger _selectedPinger = null;

		private void _lvHosts_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_lvHosts.SelectedItems != null && _lvHosts.SelectedItems.Count > 0)
				_selectedPinger = (HostPinger)_lvHosts.SelectedItems[0].Tag;
			else
				_selectedPinger = null;

			_tbStartHost.Enabled = _selectedPinger != null && !_selectedPinger.IsRunning;
			_tbRemoveHost.Enabled = _selectedPinger != null && !_selectedPinger.IsRunning;
			_tbStopHost.Enabled = _selectedPinger != null && _selectedPinger.IsRunning;

			_tbHostOptions.Enabled = _selectedPinger != null;
		}

		private void _nimRestore_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Maximized)
				WindowState = FormWindowState.Normal;
			else
			{
				Visible = true;
				WindowState = _oldState;
			}
		}

		private void _nimMaximize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized;
			Visible = true;
		}

		private void _nimMinimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void _nimExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void _tbAbout_Click(object sender, EventArgs e)
		{
			AboutForm dlg = new AboutForm();
			dlg.ShowDialog(this);
		}
	}
}