using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class GClass4 : ProtoBase
	{
		public uint topSid;

		public uint subSid;

		public uint pos;

		public MYHashMap users;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			topSid = popInt();
			subSid = popInt();
			pos = popInt();
			users = popHashMapKIVP<POnlineUser>();
		}
	}
}
