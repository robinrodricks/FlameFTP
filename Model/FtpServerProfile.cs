using System;
using System.Net;
using System.Security.Authentication;
using System.Security.Policy;
using System.Text;
using FlameFTP.Enums;
using FluentFTP;

namespace FlameFTP.Model {
	/// <summary>
	/// One instance per FTP server registered in the system. Saved to disk in a JSON settings file.
	/// </summary>
	[Serializable]
	public class FtpServerProfile {
		public Guid SiteKey = Guid.NewGuid();

		public string DisplayName { get; set; } = "New Profile";
		public string Host { get; set; } = "localhost";
		public string User { get; set; } = "";
		public string Pass { get; set; } = "";
		public int Port { get; set; } = 0;
		public FtpEncryptionMode Protocol { get; set; } = FtpEncryptionMode.Auto;
		public SslProtocols SecureProtocol { get; set; } = SslProtocols.Default;
		public FtpEncodingType Encoding { get; set; } = FtpEncodingType.UTF8;
		public FtpDataType DataTransType { get; set; } = FtpDataType.Binary;
		public FtpDataConnectionType DataConnType { get; set; } = FtpDataConnectionType.AutoPassive;
		public bool IsAuto { get; set; } = true;

		public Encoding GetEncoding() {
			if (Encoding == FtpEncodingType.UTF8) {
				return System.Text.Encoding.UTF8;
			}
			return System.Text.Encoding.GetEncoding((int)Encoding);
		}
		public FtpServerProfile Clone() {
			return new FtpServerProfile {
				Host = this.Host,
				User = this.User,
				Pass = this.Pass,
				Port = this.Port,
				Encoding = this.Encoding,
				DataTransType = this.DataTransType,
				Protocol = this.Protocol,
				SecureProtocol = this.SecureProtocol,
				DataConnType = this.DataConnType,
				IsAuto = this.IsAuto,
			};
		}
		public override string ToString() {
			return DisplayName ?? "<untitled>";
		}

		public void ConfigureClient(FtpClient client) {
			client.Host = Host;
			client.Port = Port;
			client.Credentials = new NetworkCredential(User, Pass);
			client.Encoding = GetEncoding();
			client.Config.EncryptionMode = Protocol;
			client.Config.SslProtocols = SecureProtocol;
			client.Config.DataConnectionType = DataConnType;
			client.Config.DownloadDataType = DataTransType;
			client.Config.UploadDataType = DataTransType;
		}

	}
}
