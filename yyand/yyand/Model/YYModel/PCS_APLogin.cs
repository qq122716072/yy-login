using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PCS_APLogin : LoginAuthInfo
	{
		public uint m_uAppID;

		public MyUInt64 m_uUid;

		public bool m_bRelogin;

		public byte[] m_strTicket;

		public byte[] m_strCookie;

		public byte[] m_strContext;

		public PCS_APLogin()
		{
			m_uUid = new MyUInt64(0u, 0u);
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(775684u);
			pushInt(m_uAppID);
			method_0(m_uUid);
			pushBool(m_bRelogin);
			pushBytes(m_strTicket);
			pushBytes(m_strCookie);
			pushBytes(m_strContext);
		}
	}
}
