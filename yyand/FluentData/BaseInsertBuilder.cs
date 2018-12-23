using System.Runtime.CompilerServices;

namespace FluentData
{
	internal abstract class BaseInsertBuilder
	{
		[CompilerGenerated]
		private BuilderData builderData_0;

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

		public BaseInsertBuilder(IDbCommand command, string name)
		{
			Data = new BuilderData(command, name);
			Actions = new ActionsHandler(Data);
		}

		private IDbCommand method_0()
		{
			Data.Command.ClearSql.Sql(Data.Command.Data.Context.Data.FluentDataProvider.GetSqlForInsertBuilder(Data));
			return Data.Command;
		}

		public int Execute()
		{
			return method_0().Execute();
		}

		public T ExecuteReturnLastId<T>(string identityColumnName = null)
		{
			return method_0().ExecuteReturnLastId<T>(identityColumnName);
		}
	}
}
