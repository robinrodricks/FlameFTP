using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using FlameFTP.Model;
using FluentFTP;

namespace FlameFTP.Managers {
	public class FtpFileManager {
		private FtpClient _client;
		public ConnectionProfile ConnectionProfile { get; set; }
		public string LocalPath;
		private string _remotePath;
		public string RemotePath {
			get { return _remotePath; }
			set {
				_remotePath = value;

				var client = GetClient();
				client.SetWorkingDirectory(RemotePath);
			}
		}

		public FtpClient GetClient() {
			if (_client == null) {
				NetworkCredential networkCredential = new NetworkCredential(ConnectionProfile.UserName, ConnectionProfile.Password);
				_client = new FtpClient(ConnectionProfile.HostName, networkCredential, ConnectionProfile.PortNo);
				_client.Config.SslProtocols = ConnectionProfile.SslProtocols;
				_client.Config.DataConnectionType = ConnectionProfile.FtpDataConnectionType;
				_client.Config.EncryptionMode = ConnectionProfile.FtpEncryptionMode;

			}

			if (_client.IsConnected == false) {
				_client.Connect();
			}

			return _client;
		}

		public bool DownloadFile(string localPath, string remotePath) {
			var client = GetClient();
			var ok = client.DownloadFile(localPath, remotePath);
			return ok == FtpStatus.Success || ok == FtpStatus.Skipped;
		}

		public string GetFolderPathFromListItem(FtpListItem ftpListItem) {
			if (ftpListItem.Type == FtpObjectType.Directory) {
				return ftpListItem.FullName;
			}

			if (ftpListItem.Type == FtpObjectType.File) {
				return Path.GetDirectoryName(ftpListItem.FullName);
			}
			return "";
		}

		public void DownloadFiles(List<FtpListItem> ftpItemsList, string folderPath, string baseRemotePath) {
			try {
				var filetemp = Path.Combine(folderPath, "tempfile.tmp");
				FileStream ewrr = File.Create(filetemp);
				ewrr.Close();
				File.Delete(filetemp);
			}
			catch (Exception e) {
				Console.WriteLine(e);
				return;
			}

			var client = GetClient();

			foreach (FtpListItem ftpListItem in ftpItemsList) {

				if (ftpListItem.Type == FtpObjectType.Directory) {
					var newRootpath = folderPath;

					var newfolderpath = ftpListItem.FullName.Replace(baseRemotePath, @"\");
					var newDirectory = newRootpath + newfolderpath;

					LocalFileManager.CreateDirectory(newDirectory);
				}

				if (ftpListItem.Type == FtpObjectType.File) {
					var wd = ftpListItem.FullName.Replace(ftpListItem.Name, "");
					client.SetWorkingDirectory(wd);

					var newRootpath = folderPath;
					string newFilePath = ftpListItem.FullName.Replace(baseRemotePath, "");

					string newFilePath2 = newFilePath.Replace("/", "\\");
					var newFileName = newRootpath + newFilePath2;
					client.DownloadFile(newFileName, ftpListItem.Name);
				}


			}
		}

		public bool UploadFile(string localPath, string remotePath) {
			var client = GetClient();
			var ok = client.UploadFile(localPath, remotePath);
			return ok == FtpStatus.Success || ok == FtpStatus.Skipped;
		}

		public void Uploadfiles(List<FtpListItem> ftpItemsList) {

			//client.EnableThreadSafeDataConnections = true;
			var client = GetClient();


			foreach (FtpListItem ftpListItem in ftpItemsList) {
				var wd = Path.GetDirectoryName(ftpListItem.Name);
				if (client.DirectoryExists(wd) == false) {
					client.CreateDirectory(wd, true);
				}
				client.SetWorkingDirectory(wd);
				//The full name is the local folder !!!
				client.UploadFile(ftpListItem.FullName, ftpListItem.Name, FtpRemoteExists.Overwrite, true, FtpVerify.None);
			}
		}

		public string GetWorkingDirectory() {
			var client = GetClient();
			return client.GetWorkingDirectory();
		}

		public void CreateRemoteFolder(string remoteFolderName) {
			var client = GetClient();
			client.CreateDirectory(remoteFolderName, true);
		}

		public void DeleteRemoteFolder(string folderName) {
			var client = GetClient();
			client.DeleteDirectory(folderName);
			client.SetWorkingDirectory("/");
		}

		public void DeleteRemoteFile(string fileName) {
			var client = GetClient();
			client.DeleteFile(fileName);
		}


		public FtpListItem[] GetRecursiveListing() {
			var client = GetClient();
			var listing = client.GetListing(client.GetWorkingDirectory(), FtpListOption.Recursive);
			return listing;
		}

		public void SetWorkingDirectory(string remotepath) {
			var client = GetClient();
			client.SetWorkingDirectory(remotepath);


		}

		public List<FtpListItem> GetRemoteListViewItems() {
			var client = GetClient();
			List<FtpListItem> listItems = new List<FtpListItem>();

			// get a list of files and directories in the "/htdocs" folder
			foreach (FtpListItem ftpListItem in client.GetListing()) {
				listItems.Add(ftpListItem);
			}

			var returnitems = listItems.OrderByDescending(d => d.Type).ThenBy(f => f.Name).ToList();

			return returnitems;
		}
	}
}