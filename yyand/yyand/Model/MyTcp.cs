using Org.Mentalis.Network.ProxySocket;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using ZHANHUO.Common;
using ZHANHUO.Model.YYModel;

namespace ZHANHUO.Model
{
	public class MyTcp : IDisposable
	{
		public delegate void OnConnected(bool issuccess, bool iszhongduan = false);

		public delegate void OnRecieved(byte[] bytes);

		public delegate void OnHeart();

		private bool bool_0;

		private TcpClient tcpClient_0;

		private ARC4 arc4_0;

		private ARC4 arc4_1;

		private IPEndPoint ipendPoint_0;

		private ProxySocket proxySocket_0;

		private NetworkStream networkStream_0;

		private System.Timers.Timer timer_0;

		private System.Timers.Timer timer_1;

		private System.Timers.Timer timer_2;

		private System.Timers.Timer timer_3;

		[CompilerGenerated]
		private OnConnected onConnected_0;

		[CompilerGenerated]
		private OnRecieved onRecieved_0;

		[CompilerGenerated]
		private OnHeart onHeart_0;

		private volatile int int_0;

		public uint uid;

		public uint sidnew;

		private ConcurrentQueue<byte[]> concurrentQueue_0;

		private byte[] byte_0 = new byte[8192];

		private static int int_1;

		private static int int_2;

		private static int int_3;

		private static int int_4;

		private bool bool_1;

		public bool MyConnected
		{
			get
			{
				if (tcpClient_0 != null)
				{
					return tcpClient_0.IsOnline();
				}
				return false;
			}
		}

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

		public event OnHeart HeartEvent
		{
			[CompilerGenerated]
			add
			{
				OnHeart onHeart = onHeart_0;
				OnHeart onHeart2;
				do
				{
					onHeart2 = onHeart;
					OnHeart value2 = (OnHeart)Delegate.Combine(onHeart2, value);
					onHeart = Interlocked.CompareExchange(ref onHeart_0, value2, onHeart2);
				}
				while ((object)onHeart != onHeart2);
			}
			[CompilerGenerated]
			remove
			{
				OnHeart onHeart = onHeart_0;
				OnHeart onHeart2;
				do
				{
					onHeart2 = onHeart;
					OnHeart value2 = (OnHeart)Delegate.Remove(onHeart2, value);
					onHeart = Interlocked.CompareExchange(ref onHeart_0, value2, onHeart2);
				}
				while ((object)onHeart != onHeart2);
			}
		}

		public MyTcp(string ip, int port, bool isservice = false, string daili = "", ProxyTypes pt = ProxyTypes.None)
		{
			try
			{
				bool_0 = isservice;
				proxySocket_0 = new ProxySocket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
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
				timer_3 = new System.Timers.Timer(20.0);
				timer_3.Elapsed += timer_3_Elapsed;
				timer_3.AutoReset = true;
				timer_0 = new System.Timers.Timer(20.0);
				timer_0.Elapsed += timer_0_Elapsed;
				timer_0.AutoReset = true;
				timer_1 = new System.Timers.Timer(15000.0);
				timer_1.Elapsed += timer_1_Elapsed;
				timer_1.AutoReset = true;
				timer_2 = new System.Timers.Timer(63000.0);
				timer_2.Elapsed += timer_2_Elapsed;
				timer_2.AutoReset = true;
				concurrentQueue_0 = new ConcurrentQueue<byte[]>();
			}
			catch (Exception ex)
			{
				throw new Exception("ctcp:" + ex.Message);
			}
		}

		private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (Interlocked.Exchange(ref int_1, 1) == 0)
			{
				try
				{
					if (tcpClient_0.Available > 0 && networkStream_0.CanRead)
					{
						byte[] array = new byte[8192];
						int num = networkStream_0.Read(array, 0, array.Length);
						if (num != 0)
						{
							byte[] bytes = array.Take(num).ToArray();
							if (arc4_1 != null)
							{
								arc4_1.decrypt(bytes);
							}
							OnRecieved onRecieved = onRecieved_0;
							if (onRecieved != null)
							{
								onRecieved(bytes);
							}
						}
					}
				}
				catch
				{
				}
				finally
				{
					Interlocked.Exchange(ref int_1, 0);
				}
			}
		}

		private void timer_3_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (Interlocked.Exchange(ref int_2, 1) == 0)
			{
				try
				{
					byte[] result;
					if (networkStream_0.CanWrite && concurrentQueue_0.TryDequeue(out result))
					{
						networkStream_0.Write(result, 0, result.Length);
					}
				}
				catch
				{
				}
				finally
				{
					Interlocked.Exchange(ref int_2, 0);
				}
			}
		}

		private void timer_1_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (Interlocked.Exchange(ref int_3, 1) == 0)
			{
				try
				{
					if (bool_0)
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
					Interlocked.Exchange(ref int_3, 0);
				}
			}
		}

		private void timer_2_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (Interlocked.Exchange(ref int_4, 1) == 0)
			{
				try
				{
					if (uid != 0 && sidnew != 0)
					{
						try
						{
							List<uint> list = new List<uint>();
							list.Add(uid);
							PQueryUserInfoReq obj = new PQueryUserInfoReq
							{
								uidlist = list,
								topSid = sidnew,
								type = 0
							};
							byte[] serverName = bytetool.String2Bytes("channelUserInfo");
							byte[] bytes = default(byte[]);
							using (ByteArray byteArray = new ByteArray(ProtoPacket.pack(obj)))
							{
								PContextField1 pContextField = new PContextField1();
								pContextField.f1 = sidnew;
								ProtoPacket protoPacket = ProtoPacket.unpack(byteArray.Buffer);
								PAPRouter pAPRouter = new PAPRouter();
								pAPRouter.m_objAPHdr.m_pAppUID = new CAppUID();
								pAPRouter.m_objAPHdr.m_pAppUID.m_uAppID = 259u;
								pAPRouter.m_objAPHdr.m_pAppUID.m_uUID.low = uid;
								pAPRouter.m_objAPHdr.m_pRoutingKey = new CRoutingKey();
								pAPRouter.m_objAPHdr.m_pRoutingKey.m_uRealUri = protoPacket.getUri();
								pAPRouter.m_objAPHdr.m_pCompressionInfo = new CCompressionInfo();
								pAPRouter.m_objAPHdr.m_pClientInfo = new CClientInfo();
								pAPRouter.m_objAPHdr.m_pClientInfo.m_serverName = serverName;
								pAPRouter.m_objAPHdr.m_pExtentProp = new CExtentProp();
								MYHashMap mapExtentProp = pAPRouter.m_objAPHdr.m_pExtentProp.m_mapExtentProp;
								uint num = 1u;
								mapExtentProp.put(num.ToString(), ProtoPacket.packNoHeader(pContextField));
								MYHashMap mapExtentProp2 = pAPRouter.m_objAPHdr.m_pExtentProp.m_mapExtentProp;
								num = 3u;
								mapExtentProp2.put(num.ToString(), null);
								pAPRouter.m_strLoad = protoPacket.getBuffer().Buffer;
								pAPRouter.m_ururi = protoPacket.getUri();
								bytes = ProtoPacket.pack(pAPRouter);
								byteArray.Dispose();
							}
							Send(bytes);
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
				finally
				{
					Interlocked.Exchange(ref int_4, 0);
				}
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

		public void startheart()
		{
			timer_1.Enabled = true;
			timer_1.Start();
			timer_3.Interval = 1000.0;
			timer_0.Interval = 1000.0;
		}

		public void stopheart()
		{
			timer_1.Enabled = false;
			timer_1.Stop();
		}

		public void Connect()
		{
			try
			{
				proxySocket_0.Connect(ipendPoint_0);
				if (proxySocket_0.Connected)
				{
					tcpClient_0 = new TcpClient();
					tcpClient_0.ReceiveTimeout = 3000;
					tcpClient_0.Client = proxySocket_0;
					networkStream_0 = tcpClient_0.GetStream();
					networkStream_0.BeginRead(byte_0, 0, byte_0.Length, method_0, networkStream_0);
					timer_3.Enabled = true;
					timer_3.Start();
					OnConnected onConnected = onConnected_0;
					if (onConnected != null)
					{
						onConnected(true, false);
					}
				}
				else
				{
					OnConnected onConnected2 = onConnected_0;
					if (onConnected2 != null)
					{
						onConnected2(false, false);
					}
				}
			}
			catch
			{
				OnConnected onConnected3 = onConnected_0;
				if (onConnected3 != null)
				{
					onConnected3(false, false);
				}
			}
		}

		private void method_0(IAsyncResult iasyncResult_0)
		{
			NetworkStream networkStream = (NetworkStream)iasyncResult_0.AsyncState;
			try
			{
				int num = networkStream.EndRead(iasyncResult_0);
				if (num > 0)
				{
					byte[] bytes = byte_0.Take(num).ToArray();
					if (arc4_1 != null)
					{
						arc4_1.decrypt(bytes);
					}
					OnRecieved onRecieved = onRecieved_0;
					if (onRecieved != null)
					{
						onRecieved(bytes);
					}
				}
				byte_0 = new byte[8192];
				networkStream.BeginRead(byte_0, 0, byte_0.Length, method_0, networkStream);
			}
			catch
			{
			}
		}

		public void Send(byte[] bytes)
		{
			try
			{
				if (arc4_0 != null)
				{
					arc4_0.encrypt(bytes);
				}
				concurrentQueue_0.Enqueue(bytes);
			}
			catch
			{
			}
		}

		public void SendSync(byte[] bytes)
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

		protected virtual void Dispose(bool disposing)
		{
			if (!bool_1)
			{
				if (disposing)
				{
					try
					{
						timer_0.Enabled = false;
						timer_0.Stop();
						timer_0.Dispose();
					}
					catch
					{
					}
					try
					{
						timer_3.Enabled = false;
						timer_3.Stop();
						timer_3.Dispose();
					}
					catch
					{
					}
					try
					{
						timer_1.Enabled = false;
						timer_1.Stop();
						timer_1.Dispose();
					}
					catch
					{
					}
					try
					{
						timer_2.Enabled = false;
						timer_2.Stop();
						timer_2.Dispose();
					}
					catch
					{
					}
					try
					{
						tcpClient_0.GetStream().Close();
					}
					catch
					{
					}
					try
					{
						proxySocket_0.Close();
						proxySocket_0.Dispose();
					}
					catch
					{
					}
					try
					{
						tcpClient_0.Close();
					}
					catch
					{
					}
					arc4_0 = (arc4_1 = null);
				}
				bool_1 = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
		}
	}
}
