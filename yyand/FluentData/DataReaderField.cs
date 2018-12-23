using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FluentData
{
	internal class DataReaderField
	{
		private readonly string[] string_0;

		private readonly int int_0;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private Type type_0;

		public int Index
		{
			get;
			private set;
		}

		public string LowerName
		{
			get;
			private set;
		}

		public string Name
		{
			get;
			private set;
		}

		public Type Type
		{
			get;
			private set;
		}

		public int NestedLevels
		{
			get
			{
				return int_0;
			}
		}

		public bool IsSystem
		{
			get
			{
				return Name.IndexOf("FLUENTDATA_") > -1;
			}
		}

		public DataReaderField(int index, string name, Type type)
		{
			Index = index;
			Name = name;
			LowerName = name.ToLower();
			Type = type;
			string_0 = LowerName.Split('_');
			int_0 = string_0.Count() - 1;
		}

		public string GetNestedName(int level)
		{
			return string_0[level];
		}
	}
}
