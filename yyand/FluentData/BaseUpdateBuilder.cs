using System.Runtime.CompilerServices;

namespace FluentData
{
	internal abstract class BaseUpdateBuilder
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

		public BaseUpdateBuilder(IDbProvider provider, IDbCommand command, string name)
		{
			Data = new BuilderData(command, name);
			Actions = new ActionsHandler(Data);
		}

		public int Execute()
		{
			if (Data.Columns.Count == 0 || Data.Where.Count == 0)
			{
				throw new FluentDataException("Columns or where filter have not yet been added.");
			}
			Data.Command.ClearSql.Sql(Data.Command.Data.Context.Data.FluentDataProvider.GetSqlForUpdateBuilder(Data));
			return Data.Command.Execute();
		}
	}
}
