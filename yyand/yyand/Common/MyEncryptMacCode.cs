using System;
using System.Security.Cryptography;
using System.Text;

namespace ZHANHUO.Common
{
	public class MyEncryptMacCode
	{
		private static string string_0;

		public static string GetMD5(string str)
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(str));
			for (int i = 0; i < array.Length; i++)
			{
				byte b = array[i];
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		public static string AesEncryptor(string str)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(str);
			return Convert.ToBase64String(new AesManaged
			{
				Key = Encoding.UTF8.GetBytes(GetMD5(string_0)),
				IV = Encoding.UTF8.GetBytes(GetMD5(string_0).Substring(8, 16)),
				Mode = CipherMode.CBC,
				Padding = PaddingMode.PKCS7
			}.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
		}

		public static string AesDecryptor(string str)
		{
			byte[] array = Convert.FromBase64String(str);
			ICryptoTransform cryptoTransform = new AesManaged
			{
				Key = Encoding.UTF8.GetBytes(GetMD5(string_0)),
				IV = Encoding.UTF8.GetBytes(GetMD5(string_0).Substring(8, 16)),
				Mode = CipherMode.CBC,
				Padding = PaddingMode.PKCS7
			}.CreateDecryptor();
			return Encoding.UTF8.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}

		static MyEncryptMacCode()
		{
			string_0 = "LZQ123LMH4QWER!@#ZSN$!QAZ";
		}
	}
}
