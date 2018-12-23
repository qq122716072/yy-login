using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PServiceUInfoReq : ProtoBase
	{
		public uint uid;

		public uint sid;

		public List<uint> reqUids;

		public uint ConnectionType;

		public PServiceUInfoReq()
		{
			reqUids = new List<uint>();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(61528u);
			pushInt(uid);
			pushInt(sid);
			pushIntArray(reqUids);
			pushByte(ConnectionType);
		}
	}
}
