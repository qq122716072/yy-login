using System.Runtime.InteropServices;

namespace ZHANHUO.Common
{
	public class krbtool
	{
		[DllImport("login.dll")]
		public static extern int Out(byte[] linkd, int linkd_len, byte[] fhzzz, byte[] krbtgt, int krbtgt_len, string user, string pwdhash, int nui);
	}
}
