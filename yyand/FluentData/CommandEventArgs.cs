using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace FluentData
{
	public class CommandEventArgs : EventArgs
	{
		[CompilerGenerated]
		private System.Data.IDbCommand idbCommand_0;

		public System.Data.IDbCommand Command
		{
			get;
			private set;
		}

		public CommandEventArgs(System.Data.IDbCommand command)
		{
			Command = command;
		}
	}
}
