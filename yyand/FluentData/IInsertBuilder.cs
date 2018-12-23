using System;
using System.Linq.Expressions;

namespace FluentData
{
	public interface IInsertBuilder : IExecute, GInterface2
	{
		BuilderData Data
		{
			get;
		}

		IInsertBuilder Column(string columnName, object value, DataTypes parameterType = DataTypes.Object, int size = 0);

		IInsertBuilder Fill(Action<GInterface0> fillMethod);
	}
	public interface IInsertBuilder<T> : IExecute, GInterface2
	{
		BuilderData Data
		{
			get;
		}

		T Item
		{
			get;
		}

		IInsertBuilder<T> AutoMap(params Expression<Func<T, object>>[] ignoreProperties);

		IInsertBuilder<T> Column(string columnName, object value, DataTypes parameterType = DataTypes.Object, int size = 0);

		IInsertBuilder<T> Column(Expression<Func<T, object>> expression, DataTypes parameterType = DataTypes.Object, int size = 0);

		IInsertBuilder<T> Fill(Action<GInterface1<T>> fillMethod);
	}
}
