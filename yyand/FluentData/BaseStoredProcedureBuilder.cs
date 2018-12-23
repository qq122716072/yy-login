using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FluentData
{
	internal abstract class BaseStoredProcedureBuilder
	{
		[CompilerGenerated]
		private BuilderData pvWaltdXoI;

		[CompilerGenerated]
		private ActionsHandler actionsHandler_0;

		public BuilderData Data
		{
			get;
			set;
		}

		protected ActionsHandler Actions
		{
			get;
			set;
		}

		public BaseStoredProcedureBuilder(IDbCommand command, string name)
		{
			Data = new BuilderData(command, name);
			Actions = new ActionsHandler(Data);
		}

		private IDbCommand method_0()
		{
			Data.Command.CommandType(DbCommandTypes.StoredProcedure);
			Data.Command.ClearSql.Sql(Data.Command.Data.Context.Data.FluentDataProvider.GetSqlForStoredProcedureBuilder(Data));
			return Data.Command;
		}

		public void Dispose()
		{
			Data.Command.Dispose();
		}

		public TParameterType ParameterValue<TParameterType>(string outputParameterName)
		{
			return Data.Command.ParameterValue<TParameterType>(outputParameterName);
		}

		public int Execute()
		{
			return method_0().Execute();
		}

		public List<TEntity> QueryMany<TEntity>(Action<TEntity, IDataReader> customMapper = null)
		{
			return method_0().QueryMany(customMapper);
		}

		public List<TEntity> QueryMany<TEntity>(Action<TEntity, dynamic> customMapper)
		{
			return method_0().QueryMany(customMapper);
		}

		public TList QueryMany<TEntity, TList>(Action<TEntity, IDataReader> customMapper = null) where TList : IList<TEntity>
		{
			return method_0().QueryMany<TEntity, TList>(customMapper);
		}

		public TList QueryMany<TEntity, TList>(Action<TEntity, dynamic> customMapper) where TList : IList<TEntity>
		{
			return method_0().QueryMany<TEntity, TList>(customMapper);
		}

		public void QueryComplexMany<TEntity>(IList<TEntity> list, Action<IList<TEntity>, IDataReader> customMapper)
		{
			method_0().QueryComplexMany(list, customMapper);
		}

		public void QueryComplexMany<TEntity>(IList<TEntity> list, Action<IList<TEntity>, dynamic> customMapper)
		{
			method_0().QueryComplexMany(list, customMapper);
		}

		public TEntity QuerySingle<TEntity>(Action<TEntity, IDataReader> customMapper = null)
		{
			return method_0().QuerySingle(customMapper);
		}

		public TEntity QuerySingle<TEntity>(Action<TEntity, dynamic> customMapper)
		{
			return method_0().QuerySingle(customMapper);
		}

		public TEntity QueryComplexSingle<TEntity>(Func<IDataReader, TEntity> customMapper)
		{
			return method_0().QueryComplexSingle(customMapper);
		}

		public TEntity QueryComplexSingle<TEntity>(Func<dynamic, TEntity> customMapper)
		{
			return method_0().QueryComplexSingle(customMapper);
		}
	}
}
