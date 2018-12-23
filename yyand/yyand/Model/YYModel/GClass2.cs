using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class GClass2 : ProtoBase
	{
		public uint topSid;

		public uint totalCount;

		public MYHashMap myhashMap_0;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			topSid = popInt();
			totalCount = popInt();
			myhashMap_0 = popHashMapKIVI();
		}
	}
}
