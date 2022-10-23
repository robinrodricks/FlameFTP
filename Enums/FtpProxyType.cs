using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlameFTP.Enums {
	public enum FtpProxyType: int {
		Socks5 = 1,
		Socks4 = 2,
		Socks4a = 3,
		Http11 = 4,
		UserAtHost = 5,
		BlueCoat = 6,
	}
}
