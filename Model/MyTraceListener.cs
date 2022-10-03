using FlameFTP.Managers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlameFTP.Model
{
	class MyTraceListener : TraceListener
	{
		public override void Write(string message)
		{
		}

		public override void WriteLine(string message)
		{

			FtpClientEventArgs args = new FtpClientEventArgs();
			args.FtpEventMessage = message;
			SettingsManager.OnFtpMessageReceived(args);
		}

		
	}
}
