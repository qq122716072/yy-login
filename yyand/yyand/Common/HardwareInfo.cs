using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace ZHANHUO.Common
{
	public class HardwareInfo
	{
		public enum NCBCONST
		{
			NCBNAMSZ = 0x10,
			MAX_LANA = 254,
			NCBENUM = 55,
			NRC_GOODRET = 0,
			NCBRESET = 50,
			NCBASTAT = 51,
			NUM_NAMEBUF = 30
		}

		public struct ADAPTER_STATUS
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
			public byte[] adapter_address;

			public byte rev_major;

			public byte reserved0;

			public byte adapter_type;

			public byte rev_minor;

			public ushort duration;

			public ushort frmr_recv;

			public ushort frmr_xmit;

			public ushort iframe_recv_err;

			public ushort xmit_aborts;

			public uint xmit_success;

			public uint recv_success;

			public ushort iframe_xmit_err;

			public ushort recv_buff_unavail;

			public ushort t1_timeouts;

			public ushort ti_timeouts;

			public uint reserved1;

			public ushort free_ncbs;

			public ushort max_cfg_ncbs;

			public ushort max_ncbs;

			public ushort xmit_buf_unavail;

			public ushort max_dgram_size;

			public ushort pending_sess;

			public ushort max_cfg_sess;

			public ushort max_sess;

			public ushort max_sess_pkt_size;

			public ushort name_count;
		}

		public struct NAME_BUFFER
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			public byte[] name;

			public byte name_num;

			public byte name_flags;
		}

		public struct NCB
		{
			public byte ncb_command;

			public byte ncb_retcode;

			public byte ncb_lsn;

			public byte ncb_num;

			public IntPtr ncb_buffer;

			public ushort ncb_length;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			public byte[] ncb_callname;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			public byte[] ncb_name;

			public byte ncb_rto;

			public byte ncb_sto;

			public IntPtr ncb_post;

			public byte ncb_lana_num;

			public byte ncb_cmd_cplt;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
			public byte[] ncb_reserve;

			public IntPtr ncb_event;
		}

		public struct LANA_ENUM
		{
			public byte length;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 254)]
			public byte[] lana;
		}

		[StructLayout(LayoutKind.Auto)]
		public struct ASTAT
		{
			public ADAPTER_STATUS adapt;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
			public NAME_BUFFER[] NameBuff;
		}

		public class Win32API
		{
			[DllImport("NETAPI32.DLL")]
			public static extern char Netbios(ref NCB ncb);
		}

		public static string GetInfo()
		{
			StringBuilder stringBuilder = new StringBuilder("tempip");
			List<IPAddress> list = (from ip in Dns.GetHostAddresses(Dns.GetHostName())
			where ip.AddressFamily == AddressFamily.InterNetwork
			select ip).ToList();
			if (list != null && list.Count > 0)
			{
				using (List<IPAddress>.Enumerator enumerator = list.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						IPAddress current = enumerator.Current;
						stringBuilder.Append(current.ToString());
					}
				}
			}
			stringBuilder.Append("LZQ123LMH4QWER");
			stringBuilder.Append(GetMacAddress());
			stringBuilder.Append("llz");
			stringBuilder.Append(GetHardDiskID());
			stringBuilder.Append("lzq");
			stringBuilder.Append(GetCpuID());
			stringBuilder.Append("lmh");
			stringBuilder.Append(GetMacAddress());
			stringBuilder.Append("zsn");
			return MyEncryptMacCode.GetMD5(stringBuilder.ToString());
		}

		public static string GetMotherBoardSerialNumber()
		{
			ManagementObjectCollection instances = new ManagementClass("WIN32_BaseBoard").GetInstances();
			string result = "";
			using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
			{
				if (managementObjectEnumerator.MoveNext())
				{
					return ((ManagementObject)managementObjectEnumerator.Current)["SerialNumber"].ToString();
				}
				return result;
			}
		}

		public static string GetCpuID()
		{
			try
			{
				ManagementObjectCollection instances = new ManagementClass("Win32_Processor").GetInstances();
				string result = null;
				using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
				{
					if (managementObjectEnumerator.MoveNext())
					{
						result = ((ManagementObject)managementObjectEnumerator.Current).Properties["ProcessorId"].Value.ToString();
					}
				}
				return result;
			}
			catch
			{
				return "";
			}
		}

		public static string GetHardDiskID()
		{
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
				string result = null;
				using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
				{
					if (managementObjectEnumerator.MoveNext())
					{
						result = ((ManagementObject)managementObjectEnumerator.Current)["SerialNumber"].ToString().Trim();
					}
				}
				return result;
			}
			catch
			{
				return "";
			}
		}

		public static string GetMacAddress()
		{
			string text = "";
			try
			{
				NCB ncb = default(NCB);
				ncb.ncb_command = 55;
				int num = Marshal.SizeOf(typeof(LANA_ENUM));
				ncb.ncb_buffer = Marshal.AllocHGlobal(num);
				ncb.ncb_length = (ushort)num;
				char num2 = Win32API.Netbios(ref ncb);
				LANA_ENUM lANA_ENUM = (LANA_ENUM)Marshal.PtrToStructure(ncb.ncb_buffer, typeof(LANA_ENUM));
				Marshal.FreeHGlobal(ncb.ncb_buffer);
				if (num2 != 0)
				{
					return "";
				}
				for (int i = 0; i < lANA_ENUM.length; i++)
				{
					ncb.ncb_command = 50;
					ncb.ncb_lana_num = lANA_ENUM.lana[i];
					if (Win32API.Netbios(ref ncb) != 0)
					{
						return "";
					}
					ncb.ncb_command = 51;
					ncb.ncb_lana_num = lANA_ENUM.lana[i];
					ncb.ncb_callname[0] = 42;
					num = Marshal.SizeOf(typeof(ADAPTER_STATUS)) + Marshal.SizeOf(typeof(NAME_BUFFER)) * 30;
					ncb.ncb_buffer = Marshal.AllocHGlobal(num);
					ncb.ncb_length = (ushort)num;
					char num3 = Win32API.Netbios(ref ncb);
					ASTAT aSTAT = default(ASTAT);
					aSTAT.adapt = (ADAPTER_STATUS)Marshal.PtrToStructure(ncb.ncb_buffer, typeof(ADAPTER_STATUS));
					Marshal.FreeHGlobal(ncb.ncb_buffer);
					if (num3 == '\0')
					{
						if (i > 0)
						{
							text += ":";
						}
						text = string.Format("{0,2:X}{1,2:X}{2,2:X}{3,2:X}{4,2:X}{5,2:X}", aSTAT.adapt.adapter_address[0], aSTAT.adapt.adapter_address[1], aSTAT.adapt.adapter_address[2], aSTAT.adapt.adapter_address[3], aSTAT.adapt.adapter_address[4], aSTAT.adapt.adapter_address[5]);
					}
				}
			}
			catch
			{
			}
			return text.Replace(' ', '0');
		}
	}
}
