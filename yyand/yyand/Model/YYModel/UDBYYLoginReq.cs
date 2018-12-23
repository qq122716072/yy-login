using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class UDBYYLoginReq : ProtoBase
	{
		public byte[] _context;

		public byte[] _appid;

		public uint _apptype;

		public uint _lcid;

		public MyUInt64 _terminal_type;

		public byte[] _device_id;

		public byte[] _client_ip;

		public uint _ver_int;

		public byte[] _ver_str;

		public byte[] _version;

		public MyUInt64 _yyuid;

		public byte[] _user;

		public uint _user_token_type;

		public byte[] _user_token;

		public byte[] _pic_id;

		public byte[] _pic_code;

		public uint _dynamic_token_type;

		public byte[] _dynamic_token;

		public byte[] _vmToken;

		public List<ByteArray> _jump_appids;

		public List<ByteArray> _jump_sessionids;

		public byte[] _callback_data;

		public byte[] _extension;

		public UDBYYLoginReq()
		{
			_terminal_type = new MyUInt64(0u, 0u);
			_yyuid = new MyUInt64(0u, 0u);
			_jump_appids = new List<ByteArray>();
			_jump_sessionids = new List<ByteArray>();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(2281u);
			pushBytes(_context);
			pushBytes(_appid);
			pushByte(_apptype);
			pushInt(_lcid);
			method_0(_terminal_type);
			pushBytes(_device_id);
			pushBytes(_client_ip);
			pushInt(_ver_int);
			pushBytes(_ver_str);
			pushBytes(_version);
			method_0(_yyuid);
			pushBytes(_user);
			pushByte(_user_token_type);
			pushBytes(_user_token);
			pushBytes(_pic_id);
			pushBytes(_pic_code);
			pushShort(_dynamic_token_type);
			pushBytes(_dynamic_token);
			pushBytes(_vmToken);
			pushStringArray(_jump_appids);
			pushStringArray(_jump_sessionids);
			pushBytes(_callback_data);
			pushBytes(_extension);
		}
	}
}
