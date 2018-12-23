using Newtonsoft.Json;
using Org.Mentalis.Network.ProxySocket;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using ZHANHUO.Common;
using ZHANHUO.Model.YYModel;

namespace ZHANHUO.Model
{
    public class MyUser1222
    {
        public delegate void OnGetUserCount(uint uint_0);

        public delegate void OnGetUserList(uint uint_0);

        [CompilerGenerated]
        private OnGetUserCount onGetUserCount_0;

        [CompilerGenerated]
        private OnGetUserList onGetUserList_0;

        [CompilerGenerated]
        private int int_0;

        [CompilerGenerated]
        private int int_1;

        [CompilerGenerated]
        private string string_0;

        [CompilerGenerated]
        private string string_1;

        [CompilerGenerated]
        private string string_2;

        [CompilerGenerated]
        private int int_2;

        [CompilerGenerated]
        private bool bool_0;

        [CompilerGenerated]
        private int int_3;

        [CompilerGenerated]
        private int int_4;

        [CompilerGenerated]
        private int int_5;

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
        private string string_5;

        [CompilerGenerated]
        private OldTcp oldTcp_0;

        [CompilerGenerated]
        private OldTcp oldTcp_1;

        [CompilerGenerated]
        private string string_6;

        [CompilerGenerated]
        private int int_6;

        [CompilerGenerated]
        private int int_7;

        [CompilerGenerated]
        private ProxyTypes proxyTypes_0;

        [CompilerGenerated]
        private string string_7;

        [CompilerGenerated]
        private string string_8;

        [CompilerGenerated]
        private int int_8;

        [CompilerGenerated]
        private bool bool_1;

        [CompilerGenerated]
        private bool bool_2;

        [CompilerGenerated]
        private byte[] byte_0;

        [CompilerGenerated]
        private string string_9;

        [CompilerGenerated]
        private int int_9;

        [CompilerGenerated]
        private string string_10;

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

        [CompilerGenerated]
        private DateTime dateTime_5;

        [CompilerGenerated]
        private DateTime dateTime_6;

        [CompilerGenerated]
        private DateTime dateTime_7;

        [CompilerGenerated]
        private DateTime dateTime_8;

        [CompilerGenerated]
        private DateTime dateTime_9;

        [CompilerGenerated]
        private DateTime dateTime_10;

        [CompilerGenerated]
        private bool bool_3;

        [CompilerGenerated]
        private bool bool_4;

        [CompilerGenerated]
        private bool bool_5;

        [CompilerGenerated]
        private bool bool_6;

        [CompilerGenerated]
        private string string_11;

        [CompilerGenerated]
        private int int_10;

        [CompilerGenerated]
        private DateTime dateTime_11;

        private System.Timers.Timer timer_0;

        private System.Timers.Timer timer_1;

        private uint uint_5;

        private ByteArray byteArray_0;

        private int int_11;

        private ByteArray byteArray_1;

        private int int_12;

        public int index
        {
            get;
            set;
        }

        public int id
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
                        if (mytrace == "MMCW")
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
                string str = loginstatus.ToString();
                return str + "-" + joinstatus.ToString();
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

        public OldTcp logintcp
        {
            get;
            set;
        }

        public OldTcp servicetcp
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
                if (logintype == 1)
                {
                    return "";
                }
                return daili;
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

        public bool isinqueue
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
            get;
            set;
        }

        public int jointimes
        {
            get;
            set;
        }

        public string loseconreason
        {
            get;
            set;
        }

        public DateTime startlogintime
        {
            get;
            set;
        }

        public DateTime weblogintime
        {
            get;
            set;
        }

        public DateTime startjointime
        {
            get;
            set;
        }

        public DateTime joinchanneltime
        {
            get;
            set;
        }

        public DateTime lasthearttime
        {
            get;
            set;
        }

        public DateTime lastsendhearttime
        {
            get;
            set;
        }

        public DateTime lastsendtime
        {
            get;
            set;
        }

        public DateTime buhaotime
        {
            get;
            set;
        }

        public DateTime checkinchaneltime
        {
            get;
            set;
        }

        public DateTime lastonlinetime
        {
            get;
            set;
        }

        public DateTime startloginservicetime
        {
            get;
            set;
        }

        public string mcki
        {
            get
            {
                if (lasthearttime == DateTime.MinValue)
                {
                    return "";
                }
                return lasthearttime.ToString("HHmm");
            }
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

        public bool isgongneng
        {
            get;
            set;
        }

        public bool isxianche
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

        public DateTime lastservicehearttime
        {
            get;
            set;
        }

        public event OnGetUserCount Event_0
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

        public event OnGetUserList Event_1
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

        private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (status == 2)
                {
                    if (uint_5 % 15u == 0)
                    {
                        Send_041E();
                    }
                    uint_5++;
                }
            }
            catch
            {
            }
        }

        private void timer_1_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (logintcp != null)
                {
                    byte[] array = logintcp.recive();
                    if (array != null && array.Length != 0)
                    {
                        if (array[8] == 200 && array[9] == 0)
                        {
                            byteArray_0 = null;
                            byteArray_0 = new ByteArray();
                            using (ByteArray byteArray = new ByteArray(array))
                            {
                                int_11 = byteArray.ReadInt();
                            }
                            byteArray_0.writeBytes(array);
                        }
                        else if (byteArray_0 != null && byteArray_0.length > 0 && byteArray_0.length < int_11)
                        {
                            byteArray_0.writeBytes(array);
                        }
                        if (byteArray_0 != null && byteArray_0.length >= int_11)
                        {
                            int_11 = 0;
                            method_2(byteArray_0.Buffer);
                        }
                    }
                }
            }
            catch
            {
                byteArray_0 = null;
                int_11 = 0;
            }
        }

        public void SendSH()
        {
            try
            {
                byte[] bytes = new byte[14]
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
                servicetcp.Send(bytes);
                lastservicehearttime = DateTime.Now;
            }
            catch
            {
            }
        }

        public MyUser1222()
        {
            DateTime dateTime = lasthearttime = DateTime.MinValue;
            DateTime dateTime2 = dateTime;
            dateTime = (joinchanneltime = dateTime2);
            DateTime dateTime4 = dateTime;
            dateTime = (startjointime = dateTime4);
            DateTime dateTime6 = dateTime;
            dateTime = (weblogintime = dateTime6);
            DateTime dateTime8 = dateTime;
            dateTime = (startlogintime = dateTime8);
            DateTime dateTime10 = dateTime;
            dateTime = (lastservicehearttime = dateTime10);
            DateTime dateTime12 = dateTime;
            dateTime = (lastsendtime = dateTime12);
            DateTime dateTime14 = dateTime;
            dateTime = (buhaotime = dateTime14);
            DateTime dateTime16 = dateTime;
            dateTime = (checkinchaneltime = dateTime16);
            DateTime dateTime18 = dateTime;
            dateTime = (lastonlinetime = dateTime18);
            DateTime dateTime20 = dateTime;
            DateTime dateTime22 = startloginservicetime = dateTime20;
            dateTime = (lastsendhearttime = dateTime22);
            isxianche = false;
            isqutubiao = false;
            isudblogin = false;
            isfenghao = false;
            isloginservice = false;
            isinqueue = false;
            isgongneng = false;
            currentflag = 10000;
            string text2 = username = "";
            string text3 = text2;
            text2 = (yanzhengma = text3);
            string text5 = text2;
            string text7 = mytrace = text5;
            text2 = (daili = text7);
            timer_0 = new System.Timers.Timer(1000.0);
            timer_0.Elapsed += timer_0_Elapsed;
            timer_0.AutoReset = true;
            timer_0.Enabled = true;
            timer_0.Start();
            timer_1 = new System.Timers.Timer(50.0);
            timer_1.Elapsed += timer_1_Elapsed;
            timer_1.AutoReset = true;
            timer_1.Enabled = true;
            timer_1.Start();
        }

        public void resend()
        {
            try
            {
                if (lastsendtime != DateTime.MinValue && lastsendtime.AddSeconds(3.0) < DateTime.Now)
                {
                    lastsendtime = DateTime.Now;
                    if (currentflag >= 20001 && currentflag < 21000)
                    {
                        method_3();
                    }
                    else if (currentflag >= 40001 && currentflag < 41000)
                    {
                        method_8();
                    }
                    else if (currentflag >= 50001 && currentflag < 51000)
                    {
                        Send_0BD0_0307();
                    }
                }
            }
            catch
            {
            }
        }

        public void join()
        {
            try
            {
                if (logintype == 2)
                {
                    pt = ProxyTypes.None;
                    daili = "";
                }
                else if (logintype == 1 && isudblogin)
                {
                    pt = ProxyTypes.None;
                    daili = "";
                }
                heartbeat = 0;
                isinqueue = false;
                startjointime = DateTime.Now;
                currentflag = rdomhelper.getrandom(10001, 11000);
                logintcp = new OldTcp(apip, apport, daili, pt);
                if (logintcp.connect())
                {
                    method_3();
                }
                else
                {
                    OnConnected(false);
                }
            }
            catch
            {
                joinstatus = 0;
            }
        }

        public void OnConnected(bool bool_7, bool bool_8 = false)
        {
            if (!bool_7)
            {
                try
                {
                    if (status != 0)
                    {
                        status = 1;
                    }
                    joinstatus = 0;
                    currentflag = 10000;
                    isinqueue = false;
                    heartbeat = 0;
                    isloginservice = false;
                    startjointime = DateTime.MinValue;
                    lastonlinetime = DateTime.MinValue;
                    if (bool_8)
                    {
                        isudblogin = false;
                        checkinchaneltime = DateTime.MinValue;
                    }
                    if (logintcp != null)
                    {
                        logintcp.Dispose();
                    }
                }
                catch
                {
                }
            }
            else
            {
                method_3();
            }
        }

        private void method_0(byte[] byte_1)
        {
            try
            {
                if (byte_1[8] == 200 && byte_1[9] == 0)
                {
                    byteArray_0 = null;
                    byteArray_0 = new ByteArray();
                    using (ByteArray byteArray = new ByteArray(byte_1))
                    {
                        int_11 = byteArray.ReadInt();
                    }
                    byteArray_0.writeBytes(byte_1);
                }
                else if (byteArray_0 != null && byteArray_0.length > 0 && byteArray_0.length < int_11)
                {
                    byteArray_0.writeBytes(byte_1);
                }
                if (byteArray_0 != null && byteArray_0.length >= int_11)
                {
                    int_11 = 0;
                    method_2(byteArray_0.Buffer);
                }
            }
            catch
            {
                byteArray_0 = null;
                int_11 = 0;
            }
        }

        private void method_1()
        {
        }

        private void method_2(byte[] byte_1)
        {
            try
            {
                if (byte_1 != null && byte_1.Length >= 10 && byte_1[8] == 200)
                {
                    string text = bytetool.fromArray(byte_1);
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
                                method_7(byte_1);
                            }
                            else if (text2 == "04D7")
                            {
                                method_9(byte_1);
                            }
                            else if (text2 == "0422")
                            {
                                mytrace = "FO";
                                OnConnected(false, true);
                                isudblogin = false;
                            }
                            else if (text2 == "0BD0")
                            {
                                string text3;
                                string a;
                                try
                                {
                                    text3 = text.Substring(24, 4).ToUpper();
                                    a = text.Substring(24, 6).ToUpper();
                                }
                                catch
                                {
                                    return;
                                }
                                if (text3 == "1E74")
                                {
                                    Recv_Service_1E74(byte_1);
                                }
                                else if (text3 == "0308")
                                {
                                    method_10(byte_1);
                                }
                                else if (!(text3 == "0868"))
                                {
                                    if (text3 == "0242" && a == "02421F")
                                    {
                                        method_11(byte_1);
                                    }
                                    else if (!(text3 == "0302"))
                                    {
                                        if (!(text3 == "024D") && !(text3 == "0235") && !(text3 == "0240") && !(text3 == "020C") && !(text3 == "0422"))
                                        {
                                            if (text3 == "022C")
                                            {
                                                mytrace = "YDD";
                                            }
                                            else if (!(text3 == "0239"))
                                            {
                                                if (text3 == "041F")
                                                {
                                                    method_12(byte_1);
                                                }
                                                else if (text3 == "02D1")
                                                {
                                                    method_13(byte_1);
                                                }
                                                else if (text3 == "02B1")
                                                {
                                                    method_14(byte_1);
                                                }
                                                else if (text3 == "02B3")
                                                {
                                                    checkinchaneltime = DateTime.Now;
                                                }
                                                else if (text3 == "02B5")
                                                {
                                                    method_15(byte_1);
                                                }
                                                else if (text3 == "0248")
                                                {
                                                    OnConnected(false, true);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            loseconreason = "KO:" + text3;
                                            OnConnected(false, true);
                                            isudblogin = false;
                                        }
                                    }
                                }
                            }
                            else if (text2 == "041F")
                            {
                                method_12(byte_1);
                            }
                            else if (text2 == "024D" || text2 == "0235" || text2 == "0240" || text2 == "020C")
                            {
                                loseconreason = "OKO:" + text2;
                                OnConnected(false, true);
                            }
                        }
                        else
                        {
                            method_4(byte_1);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void method_3()
        {
            try
            {
                currentflag = rdomhelper.getrandom(20001, 21000);
                byte[] publicKey = rsautil.getInstance().getPublicKey();
                byte[] exponent = rsautil.getInstance().getExponent();
                byte[] bytes = ProtoPacket.pack(new PExchangeKeyExt(publicKey, exponent));
                logintcp.Send(bytes);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        private void method_4(byte[] byte_1)
        {
            try
            {
                if (currentflag <= 30000)
                {
                    byte[] array = null;
                    using (ByteArray byteArray = new ByteArray(byte_1))
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
                            method_8();
                        }
                        else
                        {
                            method_5();
                        }
                    }
                    else
                    {
                        method_6();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void method_5(bool bool_7 = false, byte[] byte_1 = null, byte[] byte_2 = null)
        {
            try
            {
                if (!bool_7)
                {
                    currentflag = rdomhelper.getrandom(30001, 31000);
                }
                else
                {
                    currentflag = rdomhelper.getrandom(31000, 32000);
                }
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
                if (bool_7)
                {
                    uDBYYLoginReq._pic_id = byte_1;
                    int num = 1;
                    using (MemoryStream stream = new MemoryStream(byte_2))
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
                    string text2 = yanzhengma = imagetool.CreateInstance().hqCode(byte_2, num);
                    string text3 = text2;
                    string s2 = text3;
                    uDBYYLoginReq._pic_code = Encoding.UTF8.GetBytes(s2);
                }
                byte[] bytes = ProtoPacket.pack(new PCS_CliAPLoginAuth2
                {
                    ruri = 2281u,
                    payLoad = ProtoPacket.packNoHeader(uDBYYLoginReq)
                });
                logintcp.Send(bytes);
                lastsendtime = DateTime.Now;
            }
            catch (Exception)
            {
            }
        }

        private void method_6()
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
                byte[] bytes = ProtoPacket.pack(new PCS_CliAPLoginAuth2
                {
                    ruri = 2281u,
                    payLoad = ProtoPacket.packNoHeader(uDBYYLoginReq)
                });
                logintcp.Send(bytes);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        private void method_7(byte[] byte_1)
        {
            try
            {
                if (currentflag <= 40000)
                {
                    using (ByteArray byteArray = new ByteArray(byte_1))
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
                            isfenghao = true;
                            status = 3;
                        }
                        else
                        {
                            string @string = Encoding.UTF8.GetString(uDBYYLoginRes._reason);
                            if (!(@string.ToLower() == "success"))
                            {
                                if (@string.ToLower() == "user frozen")
                                {
                                    throw new Exception("UF");
                                }
                                if (!(@string.ToLower() == "static_verify") && !(@string.ToLower() == "invalid piccode"))
                                {
                                    if (!@string.Contains("invalid user"))
                                    {
                                        throw new Exception(@string);
                                    }
                                    OnConnected(false);
                                    mytrace = "MMCW";
                                    status = 33;
                                    isfenghao = true;
                                    joinstatus = 0;
                                }
                                else
                                {
                                    mytrace = "YZM";
                                    method_5(true, uDBYYLoginRes._pic_id, uDBYYLoginRes._pic_data);
                                }
                                goto IL_027a;
                            }
                            using (ByteArray byteArray2 = new ByteArray(uDBYYLoginRes._login_data))
                            {
                                loginData.unmarshall(byteArray2);
                                byteArray2.Dispose();
                            }
                            username = Encoding.UTF8.GetString(loginData._passport);
                            yycookie = loginData._yycookie;
                            uid = uDBYYLoginRes._yyuid.low;
                            string cookie = Hex.fromArray(new ByteArray(yycookie));
                            if (logintype == 1)
                            {
                                savepcbuser savepcbuser = new savepcbuser();
                                savepcbuser.username = username;
                                savepcbuser.cookie = cookie;
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
                            if (logintype != 1 || isudblogin || pt == ProxyTypes.None)
                            {
                                method_8();
                                goto IL_027a;
                            }
                            isudblogin = true;
                            OnConnected(false);
                            joinstatus = -1;
                        }
                        goto end_IL_0017;
                    IL_027a:
                        byteArray.Dispose();
                    end_IL_0017:;
                    }
                }
            }
            catch (Exception ex)
            {
                mytrace = ex.Message;
            }
        }

        private void method_8()
        {
            try
            {
                currentflag = rdomhelper.getrandom(40001, 41000);
                byte[] bytes = (logintype != 1) ? ProtoPacket.pack(new PCS_APLogin
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
                    m_strFrom = bytetool.String2Bytes("8.45.0.1"),
                    m_strCliVer = bytetool.String2Bytes("8.45.0.1")
                });
                logintcp.Send(bytes);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        private void method_9(byte[] byte_1)
        {
            try
            {
                if (currentflag <= 50000)
                {
                    using (ByteArray byteArray = new ByteArray(byte_1))
                    {
                        ProtoPacket protoPacket = ProtoPacket.unpack(byteArray.Buffer);
                        PCS_APLoginRes pCS_APLoginRes = new PCS_APLoginRes();
                        pCS_APLoginRes.unmarshall(protoPacket.getBuffer());
                        byteArray.Dispose();
                        if (pCS_APLoginRes.m_uResCode != 200)
                        {
                            if (logintype == 1)
                            {
                                isudblogin = false;
                            }
                            throw new Exception(pCS_APLoginRes.m_uResCode.ToString());
                        }
                        Send_0BD0_0307();
                    }
                }
            }
            catch (Exception)
            {
                if (logintype == 1)
                {
                    logtool.delusercache_p(passport);
                    isudblogin = false;
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
                byte[] bytes = null;
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
                    bytes = byteArray3.Buffer;
                    byteArray3.Dispose();
                }
                logintcp.Send(bytes);
                lastsendtime = DateTime.Now;
            }
            catch
            {
            }
        }

        private void method_10(byte[] byte_1)
        {
            try
            {
                if (currentflag <= 60000)
                {
                    using (ByteArray byteArray = new ByteArray(byte_1))
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
                        }
                        byteArray.Dispose();
                    }
                    currentflag = rdomhelper.getrandom(60001, 61000);
                    isinqueue = true;
                }
            }
            catch (Exception)
            {
            }
        }

        public void Send_0BD0_02411F(bool bool_7 = false)
        {
            try
            {
                if (bool_7)
                {
                    currentflag = rdomhelper.getrandom(70001, 71000);
                }
                else
                {
                    currentflag = rdomhelper.getrandom(60001, 61000);
                }
                PJoinChannelReq pJoinChannelReq = new PJoinChannelReq();
                pJoinChannelReq.uid = uid;
                pJoinChannelReq.topsid = sid;
                pJoinChannelReq.subSid = subid;
                MYHashMap props = pJoinChannelReq.props;
                props.put(2u.ToString(), bytetool.String2Bytes("0"));
                if (bool_7)
                {
                    MYHashMap props2 = pJoinChannelReq.props;
                    props2.put(3u.ToString(), bytetool.String2Bytes("1"));
                }
                byte[] serverName = bytetool.String2Bytes("channelAuther");
                byte[] bytes = null;
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
                    bytes = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(bytes);
                lastsendtime = DateTime.Now;
                buhaotime = DateTime.Now;
            }
            catch (Exception)
            {
            }
        }

        private void method_11(byte[] byte_1)
        {
            try
            {
                if (status != 2)
                {
                    using (ByteArray byteArray = new ByteArray(byte_1))
                    {
                        if (byte_1[8] != 200)
                        {
                            throw new Exception("ERR");
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
                        uint num3 = byteArray.readByte();
                        switch (num3)
                        {
                            case 7u:
                                mytrace = "M-J";
                                Send_0BD0_02411F(true);
                                break;
                            case 4u:
                                if (sid != num2 && sid != num)
                                {
                                    mytrace = "GOON";
                                }
                                else
                                {
                                    mytrace = "SUC";
                                    currentflag = rdomhelper.getrandom(90001, 91000);
                                    joinchanneltime = DateTime.Now;
                                    lasthearttime = DateTime.Now;
                                    checkinchaneltime = DateTime.Now;
                                    joinstatus = 2;
                                    status = 2;
                                    isinqueue = false;
                                    jointimes++;
                                    if (sidnew == 0)
                                    {
                                        sidnew = num;
                                    }
                                    if (this.subidnew == 0)
                                    {
                                        this.subidnew = subidnew;
                                    }
                                    if (isgongneng)
                                    {
                                        Send_Service_1E73();
                                    }
                                }
                                break;
                            default:
                                throw new Exception("JERR:" + num3);
                            case 12u:
                                OnConnected(false);
                                isfenghao = true;
                                status = 33;
                                mytrace = "频道不存在";
                                break;
                            case 11u:
                                mytrace = "Y-J";
                                currentflag = rdomhelper.getrandom(98001, 99000);
                                joinchanneltime = DateTime.Now;
                                lasthearttime = DateTime.Now;
                                checkinchaneltime = DateTime.Now;
                                joinstatus = 1;
                                status = 1;
                                if (sidnew == 0)
                                {
                                    sidnew = num;
                                }
                                if (this.subidnew == 0)
                                {
                                    this.subidnew = subidnew;
                                }
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

        public void Send_041E()
        {
            try
            {
                lasthearttime = DateTime.Now;
                byte[] bytes = ProtoPacket.pack(new PCS_APPing());
                logintcp.Send(bytes);
                lastsendhearttime = DateTime.Now;
            }
            catch
            {
            }
        }

        private void method_12(byte[] byte_1)
        {
            try
            {
                heartbeat++;
                lasthearttime = DateTime.Now;
            }
            catch
            {
            }
        }

        public void Send_Service_1E73()
        {
            try
            {
                startloginservicetime = DateTime.Now;
                PCS_GetAPInfo gparam_ = new PCS_GetAPInfo
                {
                    m_uAppId = 260u,
                    m_uUid =
                    {
                        low = Convert.ToUInt32(uid)
                    }
                };
                byte[] serverName = bytetool.String2Bytes("aplbs_webyy");
                byte[] bytes = null;
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
                    bytes = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(bytes);
            }
            catch
            {
            }
        }

        public void Recv_Service_1E74(byte[] byte_1)
        {
            try
            {
                byte[] bytes = byte_1.Skip(38).Take(byte_1[36]).ToArray();
                using (ByteArray byteArray = new ByteArray(byte_1.Skip(36 + byte_1[36] + 10).Take(5).ToArray()))
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
                byte[] bytes = null;
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
                    bytes = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(bytes);
            }
            catch
            {
            }
        }

        private void method_13(byte[] byte_1)
        {
            try
            {
                using (ByteArray byteArray = new ByteArray(byte_1))
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
                byte[] bytes = null;
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
                    bytes = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(bytes);
            }
            catch
            {
            }
        }

        private void method_14(byte[] byte_1)
        {
            try
            {
                using (ByteArray byteArray = new ByteArray(byte_1))
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

        public void GetUserList(uint uint_6, uint uint_7 = 0u)
        {
            try
            {
                GClass3 gparam_ = new GClass3
                {
                    topSid = sidnew,
                    subSid = subidnew,
                    pos = uint_7,
                    num = uint_6
                };
                byte[] serverName = bytetool.String2Bytes("channelUserInfo");
                byte[] bytes = null;
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
                    bytes = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(bytes);
            }
            catch
            {
            }
        }

        private void method_15(byte[] byte_1)
        {
            try
            {
                using (ByteArray byteArray = new ByteArray(byte_1))
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
                    list.Add(uid);
                }
            }
            catch
            {
            }
        }

        public byte[] GetUserInfo()
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
                byte[] result = null;
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
                    result = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                return result;
            }
            catch
            {
                return null;
            }
        }

        private void method_16(byte[] byte_1)
        {
            try
            {
                using (ByteArray byteArray = new ByteArray(byte_1))
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
                new List<uint>().Add(uid);
                PLeaveChannelReq gparam_ = new PLeaveChannelReq
                {
                    topsid = sidnew,
                    uid = uid
                };
                byte[] serverName = bytetool.String2Bytes("channelAuther");
                byte[] bytes = null;
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
                    bytes = ProtoPacket.pack(pAPRouter);
                    byteArray.Dispose();
                }
                logintcp.Send(bytes);
            }
            catch
            {
            }
        }

        public void connect_s()
        {
        }

        public void OnConnected_s(bool bool_7, bool bool_8 = false)
        {
            if (bool_7)
            {
                Send_0411_s();
            }
            else if (status == 2)
            {
                Send_Service_1E73();
            }
        }

        private void method_17(byte[] byte_1)
        {
            try
            {
                if (byte_1[8] == 200 && byte_1[9] == 0)
                {
                    byteArray_1 = null;
                    byteArray_1 = new ByteArray();
                    using (ByteArray byteArray = new ByteArray(byte_1))
                    {
                        int_12 = byteArray.ReadInt();
                    }
                    byteArray_1.writeBytes(byte_1);
                }
                else if (byteArray_1 != null && byteArray_1.length > 0 && byteArray_1.length < int_12)
                {
                    byteArray_1.writeBytes(byte_1);
                }
                if (byteArray_1 != null && byteArray_1.length >= int_12)
                {
                    int_12 = 0;
                    method_18(byteArray_1.Buffer);
                }
            }
            catch
            {
                byteArray_1 = null;
                int_12 = 0;
            }
        }

        private void method_18(byte[] byte_1)
        {
            try
            {
                if (byte_1 != null && byte_1.Length >= 10 && byte_1[8] == 200)
                {
                    string text = bytetool.fromArray(byte_1);
                    string text2 = "";
                    try
                    {
                        text2 = text.Substring(8, 4).ToUpper();
                    }
                    catch
                    {
                    }
                    if (!string.IsNullOrWhiteSpace(text2) && !(text2 == "1E74") && text2 == "0BD0")
                    {
                        try
                        {
                            text.Substring(24, 4).ToUpper();
                            text.Substring(24, 6).ToUpper();
                        }
                        catch
                        {
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
                byte[] bytes = ProtoPacket.pack(new PExchangeKey(publicKey, exponent));
                servicetcp.Send(bytes);
            }
            catch
            {
            }
        }

        public void Recv_0412_s(byte[] byte_1)
        {
            try
            {
                byte[] array = null;
                using (ByteArray byteArray = new ByteArray(byte_1))
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
                method_19();
            }
            catch
            {
            }
        }

        private void method_19()
        {
            try
            {
                byte[] bytes;
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
                    bytes = ProtoPacket.pack(pCS_APLogin);
                }
                else
                {
                    bytes = ProtoPacket.pack(new PCS_APLogin
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
                servicetcp.Send(bytes);
            }
            catch
            {
            }
        }

        public void Recv_04D7_s(byte[] byte_1)
        {
            using (ByteArray byteArray = new ByteArray(byte_1))
            {
                ProtoPacket protoPacket = ProtoPacket.unpack(byteArray.Buffer);
                PCS_APLoginRes pCS_APLoginRes = new PCS_APLoginRes();
                pCS_APLoginRes.unmarshall(protoPacket.getBuffer());
                byteArray.Dispose();
                if (pCS_APLoginRes.m_uResCode != 200)
                {
                    isudblogin = false;
                    OnConnected_s(false);
                }
                else
                {
                    lastservicehearttime = DateTime.Now;
                    isloginservice = true;
                    if (isqutubiao)
                    {
                        method_20();
                    }
                    if (isxianche)
                    {
                        method_21();
                    }
                }
            }
        }

        private void method_20()
        {
            try
            {
                byte[] bytes = null;
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
                    byteArray.writeBytes(Encoding.Default.GetBytes("4000"));
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
                    bytes = byteArray.Buffer;
                    byteArray.Dispose();
                }
                servicetcp.Send(bytes);
            }
            catch
            {
            }
        }

        private void method_21()
        {
            try
            {
                byte[] bytes = null;
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
                    bytes = byteArray.Buffer;
                    byteArray.Dispose();
                }
                servicetcp.Send(bytes);
            }
            catch
            {
            }
        }
    }
}
