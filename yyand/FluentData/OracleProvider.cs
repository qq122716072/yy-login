using FluentData.Providers.Common;
using FluentData.Providers.Common.Builders;
using System;
using System.Data;

namespace FluentData
{
	public class OracleProvider : IDbProvider
	{
		public string ProviderName
		{
			get
			{
				return "Oracle.DataAccess.Client";
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
				return false;
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
				return true;
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
			return name + " " + alias;
		}

		public string GetSqlForSelectBuilder(SelectBuilderData data)
		{
			string text = "";
			if (data.PagingItemsPerPage == 0)
			{
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
			}
			else if (data.PagingItemsPerPage > 0)
			{
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
				text = string.Format("select * from\r\n\t\t\t\t\t\t\t\t\t\t(\r\n\t\t\t\t\t\t\t\t\t\t\tselect {0}, \r\n\t\t\t\t\t\t\t\t\t\t\t\trow_number() over (order by {1}) FLUENTDATA_ROWNUMBER\r\n\t\t\t\t\t\t\t\t\t\t\t{2}\r\n\t\t\t\t\t\t\t\t\t\t)\r\n\t\t\t\t\t\t\t\t\t\twhere fluentdata_RowNumber between {3} and {4}\r\n\t\t\t\t\t\t\t\t\t\torder by fluentdata_RowNumber", data.Select, data.OrderBy, text, data.GetFromItems(), data.GetToItems());
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
			command.ParameterOut("FluentDataLastId", command.Data.Context.Data.FluentDataProvider.GetDbTypeForClrType(typeof(T)), 0);
			command.Sql(" returning " + identityColumnName + " into :FluentDataLastId");
			object lastId = null;
			command.Data.ExecuteQueryHandler.ExecuteQuery(false, delegate
			{
				command.Data.InnerCommand.ExecuteNonQuery();
				lastId = ((IParameterValue)command).ParameterValue<object>("FluentDataLastId");
			});
			return lastId;
		}

		public void OnCommandExecuting(IDbCommand command)
		{
			if (command.Data.InnerCommand.CommandType == CommandType.Text)
			{
				dynamic innerCommand = command.Data.InnerCommand;
				innerCommand.BindByName = true;
			}
		}

		public string EscapeColumnName(string name)
		{
			return name;
		}
	}
}
