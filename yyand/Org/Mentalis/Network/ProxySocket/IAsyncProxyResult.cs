using System;
using System.Threading;

namespace Org.Mentalis.Network.ProxySocket
{
	internal class IAsyncProxyResult : IAsyncResult
	{
		private bool bool_0;

		private object object_0;

		private ManualResetEvent manualResetEvent_0;

		public bool IsCompleted
		{
			get
			{
				return bool_0;
			}
		}

		public bool CompletedSynchronously
		{
			get
			{
				return false;
			}
		}

		public object AsyncState
		{
			get
			{
				return object_0;
			}
		}

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				if (manualResetEvent_0 == null)
				{
					manualResetEvent_0 = new ManualResetEvent(false);
				}
				return manualResetEvent_0;
			}
		}

		internal IAsyncProxyResult(object stateObject = null)
		{
			object_0 = stateObject;
			bool_0 = false;
			if (manualResetEvent_0 != null)
			{
				manualResetEvent_0.Reset();
			}
		}

		internal void Reset()
		{
			object_0 = null;
			bool_0 = true;
			if (manualResetEvent_0 != null)
			{
				manualResetEvent_0.Set();
			}
		}
	}
}
