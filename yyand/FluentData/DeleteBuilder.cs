using System;
using System.Linq.Expressions;

namespace FluentData
{
	internal class DeleteBuilder : BaseDeleteBuilder, IExecute, IDeleteBuilder
	{
		public DeleteBuilder(IDbCommand command, string tableName)
			: base(command, tableName)
		{
		}

		public IDeleteBuilder Where(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}
	}
	internal class DeleteBuilder<T> : BaseDeleteBuilder, IDeleteBuilder<T>, IExecute
	{
		public DeleteBuilder(IDbCommand command, string tableName, T item)
			: base(command, tableName)
		{
			base.Data.Item = item;
		}

		public IDeleteBuilder<T> Where(Expression<Func<T, object>> expression, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction<T>(expression, parameterType, size);
			return this;
		}

		public IDeleteBuilder<T> Where(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}
	}
}
