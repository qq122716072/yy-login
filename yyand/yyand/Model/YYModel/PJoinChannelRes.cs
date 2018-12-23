using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PJoinChannelRes : ProtoBase
	{
		public const uint USER_KICK_OFF = 0u;

		public const uint USER_BAN_ID = 1u;

		public const uint USER_BAN_PC = 3u;

		public const uint USER_LOGIN_SUCCESS = 4u;

		public const uint USER_LOGIN_DUOWAN_LIMIT = 5u;

		public const uint USER_NEED_PASSWD = 6u;

		public const uint USER_MUTIJOIN = 7u;

		public const uint USER_MUTIJOIN_ERR_MODE = 8u;

		public const uint USER_MUTIJOIN_TIMEOUT = 9u;

		public const uint CHANNEL_FULL = 10u;

		public const uint CHANNEL_CONGEST = 11u;

		public const uint CHANNEL_NOT_EXIST = 12u;

		public const uint CHANNEL_FROZEN = 13u;

		public const uint CHANNEL_LOCKED = 14u;

		public const uint CHANNEL_ASID_RECYLED = 15u;

		public const uint CHANNEL_SUBSID_FULL = 17u;

		public const uint CHANNEL_SUBSID_LIMIT = 18u;

		public const uint GUSET_ACCESS_LIMIT = 19u;

		public const uint CHANNEL_VIP_LIMIT = 20u;

		public const uint CHANNEL_CHARGE_LIMIT = 21u;

		public const uint JOIN_MUTI_MODE_CONTEXT = 1u;

		public const uint JOIN_MUTI_TYPES = 2u;

		public const uint JOIN_MY_ROLER = 3u;

		public uint topsid;

		public uint uid;

		public uint subSid;

		public uint asid;

		public uint loginStamp;

		public uint loginStatus;

		public byte[] errorInfo;

		public uint expiredTime;

		public MYHashMap joinProps;

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			topsid = popInt();
			uid = popInt();
			subSid = popInt();
			asid = popInt();
			loginStamp = popInt();
			loginStatus = popByte();
			errorInfo = popBytes();
		}
	}
}
