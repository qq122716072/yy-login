using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class GClass6 : ProtoBase
	{
		public uint serviceType;

		public uint sid;

		public uint uid;

		public byte[] msg;

		public uint uip;

		public uint terminalType;

		public uint statType;

		public uint subsid;

		public MyUInt64 suid;

		public GClass6()
		{
			suid = new MyUInt64(0u, 0u);
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(79960u);
			pushShort(serviceType);
			pushInt(sid);
			pushInt(uid);
			method_1(msg);
			pushInt(uip);
			pushByte(terminalType);
			pushByte(statType);
			pushInt(subsid);
			method_0(suid);
		}
	}
}
