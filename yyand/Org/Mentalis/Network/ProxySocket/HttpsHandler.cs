using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Org.Mentalis.Network.ProxySocket
{
	internal sealed class HttpsHandler : SocksHandler
	{
		private string string_1;

		private int int_1;

		public HttpsHandler(Socket server)
			: this(server, "")
		{
		}

		public HttpsHandler(Socket server, string user)
			: this(server, user, "")
		{
		}

		public HttpsHandler(Socket server, string user, string pass)
			: base(server, user)
		{
			method_8(pass);
		}

		private byte[] method_0(string string_2, int int_2)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(string.Format("CONNECT {0}:{1} HTTP/1.1", string_2, int_2));
			stringBuilder.AppendLine(string.Format("Host: {0}:{1}", string_2, int_2));
			if (!string.IsNullOrEmpty(base.Username))
			{
				string arg = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", base.Username, method_7())));
				stringBuilder.AppendLine(string.Format("Proxy-Authorization: Basic {0}", arg));
			}
			stringBuilder.AppendLine();
			return Encoding.ASCII.GetBytes(stringBuilder.ToString());
		}

		private void method_1(byte[] byte_1)
		{
			string @string = Encoding.ASCII.GetString(byte_1);
			if ((!@string.StartsWith("HTTP/1.1 ", StringComparison.OrdinalIgnoreCase) && !@string.StartsWith("HTTP/1.0 ", StringComparison.OrdinalIgnoreCase)) || !@string.EndsWith(" "))
			{
				throw new ProtocolViolationException();
			}
			string text = @string.Substring(9, 3);
			if (text != "200")
			{
				throw new ProxyException("Invalid HTTP status. Code: " + text);
			}
		}

		public override void Negotiate(IPEndPoint remoteEP)
		{
			if (remoteEP == null)
			{
				throw new ArgumentNullException();
			}
			Negotiate(remoteEP.Address.ToString(), remoteEP.Port);
		}

		public override void Negotiate(string host, int port)
		{
			if (host == null)
			{
				throw new ArgumentNullException();
			}
			if (port > 0 && port <= 65535 && host.Length <= 255)
			{
				byte[] array = method_0(host, port);
				if (base.Server.Send(array, 0, array.Length, SocketFlags.None) < array.Length)
				{
					throw new SocketException(10054);
				}
				array = ReadBytes(13);
				method_1(array);
				int num = 0;
				array = new byte[1];
				while (true)
				{
					if (num >= 4)
					{
						return;
					}
					if (base.Server.Receive(array, 0, 1, SocketFlags.None) == 0)
					{
						break;
					}
					byte b = array[0];
					num = ((b != ((num % 2 == 0) ? 13 : 10)) ? ((b == 13) ? 1 : 0) : (num + 1));
				}
				throw new SocketException(10054);
			}
			throw new ArgumentException();
		}

		public override IAsyncProxyResult BeginNegotiate(IPEndPoint remoteEP, HandShakeComplete callback, IPEndPoint proxyEndPoint)
		{
			return BeginNegotiate(remoteEP.Address.ToString(), remoteEP.Port, callback, proxyEndPoint);
		}

		public override IAsyncProxyResult BeginNegotiate(string host, int port, HandShakeComplete callback, IPEndPoint proxyEndPoint)
		{
			ProtocolComplete = callback;
			base.Buffer = method_0(host, port);
			base.Server.BeginConnect(proxyEndPoint, method_2, base.Server);
			base.AsyncResult = new IAsyncProxyResult(null);
			return base.AsyncResult;
		}

		private void method_2(IAsyncResult iasyncResult_0)
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
				base.Server.BeginSend(base.Buffer, 0, base.Buffer.Length, SocketFlags.None, method_3, null);
			}
			catch (Exception error2)
			{
				ProtocolComplete(error2);
			}
		}

		private void method_3(IAsyncResult iasyncResult_0)
		{
			try
			{
				HandleEndSend(iasyncResult_0, base.Buffer.Length);
				base.Buffer = new byte[13];
				base.Received = 0;
				base.Server.BeginReceive(base.Buffer, 0, 13, SocketFlags.None, method_4, base.Server);
			}
			catch (Exception error)
			{
				ProtocolComplete(error);
			}
		}

		private void method_4(IAsyncResult iasyncResult_0)
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
				if (base.Received < 13)
				{
					base.Server.BeginReceive(base.Buffer, base.Received, 13 - base.Received, SocketFlags.None, method_4, base.Server);
				}
				else
				{
					method_1(base.Buffer);
					method_5(true);
				}
			}
			catch (Exception error2)
			{
				ProtocolComplete(error2);
			}
		}

		private void method_5(bool bool_0)
		{
			while (base.Server.Available > 0 && int_1 < 4)
			{
				if (!bool_0)
				{
					bool_0 = false;
				}
				else if (base.Server.Receive(base.Buffer, 0, 1, SocketFlags.None) == 0)
				{
					throw new SocketException(10054);
				}
				if (base.Buffer[0] == ((int_1 % 2 == 0) ? 13 : 10))
				{
					int_1++;
				}
				else
				{
					int_1 = ((base.Buffer[0] == 13) ? 1 : 0);
				}
			}
			if (int_1 == 4)
			{
				ProtocolComplete(null);
			}
			else
			{
				base.Server.BeginReceive(base.Buffer, 0, 1, SocketFlags.None, method_6, base.Server);
			}
		}

		private void method_6(IAsyncResult iasyncResult_0)
		{
			try
			{
				HandleEndReceive(iasyncResult_0);
				method_5(false);
			}
			catch (Exception error)
			{
				ProtocolComplete(error);
			}
		}

		private string method_7()
		{
			return string_1;
		}

		private void method_8(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException();
			}
			string_1 = value;
		}
	}
}
