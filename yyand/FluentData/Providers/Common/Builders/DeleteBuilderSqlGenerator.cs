namespace FluentData.Providers.Common.Builders
{
	internal class DeleteBuilderSqlGenerator
	{
		public string GenerateSql(IDbProvider provider, string parameterPrefix, BuilderData data)
		{
			string text = "";
			foreach (BuilderColumn column in data.Columns)
			{
				if (text.Length > 0)
				{
					text += " and ";
				}
				text += string.Format("{0} = {1}{2}", provider.EscapeColumnName(column.ColumnName), parameterPrefix, column.ParameterName);
			}
			return string.Format("delete from {0} where {1}", data.ObjectName, text);
		}
	}
}
