using System;
using System.Linq.Expressions;
using System.Reflection;

namespace FluentData
{
	internal class PropertyExpressionParser<T>
	{
		private readonly object object_0;

		private readonly PropertyInfo propertyInfo_0;

		public object Value
		{
			get
			{
				return ReflectionHelper.GetPropertyValue(object_0, propertyInfo_0);
			}
		}

		public string Name
		{
			get
			{
				return propertyInfo_0.Name;
			}
		}

		public Type Type
		{
			get
			{
				return ReflectionHelper.GetPropertyType(propertyInfo_0);
			}
		}

		public PropertyExpressionParser(object item, Expression<Func<T, object>> propertyExpression)
		{
			object_0 = item;
			propertyInfo_0 = smethod_0(propertyExpression);
		}

		private static PropertyInfo smethod_0(Expression<Func<T, object>> expression_0)
		{
			PropertyInfo propertyInfo = (expression_0.Body.NodeType != ExpressionType.Convert) ? (((MemberExpression)expression_0.Body).Member as PropertyInfo) : (((MemberExpression)((UnaryExpression)expression_0.Body).Operand).Member as PropertyInfo);
			if (!(propertyInfo != (PropertyInfo)null))
			{
				throw new ArgumentException(string.Format("Expression '{0}' does not refer to a property.", expression_0.ToString()));
			}
			return typeof(T).GetProperty(propertyInfo.Name);
		}
	}
}
