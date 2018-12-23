using System;

namespace FluentData
{
	internal class QueryScalarHandler<TEntity> : IQueryTypeHandler<TEntity>
	{
		private readonly DbCommandData dbCommandData_0;

		private Type type_0;

		public bool IterateDataReader
		{
			get
			{
				return true;
			}
		}

		public QueryScalarHandler(DbCommandData data)
		{
			dbCommandData_0 = data;
		}

		public object HandleType(Action<TEntity, IDataReader> customMapperReader, Action<TEntity, dynamic> customMapperDynamic)
		{
			object obj = dbCommandData_0.Reader.GetValue(0);
			if (type_0 == (Type)null)
			{
				type_0 = dbCommandData_0.Reader.GetFieldType(0);
			}
			if (obj == null)
			{
				obj = default(TEntity);
			}
			else if (type_0 != typeof(TEntity))
			{
				obj = Convert.ChangeType(obj, typeof(TEntity));
			}
			return (TEntity)obj;
		}
	}
}
