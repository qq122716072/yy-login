using System;
using System.Net.Sockets;
using System.Text;

namespace Org.Mentalis.Network.ProxySocket.Authentication
{
	internal sealed class AuthUserPass : AuthMethod
	{
		private string string_0;

		private string string_1;

		public AuthUserPass(Socket server, string user, string pass)
			: base(server)
		{
			method_5(user);
			method_7(pass);
		}

		private byte[] method_0()
		{
			byte[] array = new byte[3 + method_4().Length + method_6().Length];
			array[0] = 1;
			array[1] = (byte)method_4().Length;
			Array.Copy(Encoding.ASCII.GetBytes(method_4()), 0, array, 2, method_4().Length);
			array[method_4().Length + 2] = (byte)method_6().Length;
			Array.Copy(Encoding.ASCII.GetBytes(method_6()), 0, array, method_4().Length + 3, method_6().Length);
			return array;
		}

		private int method_1()
		{
			return 3 + method_4().Length + method_6().Length;
		}

		public override void Authenticate()
		{
			if (base.Server.Send(method_0()) < method_1())
			{
				throw new SocketException(10054);
			}
			byte[] array = new byte[2];
			int num = 0;
			while (true)
			{
				if (num == 2)
				{
					if (array[1] != 0)
					{
						base.Server.Close();
						throw new ProxyException("Username/password combination rejected.");
					}
					return;
				}
				int num2 = base.Server.Receive(array, num, 2 - num, SocketFlags.None);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
			}
			throw new SocketException(10054);
		}

		public override void BeginAuthenticate(HandShakeComplete callback)
		{
			CallBack = callback;
			base.Server.BeginSend(method_0(), 0, method_1(), SocketFlags.None, method_2, base.Server);
		}

		private void method_2(IAsyncResult iasyncResult_0)
		{
			try
			{
				if (base.Server.EndSend(iasyncResult_0) < method_1())
				{
					throw new SocketException(10054);
				}
				base.Buffer = new byte[2];
				base.Server.BeginReceive(base.Buffer, 0, 2, SocketFlags.None, method_3, base.Server);
			}
			catch (Exception error)
			{
				CallBack(error);
			}
		}

		private void method_3(IAsyncResult iasyncResult_0)
		{
			try
			{
				int num = base.Server.EndReceive(iasyncResult_0);
				if (num <= 0)
				{
					throw new SocketException(10054);
				}
				base.Received += num;
				if (base.Received == base.Buffer.Length)
				{
					if (base.Buffer[1] != 0)
					{
						throw new ProxyException("Username/password combination not accepted.");
					}
					CallBack(null);
				}
				else
				{
					base.Server.BeginReceive(base.Buffer, base.Received, base.Buffer.Length - base.Received, SocketFlags.None, method_3, base.Server);
				}
			}
			catch (Exception error)
			{
				CallBack(error);
			}
		}

		private string method_4()
		{
			return string_0;
		}

		private void method_5(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException();
			}
			string_0 = value;
		}

		private string method_6()
		{
			return string_1;
		}

		private void method_7(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException();
			}
			string_1 = value;
		}
	}
}
