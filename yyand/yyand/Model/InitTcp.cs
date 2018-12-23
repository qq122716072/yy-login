using System;
using System.Linq;
using System.Net.Sockets;
using System.Threading;

namespace ZHANHUO.Model
{
	public class InitTcp
	{
		public TcpClient client;

		private NetworkStream networkStream_0;

		private ARC4 arc4_0;

		private ARC4 arc4_1;

		private string string_0;

		private int int_0;

		public bool connected
		{
			get
			{
				if (client != null)
				{
					return client.IsOnline();
				}
				return false;
			}
		}

		public InitTcp(string ip, int port)
		{
			client = new TcpClient(AddressFamily.InterNetwork);
			client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, new LingerOption(true, 0));
			client.ReceiveTimeout = 5000;
			string_0 = ip;
			int_0 = port;
			arc4_0 = null;
			arc4_1 = null;
		}

		public void setarc(byte[] bytes)
		{
			if (arc4_0 == null)
			{
				arc4_0 = new ARC4(bytes, false);
				arc4_1 = new ARC4(bytes, true);
			}
		}

		public bool connect()
		{
			try
			{
				client.Connect(string_0, int_0);
				networkStream_0 = client.GetStream();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool send(byte[] bytes)
		{
			try
			{
				if (!client.Connected && !client.IsOnline())
				{
					throw new Exception("连接断开");
				}
				if (networkStream_0.CanWrite)
				{
					if (arc4_0 != null)
					{
						arc4_0.encrypt(bytes);
					}
					networkStream_0.Write(bytes, 0, bytes.Length);
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public byte[] recive()
		{
			try
			{
				if (!client.Connected && !client.IsOnline())
				{
					throw new Exception("tcp close");
				}
				if (client.Available > 0)
				{
					if (networkStream_0.CanRead)
					{
						byte[] array = new byte[16384];
						int num = networkStream_0.Read(array, 0, array.Length);
						Thread.Sleep(50);
						if (num != 0)
						{
							byte[] array2 = array.Take(num).ToArray();
							if (arc4_1 != null)
							{
								arc4_1.decrypt(array2);
							}
							return array2;
						}
						return null;
					}
					return null;
				}
				return null;
			}
			catch (Exception)
			{
				return null;
			}
		}

		public void dispose()
		{
			try
			{
				if (networkStream_0 != null)
				{
					networkStream_0.Close();
					networkStream_0.Dispose();
					networkStream_0 = null;
				}
				if (client != null)
				{
					client.Client.Shutdown(SocketShutdown.Both);
					client.Client.Close();
					client.Close();
					client = null;
				}
				arc4_0 = (arc4_1 = null);
			}
			catch
			{
				networkStream_0 = null;
				client = null;
			}
		}
	}
}
