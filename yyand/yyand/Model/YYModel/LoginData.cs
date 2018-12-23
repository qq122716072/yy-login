using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class LoginData : ProtoBase
	{
		public MyUInt64 _yyid;

		public MyUInt64 _udbuid;

		public byte[] _passport;

		public byte[] _accessToken;

		public byte[] _accountInfo;

		public List<byte[]> _jump_tokens;

		public byte[] _ticket;

		public byte[] _yycookie;

		public byte[] _cookie;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			_yyid = popInt64();
			_udbuid = popInt64();
			_passport = popBytes();
			_accessToken = popBytes();
			_accountInfo = popBytes();
			_jump_tokens = popStringArray();
			_ticket = popBytes();
			_yycookie = popBytes();
			_cookie = popBytes();
		}
	}
}
