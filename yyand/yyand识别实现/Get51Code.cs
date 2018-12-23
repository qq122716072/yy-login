using System;

namespace 战火识别实现
{
	public class Get51Code : MarshalByRefObject
	{
		public Get51Code()
		{
			ImageTool.CreateInstance();
		}

		public string HQCode(byte[] bytes, int imagetype)
		{
			try
			{
				return ImageTool.CreateInstance().hqCode(bytes, imagetype);
			}
			catch
			{
				return "";
			}
		}
	}
}
