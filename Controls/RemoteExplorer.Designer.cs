namespace FlameFTP.Controls {
	partial class RemoteExplorer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteExplorer));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.TreeViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.downloadFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewFrileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.downloadFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ListViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.uplaodFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LabelPath = new System.Windows.Forms.Label();
			this.ParentSplitContainer = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.TreeViewContextMenu.SuspendLayout();
			this.ListViewContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ParentSplitContainer)).BeginInit();
			this.ParentSplitContainer.Panel1.SuspendLayout();
			this.ParentSplitContainer.Panel2.SuspendLayout();
			this.ParentSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.listView1);
			this.splitContainer1.Size = new System.Drawing.Size(1145, 694);
			this.splitContainer1.SplitterDistance = 380;
			this.splitContainer1.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.AllowDrop = true;
			this.treeView1.ContextMenuStrip = this.TreeViewContextMenu;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.ImageIndex = 0;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.Size = new System.Drawing.Size(380, 694);
			this.treeView1.TabIndex = 0;
			this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
			this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
			this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
			this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
			this.treeView1.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView1_DragOver);
			// 
			// TreeViewContextMenu
			// 
			this.TreeViewContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.TreeViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadFilesToolStripMenuItem,
            this.viewFrileToolStripMenuItem,
            this.downloadFolderToolStripMenuItem});
			this.TreeViewContextMenu.Name = "TreeViewContextMenu";
			this.TreeViewContextMenu.Size = new System.Drawing.Size(211, 104);
			// 
			// downloadFilesToolStripMenuItem
			// 
			this.downloadFilesToolStripMenuItem.Name = "downloadFilesToolStripMenuItem";
			this.downloadFilesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.downloadFilesToolStripMenuItem.Text = "Add Folder";
			this.downloadFilesToolStripMenuItem.Click += new System.EventHandler(this.downloadFilesToolStripMenuItem_Click);
			// 
			// viewFrileToolStripMenuItem
			// 
			this.viewFrileToolStripMenuItem.Name = "viewFrileToolStripMenuItem";
			this.viewFrileToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.viewFrileToolStripMenuItem.Text = "Delete Folder";
			this.viewFrileToolStripMenuItem.Click += new System.EventHandler(this.viewFrileToolStripMenuItem_Click);
			// 
			// downloadFolderToolStripMenuItem
			// 
			this.downloadFolderToolStripMenuItem.Name = "downloadFolderToolStripMenuItem";
			this.downloadFolderToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.downloadFolderToolStripMenuItem.Text = "Download Folder";
			this.downloadFolderToolStripMenuItem.Click += new System.EventHandler(this.downloadFolderToolStripMenuItem_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "folder");
			this.imageList1.Images.SetKeyName(1, "document ");
			// 
			// listView1
			// 
			this.listView1.AllowDrop = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.listView1.ContextMenuStrip = this.ListViewContextMenu;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(761, 694);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
			this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
			this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
			this.listView1.DragOver += new System.Windows.Forms.DragEventHandler(this.listView1_DragOver);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Content";
			// 
			// ListViewContextMenu
			// 
			this.ListViewContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ListViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uplaodFileToolStripMenuItem,
            this.deleteFileToolStripMenuItem,
            this.viewFileToolStripMenuItem});
			this.ListViewContextMenu.Name = "ListViewContextMenu";
			this.ListViewContextMenu.Size = new System.Drawing.Size(175, 76);
			// 
			// uplaodFileToolStripMenuItem
			// 
			this.uplaodFileToolStripMenuItem.Name = "uplaodFileToolStripMenuItem";
			this.uplaodFileToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.uplaodFileToolStripMenuItem.Text = "Download File";
			this.uplaodFileToolStripMenuItem.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click);
			// 
			// deleteFileToolStripMenuItem
			// 
			this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
			this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.deleteFileToolStripMenuItem.Text = "Delete File";
			this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
			// 
			// viewFileToolStripMenuItem
			// 
			this.viewFileToolStripMenuItem.Name = "viewFileToolStripMenuItem";
			this.viewFileToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
			this.viewFileToolStripMenuItem.Text = "View File";
			this.viewFileToolStripMenuItem.Click += new System.EventHandler(this.viewFileToolStripMenuItem_Click);
			// 
			// LabelPath
			// 
			this.LabelPath.Location = new System.Drawing.Point(3, 10);
			this.LabelPath.Name = "LabelPath";
			this.LabelPath.Size = new System.Drawing.Size(881, 23);
			this.LabelPath.TabIndex = 0;
			this.LabelPath.Text = "label1";
			// 
			// ParentSplitContainer
			// 
			this.ParentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ParentSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.ParentSplitContainer.Name = "ParentSplitContainer";
			this.ParentSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// ParentSplitContainer.Panel1
			// 
			this.ParentSplitContainer.Panel1.Controls.Add(this.LabelPath);
			// 
			// ParentSplitContainer.Panel2
			// 
			this.ParentSplitContainer.Panel2.Controls.Add(this.splitContainer1);
			this.ParentSplitContainer.Size = new System.Drawing.Size(1145, 738);
			this.ParentSplitContainer.SplitterDistance = 40;
			this.ParentSplitContainer.TabIndex = 2;
			// 
			// RemoteExplorer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ParentSplitContainer);
			this.Name = "RemoteExplorer";
			this.Size = new System.Drawing.Size(1145, 738);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.TreeViewContextMenu.ResumeLayout(false);
			this.ListViewContextMenu.ResumeLayout(false);
			this.ParentSplitContainer.Panel1.ResumeLayout(false);
			this.ParentSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ParentSplitContainer)).EndInit();
			this.ParentSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ContextMenuStrip TreeViewContextMenu;
		private System.Windows.Forms.ToolStripMenuItem downloadFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewFrileToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip ListViewContextMenu;
		private System.Windows.Forms.ToolStripMenuItem uplaodFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem downloadFolderToolStripMenuItem;
		public System.Windows.Forms.Label LabelPath;
		private System.Windows.Forms.SplitContainer ParentSplitContainer;
	}
}
