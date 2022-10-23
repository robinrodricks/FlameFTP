using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using FlameFTP.Model;
using FluentFTP;

namespace FlameFTP.Managers {
	public class FtpManager {
		private FtpClient Client;
		public FtpServerProfile Profile { get; set; }
		public string LocalPath;
		private string _remotePath;

		//     Add a custom listener here to get events every time a message is logged.
		public Action<FtpTraceLevel, string> Logger { get; set; }
		public bool IsConnected { get; private set; }
		public string ConnectionError;

		public void Init() {
			GetClient();
		}
		public void Destroy() {
			if (Client != null && Client.IsConnected) {
				try {
					Client.Disconnect();
				}
				catch (Exception ex) {
				}
			}
		}

		public FtpClient GetClient() {
			try {

				if (Client == null) {

					// configure client using profile
					Client = Profile.CreateClient();

					// add logger
					Client.LegacyLogger = Logger;

				}

				if (!Client.IsConnected) {
					if (Profile.IsAuto) {
						Client.AutoConnect();
					}
					else {
						Client.Connect();
					}
				}

				if (!Client.IsConnected || !Client.IsAuthenticated) {
					IsConnected = false;
					ConnectionError = "Unknown error while connecting to server!";
					Logger(FtpTraceLevel.Error, "Error:    " + ConnectionError);
					return null;
				}
				else {
					IsConnected = true;
					ConnectionError = null;
					return Client;
				}
			}
			catch (Exception ex) {
				ConnectionError = "Error connecting to server: " + ex.Message;
				Logger(FtpTraceLevel.Error, "Error:    " + ConnectionError);
				Logger(FtpTraceLevel.Error, "Error:    Exception type: " + ex.GetType().Name);
				IsConnected = false;
			}
			return null;
		}

		public string RemotePath {
			get { return _remotePath; }
			set {

				// connect to the server, only execute if connected
				var client = GetClient();
				if (IsConnected) {

					// all FTP commands must have exceptions handled
					try {

						client.SetWorkingDirectory(RemotePath);

					}
					catch (Exception ex) {
						Logger(FtpTraceLevel.Error, "Error:    Error navigating to directory: " + ex.Message);
						return;
					}
					_remotePath = value;
				}

			}
		}


		public List<FtpListItem> GetRemoteListViewItems() {

			// connect to the server, only execute if connected
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

			// connect to the server, only execute if connected
			var client = GetClient();
			if (IsConnected) {

				// all FTP commands must have exceptions handled
				try {

					var ok = client.DownloadFile(localPath, remotePath);
					return ok == FtpStatus.Success || ok == FtpStatus.Skipped;

				}
				catch (Exception ex) {
					Logger(FtpTraceLevel.Error, "Error:    Error downloading file: " + ex.Message);
				}
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

		public bool DownloadFiles(List<FtpListItem> ftpItemsList, string folderPath, string baseRemotePath) {

			/*try {
				var filetemp = Path.Combine(folderPath, "tempfile.tmp");
				FileStream ewrr = File.Create(filetemp);
				ewrr.Close();
				File.Delete(filetemp);
			}
			catch (Exception e) {
				Console.WriteLine(e);
				return;
			}*/

			// connect to the server, only execute if connected
			var client = GetClient();
			if (IsConnected) {

				// all FTP commands must have exceptions handled
				try {


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

					return true;

				}
				catch (Exception ex) {
					Logger(FtpTraceLevel.Error, "Error:    Error downloading files: " + ex.Message);
				}

			}

			return false;
		}

		public bool UploadFile(string localPath, string remotePath) {

			// connect to the server, only execute if connected
			var client = GetClient();
			if (IsConnected) {

				// all FTP commands must have exceptions handled
				try {

					var ok = client.UploadFile(localPath, remotePath);
					return ok == FtpStatus.Success || ok == FtpStatus.Skipped;

				}
				catch (Exception ex) {
					Logger(FtpTraceLevel.Error, "Error:    Error uploading file: " + ex.Message);
					return false;
				}
			}
			return false;
		}

		public bool UploadFiles(List<FtpListItem> ftpItemsList) {

			// connect to the server, only execute if connected
			var client = GetClient();
			if (IsConnected) {

				// all FTP commands must have exceptions handled
				try {

					foreach (FtpListItem ftpListItem in ftpItemsList) {
						var wd = Path.GetDirectoryName(ftpListItem.Name);
						if (client.DirectoryExists(wd) == false) {
							client.CreateDirectory(wd, true);
						}
						client.SetWorkingDirectory(wd);
						//The full name is the local folder !!!
						client.UploadFile(ftpListItem.FullName, ftpListItem.Name, FtpRemoteExists.Overwrite, true, FtpVerify.None);
					}
					return true;

				}
				catch (Exception ex) {
					Logger(FtpTraceLevel.Error, "Error:    Error uploading files: " + ex.Message);
				}

			}
			return false;
		}

		public string GetWorkingDirectory() {

			// connect to the server, only execute if connected
			var client = GetClient();
			if (IsConnected) {

				// all FTP commands must have exceptions handled
				try {

					return client.GetWorkingDirectory();

				}
				catch (Exception ex) {
					Logger(FtpTraceLevel.Error, "Error:    Error getting the working directory: " + ex.Message);
					return null;
				}
			}
			return null;
		}

		public bool CreateRemoteFolder(string remoteFolderName) {

			// connect to the server, only execute if connected
			var client = GetClient();
			if (IsConnected) {

				// all FTP commands must have exceptions handled
				try {

					client.CreateDirectory(remoteFolderName, true);
					return true;

				}
				catch (Exception ex) {
					Logger(FtpTraceLevel.Error, "Error:    Error creating folder: " + ex.Message);
				}
			}
			return false;
		}

		public bool DeleteRemoteFolder(string folderName) {

			// connect to the server, only execute if connected
			var client = GetClient();
			if (IsConnected) {

				// all FTP commands must have exceptions handled
				try {

					client.DeleteDirectory(folderName);

					// TODO: Navigate to the parent folder, not the root folder
					RemotePath = "/";
					return true;

				}
				catch (Exception ex) {
					Logger(FtpTraceLevel.Error, "Error:    Error deleting folder: " + ex.Message);
				}
			}
			return false;
		}

		public bool DeleteRemoteFile(string fileName) {

			// connect to the server, only execute if connected
			var client = GetClient();
			if (IsConnected) {

				// all FTP commands must have exceptions handled
				try {

					client.DeleteFile(fileName);
					return true;

				}
				catch (Exception ex) {
					Logger(FtpTraceLevel.Error, "Error:    Error deleting file: " + ex.Message);
				}
			}
			return false;
		}


		public FtpListItem[] GetRecursiveListing() {

			// connect to the server, only execute if connected
			var client = GetClient();
			if (IsConnected) {

				// all FTP commands must have exceptions handled
				try {

					var listing = client.GetListing(client.GetWorkingDirectory(), FtpListOption.Recursive);
					return listing;

				}
				catch (Exception ex) {
					Logger(FtpTraceLevel.Error, "Error:    Error getting a recursive file listing: " + ex.Message);
				}
			}
			return new FtpListItem[0];
		}

		public bool SetWorkingDirectory(string remotepath) {

			// connect to the server, only execute if connected
			var client = GetClient();
			if (IsConnected) {

				// all FTP commands must have exceptions handled
				try {

					client.SetWorkingDirectory(remotepath);
					return true;

				}
				catch (Exception ex) {
					Logger(FtpTraceLevel.Error, "Error:    Error setting the working directory: " + ex.Message);
					return false;
				}
			}

			return false;
		}

	}
}