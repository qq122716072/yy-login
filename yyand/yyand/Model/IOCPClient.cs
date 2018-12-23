using Org.Mentalis.Network.ProxySocket;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using ZHANHUO.Model.YYModel;

namespace ZHANHUO.Model
{
	public class IOCPClient
	{
		public delegate void OnConnected(bool issuccess, bool iszhongduan = false);

		public delegate void OnRecieved(byte[] bytes);

		[CompilerGenerated]
		private OnConnected onConnected_0;

		[CompilerGenerated]
		private OnRecieved onRecieved_0;

		private ProxySocket proxySocket_0;

		private SocketAsyncEventArgs socketAsyncEventArgs_0;

		private SocketAsyncEventArgs socketAsyncEventArgs_1;

		private bool bool_0;

		private ARC4 arc4_0;

		private ARC4 arc4_1;

		private System.Timers.Timer timer_0;

		private bool bool_1;

		private IPEndPoint ipendPoint_0;

		private static int int_0;

		public event OnConnected ConnectedEvent
		{
			[CompilerGenerated]
			add
			{
				OnConnected onConnected = onConnected_0;
				OnConnected onConnected2;
				do
				{
					onConnected2 = onConnected;
					OnConnected value2 = (OnConnected)Delegate.Combine(onConnected2, value);
					onConnected = Interlocked.CompareExchange(ref onConnected_0, value2, onConnected2);
				}
				while ((object)onConnected != onConnected2);
			}
			[CompilerGenerated]
			remove
			{
				OnConnected onConnected = onConnected_0;
				OnConnected onConnected2;
				do
				{
					onConnected2 = onConnected;
					OnConnected value2 = (OnConnected)Delegate.Remove(onConnected2, value);
					onConnected = Interlocked.CompareExchange(ref onConnected_0, value2, onConnected2);
				}
				while ((object)onConnected != onConnected2);
			}
		}

		public event OnRecieved RecievedEvent
		{
			[CompilerGenerated]
			add
			{
				OnRecieved onRecieved = onRecieved_0;
				OnRecieved onRecieved2;
				do
				{
					onRecieved2 = onRecieved;
					OnRecieved value2 = (OnRecieved)Delegate.Combine(onRecieved2, value);
					onRecieved = Interlocked.CompareExchange(ref onRecieved_0, value2, onRecieved2);
				}
				while ((object)onRecieved != onRecieved2);
			}
			[CompilerGenerated]
			remove
			{
				OnRecieved onRecieved = onRecieved_0;
				OnRecieved onRecieved2;
				do
				{
					onRecieved2 = onRecieved;
					OnRecieved value2 = (OnRecieved)Delegate.Remove(onRecieved2, value);
					onRecieved = Interlocked.CompareExchange(ref onRecieved_0, value2, onRecieved2);
				}
				while ((object)onRecieved != onRecieved2);
			}
		}

		public IOCPClient(string ip, int port, bool isservice = true, string daili = "", ProxyTypes pt = ProxyTypes.None)
		{
			try
			{
				bool_1 = isservice;
				proxySocket_0 = new ProxySocket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				proxySocket_0.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, new LingerOption(true, 0));
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
				arc4_0 = null;
				arc4_1 = null;
				IPAddress address = IPAddress.Parse(ip);
				ipendPoint_0 = new IPEndPoint(address, port);
				timer_0 = new System.Timers.Timer(15000.0);
				timer_0.Elapsed += timer_0_Elapsed;
				timer_0.AutoReset = true;
			}
			catch
			{
				throw new Exception("GJCW");
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

		private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (Interlocked.Exchange(ref int_0, 1) == 0)
			{
				try
				{
					if (bool_1)
					{
						Send(new byte[14]
						{
							14,
							0,
							0,
							0,
							4,
							30,
							12,
							0,
							200,
							0,
							0,
							0,
							0,
							0
						});
					}
					else
					{
						Send(ProtoPacket.pack(new PCS_APPing()));
					}
				}
				catch
				{
				}
				finally
				{
					Interlocked.Exchange(ref int_0, 0);
				}
			}
		}

		public void startheart()
		{
			timer_0.Enabled = true;
			timer_0.Start();
		}

		public void stopheart()
		{
			timer_0.Enabled = false;
			timer_0.Stop();
		}

		public void Connect()
		{
			socketAsyncEventArgs_0 = new SocketAsyncEventArgs();
			socketAsyncEventArgs_0.UserToken = proxySocket_0;
			socketAsyncEventArgs_0.RemoteEndPoint = ipendPoint_0;
			socketAsyncEventArgs_0.Completed += method_0;
			if (!proxySocket_0.ConnectAsync(socketAsyncEventArgs_0))
			{
				method_1(socketAsyncEventArgs_0);
			}
		}

		private void method_0(object sender, SocketAsyncEventArgs e)
		{
			method_1(e);
		}

		private void method_1(SocketAsyncEventArgs socketAsyncEventArgs_2)
		{
			bool_0 = (socketAsyncEventArgs_2.SocketError == SocketError.Success);
			OnConnected onConnected = onConnected_0;
			if (onConnected != null)
			{
				onConnected.BeginInvoke(bool_0, false, null, null);
			}
			if (bool_0)
			{
				StartRecive(socketAsyncEventArgs_2);
			}
		}

		public void Send(byte[] data)
		{
			if (arc4_0 != null)
			{
				arc4_0.encrypt(data);
			}
			if (socketAsyncEventArgs_1 == null)
			{
				socketAsyncEventArgs_1 = new SocketAsyncEventArgs
				{
					RemoteEndPoint = ipendPoint_0
				};
				socketAsyncEventArgs_1.Completed += method_2;
				socketAsyncEventArgs_1.UserToken = proxySocket_0;
			}
			socketAsyncEventArgs_1.SetBuffer(data, 0, data.Length);
			if (!proxySocket_0.SendAsync(socketAsyncEventArgs_1))
			{
				method_3(socketAsyncEventArgs_1);
			}
		}

		private void method_2(object sender, SocketAsyncEventArgs e)
		{
			method_3(e);
		}

		private void method_3(SocketAsyncEventArgs socketAsyncEventArgs_2)
		{
		}

		public void StartRecive(SocketAsyncEventArgs e)
		{
			Socket obj = e.UserToken as Socket;
			SocketAsyncEventArgs socketAsyncEventArgs = new SocketAsyncEventArgs();
			byte[] array = new byte[8192];
			socketAsyncEventArgs.SetBuffer(array, 0, array.Length);
			socketAsyncEventArgs.Completed += method_4;
			socketAsyncEventArgs.RemoteEndPoint = ipendPoint_0;
			socketAsyncEventArgs.UserToken = e.UserToken;
			if (!obj.ReceiveAsync(socketAsyncEventArgs))
			{
				method_5(socketAsyncEventArgs);
			}
		}

		private void method_4(object sender, SocketAsyncEventArgs e)
		{
			method_5(e);
		}

		private void method_5(SocketAsyncEventArgs socketAsyncEventArgs_2)
		{
			if (socketAsyncEventArgs_2.SocketError == SocketError.Success)
			{
				if (socketAsyncEventArgs_2.BytesTransferred > 0)
				{
					Socket obj = (Socket)socketAsyncEventArgs_2.UserToken;
					if (obj.Available == 0)
					{
						byte[] array = new byte[socketAsyncEventArgs_2.BytesTransferred];
						Array.Copy(socketAsyncEventArgs_2.Buffer, socketAsyncEventArgs_2.Offset, array, 0, array.Length);
						if (arc4_1 != null)
						{
							arc4_1.decrypt(array);
						}
						OnRecieved onRecieved = onRecieved_0;
						if (onRecieved != null)
						{
							onRecieved.BeginInvoke(array, null, null);
						}
					}
					if (!obj.ReceiveAsync(socketAsyncEventArgs_2))
					{
						method_5(socketAsyncEventArgs_2);
					}
				}
				else
				{
					method_6();
				}
			}
		}

		public void DisConnect()
		{
			try
			{
				timer_0.Stop();
				timer_0.Close();
			}
			catch
			{
			}
			try
			{
				proxySocket_0.Shutdown(SocketShutdown.Both);
			}
			catch
			{
			}
		}

		private void method_6()
		{
			arc4_0 = (arc4_1 = null);
			if (proxySocket_0.Connected)
			{
				proxySocket_0.Close();
			}
		}
	}
}
