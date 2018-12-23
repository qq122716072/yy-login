using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ZHANHUO.Common
{
	public class timetool
	{
		[DllImport("kernel32.dll")]
		public static extern uint GetTickCount();

		public static string GetTs()
		{
			return (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds.ToString().Split('.')[0];
		}

		public static string GetTs(DateTime dt)
		{
			return (dt - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds.ToString().Split('.')[0];
		}

		public static string GetTms()
		{
			return (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalMilliseconds.ToString().Split('.')[0];
		}

		public static string getstr(int minitues)
		{
			try
			{
				new StringBuilder();
				int num = minitues / 1440;
				int num2 = (minitues - 1440 * num) / 60;
				int num3 = minitues - 1440 * num - 60 * num2;
				return string.Format("{0} 天 {1}小时 {2}分", num, num2, num3);
			}
			catch
			{
				return "####";
			}
		}
	}
}
