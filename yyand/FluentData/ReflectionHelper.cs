using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace FluentData
{
	internal static class ReflectionHelper
	{
		private static readonly ConcurrentDictionary<Type, Dictionary<string, PropertyInfo>> concurrentDictionary_0;

		public static string GetPropertyNameFromExpression<T>(Expression<Func<T, object>> expression)
		{
			string text = null;
			if (expression.Body is UnaryExpression)
			{
				UnaryExpression unaryExpression = (UnaryExpression)expression.Body;
				if (unaryExpression.NodeType == ExpressionType.Convert)
				{
					text = unaryExpression.Operand.ToString();
				}
			}
			if (text == null)
			{
				text = expression.Body.ToString();
			}
			return text.Replace(expression.Parameters[0] + ".", string.Empty);
		}

		public static List<string> GetPropertyNamesFromExpressions<T>(Expression<Func<T, object>>[] expressions)
		{
			List<string> list = new List<string>();
			foreach (Expression<Func<T, object>> expression in expressions)
			{
				string propertyNameFromExpression = GetPropertyNameFromExpression(expression);
				list.Add(propertyNameFromExpression);
			}
			return list;
		}

		public static object GetPropertyValue(object item, PropertyInfo property)
		{
			return property.GetValue(item, null);
		}

		public static object GetPropertyValue(object item, string propertyName)
		{
			string[] array = propertyName.Split('.');
			int num = 0;
			while (true)
			{
				if (num >= array.Length)
				{
					return item;
				}
				string name = array[num];
				if (item == null)
				{
					break;
				}
				Type type = item.GetType();
				PropertyInfo property = type.GetProperty(name);
				if (property == (PropertyInfo)null)
				{
					return null;
				}
				item = GetPropertyValue(item, property);
				num++;
			}
			return null;
		}

		public static object GetPropertyValueDynamic(object item, string name)
		{
			IDictionary<string, object> dictionary = (IDictionary<string, object>)item;
			return dictionary[name];
		}

		public static Dictionary<string, PropertyInfo> GetProperties(Type type)
		{
			return concurrentDictionary_0.GetOrAdd(type, smethod_0);
		}

		private static Dictionary<string, PropertyInfo> smethod_0(Type type_0)
		{
			Dictionary<string, PropertyInfo> dictionary = new Dictionary<string, PropertyInfo>();
			PropertyInfo[] properties = type_0.GetProperties();
			PropertyInfo[] array = properties;
			foreach (PropertyInfo propertyInfo in array)
			{
				dictionary.Add(propertyInfo.Name.ToLower(), propertyInfo);
			}
			return dictionary;
		}

		public static bool IsList(object item)
		{
			if (item is ICollection)
			{
				return true;
			}
			return false;
		}

		public static bool IsNullable(PropertyInfo property)
		{
			if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				return true;
			}
			return false;
		}

		public static Type GetPropertyType(PropertyInfo property)
		{
			if (IsNullable(property))
			{
				return property.PropertyType.GetGenericArguments()[0];
			}
			return property.PropertyType;
		}

		public static object GetDefault(Type type)
		{
			if (type.IsValueType)
			{
				return Activator.CreateInstance(type);
			}
			return null;
		}

		public static bool IsBasicClrType(Type type)
		{
			if (!type.IsEnum && !type.IsPrimitive && !type.IsValueType && !(type == typeof(string)) && !(type == typeof(DateTime)))
			{
				return false;
			}
			return true;
		}

		public static bool IsCustomEntity<T>()
		{
			Type typeFromHandle = typeof(T);
			if (typeFromHandle.IsClass && Type.GetTypeCode(typeFromHandle) == TypeCode.Object)
			{
				return true;
			}
			return false;
		}

		static ReflectionHelper()
		{
			concurrentDictionary_0 = new ConcurrentDictionary<Type, Dictionary<string, PropertyInfo>>();
		}
	}
}
