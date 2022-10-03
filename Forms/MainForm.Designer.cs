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
			this.PanelMain = new System.Windows.Forms.Panel();
			this.RibbonTabHome = new System.Windows.Forms.RibbonTab();
			this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
			this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
			this.BtnProfiles = new System.Windows.Forms.RibbonButton();
			this.BtnConnect = new System.Windows.Forms.RibbonButton();
			this.BtnDisconnect = new System.Windows.Forms.RibbonButton();
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
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(0, 5);
			this.listBox1.Margin = new System.Windows.Forms.Padding(2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(163, 559);
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
			this.RibbonMain.OrbDropDown.Name = "";
			this.RibbonMain.OrbDropDown.Size = new System.Drawing.Size(527, 447);
			this.RibbonMain.OrbDropDown.TabIndex = 0;
			this.RibbonMain.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
			this.RibbonMain.OrbVisible = false;
			this.RibbonMain.RibbonTabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RibbonMain.Size = new System.Drawing.Size(1269, 125);
			this.RibbonMain.TabIndex = 5;
			this.RibbonMain.Tabs.Add(this.RibbonTabHome);
			this.RibbonMain.TabSpacing = 3;
			this.RibbonMain.Text = "ribbon1";
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
			// RibbonTabHome
			// 
			this.RibbonTabHome.Name = "RibbonTabHome";
			this.RibbonTabHome.Panels.Add(this.ribbonPanel1);
			this.RibbonTabHome.Panels.Add(this.ribbonPanel2);
			this.RibbonTabHome.Text = "Home";
			// 
			// ribbonPanel1
			// 
			this.ribbonPanel1.Items.Add(this.BtnProfiles);
			this.ribbonPanel1.Items.Add(this.BtnConnect);
			this.ribbonPanel1.Items.Add(this.BtnDisconnect);
			this.ribbonPanel1.Name = "ribbonPanel1";
			this.ribbonPanel1.Text = "Connection";
			// 
			// ribbonPanel2
			// 
			this.ribbonPanel2.Name = "ribbonPanel2";
			this.ribbonPanel2.Text = "Files";
			// 
			// BtnProfiles
			// 
			this.BtnProfiles.Image = ((System.Drawing.Image)(resources.GetObject("BtnProfiles.Image")));
			this.BtnProfiles.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnProfiles.LargeImage")));
			this.BtnProfiles.Name = "BtnProfiles";
			this.BtnProfiles.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnProfiles.SmallImage")));
			this.BtnProfiles.Text = "Profiles";
			this.BtnProfiles.Click += new System.EventHandler(this.BtnProfiles_Click);
			// 
			// BtnConnect
			// 
			this.BtnConnect.Image = ((System.Drawing.Image)(resources.GetObject("BtnConnect.Image")));
			this.BtnConnect.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnConnect.LargeImage")));
			this.BtnConnect.Name = "BtnConnect";
			this.BtnConnect.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnConnect.SmallImage")));
			this.BtnConnect.Text = "Connect";
			this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
			// 
			// BtnDisconnect
			// 
			this.BtnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("BtnDisconnect.Image")));
			this.BtnDisconnect.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDisconnect.LargeImage")));
			this.BtnDisconnect.Name = "BtnDisconnect";
			this.BtnDisconnect.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnDisconnect.SmallImage")));
			this.BtnDisconnect.Text = "Disconnect";
			this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
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
		private System.Windows.Forms.RibbonButton BtnProfiles;
		private System.Windows.Forms.RibbonButton BtnConnect;
		private System.Windows.Forms.RibbonButton BtnDisconnect;
		private System.Windows.Forms.RibbonPanel ribbonPanel2;
	}
}