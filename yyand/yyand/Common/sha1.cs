using System;
using System.Security.Cryptography;
using System.Text;

namespace ZHANHUO.Common
{
	public class sha1
	{
		public static string hash(string content, Encoding encode)
		{
			try
			{
				SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
				byte[] bytes = encode.GetBytes(content);
				byte[] value = sHA1CryptoServiceProvider.ComputeHash(bytes);
				sHA1CryptoServiceProvider.Dispose();
				return BitConverter.ToString(value).Replace("-", "");
			}
			catch (Exception)
			{
				return "";
			}
		}
	}
}
