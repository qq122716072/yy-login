using Org.Mentalis.Network.ProxySocket;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ZHANHUO.Model
{
	public class OldTcp : IDisposable
	{
		public TcpClient client;

		private NetworkStream networkStream_0;

		private ARC4 arc4_0;

		private ARC4 arc4_1;

		private IPEndPoint ipendPoint_0;

		private ProxySocket proxySocket_0;

		private bool bool_0;

		public bool connected
		{
			get
			{
				if (client != null)
				{
					return client.Connected;
				}
				return false;
			}
		}

		public OldTcp(string ip, int port, string daili = "", ProxyTypes pt = ProxyTypes.None, string localip = "")
		{
			try
			{
				client = new TcpClient();
				proxySocket_0 = new ProxySocket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				proxySocket_0.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, new LingerOption(true, 0));
				IPAddress address;
				if (!string.IsNullOrWhiteSpace(localip) && IPAddress.TryParse(localip, out address))
				{
					IPEndPoint localEP = new IPEndPoint(address, 0);
					proxySocket_0.Bind(localEP);
				}
				if (daili.Trim().Length > 0)
				{
					string[] array = daili.Split('|');
					if (pt == ProxyTypes.Https)
					{
						array = daili.Split(':');
					}
					proxySocket_0.ProxyEndPoint = new IPEndPoint(IPAddress.Parse(array[0]), Convert.ToInt32(array[1]));
					if (array.Length > 2)
					{
						proxySocket_0.ProxyUser = array[2];
						proxySocket_0.ProxyPass = array[3];
					}
				}
				proxySocket_0.ProxyType = pt;
				client.ReceiveTimeout = 3000;
				arc4_0 = null;
				arc4_1 = null;
				IPAddress address2 = IPAddress.Parse(ip);
				ipendPoint_0 = new IPEndPoint(address2, port);
			}
			catch (Exception ex)
			{
				throw new Exception("ctcp:" + ex.Message);
			}
		}

		public void setarc(byte[] bytes)
		{
			if (arc4_0 == null)
			{
				arc4_0 = new ARC4(bytes, false);
				arc4_1 = new ARC4(bytes, true);
			}
		}

		public bool connect(string msg = "")
		{
			try
			{
				proxySocket_0.Connect(ipendPoint_0);
				if (!proxySocket_0.Connected)
				{
					return false;
				}
				client.Client = proxySocket_0;
				networkStream_0 = client.GetStream();
				return true;
			}
			catch (Exception ex)
			{
				msg = ex.Message;
				return false;
			}
		}

		public void Send(byte[] bytes)
		{
			try
			{
				if (networkStream_0.CanWrite)
				{
					if (arc4_0 != null)
					{
						arc4_0.encrypt(bytes);
					}
					networkStream_0.Write(bytes, 0, bytes.Length);
				}
			}
			catch
			{
			}
		}

		public byte[] recive()
		{
			try
			{
				if (client.Available > 0)
				{
					if (networkStream_0.CanRead)
					{
						byte[] array = new byte[16384];
						int num = networkStream_0.Read(array, 0, array.Length);
						if (num != 0)
						{
							Thread.Sleep(100);
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

		protected virtual void Dispose(bool disposing)
		{
			if (!bool_0)
			{
				if (disposing && client != null)
				{
					try
					{
						networkStream_0.Close();
					}
					catch
					{
					}
					try
					{
						proxySocket_0.Close();
						client.Close();
					}
					catch
					{
					}
					arc4_0 = (arc4_1 = null);
				}
				bool_0 = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
		}
	}
}
