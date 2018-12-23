using FluentData.Providers.Common;
using FluentData.Providers.Common.Builders;
using System;
using System.Data;
using System.Text;

namespace FluentData
{
	public class SqlServerProvider : IDbProvider
	{
		public string ProviderName
		{
			get
			{
				return "System.Data.SqlClient";
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
			return "@" + parameterName;
		}

		public string GetSelectBuilderAlias(string name, string alias)
		{
			return name + " as " + alias;
		}

		public string GetSqlForSelectBuilder(SelectBuilderData data)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (data.PagingCurrentPage == 1)
			{
				if (data.PagingItemsPerPage == 0)
				{
					stringBuilder.Append("select");
				}
				else
				{
					stringBuilder.Append("select top " + data.PagingItemsPerPage.ToString());
				}
				stringBuilder.Append(" " + data.Select);
				stringBuilder.Append(" from " + data.From);
				if (data.WhereSql.Length > 0)
				{
					stringBuilder.Append(" where " + data.WhereSql);
				}
				if (data.GroupBy.Length > 0)
				{
					stringBuilder.Append(" group by " + data.GroupBy);
				}
				if (data.Having.Length > 0)
				{
					stringBuilder.Append(" having " + data.Having);
				}
				if (data.OrderBy.Length > 0)
				{
					stringBuilder.Append(" order by " + data.OrderBy);
				}
				return stringBuilder.ToString();
			}
			stringBuilder.Append(" from " + data.From);
			if (data.WhereSql.Length > 0)
			{
				stringBuilder.Append(" where " + data.WhereSql);
			}
			if (data.GroupBy.Length > 0)
			{
				stringBuilder.Append(" group by " + data.GroupBy);
			}
			if (data.Having.Length > 0)
			{
				stringBuilder.Append(" having " + data.Having);
			}
			return string.Format("with PagedPersons as\r\n\t\t\t\t\t\t\t\t(\r\n\t\t\t\t\t\t\t\t\tselect top 100 percent {0}, row_number() over (order by {1}) as FLUENTDATA_ROWNUMBER\r\n\t\t\t\t\t\t\t\t\t{2}\r\n\t\t\t\t\t\t\t\t)\r\n\t\t\t\t\t\t\t\tselect *\r\n\t\t\t\t\t\t\t\tfrom PagedPersons\r\n\t\t\t\t\t\t\t\twhere fluentdata_RowNumber between {3} and {4}", data.Select, data.OrderBy, stringBuilder, data.GetFromItems(), data.GetToItems());
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
			command.Sql("select SCOPE_IDENTITY()");
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
			if (name.Contains("["))
			{
				return name;
			}
			return "[" + name + "]";
		}
	}
}
