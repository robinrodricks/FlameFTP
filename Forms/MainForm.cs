using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;
using FlameFTP.Managers;
using FlameFTP.Controls;
using FlameFTP.Model;
using System.Diagnostics;

namespace FlameFTP.Forms {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
			Load += MainController_Load;
		}

		private void MainController_Load(object sender, EventArgs e) {
			SettingsManager.Init();
			UpdateServerList();
		}

		private void UpdateServerList() {
			RBtnConnectTo.DropDownItems.Clear();
			foreach (var server in SettingsManager.Settings.Servers) {
				RBtnConnectTo.DropDownItems.Add(new RibbonButton { Text = server.ToString(), Tag = server });
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			
		}

		private void connectToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}

		private void NewConnectionTab(FtpServerProfile profile) {

			// Create the new panel and add it to the tab
			var tabpage = new TabPage();
			tabpage.Text = profile.ToString() + "       ";
			tabpage.Name = profile.ToString();
			tabControl1.TabPages.Add(tabpage);

			// add a FlameTab within the TabPage to manage the connection
			FlameTab tab = new FlameTab();
			tab.SuspendLayout();
			tab.Init(profile);
			tab.Dock = DockStyle.Fill;
			tabpage.Controls.Add(tab);
			tab.ResumeLayout();
		}

		private void disconnectToolStripMenuItem_Click(object sender, EventArgs e) {
			/*var profile = (Model.FtpServerProfile)listBox1.SelectedItem;
			var sdsd = tabControl1.Controls[profile.Sitename];
			tabControl1.Controls.Remove(sdsd);*/
		}


		private void BtnProfiles_Click(object sender, EventArgs e) {
			EditServers();
		}

		private void EditServers() {
			ServerForm frmOptions = new ServerForm();
			frmOptions.StartPosition = FormStartPosition.CenterParent;
			frmOptions.ShowDialog();
			UpdateServerList();
		}

		private void BtnConnect_Click(object sender, EventArgs e) {
			
		}

		private void BtnDisconnect_Click(object sender, EventArgs e) {

		}

		private void ROBtnGithub_Click(object sender, EventArgs e) {
			Process.Start(new ProcessStartInfo("https://github.com/robinrodricks/FlameFTP"));
		}
		private void ROBtnGithub2_Click(object sender, EventArgs e) {
			Process.Start(new ProcessStartInfo("https://github.com/robinrodricks/FluentFTP"));
		}

		private void ROBtnNewConn_Click(object sender, EventArgs e) {
			EditServers();
		}

		private void ROBtnServers_Click(object sender, EventArgs e) {
			EditServers();
		}

		private void RBtnUpload_Click(object sender, EventArgs e) {

		}

		private void RBtnDownload_Click(object sender, EventArgs e) {

		}

		private void RBtnCompare_Click(object sender, EventArgs e) {

		}

		private void RBtnProps_Click(object sender, EventArgs e) {

		}

		private void RBtnDelete_Click(object sender, EventArgs e) {

		}
		private void ribbonPanel3_ButtonMoreClick(object sender, EventArgs e) {
			EditServers();
		}

		private void RBtnConnectTo_DropDownItemClicked(object sender, RibbonItemEventArgs e) {
			var profile = ((FtpServerProfile)((RibbonButton)e.Item).Tag);
			NewConnectionTab(profile);
		}

	}
}