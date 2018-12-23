using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PGetMaixuListRes : ChannelQueueMar
	{
		public uint topSid;

		public uint subSid;

		public List<uint> choruslist;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			topSid = popInt();
			subSid = popInt();
			choruslist = popIntArray();
		}
	}
}
