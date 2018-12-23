using Newtonsoft.Json;
using Org.Mentalis.Network.ProxySocket;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using ZHANHUO.Common;
using ZHANHUO.Model.YYModel;

namespace ZHANHUO.Model
{
    public class MyUser1225
    {
        public delegate void OnYongJi();

        public delegate void OnGetUserCount(uint uint_0);

        public delegate void OnGetUserList(uint uint_0, List<uint> list_0);

        [CompilerGenerated]
        private OnYongJi onYongJi_0;

        [CompilerGenerated]
        private OnGetUserCount onGetUserCount_0;

        [CompilerGenerated]
        private OnGetUserList onGetUserList_0;

        [CompilerGenerated]
        private int int_0;

        [CompilerGenerated]
        private string string_0;

        [CompilerGenerated]
        private string string_1;

        [CompilerGenerated]
        private string string_2;

        [CompilerGenerated]
        private int int_1;

        [CompilerGenerated]
        private bool bool_0;

        [CompilerGenerated]
        private int int_2;

        [CompilerGenerated]
        private int int_3;

        [CompilerGenerated]
        private int int_4;

        [CompilerGenerated]
        private uint uint_0;

        [CompilerGenerated]
        private string string_3;

        [CompilerGenerated]
        private string string_4;

        [CompilerGenerated]
        private uint uint_1;

        [CompilerGenerated]
        private uint uint_2;

        [CompilerGenerated]
        private uint uint_3;

        [CompilerGenerated]
        private uint uint_4;

        [CompilerGenerated]
        private uint uint_5;

        [CompilerGenerated]
        private string string_5;

        [CompilerGenerated]
        private MyTcp1225 myTcp1225_0;

        [CompilerGenerated]
        private string string_6;

        [CompilerGenerated]
        private int int_5;

        [CompilerGenerated]
        private int int_6;

        [CompilerGenerated]
        private ProxyTypes proxyTypes_0;

        [CompilerGenerated]
        private string string_7;

        [CompilerGenerated]
        private string string_8;

        [CompilerGenerated]
        private int int_7;

        [CompilerGenerated]
        private bool bool_1;

        [CompilerGenerated]
        private byte[] byte_0;

        private string string_9;

        [CompilerGenerated]
        private DateTime dateTime_0;

        [CompilerGenerated]
        private DateTime dateTime_1;

        [CompilerGenerated]
        private DateTime dateTime_2;

        [CompilerGenerated]
        private DateTime dateTime_3;

        [CompilerGenerated]
        private DateTime dateTime_4;

        private System.Timers.Timer timer_0;

        [CompilerGenerated]
        private string string_10;

        [CompilerGenerated]
        private int int_8;

        [CompilerGenerated]
        private bool bool_2;

        [CompilerGenerated]
        private bool bool_3;

        [CompilerGenerated]
        private bool bool_4;

        [CompilerGenerated]
        private string string_11;

        [CompilerGenerated]
        private bool bool_5;

        [CompilerGenerated]
        private string string_12;

        [CompilerGenerated]
        private bool bool_6;

        [CompilerGenerated]
        private bool bool_7;

        [CompilerGenerated]
        private int int_9;

        [CompilerGenerated]
        private DateTime dateTime_5;

        [CompilerGenerated]
        private DateTime dateTime_6;

        [CompilerGenerated]
        private bool bool_8;

        [CompilerGenerated]
        private List<duoip> list_0;

        [CompilerGenerated]
        private int int_10;

        [CompilerGenerated]
        private bool bool_9;

        [CompilerGenerated]
        private MyTcp1225 myTcp1225_1;

        [CompilerGenerated]
        private bool bool_10;

        [CompilerGenerated]
        private bool bool_11;

        [CompilerGenerated]
        private bool bool_12;

        [CompilerGenerated]
        private bool bool_13;

        [CompilerGenerated]
        private string string_13;

        [CompilerGenerated]
        private int int_11;

        [CompilerGenerated]
        private DateTime dateTime_7;

        private int int_12;

        private volatile int int_13;

        private int int_14;

        private volatile int int_15;

        private byte[] byte_1;

        private byte[] byte_2;

        public volatile int send04d6;

        public int index
        {
            get;
            set;
        }

        public string passport
        {
            get;
            set;
        }

        public string pwd
        {
            get;
            set;
        }

        public string pwden
        {
            get;
            set;
        }

        public int logintype
        {
            get;
            set;
        }

        public bool isfenghao
        {
            get;
            set;
        }

        public int loginstatus
        {
            get;
            set;
        }

        public int joinstatus
        {
            get;
            set;
        }

        public int status
        {
            get;
            set;
        }

        public string statusstr
        {
            get
            {
                if (isfenghao)
                {
                    if (status == 33)
                    {
                        if (mytrace.Contains("MMCW"))
                        {
                            return "密码错误";
                        }
                        return "频道不存在";
                    }
                    return "封号";
                }
                if (status == 0)
                {
                    return "";
                }
                if (status == 2)
                {
                    if (mytrace.Contains("SUC"))
                    {
                        return "频道在线";
                    }
                    if (mytrace.Contains("登录成功"))
                    {
                        return "频道在线";
                    }
                    if (mytrace.Contains("切换频道"))
                    {
                        return "切换频道";
                    }
                }
                if (status == 1)
                {
                    if (mytrace.Contains("mima"))
                    {
                        return "登录中";
                    }
                    if (mytrace.Contains("UF"))
                    {
                        return "登录中";
                    }
                    if (mytrace.Contains("tuichu"))
                    {
                        return "";
                    }
                    return "登录中";
                }
                return "";
            }
        }

        public uint uid
        {
            get;
            set;
        }

        public string username
        {
            get;
            set;
        }

        public string qianming
        {
            get;
            set;
        }

        public uint sid
        {
            get;
            set;
        }

        public uint sid_l
        {
            get;
            set;
        }

        public uint subid
        {
            get;
            set;
        }

        public uint sidnew
        {
            get;
            set;
        }

        public uint subidnew
        {
            get;
            set;
        }

        public string nicheng
        {
            get;
            set;
        }

        public string jifen
        {
            get;
            set;
        }

        public MyTcp1225 logintcp
        {
            get;
            set;
        }

        public string apip
        {
            get;
            set;
        }

        public int apport
        {
            get;
            set;
        }

        public int heartbeat
        {
            get;
            set;
        }

        public ProxyTypes pt
        {
            get;
            set;
        }

        public string daili
        {
            get;
            set;
        }

        public string dailistr
        {
            get
            {
                try
                {
                    if (status < 3)
                    {
                        if (!ishidedaili)
                        {
                            if (pt == ProxyTypes.None)
                            {
                                if (logintcp == null)
                                {
                                    return "";
                                }
                                object obj = logintcp.clientSocket?.LocalEndPoint?.ToString();
                                return ((string)obj) ?? "";
                            }
                            if (logintcp == null)
                            {
                                return "";
                            }
                            object obj2 = logintcp.clientSocket?.ProxyEndPoint?.ToString();
                            return ((string)obj2) ?? "";
                        }
                        if (pt == ProxyTypes.None)
                        {
                            if (logintcp == null)
                            {
                                return "";
                            }
                            object obj3 = logintcp.clientSocket?.LocalEndPoint?.ToString();
                            return ((string)obj3) ?? "";
                        }
                        return "";
                    }
                    return "";
                }
                catch
                {
                    return "";
                }
            }
        }

        public string yanzhengma
        {
            get;
            set;
        }

        public int currentflag
        {
            get;
            set;
        }

        public bool isudblogin
        {
            get;
            set;
        }

        public byte[] yycookie
        {
            get;
            set;
        }

        public string mytrace
        {
            get
            {
                return string_9;
            }
            set
            {
                string_9 = (isudblogin ? "2-" : "") + value + "-" + DateTime.Now.ToString("HHmmss");
            }
        }

        public DateTime lastsendtime
        {
            get;
            set;
        }

        public DateTime lastrecivetime
        {
            get;
            set;
        }

        public DateTime lastonlinetime
        {
            get;
            set;
        }

        public DateTime jointime
        {
            get;
            set;
        }

        public DateTime startlogintime
        {
            get;
            set;
        }

        public string lol
        {
            get
            {
                if (lastonlinetime == DateTime.MinValue)
                {
                    return "";
                }
                return lastonlinetime.ToString("HHmm");
            }
        }

        public string localip
        {
            get;
            set;
        }

        public int renzhenshibai
        {
            get;
            set;
        }

        public bool isskip
        {
            get;
            set;
        }

        public bool istuichu
        {
            get;
            set;
        }

        public bool isupdate
        {
            get;
            set;
        }

        public string autotoken
        {
            get;
            set;
        }

        public bool isyongji
        {
            get;
            set;
        }

        public string pcinfo
        {
            get;
            set;
        }

        public bool ishidedaili
        {
            get;
            set;
        }

        public bool xiugaisuiji
        {
            get;
            set;
        }

        public int yongjitimes
        {
            get;
            set;
        }

        public DateTime tihaotime
        {
            get;
            set;
        }

        public bool ishunhejin
        {
            get;
            set;
        }

        public List<duoip> listduoip
        {
            get;
            set;
        }

        public int tihaocishu
        {
            get;
            set;
        }

        public bool isgongneng
        {
            get;
            set;
        }

        public MyTcp1225 servicetcp
        {
            get;
            set;
        }

        public bool isxianche
        {
            get;
            set;
        }

        public bool isxianchewancheng
        {
            get;
            set;
        }

        public bool isqutubiao
        {
            get;
            set;
        }

        public bool isloginservice
        {
            get;
            set;
        }

        public string serviceip
        {
            get;
            set;
        }

        public int serviceport
        {
            get;
            set;
        }

        public DateTime startconnectservice
        {
            get;
            set;
        }

        public static bool zidongbuhao
        {
            get;
            internal set;
        }
        public Action YongJiEvent { get; internal set; }
        public Action<uint> GetUserCountEvent { get; internal set; }

        public event OnYongJi Event_0
        {
            [CompilerGenerated]
            add
            {
                OnYongJi onYongJi = onYongJi_0;
                OnYongJi onYongJi2;
                do
                {
                    onYongJi2 = onYongJi;
                    OnYongJi value2 = (OnYongJi)Delegate.Combine(onYongJi2, value);
                    onYongJi = Interlocked.CompareExchange(ref onYongJi_0, value2, onYongJi2);
                }
                while ((object)onYongJi != onYongJi2);
            }
            [CompilerGenerated]
            remove
            {
                OnYongJi onYongJi = onYongJi_0;
                OnYongJi onYongJi2;
                do
                {
                    onYongJi2 = onYongJi;
                    OnYongJi value2 = (OnYongJi)Delegate.Remove(onYongJi2, value);
                    onYongJi = Interlocked.CompareExchange(ref onYongJi_0, value2, onYongJi2);
                }
                while ((object)onYongJi != onYongJi2);
            }
        }

        public event OnGetUserCount Event_1
        {
            [CompilerGenerated]
            add
            {
                OnGetUserCount onGetUserCount = onGetUserCount_0;
                OnGetUserCount onGetUserCount2;
                do
                {
                    onGetUserCount2 = onGetUserCount;
                    OnGetUserCount value2 = (OnGetUserCount)Delegate.Combine(onGetUserCount2, value);
                    onGetUserCount = Interlocked.CompareExchange(ref onGetUserCount_0, value2, onGetUserCount2);
                }
                while ((object)onGetUserCount != onGetUserCount2);
            }
            [CompilerGenerated]
            remove
            {
                OnGetUserCount onGetUserCount = onGetUserCount_0;
                OnGetUserCount onGetUserCount2;
                do
                {
                    onGetUserCount2 = onGetUserCount;
                    OnGetUserCount value2 = (OnGetUserCount)Delegate.Remove(onGetUserCount2, value);
                    onGetUserCount = Interlocked.CompareExchange(ref onGetUserCount_0, value2, onGetUserCount2);
                }
                while ((object)onGetUserCount != onGetUserCount2);
            }
        }

        public event OnGetUserList Event_2
        {
            [CompilerGenerated]
            add
            {
                OnGetUserList onGetUserList = onGetUserList_0;
                OnGetUserList onGetUserList2;
                do
                {
                    onGetUserList2 = onGetUserList;
                    OnGetUserList value2 = (OnGetUserList)Delegate.Combine(onGetUserList2, value);
                    onGetUserList = Interlocked.CompareExchange(ref onGetUserList_0, value2, onGetUserList2);
                }
                while ((object)onGetUserList != onGetUserList2);
            }
            [CompilerGenerated]
            remove
            {
                OnGetUserList onGetUserList = onGetUserList_0;
                OnGetUserList onGetUserList2;
                do
                {
                    onGetUserList2 = onGetUserList;
                    OnGetUserList value2 = (OnGetUserList)Delegate.Remove(onGetUserList2, value);
                    onGetUserList = Interlocked.CompareExchange(ref onGetUserList_0, value2, onGetUserList2);
                }
                while ((object)onGetUserList != onGetUserList2);
            }
        }

        [CompilerGenerated]
        private DateTime method_0()
        {
            return dateTime_5;
        }

        [CompilerGenerated]
        private void method_1(DateTime dateTime_8)
        {
            dateTime_5 = dateTime_8;
        }

        public MyUser1225()
        {
            string_9 = "";
            int_12 = 600;
            DateTime dateTime = lastrecivetime = DateTime.MinValue;
            DateTime dateTime2 = dateTime;
            dateTime = (lastsendtime = dateTime2);
            DateTime dateTime4 = dateTime;
            dateTime = (lastonlinetime = dateTime4);
            DateTime dateTime6 = dateTime;
            dateTime = (jointime = dateTime6);
            DateTime dateTime8 = dateTime;
            DateTime dateTime10 = startconnectservice = dateTime8;
            dateTime = (tihaotime = dateTime10);
            string text3 = apip = (daili = "");
            isgongneng = false;
            localip = "";
            renzhenshibai = 0;
            isupdate = false;
            isyongji = false;
            pcinfo = Guid.NewGuid().ToString("N").ToUpper();
            autotoken = "";
            ishidedaili = false;
            xiugaisuiji = false;
            yongjitimes = 0;
            method_1(DateTime.MinValue);
            isxianchewancheng = false;
            ishunhejin = false;
            listduoip = new List<duoip>();
            tihaocishu = 0;
        }

        private string method_2(int int_16)
        {
            try
            {
                return Guid.NewGuid().ToString("N").Substring(0, int_16);
            }
            catch
            {
                return "140915bbef";
            }
        }

        public void StartJoin()
        {
            if (logintcp != null)
            {
                try
                {
                    logintcp.SendEvent -= method_5;
                    logintcp.ReciveEvent -= method_4;
                    logintcp.CloseConEvent -= method_6;
                    logintcp.ConEvent -= method_3;
                }
                catch
                {
                }
                try
                {
                    logintcp.Dispose();
                    logintcp = null;
                }
                catch
                {
                }
            }
            isxianchewancheng = false;
            istuichu = false;
            isskip = false;
            status = 1;
            joinstatus = 1;
            tihaotime = DateTime.MinValue;
            method_1(DateTime.MinValue);
            if (isgongneng)
            {
                if ((logintype == 1 && isudblogin) || logintype == 2)
                {
                    pt = ProxyTypes.None;
                    daili = "";
                }
            }
            else if (((logintype == 1 && isudblogin) || logintype == 2) && !isyongji)
            {
                pt = ProxyTypes.None;
                daili = "";
            }
            if (!ishunhejin && isudblogin)
            {
                pt = ProxyTypes.None;
                daili = "";
            }
            mytrace = "S-J";
            int_15 = 0;
            try
            {
                logintcp = new MyTcp1225(apip, apport, pt, daili, localip);
                logintcp.SendEvent += method_5;
                logintcp.ReciveEvent += method_4;
                logintcp.CloseConEvent += method_6;
                logintcp.ConEvent += method_3;
                logintcp.Connect();
            }
            catch
            {
                mytrace = "CON-ERR";
                ZhuDongDK((rdomhelper.getrandom(0, 100) <= 50) ? (-1) : 0);
                return;
            }
            try
            {
                if (timer_0 == null)
                {
                    timer_0 = new System.Timers.Timer();
                    timer_0.Interval = 1000.0;
                    timer_0.Elapsed += timer_0_Elapsed;
                }
                timer_0.Enabled = true;
                timer_0.Start();
            }
            catch
            {
            }
        }

        private void method_3()
        {
            try
            {
                int_15 = 0;
                method_7();
            }
            catch
            {
            }
        }

        public void ZhuDongDK(int int_16)
        {
            try
            {
                if (timer_0 != null)
                {
                    timer_0.Enabled = false;
                    timer_0.Stop();
                }
            }
            catch
            {
            }
            try
            {
                daili = "";
                pt = ProxyTypes.None;
                if (status < 3)
                {
                    status = 1;
                }
                joinstatus = int_16;
                heartbeat = 0;
                currentflag = 10000;
                lastonlinetime = DateTime.MinValue;
                if (logintcp != null)
                {
                    logintcp.SendEvent -= method_5;
                    logintcp.ReciveEvent -= method_4;
                    logintcp.CloseConEvent -= method_6;
                    logintcp.ConEvent -= method_3;
                    logintcp.Dispose();
                }
                int_15 = 0;
            }
            catch
            {
            }
            try
            {
                if (isgongneng && servicetcp != null)
                {
                    OnCloseConnectEvent_S();
                }
            }
            catch
            {
            }
        }

        private void method_4(byte[] byte_3)
        {
            lastrecivetime = DateTime.Now;
            try
            {
                if (byte_3 != null && byte_3.Length >= 10 && byte_3[8] == 200)
                {
                    string text = bytetool.fromArray(byte_3);
                    string text2 = "";
                    try
                    {
                        text2 = text.Substring(8, 4).ToUpper();
                    }
                    catch
                    {
                    }
                    if (!string.IsNullOrWhiteSpace(text2) && !(text2 == "1E74"))
                    {
                        if (!(text2 == "0412") && !(text2 == "0415") && !(text2 == "0287") && !(text2 == "0433"))
                        {
                            if (text2 == "04E5")
                            {
                                method_11(byte_3);
                            }
                            else if (text2 == "04D7")
                            {
                                method_14(byte_3);
                            }
                            else if (text2 == "0422")
                            {
                                mytrace = "FO";
                                tihaocishu++;
                                try
                                {
                                    if (status == 2)
                                    {
                                        LeaveChanel();
                                    }
                                    istuichu = true;
                                    heartbeat = 0;
                                    mytrace = "";
                                    currentflag = 10000;
                                    isudblogin = false;
                                    if (logintcp != null)
                                    {
                                        ZhuDongDK((rdomhelper.getrandom(0, 100) <= 50) ? (-1) : 0);
                                    }
                                }
                                catch
                                {
                                }
                            }
                            else if (text2 == "020C")
                            {
                                mytrace = "YDDL";
                                ZhuDongDK((rdomhelper.getrandom(0, 100) <= 50) ? (-1) : 0);
                            }
                            else if (text2 == "0BD0")
                            {
                                string a;
                                string a2;
                                try
                                {
                                    a = text.Substring(24, 4).ToUpper();
                                    a2 = text.Substring(24, 6).ToUpper();
                                }
                                catch
                                {
                                    return;
                                }
                                if (a == "1E74")
                                {
                                    Recv_Service_1E74(byte_3);
                                }
                                else if (a == "0308")
                                {
                                    method_15(byte_3);
                                }
                                else if (a == "0868")
                                {
                                    method_16(byte_3);
                                }
                                else if (a == "0242" && a2 == "02421F")
                                {
                                    method_18(byte_3);
                                }
                                else if (a == "0302")
                                {
                                    method_19(byte_3);
                                }
                                else if (a2 == "024D1F")
                                {
                                    mytrace = "KO-MJK";
                                    try
                                    {
                                        if (status == 2)
                                        {
                                            LeaveChanel();
                                        }
                                        istuichu = true;
                                        heartbeat = 0;
                                        status = 0;
                                        joinstatus = 0;
                                        mytrace = "";
                                        currentflag = 10000;
                                        isudblogin = false;
                                        if (logintcp != null)
                                        {
                                            ZhuDongDK((rdomhelper.getrandom(0, 100) <= 50) ? (-1) : 0);
                                        }
                                    }
                                    catch
                                    {
                                    }
                                }
                                else if (!(a2 == "023501") && !(a2 == "024025") && !(a == "022C"))
                                {
                                    if (a2 == "04220C")
                                    {
                                        mytrace = "2-KO";
                                        tihaocishu++;
                                        ZhuDongDK((rdomhelper.getrandom(0, 100) <= 50) ? (-1) : 0);
                                    }
                                    else if (!(a == "0239"))
                                    {
                                        if (a == "041F")
                                        {
                                            method_20(byte_3);
                                        }
                                        else if (a == "02D1")
                                        {
                                            method_21(byte_3);
                                        }
                                        else if (a == "02B1")
                                        {
                                            method_22(byte_3);
                                        }
                                        else if (a == "02B3")
                                        {
                                            lastonlinetime = DateTime.Now;
                                        }
                                        else if (a == "02B5")
                                        {
                                            method_23(byte_3);
                                        }
                                        else if (a == "0253")
                                        {
                                        }
                                    }
                                }
                                else
                                {
                                    mytrace = "KO-UB";
                                    tihaotime = DateTime.Now;
                                    tihaocishu++;
                                    try
                                    {
                                        if (status == 2)
                                        {
                                            LeaveChanel();
                                        }
                                        istuichu = true;
                                        heartbeat = 0;
                                        status = 0;
                                        joinstatus = 0;
                                        mytrace = "";
                                        currentflag = 10000;
                                        isudblogin = false;
                                        if (logintcp != null)
                                        {
                                            ZhuDongDK((rdomhelper.getrandom(0, 100) <= 50) ? (-1) : 0);
                                        }
                                    }
                                    catch
                                    {
                                    }
                                }
                            }
                            else if (text2 == "041F")
                            {
                                method_20(byte_3);
                            }
                            else if (text2 == "024D" || text2 == "0235" || text2 == "0240" || text2 == "020C")
                            {
                                mytrace = "OKO";
                            }
                        }
                        else
                        {
                            method_8(byte_3);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void method_5()
        {
        }

        private void method_6()
        {
            try
            {
                if (timer_0 != null)
                {
                    timer_0.Enabled = false;
                    timer_0.Stop();
                }
            }
            catch
            {
            }
            try
            {
                daili = "";
                pt = ProxyTypes.None;
                if (status < 3)
                {
                    status = 1;
                }
                joinstatus = ((rdomhelper.getrandom(0, 100) <= 50) ? (-1) : 0);
                heartbeat = 0;
                currentflag = 10000;
                lastonlinetime = DateTime.MinValue;
                if (logintcp != null)
                {
                    logintcp.SendEvent -= method_5;
                    logintcp.ReciveEvent -= method_4;
                    logintcp.CloseConEvent -= method_6;
                    logintcp.ConEvent -= method_3;
                }
                int_15 = 0;
            }
            catch
            {
            }
            try
            {
                if (isgongneng && servicetcp != null)
                {
                    OnCloseConnectEvent_S();
                }
            }
            catch
            {
            }
        }

        private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                int_13++;
            }
            catch
            {
            }
            if (Interlocked.Exchange(ref int_14, 1) == 0)
            {
                try
                {
                    if (status < 3)
                    {
                        if (joinstatus == 1)
                        {
                            resend();
                        }
                        else if (joinstatus == 2)
                        {
                            if (sid != 0)
                            {
                                if (this.jointime != DateTime.MinValue)
                                {
                                    DateTime jointime = this.jointime;
                                    if (!zidongbuhao)
                                    {
                                        if (jointime.AddSeconds((double)int_12) < DateTime.Now && !isskip)
                                        {
                                            this.jointime = DateTime.Now;
                                            int_12 = rdomhelper.getrandom(1200, 2000);
                                            Send_0BD0_02411F();
                                        }
                                    }
                                    else
                                    {
                                        this.jointime = DateTime.Now;
                                        int_12 = rdomhelper.getrandom(1200, 2000);
                                    }
                                }
                                if (int_13 % 15 == 0)
                                {
                                    Send_041E();
                                    if (isgongneng && isloginservice)
                                    {
                                        SendSH();
                                    }
                                }
                                if (isgongneng && !isloginservice && startconnectservice != DateTime.MinValue && startconnectservice.AddSeconds(23.0) < DateTime.Now)
                                {
                                    OnCloseConnectEvent_S();
                                }
                                else if (isxianche && isudblogin && !isxianchewancheng)
                                {
                                    method_28();
                                }
                            }
                            else if (int_13 % 15 == 0)
                            {
                                Send_041E();
                            }
                        }
                    }
                }
                catch
                {
                }
                finally
                {
                    Interlocked.Exchange(ref int_14, 0);
                }
            }
        }

        public void resend()
        {
            try
            {
                if (int_15 > 15)
                {
                    isudblogin = false;
                    ZhuDongDK((rdomhelper.getrandom(0, 100) <= 50) ? (-1) : 0);
                }
                else
                {
                    if (currentflag == 10000)
                    {
                        int_15++;
                    }
                    if (currentflag >= 30001 && currentflag < 32000)
                    {
                        int_15++;
                    }
                    else if (lastsendtime != DateTime.MinValue && lastsendtime.AddSeconds(3.0) < DateTime.Now)
                    {
                        lastsendtime = DateTime.Now;
                        int_15++;
                        if (currentflag >= 20001 && currentflag < 21000)
                        {
                            method_7();
                        }
                        else if (currentflag >= 40001 && currentflag < 41000)
                        {
                            method_13();
                        }
                        else if (currentflag >= 50001 && currentflag < 51000)
                        {
                            Send_0BD0_0307();
                        }
                        else if (currentflag >= 55001 && currentflag < 56000)
                        {
                            Send_0BD0_02411F();
                        }
                        else if (currentflag >= 60001 && currentflag < 61000)
                        {
                            Send_0BD0_02411F();
                        }
                        else if (currentflag >= 61001 && currentflag < 62000)
                        {
                            Send_0BD0_02411F(true);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void method_7()
        {
            try
            {
                currentflag = rdomhelper.getrandom(20001, 21000);
                byte[] publicKey = rsautil.getInstance().getPublicKey();
                byte[] exponent = rsautil.getInstance().getExponent();
                byte[] sendBuffer = ProtoPacket.pack(new PExchangeKeyExt(publicKey, exponent));
                logintcp.Send(sendBuffer);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        private void method_8(byte[] byte_3)
        {
            try
            {
                if (currentflag <= 30000)
                {
                    byte[] array = null;
                    using (ByteArray byteArray = new ByteArray(byte_3))
                    {
                        ProtoPacket protoPacket = ProtoPacket.unpack(byteArray.Buffer);
                        uint num = protoPacket.getBuffer().readUnsignedShort();
                        if (num != 0)
                        {
                            using (ByteArray byteArray2 = new ByteArray())
                            {
                                protoPacket.getBuffer().readBytes(byteArray2, 0u, num);
                                array = byteArray2.Buffer;
                                byteArray2.Dispose();
                            }
                        }
                        byteArray.Dispose();
                    }
                    if (array == null || array.Length == 0)
                    {
                        throw new Exception("rsa fail");
                    }
                    byte[] array2 = rsautil.getInstance().decrypt(array);
                    if (array2 == null)
                    {
                        throw new Exception("DEC");
                    }
                    logintcp.setarc(array2);
                    if (logintype == 1)
                    {
                        if (isudblogin)
                        {
                            method_13();
                        }
                        else
                        {
                            method_9();
                        }
                    }
                    else
                    {
                        method_10();
                    }
                }
            }
            catch
            {
            }
        }

        private void method_9(bool bool_14 = false, byte[] byte_3 = null, byte[] byte_4 = null)
        {
            try
            {
                if (!bool_14)
                {
                    currentflag = rdomhelper.getrandom(30001, 31000);
                }
                else
                {
                    currentflag = rdomhelper.getrandom(31000, 32000);
                }
                mytrace = "S-YZM";
                UDBYYLoginReq uDBYYLoginReq = new UDBYYLoginReq();
                uDBYYLoginReq._appid = bytetool.String2Bytes("yymwebflsh");
                uDBYYLoginReq._user_token_type = 1u;
                uDBYYLoginReq._user = bytetool.String2Bytes(passport);
                uDBYYLoginReq._ver_str = bytetool.String2Bytes("yymwebflsh");
                uDBYYLoginReq._ver_int = uint.MaxValue;
                uDBYYLoginReq._terminal_type = new MyUInt64(2u, 0u);
                uDBYYLoginReq._apptype = 6u;
                uDBYYLoginReq._lcid = 2052u;
                string s = xxtea2.Encrypt(sha1.hash(pwd, Encoding.ASCII).ToLower(), (passport + "275d0ff676c0d65114acdefbd2ad87a3").Substring(0, 16));
                uDBYYLoginReq._user_token = Convert.FromBase64String(s);
                if (bool_14)
                {
                    uDBYYLoginReq._pic_id = byte_3;
                    int num = 1;
                    using (MemoryStream stream = new MemoryStream(byte_4))
                    {
                        ImageFormat rawFormat = Image.FromStream(stream).RawFormat;
                        if (rawFormat.Equals(ImageFormat.Jpeg))
                        {
                            num = 2;
                        }
                        else if (rawFormat.Equals(ImageFormat.Png))
                        {
                            num = 4;
                        }
                        else if (rawFormat.Equals(ImageFormat.Bmp))
                        {
                            num = 1;
                        }
                        else if (rawFormat.Equals(ImageFormat.Gif))
                        {
                            num = 2;
                        }
                        else if (rawFormat.Equals(ImageFormat.Icon))
                        {
                            num = 5;
                        }
                    }
                    string text2 = yanzhengma = imagetool.CreateInstance().hqCode(byte_4, num);
                    string text3 = text2;
                    string s2 = text3;
                    uDBYYLoginReq._pic_code = Encoding.UTF8.GetBytes(s2);
                }
                byte[] sendBuffer = ProtoPacket.pack(new PCS_CliAPLoginAuth2
                {
                    ruri = 2281u,
                    payLoad = ProtoPacket.packNoHeader(uDBYYLoginReq)
                });
                logintcp.Send(sendBuffer);
                lastsendtime = DateTime.Now;
            }
            catch (Exception)
            {
            }
        }

        private void method_10()
        {
            try
            {
                currentflag = rdomhelper.getrandom(30001, 31000);
                UDBYYLoginReq uDBYYLoginReq = new UDBYYLoginReq();
                uDBYYLoginReq._appid = bytetool.String2Bytes("yymwebflsh");
                uDBYYLoginReq._user_token_type = 9u;
                uDBYYLoginReq._user = bytetool.String2Bytes(username);
                uDBYYLoginReq._ver_str = bytetool.String2Bytes("yymwebflsh");
                uDBYYLoginReq._ver_int = uint.MaxValue;
                uDBYYLoginReq._terminal_type = new MyUInt64(2u, 0u);
                uDBYYLoginReq._apptype = 6u;
                uDBYYLoginReq._lcid = 2052u;
                CombAcctinfo combAcctinfo = new CombAcctinfo();
                combAcctinfo.acctinfo = bytetool.String2Bytes(pwden);
                combAcctinfo.appid_type = bytetool.String2Bytes("yycomscene");
                uDBYYLoginReq._user_token = ProtoPacket.packNoHeader(combAcctinfo);
                byte[] sendBuffer = ProtoPacket.pack(new PCS_CliAPLoginAuth2
                {
                    ruri = 2281u,
                    payLoad = ProtoPacket.packNoHeader(uDBYYLoginReq)
                });
                logintcp.Send(sendBuffer);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        private void method_11(byte[] byte_3)
        {
            try
            {
                if (currentflag <= 40000)
                {
                    using (ByteArray byteArray = new ByteArray(byte_3))
                    {
                        ProtoPacket protoPacket = ProtoPacket.unpack(byteArray.Buffer);
                        PCS_CliAPLoginAuth2Res pCS_CliAPLoginAuth2Res = new PCS_CliAPLoginAuth2Res();
                        pCS_CliAPLoginAuth2Res.unmarshall(protoPacket.getBuffer());
                        if (pCS_CliAPLoginAuth2Res.rescode != 200)
                        {
                            throw new Exception(pCS_CliAPLoginAuth2Res.rescode.ToString());
                        }
                        protoPacket = ProtoPacket.unpackNoHeader(pCS_CliAPLoginAuth2Res.payLoad, pCS_CliAPLoginAuth2Res.ruri, pCS_CliAPLoginAuth2Res.rescode);
                        UDBYYLoginRes uDBYYLoginRes = new UDBYYLoginRes();
                        LoginData loginData = new LoginData();
                        uDBYYLoginRes.unmarshall(protoPacket.getBuffer());
                        if (uDBYYLoginRes._rescode == 18)
                        {
                            ZhuDongDK(2);
                            isfenghao = true;
                            mytrace = "";
                            status = 3;
                        }
                        else
                        {
                            string @string = Encoding.UTF8.GetString(uDBYYLoginRes._reason);
                            if (!(@string.ToLower() == "success"))
                            {
                                if (@string.ToLower() == "user frozen")
                                {
                                    mytrace = "UF";
                                }
                                else if (!(@string.ToLower() == "static_verify") && !(@string.ToLower() == "invalid piccode"))
                                {
                                    if (@string.Contains("invalid user"))
                                    {
                                        mytrace = "MMCW";
                                        status = 33;
                                        isfenghao = true;
                                        joinstatus = 0;
                                    }
                                    else if (@string.ToLower() == "invalid account info")
                                    {
                                        mytrace = "IAI";
                                        if (logintype == 2)
                                        {
                                            logtool.delusercache_w(passport);
                                            ZhuDongDK(-1);
                                            loginstatus = -1;
                                            status = 0;
                                        }
                                    }
                                    else
                                    {
                                        mytrace = "U-L:" + @string;
                                    }
                                }
                                else
                                {
                                    mytrace = "YZM";
                                    method_9(true, uDBYYLoginRes._pic_id, uDBYYLoginRes._pic_data);
                                }
                                goto IL_03ee;
                            }
                            using (ByteArray byteArray2 = new ByteArray(uDBYYLoginRes._login_data))
                            {
                                loginData.unmarshall(byteArray2);
                                byteArray2.Dispose();
                            }
                            username = Encoding.UTF8.GetString(loginData._passport);
                            yycookie = loginData._yycookie;
                            uid = uDBYYLoginRes._yyuid.low;
                            try
                            {
                                using (ByteArray byteArray3 = new ByteArray(loginData._ticket))
                                {
                                    byteArray3.readUnsignedInt();
                                    byteArray3.readUnsignedInt();
                                    short num = byteArray3.ReadShort();
                                    byte_1 = new byte[num];
                                    for (int i = 0; i < num; i++)
                                    {
                                        byte_1[i] = byteArray3.readByte();
                                    }
                                    num = byteArray3.ReadShort();
                                    for (int j = 0; j < num; j++)
                                    {
                                        byteArray3.readByte();
                                    }
                                    num = byteArray3.ReadShort();
                                    byte_2 = new byte[num];
                                    for (int k = 0; k < num; k++)
                                    {
                                        byte_2[k] = byteArray3.readByte();
                                    }
                                    num = byteArray3.ReadShort();
                                    for (int l = 0; l < num; l++)
                                    {
                                        byteArray3.readByte();
                                    }
                                    num = byteArray3.ReadShort();
                                    for (int m = 0; m < num; m++)
                                    {
                                        byteArray3.readByte();
                                    }
                                }
                            }
                            catch
                            {
                            }
                            if (logintype == 1)
                            {
                                savepcbuser savepcbuser = new savepcbuser();
                                savepcbuser.username = username;
                                savepcbuser.cookie = Hex.fromArray(new ByteArray(yycookie));
                                savepcbuser.uid = uid.ToString();
                                try
                                {
                                    string text = MyEncrypt.AesEncryptor(JsonConvert.SerializeObject(savepcbuser));
                                    logtool.logusercache_p(passport, text);
                                }
                                catch
                                {
                                }
                            }
                            if (logintype != 1 || isudblogin || pt == ProxyTypes.None || isyongji)
                            {
                                method_13();
                                goto IL_03ee;
                            }
                            ZhuDongDK(-1);
                            isudblogin = true;
                        }
                        goto end_IL_0017;
                    IL_03ee:
                        byteArray.Dispose();
                    end_IL_0017:;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private byte[] method_12()
        {
            try
            {
                c_Data c_Data = new c_Data();
                c_Data c_Data2 = new c_Data();
                c_Data c_Data3 = new c_Data();
                c_Data.Data = byte_2;
                c_Data.Len = byte_2.Length;
                c_Data3.str = username;
                c_Data2.Data = new byte[800];
                c_Data2.Len = krbtool.Out(c_Data.Data, c_Data.Len, c_Data2.Data, byte_1, byte_1.Length, username, sha1.hash(pwd, Encoding.ASCII).ToLower(), 8754154);
                return c_Data2.Data.Take(c_Data2.Len).ToArray();
            }
            catch
            {
                return null;
            }
        }

        private void method_13()
        {
            try
            {
                currentflag = rdomhelper.getrandom(40001, 41000);
                send04d6++;
                if (logintype == 1 && send04d6 >= 50)
                {
                    logtool.delusercache_p(passport);
                    ZhuDongDK((rdomhelper.getrandom(0, 100) <= 50) ? (-1) : 0);
                    isudblogin = false;
                    send04d6 = 0;
                }
                else
                {
                    byte[] sendBuffer = (logintype != 1) ? ProtoPacket.pack(new PCS_APLogin
                    {
                        m_strAccount = bytetool.String2Bytes(username),
                        m_strPassword = bytetool.String2Bytes(pwden),
                        m_bRelogin = (currentflag == 40005),
                        m_uAppID = 259u,
                        m_uUid =
                        {
                            low = Convert.ToUInt32(uid)
                        },
                        m_strCookie = yycookie,
                        m_uCliType = 2u,
                        m_strFrom = bytetool.String2Bytes("yymwebflsh"),
                        m_strCliVer = bytetool.String2Bytes("yymwebflsh")
                    }) : ProtoPacket.pack(new PCS_APLogin
                    {
                        m_strPassword = bytetool.String2Bytes(sha1.hash(pwd, Encoding.ASCII).ToLower()),
                        m_bRelogin = false,
                        m_uAppID = 259u,
                        m_uUid =
                        {
                            low = Convert.ToUInt32(uid)
                        },
                        m_strCookie = yycookie,
                        m_strAccount = Encoding.UTF8.GetBytes(username),
                        m_uCliType = 2u,
                        m_strCliInfo = bytetool.String2Bytes(Guid.NewGuid().ToString("N")),
                        m_strFrom = bytetool.String2Bytes("8.45.0.1"),
                        m_strCliVer = bytetool.String2Bytes("8.45.0.1")
                    });
                    logintcp.Send(sendBuffer);
                    lastsendtime = DateTime.Now;
                    mytrace = "A-L-" + send04d6.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void method_14(byte[] byte_3)
        {
            try
            {
                if (currentflag <= 50000)
                {
                    using (ByteArray byteArray = new ByteArray(byte_3))
                    {
                        ProtoPacket protoPacket = ProtoPacket.unpack(byteArray.Buffer);
                        PCS_APLoginRes pCS_APLoginRes = new PCS_APLoginRes();
                        pCS_APLoginRes.unmarshall(protoPacket.getBuffer());
                        byteArray.Dispose();
                        if (pCS_APLoginRes.m_uResCode != 200)
                        {
                            throw new Exception(pCS_APLoginRes.m_uResCode.ToString());
                        }
                        Send_0BD0_0307();
                    }
                }
            }
            catch
            {
                renzhenshibai++;
                if (logintype == 1 && renzhenshibai >= 3)
                {
                    logtool.delusercache_p(passport);
                    isudblogin = false;
                    renzhenshibai = 0;
                }
            }
        }

        public void Send_0BD0_0307()
        {
            try
            {
                currentflag = rdomhelper.getrandom(50001, 51000);
                byte[] array = null;
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.method_2(0);
                    byteArray.writeUnsignedInt(uid);
                    byte[] array2 = bytetool.strToToHexByte(sha1.hash(pwd, Encoding.ASCII).ToLower());
                    byteArray.method_2(array2.Length);
                    byteArray.writeBytes(array2);
                    byteArray.method_2(0);
                    array = byteArray.Buffer;
                    byteArray.Dispose();
                }
                byte[] array3 = null;
                using (ByteArray byteArray2 = new ByteArray())
                {
                    byteArray2.endian = Endian.LITTLE_ENDIAN;
                    byteArray2.writeBytes(bytetool.strToToHexByte("08000001030700001000000203010000"));
                    byteArray2.writeUnsignedInt(uid);
                    byteArray2.writeBytes(bytetool.strToToHexByte("0000000015000006DCCC1B00120B00000000050055496E666F1200000701000000010000000400000000001E0000081800030000000000000001003201000000010030030000000000787878FF"));
                    array3 = byteArray2.Buffer;
                    byteArray2.Dispose();
                }
                byte[] sendBuffer = null;
                using (ByteArray byteArray3 = new ByteArray())
                {
                    byteArray3.endian = Endian.LITTLE_ENDIAN;
                    byteArray3.position = 4;
                    byteArray3.writeBytes(bytetool.strToToHexByte("0BD00700C800000003070000C800"));
                    byteArray3.method_2(array.Length);
                    byteArray3.writeBytes(array);
                    byteArray3.method_2(array3.Length);
                    byteArray3.writeBytes(array3);
                    byteArray3.position = 0;
                    byteArray3.writeUnsignedInt(Convert.ToUInt32(byteArray3.length));
                    sendBuffer = byteArray3.Buffer;
                    byteArray3.Dispose();
                }
                logintcp.Send(sendBuffer);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        private void method_15(byte[] byte_3)
        {
            try
            {
                if (currentflag <= 60000)
                {
                    using (ByteArray byteArray = new ByteArray(byte_3))
                    {
                        byteArray.readUnsignedInt();
                        byteArray.readUnsignedInt();
                        byteArray.readUnsignedInt();
                        byteArray.readUnsignedInt();
                        byteArray.readUnsignedShort();
                        byteArray.readUnsignedInt();
                        int num = (int)byteArray.readUnsignedInt();
                        c_Data[] array = new c_Data[num];
                        for (int i = 0; i < num; i++)
                        {
                            array[i] = new c_Data();
                            array[i].intd = byteArray.readUnsignedShort();
                            ushort num2 = byteArray.readUnsignedShort();
                            array[i].Data = new byte[num2];
                            for (int j = 0; j < num2; j++)
                            {
                                array[i].Data[j] = byteArray.readByte();
                            }
                            if (array[i].intd == 2)
                            {
                                nicheng = Encoding.UTF8.GetString(array[i].Data);
                            }
                            if (array[i].intd == 53)
                            {
                                jifen = Encoding.UTF8.GetString(array[i].Data);
                            }
                        }
                        byteArray.Dispose();
                    }
                    if (sid != 0)
                    {
                        Send_0BD0_02411F();
                    }
                    else
                    {
                        send04d6 = 0;
                        mytrace = "登录成功";
                        jointime = DateTime.Now;
                        currentflag = rdomhelper.getrandom(90001, 91000);
                        int_12 = rdomhelper.getrandom(500, 1800);
                        joinstatus = 2;
                        status = 2;
                    }
                }
            }
            catch
            {
            }
        }

        public void Send_0BD0_0801()
        {
            try
            {
                currentflag = rdomhelper.getrandom(55001, 56000);
                sid_l = 0u;
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.position = 4;
                    byteArray.writeBytes(bytetool.strToToHexByte("0BD00700"));
                    byteArray.writeUnsignedInt(200u);
                    byteArray.writeBytes(bytetool.strToToHexByte("08010000"));
                    byteArray.writeShort(200);
                    byteArray.writeUnsignedInt(12u);
                    byteArray.writeUnsignedInt(sid);
                    byteArray.writeShort(1);
                    byteArray.writeBytes(bytetool.strToToHexByte("2079F511"));
                    byteArray.writeShort(257);
                    byteArray.writeUnsignedInt(77u);
                    byteArray.writeBytes(bytetool.strToToHexByte("08000001"));
                    byteArray.writeBytes(bytetool.strToToHexByte("08010000"));
                    byteArray.writeBytes(bytetool.strToToHexByte("10000002"));
                    byteArray.writeBytes(bytetool.strToToHexByte("03010000"));
                    byteArray.writeUnsignedInt(uid);
                    byteArray.writeUnsignedInt(0u);
                    byteArray.writeBytes(bytetool.strToToHexByte("1F000006"));
                    byteArray.writeBytes(bytetool.strToToHexByte("2A4F0068A0A916000000"));
                    byteArray.writeUTF("channelSmanager");
                    byteArray.writeBytes(bytetool.strToToHexByte("120000080C00010000000000000002003231787878FF"));
                    byteArray.position = 0;
                    byteArray.writeUnsignedInt(Convert.ToUInt32(byteArray.length));
                    sendBuffer = byteArray.Buffer;
                    byteArray.Dispose();
                }
                logintcp.Send(sendBuffer);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        private void method_16(byte[] byte_3)
        {
            try
            {
                using (ByteArray byteArray = new ByteArray(byte_3))
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedShort();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    uint num = byteArray.readUnsignedInt();
                    byte[] array = new byte[num];
                    for (int i = 0; i < num; i++)
                    {
                        array[i] = byteArray.readByte();
                    }
                    using (ByteArray byteArray2 = new ByteArray(array))
                    {
                        byteArray2.endian = Endian.LITTLE_ENDIAN;
                        byteArray2.Uncompress();
                        if (byteArray2.readUnsignedInt() == 200)
                        {
                            sid_l = byteArray2.readUnsignedInt();
                            byteArray2.readUnsignedInt();
                        }
                        else
                        {
                            sid_l = byteArray2.readUnsignedInt();
                            byteArray2.readUnsignedInt();
                        }
                    }
                    if (isskip)
                    {
                        if (sid_l != 0)
                        {
                            Send_0BD0_02411F();
                        }
                    }
                    else
                    {
                        Send_0BD0_02411F();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private long method_17(string string_14)
        {
            char[] separator = new char[1]
            {
                '.'
            };
            string[] array = string_14.Split(separator);
            return (long.Parse(array[0]) << 24) | (long.Parse(array[1]) << 16) | (long.Parse(array[2]) << 8) | long.Parse(array[3]);
        }

        public void Send_0BD0_02411F(bool bool_14 = false)
        {
            try
            {
                if (bool_14)
                {
                    currentflag = rdomhelper.getrandom(61001, 62000);
                }
                else
                {
                    currentflag = rdomhelper.getrandom(60001, 61000);
                }
                PJoinChannelReq pJoinChannelReq = new PJoinChannelReq();
                pJoinChannelReq.uid = uid;
                pJoinChannelReq.topsid = sid;
                pJoinChannelReq.subSid = subid;
                if (isskip)
                {
                    MYHashMap props = pJoinChannelReq.props;
                    props.put(2u.ToString(), bytetool.String2Bytes("1"));
                }
                else
                {
                    MYHashMap props2 = pJoinChannelReq.props;
                    props2.put(2u.ToString(), bytetool.String2Bytes("0"));
                }
                MYHashMap props3 = pJoinChannelReq.props;
                props3.put(4u.ToString(), bytetool.String2Bytes(timetool.GetTs()));
                if (bool_14)
                {
                    MYHashMap props4 = pJoinChannelReq.props;
                    props4.put(3u.ToString(), bytetool.String2Bytes("1"));
                }
                byte[] serverName = bytetool.String2Bytes("channelAuther");
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray(ProtoPacket.pack(pJoinChannelReq)))
                {
                    PContextField1 pContextField = new PContextField1();
                    pContextField.f1 = ((sid_l == 0) ? sid : sid_l);
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
                    mapExtentProp.put(1u.ToString(), ProtoPacket.packNoHeader(pContextField));
                    MYHashMap mapExtentProp2 = pAPRouter.m_objAPHdr.m_pExtentProp.m_mapExtentProp;
                    mapExtentProp2.put(3u.ToString(), bytetool.String2Bytes(pcinfo));
                    pAPRouter.m_strLoad = protoPacket.getBuffer().Buffer;
                    pAPRouter.m_ururi = protoPacket.getUri();
                    sendBuffer = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(sendBuffer, true);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        public void skip()
        {
            try
            {
                currentflag = rdomhelper.getrandom(70001, 71000);
                PJoinChannelReq pJoinChannelReq = new PJoinChannelReq
                {
                    uid = uid,
                    topsid = sid,
                    subSid = subid
                };
                MYHashMap props = pJoinChannelReq.props;
                props.put(2u.ToString(), bytetool.String2Bytes("0"));
                byte[] serverName = bytetool.String2Bytes("channelAuther");
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray(ProtoPacket.pack(pJoinChannelReq)))
                {
                    PContextField1 pContextField = new PContextField1();
                    pContextField.f1 = sid;
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
                    mapExtentProp.put(1u.ToString(), ProtoPacket.packNoHeader(pContextField));
                    MYHashMap mapExtentProp2 = pAPRouter.m_objAPHdr.m_pExtentProp.m_mapExtentProp;
                    mapExtentProp2.put(3u.ToString(), null);
                    pAPRouter.m_strLoad = protoPacket.getBuffer().Buffer;
                    pAPRouter.m_ururi = protoPacket.getUri();
                    sendBuffer = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(sendBuffer, true);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        private void method_18(byte[] byte_3)
        {
            try
            {
                if (status != 2 || isskip)
                {
                    using (ByteArray byteArray = new ByteArray(byte_3))
                    {
                        if (byte_3[8] != 200)
                        {
                            throw new Exception("J-ERR");
                        }
                        byteArray.readUnsignedInt();
                        byteArray.readUnsignedInt();
                        byteArray.readUnsignedInt();
                        byteArray.readUnsignedInt();
                        byteArray.readUnsignedShort();
                        byteArray.readUnsignedInt();
                        uint num = byteArray.readUnsignedInt();
                        byteArray.readUnsignedInt();
                        uint subidnew = byteArray.readUnsignedInt();
                        uint num2 = byteArray.readUnsignedInt();
                        byteArray.readUnsignedInt();
                        switch (byteArray.readByte())
                        {
                            case 11:
                                if (!isskip)
                                {
                                    if (ishunhejin)
                                    {
                                        yongjitimes++;
                                        mytrace = "Y-J-" + yongjitimes.ToString();
                                        if (yongjitimes > 3)
                                        {
                                            yongjitimes = 0;
                                            isyongji = true;
                                            ZhuDongDK(-1);
                                        }
                                    }
                                    else
                                    {
                                        mytrace = "Y-J";
                                        ZhuDongDK(-1);
                                        onYongJi_0?.Invoke();
                                    }
                                }
                                else
                                {
                                    mytrace = "Y-J";
                                    onYongJi_0?.Invoke();
                                }
                                break;
                            case 1:
                            case 3:
                                ZhuDongDK(0);
                                break;
                            case 4:
                                if (sid != num2 && sid != num)
                                {
                                    mytrace = "GO-ON";
                                }
                                else
                                {
                                    send04d6 = 0;
                                    if (pt != 0)
                                    {
                                        mytrace = "DL-SUC";
                                    }
                                    else
                                    {
                                        mytrace = "SUC";
                                    }
                                    jointime = DateTime.Now;
                                    currentflag = rdomhelper.getrandom(90001, 91000);
                                    int_12 = rdomhelper.getrandom(500, 1800);
                                    int num3 = 2;
                                    joinstatus = 2;
                                    status = 2;
                                    sidnew = num;
                                    this.subidnew = subidnew;
                                    yongjitimes = 0;
                                    if (isyongji)
                                    {
                                        method_1(DateTime.Now.AddSeconds((double)rdomhelper.getrandom(100, 300)));
                                        isyongji = false;
                                    }
                                    if (isskip)
                                    {
                                        isskip = false;
                                        if (isgongneng && isxianche)
                                        {
                                            if (isloginservice)
                                            {
                                                isxianchewancheng = false;
                                                method_28();
                                            }
                                            else
                                            {
                                                Send_Service_1E73();
                                            }
                                        }
                                    }
                                    else if (isgongneng && !isloginservice)
                                    {
                                        Send_Service_1E73();
                                    }
                                }
                                break;
                            default:
                                {
                                    string message = mytrace = "mima";
                                    throw new Exception(message);
                                }
                            case 7:
                                mytrace = "M-J";
                                currentflag = rdomhelper.getrandom(61001, 62000);
                                break;
                            case 12:
                                break;
                        }
                        byteArray.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                mytrace = ex.Message;
            }
        }

        private void method_19(byte[] byte_3)
        {
            try
            {
                using (ByteArray byteArray = new ByteArray(byte_3))
                {
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.ReadShort();
                    byteArray.readUnsignedInt();
                    uint num = byteArray.readUnsignedInt();
                    for (uint num2 = 0u; num2 < num; num2++)
                    {
                        byteArray.ReadShort();
                        short num3 = byteArray.ReadShort();
                        for (int i = 0; i < num3; i++)
                        {
                            byteArray.readByte();
                        }
                    }
                    if (byteArray.readUnsignedInt() == 0)
                    {
                        isupdate = false;
                    }
                    else
                    {
                        xiugaisuiji = true;
                    }
                }
            }
            catch
            {
            }
        }

        public void Send_041E()
        {
            try
            {
                byte[] sendBuffer = ProtoPacket.pack(new PCS_APPing());
                logintcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        private void method_20(byte[] byte_3)
        {
            try
            {
                heartbeat++;
            }
            catch
            {
            }
        }

        public void Send_Service_1E73()
        {
            try
            {
                startconnectservice = DateTime.Now;
                PCS_GetAPInfo gparam_ = new PCS_GetAPInfo
                {
                    m_uAppId = 260u,
                    m_uUid =
                    {
                        low = Convert.ToUInt32(uid)
                    }
                };
                byte[] serverName = bytetool.String2Bytes("aplbs_webyy");
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray(ProtoPacket.pack(gparam_)))
                {
                    PContextField1 pContextField = new PContextField1();
                    pContextField.f1 = sid;
                    ProtoPacket protoPacket = ProtoPacket.unpack(byteArray.Buffer);
                    PAPRouter pAPRouter = new PAPRouter();
                    pAPRouter.m_objAPHdr.m_pAppUID = new CAppUID();
                    pAPRouter.m_objAPHdr.m_pAppUID.m_uAppID = 259u;
                    pAPRouter.m_objAPHdr.m_pAppUID.m_uUID.low = Convert.ToUInt32(uid);
                    pAPRouter.m_objAPHdr.m_pRoutingKey = new CRoutingKey();
                    pAPRouter.m_objAPHdr.m_pRoutingKey.m_uRealUri = protoPacket.getUri();
                    pAPRouter.m_objAPHdr.m_pClientInfo = new CClientInfo();
                    pAPRouter.m_objAPHdr.m_pClientInfo.m_serverName = serverName;
                    pAPRouter.m_objAPHdr.m_pExtentProp = new CExtentProp();
                    MYHashMap mapExtentProp = pAPRouter.m_objAPHdr.m_pExtentProp.m_mapExtentProp;
                    mapExtentProp.put(1u.ToString(), ProtoPacket.packNoHeader(pContextField));
                    MYHashMap mapExtentProp2 = pAPRouter.m_objAPHdr.m_pExtentProp.m_mapExtentProp;
                    mapExtentProp2.put(3u.ToString(), null);
                    pAPRouter.m_strLoad = protoPacket.getBuffer().Buffer;
                    pAPRouter.m_ururi = protoPacket.getUri();
                    sendBuffer = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        public void Recv_Service_1E74(byte[] byte_3)
        {
            try
            {
                byte[] bytes = byte_3.Skip(38).Take(byte_3[36]).ToArray();
                using (ByteArray byteArray = new ByteArray(byte_3.Skip(36 + byte_3[36] + 10).Take(5).ToArray()))
                {
                    serviceport = byteArray.ReadShort();
                }
                serviceip = Encoding.Default.GetString(bytes);
                connect_s();
            }
            catch
            {
            }
        }

        public void GetMicList()
        {
            try
            {
                PGetMaixuListReq gparam_ = new PGetMaixuListReq
                {
                    topSid = sidnew,
                    subSid = subidnew,
                    uid = uid
                };
                byte[] serverName = bytetool.String2Bytes("channelMaixu");
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray(ProtoPacket.pack(gparam_)))
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
                    mapExtentProp.put(1u.ToString(), ProtoPacket.packNoHeader(pContextField));
                    MYHashMap mapExtentProp2 = pAPRouter.m_objAPHdr.m_pExtentProp.m_mapExtentProp;
                    mapExtentProp2.put(3u.ToString(), null);
                    pAPRouter.m_strLoad = protoPacket.getBuffer().Buffer;
                    pAPRouter.m_ururi = protoPacket.getUri();
                    sendBuffer = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        private void method_21(byte[] byte_3)
        {
            try
            {
                using (ByteArray byteArray = new ByteArray(byte_3))
                {
                    ProtoPacket protoPacket = ProtoPacket.unpack(byteArray.Buffer);
                    new PGetMaixuListRes().unmarshall(protoPacket.getBuffer());
                }
            }
            catch
            {
            }
        }

        public void GetUserCount()
        {
            try
            {
                GClass1 gparam_ = new GClass1
                {
                    topSid = sidnew,
                    sidlist =
                    {
                        sidnew,
                        subidnew
                    }
                };
                byte[] serverName = bytetool.String2Bytes("channelUserInfo");
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray(ProtoPacket.pack(gparam_)))
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
                    mapExtentProp.put(1u.ToString(), ProtoPacket.packNoHeader(pContextField));
                    MYHashMap mapExtentProp2 = pAPRouter.m_objAPHdr.m_pExtentProp.m_mapExtentProp;
                    mapExtentProp2.put(3u.ToString(), null);
                    pAPRouter.m_strLoad = protoPacket.getBuffer().Buffer;
                    pAPRouter.m_ururi = protoPacket.getUri();
                    sendBuffer = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        private void method_22(byte[] byte_3)
        {
            try
            {
                using (ByteArray byteArray = new ByteArray(byte_3))
                {
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.ReadShort();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    uint num = byteArray.readUnsignedInt();
                    uint num2 = byteArray.readUnsignedInt();
                    for (int i = 0; i < num2; i++)
                    {
                        if (subidnew == byteArray.readUnsignedInt())
                        {
                            num = byteArray.readUnsignedInt();
                            break;
                        }
                    }
                    onGetUserCount_0?.Invoke(num);
                }
            }
            catch
            {
            }
        }

        public void GetUserList(uint uint_6 = 0u)
        {
            try
            {
                GClass3 gparam_ = new GClass3
                {
                    topSid = sidnew,
                    subSid = subidnew,
                    pos = uint_6,
                    num = 50u
                };
                byte[] serverName = bytetool.String2Bytes("channelUserInfo");
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray(ProtoPacket.pack(gparam_)))
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
                    mapExtentProp.put(1u.ToString(), ProtoPacket.packNoHeader(pContextField));
                    MYHashMap mapExtentProp2 = pAPRouter.m_objAPHdr.m_pExtentProp.m_mapExtentProp;
                    mapExtentProp2.put(3u.ToString(), null);
                    pAPRouter.m_strLoad = protoPacket.getBuffer().Buffer;
                    pAPRouter.m_ururi = protoPacket.getUri();
                    sendBuffer = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        private void method_23(byte[] byte_3)
        {
            try
            {
                using (ByteArray byteArray = new ByteArray(byte_3))
                {
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.ReadShort();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    uint num = byteArray.readUnsignedInt();
                    List<uint> list = new List<uint>();
                    for (int i = 0; i < num; i++)
                    {
                        list.Add(byteArray.readUnsignedInt());
                        uint num2 = byteArray.readUnsignedInt();
                        for (int j = 0; j < num2; j++)
                        {
                            byteArray.readByte();
                            byteArray.readUnsignedInt();
                        }
                        uint num3 = byteArray.readUnsignedInt();
                        for (int k = 0; k < num3; k++)
                        {
                            byteArray.readByte();
                            short num4 = byteArray.ReadShort();
                            byteArray.position += num4;
                        }
                    }
                }
            }
            catch
            {
            }
        }

        public void GetUserInfo()
        {
            try
            {
                List<uint> list = new List<uint>();
                list.Add(uid);
                PQueryUserInfoReq gparam_ = new PQueryUserInfoReq
                {
                    uidlist = list,
                    topSid = sidnew,
                    type = 0u
                };
                byte[] serverName = bytetool.String2Bytes("channelUserInfo");
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray(ProtoPacket.pack(gparam_)))
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
                    mapExtentProp.put(1u.ToString(), ProtoPacket.packNoHeader(pContextField));
                    MYHashMap mapExtentProp2 = pAPRouter.m_objAPHdr.m_pExtentProp.m_mapExtentProp;
                    mapExtentProp2.put(3u.ToString(), null);
                    pAPRouter.m_strLoad = protoPacket.getBuffer().Buffer;
                    pAPRouter.m_ururi = protoPacket.getUri();
                    sendBuffer = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        private void method_24(byte[] byte_3)
        {
            try
            {
                using (ByteArray byteArray = new ByteArray(byte_3))
                {
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                    byteArray.ReadShort();
                    byteArray.readUnsignedInt();
                    byteArray.readUnsignedInt();
                }
            }
            catch
            {
            }
        }

        public void LeaveChanel()
        {
            try
            {
                PLeaveChannelReq gparam_ = new PLeaveChannelReq
                {
                    topsid = sidnew,
                    uid = uid
                };
                byte[] serverName = bytetool.String2Bytes("channelAuther");
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray(ProtoPacket.pack(gparam_)))
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
                    mapExtentProp.put(1u.ToString(), ProtoPacket.packNoHeader(pContextField));
                    MYHashMap mapExtentProp2 = pAPRouter.m_objAPHdr.m_pExtentProp.m_mapExtentProp;
                    mapExtentProp2.put(3u.ToString(), null);
                    pAPRouter.m_strLoad = protoPacket.getBuffer().Buffer;
                    pAPRouter.m_ururi = protoPacket.getUri();
                    sendBuffer = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        public void qiangmai()
        {
            try
            {
                PJoinChannelReq pJoinChannelReq = new PJoinChannelReq();
                pJoinChannelReq.uid = uid;
                pJoinChannelReq.topsid = ((sid_l == 0) ? sid : sid_l);
                pJoinChannelReq.subSid = subid;
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.position = 0;
                    byteArray.writeBytes(new byte[22]
                    {
                        151,
                        0,
                        0,
                        0,
                        11,
                        208,
                        7,
                        0,
                        200,
                        0,
                        0,
                        0,
                        2,
                        50,
                        0,
                        0,
                        0,
                        0,
                        12,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[28]
                    {
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        113,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        1,
                        2,
                        50,
                        0,
                        0,
                        16,
                        0,
                        0,
                        2,
                        3,
                        1,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[47]
                    {
                        0,
                        0,
                        0,
                        0,
                        29,
                        0,
                        0,
                        6,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        13,
                        0,
                        99,
                        104,
                        97,
                        110,
                        110,
                        101,
                        108,
                        65,
                        117,
                        116,
                        104,
                        101,
                        114,
                        56,
                        0,
                        0,
                        7,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        4,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[64]
                    {
                        3,
                        0,
                        0,
                        0,
                        32,
                        0,
                        52,
                        55,
                        53,
                        56,
                        52,
                        52,
                        49,
                        65,
                        51,
                        66,
                        67,
                        48,
                        52,
                        51,
                        49,
                        68,
                        49,
                        69,
                        70,
                        51,
                        48,
                        53,
                        52,
                        69,
                        50,
                        53,
                        66,
                        49,
                        66,
                        55,
                        52,
                        53,
                        120,
                        120,
                        120,
                        byte.MaxValue,
                        148,
                        0,
                        0,
                        0,
                        11,
                        208,
                        7,
                        0,
                        200,
                        0,
                        0,
                        0,
                        3,
                        102,
                        0,
                        0,
                        0,
                        0,
                        17,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[4]
                    {
                        1,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[25]
                    {
                        1,
                        0,
                        0,
                        0,
                        0,
                        105,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        1,
                        3,
                        102,
                        0,
                        0,
                        16,
                        0,
                        0,
                        2,
                        3,
                        1,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[39]
                    {
                        0,
                        0,
                        0,
                        0,
                        21,
                        0,
                        0,
                        6,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        5,
                        0,
                        85,
                        73,
                        110,
                        102,
                        111,
                        56,
                        0,
                        0,
                        7,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        4,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[64]
                    {
                        3,
                        0,
                        0,
                        0,
                        32,
                        0,
                        52,
                        55,
                        53,
                        56,
                        52,
                        52,
                        49,
                        65,
                        51,
                        66,
                        67,
                        48,
                        52,
                        51,
                        49,
                        68,
                        49,
                        69,
                        70,
                        51,
                        48,
                        53,
                        52,
                        69,
                        50,
                        53,
                        66,
                        49,
                        66,
                        55,
                        52,
                        53,
                        120,
                        120,
                        120,
                        byte.MaxValue,
                        157,
                        0,
                        0,
                        0,
                        11,
                        208,
                        7,
                        0,
                        200,
                        0,
                        0,
                        0,
                        2,
                        178,
                        47,
                        0,
                        0,
                        0,
                        16,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[4]
                    {
                        1,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[24]
                    {
                        3,
                        0,
                        0,
                        0,
                        115,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        1,
                        2,
                        178,
                        47,
                        0,
                        16,
                        0,
                        0,
                        2,
                        3,
                        1,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[49]
                    {
                        0,
                        0,
                        0,
                        0,
                        31,
                        0,
                        0,
                        6,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        15,
                        0,
                        99,
                        104,
                        97,
                        110,
                        110,
                        101,
                        108,
                        85,
                        115,
                        101,
                        114,
                        73,
                        110,
                        102,
                        111,
                        56,
                        0,
                        0,
                        7,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        4,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[42]
                    {
                        3,
                        0,
                        0,
                        0,
                        32,
                        0,
                        52,
                        55,
                        53,
                        56,
                        52,
                        52,
                        49,
                        65,
                        51,
                        66,
                        67,
                        48,
                        52,
                        51,
                        49,
                        68,
                        49,
                        69,
                        70,
                        51,
                        48,
                        53,
                        52,
                        69,
                        50,
                        53,
                        66,
                        49,
                        66,
                        55,
                        52,
                        53,
                        120,
                        120,
                        120,
                        byte.MaxValue
                    });
                    sendBuffer = byteArray.Buffer;
                    byteArray.Dispose();
                }
                logintcp.Send(sendBuffer);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        public void xiamai()
        {
            try
            {
                PJoinChannelReq pJoinChannelReq = new PJoinChannelReq();
                pJoinChannelReq.uid = uid;
                pJoinChannelReq.topsid = ((sid_l == 0) ? sid : sid_l);
                pJoinChannelReq.subSid = subid;
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.position = 0;
                    byteArray.writeBytes(new byte[22]
                    {
                        151,
                        0,
                        0,
                        0,
                        11,
                        208,
                        7,
                        0,
                        200,
                        0,
                        0,
                        0,
                        2,
                        51,
                        0,
                        0,
                        0,
                        0,
                        12,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[28]
                    {
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        113,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        1,
                        2,
                        51,
                        0,
                        0,
                        16,
                        0,
                        0,
                        2,
                        3,
                        1,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[47]
                    {
                        0,
                        0,
                        0,
                        0,
                        29,
                        0,
                        0,
                        6,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        13,
                        0,
                        99,
                        104,
                        97,
                        110,
                        110,
                        101,
                        108,
                        65,
                        117,
                        116,
                        104,
                        101,
                        114,
                        56,
                        0,
                        0,
                        7,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        4,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[64]
                    {
                        3,
                        0,
                        0,
                        0,
                        32,
                        0,
                        52,
                        55,
                        53,
                        56,
                        52,
                        52,
                        49,
                        65,
                        51,
                        66,
                        67,
                        48,
                        52,
                        51,
                        49,
                        68,
                        49,
                        69,
                        70,
                        51,
                        48,
                        53,
                        52,
                        69,
                        50,
                        53,
                        66,
                        49,
                        66,
                        55,
                        52,
                        53,
                        120,
                        120,
                        120,
                        byte.MaxValue,
                        148,
                        0,
                        0,
                        0,
                        11,
                        208,
                        7,
                        0,
                        200,
                        0,
                        0,
                        0,
                        3,
                        102,
                        0,
                        0,
                        0,
                        0,
                        17,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[4]
                    {
                        1,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[25]
                    {
                        1,
                        0,
                        0,
                        0,
                        0,
                        105,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        1,
                        3,
                        102,
                        0,
                        0,
                        16,
                        0,
                        0,
                        2,
                        3,
                        1,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[39]
                    {
                        0,
                        0,
                        0,
                        0,
                        21,
                        0,
                        0,
                        6,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        5,
                        0,
                        85,
                        73,
                        110,
                        102,
                        111,
                        56,
                        0,
                        0,
                        7,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        4,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[64]
                    {
                        3,
                        0,
                        0,
                        0,
                        32,
                        0,
                        52,
                        55,
                        53,
                        56,
                        52,
                        52,
                        49,
                        65,
                        51,
                        66,
                        67,
                        48,
                        52,
                        51,
                        49,
                        68,
                        49,
                        69,
                        70,
                        51,
                        48,
                        53,
                        52,
                        69,
                        50,
                        53,
                        66,
                        49,
                        66,
                        55,
                        52,
                        53,
                        120,
                        120,
                        120,
                        byte.MaxValue,
                        157,
                        0,
                        0,
                        0,
                        11,
                        208,
                        7,
                        0,
                        200,
                        0,
                        0,
                        0,
                        2,
                        178,
                        47,
                        0,
                        0,
                        0,
                        16,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[4]
                    {
                        1,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[24]
                    {
                        3,
                        0,
                        0,
                        0,
                        115,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        1,
                        2,
                        178,
                        47,
                        0,
                        16,
                        0,
                        0,
                        2,
                        3,
                        1,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[49]
                    {
                        0,
                        0,
                        0,
                        0,
                        31,
                        0,
                        0,
                        6,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        15,
                        0,
                        99,
                        104,
                        97,
                        110,
                        110,
                        101,
                        108,
                        85,
                        115,
                        101,
                        114,
                        73,
                        110,
                        102,
                        111,
                        56,
                        0,
                        0,
                        7,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        4,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[42]
                    {
                        3,
                        0,
                        0,
                        0,
                        32,
                        0,
                        52,
                        55,
                        53,
                        56,
                        52,
                        52,
                        49,
                        65,
                        51,
                        66,
                        67,
                        48,
                        52,
                        51,
                        49,
                        68,
                        49,
                        69,
                        70,
                        51,
                        48,
                        53,
                        52,
                        69,
                        50,
                        53,
                        66,
                        49,
                        66,
                        55,
                        52,
                        53,
                        120,
                        120,
                        120,
                        byte.MaxValue
                    });
                    sendBuffer = byteArray.Buffer;
                    byteArray.Dispose();
                }
                logintcp.Send(sendBuffer);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        public void connect_s()
        {
            startconnectservice = DateTime.Now;
            if (servicetcp != null)
            {
                try
                {
                    servicetcp.ReciveEvent -= method_25;
                    servicetcp.CloseConEvent -= OnCloseConnectEvent_S;
                    servicetcp.ConEvent -= OnCon_S;
                }
                catch
                {
                }
                try
                {
                    servicetcp.Dispose();
                }
                catch
                {
                }
            }
            servicetcp = new MyTcp1225(serviceip, serviceport, ProxyTypes.None, "", localip);
            servicetcp.ReciveEvent += method_25;
            servicetcp.CloseConEvent += OnCloseConnectEvent_S;
            servicetcp.ConEvent += OnCon_S;
            servicetcp.Connect();
        }

        public void OnSendEvent_S()
        {
        }

        public void OnCloseConnectEvent_S()
        {
            isloginservice = false;
            try
            {
                servicetcp.ReciveEvent -= method_25;
                servicetcp.CloseConEvent -= OnCloseConnectEvent_S;
                servicetcp.ConEvent -= OnCon_S;
            }
            catch
            {
            }
            try
            {
                servicetcp.Dispose();
            }
            catch
            {
            }
            if (status == 2)
            {
                Send_Service_1E73();
            }
        }

        public void OnCon_S()
        {
            try
            {
                Send_0411_s();
            }
            catch
            {
            }
        }

        private void method_25(byte[] byte_3)
        {
            try
            {
                if (byte_3 != null && byte_3.Length >= 10 && byte_3[8] == 200)
                {
                    string text = bytetool.fromArray(byte_3);
                    string text2 = "";
                    try
                    {
                        text2 = text.Substring(8, 4).ToUpper();
                    }
                    catch
                    {
                    }
                    if (!string.IsNullOrWhiteSpace(text2))
                    {
                        if (!(text2 == "0412") && !(text2 == "0415") && !(text2 == "0287") && !(text2 == "0433"))
                        {
                            if (text2 == "04D7")
                            {
                                Recv_04D7_s(byte_3);
                            }
                            else if (text2 == "0BD0")
                            {
                                string a;
                                try
                                {
                                    text.Substring(24, 4).ToUpper();
                                    a = text.Substring(24, 6).ToUpper();
                                }
                                catch
                                {
                                    return;
                                }
                                if (a == "583901" && isxianche)
                                {
                                    isxianchewancheng = true;
                                }
                            }
                        }
                        else
                        {
                            Recv_0412_s(byte_3);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        public void Send_0411_s()
        {
            try
            {
                byte[] publicKey = rsautil.getInstance().getPublicKey();
                byte[] exponent = rsautil.getInstance().getExponent();
                byte[] sendBuffer = ProtoPacket.pack(new PExchangeKey(publicKey, exponent));
                servicetcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        public void Recv_0412_s(byte[] byte_3)
        {
            try
            {
                byte[] array = null;
                using (ByteArray byteArray = new ByteArray(byte_3))
                {
                    ProtoPacket protoPacket = ProtoPacket.unpack(byteArray.Buffer);
                    uint num = protoPacket.getBuffer().readUnsignedShort();
                    if (num != 0)
                    {
                        using (ByteArray byteArray2 = new ByteArray())
                        {
                            protoPacket.getBuffer().readBytes(byteArray2, 0u, num);
                            array = byteArray2.Buffer;
                            byteArray2.Dispose();
                        }
                    }
                    byteArray.Dispose();
                }
                if (array == null || array.Length == 0)
                {
                    throw new Exception("rsa fail");
                }
                byte[] bytes = rsautil.getInstance().decrypt(array);
                servicetcp.setarc(bytes);
                method_26();
            }
            catch
            {
            }
        }

        private void method_26()
        {
            try
            {
                byte[] sendBuffer;
                if (logintype == 1)
                {
                    PCS_APLogin pCS_APLogin = new PCS_APLogin();
                    pCS_APLogin.m_strPassword = bytetool.String2Bytes(sha1.hash(pwd, Encoding.ASCII).ToLower());
                    if (yycookie != null && yycookie.Length != 0)
                    {
                        pCS_APLogin.m_bRelogin = true;
                    }
                    else
                    {
                        pCS_APLogin.m_bRelogin = false;
                    }
                    pCS_APLogin.m_uAppID = 260u;
                    pCS_APLogin.m_uUid.low = Convert.ToUInt32(uid);
                    pCS_APLogin.m_strCookie = yycookie;
                    pCS_APLogin.m_strAccount = Encoding.UTF8.GetBytes(username);
                    pCS_APLogin.m_uCliType = 2u;
                    pCS_APLogin.m_strFrom = bytetool.String2Bytes("8.45.0.1");
                    pCS_APLogin.m_strCliVer = bytetool.String2Bytes("8.45.0.1");
                    sendBuffer = ProtoPacket.pack(pCS_APLogin);
                }
                else
                {
                    sendBuffer = ProtoPacket.pack(new PCS_APLogin
                    {
                        m_strAccount = bytetool.String2Bytes(username),
                        m_strPassword = bytetool.String2Bytes(pwden),
                        m_bRelogin = false,
                        m_uAppID = 260u,
                        m_uUid =
                        {
                            low = Convert.ToUInt32(uid)
                        },
                        m_strCookie = yycookie,
                        m_uCliType = 2u,
                        m_strFrom = bytetool.String2Bytes("yymwebflsh"),
                        m_strCliVer = bytetool.String2Bytes("yymwebflsh")
                    });
                }
                servicetcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        public void Recv_04D7_s(byte[] byte_3)
        {
            using (ByteArray byteArray = new ByteArray(byte_3))
            {
                ProtoPacket protoPacket = ProtoPacket.unpack(byteArray.Buffer);
                PCS_APLoginRes pCS_APLoginRes = new PCS_APLoginRes();
                pCS_APLoginRes.unmarshall(protoPacket.getBuffer());
                byteArray.Dispose();
                if (pCS_APLoginRes.m_uResCode != 200)
                {
                    isloginservice = false;
                    OnCloseConnectEvent_S();
                }
                else
                {
                    isloginservice = true;
                    if (isxianche)
                    {
                        method_28();
                    }
                    if (isqutubiao)
                    {
                        method_27("4000");
                    }
                }
            }
        }

        private void method_27(string string_14)
        {
            try
            {
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.position = 0;
                    byteArray.writeBytes(new byte[10]
                    {
                        56,
                        0,
                        0,
                        0,
                        88,
                        206,
                        9,
                        0,
                        200,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[16]
                    {
                        0,
                        0,
                        0,
                        0,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[12]
                    {
                        0,
                        0,
                        0,
                        0,
                        2,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(subid)));
                    byteArray.writeBytes(new byte[28]
                    {
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        172,
                        0,
                        0,
                        0,
                        11,
                        208,
                        7,
                        0,
                        200,
                        0,
                        0,
                        0,
                        88,
                        207,
                        9,
                        0,
                        0,
                        0,
                        46,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[16]
                    {
                        0,
                        0,
                        0,
                        0,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[12]
                    {
                        0,
                        0,
                        0,
                        0,
                        2,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(subid)));
                    byteArray.writeBytes(new byte[26]
                    {
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        100,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        1,
                        88,
                        207,
                        9,
                        0,
                        16,
                        0,
                        0,
                        2,
                        4,
                        1,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[34]
                    {
                        0,
                        0,
                        0,
                        0,
                        16,
                        0,
                        0,
                        6,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        56,
                        0,
                        0,
                        7,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        4,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[52]
                    {
                        3,
                        0,
                        0,
                        0,
                        32,
                        0,
                        57,
                        65,
                        54,
                        52,
                        57,
                        51,
                        48,
                        48,
                        52,
                        65,
                        55,
                        70,
                        68,
                        53,
                        53,
                        69,
                        53,
                        68,
                        68,
                        68,
                        51,
                        52,
                        50,
                        67,
                        65,
                        56,
                        69,
                        57,
                        67,
                        54,
                        52,
                        54,
                        120,
                        120,
                        120,
                        byte.MaxValue,
                        56,
                        0,
                        0,
                        0,
                        88,
                        206,
                        9,
                        0,
                        200,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[16]
                    {
                        0,
                        0,
                        0,
                        0,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[12]
                    {
                        0,
                        0,
                        0,
                        0,
                        2,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(subid)));
                    byteArray.writeBytes(new byte[30]
                    {
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        203,
                        0,
                        0,
                        0,
                        11,
                        208,
                        7,
                        0,
                        200,
                        0,
                        0,
                        0,
                        88,
                        56,
                        1,
                        0,
                        0,
                        0,
                        77,
                        0,
                        0,
                        0,
                        22,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[14]
                    {
                        45,
                        0,
                        0,
                        0,
                        45,
                        0,
                        0,
                        0,
                        88,
                        228,
                        5,
                        0,
                        200,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[23]
                    {
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        1,
                        0,
                        17,
                        0,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        1,
                        0,
                        48,
                        2,
                        0,
                        4,
                        0
                    });
                    byteArray.writeBytes(Encoding.Default.GetBytes(string_14));
                    byteArray.writeBytes(new byte[6]);
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(subid)));
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[24]
                    {
                        0,
                        0,
                        0,
                        0,
                        100,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        1,
                        88,
                        56,
                        1,
                        0,
                        16,
                        0,
                        0,
                        2,
                        4,
                        1,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[34]
                    {
                        0,
                        0,
                        0,
                        0,
                        16,
                        0,
                        0,
                        6,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        56,
                        0,
                        0,
                        7,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        4,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[66]
                    {
                        3,
                        0,
                        0,
                        0,
                        32,
                        0,
                        57,
                        65,
                        54,
                        52,
                        57,
                        51,
                        48,
                        48,
                        52,
                        65,
                        55,
                        70,
                        68,
                        53,
                        53,
                        69,
                        53,
                        68,
                        68,
                        68,
                        51,
                        52,
                        50,
                        67,
                        65,
                        56,
                        69,
                        57,
                        67,
                        54,
                        52,
                        54,
                        120,
                        120,
                        120,
                        byte.MaxValue,
                        168,
                        0,
                        0,
                        0,
                        11,
                        208,
                        7,
                        0,
                        200,
                        0,
                        0,
                        0,
                        88,
                        56,
                        1,
                        0,
                        0,
                        0,
                        42,
                        0,
                        0,
                        0,
                        155,
                        58
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[20]
                    {
                        10,
                        0,
                        0,
                        0,
                        11,
                        0,
                        0,
                        0,
                        232,
                        3,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(subid)));
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[24]
                    {
                        0,
                        0,
                        0,
                        0,
                        100,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        1,
                        88,
                        56,
                        1,
                        0,
                        16,
                        0,
                        0,
                        2,
                        4,
                        1,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[34]
                    {
                        0,
                        0,
                        0,
                        0,
                        16,
                        0,
                        0,
                        6,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        56,
                        0,
                        0,
                        7,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        4,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sid)));
                    byteArray.writeBytes(new byte[42]
                    {
                        3,
                        0,
                        0,
                        0,
                        32,
                        0,
                        57,
                        65,
                        54,
                        52,
                        57,
                        51,
                        48,
                        48,
                        52,
                        65,
                        55,
                        70,
                        68,
                        53,
                        53,
                        69,
                        53,
                        68,
                        68,
                        68,
                        51,
                        52,
                        50,
                        67,
                        65,
                        56,
                        69,
                        57,
                        67,
                        54,
                        52,
                        54,
                        120,
                        120,
                        120,
                        byte.MaxValue
                    });
                    sendBuffer = byteArray.Buffer;
                    byteArray.Dispose();
                }
                servicetcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        internal void shuahua(int v, string beishuahuamingzi)
        {
            throw new NotImplementedException();
        }

        private void method_28()
        {
            try
            {
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.position = 4;
                    byteArray.writeBytes(bytetool.strToToHexByte("0BD00700C800000058380100C8002E000000A43A"));
                    byteArray.writeUnsignedInt(sidnew);
                    byteArray.writeUnsignedInt(Convert.ToUInt32(uid));
                    byteArray.writeBytes(bytetool.strToToHexByte("0A0000000B0000004C0400000000000000000100"));
                    byteArray.writeUnsignedInt(subidnew);
                    byteArray.writeUnsignedInt(Convert.ToUInt32(uid));
                    byteArray.writeBytes(bytetool.strToToHexByte("0001000000000000370000000800000158380100100000020401000033A49F43000000001B00000702000000FF030000050031353031320004000002003336787878FF"));
                    byteArray.position = 0;
                    byteArray.writeUnsignedInt(Convert.ToUInt32(byteArray.length));
                    sendBuffer = byteArray.Buffer;
                    byteArray.Dispose();
                }
                servicetcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        public void SendSH()
        {
            try
            {
                byte[] sendBuffer = new byte[14]
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
                };
                servicetcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        public void zhibotongzhi(uint uint_6)
        {
            try
            {
                byte[] sendBuffer = null;
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.position = 0;
                    byteArray.writeBytes(new byte[24]
                    {
                        218,
                        0,
                        0,
                        0,
                        11,
                        208,
                        7,
                        0,
                        200,
                        0,
                        0,
                        0,
                        88,
                        56,
                        1,
                        0,
                        200,
                        0,
                        125,
                        0,
                        0,
                        0,
                        165,
                        58
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sidnew)));
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray.writeBytes(new byte[16]
                    {
                        89,
                        0,
                        0,
                        0,
                        38,
                        12,
                        207,
                        0,
                        4,
                        0,
                        0,
                        0,
                        5,
                        0,
                        36,
                        0
                    });
                    byteArray.writeBytes(new byte[36]
                    {
                        100,
                        102,
                        48,
                        99,
                        53,
                        52,
                        99,
                        101,
                        45,
                        99,
                        50,
                        101,
                        55,
                        45,
                        52,
                        49,
                        53,
                        98,
                        45,
                        57,
                        48,
                        48,
                        53,
                        45,
                        100,
                        57,
                        55,
                        52,
                        57,
                        55,
                        54,
                        55,
                        53,
                        48,
                        97,
                        56
                    });
                    byteArray.writeBytes(new byte[33]
                    {
                        1,
                        0,
                        8,
                        0,
                        53,
                        57,
                        53,
                        57,
                        56,
                        52,
                        55,
                        56,
                        6,
                        0,
                        6,
                        0,
                        51,
                        46,
                        49,
                        51,
                        46,
                        50,
                        2,
                        0,
                        1,
                        0,
                        49,
                        12,
                        0,
                        1,
                        0,
                        0,
                        0
                    });
                    byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uint_6)));
                    byteArray.writeBytes(new byte[97]
                    {
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        67,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        1,
                        88,
                        56,
                        1,
                        0,
                        16,
                        0,
                        0,
                        2,
                        4,
                        1,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        7,
                        0,
                        0,
                        0,
                        0,
                        31,
                        0,
                        0,
                        8,
                        25,
                        0,
                        3,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        2,
                        0,
                        54,
                        50,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        50,
                        3,
                        0,
                        0,
                        0,
                        0,
                        0,
                        120,
                        120,
                        120,
                        byte.MaxValue
                    });
                    sendBuffer = byteArray.Buffer;
                    byteArray.Dispose();
                }
                servicetcp.Send(sendBuffer);
            }
            catch
            {
            }
        }

        public void daka2()
        {
            Encoding @default = Encoding.Default;
            if (Convert.ToByte(@default.GetBytes(Convert.ToUInt32(subidnew).ToString()).Length) == 8)
            {
                try
                {
                    byte[] sendBuffer = null;
                    using (ByteArray byteArray = new ByteArray())
                    {
                        byteArray.endian = Endian.LITTLE_ENDIAN;
                        byteArray.position = 0;
                        byteArray.writeBytes(new byte[24]
                        {
                            200,
                            0,
                            0,
                            0,
                            11,
                            208,
                            7,
                            0,
                            200,
                            0,
                            0,
                            0,
                            88,
                            56,
                            1,
                            0,
                            200,
                            0,
                            118,
                            0,
                            0,
                            0,
                            164,
                            58
                        });
                        byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sidnew)));
                        byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                        byteArray.writeBytes(new byte[72]
                        {
                            82,
                            0,
                            0,
                            0,
                            44,
                            1,
                            0,
                            0,
                            123,
                            0,
                            0,
                            0,
                            72,
                            0,
                            183,
                            8,
                            0,
                            0,
                            78,
                            4,
                            0,
                            0,
                            213,
                            0,
                            0,
                            0,
                            34,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            1,
                            0,
                            0,
                            0,
                            1,
                            0,
                            0,
                            0,
                            10,
                            0
                        });
                        Encoding default2 = Encoding.Default;
                        byteArray.writeBytes(default2.GetBytes(Convert.ToUInt32(subidnew).ToString()));
                        byteArray.writeBytes(new byte[12]
                        {
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            1,
                            0
                        });
                        byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(subidnew)));
                        byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                        byteArray.writeBytes(new byte[28]
                        {
                            0,
                            1,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            56,
                            0,
                            0,
                            0,
                            8,
                            0,
                            0,
                            1,
                            88,
                            56,
                            1,
                            0,
                            16,
                            0,
                            0,
                            2,
                            4,
                            1,
                            0,
                            0
                        });
                        byteArray.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                        byteArray.writeBytes(new byte[36]
                        {
                            0,
                            0,
                            0,
                            0,
                            28,
                            0,
                            0,
                            7,
                            2,
                            0,
                            0,
                            0,
                            byte.MaxValue,
                            3,
                            0,
                            0,
                            5,
                            0,
                            49,
                            53,
                            48,
                            49,
                            50,
                            0,
                            4,
                            0,
                            0,
                            3,
                            0,
                            49,
                            49,
                            48,
                            120,
                            120,
                            120,
                            byte.MaxValue
                        });
                        sendBuffer = byteArray.Buffer;
                        byteArray.Dispose();
                    }
                    servicetcp.Send(sendBuffer);
                }
                catch
                {
                }
            }
            else
            {
                try
                {
                    byte[] sendBuffer2 = null;
                    using (ByteArray byteArray2 = new ByteArray())
                    {
                        byteArray2.endian = Endian.LITTLE_ENDIAN;
                        byteArray2.position = 0;
                        byteArray2.writeBytes(new byte[24]
                        {
                            200,
                            0,
                            0,
                            0,
                            11,
                            208,
                            7,
                            0,
                            200,
                            0,
                            0,
                            0,
                            88,
                            56,
                            1,
                            0,
                            200,
                            0,
                            118,
                            0,
                            0,
                            0,
                            164,
                            58
                        });
                        byteArray2.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sidnew)));
                        byteArray2.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                        byteArray2.writeBytes(new byte[72]
                        {
                            82,
                            0,
                            0,
                            0,
                            44,
                            1,
                            0,
                            0,
                            123,
                            0,
                            0,
                            0,
                            72,
                            0,
                            183,
                            8,
                            0,
                            0,
                            78,
                            4,
                            0,
                            0,
                            213,
                            0,
                            0,
                            0,
                            34,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            1,
                            0,
                            0,
                            0,
                            1,
                            0,
                            0,
                            0,
                            10,
                            0
                        });
                        Encoding default3 = Encoding.Default;
                        byteArray2.writeBytes(default3.GetBytes(Convert.ToUInt32(subidnew).ToString()));
                        byteArray2.writeBytes(new byte[10]
                        {
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            1,
                            0
                        });
                        byteArray2.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(subidnew)));
                        byteArray2.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                        byteArray2.writeBytes(new byte[28]
                        {
                            0,
                            1,
                            0,
                            0,
                            0,
                            0,
                            0,
                            0,
                            56,
                            0,
                            0,
                            0,
                            8,
                            0,
                            0,
                            1,
                            88,
                            56,
                            1,
                            0,
                            16,
                            0,
                            0,
                            2,
                            4,
                            1,
                            0,
                            0
                        });
                        byteArray2.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                        byteArray2.writeBytes(new byte[36]
                        {
                            0,
                            0,
                            0,
                            0,
                            28,
                            0,
                            0,
                            7,
                            2,
                            0,
                            0,
                            0,
                            byte.MaxValue,
                            3,
                            0,
                            0,
                            5,
                            0,
                            49,
                            53,
                            48,
                            49,
                            50,
                            0,
                            4,
                            0,
                            0,
                            3,
                            0,
                            49,
                            49,
                            48,
                            120,
                            120,
                            120,
                            byte.MaxValue
                        });
                        sendBuffer2 = byteArray2.Buffer;
                        byteArray2.Dispose();
                    }
                    servicetcp.Send(sendBuffer2);
                }
                catch
                {
                }
            }
        }

        public void shuahua(uint uint_6, string string_14)
        {
            try
            {
                byte[] first = new byte[14]
                {
                    11,
                    208,
                    7,
                    0,
                    200,
                    0,
                    0,
                    0,
                    88,
                    56,
                    1,
                    0,
                    200,
                    0
                };
                byte[] first2 = new byte[50]
                {
                    39,
                    12,
                    3,
                    0,
                    5,
                    0,
                    0,
                    0,
                    3,
                    0,
                    36,
                    0,
                    102,
                    56,
                    56,
                    99,
                    101,
                    100,
                    98,
                    57,
                    45,
                    48,
                    48,
                    56,
                    52,
                    45,
                    52,
                    102,
                    57,
                    54,
                    45,
                    57,
                    52,
                    99,
                    48,
                    45,
                    53,
                    97,
                    98,
                    100,
                    55,
                    55,
                    51,
                    99,
                    98,
                    49,
                    57,
                    102,
                    1,
                    0
                };
                byte[] second = null;
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.position = 2;
                    ByteArray byteArray2 = byteArray;
                    Encoding @default = Encoding.Default;
                    byteArray2[0] = Convert.ToByte(@default.GetBytes(Convert.ToUInt32(subidnew).ToString()).Length);
                    ByteArray byteArray3 = byteArray;
                    Encoding default2 = Encoding.Default;
                    byteArray3.writeBytes(default2.GetBytes(Convert.ToUInt32(subidnew).ToString()));
                    byteArray.writeBytes(new byte[54]
                    {
                        2,
                        0,
                        1,
                        0,
                        49,
                        5,
                        0,
                        36,
                        0,
                        100,
                        52,
                        99,
                        51,
                        99,
                        100,
                        49,
                        99,
                        45,
                        102,
                        48,
                        57,
                        101,
                        45,
                        52,
                        97,
                        51,
                        55,
                        45,
                        98,
                        56,
                        100,
                        97,
                        45,
                        98,
                        57,
                        54,
                        100,
                        99,
                        54,
                        99,
                        56,
                        49,
                        97,
                        57,
                        49,
                        6,
                        0,
                        5,
                        0,
                        52,
                        46,
                        54,
                        46,
                        52
                    });
                    second = byteArray.Buffer;
                    byteArray.Dispose();
                }
                first2 = first2.Concat(second).ToArray();
                byte[] first3 = null;
                using (ByteArray byteArray4 = new ByteArray())
                {
                    byteArray4.endian = Endian.LITTLE_ENDIAN;
                    ByteArray byteArray5 = byteArray4;
                    byteArray5.writeBytes(new byte[6]
                    {
                        134,
                        0,
                        1,
                        0,
                        0,
                        0
                    });
                    byteArray4.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uint_6)));
                    byteArray4.writeBytes(new byte[31]
                    {
                        3,
                        0,
                        0,
                        0,
                        25,
                        0,
                        77,
                        79,
                        66,
                        83,
                        69,
                        78,
                        68,
                        70,
                        76,
                        87,
                        83,
                        69,
                        81,
                        95,
                        84,
                        79,
                        95,
                        78,
                        73,
                        67,
                        75,
                        78,
                        65,
                        77,
                        69
                    });
                    first3 = byteArray4.Buffer;
                    byteArray4.Dispose();
                }
                byte[] second2 = null;
                using (ByteArray byteArray6 = new ByteArray())
                {
                    byteArray6.endian = Endian.LITTLE_ENDIAN;
                    byteArray6.position = 2;
                    byteArray6[0] = Convert.ToByte(Encoding.UTF8.GetBytes(string_14).Length);
                    byteArray6.writeBytes(Encoding.UTF8.GetBytes(string_14));
                    second2 = byteArray6.Buffer;
                    byteArray6.Dispose();
                }
                first3 = first3.Concat(second2).ToArray();
                byte[] second3 = new byte[45]
                {
                    11,
                    0,
                    110,
                    111,
                    98,
                    108,
                    101,
                    95,
                    108,
                    101,
                    118,
                    101,
                    108,
                    1,
                    0,
                    48,
                    27,
                    0,
                    77,
                    79,
                    66,
                    83,
                    69,
                    78,
                    68,
                    70,
                    76,
                    87,
                    83,
                    69,
                    81,
                    95,
                    70,
                    82,
                    79,
                    77,
                    95,
                    78,
                    73,
                    67,
                    75,
                    78,
                    65,
                    77,
                    69
                };
                first3 = first3.Concat(second3).ToArray();
                byte[] second4 = null;
                using (ByteArray byteArray7 = new ByteArray())
                {
                    byteArray7.endian = Endian.LITTLE_ENDIAN;
                    byteArray7.position = 2;
                    byteArray7[0] = Convert.ToByte(Encoding.UTF8.GetBytes(nicheng).Length);
                    byteArray7.writeBytes(Encoding.UTF8.GetBytes(nicheng));
                    second4 = byteArray7.Buffer;
                    byteArray7.Dispose();
                }
                first3 = first3.Concat(second4).ToArray();
                first3[0] = Convert.ToByte(new ByteArray(first3)
                {
                    endian = Endian.LITTLE_ENDIAN,
                    position = 4
                }.length - 2);
                byte[] array = first2.Concat(first3).ToArray();
                byte[] second5 = BitConverter.GetBytes(array.Length).Concat(array).ToArray();
                byte[] first4 = null;
                using (ByteArray byteArray8 = new ByteArray())
                {
                    byteArray8.endian = Endian.LITTLE_ENDIAN;
                    byteArray8.writeBytes(new byte[2]
                    {
                        165,
                        58
                    });
                    byteArray8.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sidnew)));
                    byteArray8.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    first4 = byteArray8.Buffer;
                    byteArray8.Dispose();
                }
                first4 = first4.Concat(second5).ToArray();
                byte[] second6 = null;
                using (ByteArray byteArray9 = new ByteArray())
                {
                    byteArray9.endian = Endian.LITTLE_ENDIAN;
                    byteArray9.writeBytes(new byte[6]);
                    byteArray9.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(subidnew)));
                    byteArray9.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray9.writeBytes(new byte[4]);
                    second6 = byteArray9.Buffer;
                    byteArray9.Dispose();
                }
                first4 = first4.Concat(second6).ToArray();
                byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(first4.Length));
                byte[] second7 = null;
                using (ByteArray byteArray10 = new ByteArray())
                {
                    byteArray10.endian = Endian.LITTLE_ENDIAN;
                    byteArray10.writeBytes(new byte[20]
                    {
                        100,
                        0,
                        0,
                        0,
                        8,
                        0,
                        0,
                        1,
                        88,
                        56,
                        1,
                        0,
                        16,
                        0,
                        0,
                        2,
                        4,
                        1,
                        0,
                        0
                    });
                    byteArray10.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(uid)));
                    byteArray10.writeBytes(new byte[34]
                    {
                        0,
                        0,
                        0,
                        0,
                        16,
                        0,
                        0,
                        6,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        56,
                        0,
                        0,
                        7,
                        2,
                        0,
                        0,
                        0,
                        1,
                        0,
                        0,
                        0,
                        4,
                        0
                    });
                    byteArray10.writeBytes(BitConverter.GetBytes(Convert.ToUInt32(sidnew)));
                    byteArray10.writeBytes(new byte[42]
                    {
                        3,
                        0,
                        0,
                        0,
                        32,
                        0,
                        56,
                        69,
                        56,
                        49,
                        51,
                        55,
                        55,
                        55,
                        68,
                        69,
                        69,
                        53,
                        65,
                        68,
                        50,
                        70,
                        49,
                        69,
                        66,
                        65,
                        69,
                        49,
                        52,
                        48,
                        67,
                        48,
                        70,
                        57,
                        57,
                        53,
                        56,
                        52,
                        120,
                        120,
                        120,
                        byte.MaxValue
                    });
                    second7 = byteArray10.Buffer;
                    byteArray10.Dispose();
                }
                byte[] first5 = first.Concat(bytes).ToArray();
                first5 = first5.Concat(first4).ToArray();
                first5 = first5.Concat(second7).ToArray();
                byte[] sendBuffer = BitConverter.GetBytes(first5.Length + 4).Concat(first5).ToArray();
                servicetcp.Send(sendBuffer);
            }
            catch
            {
            }
        }
    }
}
