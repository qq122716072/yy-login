using System;

namespace Org.Mentalis.Network.ProxySocket
{
	[Serializable]
	public class ProxyException : Exception
	{
		public ProxyException()
			: this("An error occured while talking to the proxy server.")
		{
		}

		public ProxyException(string message)
			: base(message)
		{
		}

		public ProxyException(int int_0)
			: this(Socks5ToString(int_0))
		{
		}

		public static string Socks5ToString(int int_0)
		{
			switch (int_0)
			{
			default:
				return "Unspecified SOCKS error.";
			case 0:
				return "Connection succeeded.";
			case 1:
				return "General SOCKS server failure.";
			case 2:
				return "Connection not allowed by ruleset.";
			case 3:
				return "Network unreachable.";
			case 4:
				return "Host unreachable.";
			case 5:
				return "Connection refused.";
			case 6:
				return "TTL expired.";
			case 7:
				return "Command not supported.";
			case 8:
				return "Address type not supported.";
			}
		}
	}
}
