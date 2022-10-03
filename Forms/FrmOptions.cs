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
using FlameFTP.Model;

namespace FlameFTP.Forms {
	public partial class FrmOptions : Form {

		public FrmOptions() {
			InitializeComponent();
			Load += FrmOptions_Load;
		}

		private void LoadProfiles() {

			listBox1.DataSource = SettingsManager.ConnectionProfiles.Profiles;

			listBox1.DisplayMember = "Sitename";
		}

		private void FrmOptions_Load(object sender, EventArgs e) {
			comboBoxProtocol.DataSource = Enum.GetValues(typeof(SslProtocols));
			comboBoxEncryption.DataSource = Enum.GetValues(typeof(FtpEncryptionMode));
			comboBoxDataConnection.DataSource = Enum.GetValues(typeof(FtpDataConnectionType));

			LoadProfiles();
		}

		private void button2_Click(object sender, EventArgs e) {
			EditProfile();
			;
		}

		private void button1_Click(object sender, EventArgs e) {
			FrmConnectionProfile frmConnectionProfile = new FrmConnectionProfile();
			frmConnectionProfile.StartPosition = FormStartPosition.CenterParent;
			var result = frmConnectionProfile.ShowDialog();

			if (result == DialogResult.OK) {
				//Create a new Profile
				ConnectionProfile connectionProfile = new ConnectionProfile();
				connectionProfile.Sitename = frmConnectionProfile.textBoxSiteName.Text;
				connectionProfile.HostName = frmConnectionProfile.textBoxHostName.Text;
				connectionProfile.UserName = frmConnectionProfile.textBoxUserName.Text;
				connectionProfile.Password = frmConnectionProfile.textBoxPassword.Text;
				connectionProfile.PortNo = int.Parse(frmConnectionProfile.textBoxPortNo.Text);

				connectionProfile.SslProtocols = (SslProtocols)frmConnectionProfile.comboBoxProtocol.SelectedItem;
				connectionProfile.FtpDataConnectionType = (FtpDataConnectionType)frmConnectionProfile.comboBoxDataConnection.SelectedItem;
				connectionProfile.FtpEncryptionMode = (FtpEncryptionMode)frmConnectionProfile.comboBoxEncryption.SelectedItem;

				ConnectionProfilesList connectionProfilesList = SettingsManager.ConnectionProfiles;

				bool exists = connectionProfilesList.Profiles.Exists(profile => profile.SiteKey == connectionProfile.SiteKey);

				if (!exists) {
					SettingsManager.ConnectionProfiles.Profiles.Add(connectionProfile);
					SettingsManager.UpdateSettings();
					LoadProfiles();

				}
			}

		}

		private void listBox1_Click(object sender, EventArgs e) {
			UpdateProfileContols();

		}

		private void UpdateProfileContols() {
			var connectionProfile = (ConnectionProfile)listBox1.SelectedItem;

			comboBoxProtocol.DataSource = Enum.GetValues(typeof(SslProtocols));
			comboBoxEncryption.DataSource = Enum.GetValues(typeof(FtpEncryptionMode));
			comboBoxDataConnection.DataSource = Enum.GetValues(typeof(FtpDataConnectionType));


			textBoxHostName.Text = connectionProfile.HostName;
			textBoxPassword.Text = connectionProfile.Password;
			textBoxPortNo.Text = connectionProfile.PortNo.ToString();
			textBoxSiteName.Text = connectionProfile.Sitename;
			textBoxUserName.Text = connectionProfile.UserName;

			comboBoxProtocol.SelectedItem = connectionProfile.SslProtocols;

			comboBoxDataConnection.SelectedItem = connectionProfile.FtpDataConnectionType;

			comboBoxEncryption.SelectedItem = connectionProfile.FtpEncryptionMode;

		}

		private void EditProfile() {
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
				SettingsManager.UpdateSettings();
				LoadProfiles();
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			UpdateProfileContols();
		}
	}
}