using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PCS_APLoginRes : ProtoBaseEx
	{
		public uint m_uResCode;

		public byte[] m_strContext;

		public uint m_uClientIp;

		public uint m_uClientPort;

		public uint m_compressMode;

		public override void vsunmarshall(ByteArray _arg1)
		{
			base.vsunmarshall(_arg1);
			m_uResCode = popInt();
			m_strContext = popBytes();
			if (_arg1.bytesAvailable > 0)
			{
				m_uClientIp = popInt();
				m_uClientPort = popShort();
			}
			if (_arg1.bytesAvailable > 0)
			{
				m_compressMode = popByte();
			}
		}
	}
}
