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
		public static FtpSettings Settings { get; set; }

		public static void Init() {
			Load();

			if (Settings == null || Settings.Servers == null) {
				Settings = new FtpSettings();
				Settings.Servers = new List<FtpServerProfile>();
				Settings.Servers.Add(new FtpServerProfile());
				Save();
			}

		}

		public static void Save() {
			var profilestring = JsonConvert.SerializeObject(Settings);
			Properties.Settings.Default.Profiles = profilestring;
			Properties.Settings.Default.Save();
			Properties.Settings.Default.Reload();
		}

		public static void Load() {
			if (!string.IsNullOrEmpty(Properties.Settings.Default.Profiles)) {
				Settings = JsonConvert.DeserializeObject<FtpSettings>(Properties.Settings.Default.Profiles);
			}
			else {
				Settings = null;
			}
		}

	}

}