using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PUDBLoginAnonymousRes : ProtoBase
	{
		public byte[] context;

		public uint rescode;

		public uint uid;

		public uint yyid;

		public byte[] passport;

		public byte[] password;

		public byte[] cookie;

		public byte[] ticket;

		public byte[] _pic_data;

		public byte[] _session_data;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			context = popBytes();
			rescode = popInt();
			uid = popInt();
			yyid = popInt();
			passport = popBytes();
			password = popBytes();
			cookie = popBytes();
			ticket = popBytes();
			if (_arg1.length > 0)
			{
				_pic_data = popBytes();
				_session_data = popBytes();
			}
		}
	}
}
