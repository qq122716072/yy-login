using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FluentData
{
	public class BuilderData
	{
		[CompilerGenerated]
		private List<BuilderColumn> list_0;

		[CompilerGenerated]
		private object object_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private IDbCommand idbCommand_0;

		[CompilerGenerated]
		private List<BuilderColumn> list_1;

		public List<BuilderColumn> Columns
		{
			get;
			set;
		}

		public object Item
		{
			get;
			set;
		}

		public string ObjectName
		{
			get;
			set;
		}

		public IDbCommand Command
		{
			get;
			set;
		}

		public List<BuilderColumn> Where
		{
			get;
			set;
		}

		public BuilderData(IDbCommand command, string objectName)
		{
			ObjectName = objectName;
			Command = command;
			Columns = new List<BuilderColumn>();
			Where = new List<BuilderColumn>();
		}
	}
}
