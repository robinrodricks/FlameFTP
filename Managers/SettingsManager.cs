using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using FlameFTP.Model;
using FlameFTP.Properties;
using FluentFTP;
using Newtonsoft.Json;

namespace FlameFTP.Managers {
	public static class SettingsManager {
		public static ConnectionProfilesList ConnectionProfiles { get; set; }

		static SettingsManager() {
			if (String.IsNullOrEmpty(Settings.Default.Profiles)) {
				ConnectionProfilesList connectionProfilesList2 = new ConnectionProfilesList();
				connectionProfilesList2.Profiles = new List<ConnectionProfile>();
				ConnectionProfile newprofile = new ConnectionProfile() { HostName = "localhost", UserName = "anonymous", PortNo = 21, Sitename = "Localhost", Password = "guest@mydomain.com", FtpEncryptionMode = FtpEncryptionMode.None, FtpDataConnectionType = FtpDataConnectionType.AutoPassive };

				connectionProfilesList2.Profiles.Add(newprofile);

				var profilestring = JsonConvert.SerializeObject(connectionProfilesList2);
				Settings.Default.Profiles = profilestring;
				Settings.Default.Save();
				Settings.Default.Reload();
			}

			var connectionProfilesList = JsonConvert.DeserializeObject<ConnectionProfilesList>(Settings.Default.Profiles);

			ConnectionProfiles = connectionProfilesList;

		}


		public static void UpdateSettings() {
			var profilestring = JsonConvert.SerializeObject(ConnectionProfiles);
			Settings.Default.Profiles = profilestring;
			Settings.Default.Save();
			Settings.Default.Reload();

			var connectionProfilesList = JsonConvert.DeserializeObject<ConnectionProfilesList>(Settings.Default.Profiles);

			ConnectionProfiles = connectionProfilesList;
		}

		public static void UpdateProfile(ConnectionProfile connectionProfile) {
			ConnectionProfile foundProfile = ConnectionProfiles.Profiles.Find(c => c.SiteKey == connectionProfile.SiteKey);
			if (foundProfile != null) {
				ConnectionProfiles.Profiles.Remove(foundProfile);
			}
			ConnectionProfiles.Profiles.Add(connectionProfile);
			UpdateSettings();
		}
	}

}