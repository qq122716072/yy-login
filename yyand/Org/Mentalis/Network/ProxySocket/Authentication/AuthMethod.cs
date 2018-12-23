using System;
using System.Net.Sockets;

namespace Org.Mentalis.Network.ProxySocket.Authentication
{
	internal abstract class AuthMethod
	{
		private byte[] byte_0;

		private Socket socket_0;

		protected HandShakeComplete CallBack;

		private int int_0;

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

		public AuthMethod(Socket server)
		{
			Server = server;
		}

		public abstract void Authenticate();

		public abstract void BeginAuthenticate(HandShakeComplete callback);
	}
}
