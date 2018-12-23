using Newtonsoft.Json;
using Org.Mentalis.Network.ProxySocket;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ZHANHUO.Common;
using ZHANHUO.Model;
using ZHANHUO.Model.YYModel;

namespace 战火协议
{
    public class MainForm : Form
    {
        private Random random_0;

        private string string_0 = "";

        private bool bool_0;

        private DateTime dateTime_0 = DateTime.MinValue;

        private int int_0 = -1;

        private string string_1 = Guid.NewGuid().ToString();

        private int int_1 = 500;

        private uint rQaQnYbAnm;

        private uint uint_0;

        private ConcurrentBag<MyUser1225> concurrentBag_0;

        private ConcurrentBag<myip> concurrentBag_1;

        private List<string> list_0;

        private List<string> list_1;

        private int int_2 = 5000;

        private List<string> list_2;

        private int int_3;

        private int int_4;

        private int int_5;

        private List<string> list_3;

        private DateTime dateTime_1 = DateTime.MinValue;

        private DateTime dateTime_2 = DateTime.MinValue;

        private System.Timers.Timer timer_0;

        private System.Timers.Timer timer_1;

        private System.Timers.Timer timer_2;

        private System.Timers.Timer timer_3;

        private System.Timers.Timer timer_4;

        private System.Timers.Timer timer_5;

        private System.Timers.Timer timer_6;

        private System.Timers.Timer timer_7;

        private System.Timers.Timer timer_8;

        private System.Timers.Timer timer_9;

        private System.Timers.Timer timer_10;

        private System.Timers.Timer timer_11;

        private System.Timers.Timer timer_12;

        private static int int_6;

        private static int int_7;

        private static int int_8;

        private static int int_9;

        private static int int_10;

        private static int int_11;

        private static int int_12;

        private bool bool_1;

        private static int int_13;

        private static int int_14;

        private static int int_15;

        private volatile int int_16;

        private bool bool_2;

        private List<uint> list_4 = new List<uint>();

        private List<uint> list_5 = new List<uint>();

        private yongjiobj yongjiobj_0 = new yongjiobj();

        private bool bool_3 = true;

        private IContainer icontainer_0;

        private Panel panel1;

        private GroupBox groupBox1;

        private RadioButton rdbweb;

        private RadioButton rdbpc;

        private GroupBox groupBox2;

        private CheckBox ckbhulian;

        private Label lblhulian;

        private GroupBox groupBox3;

        private Label label1;

        private TextBox txtfeng;

        private TextBox txtsudu;

        private Label label5;

        private Label label4;

        private TextBox txtjin;

        private TextBox sfnEqZowcK;

        private Label label6;

        private Label label3;

        private TextBox txtzong;

        private TextBox txtsid;

        private Label label7;

        private Label label2;

        private GroupBox groupBox4;

        private CheckBox checkBox_0;

        private CheckBox checkBox_1;

        private CheckBox ckbhttpurl;

        private GroupBox groupBox5;

        private CheckBox ckbxianche;

        private CheckBox ckbqutubiao;

        private CheckBox ckbgongneng;

        private TextBox txthanhuajiange;

        private Label label8;

        private Button btndaoruhanhua;

        private CheckBox ckbhanhua;

        private GroupBox groupBox6;

        private Button btnsuijixingbie;

        private Button btndaoruqianming;

        private Button btndaorumajia;

        private Button btnqiehuan;

        private Button btntuichu;

        private Button btnjoin;

        private Button btndaochu;

        private Button btndaoru;

        private GroupBox groupBox7;

        private CheckBox ckbdsxh;

        private CheckBox ckbdssh;

        private GroupBox groupBox8;

        private TextBox txtshanghao;

        private GroupBox groupBox9;

        private TextBox txtxiahao;

        private GroupBox groupBox_0;

        private Panel panel2;

        private Label lblpath;

        private OpenFileDialog openFileDialog_0;

        private SaveFileDialog saveFileDialog_0;

        private DataGridView mygrid;

        private GroupBox groupBox_1;

        private CheckBox ckbhttplocal;

        private Label lblshijizaixian;

        private Label lbllastbuhao;

        private CheckBox ckbduoip;

        private Label lblauthtime;

        private Label label12;

        private Label label13;

        private Label label14;

        private NumericUpDown xhfen;

        private NumericUpDown xhshi;

        private NumericUpDown xhtian;

        private Label label11;

        private Label label10;

        private Label label9;

        private NumericUpDown shfen;

        private NumericUpDown shshi;

        private NumericUpDown shtian;

        private Button btnchonglian;

        private Button btnresetsudu;

        private Button btntingzhixiugai;

        private CheckBox ckbhunhe;

        private Label lblver;

        private GroupBox groupBox_2;

        private TextBox txtzuishaoshuliang;

        private CheckBox ckbzhinenghuanhao;
        private Button btn_tingzhishuahua;
        private Button btn_songhua;
        private Label lbuid;
        private DataGridViewTextBoxColumn 序号;
        private DataGridViewTextBoxColumn 用户名;
        private DataGridViewTextBoxColumn 当前频道;
        private DataGridViewTextBoxColumn CF;
        private DataGridViewTextBoxColumn 验证码;
        private DataGridViewTextBoxColumn CKI;
        private DataGridViewTextBoxColumn Trace;
        private DataGridViewTextBoxColumn 马甲;
        private DataGridViewTextBoxColumn 心跳;
        private DataGridViewTextBoxColumn 状态;
        private DataGridViewTextBoxColumn 连接IP;
        private Button tzdaka;
        private Button daka;
        private Button tingzhizhibotongzhi;
        private Button zhibotongzhi;
        private Label label18;
        private TextBox beishuanicheng;
        private Label label17;
        private TextBox shuahuasudu;
        private TextBox txt_shuahuauid;

        private void method_0()
        {
            try
            {
                timer_9.Enabled = true;
                timer_9.Start();
                timer_10.Enabled = true;
                timer_10.Start();
                timer_11.Enabled = true;
                timer_11.Start();
                timer_2.Enabled = true;
                timer_2.Start();
                timer_12.Enabled = true;
                timer_12.Start();
                timer_8.Enabled = true;
                timer_8.Start();
            }
            catch
            {
            }
        }

        private void method_1()
        {
            try
            {
                timer_9.Enabled = false;
                timer_9.Stop();
                timer_10.Enabled = false;
                timer_10.Stop();
                timer_11.Enabled = false;
                timer_11.Stop();
                timer_2.Enabled = false;
                timer_2.Stop();
                timer_12.Enabled = false;
                timer_12.Stop();
                timer_8.Enabled = false;
                timer_8.Stop();
            }
            catch
            {
            }
        }

        private void method_2()
        {
            timer_0 = new System.Timers.Timer(3000.0);
            timer_0.Elapsed += timer_0_Elapsed;
            timer_0.AutoReset = true;
            timer_1 = new System.Timers.Timer(3000.0);
            timer_1.Elapsed += timer_1_Elapsed;
            timer_1.AutoReset = true;
            timer_1.Enabled = true;
            timer_1.Start();
            timer_3 = new System.Timers.Timer(30000.0);
            timer_3.Elapsed += timer_3_Elapsed;
            timer_3.AutoReset = true;
            timer_3.Enabled = true;
            timer_3.Start();
            timer_4 = new System.Timers.Timer(60000.0);
            timer_4.Elapsed += timer_4_Elapsed;
            timer_4.AutoReset = true;
            timer_4.Enabled = true;
            timer_4.Start();
            timer_5 = new System.Timers.Timer(60000.0);
            timer_5.Elapsed += timer_5_Elapsed;
            timer_5.AutoReset = true;
            timer_5.Enabled = true;
            timer_5.Start();
            timer_6 = new System.Timers.Timer(60000.0);
            timer_6.Elapsed += timer_6_Elapsed;
            timer_6.AutoReset = true;
            timer_6.Enabled = true;
            timer_6.Start();
            timer_9 = new System.Timers.Timer(1000.0);
            timer_9.Elapsed += timer_9_Elapsed;
            timer_9.AutoReset = true;
            timer_10 = new System.Timers.Timer(1000.0);
            timer_10.Elapsed += timer_10_Elapsed;
            timer_10.AutoReset = true;
            timer_11 = new System.Timers.Timer(3000.0);
            timer_11.Elapsed += timer_11_Elapsed;
            timer_11.AutoReset = true;
            timer_2 = new System.Timers.Timer(1000.0);
            timer_2.Elapsed += timer_2_Elapsed;
            timer_2.AutoReset = true;
            timer_12 = new System.Timers.Timer(4000.0);
            timer_12.Elapsed += timer_12_Elapsed;
            timer_12.AutoReset = true;
            timer_8 = new System.Timers.Timer(90000.0);
            timer_8.Elapsed += timer_8_Elapsed;
            timer_8.AutoReset = true;
        }

        private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Interlocked.Exchange(ref int_6, 1) == 0)
            {
                try
                {
                    mygrid.BeginInvoke(new MethodInvoker(method_17));
                    if (concurrentBag_0 != null && concurrentBag_0.Count > 0)
                    {
                        int_3 = concurrentBag_0.Count;
                        int_4 = concurrentBag_0.Count(delegate (MyUser1225 p)
                        {
                            if (p.status == 2 && !p.isfenghao)
                            {
                                return !p.isskip;
                            }
                            return false;
                        });
                        int_5 = concurrentBag_0.Count((MyUser1225 p) => p.isfenghao);
                        txtzong.BeginInvoke(new MethodInvoker(method_18));
                        txtjin.BeginInvoke(new MethodInvoker(method_19));
                        txtfeng.BeginInvoke(new MethodInvoker(method_20));
                        BeginInvoke(new MethodInvoker(method_21));
                    }
                }
                catch
                {
                }
                finally
                {
                    Interlocked.Exchange(ref int_6, 0);
                }
            }
        }

        private void timer_1_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Interlocked.Exchange(ref int_7, 1) == 0)
            {
                try
                {
                    string path = Application.StartupPath + "\\Help\\pips.txt";
                    if (rdbweb.Checked)
                    {
                        path = Application.StartupPath + "\\Help\\wips.txt";
                    }
                    if (File.Exists(path))
                    {
                        string[] array = File.ReadAllLines(path);
                        ConcurrentBag<myip> concurrentBag = new ConcurrentBag<myip>();
                        string[] array2 = array;
                        foreach (string text in array2)
                        {
                            if (!string.IsNullOrWhiteSpace(text))
                            {
                                myip _myip = new myip();
                                try
                                {
                                    string[] array3 = text.Split('|');
                                    int[] array4 = new int[2];
                                    _myip.ip = array3[0];
                                    array4[0] = Convert.ToInt32(array3[1].Split(',')[0]);
                                    array4[1] = Convert.ToInt32(array3[1].Split(',')[1]);
                                    _myip.ports = array4;
                                    concurrentBag.Add(_myip);
                                }
                                catch
                                {
                                }
                            }
                        }
                        if (concurrentBag.Count > 0)
                        {
                            concurrentBag_1 = concurrentBag;
                            timer_1.Interval = 15000.0;
                        }
                    }
                }
                catch
                {
                }
                finally
                {
                    Interlocked.Exchange(ref int_7, 0);
                }
            }
        }

        private void timer_3_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Interlocked.Exchange(ref int_8, 1) == 0)
            {
                try
                {
                    if (ckbhulian.Checked)
                    {
                        int num = method_4();
                        string strHl = "";
                        switch (num)
                        {
                            case 1:
                                strHl = "上号";
                                break;
                            case 2:
                                strHl = "下号";
                                break;
                            case 0:
                                strHl = "监控中...";
                                break;
                        }
                        if (num != 0)
                        {
                            lblhulian.BeginInvoke((MethodInvoker)delegate
                            {
                                try
                                {
                                    lblhulian.Text = strHl;
                                }
                                catch
                                {
                                }
                            });
                            if (num == 1 && btnjoin.Enabled)
                            {
                                btnjoin_Click(sender, e);
                            }
                            else if (num == 2 && btntuichu.Enabled)
                            {
                                btntuichu_Click(sender, e);
                            }
                        }
                    }
                }
                catch
                {
                }
                finally
                {
                    Interlocked.Exchange(ref int_8, 0);
                }
            }
        }

        private void timer_4_Elapsed(object sender, ElapsedEventArgs e)
        {
            //IL_0028: Incompatible stack heights: 0 vs 1
            //IL_00ab: Incompatible stack heights: 0 vs 1
            //IL_00cc: Incompatible stack heights: 0 vs 1
            if (Interlocked.Exchange(ref int_9, 1) == 0)
            {
                try
                {
                    this.int_0--;
                    if (this.int_0 <= 0)
                    {
                        base.Close();
                        Application.ExitThread();
                    }
                    this.dateTime_0 = DateTime.Now;
                    this.int_0 = 99999999;
                    if (this.int_0 <= 0)
                    {
                        base.Close();
                        Application.ExitThread();
                    }
                    //this.lbldaoqi.BeginInvoke(new MethodInvoker(this.method_22));
                    this.lblauthtime.BeginInvoke(new MethodInvoker(this.method_23));
                }
                catch
                {
                }
                finally
                {
                    Interlocked.Exchange(ref MainForm.int_9, 0);
                }
            }
        }

        private void timer_9_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Interlocked.Exchange(ref int_10, 1) == 0)
            {
                try
                {
                    if (!bool_0)
                    {
                        IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                        {
                            if (p.loginstatus == 0)
                            {
                                return !p.isfenghao;
                            }
                            return false;
                        });
                        if (enumerable != null && enumerable.Count() > 0)
                        {
                            foreach (MyUser1225 item in enumerable.Reverse())
                            {
                                try
                                {
                                    if (bool_0)
                                    {
                                        return;
                                    }
                                    item.logintype = (rdbpc.Checked ? 1 : 2);
                                    item.status = 1;
                                    item.loginstatus = 1;
                                    item.startlogintime = DateTime.Now;
                                    item.sid = rQaQnYbAnm;
                                    item.subid = uint_0;
                                    item.isgongneng = ckbgongneng.Checked;
                                    item.isqutubiao = ckbqutubiao.Checked;
                                    item.isxianche = ckbxianche.Checked;
                                    Task.Factory.StartNew(delegate
                                    {
                                        ldfekfAwP(item);
                                    });
                                }
                                catch
                                {
                                }
                                Thread.Sleep(int_1);
                            }
                        }
                    }
                }
                catch
                {
                }
                finally
                {
                    Interlocked.Exchange(ref int_10, 0);
                }
            }
        }

        private void timer_10_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Interlocked.Exchange(ref int_11, 1) == 0)
            {
                try
                {
                    if (!bool_0)
                    {
                        IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                        {
                            if (p.loginstatus == -1)
                            {
                                return !p.isfenghao;
                            }
                            return false;
                        });
                        if (enumerable != null && enumerable.Count() > 0)
                        {
                            foreach (MyUser1225 item in enumerable)
                            {
                                try
                                {
                                    if (bool_0)
                                    {
                                        return;
                                    }
                                    item.status = 1;
                                    item.loginstatus = 1;
                                    item.startlogintime = DateTime.Now;
                                    Task.Factory.StartNew(delegate
                                    {
                                        ldfekfAwP(item);
                                    });
                                }
                                catch
                                {
                                }
                                Thread.Sleep(int_1);
                            }
                        }
                    }
                }
                catch
                {
                }
                finally
                {
                    Interlocked.Exchange(ref int_11, 0);
                }
            }
        }

        private void timer_11_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Interlocked.Exchange(ref int_12, 1) == 0)
            {
                try
                {
                    if (!bool_0)
                    {
                        IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                        {
                            if (p.loginstatus == 1 && p.startlogintime != DateTime.MinValue && p.startlogintime.AddMinutes(1.0) < DateTime.Now)
                            {
                                return !p.isfenghao;
                            }
                            return false;
                        });
                        if (enumerable != null && enumerable.Count() > 0)
                        {
                            foreach (MyUser1225 item in enumerable)
                            {
                                if (bool_0)
                                {
                                    break;
                                }
                                try
                                {
                                    if (item.loginstatus == 1)
                                    {
                                        item.loginstatus = ((random_0.NextDouble() > 0.5) ? (-1) : 0);
                                    }
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                }
                catch
                {
                }
                finally
                {
                    Interlocked.Exchange(ref int_12, 0);
                }
            }
        }

        private void ldfekfAwP(MyUser1225 myUser1225_0)
        {
            try
            {
                if (rdbpc.Checked)
                {
                    myUser1225_0.loginstatus = 2;
                }
                else
                {
                    dynamic val = method_3(myUser1225_0);
                    if (val == null)
                    {
                        string text = "";
                        if (!ckbhttpurl.Checked && !ckbhttplocal.Checked)
                        {
                            myUser1225_0.daili = "";
                        }
                        else
                        {
                            if (list_0.Count > 0)
                            {
                                text = list_0[random_0.Next(0, list_0.Count)];
                            }
                            myUser1225_0.daili = text;
                        }
                        loginret _loginret = new loginret();
                        if (new weblogin(myUser1225_0, text).userlogin(_loginret))
                        {
                            string ck_username = _loginret.ck_username;
                            string ck_udb_l = _loginret.ck_udb_l;
                            string uid = _loginret.uid;
                            myUser1225_0.uid = Convert.ToUInt32(uid);
                            myUser1225_0.username = ck_username;
                            myUser1225_0.pwden = ck_udb_l;
                            myUser1225_0.yanzhengma = _loginret.vcode;
                            savewebuser _savewebuser = new savewebuser();
                            _savewebuser.username = ck_username;
                            _savewebuser.pwd = ck_udb_l;
                            _savewebuser.uid = uid;
                            try
                            {
                                string msg = MyEncrypt.AesEncryptor(JsonConvert.SerializeObject(_savewebuser));
                                logtool.logusercache_w(myUser1225_0.passport, msg);
                            }
                            catch
                            {
                            }
                            myUser1225_0.loginstatus = 2;
                        }
                        else if (_loginret.isfenghao)
                        {
                            myUser1225_0.isfenghao = true;
                            myUser1225_0.status = 3;
                        }
                        else
                        {
                            myUser1225_0.loginstatus = -1;
                        }
                    }
                    else
                    {
                        string value = (string)val.uid;
                        string username = (string)val.username;
                        string pwden = (string)val.pwd;
                        myUser1225_0.uid = Convert.ToUInt32(value);
                        myUser1225_0.username = username;
                        myUser1225_0.pwden = pwden;
                        myUser1225_0.loginstatus = 2;
                    }
                }
            }
            catch
            {
                myUser1225_0.loginstatus = ((random_0.NextDouble() > 0.5) ? (-1) : 0);
            }
        }

        private dynamic method_3(MyUser1225 myUser1225_0)
        {
            try
            {
                string path = Application.StartupPath + "\\WCache\\" + string.Format("{0}.txt", myUser1225_0.passport);
                if (!File.Exists(path))
                {
                    return null;
                }
                return JsonConvert.DeserializeObject<object>(MyEncrypt.AesDecryptor(File.ReadAllText(path)));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public dynamic getpcuser(MyUser1225 uu)
        {
            try
            {
                string path = string.Format(Application.StartupPath + "\\PCache\\{0}.txt", uu.passport);
                if (!File.Exists(path))
                {
                    return null;
                }
                return JsonConvert.DeserializeObject<object>(MyEncrypt.AesDecryptor(File.ReadAllText(path)));
            }
            catch
            {
                return null;
            }
        }

        private void timer_5_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (ckbdssh.Checked && !(dateTime_1 == DateTime.MinValue) && btnjoin.Enabled && DateTime.Now > dateTime_1)
                {
                    btnjoin_Click(sender, e);
                    timer_5.Enabled = false;
                    timer_5.Stop();
                    ckbdssh.BeginInvoke(new MethodInvoker(method_24));
                    dateTime_1 = DateTime.MinValue;
                }
            }
            catch
            {
            }
        }

        private void timer_6_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (ckbdsxh.Checked && !(dateTime_2 == DateTime.MinValue) && btntuichu.Enabled && DateTime.Now > dateTime_2)
                {
                    btntuichu_Click(sender, e);
                    timer_6.Enabled = false;
                    timer_6.Stop();
                    ckbdsxh.BeginInvoke(new MethodInvoker(method_25));
                    dateTime_2 = DateTime.MinValue;
                }
            }
            catch
            {
            }
        }

        private void timer_2_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Interlocked.Exchange(ref int_13, 1) == 0)
            {
                try
                {
                    string path = "";
                    if (ckbhttpurl.Checked || ckbhttplocal.Checked)
                    {
                        if (ckbhttpurl.Checked)
                        {
                            path = Application.StartupPath + "\\Help\\remotehttp.txt";
                            if (File.Exists(path))
                            {
                                if (File.Exists(Application.StartupPath + "\\config_w_pro.txt") && File.ReadAllText(Application.StartupPath + "\\config_w_pro.txt").Contains("123.207.144.61"))
                                {
                                    bool_1 = true;
                                }
                                if (!bool_1)
                                {
                                    string[] array = File.ReadAllLines(path);
                                    List<string> list = new List<string>();
                                    string[] array2 = array;
                                    foreach (string text in array2)
                                    {
                                        if (!string.IsNullOrWhiteSpace(text))
                                        {
                                            list.Add(text);
                                        }
                                    }
                                    if (list.Count > 0)
                                    {
                                        list_0 = list;
                                    }
                                }
                                else
                                {
                                    string[] array3 = MyEncrypt.AesDecryptor(File.ReadAllText(path)).Split(new string[3]
                                    {
                                        Environment.NewLine,
                                        "\r\n",
                                        "\\r\\n"
                                    }, StringSplitOptions.RemoveEmptyEntries);
                                    if (array3 != null && array3.Count() > 0)
                                    {
                                        List<string> list2 = new List<string>();
                                        string[] array2 = array3;
                                        foreach (string text2 in array2)
                                        {
                                            IPAddress address;
                                            if (text2.Split(':').Length > 1 && IPAddress.TryParse(text2.Split(':')[0], out address))
                                            {
                                                list2.Add(text2);
                                            }
                                        }
                                        if (list2.Count > 0)
                                        {
                                            list_0 = list2;
                                        }
                                    }
                                }
                            }
                        }
                        else if (ckbhttplocal.Checked)
                        {
                            path = Application.StartupPath + "\\http.txt";
                            if (File.Exists(path))
                            {
                                string[] array4 = File.ReadAllLines(path);
                                List<string> list3 = new List<string>();
                                string[] array2 = array4;
                                foreach (string text3 in array2)
                                {
                                    if (!string.IsNullOrWhiteSpace(text3))
                                    {
                                        list3.Add(text3);
                                    }
                                }
                                if (list3.Count > 0)
                                {
                                    list_0 = list3;
                                }
                            }
                        }
                    }
                    if (checkBox_1.Checked || checkBox_0.Checked)
                    {
                        if (checkBox_1.Checked)
                        {
                            path = Application.StartupPath + "\\spoof.txt";
                        }
                        else if (checkBox_0.Checked)
                        {
                            path = Application.StartupPath + "\\s5.txt";
                        }
                        if (File.Exists(path))
                        {
                            string text4 = File.ReadAllText(path);
                            if (checkBox_1.Checked)
                            {
                                text4 = MyEncrypt.AesDecryptor(text4);
                            }
                            string[] array5 = text4.Split(new string[3]
                            {
                                Environment.NewLine,
                                "\r\n",
                                "\\r\\n"
                            }, StringSplitOptions.RemoveEmptyEntries);
                            if (array5 != null && array5.Count() > 0)
                            {
                                List<string> list4 = new List<string>();
                                string[] array2 = array5;
                                foreach (string text5 in array2)
                                {
                                    if (!string.IsNullOrWhiteSpace(text5))
                                    {
                                        list4.Add(text5.Replace(":", "|"));
                                    }
                                }
                                if (list4.Count > 0)
                                {
                                    list_1 = list4;
                                }
                            }
                        }
                    }
                    if (list_0.Count > 0 || list_1.Count > 0)
                    {
                        timer_2.Interval = 8000.0;
                    }
                }
                catch
                {
                }
                finally
                {
                    Interlocked.Exchange(ref int_13, 0);
                }
            }
        }

        private void timer_12_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Interlocked.Exchange(ref int_14, 1) == 0)
            {
                try
                {
                    if (!bool_0 && list_2.Count != 0)
                    {
                        IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                        {
                            if (p.status == 2)
                            {
                                return p.isloginservice;
                            }
                            return false;
                        });
                        if (enumerable != null && enumerable.Count() > 0)
                        {
                            foreach (MyUser1225 item in enumerable)
                            {
                                if (bool_0)
                                {
                                    break;
                                }
                                try
                                {
                                    Task.Factory.StartNew(delegate
                                    {
                                        method_16(item);
                                    });
                                }
                                catch
                                {
                                }
                                Thread.Sleep(int_2);
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

        private int method_4()
        {
            try
            {
                uint result;
                if (!uint.TryParse(txtsid.Text.Trim(), out result))
                {
                    result = 0u;
                }
                uint result2;
                if (!uint.TryParse(sfnEqZowcK.Text.Trim(), out result2))
                {
                    result2 = 0u;
                }
                string s = string.Format("{2}-{0}-{1}", result, result2, string_0);
                string text = Convert.ToBase64String(Encoding.Default.GetBytes(s));
                text = text.Replace("+", "").Replace("/", "").Replace("=", "");
                string string_ = "http://119.29.84.129:9096/yy.php?fun=status&sn=" + text;
                return Convert.ToInt32(method_5(string_));
            }
            catch
            {
                return 0;
            }
        }

        private string method_5(string string_2)
        {
            HttpWebRequest httpWebRequest = null;
            try
            {
                httpWebRequest = (HttpWebRequest)WebRequest.Create(string_2);
                httpWebRequest.Method = "GET";
                using (Stream stream = ((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream())
                {
                    using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
            catch (Exception)
            {
                return "";
            }
            finally
            {
                if (httpWebRequest != null)
                {
                    httpWebRequest.Abort();
                    httpWebRequest = null;
                }
            }
        }

        private void timer_8_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Interlocked.Exchange(ref int_15, 1) == 0)
            {
                try
                {
                    if (!bool_0)
                    {
                        IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                        {
                            if (p.status == 2)
                            {
                                return !p.isfenghao;
                            }
                            return false;
                        });
                        if (enumerable != null && enumerable.Count() > 0)
                        {
                            enumerable.ToList()[random_0.Next(0, enumerable.Count())].GetUserCount();
                            int_16++;
                        }
                    }
                }
                catch
                {
                }
                finally
                {
                    Interlocked.Exchange(ref int_15, 0);
                }
            }
        }

        private static bool smethod_0(object object_0, object object_1, object object_2, SslPolicyErrors sslPolicyErrors_0)
        {
            return true;
        }
        protected override void OnLoad(EventArgs e)
        {
            timer_7 = new System.Timers.Timer();
            timer_7.Elapsed += timer_7_Elapsed;
            SetConfig();
            base.OnLoad(e);
        }
        public MainForm(int shengyu, DateTime checktime, bool xc = false)
        {
            try
            {



                if (checktime.AddMinutes(5.0) < DateTime.Now || checktime.AddMinutes(-5.0) > DateTime.Now)
                {
                    Close();
                    Environment.Exit(0);
                }
                if (Process.GetProcessesByName("login").ToList().Count == 0)
                {
                    MessageBox.Show("login 未开启，不能打开软件！", "提示信息");
                    Environment.Exit(0);
                }
                else if (Process.GetProcessesByName("识别").ToList().Count == 0)
                {
                    MessageBox.Show("识别 未开启，不能打开软件！", "提示信息");
                    Environment.Exit(0);
                }
                else
                {
                    ThreadPool.SetMaxThreads(4096, 4000);
                    InitializeComponent();
                    int_0 = shengyu;
                    dateTime_0 = checktime;
                    concurrentBag_0 = new ConcurrentBag<MyUser1225>();
                    concurrentBag_1 = new ConcurrentBag<myip>();
                    list_0 = new List<string>();
                    list_0 = new List<string>();
                    list_1 = new List<string>();
                    random_0 = new Random();
                    list_2 = new List<string>();
                    ServicePointManager.DefaultConnectionLimit = 2147483647;
                    ServicePointManager.ServerCertificateValidationCallback = smethod_0;
                    mygrid.AutoGenerateColumns = false;
                    bool_2 = xc;
                    if (!bool_2)
                    {
                        ckbxianche.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //string text3 = lblpath.Text = (lbldaoqi.Text = "");
                lblhulian.Text = "";
                groupBox8.Hide();
                groupBox9.Hide();
                panel1.Height += 40;
                string_0 = HardwareInfo.GetInfo();
                //	lbldaoqi.Text = string.Format("到期：{0}", timetool.getstr(int_0));
                try
                {
                    lblver.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    if (int_0 > 1440)
                    {
                        //		lbldaoqi.ForeColor = Color.Green;
                    }
                    else
                    {
                        //		lbldaoqi.ForeColor = Color.Red;
                    }
                }
                catch
                {
                }
                method_2();
                try
                {
                    list_3 = new List<string>();
                    List<IPAddress> list = (from ip in Dns.GetHostAddresses(Dns.GetHostName())
                                            where ip.AddressFamily == AddressFamily.InterNetwork
                                            select ip).ToList();
                    if (list != null && list.Count > 0)
                    {
                        foreach (IPAddress item in list)
                        {
                            list_3.Add(item.ToString());
                        }
                    }
                    string path = Application.StartupPath + "\\多IP.txt";
                    if (!File.Exists(path))
                    {
                        path = Application.StartupPath + "\\多ip.txt";
                    }
                    int i;
                    if (File.Exists(path))
                    {
                        try
                        {
                            string[] array = File.ReadAllLines(path);
                            List<string> list2 = new List<string>();
                            string[] array2 = array;
                            for (i = 0; i < array2.Length; i++)
                            {
                                string text4 = array2[i];
                                try
                                {
                                    IPAddress address;
                                    if (IPAddress.TryParse(text4, out address))
                                    {
                                        list2.Add(text4);
                                    }
                                }
                                catch
                                {
                                }
                            }
                            if (list2.Count > 0)
                            {
                                list_3 = list2;
                            }
                        }
                        catch
                        {
                        }
                    }
                    Label label = lbllastbuhao;
                    i = list_3.Count;
                    label.Text = i.ToString();
                }
                catch
                {
                }
                method_6();
            }
            catch
            {
                MessageBox.Show("启动出错！");
                Close();
                Application.Exit();
            }
        }

        private void method_6()
        {
            try
            {
                string path = Application.StartupPath + "\\config.txt";
                if (File.Exists(path))
                {
                    string text = File.ReadAllText(path);
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        string[] array = text.Split('|');
                        if (array.Length > 1)
                        {
                            string a = array[1].Trim();
                            if (a == "1")
                            {
                                ckbhttpurl.Checked = true;
                            }
                            else if (a == "2")
                            {
                                ckbhttplocal.Checked = true;
                            }
                            else if (a == "3")
                            {
                                checkBox_1.Checked = true;
                            }
                            else if (a == "4")
                            {
                                checkBox_0.Checked = true;
                            }
                        }
                        if (array.Length != 0)
                        {
                            string a2 = array[0].Trim();
                            if (a2 == "1")
                            {
                                rdbpc.Checked = true;
                            }
                            else if (a2 == "2")
                            {
                                rdbweb.Checked = true;
                            }
                        }
                        if (array.Length > 2)
                        {
                            if (array[2].Trim() == "1")
                            {
                                ckbgongneng.Checked = true;
                                txt_shuahuauid.Enabled = true;
                                shuahuasudu.Enabled = true;
                                beishuanicheng.Enabled = true;
                                btn_songhua.Enabled = true;
                                btn_tingzhishuahua.Enabled = true;
                                zhibotongzhi.Enabled = true;
                                tingzhizhibotongzhi.Enabled = true;
                                daka.Enabled = true;
                                tzdaka.Enabled = true;
                                if (array.Length > 3)
                                {
                                    if (array[3].Trim() == "1")
                                    {
                                        ckbqutubiao.Checked = true;
                                    }
                                    else
                                    {
                                        ckbqutubiao.Checked = false;
                                    }
                                }
                                if (array.Length > 4)
                                {
                                    if (array[4].Trim() == "1" && ckbxianche.Visible)
                                    {
                                        ckbxianche.Checked = true;
                                    }
                                    else
                                    {
                                        ckbxianche.Checked = false;
                                    }
                                }
                                if (array.Length > 5)
                                {
                                    if (array[5].Trim() == "1")
                                    {
                                        ckbhanhua.Checked = true;
                                    }
                                    else
                                    {
                                        ckbhanhua.Checked = false;
                                    }
                                }
                                if (array.Length > 7)
                                {
                                    txthanhuajiange.Text = array[7].ToString();
                                }
                            }
                            else
                            {
                                ckbgongneng.Checked = false;
                                txt_shuahuauid.Enabled = false;
                                beishuanicheng.Enabled = false;
                                shuahuasudu.Enabled = false;
                                btn_songhua.Enabled = false;
                                btn_tingzhishuahua.Enabled = false;
                                zhibotongzhi.Enabled = false;
                                tingzhizhibotongzhi.Enabled = false;
                                daka.Enabled = false;
                                tzdaka.Enabled = false;
                            }
                        }
                        if (array.Length > 6)
                        {
                            txtsudu.Text = array[6].ToString();
                        }
                        if (array.Length > 8)
                        {
                            if (array[8].Trim() == "1")
                            {
                                ckbhunhe.Checked = true;
                            }
                            else
                            {
                                ckbhunhe.Checked = false;
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void ckbhulian_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox checkBox = (CheckBox)sender;
                if (checkBox.Checked)
                {
                    uint result;
                    if (!uint.TryParse(txtsid.Text.Trim(), out result))
                    {
                        MessageBox.Show("主频道错误");
                        checkBox.Checked = !checkBox.Checked;
                    }
                    else
                    {
                        uint result2;
                        if (!uint.TryParse(sfnEqZowcK.Text.Trim(), out result2))
                        {
                            result2 = 0u;
                        }
                        string s = string.Format("{2}-{0}-{1}", result, result2, string_0);
                        string text = Convert.ToBase64String(Encoding.Default.GetBytes(s));
                        text = text.Replace("+", "").Replace("/", "").Replace("=", "");
                        groupBox8.Show();
                        groupBox9.Show();
                        panel1.Height -= 40;
                        lblhulian.Text = "  监控中..";
                        txtshanghao.Text = "http://119.29.84.129:9096/yy.php?fun=shang&sn=" + text;
                        txtxiahao.Text = "http://119.29.84.129:9096/yy.php?fun=xia&sn=" + text;
                        txtsid.Enabled = false;
                    }
                }
                else if (lblhulian.Text.Length >= 2)
                {
                    groupBox8.Hide();
                    groupBox9.Hide();
                    panel1.Height += 40;
                    lblhulian.Text = "";
                    txtsid.Enabled = true;
                }
            }
            catch
            {
            }
        }

        private void ckbhttpurl_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (((CheckBox)sender).Checked)
                {
                    CheckBox checkBox = checkBox_0;
                    CheckBox checkBox2 = checkBox_1;
                    ckbhttplocal.Checked = false;
                    checkBox2.Checked = false;
                    checkBox.Checked = false;
                }
            }
            catch
            {
            }
        }

        private void checkBox_1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (((CheckBox)sender).Checked)
                {
                    CheckBox checkBox = ckbhttpurl;
                    CheckBox checkBox2 = ckbhttplocal;
                    checkBox_0.Checked = false;
                    checkBox2.Checked = false;
                    checkBox.Checked = false;
                }
            }
            catch
            {
            }
        }

        private void checkBox_0_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (((CheckBox)sender).Checked)
                {
                    CheckBox checkBox = ckbhttpurl;
                    CheckBox checkBox2 = ckbhttplocal;
                    checkBox_1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox.Checked = false;
                }
            }
            catch
            {
            }
        }

        private void ckbgongneng_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox checkBox = (CheckBox)sender;
                CheckBox checkBox2 = ckbqutubiao;
                CheckBox checkBox3 = ckbxianche;
                CheckBox checkBox4 = ckbhanhua;
                Button button = btndaoruhanhua;
                bool flag = txthanhuajiange.Enabled = checkBox.Checked;
                bool flag3 = button.Enabled = flag;
                bool flag5 = checkBox4.Enabled = flag3;
                bool enabled = checkBox3.Enabled = flag5;
                checkBox2.Enabled = enabled;
                txt_shuahuauid.Enabled = true;
                beishuanicheng.Enabled = true;
                shuahuasudu.Enabled = true;
                btn_songhua.Enabled = true;
                btn_tingzhishuahua.Enabled = true;
                zhibotongzhi.Enabled = true;
                tingzhizhibotongzhi.Enabled = true;
                daka.Enabled = true;
                tzdaka.Enabled = true;
                if (!checkBox.Checked)
                {
                    CheckBox checkBox5 = ckbqutubiao;
                    CheckBox checkBox6 = ckbhanhua;
                    flag5 = (ckbxianche.Checked = checkBox.Checked);
                    enabled = (checkBox6.Checked = flag5);
                    checkBox5.Checked = enabled;
                    list_2.Clear();
                    btndaoruhanhua.Text = "导入";
                    txt_shuahuauid.Enabled = false;
                    beishuanicheng.Enabled = false;
                    shuahuasudu.Enabled = false;
                    btn_songhua.Enabled = false;
                    btn_tingzhishuahua.Enabled = false;
                    zhibotongzhi.Enabled = false;
                    tingzhizhibotongzhi.Enabled = false;
                    daka.Enabled = false;
                    tzdaka.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void ckbhanhua_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!ckbhanhua.Checked)
                {
                    list_2.Clear();
                    btndaoruhanhua.Text = "导入";
                }
            }
            catch
            {
            }
        }

        private void method_7(uint uint_1)
        {
            try
            {
                if (uint_1 >= int_4)
                {
                    lblshijizaixian.BeginInvoke((MethodInvoker)delegate
                    {
                        try
                        {
                            lblshijizaixian.Text = uint_1.ToString();
                            lblshijizaixian.ForeColor = Color.Green;
                        }
                        catch
                        {
                        }
                    });
                }
                else
                {
                    lblshijizaixian.BeginInvoke((MethodInvoker)delegate
                    {
                        try
                        {
                            lblshijizaixian.Text = uint_1.ToString();
                            lblshijizaixian.ForeColor = Color.Red;
                        }
                        catch
                        {
                        }
                    });
                }
            }
            catch
            {
            }
        }

        private void method_8(uint uint_1, List<uint> list_6)
        {
            try
            {
                if (list_4.Contains(uint_1))
                {
                    lock (list_4)
                    {
                        list_4.Remove(uint_1);
                    }
                    lock (list_5)
                    {
                        list_5.AddRange(list_6);
                    }
                    if (list_4.Count == 0)
                    {
                        int bc = 0;
                        foreach (MyUser1225 item in concurrentBag_0)
                        {
                            if (item.status == 2 && item.jointime.AddMinutes(8.0) < DateTime.Now && !list_5.Contains(item.uid))
                            {
                                item.ZhuDongDK((rdomhelper.getrandom(0, 100) <= 50) ? (-1) : 0);
                                bc++;
                            }
                        }
                        lbllastbuhao.BeginInvoke((MethodInvoker)delegate
                        {
                            try
                            {
                                lbllastbuhao.Text = DateTime.Now.ToString("HH:mm:ss") + "-" + bc.ToString();
                            }
                            catch
                            {
                            }
                        });
                    }
                }
            }
            catch
            {
            }
        }

        private void method_9()
        {
            try
            {
                yongjiobj_0.isyongji = true;
                yongjiobj_0.ctime = DateTime.Now;
            }
            catch
            {
            }
        }

        private void btndaoru_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog_0.ShowDialog() == DialogResult.OK)
                {
                    lblpath.Text = openFileDialog_0.FileName;
                    concurrentBag_0 = new ConcurrentBag<MyUser1225>();
                    string[] source = File.ReadAllLines(lblpath.Text);
                    int num = 1;
                    foreach (string item in source.Distinct())
                    {
                        try
                        {
                            string passport = item.Split(new string[1]
                            {
                                "----"
                            }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                            string pwd = item.Split(new string[1]
                            {
                                "----"
                            }, StringSplitOptions.RemoveEmptyEntries)[1].Trim();
                            MyUser1225 myUser = new MyUser1225();
                            myUser.passport = passport;
                            myUser.pwd = pwd;
                            myUser.index = num;
                            myUser.GetUserCountEvent += method_7;
                            myUser.YongJiEvent += method_9;
                            concurrentBag_0.Add(myUser);
                            num++;
                        }
                        catch
                        {
                        }
                    }
                    try
                    {
                        mygrid.BeginInvoke(new MethodInvoker(method_26));
                        txtzong.BeginInvoke(new MethodInvoker(method_27));
                        timer_0.Enabled = true;
                        timer_0.Start();
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
                MessageBox.Show("导入失败，请检查文件！");
            }
        }

        private void btndaochu_Click(object sender, EventArgs e)
        {
            try
            {
                if (concurrentBag_0 != null && concurrentBag_0.Count > 0)
                {
                    saveFileDialog_0.FileName = string.Format("{0}.txt", DateTime.Now.ToString("yyyyMMddHHmmss"));
                    if (saveFileDialog_0.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        foreach (MyUser1225 item in concurrentBag_0)
                        {
                            if (!item.isfenghao)
                            {
                                stringBuilder.AppendFormat("{0}----{1}", item.passport, item.pwd);
                                stringBuilder.AppendLine();
                            }
                        }
                        using (StreamWriter streamWriter = new StreamWriter(saveFileDialog_0.FileName, false))
                        {
                            streamWriter.Write(stringBuilder.ToString());
                        }
                        MessageBox.Show("导出成功");
                    }
                }
            }
            catch
            {
            }
        }

        private void method_10()
        {
            try
            {
                string s = string.Format("{0}-{1}", rQaQnYbAnm, uint_0);
                string text = Convert.ToBase64String(Encoding.Default.GetBytes(s));
                text = text.Replace("+", "").Replace("/", "");
                string path = Application.StartupPath + "\\Help\\DSXH\\" + string.Format("{0}.txt", text);
                if (File.Exists(path))
                {
                    DateTime t = Convert.ToDateTime(File.ReadAllText(path).Trim());
                    if (t > DateTime.Now)
                    {
                        ckbdsxh.Checked = true;
                        dateTime_2 = t;
                    }
                    else
                    {
                        File.Delete(path);
                    }
                }
            }
            catch
            {
            }
        }

        private void btnjoin_Click(object sender, EventArgs e)
        {
            try
            {
                if (concurrentBag_0 == null || concurrentBag_0.Count == 0)
                {
                    throw new Exception("未导入用户！");
                }
                if (!uint.TryParse(txtsid.Text.Trim(), out rQaQnYbAnm))
                {
                    throw new Exception("请输入频道号！");
                }
                if (!uint.TryParse(sfnEqZowcK.Text.Trim(), out uint_0))
                {
                    sfnEqZowcK.Text = "0";
                    uint_0 = 0u;
                }
                if (!int.TryParse(txtsudu.Text.Trim(), out int_1))
                {
                    txtsudu.Text = "500";
                    int_1 = 500;
                }
                if (ckbhttplocal.Checked)
                {
                    string path = Application.StartupPath + "\\http.txt";
                    if (!File.Exists(path))
                    {
                        throw new Exception("未找到文件 http.txt！");
                    }
                    string[] array = File.ReadAllLines(path);
                    List<string> list = new List<string>();
                    string[] array2 = array;
                    foreach (string text in array2)
                    {
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            list.Add(text);
                        }
                    }
                    if (list.Count <= 0)
                    {
                        throw new Exception("导入代理http失败！");
                    }
                    list_0 = list;
                    timer_2.Interval = 8000.0;
                }
                if (checkBox_1.Checked)
                {
                    string path2 = Application.StartupPath + "\\spoof.txt";
                    if (!File.Exists(path2))
                    {
                        throw new Exception("未找到文件 spoof.txt！");
                    }
                    string[] array3 = MyEncrypt.AesDecryptor(File.ReadAllText(path2)).Split(new string[3]
                    {
                        Environment.NewLine,
                        "\r\n",
                        "\\r\\n"
                    }, StringSplitOptions.RemoveEmptyEntries);
                    if (array3 == null || array3.Count() <= 0)
                    {
                        throw new Exception("导入spoof失败！");
                    }
                    string[] array2 = array3;
                    foreach (string text2 in array2)
                    {
                        if (!string.IsNullOrWhiteSpace(text2))
                        {
                            list_1.Add(text2);
                        }
                    }
                    timer_2.Interval = 8000.0;
                }
                else if (checkBox_0.Checked)
                {
                    string path3 = Application.StartupPath + "\\s5.txt";
                    if (!File.Exists(path3))
                    {
                        throw new Exception("未找到文件 s5.txt！");
                    }
                    string[] array4 = File.ReadAllText(path3).Split(new string[3]
                    {
                        Environment.NewLine,
                        "\r\n",
                        "\\r\\n"
                    }, StringSplitOptions.RemoveEmptyEntries);
                    if (array4 == null || array4.Count() <= 0)
                    {
                        throw new Exception("导入s5失败！");
                    }
                    string[] array2 = array4;
                    foreach (string text3 in array2)
                    {
                        if (!string.IsNullOrWhiteSpace(text3))
                        {
                            list_1.Add(text3);
                        }
                    }
                    timer_2.Interval = 8000.0;
                }
                if (ckbhanhua.Checked)
                {
                    if (!int.TryParse(txthanhuajiange.Text.Trim(), out int_2))
                    {
                        txthanhuajiange.Text = "5000";
                    }
                    int_2 = Convert.ToInt32(txthanhuajiange.Text);
                }
                method_0();
                method_10();
                if (bool_0)
                {
                    bool_0 = false;
                    RadioButton radioButton = rdbpc;
                    RadioButton radioButton2 = rdbweb;
                    CheckBox checkBox = ckbgongneng;
                    CheckBox checkBox2 = ckbhanhua;
                    CheckBox checkBox3 = ckbxianche;
                    CheckBox checkBox4 = ckbqutubiao;
                    btnjoin.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton.Enabled = false;
                    Button button = btntuichu;
                    Button button2 = btnqiehuan;
                    Button button3 = btnsuijixingbie;
                    Button button4 = btndaorumajia;
                    btndaoruqianming.Enabled = true;
                    button4.Enabled = true;
                    button3.Enabled = true;
                    button2.Enabled = true;
                    button.Enabled = true;
                }
                else
                {
                    if (bool_3)
                    {
                        Task.Factory.StartNew(method_28);
                        Task.Factory.StartNew(method_29);
                        bool_3 = false;
                    }
                    RadioButton radioButton3 = rdbpc;
                    RadioButton radioButton4 = rdbweb;
                    CheckBox checkBox5 = ckbgongneng;
                    CheckBox checkBox6 = ckbhanhua;
                    CheckBox checkBox7 = ckbxianche;
                    CheckBox checkBox8 = ckbqutubiao;
                    btnjoin.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox7.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox5.Enabled = false;
                    radioButton4.Enabled = false;
                    radioButton3.Enabled = false;
                    Button button5 = btntuichu;
                    Button button6 = btnqiehuan;
                    Button button7 = btnsuijixingbie;
                    Button button8 = btndaorumajia;
                    btndaoruqianming.Enabled = true;
                    button8.Enabled = true;
                    button7.Enabled = true;
                    button6.Enabled = true;
                    button5.Enabled = true;
                    method_11();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void method_11()
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder("");
                if (rdbpc.Checked)
                {
                    stringBuilder.Append("1");
                }
                else if (rdbweb.Checked)
                {
                    stringBuilder.Append("2");
                }
                stringBuilder.Append("|");
                if (ckbhttpurl.Checked)
                {
                    stringBuilder.Append("1");
                }
                else if (ckbhttplocal.Checked)
                {
                    stringBuilder.Append("2");
                }
                else if (checkBox_1.Checked)
                {
                    stringBuilder.Append("3");
                }
                else if (checkBox_0.Checked)
                {
                    stringBuilder.Append("4");
                }
                else
                {
                    stringBuilder.Append("0");
                }
                stringBuilder.Append("|");
                if (ckbgongneng.Checked)
                {
                    stringBuilder.Append("1");
                }
                else
                {
                    stringBuilder.Append("0");
                }
                stringBuilder.Append("|");
                if (ckbqutubiao.Checked)
                {
                    stringBuilder.Append("1");
                }
                else
                {
                    stringBuilder.Append("0");
                }
                stringBuilder.Append("|");
                if (ckbxianche.Visible && ckbxianche.Checked)
                {
                    stringBuilder.Append("1");
                }
                else
                {
                    stringBuilder.Append("0");
                }
                stringBuilder.Append("|");
                if (ckbhanhua.Checked)
                {
                    stringBuilder.Append("1");
                }
                else
                {
                    stringBuilder.Append("0");
                }
                stringBuilder.Append("|");
                stringBuilder.Append(int_1.ToString());
                stringBuilder.Append("|");
                stringBuilder.Append(txthanhuajiange.Text.Trim());
                stringBuilder.Append("|");
                if (ckbhunhe.Checked)
                {
                    stringBuilder.Append("1");
                }
                else
                {
                    stringBuilder.Append("0");
                }
                string text = stringBuilder.ToString();
                if (!string.IsNullOrWhiteSpace(text))
                {
                    loghelper.log(Application.StartupPath + "\\config.txt", text);
                }
            }
            catch
            {
            }
        }

        private void btntuichu_Click(object sender, EventArgs e)
        {
            try
            {
                bool_0 = true;
                btnjoin.Enabled = true;
                Button button = btntuichu;
                Button button2 = btnqiehuan;
                Button button3 = btnsuijixingbie;
                Button button4 = btndaorumajia;
                btndaoruqianming.Enabled = false;
                button4.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
                button.Enabled = false;
                Task.Factory.StartNew(method_30);
                method_1();
            }
            catch
            {
            }
        }

        private void btnqiehuan_Click(object sender, EventArgs e)
        {
            try
            {
                if (concurrentBag_0 == null || concurrentBag_0.Count == 0)
                {
                    throw new Exception("未导入用户！");
                }
                uint result;
                if (!uint.TryParse(txtsid.Text.Trim(), out result))
                {
                    throw new Exception("请输入频道号！");
                }
                uint result2;
                if (!uint.TryParse(sfnEqZowcK.Text.Trim(), out result2))
                {
                    sfnEqZowcK.Text = "0";
                    result2 = 0u;
                }
                if (rQaQnYbAnm == result && uint_0 == result2)
                {
                    throw new Exception("频道号未变！");
                }
                rQaQnYbAnm = result;
                uint_0 = result2;
                if (!int.TryParse(txtsudu.Text.Trim(), out int_1))
                {
                    txtsudu.Text = "500";
                    int_1 = 500;
                }
                btnqiehuan.Enabled = false;
                Task.Factory.StartNew(method_31);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsuijixingbie_Click(object sender, EventArgs e)
        {
            btnsuijixingbie.Enabled = false;
            Task.Factory.StartNew(method_33);
        }

        private void btndaorumajia_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog_0.ShowDialog() == DialogResult.OK && openFileDialog_0.FileName.Length > 0)
                {
                    string[] nicks = File.ReadAllLines(openFileDialog_0.FileName);
                    if (nicks.Length == 0)
                    {
                        MessageBox.Show("文件无效");
                    }
                    else
                    {
                        btndaorumajia.Enabled = false;
                        Task.Factory.StartNew(delegate
                        {
                            foreach (MyUser1225 item in concurrentBag_0.Reverse())
                            {
                                item.isupdate = true;
                            }
                            while (true)
                            {
                                IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                                {
                                    if (!p.isfenghao && p.currentflag > 50000)
                                    {
                                        return p.isupdate;
                                    }
                                    return false;
                                });
                                if (enumerable == null || enumerable.Count() == 0)
                                {
                                    break;
                                }
                                foreach (MyUser1225 item2 in enumerable.Reverse())
                                {
                                    try
                                    {
                                        if (item2.xiugaisuiji)
                                        {
                                            item2.nicheng = nicks[random_0.Next(0, nicks.Length)];
                                        }
                                        else
                                        {
                                            item2.nicheng = nicks[item2.index % nicks.Length];
                                        }
                                        method_14(item2);
                                        Thread.Sleep(10);
                                    }
                                    catch
                                    {
                                    }
                                }
                                Thread.Sleep(3000);
                            }
                            btndaorumajia.BeginInvoke(new MethodInvoker(method_35));
                        });
                    }
                }
            }
            catch
            {
            }
        }

        private void btndaoruqianming_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog_0.ShowDialog() == DialogResult.OK && openFileDialog_0.FileName.Length > 0)
                {
                    string[] qms = File.ReadAllLines(openFileDialog_0.FileName);
                    if (qms.Length == 0)
                    {
                        MessageBox.Show("文件无效");
                    }
                    else
                    {
                        btndaoruqianming.Enabled = false;
                        Task.Factory.StartNew(delegate
                        {
                            foreach (MyUser1225 item in concurrentBag_0.Reverse())
                            {
                                item.isupdate = true;
                            }
                            while (true)
                            {
                                IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                                {
                                    if (!p.isfenghao && p.currentflag > 50000)
                                    {
                                        return p.isupdate;
                                    }
                                    return false;
                                });
                                if (enumerable == null || enumerable.Count() == 0)
                                {
                                    break;
                                }
                                foreach (MyUser1225 item2 in enumerable.Reverse())
                                {
                                    try
                                    {
                                        if (item2.xiugaisuiji)
                                        {
                                            item2.qianming = qms[random_0.Next(0, qms.Length)];
                                        }
                                        else
                                        {
                                            item2.qianming = qms[item2.index % qms.Length];
                                        }
                                        method_15(item2);
                                        Thread.Sleep(10);
                                    }
                                    catch
                                    {
                                    }
                                }
                                Thread.Sleep(3000);
                            }
                            btndaoruqianming.BeginInvoke(new MethodInvoker(method_36));
                        });
                    }
                }
            }
            catch
            {
            }
        }

        private void btndaoruhanhua_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog_0.ShowDialog() == DialogResult.OK && openFileDialog_0.FileName.Length > 0)
                {
                    string[] array = File.ReadAllLines(openFileDialog_0.FileName);
                    list_2.Clear();
                    string[] array2 = array;
                    foreach (string text in array2)
                    {
                        if (text.Trim().Length > 0)
                        {
                            list_2.Add(text);
                        }
                    }
                    btndaoruhanhua.BeginInvoke(new MethodInvoker(method_37));
                }
            }
            catch
            {
            }
        }

        private void method_12(MyUser1225 myUser1225_0)
        {
            byte[] buffer = default(byte[]);
            using (ByteArray byteArray = new ByteArray())
            {
                byteArray.endian = Endian.LITTLE_ENDIAN;
                byteArray.method_2(2);
                byteArray.method_2(0);
                byteArray.writeUTF("13");
                byteArray.method_2(1);
                byteArray.writeUTF(myUser1225_0.sidnew.ToString());
                buffer = byteArray.Buffer;
                byteArray.Dispose();
            }
            byte[] buffer2 = default(byte[]);
            using (ByteArray byteArray2 = new ByteArray())
            {
                byteArray2.endian = Endian.LITTLE_ENDIAN;
                byteArray2.writeBytes(bytetool.strToToHexByte("0008"));
                byteArray2.writeShort(buffer.Length);
                byteArray2.writeBytes(buffer);
                buffer2 = byteArray2.Buffer;
                byteArray2.Dispose();
            }
            byte[] buffer3 = default(byte[]);
            using (ByteArray byteArray3 = new ByteArray())
            {
                byteArray3.endian = Endian.LITTLE_ENDIAN;
                byteArray3.writeBytes(bytetool.strToToHexByte("08000001"));
                byteArray3.writeBytes(bytetool.strToToHexByte("02471F001000000203010000"));
                byteArray3.method_3(myUser1225_0.uid);
                byteArray3.method_2(0);
                byteArray3.writeBytes(bytetool.strToToHexByte("1D000006010800000000DCB90001"));
                byteArray3.writeUTF("channelAuther");
                byteArray3.writeBytes(bytetool.strToToHexByte("1200000701000000010000000400"));
                byteArray3.writeUnsignedInt(myUser1225_0.sidnew);
                byteArray3.writeShort(buffer2.Length + 2);
                byteArray3.writeBytes(buffer2);
                byteArray3.writeBytes(bytetool.strToToHexByte("787878FF"));
                buffer3 = byteArray3.Buffer;
                byteArray3.Dispose();
            }
            byte[] buffer4 = default(byte[]);
            using (ByteArray byteArray4 = new ByteArray())
            {
                byteArray4.endian = Endian.LITTLE_ENDIAN;
                byteArray4.position = 4;
                byteArray4.writeBytes(bytetool.strToToHexByte("0BD00700"));
                byteArray4.method_2(200);
                byteArray4.writeBytes(bytetool.strToToHexByte("02471F00"));
                byteArray4.writeShort(200);
                byteArray4.method_2(8);
                byteArray4.writeUnsignedInt(myUser1225_0.uid);
                byteArray4.writeUnsignedInt(myUser1225_0.sidnew);
                byteArray4.method_2(buffer3.Length);
                byteArray4.writeBytes(buffer3);
                byteArray4.position = 0;
                byteArray4.writeUnsignedInt(Convert.ToUInt32(byteArray4.length));
                buffer4 = byteArray4.Buffer;
                byteArray4.Dispose();
            }
            myUser1225_0.logintcp.Send(buffer4, false);
        }

        private void method_13(MyUser1225 myUser1225_0)
        {
            try
            {
                byte[] buffer = default(byte[]);
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.writeShort(5);
                    byteArray.writeUTF((random_0.NextDouble() > 0.5) ? "1" : "0");
                    buffer = byteArray.Buffer;
                    byteArray.Dispose();
                }
                byte[] buffer2 = default(byte[]);
                using (ByteArray byteArray2 = new ByteArray())
                {
                    byteArray2.endian = Endian.LITTLE_ENDIAN;
                    byteArray2.writeUnsignedInt(1u);
                    byteArray2.writeBytes(buffer);
                    buffer2 = byteArray2.Buffer;
                    byteArray2.Dispose();
                }
                byte[] buffer3 = default(byte[]);
                using (ByteArray byteArray3 = new ByteArray())
                {
                    byteArray3.endian = Endian.LITTLE_ENDIAN;
                    byteArray3.position = 4;
                    byteArray3.writeBytes(bytetool.strToToHexByte("0BD00700C800000003020000C800"));
                    byteArray3.writeUnsignedInt((uint)buffer2.Length);
                    byteArray3.writeBytes(buffer2);
                    byteArray3.writeUnsignedInt(98u);
                    byteArray3.writeBytes(bytetool.strToToHexByte("08000001030200001000000203010000"));
                    byteArray3.writeUnsignedInt(myUser1225_0.uid);
                    byteArray3.writeBytes(bytetool.strToToHexByte("00000000150000068CC63500120800000000050055496E666F1200000701000000010000000400000000001F000008190003000000000000000200323701000000010030030000000000787878FF"));
                    byteArray3.position = 0;
                    byteArray3.writeUnsignedInt(Convert.ToUInt32(byteArray3.length));
                    buffer3 = byteArray3.Buffer;
                    byteArray3.Dispose();
                }
                myUser1225_0.logintcp.Send(buffer3, false);
            }
            catch
            {
            }
        }

        private void method_14(MyUser1225 myUser1225_0)
        {
            try
            {
                byte[] buffer = default(byte[]);
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.writeShort(2);
                    byteArray.writeUTF(myUser1225_0.nicheng);
                    buffer = byteArray.Buffer;
                    byteArray.Dispose();
                }
                byte[] buffer2 = default(byte[]);
                using (ByteArray byteArray2 = new ByteArray())
                {
                    byteArray2.endian = Endian.LITTLE_ENDIAN;
                    byteArray2.writeUnsignedInt(1u);
                    byteArray2.writeBytes(buffer);
                    buffer2 = byteArray2.Buffer;
                    byteArray2.Dispose();
                }
                byte[] buffer3 = default(byte[]);
                using (ByteArray byteArray3 = new ByteArray())
                {
                    byteArray3.endian = Endian.LITTLE_ENDIAN;
                    byteArray3.position = 4;
                    byteArray3.writeBytes(bytetool.strToToHexByte("0BD00700C800000003020000C800"));
                    byteArray3.writeUnsignedInt((uint)buffer2.Length);
                    byteArray3.writeBytes(buffer2);
                    byteArray3.writeUnsignedInt(98u);
                    byteArray3.writeBytes(bytetool.strToToHexByte("08000001030200001000000203010000"));
                    byteArray3.writeUnsignedInt(myUser1225_0.uid);
                    byteArray3.writeBytes(bytetool.strToToHexByte("00000000150000068CC63500120800000000050055496E666F1200000701000000010000000400000000001F000008190003000000000000000200323701000000010030030000000000787878FF"));
                    byteArray3.position = 0;
                    byteArray3.writeUnsignedInt(Convert.ToUInt32(byteArray3.length));
                    buffer3 = byteArray3.Buffer;
                    byteArray3.Dispose();
                }
                myUser1225_0.logintcp.Send(buffer3, false);
            }
            catch
            {
            }
        }

        private void ckbhttplocal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (((CheckBox)sender).Checked)
                {
                    CheckBox checkBox = checkBox_0;
                    CheckBox checkBox2 = checkBox_1;
                    ckbhttpurl.Checked = false;
                    checkBox2.Checked = false;
                    checkBox.Checked = false;
                }
            }
            catch
            {
            }
        }

        private void rdbpc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (((RadioButton)sender).Checked)
                {
                    CheckBox checkBox = ckbhttpurl;
                    ckbhttplocal.Checked = false;
                    checkBox.Checked = false;
                    CheckBox checkBox2 = ckbhttpurl;
                    ckbhttplocal.Enabled = true;
                    checkBox2.Enabled = true;
                    CheckBox checkBox3 = checkBox_1;
                    checkBox_0.Checked = false;
                    checkBox3.Checked = false;
                    CheckBox checkBox4 = checkBox_1;
                    checkBox_0.Enabled = true;
                    checkBox4.Enabled = true;
                }
            }
            catch
            {
            }
        }

        private void rdbweb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (((RadioButton)sender).Checked)
                {
                    CheckBox checkBox = checkBox_1;
                    checkBox_0.Checked = false;
                    checkBox.Checked = false;
                    CheckBox checkBox2 = checkBox_1;
                    checkBox_0.Enabled = false;
                    checkBox2.Enabled = false;
                    CheckBox checkBox3 = ckbhttpurl;
                    ckbhttplocal.Enabled = true;
                    checkBox3.Enabled = true;
                }
            }
            catch
            {
            }
        }

        private void ckbdsxh_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ckbhulian_Click(object sender, EventArgs e)
        {
        }

        private void ckbdssh_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (((CheckBox)sender).Checked)
                {
                    DateTime dateTime = DateTime.Now;
                    dateTime = dateTime.AddDays((double)(int)shtian.Value);
                    dateTime = dateTime.AddHours((double)(int)shshi.Value);
                    dateTime_1 = dateTime.AddMinutes((double)(int)shfen.Value);
                }
                else
                {
                    dateTime_1 = DateTime.MinValue;
                    NumericUpDown numericUpDown = shtian;
                    NumericUpDown numericUpDown2 = shshi;
                    decimal num2 = shfen.Value = default(decimal);
                    decimal num5 = numericUpDown.Value = (numericUpDown2.Value = num2);
                }
            }
            catch
            {
            }
        }

        private void ckbdsxh_Click(object sender, EventArgs e)
        {
            try
            {
                uint result;
                if (!uint.TryParse(txtsid.Text.Trim(), out result))
                {
                    result = 0u;
                }
                uint result2;
                if (!uint.TryParse(sfnEqZowcK.Text.Trim(), out result2))
                {
                    result2 = 0u;
                }
                CheckBox obj = (CheckBox)sender;
                string s = string.Format("{0}-{1}", result, result2);
                string text = Convert.ToBase64String(Encoding.Default.GetBytes(s));
                text = text.Replace("+", "").Replace("/", "");
                string path = Application.StartupPath + "\\Help\\DSXH\\" + string.Format("{0}.txt", text);
                if (obj.Checked)
                {
                    DateTime dateTime = DateTime.Now;
                    dateTime = dateTime.AddDays((double)(int)xhtian.Value);
                    dateTime = dateTime.AddHours((double)(int)xhshi.Value);
                    dateTime_2 = dateTime.AddMinutes((double)(int)xhfen.Value);
                    using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(fileStream))
                        {
                            streamWriter.Write(dateTime_2.ToString("yyyy-MM-dd HH:mm"));
                            streamWriter.Flush();
                            streamWriter.Close();
                            streamWriter.Dispose();
                        }
                        fileStream.Close();
                        fileStream.Dispose();
                    }
                }
                else
                {
                    dateTime_2 = DateTime.MinValue;
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
            }
            catch
            {
            }
        }

        private void btnchonglian_Click(object sender, EventArgs e)
        {
            btnchonglian.Enabled = false;
            Task.Factory.StartNew(bMoQvhfFik);
        }

        private void btnresetsudu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtsudu.Text.Trim(), out int_1))
                {
                    txtsudu.Text = "500";
                    int_1 = 500;
                }
            }
            catch
            {
            }
        }

        private void btntingzhixiugai_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(method_39);
            }
            catch
            {
            }
        }

        private void method_15(MyUser1225 myUser1225_0)
        {
            try
            {
                byte[] buffer = default(byte[]);
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.writeShort(54);
                    byteArray.writeUTF(myUser1225_0.qianming);
                    buffer = byteArray.Buffer;
                    byteArray.Dispose();
                }
                byte[] buffer2 = default(byte[]);
                using (ByteArray byteArray2 = new ByteArray())
                {
                    byteArray2.endian = Endian.LITTLE_ENDIAN;
                    byteArray2.writeUnsignedInt(1u);
                    byteArray2.writeBytes(buffer);
                    buffer2 = byteArray2.Buffer;
                    byteArray2.Dispose();
                }
                byte[] buffer3 = default(byte[]);
                using (ByteArray byteArray3 = new ByteArray())
                {
                    byteArray3.endian = Endian.LITTLE_ENDIAN;
                    byteArray3.position = 4;
                    byteArray3.writeBytes(bytetool.strToToHexByte("0BD00700C800000003020000C800"));
                    byteArray3.writeUnsignedInt((uint)buffer2.Length);
                    byteArray3.writeBytes(buffer2);
                    byteArray3.writeUnsignedInt(98u);
                    byteArray3.writeBytes(bytetool.strToToHexByte("08000001030200001000000203010000"));
                    byteArray3.writeUnsignedInt(myUser1225_0.uid);
                    byteArray3.writeBytes(bytetool.strToToHexByte("00000000150000068CC63500120800000000050055496E666F1200000701000000010000000400000000001F000008190003000000000000000200323701000000010030030000000000787878FF"));
                    byteArray3.position = 0;
                    byteArray3.writeUnsignedInt(Convert.ToUInt32(byteArray3.length));
                    buffer3 = byteArray3.Buffer;
                    byteArray3.Dispose();
                }
                myUser1225_0.logintcp.Send(buffer3, false);
            }
            catch
            {
            }
        }

        private void method_16(MyUser1225 myUser1225_0)
        {
            try
            {
                string s = list_2[random_0.Next(0, list_2.Count)] + "  ";
                List<byte> list = Encoding.Unicode.GetBytes(s).ToList();
                List<byte> second = BitConverter.GetBytes(myUser1225_0.sidnew).ToList();
                List<byte> second2 = BitConverter.GetBytes(myUser1225_0.subidnew).ToList();
                List<byte> second3 = Encoding.Default.GetBytes("5060").ToList();
                List<byte> second4 = BitConverter.GetBytes(myUser1225_0.uid).ToList();
                List<byte> list2 = Encoding.UTF8.GetBytes(myUser1225_0.nicheng).ToList();
                List<byte> first = new byte[14]
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
                    0,
                    0
                }.ToList();
                List<byte> list3 = new byte[6]
                {
                    132,
                    0,
                    0,
                    0,
                    31,
                    0
                }.Concat(second).Concat(second4).ToList();
                List<byte> list4 = new byte[8]
                {
                    100,
                    0,
                    0,
                    0,
                    100,
                    0,
                    0,
                    0
                }.ToList();
                List<byte> first2 = new byte[6]
                {
                    88,
                    94,
                    47,
                    0,
                    200,
                    0
                }.Concat(second4).Concat(second).Concat(second2)
                    .ToList();
                List<byte> first3 = new byte[2]
                {
                    34,
                    0
                }.Concat(bytetool.strToToHexByte("000000010C000000530069006D00530075006E0000000000F0FFFFFF")).ToList();
                List<byte> list5 = new byte[4]
                {
                    10,
                    0,
                    0,
                    0
                }.Concat(list).Concat(new byte[7]
                {
                    0,
                    0,
                    1,
                    0,
                    48,
                    0,
                    0
                }).ToList();
                list5[0] = (byte)(list.Count - 2);
                List<byte> list6 = first3.Concat(list5).ToList();
                list6[0] = (byte)(list6.Count - 7);
                List<byte> list7 = new byte[2]
                {
                    18,
                    0
                }.Concat(list2).Concat(new byte[8]
                {
                    2,
                    0,
                    0,
                    0,
                    6,
                    0,
                    4,
                    0
                }.ToList()).Concat(second3)
                    .Concat(new byte[9]
                    {
                        3,
                        0,
                        1,
                        0,
                        49,
                        0,
                        0,
                        0,
                        0
                    })
                    .ToList();
                list7[0] = (byte)list2.Count;
                List<byte> list8 = first2.Concat(list6).Concat(list7).ToList();
                list4[0] = (byte)list8.Count;
                list4[4] = (byte)list8.Count;
                List<byte> list9 = new byte[2].Concat(second2).Concat(second4).Concat(new byte[4])
                    .ToList();
                list3[0] = (byte)(list3.Count + list4.Count + list8.Count + list9.Count - 4);
                List<byte> second5 = new byte[20]
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
                }.Concat(second4).Concat(new byte[34]
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
                }).Concat(second2)
                    .Concat(new byte[42]
                    {
                        3,
                        0,
                        0,
                        0,
                        32,
                        0,
                        50,
                        56,
                        49,
                        67,
                        49,
                        48,
                        65,
                        50,
                        70,
                        57,
                        51,
                        66,
                        65,
                        57,
                        65,
                        55,
                        57,
                        66,
                        51,
                        50,
                        69,
                        51,
                        67,
                        56,
                        55,
                        67,
                        51,
                        50,
                        48,
                        50,
                        56,
                        48,
                        120,
                        120,
                        120,
                        byte.MaxValue
                    })
                    .ToList();
                byte[] array = first.Concat(list3).Concat(list4).Concat(list8)
                    .Concat(list9)
                    .Concat(second5)
                    .ToList()
                    .ToArray();
                using (ByteArray byteArray = new ByteArray())
                {
                    byteArray.endian = Endian.LITTLE_ENDIAN;
                    byteArray.method_2(array.Length + 4);
                    byteArray.writeBytes(array);
                    myUser1225_0.servicetcp.Send(byteArray.Buffer, false);
                    byteArray.Dispose();
                }
            }
            catch
            {
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && icontainer_0 != null)
            {
                icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mygrid = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.当前频道 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.验证码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.马甲 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.心跳 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.连接IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbweb = new System.Windows.Forms.RadioButton();
            this.rdbpc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblhulian = new System.Windows.Forms.Label();
            this.ckbhulian = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnresetsudu = new System.Windows.Forms.Button();
            this.txtfeng = new System.Windows.Forms.TextBox();
            this.txtsudu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtjin = new System.Windows.Forms.TextBox();
            this.sfnEqZowcK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtzong = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckbhunhe = new System.Windows.Forms.CheckBox();
            this.checkBox_0 = new System.Windows.Forms.CheckBox();
            this.ckbhttpurl = new System.Windows.Forms.CheckBox();
            this.ckbhttplocal = new System.Windows.Forms.CheckBox();
            this.checkBox_1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_tingzhishuahua = new System.Windows.Forms.Button();
            this.btn_songhua = new System.Windows.Forms.Button();
            this.lbuid = new System.Windows.Forms.Label();
            this.txt_shuahuauid = new System.Windows.Forms.TextBox();
            this.txthanhuajiange = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btndaoruhanhua = new System.Windows.Forms.Button();
            this.ckbhanhua = new System.Windows.Forms.CheckBox();
            this.ckbxianche = new System.Windows.Forms.CheckBox();
            this.ckbqutubiao = new System.Windows.Forms.CheckBox();
            this.ckbgongneng = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btntingzhixiugai = new System.Windows.Forms.Button();
            this.btnchonglian = new System.Windows.Forms.Button();
            this.btnsuijixingbie = new System.Windows.Forms.Button();
            this.btndaoruqianming = new System.Windows.Forms.Button();
            this.btndaorumajia = new System.Windows.Forms.Button();
            this.btnqiehuan = new System.Windows.Forms.Button();
            this.btntuichu = new System.Windows.Forms.Button();
            this.btnjoin = new System.Windows.Forms.Button();
            this.btndaochu = new System.Windows.Forms.Button();
            this.btndaoru = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.xhfen = new System.Windows.Forms.NumericUpDown();
            this.xhshi = new System.Windows.Forms.NumericUpDown();
            this.xhtian = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.shfen = new System.Windows.Forms.NumericUpDown();
            this.shshi = new System.Windows.Forms.NumericUpDown();
            this.shtian = new System.Windows.Forms.NumericUpDown();
            this.ckbdsxh = new System.Windows.Forms.CheckBox();
            this.ckbdssh = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtshanghao = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtxiahao = new System.Windows.Forms.TextBox();
            this.groupBox_0 = new System.Windows.Forms.GroupBox();
            this.ckbduoip = new System.Windows.Forms.CheckBox();
            this.lblshijizaixian = new System.Windows.Forms.Label();
            this.lblauthtime = new System.Windows.Forms.Label();
            this.lbllastbuhao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblpath = new System.Windows.Forms.Label();
            this.lblver = new System.Windows.Forms.Label();
            this.openFileDialog_0 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_0 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox_1 = new System.Windows.Forms.GroupBox();
            this.groupBox_2 = new System.Windows.Forms.GroupBox();
            this.txtzuishaoshuliang = new System.Windows.Forms.TextBox();
            this.ckbzhinenghuanhao = new System.Windows.Forms.CheckBox();
            this.zhibotongzhi = new System.Windows.Forms.Button();
            this.tingzhizhibotongzhi = new System.Windows.Forms.Button();
            this.daka = new System.Windows.Forms.Button();
            this.tzdaka = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.beishuanicheng = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.shuahuasudu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mygrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xhfen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xhshi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xhtian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shfen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shshi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shtian)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox_0.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_1.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mygrid);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 502);
            this.panel1.TabIndex = 0;
            // 
            // mygrid
            // 
            this.mygrid.AllowUserToAddRows = false;
            this.mygrid.AllowUserToDeleteRows = false;
            this.mygrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.mygrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mygrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mygrid.ColumnHeadersHeight = 20;
            this.mygrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.用户名,
            this.当前频道,
            this.CF,
            this.验证码,
            this.CKI,
            this.Trace,
            this.马甲,
            this.心跳,
            this.状态,
            this.连接IP});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mygrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.mygrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mygrid.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mygrid.Location = new System.Drawing.Point(0, 0);
            this.mygrid.Name = "mygrid";
            this.mygrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mygrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mygrid.RowHeadersVisible = false;
            this.mygrid.RowTemplate.Height = 18;
            this.mygrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mygrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mygrid.Size = new System.Drawing.Size(703, 502);
            this.mygrid.TabIndex = 4;
            // 
            // 序号
            // 
            this.序号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.序号.DataPropertyName = "index";
            this.序号.FillWeight = 106.599F;
            this.序号.Frozen = true;
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.序号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.序号.Width = 40;
            // 
            // 用户名
            // 
            this.用户名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.用户名.DataPropertyName = "passport";
            this.用户名.FillWeight = 76.98668F;
            this.用户名.Frozen = true;
            this.用户名.HeaderText = "用户名";
            this.用户名.Name = "用户名";
            this.用户名.ReadOnly = true;
            this.用户名.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 当前频道
            // 
            this.当前频道.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.当前频道.DataPropertyName = "sid";
            this.当前频道.FillWeight = 77.84281F;
            this.当前频道.Frozen = true;
            this.当前频道.HeaderText = "当前频道";
            this.当前频道.Name = "当前频道";
            this.当前频道.ReadOnly = true;
            this.当前频道.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.当前频道.Width = 75;
            // 
            // CF
            // 
            this.CF.DataPropertyName = "currentflag";
            this.CF.Frozen = true;
            this.CF.HeaderText = "CF";
            this.CF.Name = "CF";
            this.CF.ReadOnly = true;
            this.CF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CF.Width = 44;
            // 
            // 验证码
            // 
            this.验证码.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.验证码.DataPropertyName = "yanzhengma";
            this.验证码.FillWeight = 253.0257F;
            this.验证码.Frozen = true;
            this.验证码.HeaderText = "验证码";
            this.验证码.Name = "验证码";
            this.验证码.ReadOnly = true;
            this.验证码.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.验证码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.验证码.Width = 50;
            // 
            // CKI
            // 
            this.CKI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CKI.DataPropertyName = "lol";
            this.CKI.Frozen = true;
            this.CKI.HeaderText = "LOL";
            this.CKI.Name = "CKI";
            this.CKI.ReadOnly = true;
            this.CKI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CKI.Visible = false;
            this.CKI.Width = 42;
            // 
            // Trace
            // 
            this.Trace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Trace.DataPropertyName = "mytrace";
            this.Trace.Frozen = true;
            this.Trace.HeaderText = "Trace";
            this.Trace.Name = "Trace";
            this.Trace.ReadOnly = true;
            this.Trace.Visible = false;
            this.Trace.Width = 80;
            // 
            // 马甲
            // 
            this.马甲.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.马甲.DataPropertyName = "nicheng";
            this.马甲.FillWeight = 76.98668F;
            this.马甲.Frozen = true;
            this.马甲.HeaderText = "马甲";
            this.马甲.Name = "马甲";
            this.马甲.ReadOnly = true;
            this.马甲.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 心跳
            // 
            this.心跳.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.心跳.DataPropertyName = "heartbeat";
            this.心跳.FillWeight = 76.98668F;
            this.心跳.Frozen = true;
            this.心跳.HeaderText = "心跳";
            this.心跳.Name = "心跳";
            this.心跳.ReadOnly = true;
            this.心跳.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.心跳.Width = 43;
            // 
            // 状态
            // 
            this.状态.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.状态.DataPropertyName = "statusstr";
            this.状态.FillWeight = 76.98668F;
            this.状态.Frozen = true;
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            this.状态.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 连接IP
            // 
            this.连接IP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.连接IP.DataPropertyName = "dailistr";
            this.连接IP.HeaderText = "代理";
            this.连接IP.Name = "连接IP";
            this.连接IP.ReadOnly = true;
            this.连接IP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbweb);
            this.groupBox1.Controls.Add(this.rdbpc);
            this.groupBox1.Location = new System.Drawing.Point(943, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 38);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "版本选择";
            // 
            // rdbweb
            // 
            this.rdbweb.AutoSize = true;
            this.rdbweb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbweb.Location = new System.Drawing.Point(44, 16);
            this.rdbweb.Name = "rdbweb";
            this.rdbweb.Size = new System.Drawing.Size(47, 16);
            this.rdbweb.TabIndex = 2;
            this.rdbweb.Text = "网页";
            this.rdbweb.UseVisualStyleBackColor = true;
            this.rdbweb.CheckedChanged += new System.EventHandler(this.rdbweb_CheckedChanged);
            // 
            // rdbpc
            // 
            this.rdbpc.AutoSize = true;
            this.rdbpc.Checked = true;
            this.rdbpc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbpc.Location = new System.Drawing.Point(7, 16);
            this.rdbpc.Name = "rdbpc";
            this.rdbpc.Size = new System.Drawing.Size(35, 16);
            this.rdbpc.TabIndex = 0;
            this.rdbpc.TabStop = true;
            this.rdbpc.Text = "PC";
            this.rdbpc.UseVisualStyleBackColor = true;
            this.rdbpc.CheckedChanged += new System.EventHandler(this.rdbpc_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblhulian);
            this.groupBox2.Controls.Add(this.ckbhulian);
            this.groupBox2.Location = new System.Drawing.Point(802, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 38);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "互联";
            // 
            // lblhulian
            // 
            this.lblhulian.AutoSize = true;
            this.lblhulian.ForeColor = System.Drawing.Color.Green;
            this.lblhulian.Location = new System.Drawing.Point(53, 18);
            this.lblhulian.Name = "lblhulian";
            this.lblhulian.Size = new System.Drawing.Size(0, 12);
            this.lblhulian.TabIndex = 1;
            // 
            // ckbhulian
            // 
            this.ckbhulian.AutoSize = true;
            this.ckbhulian.Location = new System.Drawing.Point(5, 16);
            this.ckbhulian.Name = "ckbhulian";
            this.ckbhulian.Size = new System.Drawing.Size(48, 16);
            this.ckbhulian.TabIndex = 0;
            this.ckbhulian.Text = "开启";
            this.ckbhulian.UseVisualStyleBackColor = true;
            this.ckbhulian.CheckedChanged += new System.EventHandler(this.ckbhulian_CheckedChanged);
            this.ckbhulian.Click += new System.EventHandler(this.ckbhulian_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnresetsudu);
            this.groupBox3.Controls.Add(this.txtfeng);
            this.groupBox3.Controls.Add(this.txtsudu);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtjin);
            this.groupBox3.Controls.Add(this.sfnEqZowcK);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtzong);
            this.groupBox3.Controls.Add(this.txtsid);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(701, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 92);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "频道信息";
            // 
            // btnresetsudu
            // 
            this.btnresetsudu.Location = new System.Drawing.Point(77, 65);
            this.btnresetsudu.Name = "btnresetsudu";
            this.btnresetsudu.Size = new System.Drawing.Size(40, 23);
            this.btnresetsudu.TabIndex = 13;
            this.btnresetsudu.Text = "重置";
            this.btnresetsudu.UseVisualStyleBackColor = true;
            this.btnresetsudu.Click += new System.EventHandler(this.btnresetsudu_Click);
            // 
            // txtfeng
            // 
            this.txtfeng.Enabled = false;
            this.txtfeng.Location = new System.Drawing.Point(147, 66);
            this.txtfeng.Name = "txtfeng";
            this.txtfeng.Size = new System.Drawing.Size(60, 21);
            this.txtfeng.TabIndex = 12;
            // 
            // txtsudu
            // 
            this.txtsudu.Location = new System.Drawing.Point(28, 66);
            this.txtsudu.Name = "txtsudu";
            this.txtsudu.Size = new System.Drawing.Size(41, 21);
            this.txtsudu.TabIndex = 6;
            this.txtsudu.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "封";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "速";
            // 
            // txtjin
            // 
            this.txtjin.Enabled = false;
            this.txtjin.Location = new System.Drawing.Point(146, 42);
            this.txtjin.Name = "txtjin";
            this.txtjin.Size = new System.Drawing.Size(60, 21);
            this.txtjin.TabIndex = 10;
            // 
            // sfnEqZowcK
            // 
            this.sfnEqZowcK.Location = new System.Drawing.Point(27, 42);
            this.sfnEqZowcK.Name = "sfnEqZowcK";
            this.sfnEqZowcK.Size = new System.Drawing.Size(90, 21);
            this.sfnEqZowcK.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "进";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "子";
            // 
            // txtzong
            // 
            this.txtzong.Enabled = false;
            this.txtzong.Location = new System.Drawing.Point(146, 18);
            this.txtzong.Name = "txtzong";
            this.txtzong.Size = new System.Drawing.Size(60, 21);
            this.txtzong.TabIndex = 8;
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(27, 18);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(90, 21);
            this.txtsid.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "总";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "主";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ckbhunhe);
            this.groupBox4.Controls.Add(this.checkBox_0);
            this.groupBox4.Controls.Add(this.ckbhttpurl);
            this.groupBox4.Location = new System.Drawing.Point(702, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 40);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HTTP代理";
            // 
            // ckbhunhe
            // 
            this.ckbhunhe.AutoSize = true;
            this.ckbhunhe.Checked = true;
            this.ckbhunhe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbhunhe.Location = new System.Drawing.Point(150, 18);
            this.ckbhunhe.Name = "ckbhunhe";
            this.ckbhunhe.Size = new System.Drawing.Size(48, 16);
            this.ckbhunhe.TabIndex = 21;
            this.ckbhunhe.Text = "混合";
            this.ckbhunhe.UseVisualStyleBackColor = true;
            // 
            // checkBox_0
            // 
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Location = new System.Drawing.Point(82, 18);
            this.checkBox_0.Name = "checkBox_0";
            this.checkBox_0.Size = new System.Drawing.Size(36, 16);
            this.checkBox_0.TabIndex = 5;
            this.checkBox_0.Text = "S5";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new System.EventHandler(this.checkBox_0_CheckedChanged);
            // 
            // ckbhttpurl
            // 
            this.ckbhttpurl.AutoSize = true;
            this.ckbhttpurl.Location = new System.Drawing.Point(8, 18);
            this.ckbhttpurl.Name = "ckbhttpurl";
            this.ckbhttpurl.Size = new System.Drawing.Size(48, 16);
            this.ckbhttpurl.TabIndex = 1;
            this.ckbhttpurl.Text = "HTTP";
            this.ckbhttpurl.UseVisualStyleBackColor = true;
            this.ckbhttpurl.CheckedChanged += new System.EventHandler(this.ckbhttpurl_CheckedChanged);
            // 
            // ckbhttplocal
            // 
            this.ckbhttplocal.AutoSize = true;
            this.ckbhttplocal.Location = new System.Drawing.Point(64, 18);
            this.ckbhttplocal.Name = "ckbhttplocal";
            this.ckbhttplocal.Size = new System.Drawing.Size(48, 16);
            this.ckbhttplocal.TabIndex = 2;
            this.ckbhttplocal.Text = "本地";
            this.ckbhttplocal.UseVisualStyleBackColor = true;
            this.ckbhttplocal.CheckedChanged += new System.EventHandler(this.ckbhttplocal_CheckedChanged);
            // 
            // checkBox_1
            // 
            this.checkBox_1.AutoSize = true;
            this.checkBox_1.Location = new System.Drawing.Point(4, 18);
            this.checkBox_1.Name = "checkBox_1";
            this.checkBox_1.Size = new System.Drawing.Size(54, 16);
            this.checkBox_1.TabIndex = 5;
            this.checkBox_1.Text = "spoof";
            this.checkBox_1.UseVisualStyleBackColor = true;
            this.checkBox_1.CheckedChanged += new System.EventHandler(this.checkBox_1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.beishuanicheng);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.tzdaka);
            this.groupBox5.Controls.Add(this.daka);
            this.groupBox5.Controls.Add(this.shuahuasudu);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.tingzhizhibotongzhi);
            this.groupBox5.Controls.Add(this.zhibotongzhi);
            this.groupBox5.Controls.Add(this.btn_tingzhishuahua);
            this.groupBox5.Controls.Add(this.btn_songhua);
            this.groupBox5.Controls.Add(this.lbuid);
            this.groupBox5.Controls.Add(this.txt_shuahuauid);
            this.groupBox5.Controls.Add(this.txthanhuajiange);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.btndaoruhanhua);
            this.groupBox5.Controls.Add(this.ckbhanhua);
            this.groupBox5.Controls.Add(this.ckbxianche);
            this.groupBox5.Controls.Add(this.ckbqutubiao);
            this.groupBox5.Controls.Add(this.ckbgongneng);
            this.groupBox5.Location = new System.Drawing.Point(702, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 143);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "扩展功能";
            // 
            // btn_tingzhishuahua
            // 
            this.btn_tingzhishuahua.Location = new System.Drawing.Point(145, 91);
            this.btn_tingzhishuahua.Name = "btn_tingzhishuahua";
            this.btn_tingzhishuahua.Size = new System.Drawing.Size(55, 23);
            this.btn_tingzhishuahua.TabIndex = 33;
            this.btn_tingzhishuahua.Text = "停刷";
            this.btn_tingzhishuahua.UseVisualStyleBackColor = true;
            this.btn_tingzhishuahua.Click += new System.EventHandler(this.btn_tingzhishuahua_Click);
            // 
            // btn_songhua
            // 
            this.btn_songhua.Location = new System.Drawing.Point(86, 91);
            this.btn_songhua.Name = "btn_songhua";
            this.btn_songhua.Size = new System.Drawing.Size(57, 23);
            this.btn_songhua.TabIndex = 32;
            this.btn_songhua.Text = "刷花";
            this.btn_songhua.UseVisualStyleBackColor = true;
            this.btn_songhua.Click += new System.EventHandler(this.btn_songhua_Click);
            // 
            // lbuid
            // 
            this.lbuid.AutoSize = true;
            this.lbuid.Location = new System.Drawing.Point(6, 102);
            this.lbuid.Name = "lbuid";
            this.lbuid.Size = new System.Drawing.Size(29, 12);
            this.lbuid.TabIndex = 31;
            this.lbuid.Text = "UID:";
            // 
            // txt_shuahuauid
            // 
            this.txt_shuahuauid.Location = new System.Drawing.Point(40, 93);
            this.txt_shuahuauid.Name = "txt_shuahuauid";
            this.txt_shuahuauid.Size = new System.Drawing.Size(40, 21);
            this.txt_shuahuauid.TabIndex = 30;
            // 
            // txthanhuajiange
            // 
            this.txthanhuajiange.Enabled = false;
            this.txthanhuajiange.Location = new System.Drawing.Point(163, 39);
            this.txthanhuajiange.Name = "txthanhuajiange";
            this.txthanhuajiange.Size = new System.Drawing.Size(45, 21);
            this.txthanhuajiange.TabIndex = 8;
            this.txthanhuajiange.Text = "5000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "喊话间隔";
            // 
            // btndaoruhanhua
            // 
            this.btndaoruhanhua.Enabled = false;
            this.btndaoruhanhua.Location = new System.Drawing.Point(56, 38);
            this.btndaoruhanhua.Name = "btndaoruhanhua";
            this.btndaoruhanhua.Size = new System.Drawing.Size(50, 23);
            this.btndaoruhanhua.TabIndex = 6;
            this.btndaoruhanhua.Text = "导入";
            this.btndaoruhanhua.UseVisualStyleBackColor = true;
            this.btndaoruhanhua.Click += new System.EventHandler(this.btndaoruhanhua_Click);
            // 
            // ckbhanhua
            // 
            this.ckbhanhua.AutoSize = true;
            this.ckbhanhua.Enabled = false;
            this.ckbhanhua.Location = new System.Drawing.Point(8, 42);
            this.ckbhanhua.Name = "ckbhanhua";
            this.ckbhanhua.Size = new System.Drawing.Size(48, 16);
            this.ckbhanhua.TabIndex = 5;
            this.ckbhanhua.Text = "喊话";
            this.ckbhanhua.UseVisualStyleBackColor = true;
            this.ckbhanhua.CheckedChanged += new System.EventHandler(this.ckbhanhua_CheckedChanged);
            // 
            // ckbxianche
            // 
            this.ckbxianche.AutoSize = true;
            this.ckbxianche.Enabled = false;
            this.ckbxianche.Location = new System.Drawing.Point(150, 17);
            this.ckbxianche.Name = "ckbxianche";
            this.ckbxianche.Size = new System.Drawing.Size(48, 16);
            this.ckbxianche.TabIndex = 4;
            this.ckbxianche.Text = "显车";
            this.ckbxianche.UseVisualStyleBackColor = true;
            // 
            // ckbqutubiao
            // 
            this.ckbqutubiao.AutoSize = true;
            this.ckbqutubiao.Enabled = false;
            this.ckbqutubiao.Location = new System.Drawing.Point(82, 17);
            this.ckbqutubiao.Name = "ckbqutubiao";
            this.ckbqutubiao.Size = new System.Drawing.Size(60, 16);
            this.ckbqutubiao.TabIndex = 3;
            this.ckbqutubiao.Text = "去图标";
            this.ckbqutubiao.UseVisualStyleBackColor = true;
            // 
            // ckbgongneng
            // 
            this.ckbgongneng.AutoSize = true;
            this.ckbgongneng.ForeColor = System.Drawing.Color.DarkRed;
            this.ckbgongneng.Location = new System.Drawing.Point(8, 17);
            this.ckbgongneng.Name = "ckbgongneng";
            this.ckbgongneng.Size = new System.Drawing.Size(72, 16);
            this.ckbgongneng.TabIndex = 2;
            this.ckbgongneng.Text = "功能开启";
            this.ckbgongneng.UseVisualStyleBackColor = true;
            this.ckbgongneng.CheckedChanged += new System.EventHandler(this.ckbgongneng_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btntingzhixiugai);
            this.groupBox6.Controls.Add(this.btnchonglian);
            this.groupBox6.Controls.Add(this.btnsuijixingbie);
            this.groupBox6.Controls.Add(this.btndaoruqianming);
            this.groupBox6.Controls.Add(this.btndaorumajia);
            this.groupBox6.Controls.Add(this.btnqiehuan);
            this.groupBox6.Controls.Add(this.btntuichu);
            this.groupBox6.Controls.Add(this.btnjoin);
            this.groupBox6.Controls.Add(this.btndaochu);
            this.groupBox6.Controls.Add(this.btndaoru);
            this.groupBox6.Location = new System.Drawing.Point(702, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(210, 150);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "控制";
            // 
            // btntingzhixiugai
            // 
            this.btntingzhixiugai.Location = new System.Drawing.Point(142, 48);
            this.btntingzhixiugai.Name = "btntingzhixiugai";
            this.btntingzhixiugai.Size = new System.Drawing.Size(65, 30);
            this.btntingzhixiugai.TabIndex = 20;
            this.btntingzhixiugai.Text = "停止修改";
            this.btntingzhixiugai.UseVisualStyleBackColor = true;
            this.btntingzhixiugai.Click += new System.EventHandler(this.btntingzhixiugai_Click);
            // 
            // btnchonglian
            // 
            this.btnchonglian.Location = new System.Drawing.Point(142, 15);
            this.btnchonglian.Name = "btnchonglian";
            this.btnchonglian.Size = new System.Drawing.Size(65, 30);
            this.btnchonglian.TabIndex = 19;
            this.btnchonglian.Text = "重连";
            this.btnchonglian.UseVisualStyleBackColor = true;
            this.btnchonglian.Click += new System.EventHandler(this.btnchonglian_Click);
            // 
            // btnsuijixingbie
            // 
            this.btnsuijixingbie.Enabled = false;
            this.btnsuijixingbie.Location = new System.Drawing.Point(74, 114);
            this.btnsuijixingbie.Name = "btnsuijixingbie";
            this.btnsuijixingbie.Size = new System.Drawing.Size(65, 30);
            this.btnsuijixingbie.TabIndex = 18;
            this.btnsuijixingbie.Text = "随机性别";
            this.btnsuijixingbie.UseVisualStyleBackColor = true;
            this.btnsuijixingbie.Click += new System.EventHandler(this.btnsuijixingbie_Click);
            // 
            // btndaoruqianming
            // 
            this.btndaoruqianming.Enabled = false;
            this.btndaoruqianming.Location = new System.Drawing.Point(74, 81);
            this.btndaoruqianming.Name = "btndaoruqianming";
            this.btndaoruqianming.Size = new System.Drawing.Size(65, 30);
            this.btndaoruqianming.TabIndex = 17;
            this.btndaoruqianming.Text = "导入签名";
            this.btndaoruqianming.UseVisualStyleBackColor = true;
            this.btndaoruqianming.Click += new System.EventHandler(this.btndaoruqianming_Click);
            // 
            // btndaorumajia
            // 
            this.btndaorumajia.Enabled = false;
            this.btndaorumajia.Location = new System.Drawing.Point(74, 48);
            this.btndaorumajia.Name = "btndaorumajia";
            this.btndaorumajia.Size = new System.Drawing.Size(65, 30);
            this.btndaorumajia.TabIndex = 15;
            this.btndaorumajia.Text = "导入马甲";
            this.btndaorumajia.UseVisualStyleBackColor = true;
            this.btndaorumajia.Click += new System.EventHandler(this.btndaorumajia_Click);
            // 
            // btnqiehuan
            // 
            this.btnqiehuan.Enabled = false;
            this.btnqiehuan.Location = new System.Drawing.Point(6, 81);
            this.btnqiehuan.Name = "btnqiehuan";
            this.btnqiehuan.Size = new System.Drawing.Size(65, 30);
            this.btnqiehuan.TabIndex = 14;
            this.btnqiehuan.Text = "切换频道";
            this.btnqiehuan.UseVisualStyleBackColor = true;
            this.btnqiehuan.Click += new System.EventHandler(this.btnqiehuan_Click);
            // 
            // btntuichu
            // 
            this.btntuichu.Enabled = false;
            this.btntuichu.Location = new System.Drawing.Point(6, 114);
            this.btntuichu.Name = "btntuichu";
            this.btntuichu.Size = new System.Drawing.Size(65, 30);
            this.btntuichu.TabIndex = 13;
            this.btntuichu.Text = "退出频道";
            this.btntuichu.UseVisualStyleBackColor = true;
            this.btntuichu.Click += new System.EventHandler(this.btntuichu_Click);
            // 
            // btnjoin
            // 
            this.btnjoin.Location = new System.Drawing.Point(6, 48);
            this.btnjoin.Name = "btnjoin";
            this.btnjoin.Size = new System.Drawing.Size(65, 30);
            this.btnjoin.TabIndex = 12;
            this.btnjoin.Text = "进入频道";
            this.btnjoin.UseVisualStyleBackColor = true;
            this.btnjoin.Click += new System.EventHandler(this.btnjoin_Click);
            // 
            // btndaochu
            // 
            this.btndaochu.Location = new System.Drawing.Point(74, 15);
            this.btndaochu.Name = "btndaochu";
            this.btndaochu.Size = new System.Drawing.Size(65, 30);
            this.btndaochu.TabIndex = 11;
            this.btndaochu.Text = "导出用户";
            this.btndaochu.UseVisualStyleBackColor = true;
            this.btndaochu.Click += new System.EventHandler(this.btndaochu_Click);
            // 
            // btndaoru
            // 
            this.btndaoru.Location = new System.Drawing.Point(6, 15);
            this.btndaoru.Name = "btndaoru";
            this.btndaoru.Size = new System.Drawing.Size(65, 30);
            this.btndaoru.TabIndex = 10;
            this.btndaoru.Text = "导入用户";
            this.btndaoru.UseVisualStyleBackColor = true;
            this.btndaoru.Click += new System.EventHandler(this.btndaoru_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.xhfen);
            this.groupBox7.Controls.Add(this.xhshi);
            this.groupBox7.Controls.Add(this.xhtian);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.shfen);
            this.groupBox7.Controls.Add(this.shshi);
            this.groupBox7.Controls.Add(this.shtian);
            this.groupBox7.Controls.Add(this.ckbdsxh);
            this.groupBox7.Controls.Add(this.ckbdssh);
            this.groupBox7.Location = new System.Drawing.Point(702, 435);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(210, 69);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "定时上下号";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "分";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "时";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(82, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "天";
            // 
            // xhfen
            // 
            this.xhfen.Location = new System.Drawing.Point(154, 41);
            this.xhfen.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.xhfen.Name = "xhfen";
            this.xhfen.Size = new System.Drawing.Size(35, 21);
            this.xhfen.TabIndex = 17;
            // 
            // xhshi
            // 
            this.xhshi.Location = new System.Drawing.Point(100, 41);
            this.xhshi.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.xhshi.Name = "xhshi";
            this.xhshi.Size = new System.Drawing.Size(35, 21);
            this.xhshi.TabIndex = 16;
            // 
            // xhtian
            // 
            this.xhtian.Location = new System.Drawing.Point(40, 41);
            this.xhtian.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.xhtian.Name = "xhtian";
            this.xhtian.Size = new System.Drawing.Size(40, 21);
            this.xhtian.TabIndex = 15;
            this.xhtian.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "分";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "时";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "天";
            // 
            // shfen
            // 
            this.shfen.Location = new System.Drawing.Point(154, 16);
            this.shfen.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.shfen.Name = "shfen";
            this.shfen.Size = new System.Drawing.Size(35, 21);
            this.shfen.TabIndex = 11;
            // 
            // shshi
            // 
            this.shshi.Location = new System.Drawing.Point(100, 16);
            this.shshi.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.shshi.Name = "shshi";
            this.shshi.Size = new System.Drawing.Size(35, 21);
            this.shshi.TabIndex = 10;
            // 
            // shtian
            // 
            this.shtian.Location = new System.Drawing.Point(40, 16);
            this.shtian.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.shtian.Name = "shtian";
            this.shtian.Size = new System.Drawing.Size(40, 21);
            this.shtian.TabIndex = 9;
            // 
            // ckbdsxh
            // 
            this.ckbdsxh.AutoSize = true;
            this.ckbdsxh.Location = new System.Drawing.Point(5, 44);
            this.ckbdsxh.Name = "ckbdsxh";
            this.ckbdsxh.Size = new System.Drawing.Size(36, 16);
            this.ckbdsxh.TabIndex = 8;
            this.ckbdsxh.Text = "下";
            this.ckbdsxh.UseVisualStyleBackColor = true;
            this.ckbdsxh.CheckedChanged += new System.EventHandler(this.ckbdsxh_CheckedChanged);
            this.ckbdsxh.Click += new System.EventHandler(this.ckbdsxh_Click);
            // 
            // ckbdssh
            // 
            this.ckbdssh.AutoSize = true;
            this.ckbdssh.Location = new System.Drawing.Point(5, 19);
            this.ckbdssh.Name = "ckbdssh";
            this.ckbdssh.Size = new System.Drawing.Size(36, 16);
            this.ckbdssh.TabIndex = 6;
            this.ckbdssh.Text = "上";
            this.ckbdssh.UseVisualStyleBackColor = true;
            this.ckbdssh.CheckedChanged += new System.EventHandler(this.ckbdssh_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtshanghao);
            this.groupBox8.Location = new System.Drawing.Point(0, 503);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(350, 40);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "上号链接";
            // 
            // txtshanghao
            // 
            this.txtshanghao.Location = new System.Drawing.Point(6, 13);
            this.txtshanghao.Name = "txtshanghao";
            this.txtshanghao.Size = new System.Drawing.Size(338, 21);
            this.txtshanghao.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtxiahao);
            this.groupBox9.Location = new System.Drawing.Point(350, 503);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(350, 40);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "下号链接";
            // 
            // txtxiahao
            // 
            this.txtxiahao.Location = new System.Drawing.Point(6, 13);
            this.txtxiahao.Name = "txtxiahao";
            this.txtxiahao.Size = new System.Drawing.Size(338, 21);
            this.txtxiahao.TabIndex = 1;
            // 
            // groupBox_0
            // 
            this.groupBox_0.Controls.Add(this.ckbduoip);
            this.groupBox_0.Controls.Add(this.lblshijizaixian);
            this.groupBox_0.Location = new System.Drawing.Point(702, 508);
            this.groupBox_0.Name = "groupBox_0";
            this.groupBox_0.Size = new System.Drawing.Size(101, 40);
            this.groupBox_0.TabIndex = 10;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "监控";
            // 
            // ckbduoip
            // 
            this.ckbduoip.AutoSize = true;
            this.ckbduoip.Checked = true;
            this.ckbduoip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbduoip.Location = new System.Drawing.Point(4, 19);
            this.ckbduoip.Name = "ckbduoip";
            this.ckbduoip.Size = new System.Drawing.Size(48, 16);
            this.ckbduoip.TabIndex = 6;
            this.ckbduoip.Text = "多IP";
            this.ckbduoip.UseVisualStyleBackColor = true;
            // 
            // lblshijizaixian
            // 
            this.lblshijizaixian.AutoSize = true;
            this.lblshijizaixian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblshijizaixian.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblshijizaixian.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblshijizaixian.Location = new System.Drawing.Point(53, 19);
            this.lblshijizaixian.Name = "lblshijizaixian";
            this.lblshijizaixian.Size = new System.Drawing.Size(14, 14);
            this.lblshijizaixian.TabIndex = 3;
            this.lblshijizaixian.Text = "0";
            // 
            // lblauthtime
            // 
            this.lblauthtime.AutoSize = true;
            this.lblauthtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblauthtime.Location = new System.Drawing.Point(1043, 557);
            this.lblauthtime.Name = "lblauthtime";
            this.lblauthtime.Size = new System.Drawing.Size(37, 14);
            this.lblauthtime.TabIndex = 7;
            this.lblauthtime.Text = "00:00";
            // 
            // lbllastbuhao
            // 
            this.lbllastbuhao.AutoSize = true;
            this.lbllastbuhao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbllastbuhao.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbllastbuhao.ForeColor = System.Drawing.Color.Black;
            this.lbllastbuhao.Location = new System.Drawing.Point(1086, 557);
            this.lbllastbuhao.Name = "lbllastbuhao";
            this.lbllastbuhao.Size = new System.Drawing.Size(13, 14);
            this.lbllastbuhao.TabIndex = 5;
            this.lbllastbuhao.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblpath);
            this.panel2.Location = new System.Drawing.Point(0, 549);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 26);
            this.panel2.TabIndex = 11;
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Location = new System.Drawing.Point(4, 7);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 12);
            this.lblpath.TabIndex = 0;
            // 
            // lblver
            // 
            this.lblver.AutoSize = true;
            this.lblver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblver.Location = new System.Drawing.Point(1139, 557);
            this.lblver.Name = "lblver";
            this.lblver.Size = new System.Drawing.Size(49, 14);
            this.lblver.TabIndex = 2;
            this.lblver.Text = "8.4.2.0";
            // 
            // openFileDialog_0
            // 
            this.openFileDialog_0.FileName = "openFileDialog1";
            // 
            // groupBox_1
            // 
            this.groupBox_1.Controls.Add(this.checkBox_1);
            this.groupBox_1.Controls.Add(this.ckbhttplocal);
            this.groupBox_1.Location = new System.Drawing.Point(943, 308);
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new System.Drawing.Size(109, 40);
            this.groupBox_1.TabIndex = 6;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "FF";
            // 
            // groupBox_2
            // 
            this.groupBox_2.Controls.Add(this.txtzuishaoshuliang);
            this.groupBox_2.Controls.Add(this.ckbzhinenghuanhao);
            this.groupBox_2.Location = new System.Drawing.Point(1135, 478);
            this.groupBox_2.Name = "groupBox_2";
            this.groupBox_2.Size = new System.Drawing.Size(106, 40);
            this.groupBox_2.TabIndex = 12;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "智能换号";
            // 
            // txtzuishaoshuliang
            // 
            this.txtzuishaoshuliang.Enabled = false;
            this.txtzuishaoshuliang.Location = new System.Drawing.Point(42, 14);
            this.txtzuishaoshuliang.Name = "txtzuishaoshuliang";
            this.txtzuishaoshuliang.Size = new System.Drawing.Size(56, 21);
            this.txtzuishaoshuliang.TabIndex = 7;
            this.txtzuishaoshuliang.Text = "0";
            // 
            // ckbzhinenghuanhao
            // 
            this.ckbzhinenghuanhao.AutoSize = true;
            this.ckbzhinenghuanhao.Enabled = false;
            this.ckbzhinenghuanhao.Location = new System.Drawing.Point(4, 19);
            this.ckbzhinenghuanhao.Name = "ckbzhinenghuanhao";
            this.ckbzhinenghuanhao.Size = new System.Drawing.Size(36, 16);
            this.ckbzhinenghuanhao.TabIndex = 6;
            this.ckbzhinenghuanhao.Text = "开";
            this.ckbzhinenghuanhao.UseVisualStyleBackColor = true;
            // 
            // zhibotongzhi
            // 
            this.zhibotongzhi.Location = new System.Drawing.Point(6, 117);
            this.zhibotongzhi.Name = "zhibotongzhi";
            this.zhibotongzhi.Size = new System.Drawing.Size(46, 20);
            this.zhibotongzhi.TabIndex = 39;
            this.zhibotongzhi.Text = "通知 ";
            this.zhibotongzhi.UseVisualStyleBackColor = true;
            this.zhibotongzhi.Click += new System.EventHandler(this.zhibotongzhi_Click);
            // 
            // tingzhizhibotongzhi
            // 
            this.tingzhizhibotongzhi.Location = new System.Drawing.Point(56, 117);
            this.tingzhizhibotongzhi.Name = "tingzhizhibotongzhi";
            this.tingzhizhibotongzhi.Size = new System.Drawing.Size(43, 20);
            this.tingzhizhibotongzhi.TabIndex = 40;
            this.tingzhizhibotongzhi.Text = "停止通知";
            this.tingzhizhibotongzhi.UseVisualStyleBackColor = true;
            this.tingzhizhibotongzhi.Click += new System.EventHandler(this.tingzhizhibotongzhi_Click);
            // 
            // daka
            // 
            this.daka.Location = new System.Drawing.Point(105, 117);
            this.daka.Name = "daka";
            this.daka.Size = new System.Drawing.Size(39, 20);
            this.daka.TabIndex = 41;
            this.daka.Text = "打卡";
            this.daka.UseVisualStyleBackColor = true;
            this.daka.Click += new System.EventHandler(this.daka_Click);
            // 
            // tzdaka
            // 
            this.tzdaka.Location = new System.Drawing.Point(150, 117);
            this.tzdaka.Name = "tzdaka";
            this.tzdaka.Size = new System.Drawing.Size(48, 20);
            this.tzdaka.TabIndex = 42;
            this.tzdaka.Text = "停止打卡";
            this.tzdaka.UseVisualStyleBackColor = true;
            this.tzdaka.Click += new System.EventHandler(this.tzdaka_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(98, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 47;
            this.label18.Text = "昵称：";
            // 
            // beishuanicheng
            // 
            this.beishuanicheng.Location = new System.Drawing.Point(146, 66);
            this.beishuanicheng.Name = "beishuanicheng";
            this.beishuanicheng.Size = new System.Drawing.Size(59, 21);
            this.beishuanicheng.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 45;
            this.label17.Text = "速度：";
            // 
            // shuahuasudu
            // 
            this.shuahuasudu.Location = new System.Drawing.Point(40, 64);
            this.shuahuasudu.Name = "shuahuasudu";
            this.shuahuasudu.Size = new System.Drawing.Size(40, 21);
            this.shuahuasudu.TabIndex = 44;
            this.shuahuasudu.Text = "10";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 578);
            this.Controls.Add(this.lblauthtime);
            this.Controls.Add(this.groupBox_2);
            this.Controls.Add(this.lbllastbuhao);
            this.Controls.Add(this.groupBox_1);
            this.Controls.Add(this.lblver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox_0);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mygrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xhfen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xhshi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xhtian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shfen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shshi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shtian)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        [CompilerGenerated]
        private void method_17()
        {
            try
            {
                if (Form.ActiveForm == this)
                {
                    mygrid.Refresh();
                }
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_18()
        {
            try
            {
                txtzong.Text = int_3.ToString();
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_19()
        {
            try
            {
                txtjin.Text = int_4.ToString();
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_20()
        {
            try
            {
                txtfeng.Text = int_5.ToString();
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_21()
        {
            try
            {
                if (ckbdsxh.Checked && dateTime_2 != DateTime.MinValue)
                {
                    int num = (int)(dateTime_2 - DateTime.Now).TotalHours;
                    object[] obj = new object[4]
                    {
                        rQaQnYbAnm.ToString(),
                        int_4,
                        null,
                        null
                    };
                    int num2 = num / 24;
                    obj[2] = num2.ToString();
                    num2 = num % 24;
                    obj[3] = num2.ToString();
                    Text = string.Format("{0} - {1} - {2}天{3}小时", obj);
                }
                else
                {
                    Text = string.Format("{0} - {1}", rQaQnYbAnm.ToString(), int_4);
                }
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_22()
        {
            try
            {
                //	lbldaoqi.Text = string.Format("到期：{0}", timetool.getstr(int_0));
                if (int_0 > 1440)
                {
                    //		lbldaoqi.ForeColor = Color.Green;
                }
                else
                {
                    //		lbldaoqi.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_23()
        {
            try
            {
                lblauthtime.Text = dateTime_0.ToString("HH:mm");
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_24()
        {
            try
            {
                ckbdssh.Checked = false;
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_25()
        {
            try
            {
                ckbdsxh.Checked = false;
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_26()
        {
            try
            {
                mygrid.DataSource = (from p in concurrentBag_0
                                     orderby p.index
                                     select p).ToArray();
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_27()
        {
            try
            {
                txtzong.Text = concurrentBag_0.Count.ToString();
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_28()
        {
            while (true)
            {
                try
                {
                    if (bool_0 || concurrentBag_1 == null || concurrentBag_1.Count == 0)
                    {
                        Thread.Sleep(3000);
                        continue;
                    }
                    IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                    {
                        if (p.loginstatus == 2 && p.joinstatus == 0)
                        {
                            return !p.isfenghao;
                        }
                        return false;
                    });
                    if (enumerable != null && enumerable.Count() > 0)
                    {
                        using (IEnumerator<MyUser1225> enumerator = enumerable.Reverse().GetEnumerator())
                        {
                            while (true)
                            {
                                if (enumerator.MoveNext())
                                {
                                    MyUser1225 current = enumerator.Current;
                                    try
                                    {
                                        while (yongjiobj_0.isyongji && yongjiobj_0.ctime.AddSeconds(10.0) > DateTime.Now && !ckbhunhe.Checked)
                                        {
                                            Thread.Sleep(1000);
                                        }
                                        yongjiobj_0.isyongji = false;
                                        if (!bool_0 && !(dateTime_0.AddMinutes(5.0) < DateTime.Now) && ((!checkBox_1.Checked && !checkBox_0.Checked) || (list_1 != null && list_1.Count != 0)) && ((!ckbhttpurl.Checked && !ckbhttplocal.Checked) || (list_0 != null && list_0.Count != 0)))
                                        {
                                            if (ckbduoip.Checked)
                                            {
                                                if (list_3 != null && list_3.Count > 0)
                                                {
                                                    current.localip = list_3[current.index % list_3.Count];
                                                }
                                            }
                                            else
                                            {
                                                current.localip = "";
                                            }
                                            myip _myip = concurrentBag_1.ToList()[current.index % concurrentBag_1.Count];
                                            current.apip = _myip.ip;
                                            current.apport = _myip.ports[0];
                                            if (rdbpc.Checked && list_0.Count > 0 && (ckbhttpurl.Checked || ckbhttplocal.Checked))
                                            {
                                                current.pt = ProxyTypes.Https;
                                                current.daili = list_0[current.index % list_0.Count];
                                            }
                                            else if (!checkBox_1.Checked && !checkBox_0.Checked)
                                            {
                                                current.pt = ProxyTypes.None;
                                                current.daili = "";
                                            }
                                            else
                                            {
                                                current.pt = ProxyTypes.Socks5;
                                                current.daili = list_1[current.index % list_1.Count];
                                            }
                                            if (!current.isudblogin && current.logintype == 1)
                                            {
                                                try
                                                {
                                                    dynamic val = getpcuser(current);
                                                    if (val != null)
                                                    {
                                                        string value = (string)val.uid;
                                                        string username = (string)val.username;
                                                        string arg = (string)val.cookie;
                                                        string text = (string)val.at;
                                                        current.username = username;
                                                        current.uid = Convert.ToUInt32(value);
                                                        current.yycookie = Hex.toArray(arg).Buffer;
                                                        current.autotoken = ((text == null) ? "" : text);
                                                        current.isudblogin = true;
                                                    }
                                                    else
                                                    {
                                                        current.isudblogin = false;
                                                    }
                                                }
                                                catch
                                                {
                                                }
                                            }
                                            if (checkBox_1.Checked)
                                            {
                                                current.ishidedaili = true;
                                            }
                                            else
                                            {
                                                current.ishidedaili = false;
                                            }
                                            current.sid = rQaQnYbAnm;
                                            current.subid = uint_0;
                                            current.status = 1;
                                            current.joinstatus = 1;
                                            current.lastsendtime = DateTime.Now;
                                            current.ishunhejin = ckbhunhe.Checked;
                                            current.StartJoin();
                                            Thread.Sleep(int_1);
                                            continue;
                                        }
                                    }
                                    catch
                                    {
                                        current.status = 1;
                                        current.joinstatus = -1;
                                        continue;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
                catch
                {
                }
                Thread.Sleep(1000);
            }
        }

        [CompilerGenerated]
        private void method_29()
        {
            while (true)
            {
                try
                {
                    if (bool_0 || concurrentBag_1 == null || concurrentBag_1.Count == 0)
                    {
                        Thread.Sleep(3000);
                        continue;
                    }
                    IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                    {
                        if (p.loginstatus == 2 && p.joinstatus == -1)
                        {
                            return !p.isfenghao;
                        }
                        return false;
                    });
                    if (enumerable != null && enumerable.Count() > 0)
                    {
                        using (IEnumerator<MyUser1225> enumerator = enumerable.Reverse().GetEnumerator())
                        {
                            while (true)
                            {
                                if (enumerator.MoveNext())
                                {
                                    MyUser1225 current = enumerator.Current;
                                    try
                                    {
                                        while (yongjiobj_0.isyongji && yongjiobj_0.ctime.AddSeconds(10.0) > DateTime.Now && !ckbhunhe.Checked)
                                        {
                                            Thread.Sleep(1000);
                                        }
                                        yongjiobj_0.isyongji = false;
                                        if (!bool_0 && !(dateTime_0.AddMinutes(5.0) < DateTime.Now) && ((!checkBox_1.Checked && !checkBox_0.Checked) || list_1.Count != 0) && ((!ckbhttpurl.Checked && !ckbhttplocal.Checked) || (list_0 != null && list_0.Count != 0)))
                                        {
                                            if (ckbduoip.Checked)
                                            {
                                                if (list_3 != null && list_3.Count > 0)
                                                {
                                                    current.localip = list_3[current.index % list_3.Count];
                                                }
                                            }
                                            else
                                            {
                                                current.localip = "";
                                            }
                                            myip _myip = concurrentBag_1.ToList()[current.index % concurrentBag_1.Count];
                                            current.apip = _myip.ip;
                                            current.apport = _myip.ports[0];
                                            if (rdbpc.Checked && list_0.Count > 0 && (ckbhttpurl.Checked || ckbhttplocal.Checked))
                                            {
                                                current.pt = ProxyTypes.Https;
                                                current.daili = list_0[current.index % list_0.Count];
                                            }
                                            else if (!checkBox_1.Checked && !checkBox_0.Checked)
                                            {
                                                current.pt = ProxyTypes.None;
                                                current.daili = "";
                                            }
                                            else
                                            {
                                                current.pt = ProxyTypes.Socks5;
                                                current.daili = list_1[current.index % list_1.Count];
                                            }
                                            if (!current.isudblogin && current.logintype == 1)
                                            {
                                                try
                                                {
                                                    dynamic val = getpcuser(current);
                                                    if (val != null)
                                                    {
                                                        string value = (string)val.uid;
                                                        string username = (string)val.username;
                                                        string arg = (string)val.cookie;
                                                        string text = (string)val.at;
                                                        current.username = username;
                                                        current.uid = Convert.ToUInt32(value);
                                                        current.yycookie = Hex.toArray(arg).Buffer;
                                                        current.autotoken = ((text == null) ? "" : text);
                                                        current.isudblogin = true;
                                                    }
                                                    else
                                                    {
                                                        current.isudblogin = false;
                                                    }
                                                }
                                                catch
                                                {
                                                }
                                            }
                                            if (checkBox_1.Checked)
                                            {
                                                current.ishidedaili = true;
                                            }
                                            else
                                            {
                                                current.ishidedaili = false;
                                            }
                                            current.sid = rQaQnYbAnm;
                                            current.subid = uint_0;
                                            current.status = 1;
                                            current.joinstatus = 1;
                                            current.lastsendtime = DateTime.Now;
                                            current.ishunhejin = ckbhunhe.Checked;
                                            current.StartJoin();
                                            Thread.Sleep(int_1);
                                            continue;
                                        }
                                    }
                                    catch
                                    {
                                        current.status = 1;
                                        current.joinstatus = -1;
                                        continue;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
                catch
                {
                }
                Thread.Sleep(1000);
            }
        }

        [CompilerGenerated]
        private void method_30()
        {
            foreach (MyUser1225 item in from p in concurrentBag_0.Reverse()
                                        where !p.isfenghao
                                        select p)
            {
                try
                {
                    if (item.status == 2)
                    {
                        item.LeaveChanel();
                    }
                    item.istuichu = true;
                    item.heartbeat = 0;
                    item.status = 0;
                    item.joinstatus = 0;
                    item.mytrace = "";
                    item.currentflag = 10000;
                    item.isudblogin = false;
                    if (item.logintcp != null)
                    {
                        item.ZhuDongDK((rdomhelper.getrandom(0, 100) <= 50) ? (-1) : 0);
                    }
                }
                catch
                {
                }
                Thread.Sleep(15);
            }
        }

        [CompilerGenerated]
        private void method_shuahua()
        {
            while (true)
            {
                if (!bool_0)
                {
                    IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                    {
                        if (p.status == 2)
                        {
                            return p.isloginservice;
                        }
                        return false;
                    });
                    if (enumerable != null && enumerable.Count() > 0)
                    {
                        foreach (MyUser1225 item in enumerable)
                        {
                            if (bool_0 || !btn_tingzhishuahua.Enabled)
                            {
                                break;
                            }
                            try
                            {
                                Task.Factory.StartNew(delegate
                                {
                                    new MyUser1225();
                                    item.shuahua(uint.Parse(shuahuauid), beishuahuamingzi);
                                });
                            }
                            catch
                            {
                            }
                            Thread.Sleep(int_1);
                        }
                    }
                }
                if (!btn_tingzhishuahua.Enabled)
                {
                    break;
                }
                Thread.Sleep(3000);
            }
            if (!btn_tingzhishuahua.Enabled)
            {
                btn_tingzhishuahua.BeginInvoke(new MethodInvoker(method_songhua));
            }
        }

        [CompilerGenerated]
        private void method_311()
        {
            if (!bool_0)
            {
                IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                {
                    if (p.status == 2)
                    {
                        return p.isloginservice;
                    }
                    return false;
                });
                if (enumerable != null && enumerable.Count() > 0)
                {
                    foreach (MyUser1225 item in enumerable)
                    {
                        if (bool_0 || !tingzhizhibotongzhi.Enabled)
                        {
                            break;
                        }
                        try
                        {
                            Task.Factory.StartNew(delegate
                            {
                                new MyUser1225();
                                item.zhibotongzhi(uint.Parse(shuahuauid));
                            });
                        }
                        catch
                        {
                        }
                        Thread.Sleep(int_1);
                    }
                }
            }
            zhibotongzhi.BeginInvoke(new MethodInvoker(method_9999));
        }

        [CompilerGenerated]
        private void method_99999()
        {
            try
            {
                daka.Enabled = true;
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_9999()
        {
            try
            {
                zhibotongzhi.Enabled = true;
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_songhua()
        {
            try
            {
                btn_songhua.Enabled = true;
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_3111()
        {
            if (!bool_0)
            {
                IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                {
                    if (p.status == 2)
                    {
                        return p.isloginservice;
                    }
                    return false;
                });
                if (enumerable != null && enumerable.Count() > 0)
                {
                    foreach (MyUser1225 item in enumerable)
                    {
                        if (bool_0 || !tzdaka.Enabled)
                        {
                            break;
                        }
                        try
                        {
                            Task.Factory.StartNew(delegate
                            {
                                new MyUser1225();
                                item.daka2();
                            });
                        }
                        catch
                        {
                        }
                        Thread.Sleep(int_1);
                    }
                }
            }
            daka.BeginInvoke(new MethodInvoker(method_99999));
        }
        private void method_31()
        {
            foreach (MyUser1225 item in concurrentBag_0.Reverse())
            {
                try
                {
                    item.sid = rQaQnYbAnm;
                    item.subid = uint_0;
                    item.heartbeat = 0;
                    item.isskip = true;
                }
                catch
                {
                }
            }
            while (true)
            {
                IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                {
                    if (!p.isfenghao && p.isskip)
                    {
                        return p.status == 2;
                    }
                    return false;
                });
                if (enumerable != null && enumerable.Count() > 0)
                {
                    foreach (MyUser1225 item2 in enumerable.Reverse())
                    {
                        DateTime dateTime;
                        while (yongjiobj_0.isyongji)
                        {
                            dateTime = yongjiobj_0.ctime;
                            if (!(dateTime.AddSeconds(10.0) > DateTime.Now) || ckbhunhe.Checked)
                            {
                                break;
                            }
                            Thread.Sleep(1000);
                        }
                        yongjiobj_0.isyongji = false;
                        if (item2.isskip && item2.status == 2)
                        {
                            dateTime = item2.lastsendtime;
                            if (dateTime.AddSeconds(3.0) < DateTime.Now)
                            {
                                item2.Send_0BD0_0801();
                                Thread.Sleep(15);
                            }
                        }
                    }
                }
                if (enumerable == null || enumerable.Count() == 0)
                {
                    break;
                }
                Thread.Sleep(3000);
            }
            if (!btnqiehuan.Enabled && !bool_0)
            {
                btnqiehuan.BeginInvoke(new MethodInvoker(method_32));
            }
        }

        [CompilerGenerated]
        private void method_32()
        {
            try
            {
                btnqiehuan.Enabled = true;
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_33()
        {
            foreach (MyUser1225 item in (from p in concurrentBag_0
                                         where p.status == 2
                                         select p).Reverse())
            {
                try
                {
                    method_13(item);
                    Thread.Sleep(50);
                }
                catch
                {
                }
            }
            btnsuijixingbie.BeginInvoke(new MethodInvoker(method_34));
        }

        [CompilerGenerated]
        private void method_34()
        {
            try
            {
                btnsuijixingbie.Enabled = true;
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_35()
        {
            try
            {
                btndaorumajia.Enabled = true;
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_36()
        {
            try
            {
                btndaoruqianming.Enabled = true;
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_37()
        {
            try
            {
                btndaoruhanhua.Text = list_2.Count.ToString();
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void bMoQvhfFik()
        {
            foreach (MyUser1225 item in concurrentBag_0.Where(delegate (MyUser1225 uu)
            {
                if (uu.status >= 2)
                {
                    return uu.isskip;
                }
                return true;
            }))
            {
                if (item.status < 2 || item.isskip)
                {
                    try
                    {
                        if (item.logintype == 1)
                        {
                            logtool.delusercache_p(item.passport);
                        }
                        else
                        {
                            logtool.delusercache_w(item.passport);
                        }
                        item.isskip = false;
                        item.ZhuDongDK(0);
                        item.isupdate = false;
                        item.isudblogin = false;
                        item.send04d6 = 0;
                        item.tihaotime = DateTime.MinValue;
                    }
                    catch
                    {
                    }
                    Thread.Sleep(10);
                }
            }
            btnchonglian.BeginInvoke(new MethodInvoker(method_38));
        }

        [CompilerGenerated]
        private void method_38()
        {
            try
            {
                btnchonglian.Enabled = true;
            }
            catch
            {
            }
        }

        [CompilerGenerated]
        private void method_39()
        {
            try
            {
                foreach (MyUser1225 item in from p in concurrentBag_0
                                            where p.isupdate
                                            select p)
                {
                    item.isupdate = false;
                }
            }
            catch
            {
            }
        }


        public static string Between(string str, string leftstr, string rightstr)
        {
            int num = str.IndexOf(leftstr) + leftstr.Length;
            return str.Substring(num, str.IndexOf(rightstr, num) - num);
        }

        public string GetPostString(string url, string data)
        {
            try
            {
                byte[] bytes = Encoding.GetEncoding("utf-8").GetBytes(data);
                HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(url);
                obj.Method = "POST";
                obj.ContentType = "application/x-www-form-urlencoded";
                obj.ContentLength = bytes.Length;
                obj.Proxy = null;
                Stream requestStream = obj.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                using (StreamReader streamReader = new StreamReader(((HttpWebResponse)obj.GetResponse()).GetResponseStream(), Encoding.GetEncoding("utf-8")))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void huoquuid()
        {
            if (txt_shuahuauid.Text != "")
            {
                string text = Convert.ToInt64((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalMilliseconds).ToString();
                string s = text;
                byte[] bytes = Encoding.Default.GetBytes(s);
                bytes = new SHA1CryptoServiceProvider().ComputeHash(bytes);
                StringBuilder stringBuilder = new StringBuilder();
                byte[] array = bytes;
                byte[] array2 = array;
                foreach (byte b in array2)
                {
                    stringBuilder.AppendFormat("{0:x2}", b);
                }
                string postString = GetPostString("http://m.yy.com/zone/" + txt_shuahuauid.Text + "/getUserIdByAccount.action", "account=" + txt_shuahuauid.Text + "&uid=undefined&userMac=%7B%22m%22%3A%22" + stringBuilder.ToString() + "%22%2C%22t%22%3A" + text + "%7D");
                shuahuauid = Between(postString, "\"uid\":\"", "\"}");
                if (shuahuauid != "")
                {
                    //	beishuahuamingzi = beishuanicheng.Text;
                    //      if (beishuanicheng.Text == "")
                    {
                        beishuahuamingzi = " ";
                    }
                }
            }
        }

        private void btn_songhua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(shuahuasudu.Text.Trim(), out int_1))
            {
                shuahuasudu.Text = "500";
                int_1 = 500;
            }
            btn_songhua.Enabled = false;
            btn_tingzhishuahua.Enabled = true;
            huoquuid();
            Task.Factory.StartNew(method_shuahua);
        }

        private void btn_tingzhishuahua_Click(object sender, EventArgs e)
        {
            btn_songhua.Enabled = true;
            btn_tingzhishuahua.Enabled = false;
        }
        public string shuahuauid;
        public string beishuahuamingzi;

        private void timer_7_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Interlocked.Exchange(ref int_14, 1) == 0)
            {
                try
                {
                    if (!bool_0)
                    {
                        IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate (MyUser1225 p)
                        {
                            if (p.status == 2)
                            {
                                return p.isloginservice;
                            }
                            return false;
                        });
                        if (enumerable != null && enumerable.Count() > 0)
                        {
                            foreach (MyUser1225 item in enumerable)
                            {
                                if (bool_0)
                                {
                                    break;
                                }
                                try
                                {
                                    Task.Factory.StartNew(delegate
                                    {
                                        MyUser1225 myUser1225 = new MyUser1225();

                                        item.shuahua(int.Parse(shuahuauid), beishuahuamingzi);
                                    });
                                }
                                catch
                                {
                                }
                                Thread.Sleep(310);
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

        private void SetConfig()
        {
            //    btn_songhua.DataBindings.Add(new Binding("Enabled", ckbgongneng, "Checked"));
            //    btn_tingzhishuahua.DataBindings.Add(new Binding("Enabled", ckbgongneng, "Checked"));
            //    txt_shuahuauid.DataBindings.Add(new Binding("Enabled", ckbgongneng, "Checked"));

        }

        private void zhibotongzhi_Click(object sender, EventArgs e)
        {
            {
                huoquuid();
                tingzhizhibotongzhi.Enabled = true;
                zhibotongzhi.Enabled = false;
                if (!int.TryParse(shuahuasudu.Text.Trim(), out int_1))
                {
                    shuahuasudu.Text = "500";
                    int_1 = 500;
                }
                Task.Factory.StartNew(method_311);
            }
        }

        private void tingzhizhibotongzhi_Click(object sender, EventArgs e)
        {
            tingzhizhibotongzhi.Enabled = false;
            zhibotongzhi.Enabled = true;
        }

        private void daka_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(shuahuasudu.Text.Trim(), out int_1))
            {
                shuahuasudu.Text = "500";
                int_1 = 500;
            }
            tzdaka.Enabled = true;
            daka.Enabled = false;
            huoquuid();
            Task.Factory.StartNew(method_3111);
        }

        private void tzdaka_Click(object sender, EventArgs e)
        {
            tzdaka.Enabled = false;
            daka.Enabled = true;
        }
    }
}
