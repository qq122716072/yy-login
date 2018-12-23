using System;
using System.Dynamic;

namespace FluentData
{
	internal class StoredProcedureBuilderDynamic : BaseStoredProcedureBuilder, IExecute, IDisposable, IQuery, IParameterValue, IStoredProcedureBuilderDynamic
	{
		internal StoredProcedureBuilderDynamic(IDbCommand command, string name, ExpandoObject item)
			: base(command, name)
		{
			base.Data.Item = item;
		}

		public IStoredProcedureBuilderDynamic Parameter(string name, object value, DataTypes parameterType, int size)
		{
			base.Actions.ColumnValueAction(name, value, parameterType, size);
			return this;
		}

		public IStoredProcedureBuilderDynamic AutoMap(params string[] ignoreProperties)
		{
			base.Actions.AutoMapDynamicTypeColumnsAction(ignoreProperties);
			return this;
		}

		public IStoredProcedureBuilderDynamic ParameterOut(string name, DataTypes parameterType, int size = 0)
		{
			base.Actions.ParameterOutputAction(name, parameterType, size);
			return this;
		}

		public IStoredProcedureBuilderDynamic UseMultiResult(bool useMultipleResultsets)
		{
			base.Data.Command.UseMultiResult(useMultipleResultsets);
			return this;
		}
	}
}
