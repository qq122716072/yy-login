using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PCS_GetAPInfo : ProtoBase
	{
		public MyUInt64 m_uUid;

		public uint m_uAppId;

		public uint m_uRetry;

		public byte[] m_strIMEI;

		public uint m_uSdkVersion;

		public byte[] m_uAppVersion;

		public byte[] m_strClientFrom;

		public byte[] m_strPlatform;

		public List<uint> m_uForbidIp;

		public MYHashMap m_mapApSpecReq;

		public uint m_lcid;

		public uint m_uAppkey;

		public byte[] m_strContext;

		public PCS_GetAPInfo()
		{
			m_uUid = new MyUInt64(0u, 0u);
			m_uForbidIp = new List<uint>();
			m_mapApSpecReq = new MYHashMap();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(29470u);
			method_0(m_uUid);
			pushInt(m_uAppId);
			pushInt(m_uRetry);
			pushBytes(m_strIMEI);
			pushInt(m_uSdkVersion);
			pushBytes(m_uAppVersion);
			pushBytes(m_strClientFrom);
			pushBytes(m_strPlatform);
			pushIntArray(m_uForbidIp);
			pushHashMapKIVS(m_mapApSpecReq);
			pushInt(m_lcid);
			pushInt(m_uAppkey);
			pushBytes(m_strContext);
		}
	}
}
