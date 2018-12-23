using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace FluentData
{
	public class DbCommandData
	{
		internal ExecuteQueryHandler ExecuteQueryHandler;

		[CompilerGenerated]
		private DbContext dbContext_0;

		[CompilerGenerated]
		private System.Data.IDbCommand idbCommand_0;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private IDataReader idataReader_0;

		[CompilerGenerated]
		private StringBuilder stringBuilder_0;

		public DbContext Context
		{
			get;
			private set;
		}

		public System.Data.IDbCommand InnerCommand
		{
			get;
			private set;
		}

		public bool UseMultipleResultsets
		{
			get;
			set;
		}

		public IDataReader Reader
		{
			get;
			set;
		}

		public StringBuilder Sql
		{
			get;
			private set;
		}

		public DbCommandData(DbContext context, System.Data.IDbCommand innerCommand)
		{
			Context = context;
			InnerCommand = innerCommand;
			InnerCommand.CommandType = CommandType.Text;
			Sql = new StringBuilder();
		}
	}
}
