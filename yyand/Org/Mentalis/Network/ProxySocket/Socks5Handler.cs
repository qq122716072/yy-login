using Org.Mentalis.Network.ProxySocket.Authentication;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Org.Mentalis.Network.ProxySocket
{
	internal sealed class Socks5Handler : SocksHandler
	{
		private string string_1;

		private byte[] byte_1;

		public Socks5Handler(Socket server)
			: this(server, "")
		{
		}

		public Socks5Handler(Socket server, string user)
			: this(server, user, "")
		{
		}

		public Socks5Handler(Socket server, string user, string pass)
			: base(server, user)
		{
			method_13(pass);
		}

		private void method_0()
		{
			if (base.Server.Send(new byte[4]
			{
				5,
				2,
				0,
				2
			}) < 4)
			{
				throw new SocketException(10054);
			}
			byte[] array = ReadBytes(2);
			if (array[1] == 255)
			{
				throw new ProxyException("No authentication method accepted.");
			}
			AuthMethod authMethod;
			switch (array[1])
			{
			default:
				throw new ProtocolViolationException();
			case 2:
				authMethod = new AuthUserPass(base.Server, base.Username, method_12());
				break;
			case 0:
				authMethod = new AuthNone(base.Server);
				break;
			}
			authMethod.Authenticate();
		}

		private byte[] method_1(string string_2, int int_1)
		{
			if (string_2 == null)
			{
				throw new ArgumentNullException();
			}
			if (int_1 <= 0 || int_1 > 65535 || string_2.Length > 255)
			{
				throw new ArgumentException();
			}
			byte[] array = new byte[7 + string_2.Length];
			array[0] = 5;
			array[1] = 1;
			array[2] = 0;
			array[3] = 3;
			array[4] = (byte)string_2.Length;
			Array.Copy(Encoding.ASCII.GetBytes(string_2), 0, array, 5, string_2.Length);
			Array.Copy(PortToBytes(int_1), 0, array, string_2.Length + 5, 2);
			return array;
		}

		private byte[] method_2(IPEndPoint ipendPoint_0)
		{
			if (ipendPoint_0 == null)
			{
				throw new ArgumentNullException();
			}
			byte[] array = new byte[10]
			{
				5,
				1,
				0,
				1,
				0,
				0,
				0,
				0,
				0,
				0
			};
			Array.Copy(ipendPoint_0.Address.GetAddressBytes(), 0, array, 4, 4);
			Array.Copy(PortToBytes(ipendPoint_0.Port), 0, array, 8, 2);
			return array;
		}

		public override void Negotiate(string host, int port)
		{
			method_3(method_1(host, port));
		}

		public override void Negotiate(IPEndPoint remoteEP)
		{
			method_3(method_2(remoteEP));
		}

		private void method_3(byte[] byte_2)
		{
			method_0();
			if (base.Server.Send(byte_2) < byte_2.Length)
			{
				throw new SocketException(10054);
			}
			byte[] array = ReadBytes(4);
			if (array[1] != 0)
			{
				base.Server.Close();
				throw new ProxyException(array[1]);
			}
			switch (array[3])
			{
			case 1:
				array = ReadBytes(6);
				break;
			default:
				base.Server.Close();
				throw new ProtocolViolationException();
			case 3:
				array = ReadBytes(1);
				array = ReadBytes(array[0] + 2);
				break;
			case 4:
				array = ReadBytes(18);
				break;
			}
		}

		public override IAsyncProxyResult BeginNegotiate(string host, int port, HandShakeComplete callback, IPEndPoint proxyEndPoint)
		{
			ProtocolComplete = callback;
			BdyqsvugsT(method_1(host, port));
			base.Server.BeginConnect(proxyEndPoint, method_4, base.Server);
			base.AsyncResult = new IAsyncProxyResult(null);
			return base.AsyncResult;
		}

		public override IAsyncProxyResult BeginNegotiate(IPEndPoint remoteEP, HandShakeComplete callback, IPEndPoint proxyEndPoint)
		{
			ProtocolComplete = callback;
			BdyqsvugsT(method_2(remoteEP));
			base.Server.BeginConnect(proxyEndPoint, method_4, base.Server);
			base.AsyncResult = new IAsyncProxyResult(null);
			return base.AsyncResult;
		}

		private void method_4(IAsyncResult iasyncResult_0)
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
				base.Server.BeginSend(new byte[4]
				{
					5,
					2,
					0,
					2
				}, 0, 4, SocketFlags.None, method_5, base.Server);
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
				HandleEndSend(iasyncResult_0, 4);
			}
			catch (Exception error)
			{
				ProtocolComplete(error);
				return;
			}
			try
			{
				base.Buffer = new byte[1024];
				base.Received = 0;
				base.Server.BeginReceive(base.Buffer, 0, base.Buffer.Length, SocketFlags.None, method_6, base.Server);
			}
			catch (Exception error2)
			{
				ProtocolComplete(error2);
			}
		}

		private void method_6(IAsyncResult iasyncResult_0)
		{
			try
			{
				HandleEndReceive(iasyncResult_0);
			}
			catch (Exception error)
			{
				ProtocolComplete(error);
				return;
			}
			try
			{
				if (base.Received < 2)
				{
					base.Server.BeginReceive(base.Buffer, base.Received, base.Buffer.Length - base.Received, SocketFlags.None, method_6, base.Server);
				}
				else
				{
					AuthMethod authMethod;
					switch (base.Buffer[1])
					{
					default:
						ProtocolComplete(new SocketException());
						return;
					case 2:
						authMethod = new AuthUserPass(base.Server, base.Username, method_12());
						break;
					case 0:
						authMethod = new AuthNone(base.Server);
						break;
					}
					authMethod.BeginAuthenticate(method_7);
				}
			}
			catch (Exception error2)
			{
				ProtocolComplete(error2);
			}
		}

		private void method_7(Exception exception_0)
		{
			if (exception_0 == null)
			{
				try
				{
					base.Server.BeginSend(method_14(), 0, method_14().Length, SocketFlags.None, method_8, base.Server);
				}
				catch (Exception error)
				{
					ProtocolComplete(error);
				}
			}
			else
			{
				ProtocolComplete(exception_0);
			}
		}

		private void method_8(IAsyncResult iasyncResult_0)
		{
			try
			{
				HandleEndSend(iasyncResult_0, method_14().Length);
			}
			catch (Exception error)
			{
				ProtocolComplete(error);
				return;
			}
			try
			{
				base.Buffer = new byte[5];
				base.Received = 0;
				base.Server.BeginReceive(base.Buffer, 0, base.Buffer.Length, SocketFlags.None, method_9, base.Server);
			}
			catch (Exception error2)
			{
				ProtocolComplete(error2);
			}
		}

		private void method_9(IAsyncResult iasyncResult_0)
		{
			try
			{
				HandleEndReceive(iasyncResult_0);
			}
			catch (Exception error)
			{
				ProtocolComplete(error);
				return;
			}
			try
			{
				if (base.Received == base.Buffer.Length)
				{
					method_10(base.Buffer);
				}
				else
				{
					base.Server.BeginReceive(base.Buffer, base.Received, base.Buffer.Length - base.Received, SocketFlags.None, method_9, base.Server);
				}
			}
			catch (Exception error2)
			{
				ProtocolComplete(error2);
			}
		}

		private void method_10(byte[] byte_2)
		{
			switch (byte_2[3])
			{
			case 1:
				base.Buffer = new byte[5];
				break;
			default:
				throw new ProtocolViolationException();
			case 3:
				base.Buffer = new byte[byte_2[4] + 2];
				break;
			case 4:
				byte_2 = new byte[17];
				break;
			}
			base.Received = 0;
			base.Server.BeginReceive(base.Buffer, 0, base.Buffer.Length, SocketFlags.None, method_11, base.Server);
		}

		private void method_11(IAsyncResult iasyncResult_0)
		{
			try
			{
				HandleEndReceive(iasyncResult_0);
			}
			catch (Exception error)
			{
				ProtocolComplete(error);
				return;
			}
			try
			{
				if (base.Received == base.Buffer.Length)
				{
					ProtocolComplete(null);
				}
				else
				{
					base.Server.BeginReceive(base.Buffer, base.Received, base.Buffer.Length - base.Received, SocketFlags.None, method_11, base.Server);
				}
			}
			catch (Exception error2)
			{
				ProtocolComplete(error2);
			}
		}

		private string method_12()
		{
			return string_1;
		}

		private void method_13(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException();
			}
			string_1 = value;
		}

		private byte[] method_14()
		{
			return byte_1;
		}

		private void BdyqsvugsT(byte[] value)
		{
			byte_1 = value;
		}
	}
}
