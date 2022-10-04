using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using FlameFTP.Model;
using FluentFTP;

namespace FlameFTP.Managers {
	public class FtpManager {
		private FtpClient Ftp;
		public FtpServerProfile Profile { get; set; }
		public string LocalPath;
		private string _remotePath;

		//     Add a custom listener here to get events every time a message is logged.
		public Action<FtpTraceLevel, string> Logger { get; set; }
		public bool IsConnected { get; private set; }

		public void Init() {
			GetClient();
		}

		public string RemotePath {
			get { return _remotePath; }
			set {
				_remotePath = value;

				var client = GetClient();
				client.SetWorkingDirectory(RemotePath);
			}
		}

		public FtpClient GetClient() {
			try {

				if (Ftp == null) {

					// create client
					Ftp = new FtpClient();

					// add logger
					Ftp.LegacyLogger = Logger;

					// configure client using profile
					Profile.ConfigureClient(Ftp);
				}

				if (Ftp.IsConnected == false) {
					if (Profile.IsAuto) {
						Ftp.AutoConnect();
					}
					else {
						Ftp.Connect();
					}
				}
				IsConnected = true;
				return Ftp;
			}
			catch (Exception ex) {
				Logger(FtpTraceLevel.Error, "Error:    Error connecting to server: " + ex.Message);
				IsConnected = false;
			}
			return null;
		}

		public List<FtpListItem> GetRemoteListViewItems() {
			var client = GetClient();

			if (IsConnected) {

				// get a list of files and directories in the "/htdocs" folder
				List<FtpListItem> listItems = new List<FtpListItem>();
				foreach (FtpListItem ftpListItem in client.GetListing()) {
					listItems.Add(ftpListItem);
				}

				var result = listItems.OrderByDescending(d => d.Type).ThenBy(f => f.Name).ToList();
				return result;
			}

			return new List<FtpListItem>();
		}
		public bool DownloadFile(string localPath, string remotePath) {
			var client = GetClient();
			if (IsConnected) {
				var ok = client.DownloadFile(localPath, remotePath);
				return ok == FtpStatus.Success || ok == FtpStatus.Skipped;
			}
			return false;
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

	}
}