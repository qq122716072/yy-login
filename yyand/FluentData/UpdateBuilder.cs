using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace FluentData
{
	internal class UpdateBuilder : BaseUpdateBuilder, IExecute, GInterface0, IUpdateBuilder
	{
		internal UpdateBuilder(IDbProvider dbProvider, IDbCommand command, string name)
			: base(dbProvider, command, name)
		{
		}

		public virtual IUpdateBuilder Where(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.WhereAction(columnName, value, parameterType, size);
			return this;
		}

		public IUpdateBuilder Column(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}

		GInterface0 GInterface0.Column(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}

		public IUpdateBuilder Fill(Action<GInterface0> fillMethod)
		{
			fillMethod(this);
			return this;
		}
	}
	internal class UpdateBuilder<T> : BaseUpdateBuilder, GInterface1<T>, IUpdateBuilder<T>, IExecute
	{
		[CompilerGenerated]
		private T gparam_0;

		public T Item
		{
			get;
			private set;
		}

		internal UpdateBuilder(IDbProvider provider, IDbCommand command, string name, T item)
			: base(provider, command, name)
		{
			base.Data.Item = item;
			Item = item;
		}

		public IUpdateBuilder<T> Column(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}

		public IUpdateBuilder<T> AutoMap(params Expression<Func<T, object>>[] ignoreProperties)
		{
			base.Actions.AutoMapColumnsAction<T>(ignoreProperties);
			return this;
		}

		public IUpdateBuilder<T> Column(Expression<Func<T, object>> expression, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction<T>(expression, parameterType, size);
			return this;
		}

		public virtual IUpdateBuilder<T> Where(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.WhereAction(columnName, value, parameterType, size);
			return this;
		}

		public IUpdateBuilder<T> Where(Expression<Func<T, object>> expression, DataTypes parameterType, int size)
		{
			base.Actions.WhereAction<T>(expression, parameterType, size);
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

		public IUpdateBuilder<T> Fill(Action<GInterface1<T>> fillMethod)
		{
			fillMethod(this);
			return this;
		}
	}
}
