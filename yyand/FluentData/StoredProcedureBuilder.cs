using System;
using System.Linq.Expressions;

namespace FluentData
{
	internal class StoredProcedureBuilder : BaseStoredProcedureBuilder, IExecute, IDisposable, IQuery, IParameterValue, IStoredProcedureBuilder
	{
		internal StoredProcedureBuilder(IDbCommand command, string name)
			: base(command, name)
		{
		}

		public IStoredProcedureBuilder Parameter(string name, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(name, value, parameterType, size);
			return this;
		}

		public IStoredProcedureBuilder ParameterOut(string name, DataTypes parameterType, int size = 0)
		{
			base.Actions.ParameterOutputAction(name, parameterType, size);
			return this;
		}

		public IStoredProcedureBuilder UseMultiResult(bool useMultipleResultsets)
		{
			base.Data.Command.UseMultiResult(useMultipleResultsets);
			return this;
		}
	}
	internal class StoredProcedureBuilder<T> : BaseStoredProcedureBuilder, IStoredProcedureBuilder<T>, IExecute, IDisposable, IQuery, IParameterValue
	{
		internal StoredProcedureBuilder(IDbCommand command, string name, T item)
			: base(command, name)
		{
			base.Data.Item = item;
		}

		public IStoredProcedureBuilder<T> Parameter(string name, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(name, value, parameterType, size);
			return this;
		}

		public IStoredProcedureBuilder<T> AutoMap(params Expression<Func<T, object>>[] ignoreProperties)
		{
			base.Actions.AutoMapColumnsAction<T>(ignoreProperties);
			return this;
		}

		public IStoredProcedureBuilder<T> Parameter(Expression<Func<T, object>> expression, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction<T>(expression, parameterType, size);
			return this;
		}

		public IStoredProcedureBuilder<T> ParameterOut(string name, DataTypes parameterType, int size = 0)
		{
			base.Actions.ParameterOutputAction(name, parameterType, size);
			return this;
		}

		public IStoredProcedureBuilder<T> UseMultiResult(bool useMultipleResultsets)
		{
			base.Data.Command.UseMultiResult(useMultipleResultsets);
			return this;
		}
	}
}
