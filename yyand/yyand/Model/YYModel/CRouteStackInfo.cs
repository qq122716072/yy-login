using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class CRouteStackInfo : ProtoBase
	{
		public List<MyUInt64> m_vecProxyId;

		public List<MyUInt64> m_vecS2SId;

		public CRouteStackInfo()
		{
			m_vecProxyId = new List<MyUInt64>();
			m_vecS2SId = new List<MyUInt64>();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			pushInt64Array(m_vecProxyId);
			pushInt64Array(m_vecS2SId);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			m_vecProxyId = popInt64Array();
			m_vecS2SId = popInt64Array();
		}
	}
}
