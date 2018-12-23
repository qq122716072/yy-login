using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ZHANHUO.Common
{
	public class loghelper
	{
		private static ConcurrentQueue<logobj> concurrentQueue_0;

		private static ConcurrentQueue<logobj> concurrentQueue_1;

		static loghelper()
		{
			concurrentQueue_0 = new ConcurrentQueue<logobj>();
			concurrentQueue_1 = new ConcurrentQueue<logobj>();
			Task.Factory.StartNew(delegate
			{
				while (true)
				{
					try
					{
						if (concurrentQueue_0.Count > 0)
						{
							logobj result2;
							concurrentQueue_0.TryDequeue(out result2);
							if (result2 != null)
							{
								log(result2.path, result2.msg);
							}
						}
					}
					catch
					{
					}
					Thread.Sleep(10);
				}
			});
			Task.Factory.StartNew(delegate
			{
				while (true)
				{
					try
					{
						if (concurrentQueue_1.Count > 0)
						{
							logobj result;
							concurrentQueue_1.TryDequeue(out result);
							if (result != null)
							{
								logappend(result.path, result.msg);
							}
						}
					}
					catch
					{
					}
					Thread.Sleep(10);
				}
			});
		}

		private static void smethod_0(object object_0, object object_1)
		{
			try
			{
				if (concurrentQueue_0.Count > 0)
				{
					logobj result;
					concurrentQueue_0.TryDequeue(out result);
					if (result != null)
					{
						log(result.path, result.msg);
					}
				}
				if (concurrentQueue_1.Count > 0)
				{
					logobj result2;
					concurrentQueue_1.TryDequeue(out result2);
					if (result2 != null)
					{
						logappend(result2.path, result2.msg);
					}
				}
			}
			catch
			{
			}
		}

		public static void logcacge(string path, string msg)
		{
			try
			{
				concurrentQueue_0.Enqueue(new logobj
				{
					path = path,
					msg = msg
				});
			}
			catch
			{
			}
		}

		public static void loglogs(string path, string msg)
		{
			try
			{
				if (!string.IsNullOrWhiteSpace(path))
				{
					concurrentQueue_1.Enqueue(new logobj
					{
						path = path,
						msg = msg
					});
				}
			}
			catch
			{
			}
		}

		public static void logappend(string path, string msg)
		{
			try
			{
				using (FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write))
				{
					using (StreamWriter streamWriter = new StreamWriter(fileStream))
					{
						streamWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " ---- " + msg);
						streamWriter.Flush();
						streamWriter.Close();
						streamWriter.Dispose();
					}
					fileStream.Close();
					fileStream.Dispose();
				}
			}
			catch
			{
			}
		}

		public static bool log(string path, string msg)
		{
			try
			{
				using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
				{
					using (StreamWriter streamWriter = new StreamWriter(fileStream))
					{
						streamWriter.Write(msg);
						streamWriter.Flush();
						streamWriter.Close();
						streamWriter.Dispose();
					}
					fileStream.Close();
					fileStream.Dispose();
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
