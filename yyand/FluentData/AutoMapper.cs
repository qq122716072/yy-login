using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace FluentData
{
	internal class AutoMapper
	{
		private readonly DbCommandData dbCommandData_0;

		private readonly Dictionary<string, PropertyInfo> dictionary_0;

		private readonly List<DataReaderField> list_0;

		private readonly System.Data.IDataReader idataReader_0;

		internal AutoMapper(DbCommandData dbCommandData, Type itemType)
		{
			dbCommandData_0 = dbCommandData;
			idataReader_0 = dbCommandData.Reader.InnerReader;
			dictionary_0 = ReflectionHelper.GetProperties(itemType);
			list_0 = DataReaderHelper.GetDataReaderFields(idataReader_0);
		}

		public void AutoMap(object item)
		{
			foreach (DataReaderField item2 in list_0)
			{
				if (!item2.IsSystem)
				{
					object value = idataReader_0.GetValue(item2.Index);
					bool flag = false;
					PropertyInfo value2 = null;
					if (dictionary_0.TryGetValue(item2.LowerName, out value2))
					{
						method_2(item2, value2, item, value);
						flag = true;
					}
					else if (item2.LowerName.IndexOf('_') != -1)
					{
						flag = method_0(item, item2, value);
					}
					if (!flag && !dbCommandData_0.Context.Data.IgnoreIfAutoMapFails)
					{
						throw new FluentDataException("Could not map: " + item2.Name);
					}
				}
			}
		}

		private bool method_0(object object_0, DataReaderField dataReaderField_0, object object_1)
		{
			string text = null;
			int num = 0;
			while (true)
			{
				if (num > dataReaderField_0.NestedLevels)
				{
					return false;
				}
				text = ((!string.IsNullOrEmpty(text)) ? (text + "_" + dataReaderField_0.GetNestedName(num)) : dataReaderField_0.GetNestedName(num));
				PropertyInfo value = null;
				Dictionary<string, PropertyInfo> properties = ReflectionHelper.GetProperties(object_0.GetType());
				if (properties.TryGetValue(text, out value))
				{
					if (num == dataReaderField_0.NestedLevels)
					{
						method_2(dataReaderField_0, value, object_0, object_1);
						return true;
					}
					object_0 = method_1(object_0, value);
					if (object_0 == null)
					{
						break;
					}
					text = null;
				}
				num++;
			}
			return false;
		}

		private object method_1(object object_0, PropertyInfo propertyInfo_0)
		{
			object obj = ReflectionHelper.GetPropertyValue(object_0, propertyInfo_0);
			if (obj == null)
			{
				obj = dbCommandData_0.Context.Data.EntityFactory.Create(propertyInfo_0.PropertyType);
				propertyInfo_0.SetValue(object_0, obj, null);
			}
			return obj;
		}

		private void method_2(DataReaderField dataReaderField_0, PropertyInfo propertyInfo_0, object object_0, object object_1)
		{
			try
			{
				if (object_1 == DBNull.Value)
				{
					object_1 = ((!ReflectionHelper.IsNullable(propertyInfo_0)) ? ReflectionHelper.GetDefault(propertyInfo_0.PropertyType) : null);
					goto IL_00b4;
				}
				Type propertyType = ReflectionHelper.GetPropertyType(propertyInfo_0);
				if (!(propertyType != dataReaderField_0.Type))
				{
					goto IL_00b4;
				}
				if (propertyType.IsEnum)
				{
					object_1 = ((!(dataReaderField_0.Type == typeof(string))) ? Enum.ToObject(propertyType, object_1) : Enum.Parse(propertyType, (string)object_1, true));
					goto IL_00b4;
				}
				if (ReflectionHelper.IsBasicClrType(propertyType))
				{
					object_1 = ((!(propertyType == typeof(string))) ? Convert.ChangeType(object_1, propertyInfo_0.PropertyType) : object_1.ToString());
					goto IL_00b4;
				}
				goto end_IL_0001;
				IL_00b4:
				propertyInfo_0.SetValue(object_0, object_1, null);
				end_IL_0001:;
			}
			catch (Exception innerException)
			{
				throw new FluentDataException("Could not map: " + propertyInfo_0.Name, innerException);
			}
		}
	}
}
