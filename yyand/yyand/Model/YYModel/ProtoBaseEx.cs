using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class ProtoBaseEx : ProtoBase
	{
		protected uint mProtoVer;

		public override void marshall(ByteArray _arg1)
		{
			mBuffer = _arg1;
			uint position = (uint)mBuffer.position;
			mBuffer.writeUnsignedInt(0u);
			vsmarshall(_arg1);
			uint position2 = (uint)mBuffer.position;
			uint num = position2 - position - 4;
			uint value = (mProtoVer << 28) | (num & 0xFFFFFFF);
			mBuffer.position = (int)position;
			mBuffer.writeUnsignedInt(value);
			mBuffer.position = (int)position2;
		}

		public override void unmarshall(ByteArray _arg1)
		{
			mBuffer = _arg1;
			uint position = (uint)mBuffer.position;
			uint num = mBuffer.readUnsignedInt();
			mProtoVer = ((num >> 28) & 0xF);
			uint num2 = num & 0xFFFFFFF;
			vsunmarshall(_arg1);
			mBuffer.position = (int)(position + 4 + num2);
		}

		public virtual void vsmarshall(ByteArray _arg1)
		{
			mBuffer = _arg1;
		}

		public virtual void vsunmarshall(ByteArray _arg1)
		{
			mBuffer = _arg1;
		}

		public void pushProtoWithTag(uint _arg1, ProtoBase _arg2)
		{
			if (_arg2 != null)
			{
				uint position = (uint)mBuffer.position;
				mBuffer.writeUnsignedInt(0u);
				pushProto(_arg2);
				uint position2 = (uint)mBuffer.position;
				uint num = position2 - position;
				uint value = (_arg1 << 24) | (num & 0xFFFFFF);
				mBuffer.position = (int)position;
				mBuffer.writeUnsignedInt(value);
				mBuffer.position = (int)position2;
			}
		}

		public void pushFinishFlag()
		{
			mBuffer.writeUnsignedInt(4286085240u);
		}

		public T popProtoWithTag<T>(uint _arg1) where T : ProtoBase, new()
		{
			T result = new T();
			uint position = (uint)mBuffer.position;
			while (true)
			{
				uint num = mBuffer.readUnsignedInt();
				uint num2 = (num >> 24) & 0xFF;
				uint num3 = (num & 0xFFFFFF) - 4;
				if (mBuffer.length < num3 || num2 > _arg1)
				{
					break;
				}
				if (num2 == _arg1)
				{
					result = popProto<T>();
					break;
				}
				mBuffer.position = (int)(mBuffer.position + num3);
			}
			mBuffer.position = (int)position;
			return result;
		}

		public uint popFinishFlag()
		{
			return mBuffer.readUnsignedInt();
		}
	}
}
