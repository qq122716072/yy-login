using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace FluentData
{
	public class ConnectionEventArgs : EventArgs
	{
		[CompilerGenerated]
		private IDbConnection idbConnection_0;

		public IDbConnection Connection
		{
			get;
			private set;
		}

		public ConnectionEventArgs(IDbConnection connection)
		{
			Connection = connection;
		}
	}
}
