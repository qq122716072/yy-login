using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class CAPInfo : ProtoBase
	{
		public uint m_uGrpId;

		public byte[] m_strIp;

		public List<uint> m_vecPort;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			m_strIp = popBytes();
			m_uGrpId = popInt();
			m_vecPort = popShortArray();
		}
	}
}
