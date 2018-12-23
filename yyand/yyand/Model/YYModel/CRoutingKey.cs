using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class CRoutingKey : ProtoBase
	{
		public uint m_uRealUri;

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			pushInt(m_uRealUri);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			m_uRealUri = popInt();
		}
	}
}
