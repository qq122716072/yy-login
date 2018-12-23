using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class POnlineUser : ProtoBase
	{
		public MYHashMap IntProp_t;

		public MYHashMap StrProp_t;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			IntProp_t = popHashMapKBVI();
			StrProp_t = popHashMapKBVS();
		}
	}
}
