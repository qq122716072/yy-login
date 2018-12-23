using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace ZHANHUO.Common
{
	public class ByteArray : IDisposable
	{
		private MemoryStream memoryStream_0 = new MemoryStream();

		private BinaryReader binaryReader_0;

		private BinaryWriter binaryWriter_0;

		private Endian endian_0;

		private bool bool_0;

		public byte this[int index]
		{
			get
			{
				if (index < length)
				{
					return Buffer[index];
				}
				return 0;
			}
			set
			{
				int position = this.position;
				this.position = index;
				if (value.GetType().IsValueType)
				{
					writeByte(Convert.ToByte(value));
				}
				this.position = position;
			}
		}

		public int length
		{
			get
			{
				return (int)memoryStream_0.Length;
			}
			set
			{
				memoryStream_0.SetLength(value);
			}
		}

		public int bytesAvailable
		{
			get
			{
				return length - position;
			}
		}

		public Endian endian
		{
			get
			{
				return endian_0;
			}
			set
			{
				endian_0 = value;
			}
		}

		public int position
		{
			get
			{
				return (int)memoryStream_0.Position;
			}
			set
			{
				memoryStream_0.Position = value;
			}
		}

		public byte[] Buffer
		{
			get
			{
				return memoryStream_0.ToArray();
			}
		}

		public MemoryStream MemoryStream
		{
			get
			{
				return memoryStream_0;
			}
		}

		~ByteArray()
		{
			Dispose(false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!bool_0)
			{
				if (disposing)
				{
					memoryStream_0.Close();
					memoryStream_0.Dispose();
					memoryStream_0 = null;
					binaryReader_0.Dispose();
					binaryWriter_0.Dispose();
					binaryReader_0 = null;
					binaryWriter_0 = null;
				}
				bool_0 = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public ByteArray()
		{
			method_0();
		}

		public ByteArray(MemoryStream ms)
		{
			memoryStream_0 = ms;
			method_0();
		}

		public ByteArray(byte[] buffer)
		{
			memoryStream_0 = new MemoryStream(buffer);
			method_0();
		}

		private void method_0()
		{
			endian_0 = Endian.BIG_ENDIAN;
			binaryWriter_0 = new BinaryWriter(memoryStream_0);
			binaryReader_0 = new BinaryReader(memoryStream_0);
		}

		public void clear()
		{
			long position = memoryStream_0.Position;
			memoryStream_0.SetLength(0L);
			memoryStream_0.Position = position;
		}

		public bool ReadBoolean()
		{
			return binaryReader_0.ReadBoolean();
		}

		public byte readByte()
		{
			return binaryReader_0.ReadByte();
		}

		public void readBytes(ByteArray bytes, uint offset = 0u, uint length = 0u)
		{
			if (length == 0)
			{
				length = (uint)bytesAvailable;
			}
			byte[] array = binaryReader_0.ReadBytes((int)length);
			for (int i = 0; i < array.Length; i++)
			{
				bytes[i + (int)offset] = array[i];
			}
		}

		public double ReadDouble()
		{
			return binaryReader_0.ReadDouble();
		}

		public float ReadFloat()
		{
			byte[] array = binaryReader_0.ReadBytes(4);
			byte[] array2 = new byte[4];
			int num = 3;
			int num2 = 0;
			while (num >= 0)
			{
				array2[num2] = array[num];
				num--;
				num2++;
			}
			return BitConverter.ToSingle(array2, 0);
		}

		public int ReadInt()
		{
			return binaryReader_0.ReadInt32();
		}

		public short ReadShort()
		{
			return binaryReader_0.ReadInt16();
		}

		public byte readUnsignedByte()
		{
			return binaryReader_0.ReadByte();
		}

		public uint readUnsignedInt()
		{
			return binaryReader_0.ReadUInt32();
		}

		public ushort readUnsignedShort()
		{
			return binaryReader_0.ReadUInt16();
		}

		public string readUTF()
		{
			return binaryReader_0.ReadString();
		}

		public string readUTFBytes(uint length)
		{
			if (length == 0)
			{
				return string.Empty;
			}
			UTF8Encoding uTF8Encoding = new UTF8Encoding(false, true);
			byte[] array = binaryReader_0.ReadBytes((int)length);
			return uTF8Encoding.GetString(array, 0, array.Length);
		}

		public void writeBoolean(bool value)
		{
			binaryWriter_0.BaseStream.WriteByte((byte)(value ? 1 : 0));
		}

		public void writeByte(byte value)
		{
			binaryWriter_0.BaseStream.WriteByte(value);
		}

		public void writeBytes(byte[] buffer)
		{
			int num = 0;
			while (buffer != null && num < buffer.Length)
			{
				binaryWriter_0.BaseStream.WriteByte(buffer[num]);
				num++;
			}
		}

		public void writeBytes(byte[] bytes, int offset, int length)
		{
			for (int i = offset; i < offset + length; i++)
			{
				binaryWriter_0.BaseStream.WriteByte(bytes[i]);
			}
		}

		public void writeDouble(double value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			method_1(bytes);
		}

		public void writeFloat(float value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			method_1(bytes);
		}

		private void method_1(byte[] byte_0)
		{
			if (byte_0 != null)
			{
				if (endian_0 == Endian.BIG_ENDIAN)
				{
					for (int num = byte_0.Length - 1; num >= 0; num--)
					{
						binaryWriter_0.BaseStream.WriteByte(byte_0[num]);
					}
				}
				else
				{
					for (int i = 0; i < byte_0.Length; i++)
					{
						binaryWriter_0.BaseStream.WriteByte(byte_0[i]);
					}
				}
			}
		}

		public void method_2(int value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			method_1(bytes);
		}

		public void method_3(uint value)
		{
			writeUnsignedInt(value);
		}

		public void writeInt(int value)
		{
			method_2(value);
		}

		public void writeShort(int value)
		{
			byte[] bytes = BitConverter.GetBytes((ushort)value);
			method_1(bytes);
		}

		public void writeUnsignedInt(uint value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			method_1(bytes);
		}

		public void writeUTF(string value)
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			int byteCount = uTF8Encoding.GetByteCount(value);
			byte[] bytes = uTF8Encoding.GetBytes(value);
			writeShort(byteCount);
			if (bytes.Length != 0)
			{
				binaryWriter_0.Write(bytes);
			}
		}

		public void writeUTFBytes(string value)
		{
			byte[] bytes = new UTF8Encoding().GetBytes(value);
			if (bytes.Length != 0)
			{
				binaryWriter_0.Write(bytes);
			}
		}

		public void Compress()
		{
			byte[] buffer = memoryStream_0.GetBuffer();
			DeflateStream deflateStream = new DeflateStream(memoryStream_0, CompressionMode.Compress, true);
			deflateStream.Write(buffer, 0, buffer.Length);
			deflateStream.Close();
			method_0();
		}

		public void Uncompress()
		{
			DeflateStream deflateStream = new DeflateStream(memoryStream_0, CompressionMode.Decompress, false);
			MemoryStream memoryStream = new MemoryStream();
			byte[] array = new byte[1024];
			memoryStream_0.ReadByte();
			memoryStream_0.ReadByte();
			while (true)
			{
				int num = deflateStream.Read(array, 0, array.Length);
				if (num <= 0)
				{
					break;
				}
				memoryStream.Write(array, 0, num);
			}
			deflateStream.Close();
			memoryStream_0.Close();
			memoryStream_0.Dispose();
			memoryStream_0 = memoryStream;
			memoryStream_0.Position = 0L;
			method_0();
		}
	}
}
