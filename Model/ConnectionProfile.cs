using System;
using System.Security.Authentication;
using System.Security.Policy;
using FluentFTP;

namespace FlameFTP.Model
{
	public class ConnectionProfile
	{
		public Guid SiteKey { get; set; }
		public string Sitename { get; set; }
		public string HostName { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int PortNo { get; set; }
		public SslProtocols SslProtocols { get; set; }
		public FtpEncryptionMode FtpEncryptionMode { get; set; }
		public FtpDataConnectionType FtpDataConnectionType { get; set; }

		public ConnectionProfile()
		{
			SiteKey = Guid.NewGuid();
			;
		}

	}
}
