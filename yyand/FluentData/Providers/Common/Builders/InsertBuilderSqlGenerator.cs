namespace FluentData.Providers.Common.Builders
{
	internal class InsertBuilderSqlGenerator
	{
		public string GenerateSql(IDbProvider provider, string parameterPrefix, BuilderData data)
		{
			string text = "";
			string text2 = "";
			foreach (BuilderColumn column in data.Columns)
			{
				if (text.Length > 0)
				{
					text += ",";
					text2 += ",";
				}
				text += provider.EscapeColumnName(column.ColumnName);
				text2 = text2 + parameterPrefix + column.ParameterName;
			}
			return string.Format("insert into {0}({1}) values({2})", data.ObjectName, text, text2);
		}
	}
}
