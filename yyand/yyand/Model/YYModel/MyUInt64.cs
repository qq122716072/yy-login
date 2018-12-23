using System;
using System.Collections.Generic;
using System.Text;

namespace ZHANHUO.Model.YYModel
{
	public sealed class MyUInt64 : Binary64
	{
		public uint high
		{
			get
			{
				return internalHigh;
			}
			set
			{
				internalHigh = value;
			}
		}

		public MyUInt64(uint _arg1 = 0u, uint _arg2 = 0u)
			: base(_arg1, _arg2)
		{
		}

		public static MyUInt64 smethod_0(string _arg1, uint _arg2 = 0u)
		{
			uint num = 0u;
			uint num2 = 0u;
			if (_arg2 == 0)
			{
				if (_arg1.IndexOf("0x") == 0)
				{
					_arg2 = 16u;
					num2 = 2u;
				}
				else
				{
					_arg2 = 10u;
				}
			}
			if (_arg2 < 2 || _arg2 > 36)
			{
				throw new Exception();
			}
			_arg1 = _arg1.ToLower();
			MyUInt64 myUInt = new MyUInt64(0u, 0u);
			char[] array = _arg1.ToCharArray();
			for (; num2 < _arg1.Length; num2++)
			{
				num = Convert.ToByte(array[num2]);
				if (num >= Convert.ToByte('0') && num <= Convert.ToByte('9'))
				{
					num -= Convert.ToByte('0');
				}
				else
				{
					if (num < Convert.ToByte('a') || num > Convert.ToByte('z'))
					{
						throw new Exception();
					}
					num -= Convert.ToByte('a');
				}
				if (num >= _arg2)
				{
					throw new Exception();
				}
				myUInt.mul(_arg2);
				myUInt.add(num);
			}
			return myUInt;
		}

		public static int comp(MyUInt64 _arg1, MyUInt64 _arg2)
		{
			if (_arg1.high > _arg2.high)
			{
				return 1;
			}
			if (_arg1.high < _arg2.high)
			{
				return -1;
			}
			if (_arg1.low > _arg2.low)
			{
				return 1;
			}
			if (_arg1.low < _arg2.low)
			{
				return -1;
			}
			return 0;
		}

		public void plus(uint _arg1)
		{
			add(_arg1);
		}

		public void increase()
		{
			add(1u);
		}

		public string toString(uint _arg1 = 10u)
		{
			uint num = 0u;
			if (_arg1 < 2 || _arg1 > 36)
			{
				throw new Exception();
			}
			if (low == 0 && high == 0)
			{
				return "0";
			}
			List<string> list = new List<string>();
			MyUInt64 myUInt = new MyUInt64(low, high);
			do
			{
				num = myUInt.div(_arg1);
				list.Add((num < 10) ? "0" : (Convert.ToByte('a') + num).ToString());
			}
			while (myUInt.low != 0 || myUInt.high != 0);
			list.Reverse();
			new StringBuilder();
			return list.ToString();
		}
	}
}
