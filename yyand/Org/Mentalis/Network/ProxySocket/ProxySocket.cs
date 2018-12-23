using System;
using System.Net;
using System.Net.Sockets;

namespace Org.Mentalis.Network.ProxySocket
{
	public class ProxySocket : Socket
	{
		private object object_0;

		private IPEndPoint ipendPoint_0;

		private ProxyTypes proxyTypes_0;

		private string string_0;

		private string string_1;

		private AsyncCallback asyncCallback_0;

		private IAsyncProxyResult zoSqudwCqh;

		private Exception exception_0;

		private int int_0;

		public IPEndPoint ProxyEndPoint
		{
			get
			{
				return ipendPoint_0;
			}
			set
			{
				ipendPoint_0 = value;
			}
		}

		public ProxyTypes ProxyType
		{
			get
			{
				return proxyTypes_0;
			}
			set
			{
				proxyTypes_0 = value;
			}
		}

		public string ProxyUser
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

		public string ProxyPass
		{
			get
			{
				return string_1;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException();
				}
				string_1 = value;
			}
		}

		public ProxySocket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
			: this(addressFamily, socketType, protocolType, "")
		{
		}

		public ProxySocket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType, string proxyUsername)
			: this(addressFamily, socketType, protocolType, proxyUsername, "")
		{
		}

		public ProxySocket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType, string proxyUsername, string proxyPassword)
			: base(addressFamily, socketType, protocolType)
		{
			ProxyUser = proxyUsername;
			ProxyPass = proxyPassword;
			method_8(new InvalidOperationException());
		}

		public new void Connect(EndPoint remoteEP)
		{
			if (remoteEP == null)
			{
				throw new ArgumentNullException("<remoteEP> cannot be null.");
			}
			if (base.ProtocolType == ProtocolType.Tcp && ProxyType != 0 && ProxyEndPoint != null)
			{
				base.Connect((EndPoint)ProxyEndPoint);
				if (ProxyType == ProxyTypes.Https)
				{
					new HttpsHandler(this, ProxyUser, ProxyPass).Negotiate((IPEndPoint)remoteEP);
				}
				else if (ProxyType == ProxyTypes.Socks4)
				{
					new Socks4Handler(this, ProxyUser).Negotiate((IPEndPoint)remoteEP);
				}
				else if (ProxyType == ProxyTypes.Socks5)
				{
					new Socks5Handler(this, ProxyUser, ProxyPass).Negotiate((IPEndPoint)remoteEP);
				}
			}
			else
			{
				base.Connect(remoteEP);
			}
		}

		public new void Connect(string host, int port)
		{
			if (host == null)
			{
				throw new ArgumentNullException("<host> cannot be null.");
			}
			if (port <= 0 || port > 65535)
			{
				throw new ArgumentException("Invalid port.");
			}
			if (base.ProtocolType == ProtocolType.Tcp && ProxyType != 0 && ProxyEndPoint != null)
			{
				base.Connect((EndPoint)ProxyEndPoint);
				if (ProxyType == ProxyTypes.Https)
				{
					new HttpsHandler(this, ProxyUser, ProxyPass).Negotiate(host, port);
				}
				else if (ProxyType == ProxyTypes.Socks4)
				{
					new Socks4Handler(this, ProxyUser).Negotiate(host, port);
				}
				else if (ProxyType == ProxyTypes.Socks5)
				{
					new Socks5Handler(this, ProxyUser, ProxyPass).Negotiate(host, port);
				}
			}
			else
			{
				base.Connect((EndPoint)new IPEndPoint(Dns.GetHostEntry(host).AddressList[0], port));
			}
		}

		public new IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
		{
			if (remoteEP == null)
			{
				throw new ArgumentNullException();
			}
			if (base.ProtocolType == ProtocolType.Tcp && ProxyType != 0 && ProxyEndPoint != null)
			{
				asyncCallback_0 = callback;
				if (ProxyType == ProxyTypes.Https)
				{
					method_6(new HttpsHandler(this, ProxyUser, ProxyPass).BeginNegotiate((IPEndPoint)remoteEP, method_2, ProxyEndPoint));
					return method_5();
				}
				if (ProxyType == ProxyTypes.Socks4)
				{
					method_6(new Socks4Handler(this, ProxyUser).BeginNegotiate((IPEndPoint)remoteEP, method_2, ProxyEndPoint));
					return method_5();
				}
				if (ProxyType == ProxyTypes.Socks5)
				{
					method_6(new Socks5Handler(this, ProxyUser, ProxyPass).BeginNegotiate((IPEndPoint)remoteEP, method_2, ProxyEndPoint));
					return method_5();
				}
				return null;
			}
			return base.BeginConnect(remoteEP, callback, state);
		}

		public new IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state)
		{
			if (host == null)
			{
				throw new ArgumentNullException();
			}
			if (port <= 0 || port > 65535)
			{
				throw new ArgumentException();
			}
			asyncCallback_0 = callback;
			if (base.ProtocolType == ProtocolType.Tcp && ProxyType != 0 && ProxyEndPoint != null)
			{
				if (ProxyType == ProxyTypes.Https)
				{
					method_6(new HttpsHandler(this, ProxyUser, ProxyPass).BeginNegotiate(host, port, method_2, ProxyEndPoint));
					return method_5();
				}
				if (ProxyType == ProxyTypes.Socks4)
				{
					method_6(new Socks4Handler(this, ProxyUser).BeginNegotiate(host, port, method_2, ProxyEndPoint));
					return method_5();
				}
				if (ProxyType == ProxyTypes.Socks5)
				{
					method_6(new Socks5Handler(this, ProxyUser, ProxyPass).BeginNegotiate(host, port, method_2, ProxyEndPoint));
					return method_5();
				}
				return null;
			}
			method_10(port);
			method_6(BeginDns(host, method_2));
			return method_5();
		}

		public new void EndConnect(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException();
			}
			if (!(asyncResult is IAsyncProxyResult))
			{
				base.EndConnect(asyncResult);
			}
			else
			{
				if (!asyncResult.IsCompleted)
				{
					asyncResult.AsyncWaitHandle.WaitOne();
				}
				if (method_7() != null)
				{
					throw method_7();
				}
			}
		}

		internal IAsyncProxyResult BeginDns(string host, HandShakeComplete callback)
		{
			try
			{
				Dns.BeginGetHostEntry(host, method_0, this);
				return new IAsyncProxyResult(null);
			}
			catch
			{
				throw new SocketException();
			}
		}

		private void method_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				IPHostEntry iPHostEntry = Dns.EndGetHostEntry(iasyncResult_0);
				base.BeginConnect((EndPoint)new IPEndPoint(iPHostEntry.AddressList[0], method_9()), (AsyncCallback)method_1, method_3());
			}
			catch (Exception exception_)
			{
				method_2(exception_);
			}
		}

		private void method_1(IAsyncResult iasyncResult_0)
		{
			try
			{
				base.EndConnect(iasyncResult_0);
				method_2(null);
			}
			catch (Exception exception_)
			{
				method_2(exception_);
			}
		}

		private void method_2(Exception exception_1)
		{
			if (exception_1 != null)
			{
				Close();
			}
			method_8(exception_1);
			method_5().Reset();
			if (asyncCallback_0 != null)
			{
				asyncCallback_0(method_5());
			}
		}

		private object method_3()
		{
			return object_0;
		}

		private void method_4(object value)
		{
			object_0 = value;
		}

		private IAsyncProxyResult method_5()
		{
			return zoSqudwCqh;
		}

		private void method_6(IAsyncProxyResult value)
		{
			zoSqudwCqh = value;
		}

		private Exception method_7()
		{
			return exception_0;
		}

		private void method_8(Exception value)
		{
			exception_0 = value;
		}

		private int method_9()
		{
			return int_0;
		}

		private void method_10(int value)
		{
			int_0 = value;
		}
	}
}
