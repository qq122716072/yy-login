using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace FluentData
{
	internal class DataReader : IDisposable, System.Data.IDataReader, IDataRecord, IDataReader
	{
		[CompilerGenerated]
		private System.Data.IDataReader idataReader_0;

		public System.Data.IDataReader InnerReader
		{
			get;
			private set;
		}

		public int Depth
		{
			get
			{
				return InnerReader.Depth;
			}
		}

		public bool IsClosed
		{
			get
			{
				return InnerReader.IsClosed;
			}
		}

		public int RecordsAffected
		{
			get
			{
				return InnerReader.RecordsAffected;
			}
		}

		public int FieldCount
		{
			get
			{
				return InnerReader.FieldCount;
			}
		}

		public object this[string name]
		{
			get
			{
				return this[GetOrdinal(name)];
			}
		}

		public object this[int i]
		{
			get
			{
				if (!IsDBNull(i))
				{
					return InnerReader[i];
				}
				return null;
			}
		}

		public DataReader(System.Data.IDataReader reader)
		{
			InnerReader = reader;
		}

		public void Close()
		{
			InnerReader.Close();
		}

		private UyPgRyKkQFeTSSsctj method_0<UyPgRyKkQFeTSSsctj>(int int_0)
		{
			object value = InnerReader.GetValue(int_0);
			if (value == DBNull.Value)
			{
				return default(UyPgRyKkQFeTSSsctj);
			}
			return (UyPgRyKkQFeTSSsctj)value;
		}

		public DataTable GetSchemaTable()
		{
			return InnerReader.GetSchemaTable();
		}

		public bool NextResult()
		{
			return InnerReader.NextResult();
		}

		public bool Read()
		{
			return InnerReader.Read();
		}

		public void Dispose()
		{
			InnerReader.Dispose();
		}

		public bool GetBoolean(int i)
		{
			return method_0<bool>(i);
		}

		public bool GetBoolean(string name)
		{
			return GetBoolean(GetOrdinal(name));
		}

		public byte GetByte(int i)
		{
			return method_0<byte>(i);
		}

		public byte GetByte(string name)
		{
			return GetByte(GetOrdinal(name));
		}

		public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
		{
			if (!IsDBNull(i))
			{
				return InnerReader.GetBytes(i, fieldOffset, buffer, bufferoffset, length);
			}
			return 0L;
		}

		public long GetBytes(string name, long fieldOffset, byte[] buffer, int bufferoffset, int length)
		{
			return GetBytes(GetOrdinal(name), fieldOffset, buffer, bufferoffset, length);
		}

		public char GetChar(int i)
		{
			return method_0<char>(i);
		}

		public char GetChar(string name)
		{
			return GetChar(GetOrdinal(name));
		}

		public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
		{
			if (!IsDBNull(i))
			{
				return InnerReader.GetChars(i, fieldoffset, buffer, bufferoffset, length);
			}
			return 0L;
		}

		public long GetChars(string name, long fieldoffset, char[] buffer, int bufferoffset, int length)
		{
			return GetChars(GetOrdinal(name), fieldoffset, buffer, bufferoffset, length);
		}

		public System.Data.IDataReader GetData(int i)
		{
			return InnerReader.GetData(i);
		}

		public System.Data.IDataReader GetData(string name)
		{
			return GetData(GetOrdinal(name));
		}

		public string GetDataTypeName(int i)
		{
			return InnerReader.GetDataTypeName(i);
		}

		public string GetDataTypeName(string name)
		{
			return GetDataTypeName(GetOrdinal(name));
		}

		public DateTime GetDateTime(int i)
		{
			return method_0<DateTime>(i);
		}

		public DateTime GetDateTime(string name)
		{
			return GetDateTime(GetOrdinal(name));
		}

		public decimal GetDecimal(int i)
		{
			return method_0<decimal>(i);
		}

		public decimal GetDecimal(string name)
		{
			return GetDecimal(GetOrdinal(name));
		}

		public double GetDouble(int i)
		{
			return method_0<double>(i);
		}

		public double GetDouble(string name)
		{
			return GetDouble(GetOrdinal(name));
		}

		public Type GetFieldType(int i)
		{
			return InnerReader.GetFieldType(i);
		}

		public Type GetFieldType(string name)
		{
			return GetFieldType(GetOrdinal(name));
		}

		public float GetFloat(int i)
		{
			return method_0<float>(i);
		}

		public float GetFloat(string name)
		{
			return GetFloat(GetOrdinal(name));
		}

		public Guid GetGuid(int i)
		{
			return method_0<Guid>(i);
		}

		public Guid GetGuid(string name)
		{
			return GetGuid(GetOrdinal(name));
		}

		public short GetInt16(int i)
		{
			return method_0<short>(i);
		}

		public short GetInt16(string name)
		{
			return GetInt16(GetOrdinal(name));
		}

		public int GetInt32(int i)
		{
			return method_0<int>(i);
		}

		public int GetInt32(string name)
		{
			return GetInt32(GetOrdinal(name));
		}

		public long GetInt64(int i)
		{
			return method_0<long>(i);
		}

		public long GetInt64(string name)
		{
			return GetInt64(GetOrdinal(name));
		}

		public string GetName(int i)
		{
			return InnerReader.GetName(i);
		}

		public string GetName(string name)
		{
			return InnerReader.GetName(GetOrdinal(name));
		}

		public int GetOrdinal(string name)
		{
			return InnerReader.GetOrdinal(name);
		}

		public string GetString(int i)
		{
			return method_0<string>(i);
		}

		public string GetString(string name)
		{
			return GetString(GetOrdinal(name));
		}

		public object GetValue(int i)
		{
			return method_0<object>(i);
		}

		public object GetValue(string name)
		{
			return GetValue(GetOrdinal(name));
		}

		public int GetValues(object[] values)
		{
			return InnerReader.GetValues(values);
		}

		public bool IsDBNull(int i)
		{
			return InnerReader.IsDBNull(i);
		}

		public bool IsDBNull(string name)
		{
			return IsDBNull(GetOrdinal(name));
		}
	}
}
