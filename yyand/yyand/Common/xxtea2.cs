using System;
using System.Text;

namespace ZHANHUO.Common
{
	public class xxtea2
	{
		public static string Encrypt(string source, string key)
		{
			try
			{
				Encoding aSCII = Encoding.ASCII;
				byte[] bytes = aSCII.GetBytes(source);
				byte[] bytes2 = aSCII.GetBytes(key);
				if (bytes.Length != 0)
				{
					return Convert.ToBase64String(smethod_3(smethod_0(smethod_2(bytes, true), smethod_2(bytes2, false)), false));
				}
				return "";
			}
			catch
			{
				return "";
			}
		}

		public static string Decrypt(string source, string key)
		{
			if (source.Length == 0)
			{
				return "";
			}
			Encoding uTF = Encoding.UTF8;
			byte[] object_ = Convert.FromBase64String(source);
			byte[] bytes = uTF.GetBytes(key);
			return base64Decode(uTF.GetString(smethod_3(smethod_1(smethod_2(object_, false), smethod_2(bytes, false)), true)));
		}

		private static uint[] smethod_0(object object_0, Array array_0)
		{
			int num = ((Array)object_0).Length - 1;
			if (num < 1)
			{
				return (uint[])object_0;
			}
			if (array_0.Length < 4)
			{
				uint[] array = new uint[4];
				array_0.CopyTo(array, 0);
				array_0 = array;
			}
			uint num2 = ((uint[])object_0)[num];
			uint num3 = ((uint[])object_0)[0];
			uint num4 = 2654435769u;
			uint num5 = 0u;
			int num6 = 6 + 52 / (num + 1);
			while (num6-- > 0)
			{
				num5 += num4;
				uint num8 = (num5 >> 2) & 3;
				int i;
				for (i = 0; i < num; i++)
				{
					num3 = ((uint[])object_0)[i + 1];
					num2 = (((uint[])object_0)[i] += ((((num2 >> 5) ^ (num3 << 2)) + ((num3 >> 3) ^ (num2 << 4))) ^ ((num5 ^ num3) + (((uint[])array_0)[(i & 3) ^ num8] ^ num2))));
				}
				num3 = ((uint[])object_0)[0];
				num2 = (((uint[])object_0)[num] += ((((num2 >> 5) ^ (num3 << 2)) + ((num3 >> 3) ^ (num2 << 4))) ^ ((num5 ^ num3) + (((uint[])array_0)[(i & 3) ^ num8] ^ num2))));
			}
			return (uint[])object_0;
		}

		private static uint[] smethod_1(object object_0, Array array_0)
		{
			int num = ((Array)object_0).Length - 1;
			if (num < 1)
			{
				return (uint[])object_0;
			}
			if (array_0.Length < 4)
			{
				uint[] array = new uint[4];
				array_0.CopyTo(array, 0);
				array_0 = array;
			}
			uint num2 = ((uint[])object_0)[num];
			uint num3 = ((uint[])object_0)[0];
			uint num4 = 2654435769u;
			for (uint num5 = (uint)((6 + 52 / (num + 1)) * 2654435769L); num5 != 0; num5 -= num4)
			{
				uint num6 = (num5 >> 2) & 3;
				int num7;
				for (num7 = num; num7 > 0; num7--)
				{
					num2 = ((uint[])object_0)[num7 - 1];
					num3 = (((uint[])object_0)[num7] -= ((((num2 >> 5) ^ (num3 << 2)) + ((num3 >> 3) ^ (num2 << 4))) ^ ((num5 ^ num3) + (((uint[])array_0)[(num7 & 3) ^ num6] ^ num2))));
				}
				num2 = ((uint[])object_0)[num];
				num3 = (((uint[])object_0)[0] -= ((((num2 >> 5) ^ (num3 << 2)) + ((num3 >> 3) ^ (num2 << 4))) ^ ((num5 ^ num3) + (((uint[])array_0)[(num7 & 3) ^ num6] ^ num2))));
			}
			return (uint[])object_0;
		}

		private static uint[] smethod_2(byte[] object_0, bool bool_0)
		{
			int num = ((object_0.Length & 3) == 0) ? (object_0.Length >> 2) : ((object_0.Length >> 2) + 1);
			uint[] array;
			if (bool_0)
			{
				array = new uint[num + 1];
				array[num] = (uint)object_0.Length;
			}
			else
			{
				array = new uint[num];
			}
			num = object_0.Length;
			for (int i = 0; i < num; i++)
			{
				array[i >> 2] |= (uint)(object_0[i] << ((i & 3) << 3));
			}
			return array;
		}

		private static byte[] smethod_3(object object_0, bool bool_0)
		{
			int num = (!bool_0) ? (((Array)object_0).Length << 2) : ((int)((uint[])object_0)[((Array)object_0).Length - 1]);
			byte[] array = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = (byte)(((uint[])object_0)[i >> 2] >> ((i & 3) << 3));
			}
			return array;
		}

		public static string base64Decode(string data)
		{
			try
			{
				Encoding uTF = Encoding.UTF8;
				byte[] bytes = Convert.FromBase64String(data);
				return uTF.GetString(bytes);
			}
			catch (Exception ex)
			{
				throw new Exception("Error in base64Decode" + ex.Message);
			}
		}

		public static string base64Encode(string data)
		{
			try
			{
				byte[] array = new byte[data.Length];
				return Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
			}
			catch (Exception ex)
			{
				throw new Exception("Error in base64Encode" + ex.Message);
			}
		}
	}
}
