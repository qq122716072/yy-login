using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace FluentData.Providers.Common
{
	internal class DbTypeMapper
	{
		private static Dictionary<Type, DataTypes> dictionary_0;

		private static readonly object object_0;

		public DataTypes GetDbTypeForClrType(Type clrType)
		{
			if (dictionary_0 == null)
			{
				lock (object_0)
				{
					if (dictionary_0 == null)
					{
						dictionary_0 = new Dictionary<Type, DataTypes>();
						dictionary_0.Add(typeof(short), DataTypes.Int16);
						dictionary_0.Add(typeof(int), DataTypes.Int32);
						dictionary_0.Add(typeof(long), DataTypes.Int64);
						dictionary_0.Add(typeof(string), DataTypes.String);
						dictionary_0.Add(typeof(DateTime), DataTypes.DateTime);
						dictionary_0.Add(typeof(XDocument), DataTypes.Xml);
						dictionary_0.Add(typeof(decimal), DataTypes.Decimal);
						dictionary_0.Add(typeof(Guid), DataTypes.Guid);
						dictionary_0.Add(typeof(bool), DataTypes.Boolean);
						dictionary_0.Add(typeof(char), DataTypes.String);
						dictionary_0.Add(typeof(DBNull), DataTypes.String);
						dictionary_0.Add(typeof(float), DataTypes.Single);
						dictionary_0.Add(typeof(double), DataTypes.Double);
						dictionary_0.Add(typeof(byte[]), DataTypes.Binary);
					}
				}
			}
			if (!dictionary_0.ContainsKey(clrType))
			{
				return DataTypes.Object;
			}
			return dictionary_0[clrType];
		}

		static DbTypeMapper()
		{
			object_0 = new object();
		}
	}
}
