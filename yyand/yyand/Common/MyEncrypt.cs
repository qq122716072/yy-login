using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ZHANHUO.Common
{
	public class MyEncrypt
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

		public static string Encrypt(string str)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] bytes2 = Encoding.Unicode.GetBytes(str);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
				cryptoStream.Write(bytes2, 0, bytes2.Length);
				cryptoStream.FlushFinalBlock();
				return Convert.ToBase64String(memoryStream.ToArray());
			}
		}

		public static string Decrypt(string str)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = Convert.FromBase64String(str);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Write))
				{
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.FlushFinalBlock();
					return Encoding.Unicode.GetString(memoryStream.ToArray());
				}
			}
		}

		static MyEncrypt()
		{
			string_0 = "1234QWER!@#$!QAZ";
		}
	}
}
