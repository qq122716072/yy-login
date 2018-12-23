using System.Runtime.CompilerServices;

namespace FluentData
{
	public class SelectBuilderData : BuilderData
	{
		[CompilerGenerated]
		private int qpSaypuyRf;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private string string_4;

		[CompilerGenerated]
		private string string_5;

		[CompilerGenerated]
		private string string_6;

		public int PagingCurrentPage
		{
			get;
			set;
		}

		public int PagingItemsPerPage
		{
			get;
			set;
		}

		public string Having
		{
			get;
			set;
		}

		public string GroupBy
		{
			get;
			set;
		}

		public string OrderBy
		{
			get;
			set;
		}

		public string From
		{
			get;
			set;
		}

		public string Select
		{
			get;
			set;
		}

		public string WhereSql
		{
			get;
			set;
		}

		public SelectBuilderData(IDbCommand command, string objectName)
			: base(command, objectName)
		{
			Having = "";
			GroupBy = "";
			OrderBy = "";
			From = "";
			Select = "";
			WhereSql = "";
			PagingCurrentPage = 1;
			PagingItemsPerPage = 0;
		}

		internal int GetFromItems()
		{
			return GetToItems() - PagingItemsPerPage + 1;
		}

		internal int GetToItems()
		{
			return PagingCurrentPage * PagingItemsPerPage;
		}
	}
}
