using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlameFTP.Controls {
	partial class LocalExplorer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalExplorer));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.TreeViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uploadFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ListViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.UploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ParentContainer = new System.Windows.Forms.SplitContainer();
			this.PathLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.TreeViewContextMenu.SuspendLayout();
			this.ListViewContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ParentContainer)).BeginInit();
			this.ParentContainer.Panel1.SuspendLayout();
			this.ParentContainer.Panel2.SuspendLayout();
			this.ParentContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.listView1);
			this.splitContainer1.Size = new System.Drawing.Size(1002, 652);
			this.splitContainer1.SplitterDistance = 332;
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
			this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.Size = new System.Drawing.Size(332, 652);
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
            this.addFolderToolStripMenuItem,
            this.removeFolderToolStripMenuItem,
            this.uploadFolderToolStripMenuItem});
			this.TreeViewContextMenu.Name = "TreeViewContextMenu";
			this.TreeViewContextMenu.Size = new System.Drawing.Size(154, 70);
			// 
			// addFolderToolStripMenuItem
			// 
			this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
			this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.addFolderToolStripMenuItem.Text = "Add Folder";
			this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
			// 
			// removeFolderToolStripMenuItem
			// 
			this.removeFolderToolStripMenuItem.Name = "removeFolderToolStripMenuItem";
			this.removeFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.removeFolderToolStripMenuItem.Text = "Remove Folder";
			this.removeFolderToolStripMenuItem.Click += new System.EventHandler(this.removeFolderToolStripMenuItem_Click);
			// 
			// uploadFolderToolStripMenuItem
			// 
			this.uploadFolderToolStripMenuItem.Name = "uploadFolderToolStripMenuItem";
			this.uploadFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.uploadFolderToolStripMenuItem.Text = "Upload Folder";
			this.uploadFolderToolStripMenuItem.Click += new System.EventHandler(this.uploadFolderToolStripMenuItem_Click);
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
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(666, 652);
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
            this.UploadFileToolStripMenuItem,
            this.viewFileToolStripMenuItem,
            this.deleteFileToolStripMenuItem});
			this.ListViewContextMenu.Name = "ListViewContextMenu";
			this.ListViewContextMenu.Size = new System.Drawing.Size(134, 70);
			// 
			// UploadFileToolStripMenuItem
			// 
			this.UploadFileToolStripMenuItem.Name = "UploadFileToolStripMenuItem";
			this.UploadFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.UploadFileToolStripMenuItem.Text = "Upload File";
			this.UploadFileToolStripMenuItem.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click);
			// 
			// viewFileToolStripMenuItem
			// 
			this.viewFileToolStripMenuItem.Name = "viewFileToolStripMenuItem";
			this.viewFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.viewFileToolStripMenuItem.Text = "View File";
			this.viewFileToolStripMenuItem.Click += new System.EventHandler(this.viewFileToolStripMenuItem_Click);
			// 
			// deleteFileToolStripMenuItem
			// 
			this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
			this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.deleteFileToolStripMenuItem.Text = "Delete File";
			this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
			// 
			// ParentContainer
			// 
			this.ParentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ParentContainer.Location = new System.Drawing.Point(0, 0);
			this.ParentContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ParentContainer.Name = "ParentContainer";
			this.ParentContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// ParentContainer.Panel1
			// 
			this.ParentContainer.Panel1.Controls.Add(this.PathLabel);
			// 
			// ParentContainer.Panel2
			// 
			this.ParentContainer.Panel2.Controls.Add(this.splitContainer1);
			this.ParentContainer.Size = new System.Drawing.Size(1002, 692);
			this.ParentContainer.SplitterDistance = 37;
			this.ParentContainer.SplitterWidth = 3;
			this.ParentContainer.TabIndex = 2;
			// 
			// PathLabel
			// 
			this.PathLabel.Location = new System.Drawing.Point(2, 9);
			this.PathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PathLabel.Name = "PathLabel";
			this.PathLabel.Size = new System.Drawing.Size(771, 22);
			this.PathLabel.TabIndex = 0;
			this.PathLabel.Text = "label1";
			// 
			// LocalExplorer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ParentContainer);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "LocalExplorer";
			this.Size = new System.Drawing.Size(1002, 692);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.TreeViewContextMenu.ResumeLayout(false);
			this.ListViewContextMenu.ResumeLayout(false);
			this.ParentContainer.Panel1.ResumeLayout(false);
			this.ParentContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ParentContainer)).EndInit();
			this.ParentContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private SplitContainer splitContainer1;
		private TreeView treeView1;
		private ListView listView1;
		private ImageList imageList1;
		private ColumnHeader columnHeader1;
		private ContextMenuStrip TreeViewContextMenu;
		private ContextMenuStrip ListViewContextMenu;
		private ToolStripMenuItem addFolderToolStripMenuItem;
		private ToolStripMenuItem removeFolderToolStripMenuItem;
		private ToolStripMenuItem UploadFileToolStripMenuItem;
		private ToolStripMenuItem viewFileToolStripMenuItem;
		private ToolStripMenuItem deleteFileToolStripMenuItem;
		private ToolStripMenuItem uploadFolderToolStripMenuItem;
		private SplitContainer ParentContainer;
		public Label PathLabel;
	}
}
