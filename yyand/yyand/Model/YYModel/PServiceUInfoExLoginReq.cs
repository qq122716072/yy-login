using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PServiceUInfoExLoginReq : ProtoBase
	{
		public uint uid;

		public uint sid;

		public MYHashMap type2ValueMap;

		public byte[] reserved;

		public PServiceUInfoExLoginReq()
		{
			type2ValueMap = new MYHashMap();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(385624u);
			pushInt(uid);
			pushInt(sid);
			pushBytes(reserved);
			pushHashMapKSVS(type2ValueMap);
		}
	}
}
