using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class CClientInfo : ProtoBase
	{
		public uint m_uIP;

		public uint m_uPort;

		public uint m_uRouteNum;

		public byte[] m_serverName;

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			pushInt(m_uIP);
			pushShort(m_uPort);
			pushInt(m_uRouteNum);
			pushBytes(m_serverName);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			m_uIP = popInt();
			m_uPort = popShort();
			m_uRouteNum = popInt();
			m_serverName = popBytes();
		}
	}
}
