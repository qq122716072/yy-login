using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZHANHUO.Common;

namespace ZHANHUO.Model
{
	public class initip
	{
		private string string_0 = "780fd3ab525498633122030c06cf89cb";

		private string string_1 = "8.45.0.1";

		private string string_2 = "0000D082";

		private string string_3 = "yy";

		private volatile int int_0;

		private ConcurrentBag<myip> concurrentBag_0;

		private Random random_0 = new Random();

		private string string_4 = "";

		public initip(int ic, ConcurrentBag<myip> il)
		{
			int_0 = ic;
			concurrentBag_0 = il;
		}

		public initip(ConcurrentBag<myip> il)
		{
			concurrentBag_0 = il;
		}

		public initip(string mcode)
		{
			string_4 = mcode;
		}

		public void getwebipsnew(string sid, string subid)
		{
			try
			{
				string string_ = string.Format("http://123.207.144.61:8888/pro/88881");
				string str = JsonConvert.SerializeObject(new prorequest
				{
					sid = sid,
					subid = subid
				});
				str = MyEncrypt.AesEncryptor(str);
				string string_2 = JsonConvert.SerializeObject(new sendrequest
				{
					json = str
				});
				dynamic val = JsonConvert.DeserializeObject<object>(method_0(string_, string_2));
				List<myip> list = JsonConvert.DeserializeObject<List<myip>>(MyEncrypt.AesDecryptor((string)val.ret));
				if (list != null)
				{
					foreach (myip item in list)
					{
						concurrentBag_0.Add(item);
					}
				}
			}
			catch
			{
			}
		}

		private string method_0(string string_5, string string_6 = null)
		{
			string result = string.Empty;
			HttpWebRequest httpWebRequest = null;
			HttpWebResponse httpWebResponse = null;
			Stream stream = null;
			StreamReader streamReader = null;
			try
			{
				httpWebRequest = (HttpWebRequest)WebRequest.Create(string_5);
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/json";
				httpWebRequest.ReadWriteTimeout = 30000;
				byte[] bytes = Encoding.UTF8.GetBytes(string_6);
				httpWebRequest.ContentLength = bytes.Length;
				using (stream = httpWebRequest.GetRequestStream())
				{
					stream.Write(bytes, 0, bytes.Length);
					stream.Close();
				}
				httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				using (streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
				{
					result = streamReader.ReadToEnd();
					return result;
				}
			}
			catch (Exception)
			{
				return result;
			}
			finally
			{
				if (httpWebRequest != null)
				{
					httpWebRequest.Abort();
					httpWebRequest = null;
				}
				if (httpWebResponse != null)
				{
					httpWebResponse.Dispose();
					httpWebResponse = null;
				}
				if (stream != null)
				{
					stream.Close();
					stream.Dispose();
				}
				if (streamReader != null)
				{
					streamReader.Close();
					streamReader.Dispose();
				}
			}
		}

		public void getapips()
		{
			IPAddress[] lips = Dns.GetHostEntry("aplbs.yy.com").AddressList;
			if (lips == null || lips.Count() == 0)
			{
				throw new Exception("DNS 解析错误");
			}
			int[] lports = new int[22]
			{
				8088,
				8084,
				8080,
				8091,
				8082,
				8083,
				80,
				4002,
				20800,
				23,
				32004,
				28,
				4002,
				5002,
				6002,
				23,
				80,
				87,
				3001,
				8080,
				8008,
				6001
			};
			while (concurrentBag_0.Count < int_0)
			{
				Task.Factory.StartNew(delegate
				{
					string ip = lips[random_0.Next(0, lips.Length)].ToString();
					int port = lports[random_0.Next(0, lports.Length)];
					InitTcp initTcp = new InitTcp(ip, port);
					if (initTcp.connect())
					{
						Send_1E73(initTcp);
					}
					else
					{
						initTcp.dispose();
					}
				});
				Thread.Sleep(1000);
			}
		}

		public void Send_1E73(InitTcp tcp)
		{
			try
			{
				byte[] buffer = default(byte[]);
				using (ByteArray byteArray = new ByteArray())
				{
					byteArray.endian = Endian.LITTLE_ENDIAN;
					byteArray.position = 4;
					byteArray.writeBytes(bytetool.strToToHexByte("1E730000"));
					byteArray.writeShort(200);
					byteArray.method_2(-1);
					byteArray.method_2(-1);
					byteArray.writeBytes(bytetool.strToToHexByte("03010000"));
					byteArray.method_2(0);
					byteArray.writeUTF(Guid.NewGuid().ToString("N"));
					byteArray.writeBytes(bytetool.strToToHexByte(string_2));
					byteArray.writeUTF(string_1);
					byteArray.writeUTF(string_3);
					byteArray.method_2(0);
					byteArray.method_2(0);
					byteArray.writeBytes(bytetool.strToToHexByte("00000408"));
					byteArray.method_2(0);
					byteArray.method_2(0);
					byteArray.position = 0;
					byteArray.writeUnsignedInt(Convert.ToUInt32(byteArray.length));
					buffer = byteArray.Buffer;
					byteArray.Dispose();
				}
				tcp.send(buffer);
				Thread.Sleep(200);
				processdata(tcp);
			}
			catch (Exception)
			{
				tcp.dispose();
			}
		}

		public void Recv_1E74(byte[] data, InitTcp tcp)
		{
			try
			{
				using (ByteArray byteArray = new ByteArray(data))
				{
					byteArray.readUnsignedInt();
					byteArray.readUnsignedInt();
					byteArray.readUnsignedShort();
					byteArray.readUnsignedInt();
					byteArray.readUnsignedInt();
					byteArray.readUnsignedShort();
					uint num = byteArray.readUnsignedInt();
					for (int i = 0; i < num; i++)
					{
						int length = byteArray.readUnsignedShort();
						string ip = byteArray.readUTFBytes((uint)length);
						byteArray.readUnsignedInt();
						uint num2 = byteArray.readUnsignedInt();
						myip mi = new myip();
						mi.ip = ip;
						mi.ports = new int[num2];
						for (int j = 0; j < num2; j++)
						{
							ushort num3 = byteArray.readUnsignedShort();
							mi.ports[j] = num3;
						}
						if (concurrentBag_0.Count(delegate(myip p)
						{
							if (p.ip == ip)
							{
								return p.ports[0] == mi.ports[0];
							}
							return false;
						}) == 0 && num2 == 2)
						{
							concurrentBag_0.Add(mi);
						}
					}
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				if (tcp != null)
				{
					tcp.dispose();
				}
			}
		}

		public void processdata(InitTcp tcp)
		{
			try
			{
				byte[] array = tcp.recive();
				if (array == null || array.Length == 0)
				{
					throw new Exception("接收数据为空");
				}
				if (bytetool.fromArray(array, false).Substring(8, 4).ToUpper() == "1E74")
				{
					Recv_1E74(array, tcp);
				}
			}
			catch (Exception)
			{
				tcp.dispose();
			}
		}

		public dynamic auth()
		{
			try
			{
				string string_ = string.Format("{0}/newauth/19999", "http://119.29.84.129:6677");
				string string_2 = JsonConvert.SerializeObject(new authrequest
				{
					MDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
					MAC = MyEncrypt.AesEncryptor(string_4)
				});
				return JsonConvert.DeserializeObject<object>(method_0(string_, string_2));
			}
			catch (Exception)
			{
				return null;
			}
		}

		public dynamic authgift()
		{
			try
			{
				string string_ = string.Format("{0}/newauth/12345", "http://119.29.84.129:8888");
				string string_2 = JsonConvert.SerializeObject(new authrequest
				{
					MDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
					MAC = MyEncrypt.AesEncryptor(string_4)
				});
				return JsonConvert.DeserializeObject<object>(method_0(string_, string_2));
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
