using System;
using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class Hex
	{
		public static string fromString(string _arg1, bool _arg2 = false)
		{
			ByteArray byteArray = new ByteArray();
			byteArray.writeUTFBytes(_arg1);
			return fromArray(byteArray, _arg2);
		}

		public static string toString(string _arg1)
		{
			ByteArray byteArray = toArray(_arg1);
			return byteArray.readUTFBytes((uint)byteArray.length);
		}

		public static ByteArray toArray(string _arg1)
		{
			_arg1 = _arg1.Replace(" ", "").Trim();
			ByteArray byteArray = new ByteArray();
			if ((_arg1.Length & 1) == 1)
			{
				_arg1 = "0" + _arg1;
			}
			for (uint num = 0u; num < _arg1.Length; num += 2)
			{
				byteArray[(int)(num / 2u)] = Convert.ToByte(Convert.ToInt32(_arg1.Substring((int)num, 2), 16));
			}
			return byteArray;
		}

		public static string fromArray(ByteArray array, bool colons = false)
		{
			string text = "";
			for (int i = 0; i < array.length; i++)
			{
				string text2 = ConvertInt(array[i], 16);
				if (text2.Length < 2)
				{
					text2 = "0" + text2;
				}
				text += text2;
				if (colons && i < array.length - 1)
				{
					text += ":";
				}
			}
			return text;
		}

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
	}
}
