namespace FluentData.Providers.Common.Builders
{
	internal class UpdateBuilderSqlGenerator
	{
		public string GenerateSql(IDbProvider provider, string parameterPrefix, BuilderData data)
		{
			string text = "";
			foreach (BuilderColumn column in data.Columns)
			{
				if (text.Length > 0)
				{
					text += ", ";
				}
				text += string.Format("{0} = {1}{2}", provider.EscapeColumnName(column.ColumnName), parameterPrefix, column.ParameterName);
			}
			string text2 = "";
			foreach (BuilderColumn item in data.Where)
			{
				if (text2.Length > 0)
				{
					text2 += " and ";
				}
				text2 += string.Format("{0} = {1}{2}", provider.EscapeColumnName(item.ColumnName), parameterPrefix, item.ParameterName);
			}
			return string.Format("update {0} set {1} where {2}", data.ObjectName, text, text2);
		}
	}
}
