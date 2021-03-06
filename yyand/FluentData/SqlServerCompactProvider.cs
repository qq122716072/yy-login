using FluentData.Providers.Common;
using FluentData.Providers.Common.Builders;
using System;
using System.Data;

namespace FluentData
{
	public class SqlServerCompactProvider : IDbProvider
	{
		public string ProviderName
		{
			get
			{
				return "System.Data.SqlServerCe.4.0";
			}
		}

		public bool SupportsOutputParameters
		{
			get
			{
				return false;
			}
		}

		public bool SupportsMultipleQueries
		{
			get
			{
				return false;
			}
		}

		public bool SupportsMultipleResultsets
		{
			get
			{
				return false;
			}
		}

		public bool SupportsStoredProcedures
		{
			get
			{
				return false;
			}
		}

		public bool RequiresIdentityColumn
		{
			get
			{
				return false;
			}
		}

		public IDbConnection CreateConnection(string connectionString)
		{
			return ConnectionFactory.CreateConnection(ProviderName, connectionString);
		}

		public string GetParameterName(string parameterName)
		{
			return "@" + parameterName;
		}

		public string GetSelectBuilderAlias(string name, string alias)
		{
			return name + " as " + alias;
		}

		public string GetSqlForSelectBuilder(SelectBuilderData data)
		{
			string text = "";
			text = "select " + data.Select;
			text = text + " from " + data.From;
			if (data.WhereSql.Length > 0)
			{
				text = text + " where " + data.WhereSql;
			}
			if (data.GroupBy.Length > 0)
			{
				text = text + " group by " + data.GroupBy;
			}
			if (data.Having.Length > 0)
			{
				text = text + " having " + data.Having;
			}
			if (data.OrderBy.Length > 0)
			{
				text = text + " order by " + data.OrderBy;
			}
			if (data.PagingItemsPerPage > 0)
			{
				object obj = text;
				text = obj + " offset " + (data.GetFromItems() - 1) + " rows";
				if (data.PagingItemsPerPage > 0)
				{
					object obj2 = text;
					text = obj2 + " fetch next " + data.PagingItemsPerPage + " rows only";
				}
			}
			return text;
		}

		public string GetSqlForInsertBuilder(BuilderData data)
		{
			return new InsertBuilderSqlGenerator().GenerateSql(this, "@", data);
		}

		public string GetSqlForUpdateBuilder(BuilderData data)
		{
			return new UpdateBuilderSqlGenerator().GenerateSql(this, "@", data);
		}

		public string GetSqlForDeleteBuilder(BuilderData data)
		{
			return new DeleteBuilderSqlGenerator().GenerateSql(this, "@", data);
		}

		public string GetSqlForStoredProcedureBuilder(BuilderData data)
		{
			throw new NotImplementedException();
		}

		public DataTypes GetDbTypeForClrType(Type clrType)
		{
			return new DbTypeMapper().GetDbTypeForClrType(clrType);
		}

		public object ExecuteReturnLastId<T>(IDbCommand command, string identityColumnName = null)
		{
			object lastId = null;
			command.Data.ExecuteQueryHandler.ExecuteQuery(false, delegate
			{
				int num = command.Data.InnerCommand.ExecuteNonQuery();
				if (num > 0)
				{
					command.Data.InnerCommand.CommandText = "select cast(@@identity as int)";
					lastId = command.Data.InnerCommand.ExecuteScalar();
				}
			});
			return lastId;
		}

		public void OnCommandExecuting(IDbCommand command)
		{
		}

		public string EscapeColumnName(string name)
		{
			if (name.Contains("["))
			{
				return name;
			}
			return "[" + name + "]";
		}
	}
}
