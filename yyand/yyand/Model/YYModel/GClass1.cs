using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class GClass1 : ProtoBase
	{
		public uint topSid;

		public List<uint> sidlist;

		public GClass1()
		{
			sidlist = new List<uint>();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(3125250u);
			pushInt(topSid);
			pushIntArray(sidlist);
		}
	}
}
