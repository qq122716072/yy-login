using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PContextField1 : ProtoBase
	{
		public uint f1;

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			pushInt(f1);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			f1 = popInt();
		}
	}
}
