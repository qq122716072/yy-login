using System;
using System.Linq.Expressions;

namespace FluentData
{
	public interface GInterface1<T>
	{
		BuilderData Data
		{
			get;
		}

		T Item
		{
			get;
		}

		GInterface1<T> Column(string columnName, object value, DataTypes parameterType = DataTypes.Object, int size = 0);

		GInterface1<T> Column(Expression<Func<T, object>> expression, DataTypes parameterType = DataTypes.Object, int size = 0);
	}
}
