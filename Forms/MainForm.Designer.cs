namespace FlameFTP.Forms {
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RibbonMain = new System.Windows.Forms.Ribbon();
			this.ROBtnNewConn = new System.Windows.Forms.RibbonOrbMenuItem();
			this.ROBtnGithub1 = new System.Windows.Forms.RibbonOrbMenuItem();
			this.ROBtnGithub2 = new System.Windows.Forms.RibbonOrbMenuItem();
			this.RibbonTabHome = new System.Windows.Forms.RibbonTab();
			this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
			this.RCmbServerList = new System.Windows.Forms.RibbonComboBox();
			this.RBtnServers = new System.Windows.Forms.RibbonButton();
			this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
			this.RBtnConnect = new System.Windows.Forms.RibbonButton();
			this.RBtnDisconnect = new System.Windows.Forms.RibbonButton();
			this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
			this.RBtnUpload = new System.Windows.Forms.RibbonButton();
			this.RBtnDownload = new System.Windows.Forms.RibbonButton();
			this.RBtnCompare = new System.Windows.Forms.RibbonButton();
			this.RBtnProps = new System.Windows.Forms.RibbonButton();
			this.PanelMain = new System.Windows.Forms.Panel();
			this.contextMenuStrip1.SuspendLayout();
			this.PanelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Location = new System.Drawing.Point(168, 2);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1099, 590);
			this.tabControl1.TabIndex = 2;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.IntegralHeight = false;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(0, 5);
			this.listBox1.Margin = new System.Windows.Forms.Padding(2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(163, 587);
			this.listBox1.TabIndex = 3;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(134, 120);
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// RibbonMain
			// 
			this.RibbonMain.BorderMode = System.Windows.Forms.RibbonWindowMode.NonClientAreaCustomDrawn;
			this.RibbonMain.CaptionBarVisible = false;
			this.RibbonMain.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.RibbonMain.Location = new System.Drawing.Point(0, 0);
			this.RibbonMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.RibbonMain.Minimized = false;
			this.RibbonMain.Name = "RibbonMain";
			// 
			// 
			// 
			this.RibbonMain.OrbDropDown.BorderRoundness = 8;
			this.RibbonMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
			this.RibbonMain.OrbDropDown.MenuItems.Add(this.ROBtnNewConn);
			this.RibbonMain.OrbDropDown.MenuItems.Add(this.ROBtnGithub1);
			this.RibbonMain.OrbDropDown.MenuItems.Add(this.ROBtnGithub2);
			this.RibbonMain.OrbDropDown.Name = "";
			this.RibbonMain.OrbDropDown.Size = new System.Drawing.Size(527, 248);
			this.RibbonMain.OrbDropDown.TabIndex = 0;
			this.RibbonMain.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
			this.RibbonMain.OrbText = "FLAMEFTP";
			this.RibbonMain.RibbonTabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RibbonMain.Size = new System.Drawing.Size(1269, 125);
			this.RibbonMain.TabIndex = 5;
			this.RibbonMain.Tabs.Add(this.RibbonTabHome);
			this.RibbonMain.TabSpacing = 4;
			this.RibbonMain.Text = "ribbon1";
			this.RibbonMain.ThemeColor = System.Windows.Forms.RibbonTheme.Purple;
			// 
			// ROBtnNewConn
			// 
			this.ROBtnNewConn.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
			this.ROBtnNewConn.Image = ((System.Drawing.Image)(resources.GetObject("ROBtnNewConn.Image")));
			this.ROBtnNewConn.LargeImage = ((System.Drawing.Image)(resources.GetObject("ROBtnNewConn.LargeImage")));
			this.ROBtnNewConn.Name = "ROBtnNewConn";
			this.ROBtnNewConn.SmallImage = ((System.Drawing.Image)(resources.GetObject("ROBtnNewConn.SmallImage")));
			this.ROBtnNewConn.Text = "New Connection..";
			this.ROBtnNewConn.Click += new System.EventHandler(this.ROBtnNewConn_Click);
			// 
			// ROBtnGithub1
			// 
			this.ROBtnGithub1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
			this.ROBtnGithub1.Image = ((System.Drawing.Image)(resources.GetObject("ROBtnGithub1.Image")));
			this.ROBtnGithub1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ROBtnGithub1.LargeImage")));
			this.ROBtnGithub1.Name = "ROBtnGithub1";
			this.ROBtnGithub1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ROBtnGithub1.SmallImage")));
			this.ROBtnGithub1.Text = "FlameFTP Github";
			this.ROBtnGithub1.Click += new System.EventHandler(this.ROBtnGithub_Click);
			// 
			// ROBtnGithub2
			// 
			this.ROBtnGithub2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
			this.ROBtnGithub2.Image = ((System.Drawing.Image)(resources.GetObject("ROBtnGithub2.Image")));
			this.ROBtnGithub2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ROBtnGithub2.LargeImage")));
			this.ROBtnGithub2.Name = "ROBtnGithub2";
			this.ROBtnGithub2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ROBtnGithub2.SmallImage")));
			this.ROBtnGithub2.Text = "FluentFTP Github";
			this.ROBtnGithub2.Click += new System.EventHandler(this.ROBtnGithub2_Click);
			// 
			// RibbonTabHome
			// 
			this.RibbonTabHome.Name = "RibbonTabHome";
			this.RibbonTabHome.Panels.Add(this.ribbonPanel3);
			this.RibbonTabHome.Panels.Add(this.ribbonPanel1);
			this.RibbonTabHome.Panels.Add(this.ribbonPanel2);
			this.RibbonTabHome.Text = "Home";
			// 
			// ribbonPanel3
			// 
			this.ribbonPanel3.Items.Add(this.RCmbServerList);
			this.ribbonPanel3.Items.Add(this.RBtnServers);
			this.ribbonPanel3.Name = "ribbonPanel3";
			this.ribbonPanel3.Text = "Server";
			this.ribbonPanel3.ButtonMoreClick += new System.EventHandler(this.ribbonPanel3_ButtonMoreClick);
			// 
			// RCmbServerList
			// 
			this.RCmbServerList.Name = "RCmbServerList";
			this.RCmbServerList.SelectedIndex = -1;
			this.RCmbServerList.Text = "Connect To";
			this.RCmbServerList.TextBoxText = "";
			this.RCmbServerList.TextBoxWidth = 150;
			// 
			// RBtnServers
			// 
			this.RBtnServers.Image = ((System.Drawing.Image)(resources.GetObject("RBtnServers.Image")));
			this.RBtnServers.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnServers.LargeImage")));
			this.RBtnServers.Name = "RBtnServers";
			this.RBtnServers.SmallImage = ((System.Drawing.Image)(resources.GetObject("RBtnServers.SmallImage")));
			this.RBtnServers.Text = "Manage";
			this.RBtnServers.Click += new System.EventHandler(this.BtnProfiles_Click);
			// 
			// ribbonPanel1
			// 
			this.ribbonPanel1.ButtonMoreVisible = false;
			this.ribbonPanel1.Items.Add(this.RBtnConnect);
			this.ribbonPanel1.Items.Add(this.RBtnDisconnect);
			this.ribbonPanel1.Name = "ribbonPanel1";
			this.ribbonPanel1.Text = "Connection";
			// 
			// RBtnConnect
			// 
			this.RBtnConnect.Image = ((System.Drawing.Image)(resources.GetObject("RBtnConnect.Image")));
			this.RBtnConnect.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnConnect.LargeImage")));
			this.RBtnConnect.Name = "RBtnConnect";
			this.RBtnConnect.SmallImage = ((System.Drawing.Image)(resources.GetObject("RBtnConnect.SmallImage")));
			this.RBtnConnect.Text = "Reconnect";
			this.RBtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
			// 
			// RBtnDisconnect
			// 
			this.RBtnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("RBtnDisconnect.Image")));
			this.RBtnDisconnect.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnDisconnect.LargeImage")));
			this.RBtnDisconnect.Name = "RBtnDisconnect";
			this.RBtnDisconnect.SmallImage = ((System.Drawing.Image)(resources.GetObject("RBtnDisconnect.SmallImage")));
			this.RBtnDisconnect.Text = "Disconnect";
			this.RBtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
			// 
			// ribbonPanel2
			// 
			this.ribbonPanel2.ButtonMoreVisible = false;
			this.ribbonPanel2.Items.Add(this.RBtnUpload);
			this.ribbonPanel2.Items.Add(this.RBtnDownload);
			this.ribbonPanel2.Items.Add(this.RBtnCompare);
			this.ribbonPanel2.Items.Add(this.RBtnProps);
			this.ribbonPanel2.Name = "ribbonPanel2";
			this.ribbonPanel2.Text = "Files";
			// 
			// RBtnUpload
			// 
			this.RBtnUpload.Image = ((System.Drawing.Image)(resources.GetObject("RBtnUpload.Image")));
			this.RBtnUpload.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnUpload.LargeImage")));
			this.RBtnUpload.Name = "RBtnUpload";
			this.RBtnUpload.SmallImage = ((System.Drawing.Image)(resources.GetObject("RBtnUpload.SmallImage")));
			this.RBtnUpload.Text = "Upload";
			this.RBtnUpload.Click += new System.EventHandler(this.RBtnUpload_Click);
			// 
			// RBtnDownload
			// 
			this.RBtnDownload.Image = ((System.Drawing.Image)(resources.GetObject("RBtnDownload.Image")));
			this.RBtnDownload.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnDownload.LargeImage")));
			this.RBtnDownload.Name = "RBtnDownload";
			this.RBtnDownload.SmallImage = ((System.Drawing.Image)(resources.GetObject("RBtnDownload.SmallImage")));
			this.RBtnDownload.Text = "Download";
			this.RBtnDownload.Click += new System.EventHandler(this.RBtnDownload_Click);
			// 
			// RBtnCompare
			// 
			this.RBtnCompare.Image = ((System.Drawing.Image)(resources.GetObject("RBtnCompare.Image")));
			this.RBtnCompare.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnCompare.LargeImage")));
			this.RBtnCompare.Name = "RBtnCompare";
			this.RBtnCompare.SmallImage = ((System.Drawing.Image)(resources.GetObject("RBtnCompare.SmallImage")));
			this.RBtnCompare.Text = "Verify";
			this.RBtnCompare.Click += new System.EventHandler(this.RBtnCompare_Click);
			// 
			// RBtnProps
			// 
			this.RBtnProps.Image = ((System.Drawing.Image)(resources.GetObject("RBtnProps.Image")));
			this.RBtnProps.LargeImage = ((System.Drawing.Image)(resources.GetObject("RBtnProps.LargeImage")));
			this.RBtnProps.Name = "RBtnProps";
			this.RBtnProps.SmallImage = ((System.Drawing.Image)(resources.GetObject("RBtnProps.SmallImage")));
			this.RBtnProps.Text = "Properties...";
			this.RBtnProps.Click += new System.EventHandler(this.RBtnProps_Click);
			// 
			// PanelMain
			// 
			this.PanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelMain.Controls.Add(this.tabControl1);
			this.PanelMain.Controls.Add(this.listBox1);
			this.PanelMain.Location = new System.Drawing.Point(0, 131);
			this.PanelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.PanelMain.Name = "PanelMain";
			this.PanelMain.Size = new System.Drawing.Size(1269, 604);
			this.PanelMain.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1269, 738);
			this.Controls.Add(this.PanelMain);
			this.Controls.Add(this.RibbonMain);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "FlameFTP";
			this.contextMenuStrip1.ResumeLayout(false);
			this.PanelMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.Ribbon RibbonMain;
		private System.Windows.Forms.Panel PanelMain;
		private System.Windows.Forms.RibbonTab RibbonTabHome;
		private System.Windows.Forms.RibbonPanel ribbonPanel1;
		private System.Windows.Forms.RibbonButton RBtnServers;
		private System.Windows.Forms.RibbonButton RBtnConnect;
		private System.Windows.Forms.RibbonButton RBtnDisconnect;
		private System.Windows.Forms.RibbonPanel ribbonPanel2;
		private System.Windows.Forms.RibbonOrbMenuItem ROBtnServers;
		private System.Windows.Forms.RibbonOrbMenuItem ROBtnNewConn;
		private System.Windows.Forms.RibbonOrbMenuItem ROBtnGithub1;
		private System.Windows.Forms.RibbonButton RBtnUpload;
		private System.Windows.Forms.RibbonButton RBtnDownload;
		private System.Windows.Forms.RibbonButton RBtnCompare;
		private System.Windows.Forms.RibbonButton RBtnProps;
		private System.Windows.Forms.RibbonPanel ribbonPanel3;
		private System.Windows.Forms.RibbonComboBox RCmbServerList;
		private System.Windows.Forms.RibbonOrbMenuItem ROBtnGithub2;
	}
}