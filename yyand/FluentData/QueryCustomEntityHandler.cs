using System;

namespace FluentData
{
	internal class QueryCustomEntityHandler<TEntity> : IQueryTypeHandler<TEntity>
	{
		private readonly AutoMapper autoMapper_0;

		private readonly DbCommandData dbCommandData_0;

		public bool IterateDataReader
		{
			get
			{
				return true;
			}
		}

		public QueryCustomEntityHandler(DbCommandData data)
		{
			dbCommandData_0 = data;
			autoMapper_0 = new AutoMapper(dbCommandData_0, typeof(TEntity));
		}

		public object HandleType(Action<TEntity, IDataReader> customMapperReader, Action<TEntity, dynamic> customMapperDynamic)
		{
			TEntity val = (TEntity)dbCommandData_0.Context.Data.EntityFactory.Create(typeof(TEntity));
			if (customMapperReader != null)
			{
				customMapperReader(val, dbCommandData_0.Reader);
			}
			else if (customMapperDynamic != null)
			{
				customMapperDynamic(val, new DynamicDataReader(dbCommandData_0.Reader.InnerReader));
			}
			else
			{
				autoMapper_0.AutoMap(val);
			}
			return val;
		}
	}
}
