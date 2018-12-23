using System.Net.Sockets;

namespace ZHANHUO.Model
{
	public static class TcpClientEx
	{
		public static bool IsOnline(this TcpClient c)
		{
			bool flag = true;
			bool blocking = c.Client.Blocking;
			try
			{
				byte[] buffer = new byte[1];
				c.Client.Blocking = false;
				c.Client.Send(buffer, 0, SocketFlags.None);
				return true;
			}
			catch (SocketException ex)
			{
				if (!ex.NativeErrorCode.Equals(10035))
				{
					return false;
				}
				return true;
			}
			finally
			{
				c.Client.Blocking = blocking;
			}
		}
	}
}
