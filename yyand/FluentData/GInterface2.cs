namespace FluentData
{
	public interface GInterface2
	{
		T ExecuteReturnLastId<T>(string identityColumnName = null);
	}
}
