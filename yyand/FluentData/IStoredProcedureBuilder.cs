using System;
using System.Linq.Expressions;

namespace FluentData
{
	public interface IStoredProcedureBuilder : IExecute, IDisposable, IQuery, IParameterValue
	{
		BuilderData Data
		{
			get;
		}

		IStoredProcedureBuilder Parameter(string name, object value, DataTypes parameterType = DataTypes.Object, int size = 0);

		IStoredProcedureBuilder ParameterOut(string name, DataTypes parameterType, int size = 0);

		IStoredProcedureBuilder UseMultiResult(bool useMultipleResultsets);
	}
	public interface IStoredProcedureBuilder<T> : IExecute, IDisposable, IQuery, IParameterValue
	{
		BuilderData Data
		{
			get;
		}

		IStoredProcedureBuilder<T> AutoMap(params Expression<Func<T, object>>[] ignoreProperties);

		IStoredProcedureBuilder<T> Parameter(Expression<Func<T, object>> expression, DataTypes parameterType = DataTypes.Object, int size = 0);

		IStoredProcedureBuilder<T> Parameter(string name, object value, DataTypes parameterType = DataTypes.Object, int size = 0);

		IStoredProcedureBuilder<T> ParameterOut(string name, DataTypes parameterType, int size = 0);

		IStoredProcedureBuilder<T> UseMultiResult(bool useMultipleResultsets);
	}
}
