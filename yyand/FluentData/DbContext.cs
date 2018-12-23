using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace FluentData
{
	public class DbContext : IDisposable, IDbContext
	{
		[CompilerGenerated]
		private DbContextData dbContextData_0;

		public DbContextData Data
		{
			get;
			private set;
		}

		public IDbCommand MultiResultSql
		{
			get
			{
				return method_1().UseMultiResult(true);
			}
		}

		public DbContext()
		{
			Data = new DbContextData();
		}

		internal void CloseSharedConnection()
		{
			if (Data.Connection != null)
			{
				if (Data.UseTransaction && Data.Transaction != null)
				{
					Rollback();
				}
				Data.Connection.Close();
				if (Data.OnConnectionClosed != null)
				{
					Data.OnConnectionClosed(new ConnectionEventArgs(Data.Connection));
				}
			}
		}

		public void Dispose()
		{
			CloseSharedConnection();
		}

		public IDbContext IgnoreIfAutoMapFails(bool ignoreIfAutoMapFails)
		{
			Data.IgnoreIfAutoMapFails = true;
			return this;
		}

		public ISelectBuilder<TEntity> Select<TEntity>(string sql)
		{
			return new SelectBuilder<TEntity>((IDbCommand)method_1()).Select(sql);
		}

		public IInsertBuilder Insert(string tableName)
		{
			return new InsertBuilder(method_1(), tableName);
		}

		public IInsertBuilder<T> Insert<T>(string tableName, T item)
		{
			return new InsertBuilder<T>((IDbCommand)method_1(), tableName, item);
		}

		public IInsertBuilderDynamic Insert(string tableName, ExpandoObject item)
		{
			return new InsertBuilderDynamic(method_1(), tableName, item);
		}

		public IUpdateBuilder Update(string tableName)
		{
			return new UpdateBuilder(Data.FluentDataProvider, method_1(), tableName);
		}

		public IUpdateBuilder<T> Update<T>(string tableName, T item)
		{
			return new UpdateBuilder<T>(Data.FluentDataProvider, (IDbCommand)method_1(), tableName, item);
		}

		public IUpdateBuilderDynamic Update(string tableName, ExpandoObject item)
		{
			return new UpdateBuilderDynamic(Data.FluentDataProvider, method_1(), tableName, item);
		}

		public IDeleteBuilder Delete(string tableName)
		{
			return new DeleteBuilder(method_1(), tableName);
		}

		public IDeleteBuilder<T> Delete<T>(string tableName, T item)
		{
			return new DeleteBuilder<T>((IDbCommand)method_1(), tableName, item);
		}

		private void method_0()
		{
			if (!Data.FluentDataProvider.SupportsStoredProcedures)
			{
				throw new FluentDataException("The selected database does not support stored procedures.");
			}
		}

		public IStoredProcedureBuilder StoredProcedure(string storedProcedureName)
		{
			method_0();
			return new StoredProcedureBuilder(method_1(), storedProcedureName);
		}

		public IStoredProcedureBuilder<T> StoredProcedure<T>(string storedProcedureName, T item)
		{
			method_0();
			return new StoredProcedureBuilder<T>((IDbCommand)method_1(), storedProcedureName, item);
		}

		public IStoredProcedureBuilderDynamic StoredProcedure(string storedProcedureName, ExpandoObject item)
		{
			method_0();
			return new StoredProcedureBuilderDynamic(method_1(), storedProcedureName, item);
		}

		public IDbContext CommandTimeout(int timeout)
		{
			Data.CommandTimeout = timeout;
			return this;
		}

		public IDbContext ConnectionString(string connectionString, IDbProvider fluentDataProvider, string providerName = null)
		{
			if (string.IsNullOrEmpty(providerName))
			{
				providerName = fluentDataProvider.ProviderName;
			}
			DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);
			return ConnectionString(connectionString, fluentDataProvider, factory);
		}

		public IDbContext ConnectionString(string connectionString, IDbProvider fluentDataProvider, DbProviderFactory adoNetProviderFactory)
		{
			Data.ConnectionString = connectionString;
			Data.FluentDataProvider = fluentDataProvider;
			Data.AdoNetProvider = adoNetProviderFactory;
			return this;
		}

		public IDbContext ConnectionStringName(string connectionstringName, IDbProvider dbProvider)
		{
			ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings[connectionstringName];
			if (connectionStringSettings == null)
			{
				throw new FluentDataException("A connectionstring with the specified name was not found in the .config file");
			}
			ConnectionString(connectionStringSettings.ConnectionString, dbProvider, connectionStringSettings.ProviderName);
			return this;
		}

		public IDbContext EntityFactory(IEntityFactory entityFactory)
		{
			Data.EntityFactory = entityFactory;
			return this;
		}

		public IDbContext OnConnectionOpening(Action<ConnectionEventArgs> action)
		{
			Data.OnConnectionOpening = action;
			return this;
		}

		public IDbContext OnConnectionOpened(Action<ConnectionEventArgs> action)
		{
			Data.OnConnectionOpened = action;
			return this;
		}

		public IDbContext OnConnectionClosed(Action<ConnectionEventArgs> action)
		{
			Data.OnConnectionClosed = action;
			return this;
		}

		public IDbContext OnExecuting(Action<CommandEventArgs> action)
		{
			Data.OnExecuting = action;
			return this;
		}

		public IDbContext OnExecuted(Action<CommandEventArgs> action)
		{
			Data.OnExecuted = action;
			return this;
		}

		public IDbContext OnError(Action<ErrorEventArgs> action)
		{
			Data.OnError = action;
			return this;
		}

		private DbCommand method_1()
		{
			IDbConnection dbConnection = null;
			if (!Data.UseTransaction && !Data.UseSharedConnection)
			{
				dbConnection = Data.AdoNetProvider.CreateConnection();
				dbConnection.ConnectionString = Data.ConnectionString;
			}
			else
			{
				if (Data.Connection == null)
				{
					Data.Connection = Data.AdoNetProvider.CreateConnection();
					Data.Connection.ConnectionString = Data.ConnectionString;
				}
				dbConnection = Data.Connection;
			}
			System.Data.IDbCommand dbCommand = dbConnection.CreateCommand();
			dbCommand.Connection = dbConnection;
			return new DbCommand(this, dbCommand);
		}

		public IDbCommand Sql(string sql, params object[] parameters)
		{
			return method_1().Sql(sql).Parameters(parameters);
		}

		public IDbContext UseTransaction(bool useTransaction)
		{
			Data.UseTransaction = useTransaction;
			return this;
		}

		public IDbContext UseSharedConnection(bool useSharedConnection)
		{
			Data.UseSharedConnection = useSharedConnection;
			return this;
		}

		public IDbContext IsolationLevel(IsolationLevel isolationLevel)
		{
			Data.IsolationLevel = isolationLevel;
			return this;
		}

		public IDbContext Commit()
		{
			method_2(method_3);
			return this;
		}

		public IDbContext Rollback()
		{
			method_2(method_4);
			return this;
		}

		private void method_2(Action action_0)
		{
			if (Data.Transaction != null)
			{
				if (!Data.UseTransaction)
				{
					throw new FluentDataException("Transaction support has not been enabled.");
				}
				action_0();
				Data.Transaction = null;
			}
		}

		[CompilerGenerated]
		private void method_3()
		{
			Data.Transaction.Commit();
		}

		[CompilerGenerated]
		private void method_4()
		{
			Data.Transaction.Rollback();
		}
	}
}
