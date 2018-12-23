using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FluentData
{
	internal class SelectBuilder<TEntity> : ISelectBuilder<TEntity>
	{
		[CompilerGenerated]
		private SelectBuilderData selectBuilderData_0;

		[CompilerGenerated]
		private ActionsHandler actionsHandler_0;

		public SelectBuilderData Data
		{
			get;
			set;
		}

		protected ActionsHandler Actions
		{
			get;
			set;
		}

		public SelectBuilder(IDbCommand command)
		{
			Data = new SelectBuilderData(command, "");
			Actions = new ActionsHandler(Data);
		}

		private IDbCommand method_0()
		{
			if (Data.PagingItemsPerPage > 0 && string.IsNullOrEmpty(Data.OrderBy))
			{
				throw new FluentDataException("Order by must defined when using Paging.");
			}
			Data.Command.ClearSql.Sql(Data.Command.Data.Context.Data.FluentDataProvider.GetSqlForSelectBuilder(Data));
			return Data.Command;
		}

		public ISelectBuilder<TEntity> Select(string sql)
		{
			SelectBuilderData data = Data;
			data.Select += sql;
			return this;
		}

		public ISelectBuilder<TEntity> From(string sql)
		{
			SelectBuilderData data = Data;
			data.From += sql;
			return this;
		}

		public ISelectBuilder<TEntity> Where(string sql)
		{
			SelectBuilderData data = Data;
			data.WhereSql += sql;
			return this;
		}

		public ISelectBuilder<TEntity> AndWhere(string sql)
		{
			if (Data.WhereSql.Length > 0)
			{
				SelectBuilderData data = Data;
				data.WhereSql += " and ";
			}
			SelectBuilderData data2 = Data;
			data2.WhereSql += sql;
			return this;
		}

		public ISelectBuilder<TEntity> OrWhere(string sql)
		{
			if (Data.WhereSql.Length > 0)
			{
				SelectBuilderData data = Data;
				data.WhereSql += " or ";
			}
			SelectBuilderData data2 = Data;
			data2.WhereSql += sql;
			return this;
		}

		public ISelectBuilder<TEntity> OrderBy(string sql)
		{
			SelectBuilderData data = Data;
			data.OrderBy += sql;
			return this;
		}

		public ISelectBuilder<TEntity> GroupBy(string sql)
		{
			SelectBuilderData data = Data;
			data.GroupBy += sql;
			return this;
		}

		public ISelectBuilder<TEntity> Having(string sql)
		{
			SelectBuilderData data = Data;
			data.Having += sql;
			return this;
		}

		public ISelectBuilder<TEntity> Paging(int currentPage, int itemsPerPage)
		{
			Data.PagingCurrentPage = currentPage;
			Data.PagingItemsPerPage = itemsPerPage;
			return this;
		}

		public ISelectBuilder<TEntity> Parameter(string name, object value, DataTypes parameterType, ParameterDirection direction, int size)
		{
			Data.Command.Parameter(name, value, parameterType, direction, size);
			return this;
		}

		public ISelectBuilder<TEntity> Parameters(params object[] parameters)
		{
			Data.Command.Parameters(parameters);
			return this;
		}

		public List<TEntity> QueryMany(Action<TEntity, IDataReader> customMapper = null)
		{
			return ((IQuery)method_0()).QueryMany<TEntity>(customMapper);
		}

		public List<TEntity> QueryMany(Action<TEntity, dynamic> customMapper)
		{
			return ((IQuery)method_0()).QueryMany<TEntity>(customMapper);
		}

		public TList QueryMany<TList>(Action<TEntity, IDataReader> customMapper = null) where TList : IList<TEntity>
		{
			return ((IQuery)this.method_0()).QueryMany<TEntity, TList>(customMapper);
		}

		public TList QueryMany<TList>(Action<TEntity, dynamic> customMapper) where TList : IList<TEntity>
		{
			return ((IQuery)this.method_0()).QueryMany<TEntity, TList>(customMapper);
		}

		public void QueryComplexMany(IList<TEntity> list, Action<IList<TEntity>, IDataReader> customMapper)
		{
			((IQuery)method_0()).QueryComplexMany<TEntity>(list, customMapper);
		}

		public void QueryComplexMany(IList<TEntity> list, Action<IList<TEntity>, dynamic> customMapper)
		{
			((IQuery)method_0()).QueryComplexMany<TEntity>(list, customMapper);
		}

		public TEntity QuerySingle(Action<TEntity, IDataReader> customMapper = null)
		{
			return ((IQuery)method_0()).QuerySingle<TEntity>(customMapper);
		}

		public TEntity QuerySingle(Action<TEntity, dynamic> customMapper)
		{
			return ((IQuery)method_0()).QuerySingle<TEntity>(customMapper);
		}

		public TEntity QueryComplexSingle(Func<IDataReader, TEntity> customMapper)
		{
			return ((IQuery)method_0()).QueryComplexSingle<TEntity>(customMapper);
		}

		public TEntity QueryComplexSingle(Func<dynamic, TEntity> customMapper)
		{
			return ((IQuery)method_0()).QueryComplexSingle<TEntity>(customMapper);
		}
	}
}
