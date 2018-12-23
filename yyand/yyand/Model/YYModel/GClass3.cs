using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class GClass3 : ProtoBase
	{
		public uint topSid;

		public uint subSid;

		public uint num;

		public uint pos;

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(3126274u);
			pushInt(topSid);
			pushInt(subSid);
			pushInt(num);
			pushInt(pos);
		}
	}
}
