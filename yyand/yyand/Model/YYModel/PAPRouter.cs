using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PAPRouter : PAPRouterHdrBase
	{
		public const uint USER_INFO_TOP_SID = 1u;

		public const uint USER_INFO_SUB_SID = 2u;

		public const uint USER_INFO_PCINFO = 3u;

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(512011u);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
		}
	}
}
