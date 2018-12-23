using System.Runtime.CompilerServices;

namespace FluentData
{
	public class BuilderColumn
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private object object_0;

		public string ColumnName
		{
			get;
			set;
		}

		public string ParameterName
		{
			get;
			set;
		}

		public object Value
		{
			get;
			set;
		}

		public BuilderColumn(string columnName, object value, string parameterName)
		{
			ColumnName = columnName;
			Value = value;
			ParameterName = parameterName;
		}
	}
}
