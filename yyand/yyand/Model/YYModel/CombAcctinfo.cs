using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class CombAcctinfo : ProtoBase
	{
		public byte[] acctinfo;

		public byte[] appid_type;

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			pushBytes(acctinfo);
			pushBytes(appid_type);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			acctinfo = popBytes();
			appid_type = popBytes();
		}
	}
}
