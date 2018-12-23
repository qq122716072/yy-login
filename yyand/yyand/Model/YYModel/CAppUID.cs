using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class CAppUID : ProtoBase
	{
		public uint m_uAppID;

		public MyUInt64 m_uUID;

		public CAppUID()
		{
			m_uUID = new MyUInt64(0u, 0u);
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			pushInt(m_uAppID);
			method_0(m_uUID);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			m_uAppID = popInt();
			m_uUID = popInt64();
		}
	}
}
