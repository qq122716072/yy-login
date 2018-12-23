using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class MyBase64
	{
		public const string version = "1.0.0";

		public static string encode(string param1)
		{
			ByteArray byteArray = new ByteArray();
			byteArray.writeUTFBytes(param1);
			return encodeByteArray(byteArray);
		}

		public static string encodeByteArray(ByteArray param1)
		{
			string text = null;
			List<int> list = null;
			List<int> list2 = null;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			text = "";
			list2 = new List<int>(4);
			param1.position = 0;
			while (param1.bytesAvailable > 0)
			{
				list = new List<int>();
				for (num = 0; num < 3; num++)
				{
					if (param1.bytesAvailable <= 0)
					{
						break;
					}
					list[num] = param1.readUnsignedByte();
				}
				list2[0] = (list[0] & 0xFC) >> 2;
				list2[1] = (((list[0] & 3) << 4) | (list[1] >> 4));
				list2[2] = (((list[1] & 0xF) << 2) | (list[2] >> 6));
				list2[3] = (list[2] & 0x3F);
				for (num2 = list.Count; num2 < 3; num2++)
				{
					list2[num2 + 1] = 64;
				}
				for (num3 = 0; num3 < list2.Count; num3++)
				{
					text += "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=-_".CharAt(list2[num3]);
				}
			}
			return text;
		}

		public static string decode(string param1)
		{
			ByteArray byteArray = decodeToByteArray(param1);
			return byteArray.readUTFBytes((uint)byteArray.length);
		}

		public static ByteArray decodeToByteArray(string param1)
		{
			ByteArray byteArray = null;
			int[] array = null;
			int[] array2 = null;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			byteArray = new ByteArray();
			array = new int[4];
			array2 = new int[3];
			for (num = 0; num < param1.Length; num += 4)
			{
				for (num2 = 0; num2 < 4 && num + num2 < param1.Length; num2++)
				{
					array[num2] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=-_".IndexOf(param1.CharAt(num + num2));
				}
				array2[0] = (array[0] << 2) + ((array[1] & 0x30) >> 4);
				array2[1] = ((array[1] & 0xF) << 4) + ((array[2] & 0x3C) >> 2);
				array2[2] = ((array[2] & 3) << 6) + array[3];
				for (num3 = 0; num3 < array2.Length && array[num3 + 1] != 64; num3++)
				{
					byteArray.writeByte((byte)array2[num3]);
				}
			}
			byteArray.position = 0;
			return byteArray;
		}
	}
}
