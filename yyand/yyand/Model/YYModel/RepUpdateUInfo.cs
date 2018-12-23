using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class RepUpdateUInfo : Properties
	{
		public uint errcode;

		public byte[] limit_end_time;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			errcode = popInt();
			limit_end_time = popBytes();
		}
	}
}
