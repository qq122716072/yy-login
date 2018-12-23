using System;
using System.Data;

namespace FluentData
{
	internal class ExecuteQueryHandler
	{
		private readonly DbCommand dbCommand_0;

		private bool bool_0;

		public ExecuteQueryHandler(DbCommand command)
		{
			dbCommand_0 = command;
		}

		internal void ExecuteQuery(bool useReader, Action action)
		{
			try
			{
				method_0(useReader);
				action();
				if (dbCommand_0.Data.Context.Data.OnExecuted != null)
				{
					dbCommand_0.Data.Context.Data.OnExecuted(new CommandEventArgs(dbCommand_0.Data.InnerCommand));
				}
			}
			catch (Exception exception_)
			{
				method_3(exception_);
			}
			finally
			{
				method_2();
			}
		}

		private void method_0(bool bool_1)
		{
			if (bool_0)
			{
				if (!dbCommand_0.Data.UseMultipleResultsets)
				{
					throw new FluentDataException("A query has already been executed on this command object. Please create a new command object.");
				}
				dbCommand_0.Data.Reader.NextResult();
			}
			else
			{
				dbCommand_0.Data.InnerCommand.CommandText = dbCommand_0.Data.Sql.ToString();
				if (dbCommand_0.Data.Context.Data.CommandTimeout != -2147483648)
				{
					dbCommand_0.Data.InnerCommand.CommandTimeout = dbCommand_0.Data.Context.Data.CommandTimeout;
				}
				if (dbCommand_0.Data.InnerCommand.Connection.State != ConnectionState.Open)
				{
					method_1();
				}
				if (dbCommand_0.Data.Context.Data.UseTransaction)
				{
					if (dbCommand_0.Data.Context.Data.Transaction == null)
					{
						dbCommand_0.Data.Context.Data.Transaction = dbCommand_0.Data.Context.Data.Connection.BeginTransaction((System.Data.IsolationLevel)dbCommand_0.Data.Context.Data.IsolationLevel);
					}
					dbCommand_0.Data.InnerCommand.Transaction = dbCommand_0.Data.Context.Data.Transaction;
				}
				if (dbCommand_0.Data.Context.Data.OnExecuting != null)
				{
					dbCommand_0.Data.Context.Data.OnExecuting(new CommandEventArgs(dbCommand_0.Data.InnerCommand));
				}
				if (bool_1)
				{
					dbCommand_0.Data.Reader = new DataReader(dbCommand_0.Data.InnerCommand.ExecuteReader());
				}
				bool_0 = true;
			}
		}

		private void method_1()
		{
			if (dbCommand_0.Data.Context.Data.OnConnectionOpening != null)
			{
				dbCommand_0.Data.Context.Data.OnConnectionOpening(new ConnectionEventArgs(dbCommand_0.Data.InnerCommand.Connection));
			}
			dbCommand_0.Data.InnerCommand.Connection.Open();
			if (dbCommand_0.Data.Context.Data.OnConnectionOpened != null)
			{
				dbCommand_0.Data.Context.Data.OnConnectionOpened(new ConnectionEventArgs(dbCommand_0.Data.InnerCommand.Connection));
			}
		}

		private void method_2()
		{
			if (!dbCommand_0.Data.UseMultipleResultsets)
			{
				if (dbCommand_0.Data.Reader != null)
				{
					dbCommand_0.Data.Reader.Close();
				}
				dbCommand_0.ClosePrivateConnection();
			}
		}

		private void method_3(Exception exception_0)
		{
			if (dbCommand_0.Data.Reader != null)
			{
				dbCommand_0.Data.Reader.Close();
			}
			dbCommand_0.ClosePrivateConnection();
			if (dbCommand_0.Data.Context.Data.UseTransaction)
			{
				dbCommand_0.Data.Context.CloseSharedConnection();
			}
			if (dbCommand_0.Data.Context.Data.OnError != null)
			{
				dbCommand_0.Data.Context.Data.OnError(new ErrorEventArgs(dbCommand_0.Data.InnerCommand, exception_0));
			}
			throw exception_0;
		}
	}
}
