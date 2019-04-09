using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Xml;

namespace NetPinger
{
	public delegate void PingDelegate(HostPinger host);

	public enum HostStatus
	{
		Dead,
		Alive,
		Unknown
	};

	public class HostPinger
	{
		#region IPAddres

		private IPAddress _hostIP;

		public IPAddress HostIP
		{
			get { return _hostIP; }
			set { _hostIP = value; }
		}

		#endregion

		#region HostName

		private string _hostName = string.Empty;

		public string HostName
		{
			get { return _hostName; }
			set { _hostName = value; }
		}

		#endregion

		#region Statistics

		#region SentPakets

		private int _sentPackets;

		public int SentPackets
		{
			get
			{
				lock (_syncStatistics)
					return _sentPackets;
			}
		}

		#endregion

		#region RecivedPackets

		private int _recivedPackets;

		public int RecivedPackets
		{
			get
			{
				lock (_syncStatistics)
					return _recivedPackets;
			}
		}

		#endregion

		#region RecivedPacketsPercent

		public float RecivedPacketsPercents
		{
			get
			{
				lock (_syncStatistics)
					return _recivedPackets / _sentPackets * 100;
			}
		}

		#endregion

		#region LostPackets

		private int _lostPackets;

		public int LostPackets
		{
			get
			{
				lock (_syncStatistics)
					return _lostPackets;
			}
		}

		#endregion

		#region LostPacketsPercent

		public float LostPacketsPercent
		{
			get
			{
				lock (_syncStatistics)
					return (float)_lostPackets / _sentPackets * 100;
			}
		}

		#endregion

		#region CurrentResponseTime

		private long _currentResponseTime;

		public long CurrentResponseTime
		{
			get
			{
				lock (_syncStatistics)
					return _currentResponseTime;
			}
		}

		#endregion

		#region AvargeResponseTime

		private long _totalResponseTime = 0;

		public float AvargeResponseTime
		{
			get
			{
				lock (_syncStatistics)
					return _recivedPackets != 0 ? (float)_totalResponseTime / _recivedPackets : 0;
			}
		}

		#endregion

		#region Status

		private int _continousPacketLost = 0;

		private HostStatus _status = HostStatus.Unknown;

		public HostStatus Status
		{
			get
			{
				lock (_syncControl)
				{
					lock (_syncStatistics)
						return _isRunning ? _status : HostStatus.Unknown;
				}
			}
		}

		#endregion

		#region StatusDuration

		private DateTime _statusReachedAt = DateTime.Now;

		public TimeSpan StatusDuration
		{
			get
			{
				lock (_syncStatistics)
					return DateTime.Now.Subtract(_statusReachedAt);
			}
		}

		#endregion

		#region TestDuration

		private DateTime _startTime = DateTime.Now;

		public TimeSpan TestDuration
		{
			get
			{
				lock (_syncControl)
				{
					lock (_syncStatistics)
						return _isRunning ? DateTime.Now.Subtract(_startTime) : new TimeSpan(0);
				}
			}
		}

		#endregion

		private void IncLost()
		{
			lock (_syncStatistics)
			{
				_sentPackets++;
				_lostPackets++;

				lock (_syncOptions)
				{
					// enough packets has been lost so we can assume that the host is dead 
					if (++_continousPacketLost > _pingsBeforeDead && _status != HostStatus.Dead)
					{
						_statusReachedAt = DateTime.Now;
						Logger.Instance.Log(this, "Host died!");

						_status = HostStatus.Dead;
					}
				}
			}
		}

		private void IncRecived(long time)
		{
			lock (_syncStatistics)
			{
				_sentPackets++;
				_recivedPackets++;

				_totalResponseTime += time;
				_currentResponseTime = time;

				// restarts counter
				_continousPacketLost = 0;

				if (_status != HostStatus.Alive)
				{
					_statusReachedAt = DateTime.Now;
					Logger.Instance.Log(this, "Host is alive!");

					_status = HostStatus.Alive;
				}
			}
		}

		#endregion

		#region Options

		#region TTL

		public static readonly int DEFAULT_TTL = 32;

		private int _ttl = DEFAULT_TTL;

		public int TTL
		{
			get
			{
				lock (_syncOptions)
					return _ttl;
			}
			set
			{
				lock (_syncOptions)
				{
					if (value > 0 && value != _ttl)
					{
						_ttl = value;
						_pingerOptions.Ttl = value;
					}
				}
			}
		}

		#endregion

		#region DontFragment

		public static readonly bool DEFALUT_FRAGMENT = false;

		private bool _dontFragment;

		public bool DontFragment
		{
			get
			{
				lock (_syncOptions)
					return _dontFragment;
			}
			set
			{
				lock (_syncOptions)
				{
					if (value != _dontFragment)
					{
						_dontFragment = value;
						_pingerOptions.DontFragment = value;
					}
				}
			}
		}

		#endregion

		#region BufferSize

		public static readonly int DEFAULT_BUFFER_SIZE = 32;

		private int _bufferSize = DEFAULT_BUFFER_SIZE;

		public int BufferSize
		{
			get
			{
				lock (_syncOptions)
					return _bufferSize;
			}
			set
			{
				lock (_syncOptions)
				{
					if (value > 0)
					{
						_bufferSize = value;
						_buffer = new byte[value];
					}
				}
			}
		}

		#endregion

		#region Timeout

		public static readonly int DEFAULT_TIMEOUT = 2000;

		private int _timeout = DEFAULT_TIMEOUT;

		public int Timeout
		{
			get
			{
				lock (_syncOptions)
					return _timeout;
			}
			set
			{
				lock (_syncOptions)
					_timeout = value;
			}
		}


		#endregion

		#region PingInterval

		public static readonly int DEFAULT_PING_INTERVAL = 1000;

		private int _pingInterval = DEFAULT_PING_INTERVAL;

		public int PingInterval
		{
			get
			{
				lock (_syncOptions)
					return _pingInterval;
			}
			set
			{
				lock (_syncOptions)
					_pingInterval = value;
			}
		}

		#endregion

		#region PingsBeforeDead

		public static readonly int DEFALUT_PINGS_BEFORE_DEAD = 10;

		private int _pingsBeforeDead = DEFALUT_PINGS_BEFORE_DEAD;

		// How much packets should be lost so we can assume that the host is dead
		public int PingsBeforeDead
		{
			get
			{
				lock (_syncOptions)
					return _pingsBeforeDead;
			}
			set
			{
				lock (_syncOptions)
					_pingsBeforeDead = value;
			}
		}

		#endregion

		#endregion

		#region Private Attributes

		byte[] _buffer = new byte[DEFAULT_BUFFER_SIZE];

		System.Timers.Timer _timer = new System.Timers.Timer();

		Ping _pinger = new Ping();

		PingOptions _pingerOptions = new PingOptions(DEFAULT_TTL, DEFALUT_FRAGMENT);

		#endregion

		#region SynchronizationObjects

		object _syncStatistics = new object();
		object _syncOptions = new object();
		object _syncControl = new object();

		#endregion

		#region Events

		public event PingDelegate OnPing;

		private void RaisePing()
		{
			if (OnPing != null)
				OnPing(this);
		}

		#endregion

		#region Constructors

		public HostPinger()
		{
			_hostIP = new IPAddress(new byte[] { 127, 0, 0, 1 });
			_hostName = "localhost";
		}

		public HostPinger(XmlNode xmlNode)
		{
			if (xmlNode["name"] != null)
				HostName = xmlNode["name"].InnerText;
			else
				HostName = "No Name";

			if (xmlNode["ip"] != null)
				HostIP = IPAddress.Parse(xmlNode["ip"].InnerText);
			else
				HostIP = GetHostIpByName(_hostName);

			if (xmlNode["timeout"] != null)
				Timeout = int.Parse(xmlNode["timeout"].InnerText);

			if (xmlNode["interval"] != null)
				PingInterval = int.Parse(xmlNode["interval"].InnerText);

			if (xmlNode["pingsbeforedead"] != null)
				PingsBeforeDead = int.Parse(xmlNode["pingsbeforedead"].InnerText);

			if (xmlNode["buffersize"] != null)
				BufferSize = int.Parse(xmlNode["buffersize"].InnerText);

			if (xmlNode["ttl"] != null)
				TTL = int.Parse(xmlNode["ttl"].InnerText);

			if (xmlNode["dontfragment"] != null)
				DontFragment = bool.Parse(xmlNode["dontfragment"].InnerText);

			InitTimer();
		}

		public HostPinger(string hostName)
		{
			_hostName = hostName;
			_hostIP = GetHostIpByName(_hostName);

			InitTimer();
		}

		public HostPinger(IPAddress address)
		{
			_hostName = "No Name";
			_hostIP = address;

			InitTimer();
		}

		public HostPinger(string hostName, IPAddress address)
		{
			_hostName = hostName;
			_hostIP = address;

			InitTimer();
		}

		private IPAddress GetHostIpByName(string name)
		{
			IPHostEntry dnse;
			try
			{
				dnse = Dns.GetHostEntry(_hostName);
			}
			catch(Exception ex)
			{
				throw new Exception("Error connecting DNS for " + _hostName + " host", ex);
			}

			if (dnse != null)
				return dnse.AddressList[0];
			else
				throw new Exception("Cannot resolve host \"" + _hostName + "\" IP by its name.");
		}

		#endregion

		#region Timer

		void InitTimer()
		{
			_timer.AutoReset = false;
			_timer.Elapsed += new System.Timers.ElapsedEventHandler(_timer_Elapsed);
		}

		void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			Pinger();
		}

		#endregion

		#region Control

		#region IsRunning

		private bool _isRunning;

		public bool IsRunning
		{
			get
			{
				lock (_syncControl)
					return _isRunning;
			}

			set
			{
				if (value)
					Start();
				else
					Stop();
			}
		}

		#endregion

		public void Start()
		{
			Monitor.Enter(_syncControl);
			if (!_isRunning)
			{
				_isRunning = true;

				lock (_syncStatistics)
					// save test startting time 
					_startTime = DateTime.Now;

				Monitor.Exit(_syncControl);

				// run first ping
				Thread t = new Thread(new ThreadStart(Pinger));
				t.Start();

				// log command
				Logger.Instance.Log(this, "Pinging started");

				return;
			}
			Monitor.Exit(_syncControl);
		}

		public void Stop()
		{
			lock (_syncControl)
			{
				// log command
				if (_isRunning)
					Logger.Instance.Log(this, "Pinging stopped");

				_continousPacketLost = 0;

				_isRunning = false;
			}
		}

		#endregion

		#region Pinging

		private void Pinger()
		{
			lock (_syncControl)
			{
				PingReply reply;
				lock (_syncOptions)
					// send ping message
					reply = _pinger.Send(_hostIP, _timeout, _buffer, _pingerOptions);

				switch (reply.Status)
				{
					case IPStatus.BadDestination:
					case IPStatus.BadHeader:
					case IPStatus.BadOption:
					case IPStatus.BadRoute:
					case IPStatus.UnrecognizedNextHeader:
					case IPStatus.PacketTooBig:
					case IPStatus.ParameterProblem:
						// wrong message format
						IncLost();
						break;

					case IPStatus.DestinationScopeMismatch:
					case IPStatus.Unknown:
					case IPStatus.HardwareError:
					case IPStatus.IcmpError:
					case IPStatus.NoResources:
					case IPStatus.SourceQuench:
						// error
						IncLost();
						break;

					case IPStatus.DestinationHostUnreachable:
					case IPStatus.DestinationNetworkUnreachable:
					case IPStatus.DestinationPortUnreachable:
					case IPStatus.DestinationProhibited:
					case IPStatus.DestinationUnreachable:
						// unreachability of the remote host
						IncLost();
						break;

					case IPStatus.TimeExceeded:
					case IPStatus.TimedOut:
					case IPStatus.TtlExpired:
					case IPStatus.TtlReassemblyTimeExceeded:
						// time outs
						IncLost();
						break;

					case IPStatus.Success:
						// success
						IncRecived(reply.RoundtripTime);
						break;

					default:
						// something went wrong
						IncLost();
						break;
				}

				// still runnning?
				if (_isRunning)
				{
					lock (_syncOptions)
						// new interval if it was change
						_timer.Interval = _pingInterval;

					// ping another
					_timer.Start();
				}
			}

			// raise event
			RaisePing();
		}

		#endregion

	}
}
