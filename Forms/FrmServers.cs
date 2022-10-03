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
using FlameFTP.Enums;

namespace FlameFTP.Forms {
	public partial class FrmServers : Form {

		public FrmServers() {
			InitializeComponent();
			Load += FrmOptions_Load;
		}

		private void ReloadProfiles() {
			LstServers.DisplayMember = "DisplayName";
			LstServers.DataSource = null;
			LstServers.DataSource = SettingsManager.Settings.Servers;
		}

		private void FrmOptions_Load(object sender, EventArgs e) {

			CbProtocol.DataSource = Enum.GetValues(typeof(FtpEncryptionMode));
			CbSecureProtocol.DataSource = Enum.GetValues(typeof(SslProtocols));
			CbEncoding.DataSource = Enum.GetValues(typeof(FtpEncodingType));
			CbDataTrans.DataSource = Enum.GetValues(typeof(FtpDataType));
			CbDataConn.DataSource = Enum.GetValues(typeof(FtpDataConnectionType));

			ReloadProfiles();
		}


		private FtpServerProfile CurProfile;

		private void LoadProfile(FtpServerProfile profile) {

			CurProfile = profile;

			// load profile into UI
			TxtDisplayName.Text = profile.DisplayName;
			TxtHost.Text = profile.Host;
			TxtUser.Text = profile.User;
			TxtPass.Text = profile.Pass;
			NumPort.Value = profile.Port;
			CbAuto.Checked = profile.IsAuto;
			CbProtocol.SelectedItem = profile.Protocol;
			CbSecureProtocol.SelectedItem = profile.SecureProtocol;
			CbEncoding.SelectedItem = profile.Encoding;
			CbDataTrans.SelectedItem = profile.DataTransType;
			CbDataConn.SelectedItem = profile.DataConnType;
		}
		private void SaveToProfile(FtpServerProfile profile) {

			// update profile from UI
			profile.DisplayName = TxtDisplayName.Text;
			profile.Host = TxtHost.Text;
			profile.User = TxtUser.Text;
			profile.Pass = TxtPass.Text;
			profile.Port = Convert.ToInt32(NumPort.Value);
			profile.IsAuto = CbAuto.Checked;
			profile.Protocol = (FtpEncryptionMode)CbProtocol.SelectedItem;
			profile.SecureProtocol = (SslProtocols)CbSecureProtocol.SelectedItem;
			profile.Encoding = (FtpEncodingType)CbEncoding.SelectedItem;
			profile.DataTransType = (FtpDataType)CbDataTrans.SelectedItem;
			profile.DataConnType = (FtpDataConnectionType)CbDataConn.SelectedItem;

			// save settings
			SettingsManager.Save();
		}

		private void LstServers_SelectedIndexChanged(object sender, EventArgs e) {
			if (LstServers.SelectedItem != null) {
				LoadProfile((FtpServerProfile)LstServers.SelectedItem);
				PanelProfile.Enabled = true;
			}
			else {
				PanelProfile.Enabled = false;
			}
		}
		private void BtnNew_Click(object sender, EventArgs e) {
			var newProfile = new FtpServerProfile();
			SettingsManager.Settings.Servers.Add(newProfile);
			ReloadProfiles();
			LstServers.SelectedItem = newProfile;
		}

		private void BtnDelete_Click(object sender, EventArgs e) {
			SettingsManager.Settings.Servers.Remove(CurProfile);
			PanelProfile.Enabled = false;
			ReloadProfiles();
		}

		private void BtnSave_Click(object sender, EventArgs e) {
			if (CurProfile != null) {
				SaveToProfile(CurProfile);
				ReloadProfiles();
			}
		}

		private void CbAuto_CheckedChanged(object sender, EventArgs e) {
			GrpManual.Enabled = !CbAuto.Checked;
		}

	}
}