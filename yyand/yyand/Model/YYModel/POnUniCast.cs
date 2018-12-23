using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class POnUniCast : ProtoBase
	{
		public const uint LOGIN = 0u;

		public const uint SESSION = 1u;

		public uint type;

		public uint topSid;

		public byte[] msg;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			type = popInt();
			topSid = popInt();
			msg = method_2();
		}
	}
}
