using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ZHANHUO.Model
{
	public class duoip
	{
		[CompilerGenerated]
		private uint uint_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private List<int> list_0;

		public uint sid
		{
			get;
			set;
		}

		public string ip
		{
			get;
			set;
		}

		public List<int> ports
		{
			get;
			set;
		}

		public duoip()
		{
			ports = new List<int>();
		}
	}
}
