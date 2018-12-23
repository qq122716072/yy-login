using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace FluentData
{
	internal class QueryHandler<TEntity>
	{
		private readonly DbCommandData dbCommandData_0;

		private readonly IQueryTypeHandler<TEntity> iqueryTypeHandler_0;

		public QueryHandler(DbCommandData data)
		{
			dbCommandData_0 = data;
			if (!(typeof(TEntity) == typeof(object)) && !(typeof(TEntity) == typeof(ExpandoObject)))
			{
				if (typeof(TEntity) == typeof(DataTable))
				{
					iqueryTypeHandler_0 = new QueryDataTableHandler<TEntity>(data);
				}
				else if (ReflectionHelper.IsCustomEntity<TEntity>())
				{
					iqueryTypeHandler_0 = new QueryCustomEntityHandler<TEntity>(data);
				}
				else
				{
					iqueryTypeHandler_0 = new QueryScalarHandler<TEntity>(data);
				}
			}
			else
			{
				iqueryTypeHandler_0 = new QueryDynamicHandler<TEntity>(data);
			}
		}

		internal TList ExecuteMany<TList>(Action<TEntity, IDataReader> customMapperReader, Action<TEntity, dynamic> customMapperDynamic) where TList : IList<TEntity>
		{
			TList result = (TList)this.dbCommandData_0.Context.Data.EntityFactory.Create(typeof(TList));
			System.Data.IDataReader innerReader = this.dbCommandData_0.Reader.InnerReader;
			if (this.iqueryTypeHandler_0.IterateDataReader)
			{
				while (innerReader.Read())
				{
					TEntity item = (TEntity)this.iqueryTypeHandler_0.HandleType(customMapperReader, customMapperDynamic);
					((ICollection<TEntity>)result).Add(item);
				}
			}
			else
			{
				TEntity item2 = (TEntity)this.iqueryTypeHandler_0.HandleType(customMapperReader, customMapperDynamic);
				((ICollection<TEntity>)result).Add(item2);
			}
			return result;
		}

		internal TEntity ExecuteSingle(Action<TEntity, IDataReader> customMapperReader, Action<TEntity, dynamic> customMapperDynamic)
		{
			TEntity result = default(TEntity);
			if (iqueryTypeHandler_0.IterateDataReader && !dbCommandData_0.Reader.InnerReader.Read())
			{
				return result;
			}
			return (TEntity)iqueryTypeHandler_0.HandleType(customMapperReader, customMapperDynamic);
		}
	}
}
