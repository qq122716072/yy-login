using System.Data;
using System.Data.Common;

namespace FluentData.Providers.Common
{
	internal class ConnectionFactory
	{
		public static IDbConnection CreateConnection(string providerName, string connectionString)
		{
			DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);
			DbConnection dbConnection = factory.CreateConnection();
			dbConnection.ConnectionString = connectionString;
			return dbConnection;
		}
	}
}
