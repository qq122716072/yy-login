using System;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace FluentData
{
	public class DbContextData
	{
		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private IDbConnection idbConnection_0;

		[CompilerGenerated]
		private DbProviderFactory dbProviderFactory_0;

		[CompilerGenerated]
		private IsolationLevel isolationLevel_0;

		[CompilerGenerated]
		private IDbTransaction idbTransaction_0;

		[CompilerGenerated]
		private IDbProvider idbProvider_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private IEntityFactory ientityFactory_0;

		[CompilerGenerated]
		private bool bool_2;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private Action<ConnectionEventArgs> action_0;

		[CompilerGenerated]
		private Action<ConnectionEventArgs> action_1;

		[CompilerGenerated]
		private Action<ConnectionEventArgs> action_2;

		[CompilerGenerated]
		private Action<CommandEventArgs> action_3;

		[CompilerGenerated]
		private Action<CommandEventArgs> action_4;

		[CompilerGenerated]
		private Action<ErrorEventArgs> action_5;

		public bool UseTransaction
		{
			get;
			set;
		}

		public bool UseSharedConnection
		{
			get;
			set;
		}

		public IDbConnection Connection
		{
			get;
			set;
		}

		public DbProviderFactory AdoNetProvider
		{
			get;
			set;
		}

		public IsolationLevel IsolationLevel
		{
			get;
			set;
		}

		public IDbTransaction Transaction
		{
			get;
			set;
		}

		public IDbProvider FluentDataProvider
		{
			get;
			set;
		}

		public string ConnectionString
		{
			get;
			set;
		}

		public IEntityFactory EntityFactory
		{
			get;
			set;
		}

		public bool IgnoreIfAutoMapFails
		{
			get;
			set;
		}

		public int CommandTimeout
		{
			get;
			set;
		}

		public Action<ConnectionEventArgs> OnConnectionOpening
		{
			get;
			set;
		}

		public Action<ConnectionEventArgs> OnConnectionOpened
		{
			get;
			set;
		}

		public Action<ConnectionEventArgs> OnConnectionClosed
		{
			get;
			set;
		}

		public Action<CommandEventArgs> OnExecuting
		{
			get;
			set;
		}

		public Action<CommandEventArgs> OnExecuted
		{
			get;
			set;
		}

		public Action<ErrorEventArgs> OnError
		{
			get;
			set;
		}

		public DbContextData()
		{
			IgnoreIfAutoMapFails = false;
			UseTransaction = false;
			IsolationLevel = IsolationLevel.ReadCommitted;
			EntityFactory = new EntityFactory();
			CommandTimeout = -2147483648;
		}
	}
}
