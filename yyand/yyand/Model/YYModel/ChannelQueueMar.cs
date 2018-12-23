using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class ChannelQueueMar : ProtoBase
	{
		public bool mute;

		public bool disable;

		public uint ring;

		public uint count;

		public uint validring;

		public List<uint> userlist;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			mute = popBool();
			disable = popBool();
			ring = popInt();
			count = popInt();
			validring = popInt();
			userlist = popIntArray();
		}
	}
}
