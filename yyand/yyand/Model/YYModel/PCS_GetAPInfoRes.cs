using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PCS_GetAPInfoRes : ProtoBase
	{
		public uint m_uAreaId;

		public uint m_emISPType;

		public uint m_uIp;

		public List<CAPInfo> m_vecApInfo;

		public uint m_uAppId;

		public uint m_uRescode;

		public byte[] m_strExtension;

		public uint m_uApLinkMode;

		public uint m_uApLoginMode;

		public byte[] m_strContext;

		public override void unmarshall(ByteArray _arg1)
		{
			_arg1.position = 0;
			base.unmarshall(_arg1);
			m_uAreaId = popInt();
			m_emISPType = popShort();
			m_uIp = popInt();
			m_vecApInfo = popProtoArray<CAPInfo>();
			m_uAppId = popInt();
			m_uRescode = popInt();
			m_strExtension = popBytes();
			m_uApLinkMode = popInt();
			m_uApLoginMode = popInt();
			m_strContext = popBytes();
		}
	}
}
