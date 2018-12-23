using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FluentData
{
	internal class ActionsHandler
	{
		private bool bool_0;

		private readonly BuilderData builderData_0;

		internal ActionsHandler(BuilderData data)
		{
			builderData_0 = data;
		}

		internal void ColumnValueAction(string columnName, object value, DataTypes parameterType, int size)
		{
			method_0(columnName, value, typeof(object), parameterType, size);
		}

		private void method_0(string string_0, object object_0, Type type_0, DataTypes dataTypes_0, int int_0)
		{
			builderData_0.Columns.Add(new BuilderColumn(string_0, object_0, string_0));
			if (dataTypes_0 == DataTypes.Object)
			{
				dataTypes_0 = builderData_0.Command.Data.Context.Data.FluentDataProvider.GetDbTypeForClrType(type_0);
			}
			method_2(string_0, object_0, dataTypes_0, ParameterDirection.Input, int_0);
		}

		internal void ColumnValueAction<T>(Expression<Func<T, object>> expression, DataTypes parameterType, int size)
		{
			PropertyExpressionParser<T> propertyExpressionParser = new PropertyExpressionParser<T>(builderData_0.Item, expression);
			method_0(propertyExpressionParser.Name, propertyExpressionParser.Value, propertyExpressionParser.Type, parameterType, size);
		}

		internal void ColumnValueDynamic(ExpandoObject item, string propertyName, DataTypes parameterType, int size)
		{
			object object_ = ((IDictionary<string, object>)item)[propertyName];
			method_0(propertyName, object_, typeof(object), parameterType, size);
		}

		private void method_1()
		{
			if (bool_0)
			{
				throw new FluentDataException("AutoMap cannot be called more than once.");
			}
			bool_0 = true;
		}

		internal void AutoMapColumnsAction<T>(params Expression<Func<T, object>>[] ignorePropertyExpressions)
		{
			method_1();
			Dictionary<string, PropertyInfo> properties = ReflectionHelper.GetProperties(builderData_0.Item.GetType());
			HashSet<string> hashSet = new HashSet<string>();
			if (ignorePropertyExpressions != null)
			{
				foreach (Expression<Func<T, object>> propertyExpression in ignorePropertyExpressions)
				{
					string name = new PropertyExpressionParser<T>(builderData_0.Item, propertyExpression).Name;
					hashSet.Add(name);
				}
			}
			using (Dictionary<string, PropertyInfo>.Enumerator enumerator = properties.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Func<string, bool> func = null;
					KeyValuePair<string, PropertyInfo> property = enumerator.Current;
					HashSet<string> source = hashSet;
					func = delegate(string x)
					{
						KeyValuePair<string, PropertyInfo> keyValuePair4 = property;
						return x.Equals(keyValuePair4.Value.Name, StringComparison.CurrentCultureIgnoreCase);
					};
					string text = source.SingleOrDefault(func);
					if (text == null)
					{
						KeyValuePair<string, PropertyInfo> keyValuePair = property;
						Type propertyType = ReflectionHelper.GetPropertyType(keyValuePair.Value);
						object item = builderData_0.Item;
						KeyValuePair<string, PropertyInfo> keyValuePair2 = property;
						object propertyValue = ReflectionHelper.GetPropertyValue(item, keyValuePair2.Value);
						KeyValuePair<string, PropertyInfo> keyValuePair3 = property;
						method_0(keyValuePair3.Value.Name, propertyValue, propertyType, DataTypes.Object, 0);
					}
				}
			}
		}

		internal void AutoMapDynamicTypeColumnsAction(params string[] ignorePropertyExpressions)
		{
			method_1();
			IDictionary<string, object> dictionary = (IDictionary<string, object>)builderData_0.Item;
			HashSet<string> hashSet = new HashSet<string>();
			if (ignorePropertyExpressions != null)
			{
				foreach (string item in ignorePropertyExpressions)
				{
					hashSet.Add(item);
				}
			}
			using (IEnumerator<KeyValuePair<string, object>> enumerator = dictionary.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Func<string, bool> func = null;
					KeyValuePair<string, object> property = enumerator.Current;
					HashSet<string> source = hashSet;
					func = delegate(string x)
					{
						KeyValuePair<string, object> keyValuePair3 = property;
						return x.Equals(keyValuePair3.Key, StringComparison.CurrentCultureIgnoreCase);
					};
					string text = source.SingleOrDefault(func);
					if (text == null)
					{
						KeyValuePair<string, object> keyValuePair = property;
						string key = keyValuePair.Key;
						KeyValuePair<string, object> keyValuePair2 = property;
						method_0(key, keyValuePair2.Value, typeof(object), DataTypes.Object, 0);
					}
				}
			}
		}

		private void method_2(string string_0, object object_0, DataTypes dataTypes_0, ParameterDirection parameterDirection_0, int int_0)
		{
			builderData_0.Command.Parameter(string_0, object_0, dataTypes_0, parameterDirection_0, int_0);
		}

		internal void ParameterOutputAction(string name, DataTypes dataTypes, int size)
		{
			method_2(name, null, dataTypes, ParameterDirection.Output, size);
		}

		internal void WhereAction(string columnName, object value, DataTypes parameterType, int size)
		{
			method_2(columnName, value, parameterType, ParameterDirection.Input, 0);
			builderData_0.Where.Add(new BuilderColumn(columnName, value, columnName));
		}

		internal void WhereAction<T>(Expression<Func<T, object>> expression, DataTypes parameterType, int size)
		{
			PropertyExpressionParser<T> propertyExpressionParser = new PropertyExpressionParser<T>(builderData_0.Item, expression);
			WhereAction(propertyExpressionParser.Name, propertyExpressionParser.Value, parameterType, size);
		}
	}
}
