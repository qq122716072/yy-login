using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace FluentData
{
	internal class UpdateBuilderDynamic : BaseUpdateBuilder, IExecute, IInsertUpdateBuilderDynamic, IUpdateBuilderDynamic
	{
		[CompilerGenerated]
		private dynamic object_0;

		public dynamic Item
		{
			get;
			private set;
		}

		internal UpdateBuilderDynamic(IDbProvider dbProvider, IDbCommand command, string name, ExpandoObject item)
			: base(dbProvider, command, name)
		{
			base.Data.Item = item;
			Item = item;
		}

		public virtual IUpdateBuilderDynamic Where(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.WhereAction(columnName, value, parameterType, size);
			return this;
		}

		public IUpdateBuilderDynamic Column(string columnName, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(columnName, value, parameterType, size);
			return this;
		}

		public IUpdateBuilderDynamic Column(string propertyName, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueDynamic((ExpandoObject)base.Data.Item, propertyName, parameterType, size);
			return this;
		}

		public IUpdateBuilderDynamic Where(string name, DataTypes parameterType, int size)
		{
			object propertyValueDynamic = ReflectionHelper.GetPropertyValueDynamic(base.Data.Item, name);
			Where(name, propertyValueDynamic, parameterType, size);
			return this;
		}

		public IUpdateBuilderDynamic AutoMap(params string[] ignoreProperties)
		{
			base.Actions.AutoMapDynamicTypeColumnsAction(ignoreProperties);
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

		public IUpdateBuilderDynamic Fill(Action<IInsertUpdateBuilderDynamic> fillMethod)
		{
			fillMethod(this);
			return this;
		}
	}
}
