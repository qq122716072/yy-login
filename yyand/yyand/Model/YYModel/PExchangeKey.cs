using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PExchangeKey : ProtoBase
	{
		private byte[] byte_0;

		private byte[] byte_1;

		public PExchangeKey(byte[] _arg1, byte[] _arg2)
		{
			byte_0 = _arg1;
			byte_1 = _arg2;
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(4356u);
			pushBytes(byte_0);
			pushBytes(byte_1);
		}
	}
}
