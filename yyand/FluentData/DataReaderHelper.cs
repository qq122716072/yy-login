using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FluentData
{
	internal class DataReaderHelper
	{
		internal static List<DataReaderField> GetDataReaderFields(System.Data.IDataReader reader)
		{
			List<DataReaderField> list = new List<DataReaderField>();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				DataReaderField column = new DataReaderField(i, reader.GetName(i), reader.GetFieldType(i));
				if (list.SingleOrDefault((DataReaderField x) => x.LowerName == column.LowerName) == null)
				{
					list.Add(column);
				}
			}
			return list;
		}
	}
}
