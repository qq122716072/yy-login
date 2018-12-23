using System;
using System.Net;
using System.Net.Sockets;

namespace Org.Mentalis.Network.ProxySocket
{
	internal abstract class SocksHandler
	{
		private Socket socket_0;

		private string string_0;

		private IAsyncProxyResult iasyncProxyResult_0;

		private byte[] byte_0;

		private int int_0;

		protected HandShakeComplete ProtocolComplete;

		protected Socket Server
		{
			get
			{
				return socket_0;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException();
				}
				socket_0 = value;
			}
		}

		protected string Username
		{
			get
			{
				return string_0;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException();
				}
				string_0 = value;
			}
		}

		protected IAsyncProxyResult AsyncResult
		{
			get
			{
				return iasyncProxyResult_0;
			}
			set
			{
				iasyncProxyResult_0 = value;
			}
		}

		protected byte[] Buffer
		{
			get
			{
				return byte_0;
			}
			set
			{
				byte_0 = value;
			}
		}

		protected int Received
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public SocksHandler(Socket server, string user)
		{
			Server = server;
			Username = user;
		}

		protected byte[] PortToBytes(int port)
		{
			return new byte[2]
			{
				(byte)(port / 256),
				(byte)(port % 256)
			};
		}

		protected byte[] AddressToBytes(long address)
		{
			return new byte[4]
			{
				(byte)(address % 256L),
				(byte)(address / 256L % 256L),
				(byte)(address / 65536L % 256L),
				(byte)(address / 16777216L)
			};
		}

		protected byte[] ReadBytes(int count)
		{
			if (count <= 0)
			{
				throw new ArgumentException();
			}
			byte[] array = new byte[count];
			int num;
			for (int i = 0; i != count; i += num)
			{
				num = Server.Receive(array, i, count - i, SocketFlags.None);
				if (num == 0)
				{
					throw new SocketException(10054);
				}
			}
			return array;
		}

		protected void HandleEndReceive(IAsyncResult ar)
		{
			int num = Server.EndReceive(ar);
			if (num <= 0)
			{
				throw new SocketException(10054);
			}
			Received += num;
		}

		protected void HandleEndSend(IAsyncResult ar, int expectedLength)
		{
			if (Server.EndSend(ar) < expectedLength)
			{
				throw new SocketException(10054);
			}
		}

		public abstract void Negotiate(string host, int port);

		public abstract void Negotiate(IPEndPoint remoteEP);

		public abstract IAsyncProxyResult BeginNegotiate(IPEndPoint remoteEP, HandShakeComplete callback, IPEndPoint proxyEndPoint);

		public abstract IAsyncProxyResult BeginNegotiate(string host, int port, HandShakeComplete callback, IPEndPoint proxyEndPoint);
	}
}
