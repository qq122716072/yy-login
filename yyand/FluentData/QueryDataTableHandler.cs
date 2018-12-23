using System;
using System.Data;

namespace FluentData
{
	internal class QueryDataTableHandler<TEntity> : IQueryTypeHandler<TEntity>
	{
		private readonly DbCommandData dbCommandData_0;

		public bool IterateDataReader
		{
			get
			{
				return false;
			}
		}

		public QueryDataTableHandler(DbCommandData data)
		{
			dbCommandData_0 = data;
		}

		public object HandleType(Action<TEntity, IDataReader> customMapperReader, Action<TEntity, dynamic> customMapperDynamic)
		{
			DataTable dataTable = new DataTable();
			dataTable.Load(dbCommandData_0.Reader.InnerReader, LoadOption.OverwriteChanges);
			return dataTable;
		}
	}
}
