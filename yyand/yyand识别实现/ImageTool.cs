using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace 战火识别实现
{
	public class ImageTool
	{
		private static ImageTool imageTool_0;

		[DllImport("Mascara.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int www_51ocr_com_InitOCR(string templatefile);

		[DllImport("Mascara.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern int www_51ocr_com_RECOG_1(string imagefile, StringBuilder text);

		[DllImport("Mascara.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
      
        public static extern int www_51ocr_com_RECOG_2(byte[] imagebuf, int size, int type, StringBuilder text);

		private ImageTool()
		{
			www_51ocr_com_InitOCR(Application.StartupPath + "\\51ocr_yy_en.Templates");
		}

		public static ImageTool CreateInstance()
		{
			if (imageTool_0 == null)
			{
				imageTool_0 = new ImageTool();
			}
			return imageTool_0;
		}

		public string hqCode(byte[] bytes, int imageType = 1)
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder("0000000000", 80);
				www_51ocr_com_RECOG_2(bytes, bytes.Length, imageType, stringBuilder);
				return stringBuilder.ToString();
			}
			catch (Exception)
			{
				return "";
			}
		}

		public byte[] method_0(Bitmap bitmap)
		{
			try
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					bitmap.Save(memoryStream, ImageFormat.Bmp);
					byte[] array = new byte[memoryStream.Length];
					memoryStream.Seek(0L, SeekOrigin.Begin);
					memoryStream.Read(array, 0, Convert.ToInt32(memoryStream.Length));
					return array;
				}
			}
			catch
			{
				return null;
			}
		}
	}
}
