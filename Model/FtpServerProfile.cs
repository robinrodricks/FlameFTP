using System;
using System.Net;
using System.Security.Authentication;
using System.Security.Policy;
using System.Text;
using FlameFTP.Enums;
using FluentFTP;
using FluentFTP.Proxy.SyncProxy;

namespace FlameFTP.Model {
	/// <summary>
	/// One instance per FTP server registered in the system. Saved to disk in a JSON settings file.
	/// </summary>
	[Serializable]
	public class FtpServerProfile {
		public Guid SiteKey = Guid.NewGuid();

		public string DisplayName { get; set; } = "New Profile";
		public string Host { get; set; } = "localhost";
		public string User { get; set; } = "anonymous";
		public string Pass { get; set; } = "anonymous";
		public int Port { get; set; } = 0;
		public FtpEncryptionMode Protocol { get; set; } = FtpEncryptionMode.Auto;
		public SslProtocols SecureProtocol { get; set; } = SslProtocols.Default;
		public FtpEncodingType Encoding { get; set; } = FtpEncodingType.UTF8;
		public FtpDataType DataTransType { get; set; } = FtpDataType.Binary;
		public FtpDataConnectionType DataConnType { get; set; } = FtpDataConnectionType.AutoPassive;
		public bool IsAuto { get; set; } = true;
		public string InitialServerPath { get; set; } = "/";
		public string InitialLocalPath { get; set; } = "C:\\";
		public bool IsProxy { get; set; } = false;
		public FtpProxyType ProxyType { get; set; } = FtpProxyType.Socks5;
		public string ProxyHost { get; set; } = "localhost";
		public string ProxyUser { get; set; } = "anonymous";
		public string ProxyPass { get; set; } = "anonymous";
		public int ProxyPort { get; set; } = 0;

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
				InitialServerPath = this.InitialServerPath,
				InitialLocalPath = this.InitialLocalPath,
				IsProxy = this.IsProxy,
				ProxyType = this.ProxyType,
				ProxyHost = this.ProxyHost,
				ProxyUser = this.ProxyUser,
				ProxyPass = this.ProxyPass,
				ProxyPort = this.ProxyPort,
			};
		}
		public override string ToString() {
			return DisplayName ?? "<untitled>";
		}

		public FtpClient CreateClient() {
			FtpClient client;

			if (!IsProxy) {

				// create a regular FTP client
				client = new FtpClient();
				client.Host = Host;
				client.Port = Port;
				client.Credentials = new NetworkCredential(User, Pass);
			}
			else {

				// create proxy config object based on this profile
				var proxyConfig = new FtpProxyProfile {
					FtpHost = Host,
					FtpPort = Port,
					FtpCredentials = new NetworkCredential(User, Pass),
					ProxyHost = ProxyHost,
					ProxyPort = ProxyPort,
					ProxyCredentials = new NetworkCredential(ProxyUser, ProxyPass),
				};

				// create a FTP proxy client
				switch (ProxyType) {
					case FtpProxyType.Socks5:
						client = new FtpClientSocks5Proxy(proxyConfig);
						break;
					case FtpProxyType.Socks4:
						client = new FtpClientSocks4Proxy(proxyConfig);
						break;
					case FtpProxyType.Socks4a:
						client = new FtpClientSocks4aProxy(proxyConfig);
						break;
					case FtpProxyType.Http11:
						client = new FtpClientHttp11Proxy(proxyConfig);
						break;
					case FtpProxyType.UserAtHost:
						client = new FtpClientUserAtHostProxy(proxyConfig);
						break;
					case FtpProxyType.BlueCoat:
						client = new FtpClientBlueCoatProxy(proxyConfig);
						break;
					default:
						return null;
				}
			}

			client.Encoding = GetEncoding();
			client.Config.EncryptionMode = Protocol;
			client.Config.SslProtocols = SecureProtocol;
			client.Config.DataConnectionType = DataConnType;
			client.Config.DownloadDataType = DataTransType;
			client.Config.UploadDataType = DataTransType;
			client.Config.ValidateAnyCertificate = true;

			return client;
		}

	}
}
