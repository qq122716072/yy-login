using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class UDBYYLoginRes : ProtoBase
	{
		public byte[] _context;

		public uint _rescode;

		public byte[] _reason;

		public byte[] _description;

		public MyUInt64 _yyuid;

		public List<byte[]> dynamic_token_reqs;

		public byte[] _pic_id;

		public byte[] _pic_data;

		public byte[] _login_data;

		public byte[] _callback_data;

		public byte[] _extension;

		public UDBYYLoginRes()
		{
			dynamic_token_reqs = new List<byte[]>();
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			_context = popBytes();
			_rescode = popInt();
			_reason = popBytes();
			_description = popBytes();
			_yyuid = popInt64();
			dynamic_token_reqs = popStringArray();
			_pic_id = popBytes();
			_pic_data = popBytes();
			_login_data = popBytes();
			_callback_data = popBytes();
			_extension = popBytes();
		}
	}
}
