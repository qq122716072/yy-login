using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class APRouterBase : ProtoBase
	{
		public byte[] m_strFrom;

		public uint m_ururi;

		public uint m_uResCode;

		public byte[] m_strLoad;

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			pushBytes(m_strFrom);
			pushInt(m_ururi);
			pushShort(m_uResCode);
			method_1(m_strLoad);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			m_strFrom = popBytes();
			m_ururi = popInt();
			m_uResCode = popShort();
			m_strLoad = method_2();
		}
	}
}
