using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using FluentFTP;

namespace FlameFTP.Managers {
	public class LocalFileManager {
		public static List<FtpListItem> GetLocalFoldersListItems(string folderPath) {
			List<FtpListItem> ftpListItems = new List<FtpListItem>();

			string[] dirs = Directory.GetDirectories(folderPath);

			foreach (string dir in dirs) {
				DirectoryInfo directoryInfo = new DirectoryInfo(dir);

				if ((directoryInfo.Attributes & FileAttributes.Hidden) == 0) {
					FtpListItem ftpListItem = new FtpListItem();
					ftpListItem.Name = directoryInfo.Name;
					ftpListItem.FullName = directoryInfo.FullName;
					ftpListItem.Type = FtpObjectType.Directory;
					//ftpListItem.Tag = directoryInfo;
					//ftpListItem.Name = "folder";

					ftpListItems.Add(ftpListItem);
				}
			}

			return ftpListItems;
		}

		public static List<FtpListItem> GetLocalFileListItems(string folderPath, int i) {
			List<FtpListItem> ftpListItems = new List<FtpListItem>();

			string[] filelist;

			if (i == 1) {
				filelist = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

			}
			else {
				filelist = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly);

			}

			foreach (string file in filelist) {
				FileInfo fileInfo = new FileInfo(file);

				if ((fileInfo.Attributes & FileAttributes.Hidden) == 0) {
					FtpListItem ftpListItem = new FtpListItem();
					ftpListItem.Name = fileInfo.Name;
					ftpListItem.FullName = fileInfo.FullName;
					//listViewItem.Tag = fileInfo;
					ftpListItem.Type = FtpObjectType.File;
					ftpListItems.Add(ftpListItem);
				}
			}

			return ftpListItems;


		}

		public static bool TryToDelete(string f) {
			try {
				File.Delete(f);
				return true;
			}
			catch (Exception) {
				return false;
			}
		}

		public static void CreateDirectory(string newFolderName) {
			Directory.CreateDirectory(newFolderName);

		}


	}
}