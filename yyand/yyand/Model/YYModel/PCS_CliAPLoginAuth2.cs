using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PCS_CliAPLoginAuth2 : ProtoBase
	{
		public byte[] context;

		public uint ruri;

		public byte[] payLoad;

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(779268u);
			pushBytes(context);
			pushInt(ruri);
			method_1(payLoad);
		}
	}
}
