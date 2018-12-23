using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class CCompressionInfo : ProtoBase
	{
		public uint m_uCodec;

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			pushInt(m_uCodec);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			m_uCodec = popInt();
		}
	}
}
