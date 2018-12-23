using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class CExtentProp : ProtoBase
	{
		public MYHashMap m_mapExtentProp;

		public CExtentProp()
		{
			m_mapExtentProp = new MYHashMap();
		}

		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			pushHashMapKIVS(m_mapExtentProp);
		}

		public override void unmarshall(ByteArray _arg1)
		{
			base.unmarshall(_arg1);
			m_mapExtentProp = popHashMapKIVS();
		}
	}
}
