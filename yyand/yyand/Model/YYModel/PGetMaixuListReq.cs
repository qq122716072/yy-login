using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PGetMaixuListReq : ProtoBase
	{
		public uint topSid;

		public uint subSid;

		public uint uid;

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(3854338u);
			pushInt(topSid);
			pushInt(subSid);
			pushInt(uid);
		}
	}
}
