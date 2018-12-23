using ZHANHUO.Common;

namespace ZHANHUO.Model.YYModel
{
	public class PServiceUInfoExModifyReq : PServiceUInfoExLoginReq
	{
		public override void marshall(ByteArray _arg1)
		{
			base.marshall(_arg1);
			setUri(386136u);
		}
	}
}
