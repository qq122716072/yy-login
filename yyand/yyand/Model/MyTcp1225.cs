using Org.Mentalis.Network.ProxySocket;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ZHANHUO.Model
{
	public class MyTcp1225 : IDisposable
	{
		public delegate void OnSend();

		public delegate void OnRecive(byte[] data);

		public delegate void OnCloseCon();

		public delegate void OnCon();

		private ARC4 arc4_0;

		private ARC4 arc4_1;

		private IPEndPoint ipendPoint_0;

		public ProxySocket clientSocket;

		[CompilerGenerated]
		private OnSend onSend_0;

		[CompilerGenerated]
		private OnRecive onRecive_0;

		[CompilerGenerated]
		private OnCloseCon onCloseCon_0;

		[CompilerGenerated]
		private OnCon onCon_0;

		private List<byte> list_0;

		private MySocketEventArgs mySocketEventArgs_0 = new MySocketEventArgs();

		private int int_0;

		public event OnSend SendEvent
		{
			[CompilerGenerated]
			add
			{
				OnSend onSend = onSend_0;
				OnSend onSend2;
				do
				{
					onSend2 = onSend;
					OnSend value2 = (OnSend)Delegate.Combine(onSend2, value);
					onSend = Interlocked.CompareExchange(ref onSend_0, value2, onSend2);
				}
				while ((object)onSend != onSend2);
			}
			[CompilerGenerated]
			remove
			{
				OnSend onSend = onSend_0;
				OnSend onSend2;
				do
				{
					onSend2 = onSend;
					OnSend value2 = (OnSend)Delegate.Remove(onSend2, value);
					onSend = Interlocked.CompareExchange(ref onSend_0, value2, onSend2);
				}
				while ((object)onSend != onSend2);
			}
		}

		public event OnRecive ReciveEvent
		{
			[CompilerGenerated]
			add
			{
				OnRecive onRecive = onRecive_0;
				OnRecive onRecive2;
				do
				{
					onRecive2 = onRecive;
					OnRecive value2 = (OnRecive)Delegate.Combine(onRecive2, value);
					onRecive = Interlocked.CompareExchange(ref onRecive_0, value2, onRecive2);
				}
				while ((object)onRecive != onRecive2);
			}
			[CompilerGenerated]
			remove
			{
				OnRecive onRecive = onRecive_0;
				OnRecive onRecive2;
				do
				{
					onRecive2 = onRecive;
					OnRecive value2 = (OnRecive)Delegate.Remove(onRecive2, value);
					onRecive = Interlocked.CompareExchange(ref onRecive_0, value2, onRecive2);
				}
				while ((object)onRecive != onRecive2);
			}
		}

		public event OnCloseCon CloseConEvent
		{
			[CompilerGenerated]
			add
			{
				OnCloseCon onCloseCon = onCloseCon_0;
				OnCloseCon onCloseCon2;
				do
				{
					onCloseCon2 = onCloseCon;
					OnCloseCon value2 = (OnCloseCon)Delegate.Combine(onCloseCon2, value);
					onCloseCon = Interlocked.CompareExchange(ref onCloseCon_0, value2, onCloseCon2);
				}
				while ((object)onCloseCon != onCloseCon2);
			}
			[CompilerGenerated]
			remove
			{
				OnCloseCon onCloseCon = onCloseCon_0;
				OnCloseCon onCloseCon2;
				do
				{
					onCloseCon2 = onCloseCon;
					OnCloseCon value2 = (OnCloseCon)Delegate.Remove(onCloseCon2, value);
					onCloseCon = Interlocked.CompareExchange(ref onCloseCon_0, value2, onCloseCon2);
				}
				while ((object)onCloseCon != onCloseCon2);
			}
		}

		public event OnCon ConEvent
		{
			[CompilerGenerated]
			add
			{
				OnCon onCon = onCon_0;
				OnCon onCon2;
				do
				{
					onCon2 = onCon;
					OnCon value2 = (OnCon)Delegate.Combine(onCon2, value);
					onCon = Interlocked.CompareExchange(ref onCon_0, value2, onCon2);
				}
				while ((object)onCon != onCon2);
			}
			[CompilerGenerated]
			remove
			{
				OnCon onCon = onCon_0;
				OnCon onCon2;
				do
				{
					onCon2 = onCon;
					OnCon value2 = (OnCon)Delegate.Remove(onCon2, value);
					onCon = Interlocked.CompareExchange(ref onCon_0, value2, onCon2);
				}
				while ((object)onCon != onCon2);
			}
		}

		public MyTcp1225(string ip, int port, ProxyTypes pt = ProxyTypes.None, string daili = "", string localip = "")
		{
			ipendPoint_0 = new IPEndPoint(IPAddress.Parse(ip), port);
			clientSocket = new ProxySocket(ipendPoint_0.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			clientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, new LingerOption(true, 0));
			IPAddress address;
			if (!string.IsNullOrWhiteSpace(localip) && IPAddress.TryParse(localip, out address))
			{
				IPEndPoint localEP = new IPEndPoint(address, 0);
				clientSocket.Bind(localEP);
			}
			if (!string.IsNullOrWhiteSpace(daili) && daili.Trim().Length > 0)
			{
				string[] array = daili.Split('|');
				if (pt == ProxyTypes.Https)
				{
					array = daili.Split(':');
				}
				clientSocket.ProxyEndPoint = new IPEndPoint(IPAddress.Parse(array[0]), Convert.ToInt32(array[1]));
				if (array.Length > 2)
				{
					clientSocket.ProxyUser = array[2];
					clientSocket.ProxyPass = array[3];
				}
			}
			clientSocket.ProxyType = pt;
			list_0 = new List<byte>();
		}

		public void setarc(byte[] bytes)
		{
			if (arc4_0 == null)
			{
				arc4_0 = new ARC4(bytes, false);
				arc4_1 = new ARC4(bytes, true);
			}
		}

		public void Connect()
		{
			try
			{
				clientSocket.BeginConnect(ipendPoint_0, VvVnOpsTju, null);
			}
			catch
			{
				try
				{
					OnCloseCon onCloseCon = onCloseCon_0;
					if (onCloseCon != null)
					{
						onCloseCon();
					}
				}
				catch
				{
				}
				Dispose();
			}
		}

		public void initArgs()
		{
			try
			{
				byte[] buffer = new byte[8196];
				mySocketEventArgs_0.Completed += method_1;
				mySocketEventArgs_0.UserToken = clientSocket;
				mySocketEventArgs_0.ArgsTag = 0;
				mySocketEventArgs_0.SetBuffer(buffer, 0, 8196);
				if (!clientSocket.ReceiveAsync(mySocketEventArgs_0))
				{
					method_3(mySocketEventArgs_0);
				}
			}
			catch
			{
			}
		}

		private MySocketEventArgs method_0()
		{
			MySocketEventArgs obj = new MySocketEventArgs
			{
				UserToken = clientSocket,
				RemoteEndPoint = ipendPoint_0,
				IsUsing = false
			};
            obj.Completed += new EventHandler<SocketAsyncEventArgs>(method_1);
			Interlocked.Increment(ref int_0);
			obj.ArgsTag = int_0;
			return obj;
		}

		private void method_1(object sender, SocketAsyncEventArgs e)
		{
			try
			{
				switch (e.LastOperation)
				{
				default:
					throw new ArgumentException("The last operation completed on the socket was not a receive or send");
				case SocketAsyncOperation.Send:
					method_2(e);
					break;
				case SocketAsyncOperation.Receive:
					method_3(e);
					break;
				}
			}
			catch
			{
			}
		}

		public void Send(byte[] sendBuffer, bool issync = false)
		{
			MySocketEventArgs mySocketEventArgs = method_0();
			try
			{
				if (arc4_0 != null)
				{
					arc4_0.encrypt(sendBuffer);
				}
				mySocketEventArgs.IsUsing = true;
				mySocketEventArgs.SetBuffer(sendBuffer, 0, sendBuffer.Length);
				if (clientSocket != null && !clientSocket.SendAsync(mySocketEventArgs))
				{
					method_2(mySocketEventArgs);
				}
			}
			catch
			{
			}
		}

		private void method_2(SocketAsyncEventArgs socketAsyncEventArgs_0)
		{
			SocketError socketError = SocketError.Success;
			try
			{
				MySocketEventArgs obj = (MySocketEventArgs)socketAsyncEventArgs_0;
				socketError = obj.SocketError;
				obj.IsUsing = false;
				obj.SetBuffer(null, 0, 0);
				obj.Completed -= method_1;
				obj.Dispose();
			}
			catch
			{
			}
			try
			{
				if (socketError != 0)
				{
					method_4();
				}
				else if (onSend_0 != null)
				{
					onSend_0();
				}
			}
			catch
			{
			}
		}

		private void method_3(SocketAsyncEventArgs socketAsyncEventArgs_0)
		{
			try
			{
				Socket socket = (Socket)socketAsyncEventArgs_0.UserToken;
				if (socketAsyncEventArgs_0.SocketError == SocketError.Success && socketAsyncEventArgs_0.BytesTransferred > 0)
				{
					byte[] array = new byte[socketAsyncEventArgs_0.BytesTransferred];
					Array.Copy(socketAsyncEventArgs_0.Buffer, socketAsyncEventArgs_0.Offset, array, 0, socketAsyncEventArgs_0.BytesTransferred);
					if (arc4_1 != null)
					{
						arc4_1.decrypt(array);
					}
					lock (list_0)
					{
						list_0.AddRange(array);
					}
					do
					{
						int num = BitConverter.ToInt32(list_0.GetRange(0, 4).ToArray(), 0);
						if (num > list_0.Count)
						{
							break;
						}
						byte[] data = list_0.GetRange(0, num).ToArray();
						lock (list_0)
						{
							list_0.RemoveRange(0, num);
						}
						if (onRecive_0 != null)
						{
							onRecive_0(data);
						}
						data = null;
					}
					while (list_0.Count > 4);
					array = null;
					if (!socket.ReceiveAsync(socketAsyncEventArgs_0))
					{
						method_3(socketAsyncEventArgs_0);
					}
				}
				else
				{
					method_4();
				}
			}
			catch
			{
			}
		}

		private void method_4()
		{
			try
			{
				if (onCloseCon_0 != null)
				{
					onCloseCon_0();
					Dispose();
				}
			}
			catch
			{
			}
		}

		public void Dispose()
		{
			try
			{
				clientSocket.Shutdown(SocketShutdown.Both);
			}
			catch
			{
			}
			try
			{
				try
				{
					mySocketEventArgs_0.Completed -= method_1;
					mySocketEventArgs_0.SetBuffer(null, 0, 0);
					mySocketEventArgs_0.Dispose();
				}
				catch
				{
					if (mySocketEventArgs_0 != null)
					{
						mySocketEventArgs_0.Dispose();
					}
				}
			}
			catch
			{
			}
			try
			{
				clientSocket.Close();
				list_0 = null;
				arc4_0 = (arc4_1 = null);
			}
			catch
			{
			}
			try
			{
				clientSocket.Dispose();
			}
			catch
			{
			}
		}

		[CompilerGenerated]
		private void VvVnOpsTju(IAsyncResult iasyncResult_0)
		{
			try
			{
				clientSocket.EndConnect(iasyncResult_0);
			}
			catch
			{
			}
			if (clientSocket.Connected)
			{
				initArgs();
				OnCon onCon = onCon_0;
				if (onCon != null)
				{
					onCon();
				}
			}
			else
			{
				OnCloseCon onCloseCon = onCloseCon_0;
				if (onCloseCon != null)
				{
					onCloseCon();
				}
				Dispose();
			}
		}
	}
}
