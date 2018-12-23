namespace ZHANHUO.Model.YYModel
{
	public class Binary64
	{
		public uint low;

		public uint internalHigh;

		public Binary64(uint _arg1 = 0u, uint _arg2 = 0u)
		{
			low = _arg1;
			internalHigh = _arg2;
		}

		protected uint div(uint _arg1)
		{
			uint num = internalHigh % _arg1;
			uint result = (low % 10u + num * 6) % 10u;
			internalHigh /= _arg1;
			double num2 = ((double)num * 4294967296.0 + (double)low) / (double)_arg1;
			internalHigh = (uint)((double)internalHigh + num2 / 4294967296.0);
			low = (uint)num2;
			return result;
		}

		protected void mul(uint _arg1)
		{
			double num = (double)low * (double)_arg1;
			internalHigh = (uint)(num / 4294967296.0 + (double)internalHigh * (double)_arg1);
			low = (uint)num;
		}

		protected void add(uint _arg1)
		{
			double num = (double)low + (double)_arg1;
			internalHigh = (uint)(num / 4294967296.0 + (double)internalHigh);
			low = (uint)num;
		}

		protected void bitwiseNot()
		{
			low = ~low;
			internalHigh = ~internalHigh;
		}
	}
}
