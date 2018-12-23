using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace FluentData
{
	internal class DbCommand : IExecute, GInterface2, IDisposable, IQuery, IParameterValue, IDbCommand
	{
		private int int_0;

		[CompilerGenerated]
		private DbCommandData dbCommandData_0;

		public DbCommandData Data
		{
			get;
			private set;
		}

		public IDbCommand ClearSql
		{
			get
			{
				Data.Sql.Clear();
				return this;
			}
		}

		public DbCommand(DbContext dbContext, System.Data.IDbCommand innerCommand)
		{
			Data = new DbCommandData(dbContext, innerCommand);
			Data.ExecuteQueryHandler = new ExecuteQueryHandler(this);
		}

		public IDbCommand UseMultiResult(bool useMultipleResultset)
		{
			if (useMultipleResultset && !Data.Context.Data.FluentDataProvider.SupportsMultipleResultsets)
			{
				throw new FluentDataException("The selected database does not support multiple resultset");
			}
			Data.UseMultipleResultsets = useMultipleResultset;
			return this;
		}

		public IDbCommand CommandType(DbCommandTypes dbCommandType)
		{
			Data.InnerCommand.CommandType = (CommandType)dbCommandType;
			return this;
		}

		internal void ClosePrivateConnection()
		{
			if (!Data.Context.Data.UseTransaction && !Data.Context.Data.UseSharedConnection)
			{
				Data.InnerCommand.Connection.Close();
				if (Data.Context.Data.OnConnectionClosed != null)
				{
					Data.Context.Data.OnConnectionClosed(new ConnectionEventArgs(Data.InnerCommand.Connection));
				}
			}
		}

		public void Dispose()
		{
			if (Data.Reader != null)
			{
				Data.Reader.Close();
			}
			ClosePrivateConnection();
		}

		public TEntity QueryComplexSingle<TEntity>(Func<IDataReader, TEntity> customMapper)
		{
			TEntity item = (TEntity)default(TEntity);
			Data.ExecuteQueryHandler.ExecuteQuery(true, delegate
			{
				if (Data.Reader.Read())
				{
					item = (TEntity)customMapper(Data.Reader);
				}
			});
			return (TEntity)item;
		}

		public TEntity QueryComplexSingle<TEntity>(Func<dynamic, TEntity> customMapper)
		{
			TEntity item = (TEntity)default(TEntity);
			Data.ExecuteQueryHandler.ExecuteQuery(true, delegate
			{
				if (Data.Reader.Read())
				{
					item = (TEntity)customMapper(new DynamicDataReader(Data.Reader));
				}
			});
			return (TEntity)item;
		}

		public T ExecuteReturnLastId<T>(string identityColumnName = null)
		{
			if (Data.Context.Data.FluentDataProvider.RequiresIdentityColumn && string.IsNullOrEmpty(identityColumnName))
			{
				throw new FluentDataException("The identity column must be given");
			}
			object obj = Data.Context.Data.FluentDataProvider.ExecuteReturnLastId<T>(this, identityColumnName);
			if (!(obj.GetType() == typeof(T)))
			{
				return (T)Convert.ChangeType(obj, typeof(T));
			}
			return (T)obj;
		}

		public TEntity QuerySingle<TEntity>(Action<TEntity, IDataReader> customMapper)
		{
			TEntity item = (TEntity)default(TEntity);
			Data.ExecuteQueryHandler.ExecuteQuery(true, delegate
			{
				item = (TEntity)new QueryHandler<TEntity>(Data).ExecuteSingle(customMapper, (Action<TEntity, dynamic>)null);
			});
			return (TEntity)item;
		}

		public TEntity QuerySingle<TEntity>(Action<TEntity, dynamic> customMapper)
		{
			TEntity item = (TEntity)default(TEntity);
			Data.ExecuteQueryHandler.ExecuteQuery(true, delegate
			{
				item = (TEntity)new QueryHandler<TEntity>(Data).ExecuteSingle((Action<TEntity, IDataReader>)customMapper, (Action<TEntity, dynamic>)null);
			});
			return (TEntity)item;
		}

		public IDbCommand Sql(string sql)
		{
			Data.Sql.Append(sql);
			return this;
		}

		public int Execute()
		{
			int recordsAffected = 0;
			Data.ExecuteQueryHandler.ExecuteQuery(false, delegate
			{
				recordsAffected = Data.InnerCommand.ExecuteNonQuery();
			});
			return recordsAffected;
		}

		public IDbCommand Parameter(string name, object value, DataTypes parameterType = DataTypes.Object, ParameterDirection direction = ParameterDirection.Input, int size = 0)
		{
			if (parameterType != DataTypes.Binary && !(value is byte[]) && ReflectionHelper.IsList(value))
			{
				method_0(name, value);
			}
			else
			{
				method_1(name, value, parameterType, direction, size);
			}
			return this;
		}

		public IDbCommand Parameters(params object[] parameters)
		{
			if (parameters != null)
			{
				for (int i = 0; i < parameters.Count(); i++)
				{
					Parameter(int_0.ToString(), parameters[int_0], DataTypes.Object, ParameterDirection.Input, 0);
					int_0++;
				}
			}
			return this;
		}

		private void method_0(string string_0, object object_0)
		{
			IEnumerable enumerable = (IEnumerable)object_0;
			StringBuilder stringBuilder = new StringBuilder();
			int num = -1;
			foreach (object item in enumerable)
			{
				num++;
				if (num == 0)
				{
					stringBuilder.Append(" in(");
				}
				else
				{
					stringBuilder.Append(",");
				}
				IDbDataParameter dbDataParameter = method_1("p" + string_0 + "p" + num.ToString(), item, DataTypes.Object, ParameterDirection.Input, 0);
				stringBuilder.Append(dbDataParameter.ParameterName);
			}
			stringBuilder.Append(")");
			string oldValue = string.Format(" in({0})", Data.Context.Data.FluentDataProvider.GetParameterName(string_0));
			Data.Sql.Replace(oldValue, stringBuilder.ToString());
		}

		private IDbDataParameter method_1(string string_0, object object_0, DataTypes dataTypes_0 = DataTypes.Object, ParameterDirection parameterDirection_0 = ParameterDirection.Input, int int_1 = 0)
		{
			if (object_0 == null)
			{
				object_0 = DBNull.Value;
			}
			if (object_0.GetType().IsEnum)
			{
				object_0 = (int)object_0;
			}
			IDbDataParameter dbDataParameter = Data.InnerCommand.CreateParameter();
			if (dataTypes_0 == DataTypes.Object)
			{
				dbDataParameter.DbType = (DbType)Data.Context.Data.FluentDataProvider.GetDbTypeForClrType(object_0.GetType());
			}
			else
			{
				dbDataParameter.DbType = (DbType)dataTypes_0;
			}
			dbDataParameter.ParameterName = Data.Context.Data.FluentDataProvider.GetParameterName(string_0);
			dbDataParameter.Direction = (System.Data.ParameterDirection)parameterDirection_0;
			dbDataParameter.Value = object_0;
			if (int_1 > 0)
			{
				dbDataParameter.Size = int_1;
			}
			Data.InnerCommand.Parameters.Add(dbDataParameter);
			return dbDataParameter;
		}

		public IDbCommand ParameterOut(string name, DataTypes parameterType, int size)
		{
			if (!Data.Context.Data.FluentDataProvider.SupportsOutputParameters)
			{
				throw new FluentDataException("The selected database does not support output parameters");
			}
			Parameter(name, null, parameterType, ParameterDirection.Output, size);
			return this;
		}

		public TParameterType ParameterValue<TParameterType>(string outputParameterName)
		{
			outputParameterName = Data.Context.Data.FluentDataProvider.GetParameterName(outputParameterName);
			if (!Data.InnerCommand.Parameters.Contains(outputParameterName))
			{
				throw new FluentDataException(string.Format("Parameter {0} not found", outputParameterName));
			}
			object value = (Data.InnerCommand.Parameters[outputParameterName] as IDataParameter).Value;
			if (value == DBNull.Value)
			{
				return default(TParameterType);
			}
			return (TParameterType)value;
		}

		public TList QueryMany<TEntity, TList>(Action<TEntity, IDataReader> customMapper = null) where TList : IList<TEntity>
		{
			TList items = (TList)default(TList);
			Data.ExecuteQueryHandler.ExecuteQuery(true, delegate
			{
				items = (TList)new QueryHandler<TEntity>(Data).ExecuteMany<TList>(customMapper, null);
			});
			return (TList)items;
		}

		public TList QueryMany<TEntity, TList>(Action<TEntity, dynamic> customMapper) where TList : IList<TEntity>
		{
			TList items = (TList)default(TList);
			Data.ExecuteQueryHandler.ExecuteQuery(true, delegate
			{
				items = (TList)new QueryHandler<TEntity>(Data).ExecuteMany<TList>(null, customMapper);
			});
			return (TList)items;
		}

		public List<TEntity> QueryMany<TEntity>(Action<TEntity, IDataReader> customMapper)
		{
			return QueryMany<TEntity, List<TEntity>>(customMapper);
		}

		public List<TEntity> QueryMany<TEntity>(Action<TEntity, dynamic> customMapper)
		{
			return QueryMany<TEntity, List<TEntity>>(customMapper);
		}

		public DataTable QueryManyDataTable()
		{
			DataTable dataTable = new DataTable();
			Data.ExecuteQueryHandler.ExecuteQuery(true, delegate
			{
				dataTable.Load(Data.Reader.InnerReader, LoadOption.OverwriteChanges);
			});
			return dataTable;
		}

		public void QueryComplexMany<TEntity>(IList<TEntity> list, Action<IList<TEntity>, IDataReader> customMapper)
		{
			Data.ExecuteQueryHandler.ExecuteQuery(true, delegate
			{
				while (Data.Reader.Read())
				{
					customMapper(list, Data.Reader);
				}
			});
		}

		public void QueryComplexMany<TEntity>(IList<TEntity> list, Action<IList<TEntity>, dynamic> customMapper)
		{
			Data.ExecuteQueryHandler.ExecuteQuery(true, delegate
			{
				while (Data.Reader.Read())
				{
					customMapper(list, Data.Reader);
				}
			});
		}
	}
}
