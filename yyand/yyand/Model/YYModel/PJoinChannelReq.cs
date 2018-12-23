using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PJoinChannelReq : ProtoBase
	{
		public const uint JOIN_INFO_PASSWD = 1u;

		public const uint JOIN_INFO_LOGIN_MODE = 2u;

		public const uint JOIN_MUTI_MODE = 3u;

		public const uint JOIN_MUTI_MODE_CONTEXT = 4u;

		public uint uid;

		public uint topsid;

		public uint subSid;

		public MYHashMap props;

		public PJoinChannelReq()
		{
			props = new MYHashMap();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(2048258u);
			pushInt(uid);
			pushInt(topsid);
			pushInt(subSid);
			pushHashMapKIVS(props);
		}
	}
}
