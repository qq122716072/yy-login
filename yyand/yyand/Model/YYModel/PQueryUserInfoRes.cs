using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PQueryUserInfoRes : ProtoBase
	{
		public uint topSid;

		public MYHashMap users;

		public uint type;

		public List<uint> leaves;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			topSid = popInt();
			users = popHashMapKIVP<POnlineUser>();
			if (_arg1.bytesAvailable > 0)
			{
				type = popInt();
				leaves = popIntArray();
			}
		}
	}
}
