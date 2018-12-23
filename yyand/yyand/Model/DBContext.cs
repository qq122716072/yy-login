using FluentData;
using System;
using System.Windows.Forms;

namespace ZHANHUO.Model
{
	public class DBContext
	{
		public static IDbContext GetContext()
		{
			try
			{
				string connectionString = string.Format("Data Source=C:\\Users\\manager\\Desktop\\testsl\\ZhanHuo.db;Pooling=true;FailIfMissing=false", Application.StartupPath);
				return new DbContext().ConnectionString(connectionString, (IDbProvider)new SqliteProvider(), (string)null);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
