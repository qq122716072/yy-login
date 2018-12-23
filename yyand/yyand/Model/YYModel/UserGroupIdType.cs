using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class UserGroupIdType : ProtoBase
	{
		public MyUInt64 userGroupType;

		public MyUInt64 userGroupId;

		public UserGroupIdType()
		{
			userGroupType = new MyUInt64(0u, 0u);
			userGroupId = new MyUInt64(0u, 0u);
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			method_0(userGroupType);
			method_0(userGroupId);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			userGroupType = popInt64();
			userGroupId = popInt64();
		}
	}
}
