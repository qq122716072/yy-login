using System;
using System.Data;
using System.Dynamic;

namespace FluentData
{
	internal class DynamicDataReader : DynamicObject
	{
		private readonly System.Data.IDataReader idataReader_0;

		internal DynamicDataReader(System.Data.IDataReader dataReader)
		{
			idataReader_0 = dataReader;
		}

		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			result = idataReader_0[binder.Name];
			if (result == DBNull.Value)
			{
				result = null;
			}
			return true;
		}
	}
}
