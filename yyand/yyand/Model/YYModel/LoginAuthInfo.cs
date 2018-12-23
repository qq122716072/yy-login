using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class LoginAuthInfo : ProtoBaseEx
	{
		public byte[] m_strAccount;

		public byte[] m_strPassword;

		public uint m_uCliType;

		public uint m_uCliVer;

		public byte[] m_strCliVer;

		public uint m_uCliLcid;

		public byte[] m_strFrom;

		public byte[] m_strCliInfo;

		public byte[] m_strReserve;

		public override void vsmarshall(ByteArray _arg1)
		{
			base.vsmarshall(_arg1);
			pushBytes(m_strAccount);
			pushBytes(m_strPassword);
			pushInt(m_uCliType);
			pushInt(m_uCliVer);
			pushInt(m_uCliLcid);
			pushBytes(m_strFrom);
			pushBytes(m_strCliInfo);
			pushBytes(m_strReserve);
		}
	}
}
