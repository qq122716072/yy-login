using System;
using System.Runtime.CompilerServices;

namespace ZHANHUO.Model
{
	public class yongjiobj
	{
		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private DateTime dateTime_0;

		public bool isyongji
		{
			get;
			set;
		}

		public DateTime ctime
		{
			get;
			set;
		}

		public yongjiobj()
		{
			isyongji = false;
			ctime = DateTime.MinValue;
		}
	}
}
