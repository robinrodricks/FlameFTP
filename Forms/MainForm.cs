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
			LoadConnectionProfiles();
		}

		private void LoadConnectionProfiles() {
			listBox1.DataSource = SettingsManager.ConnectionProfiles.Profiles;
			listBox1.DisplayMember = "Sitename";
		}

		private void button1_Click(object sender, EventArgs e) {
			NewConnectionTab();
		}

		private void connectToolStripMenuItem_Click(object sender, EventArgs e) {
			NewConnectionTab();
		}

		private void NewConnectionTab() {
			var profile = (ConnectionProfile)listBox1.SelectedItem;
			//Create the new panel and add it to the tab
			var tabpage = new TabPage();
			tabpage.Text = profile.Sitename + "       ";
			tabpage.Name = profile.Sitename;

			tabControl1.TabPages.Add(tabpage);

			ExplorerPanel explorerPanel = new ExplorerPanel(profile);

			explorerPanel.Dock = DockStyle.Fill;

			tabpage.Controls.Add(explorerPanel);
		}

		private void disconnectToolStripMenuItem_Click(object sender, EventArgs e) {
			var profile = (ConnectionProfile)listBox1.SelectedItem;
			var sdsd = tabControl1.Controls[profile.Sitename];
			tabControl1.Controls.Remove(sdsd);
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e) {
			var connectionProfile = (ConnectionProfile)listBox1.SelectedItem;
			FrmConnectionProfile frmConnectionProfile = new FrmConnectionProfile();

			frmConnectionProfile.comboBoxProtocol.DataSource = Enum.GetValues(typeof(SslProtocols));
			frmConnectionProfile.comboBoxEncryption.DataSource = Enum.GetValues(typeof(FtpEncryptionMode));
			frmConnectionProfile.comboBoxDataConnection.DataSource = Enum.GetValues(typeof(FtpDataConnectionType));


			frmConnectionProfile.textBoxHostName.Text = connectionProfile.HostName;
			frmConnectionProfile.textBoxPassword.Text = connectionProfile.Password;
			frmConnectionProfile.textBoxPortNo.Text = connectionProfile.PortNo.ToString();
			frmConnectionProfile.textBoxSiteName.Text = connectionProfile.Sitename;
			frmConnectionProfile.textBoxUserName.Text = connectionProfile.UserName;

			frmConnectionProfile.comboBoxProtocol.SelectedItem = connectionProfile.SslProtocols;
			frmConnectionProfile.lblproto.Text = connectionProfile.SslProtocols.ToString();

			frmConnectionProfile.comboBoxDataConnection.SelectedItem = connectionProfile.FtpDataConnectionType;
			frmConnectionProfile.lbldata.Text = connectionProfile.FtpDataConnectionType.ToString();

			frmConnectionProfile.comboBoxEncryption.SelectedItem = connectionProfile.FtpEncryptionMode;
			frmConnectionProfile.lblenc.Text = connectionProfile.FtpEncryptionMode.ToString();

			frmConnectionProfile.StartPosition = FormStartPosition.CenterParent;
			var actionResult = frmConnectionProfile.ShowDialog();
			if (actionResult == DialogResult.OK) {
				connectionProfile.Sitename = frmConnectionProfile.textBoxSiteName.Text;
				connectionProfile.HostName = frmConnectionProfile.textBoxHostName.Text;
				connectionProfile.UserName = frmConnectionProfile.textBoxUserName.Text;
				connectionProfile.Password = frmConnectionProfile.textBoxPassword.Text;
				connectionProfile.PortNo = int.Parse(frmConnectionProfile.textBoxPortNo.Text);
				var bob = (SslProtocols)frmConnectionProfile.comboBoxProtocol.SelectedItem;
				connectionProfile.SslProtocols = bob;

				connectionProfile.FtpDataConnectionType = (FtpDataConnectionType)frmConnectionProfile.comboBoxDataConnection.SelectedItem;
				connectionProfile.FtpEncryptionMode = (FtpEncryptionMode)frmConnectionProfile.comboBoxEncryption.SelectedItem;


				SettingsManager.UpdateProfile(connectionProfile);
			}
			LoadConnectionProfiles();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e) {
			var connectionProfile = new ConnectionProfile();
			connectionProfile.Sitename = "Enter Site Name";
			FrmConnectionProfile frmConnectionProfile = new FrmConnectionProfile();
			frmConnectionProfile.textBoxHostName.Text = connectionProfile.HostName;
			frmConnectionProfile.textBoxPassword.Text = connectionProfile.Password;
			frmConnectionProfile.textBoxPortNo.Text = connectionProfile.PortNo.ToString();
			frmConnectionProfile.textBoxSiteName.Text = connectionProfile.Sitename;
			frmConnectionProfile.textBoxUserName.Text = connectionProfile.UserName;

			frmConnectionProfile.StartPosition = FormStartPosition.CenterParent;
			var actionResult = frmConnectionProfile.ShowDialog();
			if (actionResult == DialogResult.OK) {
				connectionProfile.Sitename = frmConnectionProfile.textBoxSiteName.Text;
				connectionProfile.HostName = frmConnectionProfile.textBoxHostName.Text;
				connectionProfile.UserName = frmConnectionProfile.textBoxUserName.Text;
				connectionProfile.Password = frmConnectionProfile.textBoxPassword.Text;
				connectionProfile.PortNo = int.Parse(frmConnectionProfile.textBoxPortNo.Text);

				connectionProfile.SslProtocols = (SslProtocols)frmConnectionProfile.comboBoxProtocol.SelectedItem;
				connectionProfile.FtpDataConnectionType = (FtpDataConnectionType)frmConnectionProfile.comboBoxDataConnection.SelectedItem;
				connectionProfile.FtpEncryptionMode = (FtpEncryptionMode)frmConnectionProfile.comboBoxEncryption.SelectedItem;


				SettingsManager.UpdateProfile(connectionProfile);
			}
			LoadConnectionProfiles();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
			var profile = (ConnectionProfile)listBox1.SelectedItem;
			SettingsManager.ConnectionProfiles.Profiles.Remove(profile);
			SettingsManager.UpdateSettings();
			LoadConnectionProfiles();
		}


		private void BtnProfiles_Click(object sender, EventArgs e) {
			EditServers();
		}

		private void EditServers() {
			FrmServers frmOptions = new FrmServers();
			frmOptions.StartPosition = FormStartPosition.CenterParent;
			frmOptions.ShowDialog();
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

		private void ribbonPanel3_ButtonMoreClick(object sender, EventArgs e) {
			EditServers();
		}

	}
}