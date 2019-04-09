using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NetPinger
{
	class Logger
	{
		static readonly string LOG_ROW_FORMAT = "{0,-21}| ({1,-15}) {2,-30} | {3}";

		StreamWriter _fileWriter;

		static Logger _instance;
		static object _syncInstance = new object();

		public static Logger Instance
		{
			get
			{
				lock (_syncInstance)
				{
					if (_instance == null)
						_instance = new Logger();

					return _instance;
				}
			}
		}

		public Logger()
		{
			_fileWriter = new StreamWriter(File.Open("pinger.log", FileMode.Append, FileAccess.Write, FileShare.Read));
		}

		public void Log(HostPinger host, string message)
		{
			PingForm.NotifyMessage(host, message);

			lock (this)
			{
				_fileWriter.WriteLine(LOG_ROW_FORMAT, DateTime.Now, host.HostIP, host.HostName, message);
				_fileWriter.Flush();
			}
		}
	}
}
