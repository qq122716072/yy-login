using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class GClass5 : ProtoBase
	{
		public byte[] context;

		public uint versionNum;

		public byte[] pcInfo;

		public byte[] macAddr;

		public uint clientFrom;

		public byte[] clientExtension;

		public byte[] bizName;

		public byte[] antiCode;

		public MyUInt64 terminalType;

		public uint lcid;

		public byte[] versionStr;

		public uint _subsid;

		public byte[] _pic_code;

		public byte[] _session_data;

		public GClass5()
		{
			terminalType = new MyUInt64(0u, 0u);
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(19822u);
			pushBytes(context);
			pushInt(versionNum);
			pushBytes(pcInfo);
			pushBytes(macAddr);
			pushInt(clientFrom);
			pushBytes(clientExtension);
			pushBytes(bizName);
			pushBytes(antiCode);
			method_0(terminalType);
			pushInt(lcid);
			pushBytes(versionStr);
			pushInt(_subsid);
			pushBytes(_pic_code);
			pushBytes(_session_data);
		}
	}
}
