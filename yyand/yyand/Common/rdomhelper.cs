using System;

namespace ZHANHUO.Common
{
	public class rdomhelper
	{
		private static Random random_0;

		static rdomhelper()
		{
			random_0 = new Random();
		}

		public static int getrandom(int start, int end)
		{
			try
			{
				return random_0.Next(start, end);
			}
			catch
			{
				return new Random().Next(start, end);
			}
		}

		public static string GetRandom()
		{
			try
			{
				return random_0.NextDouble().ToString();
			}
			catch
			{
				return "";
			}
		}
	}
}
