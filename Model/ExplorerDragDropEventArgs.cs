using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;


namespace FlameFTP.Model {
	public class ExplorerDragDropEventArgs : EventArgs {
		public TreeNode SourceTreeNode { get; set; }

		public ListView.SelectedListViewItemCollection SourceListViewItemCollection { get; set; }

		public TreeNode TargetTreeNode { get; set; }
		public ListView TargetListView { get; set; }
		public TreeView TargetTreeView { get; set; }

		public ActionEvent ActionType { get; set; }

		public enum ActionEvent {
			UploadLocalTreeView,
			UploadLocalListView,
			DownLoadRemoteTreeview,
			DownloadRemoteListView
		}



	}
}