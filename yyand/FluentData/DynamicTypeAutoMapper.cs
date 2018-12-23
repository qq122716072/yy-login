using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace FluentData
{
	internal class DynamicTypeAutoMapper
	{
		private readonly List<DataReaderField> list_0;

		private readonly System.Data.IDataReader idataReader_0;

		public DynamicTypeAutoMapper(System.Data.IDataReader reader)
		{
			idataReader_0 = reader;
			list_0 = DataReaderHelper.GetDataReaderFields(idataReader_0);
		}

		public ExpandoObject AutoMap()
		{
			ExpandoObject expandoObject = new ExpandoObject();
			IDictionary<string, object> dictionary = expandoObject;
			foreach (DataReaderField item in list_0)
			{
				if (idataReader_0.IsDBNull(item.Index))
				{
					dictionary.Add(item.Name, null);
				}
				else
				{
					dictionary.Add(item.Name, idataReader_0[item.Index]);
				}
			}
			return expandoObject;
		}
	}
}
