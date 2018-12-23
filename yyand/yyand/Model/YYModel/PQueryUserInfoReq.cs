using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PQueryUserInfoReq : ProtoBase
	{
		public uint topSid;

		public List<uint> uidlist;

		public uint type;

		public PQueryUserInfoReq()
		{
			uidlist = new List<uint>();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(3125762u);
			pushInt(topSid);
			pushIntArray(uidlist);
			pushInt(type);
		}
	}
}
