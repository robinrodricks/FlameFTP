using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlameFTP.Model {
	public class FtpClientEventArgs : EventArgs {
		public string FtpEventMessage { get; set; }
	}
}