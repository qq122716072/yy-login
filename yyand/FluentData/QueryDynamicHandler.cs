using System;

namespace FluentData
{
	internal class QueryDynamicHandler<TEntity> : IQueryTypeHandler<TEntity>
	{
		private readonly DbCommandData dbCommandData_0;

		private readonly DynamicTypeAutoMapper dynamicTypeAutoMapper_0;

		public bool IterateDataReader
		{
			get
			{
				return true;
			}
		}

		public QueryDynamicHandler(DbCommandData data)
		{
			dbCommandData_0 = data;
			dynamicTypeAutoMapper_0 = new DynamicTypeAutoMapper(dbCommandData_0.Reader.InnerReader);
		}

		public object HandleType(Action<TEntity, IDataReader> customMapperReader, Action<TEntity, dynamic> customMapperDynamic)
		{
			return dynamicTypeAutoMapper_0.AutoMap();
		}
	}
}
