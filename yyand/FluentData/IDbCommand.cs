using System;

namespace FluentData
{
	public interface IDbCommand : IExecute, GInterface2, IDisposable, IQuery, IParameterValue
	{
		DbCommandData Data
		{
			get;
		}

		IDbCommand ClearSql
		{
			get;
		}

		IDbCommand ParameterOut(string name, DataTypes parameterType, int size = 0);

		IDbCommand Parameter(string name, object value, DataTypes parameterType = DataTypes.Object, ParameterDirection direction = ParameterDirection.Input, int size = 0);

		IDbCommand Parameters(params object[] parameters);

		IDbCommand Sql(string sql);

		IDbCommand CommandType(DbCommandTypes dbCommandType);

		IDbCommand UseMultiResult(bool useMultipleResultsets);
	}
}
