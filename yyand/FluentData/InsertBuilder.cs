using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace FluentData
{
	internal class InsertBuilder : BaseInsertBuilder, IExecute, GInterface0, GInterface2, IInsertBuilder
	{
		internal InsertBuilder(IDbCommand command, string name)
			: base(command, name)
		{
		}

		public IInsertBuilder Column(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}

		GInterface0 GInterface0.Column(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}

		public IInsertBuilder Fill(Action<GInterface0> fillMethod)
		{
			fillMethod(this);
			return this;
		}
	}
	internal class InsertBuilder<T> : BaseInsertBuilder, IInsertBuilder<T>, GInterface1<T>, IExecute, GInterface2
	{
		[CompilerGenerated]
		private T gparam_0;

		public T Item
		{
			get;
			private set;
		}

		internal InsertBuilder(IDbCommand command, string name, T item)
			: base(command, name)
		{
			base.Data.Item = item;
			Item = item;
		}

		public IInsertBuilder<T> Column(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}

		public IInsertBuilder<T> Column(Expression<Func<T, object>> expression, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction<T>(expression, parameterType, size);
			return this;
		}

		public IInsertBuilder<T> Fill(Action<GInterface1<T>> fillMethod)
		{
			fillMethod(this);
			return this;
		}

		public IInsertBuilder<T> AutoMap(params Expression<Func<T, object>>[] ignoreProperties)
		{
			base.Actions.AutoMapColumnsAction<T>(ignoreProperties);
			return this;
		}

		GInterface1<T> GInterface1<T>.Column(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}

		GInterface1<T> GInterface1<T>.Column(Expression<Func<T, object>> expression, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction<T>(expression, parameterType, size);
			return this;
		}
	}
}
