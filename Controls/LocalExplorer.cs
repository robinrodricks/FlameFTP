using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FluentFTP;
using FlameFTP.Model;
using FlameFTP.Managers;
using FlameFTP.Formats;
using FlameFTP.Forms;

namespace FlameFTP.Controls {
	public partial class LocalExplorer : UserControl {
		public FtpFileManager Ftphelper;
		private ImageList _treeview1ImageList;
		public TreeNode SelectedNode;

		public LocalExplorer() {
			InitializeComponent();
			_treeview1ImageList = new ImageList();
			treeView1.ImageList = _treeview1ImageList;
			PathLabel.Text = "";
		}

		public void LoadLocalDrives() {
			string[] drives = Directory.GetLogicalDrives();
			foreach (var drive in drives) {
				DriveInfo driveInfo = new DriveInfo(drive);

				if (driveInfo.IsReady == false) {
					continue;
				}

				//Need to add a Node to the Treeview1
				TreeNode driveNode = new TreeNode(drive);
				driveNode.Name = drive;
				driveNode.Text = drive;
				var image = ShellIcon.GetSmallFolderIcon().ToBitmap();
				image.MakeTransparent();
				_treeview1ImageList.Images.Add(image);

				FtpListItem ftpListItem = new FtpListItem();
				ftpListItem.Name = drive;
				ftpListItem.FullName = drive;
				ftpListItem.Type = FtpObjectType.Directory;
				driveNode.Tag = ftpListItem;

				treeView1.Nodes.Add(driveNode);
			}

		}

		public void LoadLocalFilesFromPath(TreeNode selectedNode) {
			string downloadFolder = @"c:\";
			var taginfo = (FtpListItem)selectedNode.Tag;

			if (taginfo.Type == FtpObjectType.Directory) {
				downloadFolder = taginfo.FullName;
			}

			if (taginfo.Type == FtpObjectType.File) {
				downloadFolder = Path.GetDirectoryName(taginfo.FullName);
			}

			List<FtpListItem> foldersListItems = LocalFileManager.GetLocalFoldersListItems(downloadFolder);

			selectedNode.Nodes.Clear();

			foreach (FtpListItem ftpListItem in foldersListItems) {
				//This is never used now as we clear out the ones above
				var existsNode = selectedNode.Nodes.Find(ftpListItem.FullName, false).FirstOrDefault();
				if (existsNode != null) {
					continue;
				}

				TreeNode node = new TreeNode(ftpListItem.Name);
				node.Tag = ftpListItem;
				node.Name = ftpListItem.FullName;

				if (ftpListItem.Type == FtpObjectType.Directory) {
					var image = ShellIcon.GetSmallFolderIcon().ToBitmap();
					image.MakeTransparent();
					_treeview1ImageList.Images.Add(image);
					node.ImageIndex = _treeview1ImageList.Images.Count - 1;
					node.SelectedImageIndex = _treeview1ImageList.Images.Count - 1;
					//We need to populate the right hand panel with a list of files
				}

				selectedNode.Nodes.Add(node);

			}

			//selectedNode.Expand();
			treeView1.SelectedNode = selectedNode;

			listView1.Items.Clear();
			List<FtpListItem> fileListItemsListItems = LocalFileManager.GetLocalFileListItems(downloadFolder, 0);

			if (fileListItemsListItems.Count == 0) {
				return;
			}

			var smallImageList = new ImageList();

			foreach (var ftpListItem in fileListItemsListItems) {
				//IF we want to add the list view items 
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = ftpListItem.Name;
				listViewItem.Name = ftpListItem.Name;
				listViewItem.Tag = ftpListItem;

				var image = ShellIcon.GetSmallIconFromExtension(Path.GetExtension(ftpListItem.Name)).ToBitmap();
				image.MakeTransparent();
				smallImageList.Images.Add(image);
				listViewItem.ImageIndex = smallImageList.Images.Count - 1;
				listView1.Items.Add(listViewItem);
			}

			listView1.SmallImageList = smallImageList;
			listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private void addFolderToolStripMenuItem_Click(object sender, EventArgs e) {
			var selectedNode = treeView1.SelectedNode;
			var localpath = selectedNode.Name;

			var newfolderName = GetNewFolderName();

			if (!String.IsNullOrEmpty(newfolderName)) {
				LocalFileManager.CreateDirectory(Path.Combine(localpath, newfolderName));
				LoadLocalFilesFromPath(selectedNode);
			}
		}

		private string GetNewFolderName() {
			FrmNewDirectory frmNewDirectory = new FrmNewDirectory();
			frmNewDirectory.StartPosition = FormStartPosition.CenterParent;

			var actDialogResult = frmNewDirectory.ShowDialog();

			if (actDialogResult == DialogResult.OK) {
				var newFolderName = frmNewDirectory.textBox1.Text;
				if (!String.IsNullOrEmpty(newFolderName)) {
					//Create the new folder
					return newFolderName;
				}
			}
			return "";
		}

		private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {

			var hitTest = treeView1.HitTest(e.Location);
			if (hitTest.Location == TreeViewHitTestLocations.PlusMinus) {
				//expand collapse clicked
			}

			Cursor = Cursors.WaitCursor;

			SelectedNode = e.Node;

			var sourceTreeNode = e.Node;
			Ftphelper.LocalPath = sourceTreeNode.FullPath;
			PathLabel.Text = sourceTreeNode.Name;

			if (e.Button == MouseButtons.Left) {
				var ftpListItem = (FtpListItem)sourceTreeNode.Tag;
				if (ftpListItem.Type == FtpObjectType.Directory) {
					LoadLocalFilesFromPath(sourceTreeNode);
				}

				if (sourceTreeNode.IsExpanded) {
					sourceTreeNode.Collapse(true);
				}
				else {
					sourceTreeNode.Expand();
				}
			}
			Cursor = Cursors.Default;
		}

		private void removeFolderToolStripMenuItem_Click(object sender, EventArgs e) {
			var fred = treeView1.SelectedNode;
			var localpath = fred.Name;
			var newfolderName = GetNewFolderName();

			if (!String.IsNullOrEmpty(newfolderName)) {
				Directory.Delete(Path.Combine(localpath, newfolderName));
			}
		}

		private void viewFileToolStripMenuItem_Click(object sender, EventArgs e) {

			if (listView1.SelectedItems.Count == 1) {
				var selectedItem = listView1.SelectedItems[0];
				FtpListItem fileInfo = (FtpListItem)selectedItem.Tag;
				if (fileInfo.Type == FtpObjectType.File) {
					Process.Start(fileInfo.FullName);
				}
			}
		}

		private void uploadFileToolStripMenuItem_Click(object sender, EventArgs e) {
			var ftpItemsList = new List<FtpListItem>();
			for (int i = 0; i < listView1.SelectedItems.Count; i++) {
				var selectedItem = listView1.SelectedItems[i];
				if (selectedItem.Name.ToLower().Contains("file")) {
					FtpListItem ftpListItem = (FtpListItem)selectedItem.Tag;
					ftpItemsList.Add(ftpListItem);
				}
			}
			Ftphelper.Uploadfiles(ftpItemsList);


		}

		private void treeView1_DragEnter(object sender, DragEventArgs e) {
			e.Effect = DragDropEffects.Move;
		}

		private void treeView1_DragOver(object sender, DragEventArgs e) {
			e.Effect = e.AllowedEffect;
		}

		private void treeView1_ItemDrag(object sender, ItemDragEventArgs e) {
			DoDragDrop(e.Item, DragDropEffects.Move);
		}

		private void treeView1_DragDrop(object sender, DragEventArgs e) {
			ExplorerDragDropEventArgs dragDropEventArgs = new ExplorerDragDropEventArgs();

			//Get any list view items collection that were dropped
			ListView.SelectedListViewItemCollection listViewItemCollection = (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection));
			dragDropEventArgs.SourceListViewItemCollection = listViewItemCollection;

			dragDropEventArgs.TargetTreeView = treeView1;

			//The node that was dropped
			TreeNode sourceNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
			dragDropEventArgs.SourceTreeNode = sourceNode;

			if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false)) {
				Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
				TreeNode destinationNode = ((TreeView)sender).GetNodeAt(pt);

				dragDropEventArgs.TargetTreeNode = destinationNode;

			}

			TreeViewDragDrop(dragDropEventArgs);

			LoadLocalFilesFromPath(treeView1.SelectedNode);
		}

		private void listView1_DragDrop(object sender, DragEventArgs e) {
			ExplorerDragDropEventArgs dragDropEventArgs = new ExplorerDragDropEventArgs();

			//Get any list view items collection that were dropped
			ListView.SelectedListViewItemCollection listViewItemCollection = (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection));
			dragDropEventArgs.SourceListViewItemCollection = listViewItemCollection;

			dragDropEventArgs.TargetListView = listView1;

			//The node that was dropped
			TreeNode sourceNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
			dragDropEventArgs.SourceTreeNode = sourceNode;

			ListViewDragDrop(dragDropEventArgs);

			//Now update the folder
			LoadLocalFilesFromPath(treeView1.SelectedNode);
		}

		private void listView1_DragEnter(object sender, DragEventArgs e) {
			e.Effect = DragDropEffects.Move;
		}

		private void listView1_DragOver(object sender, DragEventArgs e) {
			e.Effect = e.AllowedEffect;
		}

		private void listView1_ItemDrag(object sender, ItemDragEventArgs e) {
			DoDragDrop(listView1.SelectedItems, DragDropEffects.Move);
		}

		public event ListViewDragDropEventHandler ListViewDragDropReceived;
		public delegate void ListViewDragDropEventHandler(ExplorerDragDropEventArgs e);
		public void ListViewDragDrop(ExplorerDragDropEventArgs listviewDroppedEventArgs) {
			ListViewDragDropEventHandler handler = ListViewDragDropReceived;
			if (handler != null) {
				handler(listviewDroppedEventArgs);
			}
		}

		public event TreeViewDragDropEventHandler TreeViewDragDropReceived;
		public delegate void TreeViewDragDropEventHandler(ExplorerDragDropEventArgs e);
		public void TreeViewDragDrop(ExplorerDragDropEventArgs explorerDragDropEventArgs) {
			TreeViewDragDropEventHandler handler = TreeViewDragDropReceived;
			if (handler != null) {
				handler(explorerDragDropEventArgs);
			}
		}

		//

		public event TreeViewUploadMenuEventHandler TreeViewUploadMenuReceived;
		public delegate void TreeViewUploadMenuEventHandler(ExplorerDragDropEventArgs e);
		public void TreeViewUploadMenu(ExplorerDragDropEventArgs explorerDragDropEventArgs) {
			TreeViewUploadMenuEventHandler handler = TreeViewUploadMenuReceived;
			if (handler != null) {
				handler(explorerDragDropEventArgs);
			}
		}


		//


		private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e) {
			//Need to check if there is a selected item
			if (listView1.SelectedItems.Count == 1) {
				var selectedItem = listView1.SelectedItems[0];

				FtpListItem ftpListItem = (FtpListItem)selectedItem.Tag;
				//var FileinfoList = new List<FtpListItem>();
				//FileinfoList.Add(ftpListItem);
				LocalFileManager.TryToDelete(ftpListItem.FullName);
				LoadLocalFilesFromPath(treeView1.SelectedNode);
				//RemoteFileHelper.DeleteFile(ftpListItem.FullName);
				//RefreshRemoteListView();

			}
		}

		private void uploadFolderToolStripMenuItem_Click(object sender, EventArgs e) {
			ExplorerDragDropEventArgs dragDropEventArgs = new ExplorerDragDropEventArgs();

			dragDropEventArgs.SourceTreeNode = treeView1.SelectedNode;

			dragDropEventArgs.ActionType = ExplorerDragDropEventArgs.ActionEvent.UploadLocalTreeView;

			TreeViewUploadMenu(dragDropEventArgs);

		}
	}
}