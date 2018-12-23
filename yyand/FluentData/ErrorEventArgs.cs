using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace FluentData
{
	public class ErrorEventArgs : EventArgs
	{
		[CompilerGenerated]
		private System.Data.IDbCommand idbCommand_0;

		[CompilerGenerated]
		private Exception exception_0;

		public System.Data.IDbCommand Command
		{
			get;
			private set;
		}

		public Exception Exception
		{
			get;
			set;
		}

		public ErrorEventArgs(System.Data.IDbCommand command, Exception exception)
		{
			Command = command;
			Exception = exception;
		}
	}
}
