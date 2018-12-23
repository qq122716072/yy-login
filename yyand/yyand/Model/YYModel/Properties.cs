using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class Properties : ProtoBase
	{
		public MYHashMap props;

		public Properties()
		{
			props = new MYHashMap();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			pushHashMapKSVS(props);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			props = popHashMapKSVS();
		}
	}
}
