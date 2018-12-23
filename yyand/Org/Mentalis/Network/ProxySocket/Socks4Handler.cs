using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Org.Mentalis.Network.ProxySocket
{
	internal sealed class Socks4Handler : SocksHandler
	{
		public Socks4Handler(Socket server, string user)
			: base(server, user)
		{
		}

		private byte[] method_0(string string_1, int int_1)
		{
			if (string_1 == null)
			{
				throw new ArgumentNullException();
			}
			if (int_1 <= 0 || int_1 > 65535)
			{
				throw new ArgumentException();
			}
			byte[] array = new byte[10 + base.Username.Length + string_1.Length];
			array[0] = 4;
			array[1] = 1;
			Array.Copy(PortToBytes(int_1), 0, array, 2, 2);
			byte[] array2 = array;
			byte[] array3 = array;
			array[6] = 0;
			array3[5] = 0;
			array2[4] = 0;
			array[7] = 1;
			Array.Copy(Encoding.ASCII.GetBytes(base.Username), 0, array, 8, base.Username.Length);
			array[8 + base.Username.Length] = 0;
			Array.Copy(Encoding.ASCII.GetBytes(string_1), 0, array, 9 + base.Username.Length, string_1.Length);
			array[9 + base.Username.Length + string_1.Length] = 0;
			return array;
		}

		private byte[] method_1(IPEndPoint ipendPoint_0)
		{
			if (ipendPoint_0 == null)
			{
				throw new ArgumentNullException();
			}
			byte[] array = new byte[9 + base.Username.Length];
			array[0] = 4;
			array[1] = 1;
			Array.Copy(PortToBytes(ipendPoint_0.Port), 0, array, 2, 2);
			Array.Copy(ipendPoint_0.Address.GetAddressBytes(), 0, array, 4, 4);
			Array.Copy(Encoding.ASCII.GetBytes(base.Username), 0, array, 8, base.Username.Length);
			array[8 + base.Username.Length] = 0;
			return array;
		}

		public override void Negotiate(string host, int port)
		{
			method_2(method_0(host, port));
		}

		public override void Negotiate(IPEndPoint remoteEP)
		{
			method_2(method_1(remoteEP));
		}

		private void method_2(byte[] byte_1)
		{
			if (byte_1 == null)
			{
				throw new ArgumentNullException();
			}
			if (byte_1.Length < 2)
			{
				throw new ArgumentException();
			}
			if (base.Server.Send(byte_1) < byte_1.Length)
			{
				throw new SocketException(10054);
			}
			if (ReadBytes(8)[1] != 90)
			{
				base.Server.Close();
				throw new ProxyException("Negotiation failed.");
			}
		}

		public override IAsyncProxyResult BeginNegotiate(string host, int port, HandShakeComplete callback, IPEndPoint proxyEndPoint)
		{
			ProtocolComplete = callback;
			base.Buffer = method_0(host, port);
			base.Server.BeginConnect(proxyEndPoint, method_3, base.Server);
			base.AsyncResult = new IAsyncProxyResult(null);
			return base.AsyncResult;
		}

		public override IAsyncProxyResult BeginNegotiate(IPEndPoint remoteEP, HandShakeComplete callback, IPEndPoint proxyEndPoint)
		{
			ProtocolComplete = callback;
			base.Buffer = method_1(remoteEP);
			base.Server.BeginConnect(proxyEndPoint, method_3, base.Server);
			base.AsyncResult = new IAsyncProxyResult(null);
			return base.AsyncResult;
		}

		private void method_3(IAsyncResult iasyncResult_0)
		{
			try
			{
				base.Server.EndConnect(iasyncResult_0);
			}
			catch (Exception error)
			{
				ProtocolComplete(error);
				return;
			}
			try
			{
				base.Server.BeginSend(base.Buffer, 0, base.Buffer.Length, SocketFlags.None, method_4, base.Server);
			}
			catch (Exception error2)
			{
				ProtocolComplete(error2);
			}
		}

		private void method_4(IAsyncResult iasyncResult_0)
		{
			try
			{
				HandleEndSend(iasyncResult_0, base.Buffer.Length);
			}
			catch (Exception error)
			{
				ProtocolComplete(error);
				return;
			}
			try
			{
				base.Buffer = new byte[8];
				base.Received = 0;
				base.Server.BeginReceive(base.Buffer, 0, base.Buffer.Length, SocketFlags.None, method_5, base.Server);
			}
			catch (Exception error2)
			{
				ProtocolComplete(error2);
			}
		}

		private void method_5(IAsyncResult iasyncResult_0)
		{
			try
			{
				HandleEndReceive(iasyncResult_0);
				if (base.Received == 8)
				{
					if (base.Buffer[1] == 90)
					{
						ProtocolComplete(null);
					}
					else
					{
						base.Server.Close();
						ProtocolComplete(new ProxyException("Negotiation failed."));
					}
				}
				else
				{
					base.Server.BeginReceive(base.Buffer, base.Received, base.Buffer.Length - base.Received, SocketFlags.None, method_5, base.Server);
				}
			}
			catch (Exception error)
			{
				ProtocolComplete(error);
			}
		}
	}
}
