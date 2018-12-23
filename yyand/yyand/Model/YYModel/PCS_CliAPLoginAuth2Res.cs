using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PCS_CliAPLoginAuth2Res : ProtoBase
	{
		public byte[] context;

		public uint rescode;

		public uint ruri;

		public byte[] payLoad;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			context = popBytes();
			rescode = popInt();
			ruri = popInt();
			payLoad = method_2();
		}
	}
}
