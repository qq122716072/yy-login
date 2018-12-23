using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PAPRouterHdrBase : APRouterBase
	{
		public PAPRouterHeaders m_objAPHdr;

		public PAPRouterHdrBase()
		{
			m_objAPHdr = new PAPRouterHeaders();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			pushProto(m_objAPHdr);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			m_objAPHdr = popProto<PAPRouterHeaders>();
		}
	}
}
