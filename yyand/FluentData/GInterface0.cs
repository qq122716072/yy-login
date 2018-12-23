namespace FluentData
{
	public interface GInterface0
	{
		BuilderData Data
		{
			get;
		}

		GInterface0 Column(string columnName, object value, DataTypes parameterType = DataTypes.Object, int size = 0);
	}
}
