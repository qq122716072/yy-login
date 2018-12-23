using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PLeaveChannelReq : ProtoBase
	{
		public uint uid;

		public uint topsid;

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(2049794u);
			pushInt(uid);
			pushInt(topsid);
		}
	}
}
