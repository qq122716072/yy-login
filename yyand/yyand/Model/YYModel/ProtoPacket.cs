using System;
using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class ProtoPacket
	{
		private ByteArray byteArray_0;

		private uint uint_0;

		private uint uint_1;

		private uint uint_2 = 200u;

		public ProtoPacket()
		{
			byteArray_0 = new ByteArray();
			byteArray_0.endian = Endian.LITTLE_ENDIAN;
		}

		public static byte[] pack<T>(T obj) where T : ProtoBase
		{
			using (ByteArray byteArray = new ByteArray())
			{
				byteArray.endian = Endian.LITTLE_ENDIAN;
				byteArray.position = 10;
				obj.marshall(byteArray);
				byteArray.position = 0;
				byteArray.writeUnsignedInt(Convert.ToUInt32(byteArray.length));
				byteArray.writeUnsignedInt(obj.getUri());
				byteArray.writeShort(Convert.ToInt32(obj.getRes()));
				byte[] buffer = byteArray.Buffer;
				byteArray.Dispose();
				return buffer;
			}
		}

		public static byte[] packNoHeader<T>(T obj) where T : ProtoBase
		{
			byte[] array = null;
			using (ByteArray byteArray = new ByteArray())
			{
				byteArray.endian = Endian.LITTLE_ENDIAN;
				byteArray.position = 0;
				obj.marshall(byteArray);
				array = byteArray.Buffer;
				byteArray.Dispose();
				return array;
			}
		}

		public static ProtoPacket unpack(byte[] _arg0)
		{
			using (ByteArray byteArray = new ByteArray(_arg0))
			{
				try
				{
					byteArray.position = 0;
					byteArray.endian = Endian.LITTLE_ENDIAN;
					ProtoPacket protoPacket = new ProtoPacket();
					protoPacket.uint_1 = byteArray.readUnsignedInt();
					protoPacket.uint_0 = byteArray.readUnsignedInt();
					protoPacket.uint_2 = byteArray.readUnsignedShort();
					byteArray.readBytes(protoPacket.byteArray_0, 0u, 0u);
					return protoPacket;
				}
				catch
				{
					return null;
				}
			}
		}

		public static ProtoPacket unpackNoHeader(byte[] _arg0, uint _arg3, uint _arg4)
		{
			using (ByteArray byteArray = new ByteArray(_arg0))
			{
				try
				{
					byteArray.position = 0;
					byteArray.endian = Endian.LITTLE_ENDIAN;
					ProtoPacket protoPacket = new ProtoPacket();
					protoPacket.uint_1 = (uint)byteArray.length;
					protoPacket.uint_0 = _arg3;
					protoPacket.uint_2 = _arg4;
					byteArray.readBytes(protoPacket.byteArray_0, 0u, 0u);
					byteArray.Dispose();
					return protoPacket;
				}
				catch
				{
					return null;
				}
			}
		}

		public uint getUri()
		{
			return uint_0;
		}

		public uint getRes()
		{
			return uint_2;
		}

		public ByteArray getBuffer()
		{
			return byteArray_0;
		}
	}
}
