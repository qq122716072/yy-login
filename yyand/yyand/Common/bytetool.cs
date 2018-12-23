using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace ZHANHUO.Common
{
	public class bytetool
	{
		public static string ConvertInt(int num, int toBase)
		{
			string text = "0123456789abcdefghijklmnopqrstuvwxyz";
			if (toBase > text.Length)
			{
				throw new IndexOutOfRangeException();
			}
			List<char> list = new List<char>();
			do
			{
				int index = num % toBase;
				list.Add(text[index]);
				num /= toBase;
			}
			while (num != 0);
			list.Reverse();
			return new string(list.ToArray());
		}

		public static string fromArray(byte[] array, bool colons = false)
		{
			string text = "";
			for (int i = 0; i < array.Length; i++)
			{
				string text2 = ConvertInt(array[i], 16);
				if (text2.Length < 2)
				{
					text2 = "0" + text2;
				}
				text += text2;
				if (colons && i < array.Length - 1)
				{
					text += ":";
				}
			}
			return text;
		}

		public static byte[] strToToHexByte(string hexString)
		{
			hexString = hexString.Replace(" ", "");
			if (hexString.Length % 2 != 0)
			{
				hexString += " ";
			}
			byte[] array = new byte[hexString.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
			}
			return array;
		}

		public static byte[] toArray(string str)
		{
			byte[] array = null;
			using (ByteArray byteArray = new ByteArray())
			{
				str = str.Replace(" ", "").Trim();
				if ((str.Length & 1) == 1)
				{
					str = "0" + str;
				}
				for (uint num = 0u; num < str.Length; num += 2)
				{
					byteArray[(int)(num / 2u)] = Convert.ToByte(Convert.ToInt32(str.Substring((int)num, 2), 16));
				}
				array = byteArray.Buffer;
				byteArray.Dispose();
				return array;
			}
		}

		public static byte[] String2Bytes(string str)
		{
			byte[] array = null;
			using (ByteArray byteArray = new ByteArray())
			{
				byteArray.writeUTFBytes(str);
				array = byteArray.Buffer;
				byteArray.Dispose();
				return array;
			}
		}

		public static byte[] Decompress(byte[] sourceByte, int len)
		{
			MemoryStream memoryStream = new MemoryStream();
			DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, true);
			deflateStream.Write(sourceByte, 0, sourceByte.Length);
			deflateStream.Close();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			return result;
		}
	}
}
