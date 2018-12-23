using FluentData.Providers.Common;
using FluentData.Providers.Common.Builders;
using System;
using System.Data;

namespace FluentData
{
	public class PostgreSqlProvider : IDbProvider
	{
		public string ProviderName
		{
			get
			{
				return "Npgsql";
			}
		}

		public bool SupportsOutputParameters
		{
			get
			{
				return true;
			}
		}

		public bool SupportsMultipleResultsets
		{
			get
			{
				return true;
			}
		}

		public bool SupportsMultipleQueries
		{
			get
			{
				return true;
			}
		}

		public bool SupportsStoredProcedures
		{
			get
			{
				return true;
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
			return ":" + parameterName;
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
				if (data.PagingItemsPerPage > 0)
				{
					text = text + " limit " + data.PagingItemsPerPage;
				}
				text = text + " offset " + (data.GetFromItems() - 1);
			}
			return text;
		}

		public string GetSqlForInsertBuilder(BuilderData data)
		{
			return new InsertBuilderSqlGenerator().GenerateSql(this, ":", data);
		}

		public string GetSqlForUpdateBuilder(BuilderData data)
		{
			return new UpdateBuilderSqlGenerator().GenerateSql(this, ":", data);
		}

		public string GetSqlForDeleteBuilder(BuilderData data)
		{
			return new DeleteBuilderSqlGenerator().GenerateSql(this, ":", data);
		}

		public string GetSqlForStoredProcedureBuilder(BuilderData data)
		{
			return data.ObjectName;
		}

		public DataTypes GetDbTypeForClrType(Type clrType)
		{
			return new DbTypeMapper().GetDbTypeForClrType(clrType);
		}

		public object ExecuteReturnLastId<T>(IDbCommand command, string identityColumnName = null)
		{
			if (command.Data.Sql[command.Data.Sql.Length - 1] != ';')
			{
				command.Sql(";");
			}
			System.Data.IDbCommand innerCommand = command.Data.InnerCommand;
			innerCommand.CommandText += "select lastval();";
			object lastId = null;
			command.Data.ExecuteQueryHandler.ExecuteQuery(false, delegate
			{
				lastId = command.Data.InnerCommand.ExecuteScalar();
			});
			return lastId;
		}

		public void OnCommandExecuting(IDbCommand command)
		{
		}

		public string EscapeColumnName(string name)
		{
			return name;
		}
	}
}
