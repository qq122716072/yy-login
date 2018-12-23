using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PJoinUserGroup : ProtoBase
	{
		public MyUInt64 uid;

		public List<UserGroupIdType> userGroupIdSet;

		public byte[] extraInfo;

		public PJoinUserGroup()
		{
			uid = new MyUInt64(0u, 0u);
			userGroupIdSet = new List<UserGroupIdType>();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(642648u);
			method_0(uid);
			pushProtoArray(userGroupIdSet);
			pushBytes(extraInfo);
		}
	}
}
