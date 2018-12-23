using System.IO;
using System.Windows.Forms;

namespace ZHANHUO.Common
{
	public class logtool
	{
		public static void delusercache_w(string passport)
		{
			try
			{
				string path = string.Format(Application.StartupPath + "\\WCache\\{0}.txt", passport);
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
			catch
			{
			}
		}

		public static void delusercache_p(string passport)
		{
			try
			{
				string path = string.Format(Application.StartupPath + "\\PCache\\{0}.txt", passport);
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
			catch
			{
			}
		}

		public static void logusercache_w(string passport, string msg)
		{
			try
			{
				loghelper.logcacge(string.Format(Application.StartupPath + "\\WCache\\{0}.txt", passport), msg);
			}
			catch
			{
			}
		}

		public static void logusercache_p(string passport, string msg)
		{
			try
			{
				loghelper.logcacge(string.Format(Application.StartupPath + "\\PCache\\{0}.txt", passport), msg);
			}
			catch
			{
			}
		}

		public static void logips_w(string msg)
		{
			try
			{
				loghelper.logcacge(string.Format(Application.StartupPath + "\\Help\\wips.txt"), msg);
			}
			catch
			{
			}
		}

		public static void logips_p(string msg)
		{
			try
			{
				loghelper.logcacge(string.Format(Application.StartupPath + "\\Help\\pips.txt"), msg);
			}
			catch
			{
			}
		}

		public static void logproxy_http(string msg)
		{
			try
			{
				loghelper.logcacge(string.Format(Application.StartupPath + "\\Help\\remotehttp.txt"), msg);
			}
			catch
			{
			}
		}

		public static void logproxy_s5(string msg)
		{
			try
			{
				loghelper.logcacge(string.Format(Application.StartupPath + "\\Help\\remotespoof.txt"), msg);
			}
			catch
			{
			}
		}

		public static void logauth(string msg)
		{
			try
			{
				loghelper.logcacge(string.Format(Application.StartupPath + "\\Help\\macinfo.txt"), msg);
			}
			catch
			{
			}
		}

		public static void logauthgift(string msg)
		{
			try
			{
				loghelper.logcacge(string.Format(Application.StartupPath + "\\Help\\gmacinfo.txt"), msg);
			}
			catch
			{
			}
		}
	}
}
