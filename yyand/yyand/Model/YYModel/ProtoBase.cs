using System;
using System.Collections.Generic;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class ProtoBase
	{
		protected ByteArray mBuffer;

		protected uint mUri;

		protected uint mRes = 200u;

		public void setUri(uint _arg1)
		{
			mUri = _arg1;
		}

		public uint getUri()
		{
			return mUri;
		}

		public uint getRes()
		{
			return mRes;
		}

		public ByteArray getBuffer()
		{
			return mBuffer;
		}

		public virtual void marshall(ByteArray _arg1)
		{
			mBuffer = _arg1;
		}

		public virtual void unmarshall(ByteArray _arg1)
		{
			mBuffer = _arg1;
		}

		public void pushBool(bool _arg1)
		{
			uint value = 0u;
			if (_arg1)
			{
				value = 1u;
			}
			mBuffer.writeByte(Convert.ToByte(value));
		}

		public void pushByte(uint _arg1)
		{
			mBuffer.writeByte(Convert.ToByte(_arg1));
		}

		public void pushShort(uint _arg1)
		{
			mBuffer.writeShort(Convert.ToUInt16(_arg1));
		}

		public void pushInt(uint _arg1)
		{
			mBuffer.writeUnsignedInt(_arg1);
		}

		public void method_0(MyUInt64 _arg1)
		{
			mBuffer.writeUnsignedInt(_arg1.low);
			mBuffer.writeUnsignedInt(_arg1.high);
		}

		public void pushBytes(byte[] bytes)
		{
			if (bytes == null)
			{
				mBuffer.writeShort(0);
			}
			else
			{
				mBuffer.writeShort(bytes.Length);
				mBuffer.writeBytes(bytes);
			}
		}

		public void method_1(byte[] _arg1)
		{
			if (_arg1 != null)
			{
				mBuffer.writeInt(_arg1.Length);
				mBuffer.writeBytes(_arg1);
			}
			else
			{
				mBuffer.writeInt(0);
			}
		}

		public void pushProto(ProtoBase _arg1)
		{
			_arg1.marshall(mBuffer);
		}

		public void pushProtoArray<T>(List<T> _arg1) where T : ProtoBase, new()
		{
			uint count = (uint)_arg1.Count;
			pushInt(count);
			for (uint num = 0u; num < count; num++)
			{
				_arg1[(int)num].marshall(mBuffer);
			}
		}

		public void pushShortArray(List<uint> _arg1)
		{
			uint count = (uint)_arg1.Count;
			pushInt(count);
			for (uint num = 0u; num < count; num++)
			{
				mBuffer.writeShort((int)_arg1[(int)num]);
			}
		}

		public void pushIntArray(List<uint> _arg1)
		{
			uint count = (uint)_arg1.Count;
			pushInt(count);
			for (uint num = 0u; num < count; num++)
			{
				mBuffer.writeUnsignedInt(_arg1[(int)num]);
			}
		}

		public void pushInt64Array(List<MyUInt64> _arg1)
		{
			uint count = (uint)_arg1.Count;
			pushInt(count);
			for (uint num = 0u; num < count; num++)
			{
				method_0(_arg1[(int)num]);
			}
		}

		public void pushStringArray(List<ByteArray> _arg1)
		{
			uint count = (uint)_arg1.Count;
			pushInt(count);
			for (uint num = 0u; num < count; num++)
			{
				pushBytes(_arg1[(int)num].Buffer);
			}
		}

		public bool popBool()
		{
			return mBuffer.readByte() != 0;
		}

		public uint popByte()
		{
			return (uint)(mBuffer.readByte() & 0xFF);
		}

		public uint popShort()
		{
			return mBuffer.readUnsignedShort();
		}

		public uint popInt()
		{
			return mBuffer.readUnsignedInt();
		}

		public MyUInt64 popInt64()
		{
			uint arg = mBuffer.readUnsignedInt();
			uint arg2 = mBuffer.readUnsignedInt();
			return new MyUInt64(arg, arg2);
		}

		public List<uint> popIntArray()
		{
			uint num = popInt();
			List<uint> list = new List<uint>();
			for (uint num2 = 0u; num2 < num; num2++)
			{
				list[(int)num2] = popInt();
			}
			return list;
		}

		public List<MyUInt64> popInt64Array()
		{
			uint num = popInt();
			List<MyUInt64> list = new List<MyUInt64>();
			for (uint num2 = 0u; num2 < num; num2++)
			{
				list[(int)num2] = popInt64();
			}
			return list;
		}

		public List<uint> popShortArray()
		{
			uint num = popInt();
			List<uint> list = new List<uint>();
			for (uint num2 = 0u; num2 < num; num2++)
			{
				list[(int)num2] = popShort();
			}
			return list;
		}

		public byte[] popBytes()
		{
			uint num = popShort();
			byte[] result = null;
			using (ByteArray byteArray = new ByteArray())
			{
				if (num == 0)
				{
					return result;
				}
				mBuffer.readBytes(byteArray, 0u, num);
				byteArray.position = 0;
				return byteArray.Buffer;
			}
		}

		public List<byte[]> popStringArray()
		{
			uint num = popInt();
			List<byte[]> list = new List<byte[]>();
			for (uint num2 = 0u; num2 < num; num2++)
			{
				list[(int)num2] = popBytes();
			}
			return list;
		}

		public void pushHashMapKIVS(MYHashMap _arg1)
		{
			uint num = (uint)_arg1.size();
			pushInt(num);
			List<string> list = _arg1.keys();
			List<object> list2 = _arg1.values();
			for (uint num2 = 0u; num2 < num; num2++)
			{
				pushInt((uint)Convert.ToInt32(list[(int)num2]));
				pushBytes((byte[])list2[(int)num2]);
			}
		}

		public MYHashMap popHashMapKIVS()
		{
			MYHashMap mYHashMap = new MYHashMap();
			uint num = popInt();
			for (uint num2 = 0u; num2 < num; num2++)
			{
				mYHashMap.put(popInt().ToString(), popBytes());
			}
			return mYHashMap;
		}

		public MYHashMap popHashMapKIVP<T>() where T : ProtoBase, new()
		{
			MYHashMap mYHashMap = new MYHashMap();
			uint num = popInt();
			for (int i = 0; i < num; i++)
			{
				mYHashMap.put(popInt().ToString(), popProto<T>());
			}
			return mYHashMap;
		}

		public MYHashMap popHashMapKBVI()
		{
			MYHashMap mYHashMap = new MYHashMap();
			uint num = popInt();
			for (int i = 0; i < num; i++)
			{
				mYHashMap.put(popByte().ToString(), popInt());
			}
			return mYHashMap;
		}

		public MYHashMap popHashMapKIVI()
		{
			MYHashMap mYHashMap = new MYHashMap();
			uint num = popInt();
			for (int i = 0; i < num; i++)
			{
				mYHashMap.put(popInt().ToString(), popInt());
			}
			return mYHashMap;
		}

		public MYHashMap popHashMapKBVS()
		{
			MYHashMap mYHashMap = new MYHashMap();
			uint num = popInt();
			for (int i = 0; i < num; i++)
			{
				mYHashMap.put(popByte().ToString(), popBytes());
			}
			return mYHashMap;
		}

		public byte[] method_2()
		{
			byte[] result = null;
			uint num = popInt();
			using (ByteArray byteArray = new ByteArray())
			{
				if (num != 0)
				{
					mBuffer.readBytes(byteArray, 0u, num);
					byteArray.position = 0;
					result = byteArray.Buffer;
				}
				byteArray.Dispose();
				return result;
			}
		}

		public T popProto<T>() where T : ProtoBase, new()
		{
			T val = new T();
			val.unmarshall(mBuffer);
			return val;
		}

		public List<T> popProtoArray<T>() where T : ProtoBase, new()
		{
			uint num = popInt();
			List<T> list = new List<T>();
			for (uint num2 = 0u; num2 < num; num2++)
			{
				list[(int)num2] = popProto<T>();
			}
			return list;
		}

		public void pushHashMapKSVS(MYHashMap _arg1)
		{
			uint num = (uint)_arg1.size();
			pushInt(num);
			List<string> list = _arg1.keys();
			List<object> list2 = _arg1.values();
			for (uint num2 = 0u; num2 < num; num2++)
			{
				pushShort((uint)Convert.ToInt32(list[(int)num2]));
				pushBytes((byte[])list2[(int)num2]);
			}
		}

		public MYHashMap popHashMapKSVS()
		{
			MYHashMap mYHashMap = new MYHashMap();
			uint num = popInt();
			for (uint num2 = 0u; num2 < num; num2++)
			{
				mYHashMap.put(popShort().ToString(), popBytes());
			}
			return mYHashMap;
		}
	}
}
