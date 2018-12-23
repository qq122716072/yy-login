using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PAPRouterHeaders : ProtoBaseEx
	{
		public CRoutingKey m_pRoutingKey;

		public CAppUID m_pAppUID;

		public CRouteStackInfo m_pProxyInfo;

		public CCompressionInfo m_pCompressionInfo;

		public CClientInfo m_pClientInfo;

		public CExtentProp m_pExtentProp;

		public override void vsmarshall(ByteArray _arg1)
		{
			base.vsmarshall(_arg1);
			pushProtoWithTag(1u, m_pRoutingKey);
			pushProtoWithTag(2u, m_pAppUID);
			pushProtoWithTag(4u, m_pProxyInfo);
			pushProtoWithTag(5u, m_pCompressionInfo);
			pushProtoWithTag(6u, m_pClientInfo);
			pushProtoWithTag(7u, m_pExtentProp);
			pushFinishFlag();
		}

		public override void vsunmarshall(ByteArray _arg1)
		{
			base.vsunmarshall(_arg1);
			m_pRoutingKey = popProtoWithTag<CRoutingKey>(1u);
			m_pAppUID = popProtoWithTag<CAppUID>(2u);
			m_pProxyInfo = popProtoWithTag<CRouteStackInfo>(4u);
			m_pCompressionInfo = popProtoWithTag<CCompressionInfo>(5u);
			m_pClientInfo = popProtoWithTag<CClientInfo>(6u);
			m_pExtentProp = popProtoWithTag<CExtentProp>(7u);
			popFinishFlag();
		}
	}
}
