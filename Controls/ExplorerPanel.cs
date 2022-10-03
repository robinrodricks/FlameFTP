using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;
using FlameFTP.Model;
using FlameFTP.Managers;

namespace FlameFTP.Controls {
	public partial class ExplorerPanel : UserControl {
		/// <summary>
		/// This will hold the ftphelper, we can then use the helper to connect remotely,
		/// The helper functions are then passed to the relevant explorer list.
		/// explorerlocal is the local file manager, explorer remote is the ftp site.
		/// </summary>
		/// 
		private FtpFileManager _ftpHelper;
		private ConnectionProfile _profile;


		public string PanelName { get; set; }

		public ExplorerPanel() {
			InitializeComponent();
		}

		public ExplorerPanel(ConnectionProfile profile) : this() {
			_profile = profile;
			PanelName = _profile.Sitename;

			_ftpHelper = new FtpFileManager();
			_ftpHelper.ConnectionProfile = _profile;

			ExplorerLocal.Ftphelper = _ftpHelper;
			ExplorerRemote.Ftphelper = _ftpHelper;

			//Set up event handlers for explorer
			ExplorerLocal.ListViewDragDropReceived += ExplorerLocal_ListViewDragDropReceived;
			ExplorerLocal.TreeViewDragDropReceived += ExplorerLocal_TreeViewDragDropReceived;

			ExplorerLocal.TreeViewUploadMenuReceived += ExplorerLocal_TreeViewUploadMenuReceived;

			//
			ExplorerRemote.ListViewDragDropReceived += ExplorerRemote_ListViewDragDropReceived;
			ExplorerRemote.TreeViewDragDropReceived += ExplorerRemote_TreeViewDragDropReceived;
			ExplorerRemote.TreeViewDownloadMenuReceived += ExplorerRemote_TreeViewDownloadMenuReceived;

			LoadPanelData();

			// Set up logging
			_ftpHelper.GetClient().LegacyLogger = OnClientMessageReceived;
		}

		private void ExplorerRemote_TreeViewDownloadMenuReceived(ExplorerDragDropEventArgs e) {
			//This is simlar to the drop event on the target but it is being raised from the pusher not the receiver
			//So it should work like the local treeview received
			//check the action type if it's set it could be download event from the menu if so the target is the current selected node
			if (e.ActionType == ExplorerDragDropEventArgs.ActionEvent.DownLoadRemoteTreeview) {
				//We had a menu command
				//Therfore e.targetTreeViewNode will be null so we need to make the targetTreeviewNode = to the 
				//local seelcted node
				e.TargetTreeNode = ExplorerLocal.SelectedNode;
			}

			if (ExplorerLocal.SelectedNode.TreeView == e.TargetTreeView) {
				return;
			}

			string downloadPath = "";
			string baseRemotePath = "";

			List<FtpListItem> listItemsToLoad = new List<FtpListItem>();

			//If we had a node dropped
			if (e.SourceTreeNode != null) {
				if (e.SourceTreeNode != null) {
					baseRemotePath = e.SourceTreeNode.Name;
				}

				_ftpHelper.SetWorkingDirectory(e.SourceTreeNode.FullPath);
				var listItems = _ftpHelper.GetRecursiveListing();

				foreach (FtpListItem ftpListItem in listItems) {
					listItemsToLoad.Add(ftpListItem);
				}

			}

			//If we had a listview dropped
			if (e.SourceListViewItemCollection != null) {
				if (e.SourceListViewItemCollection.Count > 0) {
					//We have a list of items
					foreach (var item in e.SourceListViewItemCollection) {
						ListViewItem listViewItem = (ListViewItem)item;
						FtpListItem ftpListItem = (FtpListItem)listViewItem.Tag;
						listItemsToLoad.Add(ftpListItem);
					}
				}
			}


			//What is the drop target
			TreeNode targetNode;
			if (e.TargetTreeNode != null) {
				downloadPath = e.TargetTreeNode.Name;
				targetNode = e.TargetTreeNode;
			}
			else {
				downloadPath = e.TargetTreeView.TopNode.Name;
				targetNode = e.TargetTreeView.TopNode;
			}

			if (listItemsToLoad.Count > 0) {
				_ftpHelper.DownloadFiles(listItemsToLoad, downloadPath, baseRemotePath);
				ExplorerLocal.LoadLocalFilesFromPath(targetNode);
			}
		}

		private void ExplorerLocal_TreeViewUploadMenuReceived(ExplorerDragDropEventArgs e) {
			//This is simlar to the drop event on the target but it is being raised from the pusher not the receiver
			//So it should work like the remote treeview received
			if (e.ActionType == ExplorerDragDropEventArgs.ActionEvent.UploadLocalTreeView) {
				//This was a menu command.
				e.TargetTreeNode = ExplorerRemote.SelectedNode;
			}

			if (e.SourceTreeNode != null) {
				if (ExplorerRemote.SelectedNode.TreeView == e.SourceTreeNode.TreeView) {
					return;
				}
			}


			//What did we drop a node or a list of files ?

			List<FtpListItem> listItemsToLoad = new List<FtpListItem>();

			if (e.SourceTreeNode != null) {
				var listItems = GetLocalNodeFiles(e.SourceTreeNode);
				foreach (FtpListItem ftpListItem in listItems) {
					listItemsToLoad.Add(ftpListItem);
				}

				var bob = e.TargetTreeNode.Name + "/";

				foreach (FtpListItem item in listItemsToLoad) {
					DirectoryInfo pd = Directory.GetParent(e.SourceTreeNode.FullPath);
					var s1 = item.FullName.Replace(pd.FullName, bob);
					item.Name = s1.Replace(@"\", "/");
				}
			}

			if (e.SourceListViewItemCollection != null) {
				if (e.SourceListViewItemCollection.Count > 0) {
					foreach (var item in e.SourceListViewItemCollection) {
						ListViewItem listViewItem = (ListViewItem)item;
						FtpListItem ftpListItem = (FtpListItem)listViewItem.Tag;
						listItemsToLoad.Add(ftpListItem);
					}
				}
			}

			if (e.TargetTreeNode != null) {
				_ftpHelper.SetWorkingDirectory(e.TargetTreeNode.FullPath);
			}

			if (listItemsToLoad.Count > 0) {
				_ftpHelper.Uploadfiles(listItemsToLoad);

				ExplorerRemote.RefreshRemoteListView(e.TargetTreeNode);
			}
		}

		private void ExplorerRemote_TreeViewDragDropReceived(ExplorerDragDropEventArgs e) {
			if (e.ActionType == ExplorerDragDropEventArgs.ActionEvent.UploadLocalTreeView) {
				//This was a menu command.
				e.TargetTreeNode = ExplorerRemote.SelectedNode;
			}

			if (e.SourceTreeNode != null) {
				if (ExplorerRemote.SelectedNode.TreeView == e.SourceTreeNode.TreeView) {
					return;
				}
			}


			//What did we drop a node or a list of files ?

			List<FtpListItem> listItemsToLoad = new List<FtpListItem>();

			if (e.SourceTreeNode != null) {
				var listItems = GetLocalNodeFiles(e.SourceTreeNode);
				foreach (FtpListItem ftpListItem in listItems) {
					listItemsToLoad.Add(ftpListItem);
				}

				//var bob = e.TargetTreeNode.Name;
				var bob = e.TargetTreeNode.Name + "/";

				foreach (FtpListItem item in listItemsToLoad) {
					DirectoryInfo pd = Directory.GetParent(e.SourceTreeNode.FullPath);
					var s1 = item.FullName.Replace(pd.FullName, bob);
					item.Name = s1.Replace(@"\", "/");
				}
			}

			if (e.SourceListViewItemCollection != null) {
				if (e.SourceListViewItemCollection.Count > 0) {
					foreach (var item in e.SourceListViewItemCollection) {
						ListViewItem listViewItem = (ListViewItem)item;
						FtpListItem ftpListItem = (FtpListItem)listViewItem.Tag;
						listItemsToLoad.Add(ftpListItem);
					}
				}
			}

			if (e.TargetTreeNode != null) {
				_ftpHelper.SetWorkingDirectory(e.TargetTreeNode.FullPath);
			}

			if (listItemsToLoad.Count > 0) {
				_ftpHelper.Uploadfiles(listItemsToLoad);

				ExplorerRemote.RefreshRemoteListView(e.TargetTreeNode);
			}
		}

		private void ExplorerLocal_TreeViewDragDropReceived(ExplorerDragDropEventArgs e) {
			//check the action type if it's set it could be download event from the menu if so the target is the current selected node
			if (e.ActionType == ExplorerDragDropEventArgs.ActionEvent.DownLoadRemoteTreeview) {
				//We had a menu command
				//Therfore e.targetTreeViewNode will be null so we need to make the targetTreeviewNode = to the 
				//local seelcted node
				e.TargetTreeNode = ExplorerLocal.SelectedNode;
			}

			if (ExplorerLocal.SelectedNode.TreeView == e.TargetTreeView) {
				return;
			}

			string downloadPath = "";
			string baseRemotePath = "";

			List<FtpListItem> listItemsToLoad = new List<FtpListItem>();

			//If we had a node dropped
			if (e.SourceTreeNode != null) {
				if (e.SourceTreeNode != null) {
					baseRemotePath = e.SourceTreeNode.Name;
				}

				_ftpHelper.SetWorkingDirectory(e.SourceTreeNode.FullPath);
				var listItems = _ftpHelper.GetRecursiveListing();

				foreach (FtpListItem ftpListItem in listItems) {
					listItemsToLoad.Add(ftpListItem);
				}

			}

			//If we had a listview dropped
			if (e.SourceListViewItemCollection != null) {
				if (e.SourceListViewItemCollection.Count > 0) {
					//We have a list of items
					foreach (var item in e.SourceListViewItemCollection) {
						ListViewItem listViewItem = (ListViewItem)item;
						FtpListItem ftpListItem = (FtpListItem)listViewItem.Tag;
						listItemsToLoad.Add(ftpListItem);
					}
				}
			}


			//What is the drop target
			TreeNode targetNode;
			if (e.TargetTreeNode != null) {
				downloadPath = e.TargetTreeNode.Name;
				targetNode = e.TargetTreeNode;
			}
			else {
				downloadPath = e.TargetTreeView.TopNode.Name;
				targetNode = e.TargetTreeView.TopNode;
			}

			if (listItemsToLoad.Count > 0) {
				_ftpHelper.DownloadFiles(listItemsToLoad, downloadPath, baseRemotePath);
				ExplorerLocal.LoadLocalFilesFromPath(targetNode);
			}
		}

		private List<FtpListItem> GetLocalNodeFiles(TreeNode sourceTreeNode) {
			List<FtpListItem> ftpListItems = new List<FtpListItem>();

			var files = LocalFileManager.GetLocalFileListItems(sourceTreeNode.FullPath, 1);
			foreach (FtpListItem ftpListItem in files) {
				ftpListItems.Add(ftpListItem);
			}

			return ftpListItems;
		}

		private void ExplorerRemote_ListViewDragDropReceived(ExplorerDragDropEventArgs e) {
			if (e.SourceTreeNode != null) {
				if (e.SourceTreeNode.TreeView == ExplorerRemote.SelectedNode.TreeView) {
					return;
				}
			}

			List<FtpListItem> listItemsToLoad = new List<FtpListItem>();

			if (e.SourceTreeNode != null) {
				var listItems = GetLocalNodeFiles(e.SourceTreeNode);
				foreach (FtpListItem ftpListItem in listItems) {
					listItemsToLoad.Add(ftpListItem);
				}


				//Lets create a new folder
				var helperRemotePath = _ftpHelper.RemotePath;

				foreach (FtpListItem item in listItemsToLoad) {
					DirectoryInfo pd = Directory.GetParent(e.SourceTreeNode.FullPath);
					var s1 = item.FullName.Replace(pd.FullName, helperRemotePath);
					item.Name = s1.Replace(@"\", "/");
				}
			}

			if (e.SourceListViewItemCollection != null) {
				if (e.SourceListViewItemCollection.Count > 0) {
					foreach (var item in e.SourceListViewItemCollection) {
						ListViewItem listViewItem = (ListViewItem)item;
						FtpListItem ftpListItem = (FtpListItem)listViewItem.Tag;
						listItemsToLoad.Add(ftpListItem);
					}

				}
			}

			if (listItemsToLoad.Count > 0) {
				_ftpHelper.Uploadfiles(listItemsToLoad);

				ExplorerRemote.RefreshRemoteListView(ExplorerRemote.SelectedNode);
			}

		}

		private void ExplorerLocal_ListViewDragDropReceived(ExplorerDragDropEventArgs e) {
			if (e.SourceTreeNode != null) {
				if (e.SourceTreeNode.TreeView == ExplorerLocal.SelectedNode.TreeView) {
					return;
				}
			}

			List<FtpListItem> listItemsToLoad = new List<FtpListItem>();
			string baseRemotePath = _ftpHelper.RemotePath;
			baseRemotePath = baseRemotePath.Replace("/", "");
			baseRemotePath = baseRemotePath.Replace("\\", "/");

			if (e.SourceListViewItemCollection != null) {
				foreach (var item in e.SourceListViewItemCollection) {
					ListViewItem listViewItem = (ListViewItem)item;
					FtpListItem ftpListItem = (FtpListItem)listViewItem.Tag;
					listItemsToLoad.Add(ftpListItem);
				}
			}

			//If we had a node dropped
			if (e.SourceTreeNode != null) {
				if (e.SourceTreeNode != null) {
					baseRemotePath = e.SourceTreeNode.Name;
				}
				var newpath = Path.Combine(_ftpHelper.LocalPath, e.SourceTreeNode.Text);
				LocalFileManager.CreateDirectory(newpath);
				_ftpHelper.LocalPath = newpath;

				_ftpHelper.SetWorkingDirectory(e.SourceTreeNode.FullPath);

				var listItems = _ftpHelper.GetRecursiveListing();

				foreach (FtpListItem ftpListItem in listItems) {
					//Need to create the folder here
					listItemsToLoad.Add(ftpListItem);
				}
			}

			//Now we need to create the local path


			//Use the text property of the node to create a new folder.

			if (listItemsToLoad.Count > 0) {
				_ftpHelper.DownloadFiles(listItemsToLoad, _ftpHelper.LocalPath, baseRemotePath);
			}
		}


		private void LoadPanelData() {
			ExplorerRemote.PopulateInitialRemoteListView();
			ExplorerLocal.LoadLocalDrives();
		}

		private void OnClientMessageReceived(FtpTraceLevel level, string text) {
			string texttoappend = text + System.Environment.NewLine;
			listBox2.Items.Add(texttoappend);

			while (listBox2.Items.Count >= 200) {
				listBox2.Items.RemoveAt(0);

			}

			listBox2.SelectedIndex = listBox2.Items.Count - 1;
		}
	}
}