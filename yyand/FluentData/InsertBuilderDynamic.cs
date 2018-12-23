using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace FluentData
{
	internal class InsertBuilderDynamic : BaseInsertBuilder, IExecute, IInsertUpdateBuilderDynamic, GInterface2, IInsertBuilderDynamic
	{
		[CompilerGenerated]
		private dynamic object_0;

		public dynamic Item
		{
			get;
			private set;
		}

		internal InsertBuilderDynamic(IDbCommand command, string name, ExpandoObject item)
			: base(command, name)
		{
			base.Data.Item = item;
			Item = item;
		}

		public IInsertBuilderDynamic Column(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}

		public IInsertBuilderDynamic Column(string propertyName, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueDynamic((ExpandoObject)base.Data.Item, propertyName, parameterType, size);
			return this;
		}

		public IInsertBuilderDynamic AutoMap(params string[] ignoreProperties)
		{
			base.Actions.AutoMapDynamicTypeColumnsAction(ignoreProperties);
			return this;
		}

		public IInsertBuilderDynamic Fill(Action<IInsertUpdateBuilderDynamic> fillMethod)
		{
			fillMethod(this);
			return this;
		}

		IInsertUpdateBuilderDynamic IInsertUpdateBuilderDynamic.Column(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}

		IInsertUpdateBuilderDynamic IInsertUpdateBuilderDynamic.Column(string propertyName, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueDynamic((ExpandoObject)base.Data.Item, propertyName, parameterType, size);
			return this;
		}
	}
}
