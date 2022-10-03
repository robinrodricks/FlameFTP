using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Xsl;
using FluentFTP;
using FlameFTP.Model;
using FlameFTP.Managers;
using FlameFTP.Formats;
using FlameFTP.Forms;

namespace FlameFTP.Controls {
	public partial class RemoteExplorer : UserControl
	{
		/// <summary>
		/// This is the control that is going to handle the remote FTP calls.
		/// </summary>
		public FtpHelper Ftphelper;
		private ImageList _treeview2ImageList;
		public TreeNode SelectedNode;


		public RemoteExplorer()
		{
			InitializeComponent();
			_treeview2ImageList = new ImageList();
			treeView1.ImageList = _treeview2ImageList;
			LabelPath.Text = "";
		}

		public void PopulateInitialRemoteListView()
		{
			TreeNode rootNode = new TreeNode();

			if (treeView1.Nodes.Count == 0)
			{
				//Add a new node
				rootNode = new TreeNode("/");
				rootNode.Name = "/";
				rootNode.Text = "/";

				FtpListItem ftpListItem = new FtpListItem();
				ftpListItem.Type = FtpFileSystemObjectType.Directory;
				ftpListItem.FullName = rootNode.Name;
				rootNode.Tag = ftpListItem;
				treeView1.Nodes.Add(rootNode);
			}

			var ftpItemsList = Ftphelper.GetRemoteListViewItems();

			PopulateTreeViewWithItems(ftpItemsList, rootNode);
		}

		private void PopulateTreeViewWithItems(List<FtpListItem> ftpItemsList, TreeNode selectedNode)
		{
			selectedNode.Nodes.Clear();

			if (ftpItemsList.Count == 0)
				return;

			foreach (FtpListItem ftpListItem in ftpItemsList)
			{
				var existsNode = selectedNode.Nodes.Find(ftpListItem.FullName, false).FirstOrDefault();
				if (existsNode != null)
				{
					continue;
				}

				if (ftpListItem.Type == FtpFileSystemObjectType.File)
				{
					continue;
				}

				TreeNode node = new TreeNode(ftpListItem.Name);
				node.Tag = ftpListItem;
				node.Name = ftpListItem.FullName;

				if (ftpListItem.Type == FtpFileSystemObjectType.File)
				{
					var image = ShellIcon.GetSmallIconFromExtension(Path.GetExtension(ftpListItem.FullName)).ToBitmap();
					image.MakeTransparent();
					_treeview2ImageList.Images.Add(image);
					node.ImageIndex = _treeview2ImageList.Images.Count - 1;
					node.SelectedImageIndex = _treeview2ImageList.Images.Count - 1;
				}
				else
				{
					var image = ShellIcon.GetSmallFolderIcon().ToBitmap();
					image.MakeTransparent();
					_treeview2ImageList.Images.Add(image);
					node.ImageIndex = _treeview2ImageList.Images.Count - 1;
					node.SelectedImageIndex = _treeview2ImageList.Images.Count - 1;
				}

				selectedNode.Nodes.Add(node);
			}

			//selectedNode.Expand();
			treeView1.SelectedNode = selectedNode;


		}

		private void uploadFileToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			var fred = listView1.SelectedItems;

			foreach (var selecteditem in fred)
			{
				var listitem = (ListViewItem)selecteditem;

				var ok = Ftphelper.DownloadFile(Path.Combine(Ftphelper.LocalPath, listitem.Text), listitem.Text);
			}
		}

		public void RefreshRemoteListView(TreeNode selectedNode)
		{
			Ftphelper.SetWorkingDirectory(selectedNode.FullPath);

			//This gets the ftp item list from the working folder on the server
			var remoteListViewItems = Ftphelper.GetRemoteListViewItems();

			//Populate the lefthad treeview
			PopulateTreeViewWithItems(remoteListViewItems, selectedNode);

			//Populate the right had list view
			PopulateListViewWithItems(remoteListViewItems, selectedNode);
		}

		public void PopulateListViewWithItems(List<FtpListItem> ftpItemsList, TreeNode selectedNode)
		{
			listView1.Items.Clear();

			if (ftpItemsList.Count == 0)
				return;
			var listViewImageList = new ImageList();

			foreach (FtpListItem ftpListItem in ftpItemsList)
			{

				if (ftpListItem.Type == FtpFileSystemObjectType.Directory)
				{
					continue;
				}

				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Name = ftpListItem.Name;
				listViewItem.Text = ftpListItem.Name;
				listViewItem.Tag = ftpListItem;

				if (ftpListItem.Type == FtpFileSystemObjectType.File)
				{
					var image = ShellIcon.GetSmallIconFromExtension(Path.GetExtension(ftpListItem.FullName)).ToBitmap();
					image.MakeTransparent();
					listViewImageList.Images.Add(image);
					listViewItem.ImageIndex = listViewImageList.Images.Count - 1;
				}
				else
				{//wont get here , due to above if check
					var image = ShellIcon.GetSmallFolderIcon().ToBitmap();
					image.MakeTransparent();
					listViewImageList.Images.Add(image);
				}

				listView1.Items.Add(listViewItem);

			}
			listView1.SmallImageList = listViewImageList;
			listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			SelectedNode = e.Node;

			var sourceTreeNode = e.Node;
			Ftphelper.RemotePath = sourceTreeNode.FullPath;
			LabelPath.Text = sourceTreeNode.Name;

			if (e.Button == MouseButtons.Left)
			{
				var ftpListItem = (FtpListItem)sourceTreeNode.Tag;
				//Is only going to be a directory
				if (ftpListItem.Type == FtpFileSystemObjectType.Directory)
				{
					RefreshRemoteListView(sourceTreeNode);
				}
				if (sourceTreeNode.IsExpanded)
				{
					sourceTreeNode.Collapse(true);
					//Cursor = Cursors.Default;
					//return;
				}
				else
				{
					sourceTreeNode.Expand();
				}
			}
			Cursor = Cursors.Default;
		}

		private void treeView1_DragDrop(object sender, DragEventArgs e)
		{
			ExplorerDragDropEventArgs dragDropEventArgs = new ExplorerDragDropEventArgs();

			//Get any list view items collection that were dropped
			ListView.SelectedListViewItemCollection listViewItemCollection = (ListView.SelectedListViewItemCollection)e.Data.GetData(typeof(ListView.SelectedListViewItemCollection));
			dragDropEventArgs.SourceListViewItemCollection = listViewItemCollection;

			dragDropEventArgs.TargetTreeView = treeView1;

			//The node that was dropped
			TreeNode sourceNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
			dragDropEventArgs.SourceTreeNode = sourceNode;

			if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
			{
				Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
				TreeNode destinationNode = ((TreeView)sender).GetNodeAt(pt);

				dragDropEventArgs.TargetTreeNode = destinationNode;

			}

			TreeViewDragDrop(dragDropEventArgs);

			//Now update the folder
			RefreshRemoteListView(treeView1.SelectedNode);

		}

		private void treeView1_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void treeView1_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = e.AllowedEffect;
		}

		private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
		{
			DoDragDrop(e.Item, DragDropEffects.Move);
		}

		private void listView1_DragDrop(object sender, DragEventArgs e)
		{
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
			RefreshRemoteListView(treeView1.SelectedNode);


		}

		private void listView1_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void listView1_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = e.AllowedEffect;
		}

		private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
		{
			DoDragDrop(listView1.SelectedItems, DragDropEffects.Move);
		}

		public event LocalExplorer.ListViewDragDropEventHandler ListViewDragDropReceived;
		public delegate void ListViewDragDropEventHandler(ExplorerDragDropEventArgs e);
		public void ListViewDragDrop(ExplorerDragDropEventArgs dragDropEventArgs)
		{

			LocalExplorer.ListViewDragDropEventHandler handler = ListViewDragDropReceived;
			if (handler != null)
			{
				handler(dragDropEventArgs);
			}
		}

		public event LocalExplorer.TreeViewDragDropEventHandler TreeViewDragDropReceived;
		public delegate void TreeViewDragDropEventHandler(ExplorerDragDropEventArgs e);
		public void TreeViewDragDrop(ExplorerDragDropEventArgs dragDropEventArgs)
		{
			LocalExplorer.TreeViewDragDropEventHandler handler = TreeViewDragDropReceived;
			if (handler != null)
			{
				handler(dragDropEventArgs);
			}
		}


		public event TreeViewUploadMenuEventHandler TreeViewDownloadMenuReceived;
		public delegate void TreeViewUploadMenuEventHandler(ExplorerDragDropEventArgs e);
		public void TreeViewDownloadMenu(ExplorerDragDropEventArgs explorerDragDropEventArgs)
		{
			TreeViewUploadMenuEventHandler handler = TreeViewDownloadMenuReceived;
			if (handler != null)
			{
				handler(explorerDragDropEventArgs);
			}
		}

		private void downloadFilesToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			//Create a remote directory
			var newfolderName = GetNewFolderName();
			if (!string.IsNullOrEmpty(newfolderName))
			{
				Ftphelper.CreateRemoteFolder(newfolderName);
				RefreshRemoteListView(treeView1.SelectedNode);
			}
		}

		private static string GetNewFolderName()
		{
			FrmNewDirectory frmNewDirectory = new FrmNewDirectory();
			frmNewDirectory.StartPosition = FormStartPosition.CenterParent;

			var actDialogResult = frmNewDirectory.ShowDialog();

			if (actDialogResult == DialogResult.OK)
			{
				var newFolderName = frmNewDirectory.textBox1.Text;
				if (!string.IsNullOrEmpty(newFolderName))
				{
					//Create the new folder
					return newFolderName;
				}
			}
			return "";
		}

		private void viewFrileToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			string remoteFolder = Ftphelper.GetWorkingDirectory();
			var confrimstr = string.Format("Are you sure to delete the folder {0}  and subdirectories ??", remoteFolder);

			var confirmResult = MessageBox.Show(confrimstr,
				"Confirm Folder Delete!!",
				MessageBoxButtons.YesNo);

			if (confirmResult == DialogResult.Yes)
			{
				// If 'Yes', do something here.
				Ftphelper.DeleteRemoteFolder(Ftphelper.GetWorkingDirectory());
				Ftphelper.SetWorkingDirectory("/");
				RefreshRemoteListView(treeView1.TopNode);
			}
		}

		private void viewFileToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (listView1.SelectedItems.Count == 1)
			{
				var selectedItem = listView1.SelectedItems[0];
				FtpListItem ftpListItem = (FtpListItem)selectedItem.Tag;
				FileInfo fileInfo = new FileInfo(ftpListItem.FullName);

				var FileinfoList = new List<FileInfo>();
				FileinfoList.Add(fileInfo);
				//Path.GetTempFileName();
				var tempfile = Path.Combine(Path.GetTempPath(), fileInfo.Name);

				if (Ftphelper.DownloadFile(tempfile, ftpListItem.FullName))
				{
					System.Diagnostics.Process.Start(tempfile);
				}

			}
		}

		private void deleteFileToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			//Need to check if there is a selected item
			if (listView1.SelectedItems.Count == 1)
			{
				var selectedItem = listView1.SelectedItems[0];

				FtpListItem ftpListItem = (FtpListItem)selectedItem.Tag;
				//var FileinfoList = new List<FtpListItem>();
				//FileinfoList.Add(ftpListItem);
				Ftphelper.DeleteRemoteFile(ftpListItem.FullName);
				RefreshRemoteListView(treeView1.SelectedNode);

			}
		}

		private void downloadFolderToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			ExplorerDragDropEventArgs dragDropEventArgs = new ExplorerDragDropEventArgs();

			//The node that was dropped
			
			dragDropEventArgs.SourceTreeNode = treeView1.SelectedNode;
			dragDropEventArgs.ActionType= ExplorerDragDropEventArgs.ActionEvent.DownLoadRemoteTreeview;

			TreeViewDownloadMenu(dragDropEventArgs);
			

			
		}
	}
}
