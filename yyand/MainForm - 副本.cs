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

		private Label lbldaoqi;

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

		private DataGridViewTextBoxColumn 序号;

		private DataGridViewTextBoxColumn 用户名;

		private DataGridViewTextBoxColumn 状态;

		private DataGridViewTextBoxColumn 当前频道;

		private DataGridViewTextBoxColumn CF;

		private DataGridViewTextBoxColumn 验证码;

		private DataGridViewTextBoxColumn 心跳;

		private DataGridViewTextBoxColumn CKI;

		private DataGridViewTextBoxColumn Trace;

		private DataGridViewTextBoxColumn 马甲;

		private DataGridViewTextBoxColumn 连接IP;

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
						int_4 = concurrentBag_0.Count(delegate(MyUser1225 p)
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
					int_0--;
					if (int_0 > 0)
					{
						;
					}
					string path = Application.StartupPath + "\\Help\\macinfo.txt";
					if (File.Exists(path))
					{
						checkinfo _checkinfo = JsonConvert.DeserializeObject<checkinfo>(MyEncrypt.AesDecryptor(File.ReadAllText(path)));
						if (_checkinfo != null && _checkinfo.mac == string_0 && _checkinfo.createtime.AddMinutes(5.0) > DateTime.Now)
						{
							dateTime_0 = DateTime.Now;
							int_0 = _checkinfo.minitues;
						}
					}
					if (int_0 > 0)
					{
						;
					}
					if (!(dateTime_0.AddHours(2.0) < DateTime.Now))
					{
						;
					}
					lbldaoqi.BeginInvoke(new MethodInvoker(method_22));
					lblauthtime.BeginInvoke(new MethodInvoker(method_23));
				}
				catch
				{
				}
				finally
				{
					Interlocked.Exchange(ref int_9, 0);
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
						IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate(MyUser1225 p)
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
						IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate(MyUser1225 p)
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
						IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate(MyUser1225 p)
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
						IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate(MyUser1225 p)
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
				string string_ = "http://118.89.226.148:8889/getstatus?sn=" + text;
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
						IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate(MyUser1225 p)
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

		public MainForm(int shengyu, DateTime checktime, bool xc = false)
		{
			try
			{
				if (checktime.AddMinutes(5.0) < DateTime.Now || checktime.AddMinutes(-5.0) > DateTime.Now)
				{
					Close();
					Environment.Exit(0);
				}
				if (Process.GetProcessesByName("战火辅助").ToList().Count == 0)
				{
					MessageBox.Show("战火辅助 未开启，不能打开软件！", "提示信息");
					Environment.Exit(0);
				}
				else if (Process.GetProcessesByName("战火识别").ToList().Count == 0)
				{
					MessageBox.Show("战火识别 未开启，不能打开软件！", "提示信息");
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
				string text3 = lblpath.Text = (lbldaoqi.Text = "");
				lblhulian.Text = "";
				groupBox8.Hide();
				groupBox9.Hide();
				panel1.Height += 40;
				string_0 = HardwareInfo.GetInfo();
				lbldaoqi.Text = string.Format("到期：{0}", timetool.getstr(int_0));
				try
				{
					lblver.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
					if (int_0 > 1440)
					{
						lbldaoqi.ForeColor = Color.Green;
					}
					else
					{
						lbldaoqi.ForeColor = Color.Red;
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
						lblhulian.Text = "监控中...";
						txtshanghao.Text = "http://118.89.226.148:8889/shanghao?sn=" + text;
						txtxiahao.Text = "http://118.89.226.148:8889/xiahao?sn=" + text;
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
				if (!checkBox.Checked)
				{
					CheckBox checkBox5 = ckbqutubiao;
					CheckBox checkBox6 = ckbhanhua;
					flag5 = (ckbxianche.Checked = checkBox.Checked);
					enabled = (checkBox6.Checked = flag5);
					checkBox5.Checked = enabled;
					list_2.Clear();
					btndaoruhanhua.Text = "导入";
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
								IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate(MyUser1225 p)
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
								IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate(MyUser1225 p)
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(战火协议.MainForm));
			panel1 = new System.Windows.Forms.Panel();
			mygrid = new System.Windows.Forms.DataGridView();
			groupBox1 = new System.Windows.Forms.GroupBox();
			rdbweb = new System.Windows.Forms.RadioButton();
			rdbpc = new System.Windows.Forms.RadioButton();
			groupBox2 = new System.Windows.Forms.GroupBox();
			lblhulian = new System.Windows.Forms.Label();
			ckbhulian = new System.Windows.Forms.CheckBox();
			groupBox3 = new System.Windows.Forms.GroupBox();
			btnresetsudu = new System.Windows.Forms.Button();
			txtfeng = new System.Windows.Forms.TextBox();
			txtsudu = new System.Windows.Forms.TextBox();
			label5 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			txtjin = new System.Windows.Forms.TextBox();
			sfnEqZowcK = new System.Windows.Forms.TextBox();
			label6 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			txtzong = new System.Windows.Forms.TextBox();
			txtsid = new System.Windows.Forms.TextBox();
			label7 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			groupBox4 = new System.Windows.Forms.GroupBox();
			ckbhttplocal = new System.Windows.Forms.CheckBox();
			ckbhttpurl = new System.Windows.Forms.CheckBox();
			checkBox_0 = new System.Windows.Forms.CheckBox();
			checkBox_1 = new System.Windows.Forms.CheckBox();
			groupBox5 = new System.Windows.Forms.GroupBox();
			txthanhuajiange = new System.Windows.Forms.TextBox();
			label8 = new System.Windows.Forms.Label();
			btndaoruhanhua = new System.Windows.Forms.Button();
			ckbhanhua = new System.Windows.Forms.CheckBox();
			ckbxianche = new System.Windows.Forms.CheckBox();
			ckbqutubiao = new System.Windows.Forms.CheckBox();
			ckbgongneng = new System.Windows.Forms.CheckBox();
			groupBox6 = new System.Windows.Forms.GroupBox();
			ckbhunhe = new System.Windows.Forms.CheckBox();
			btntingzhixiugai = new System.Windows.Forms.Button();
			btnchonglian = new System.Windows.Forms.Button();
			btnsuijixingbie = new System.Windows.Forms.Button();
			btndaoruqianming = new System.Windows.Forms.Button();
			btndaorumajia = new System.Windows.Forms.Button();
			btnqiehuan = new System.Windows.Forms.Button();
			btntuichu = new System.Windows.Forms.Button();
			btnjoin = new System.Windows.Forms.Button();
			btndaochu = new System.Windows.Forms.Button();
			btndaoru = new System.Windows.Forms.Button();
			groupBox7 = new System.Windows.Forms.GroupBox();
			label12 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			xhfen = new System.Windows.Forms.NumericUpDown();
			xhshi = new System.Windows.Forms.NumericUpDown();
			xhtian = new System.Windows.Forms.NumericUpDown();
			label11 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			shfen = new System.Windows.Forms.NumericUpDown();
			shshi = new System.Windows.Forms.NumericUpDown();
			shtian = new System.Windows.Forms.NumericUpDown();
			ckbdsxh = new System.Windows.Forms.CheckBox();
			ckbdssh = new System.Windows.Forms.CheckBox();
			groupBox8 = new System.Windows.Forms.GroupBox();
			txtshanghao = new System.Windows.Forms.TextBox();
			groupBox9 = new System.Windows.Forms.GroupBox();
			txtxiahao = new System.Windows.Forms.TextBox();
			groupBox_0 = new System.Windows.Forms.GroupBox();
			ckbduoip = new System.Windows.Forms.CheckBox();
			lblshijizaixian = new System.Windows.Forms.Label();
			lblauthtime = new System.Windows.Forms.Label();
			lbllastbuhao = new System.Windows.Forms.Label();
			panel2 = new System.Windows.Forms.Panel();
			lblver = new System.Windows.Forms.Label();
			lbldaoqi = new System.Windows.Forms.Label();
			lblpath = new System.Windows.Forms.Label();
			openFileDialog_0 = new System.Windows.Forms.OpenFileDialog();
			saveFileDialog_0 = new System.Windows.Forms.SaveFileDialog();
			groupBox_1 = new System.Windows.Forms.GroupBox();
			groupBox_2 = new System.Windows.Forms.GroupBox();
			txtzuishaoshuliang = new System.Windows.Forms.TextBox();
			ckbzhinenghuanhao = new System.Windows.Forms.CheckBox();
			序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			当前频道 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			CF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			验证码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			心跳 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			CKI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Trace = new System.Windows.Forms.DataGridViewTextBoxColumn();
			马甲 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			连接IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)mygrid).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox5.SuspendLayout();
			groupBox6.SuspendLayout();
			groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)xhfen).BeginInit();
			((System.ComponentModel.ISupportInitialize)xhshi).BeginInit();
			((System.ComponentModel.ISupportInitialize)xhtian).BeginInit();
			((System.ComponentModel.ISupportInitialize)shfen).BeginInit();
			((System.ComponentModel.ISupportInitialize)shshi).BeginInit();
			((System.ComponentModel.ISupportInitialize)shtian).BeginInit();
			groupBox8.SuspendLayout();
			groupBox9.SuspendLayout();
			groupBox_0.SuspendLayout();
			panel2.SuspendLayout();
			groupBox_1.SuspendLayout();
			groupBox_2.SuspendLayout();
			SuspendLayout();
			panel1.Controls.Add(mygrid);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(703, 461);
			panel1.TabIndex = 0;
			mygrid.AllowUserToAddRows = false;
			mygrid.AllowUserToDeleteRows = false;
			mygrid.BackgroundColor = System.Drawing.SystemColors.Window;
			mygrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			mygrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			mygrid.ColumnHeadersHeight = 20;
			mygrid.Columns.AddRange(序号, 用户名, 状态, 当前频道, CF, 验证码, 心跳, CKI, Trace, 马甲, 连接IP);
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			mygrid.DefaultCellStyle = dataGridViewCellStyle2;
			mygrid.Dock = System.Windows.Forms.DockStyle.Fill;
			mygrid.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
			mygrid.Location = new System.Drawing.Point(0, 0);
			mygrid.Name = "mygrid";
			mygrid.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			mygrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			mygrid.RowHeadersVisible = false;
			mygrid.RowTemplate.Height = 18;
			mygrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			mygrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			mygrid.Size = new System.Drawing.Size(703, 461);
			mygrid.TabIndex = 4;
			groupBox1.Controls.Add(rdbweb);
			groupBox1.Controls.Add(rdbpc);
			groupBox1.Location = new System.Drawing.Point(701, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(90, 38);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "版本选择";
			rdbweb.AutoSize = true;
			rdbweb.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			rdbweb.Location = new System.Drawing.Point(44, 16);
			rdbweb.Name = "rdbweb";
			rdbweb.Size = new System.Drawing.Size(47, 16);
			rdbweb.TabIndex = 2;
			rdbweb.Text = "网页";
			rdbweb.UseVisualStyleBackColor = true;
			rdbweb.CheckedChanged += new System.EventHandler(rdbweb_CheckedChanged);
			rdbpc.AutoSize = true;
			rdbpc.Checked = true;
			rdbpc.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			rdbpc.Location = new System.Drawing.Point(7, 16);
			rdbpc.Name = "rdbpc";
			rdbpc.Size = new System.Drawing.Size(35, 16);
			rdbpc.TabIndex = 0;
			rdbpc.TabStop = true;
			rdbpc.Text = "PC";
			rdbpc.UseVisualStyleBackColor = true;
			rdbpc.CheckedChanged += new System.EventHandler(rdbpc_CheckedChanged);
			groupBox2.Controls.Add(lblhulian);
			groupBox2.Controls.Add(ckbhulian);
			groupBox2.Location = new System.Drawing.Point(790, 0);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(122, 38);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "互联";
			lblhulian.AutoSize = true;
			lblhulian.ForeColor = System.Drawing.Color.Green;
			lblhulian.Location = new System.Drawing.Point(53, 18);
			lblhulian.Name = "lblhulian";
			lblhulian.Size = new System.Drawing.Size(41, 12);
			lblhulian.TabIndex = 1;
			lblhulian.Text = "label1";
			ckbhulian.AutoSize = true;
			ckbhulian.Location = new System.Drawing.Point(5, 16);
			ckbhulian.Name = "ckbhulian";
			ckbhulian.Size = new System.Drawing.Size(48, 16);
			ckbhulian.TabIndex = 0;
			ckbhulian.Text = "开启";
			ckbhulian.UseVisualStyleBackColor = true;
			ckbhulian.CheckedChanged += new System.EventHandler(ckbhulian_CheckedChanged);
			ckbhulian.Click += new System.EventHandler(ckbhulian_Click);
			groupBox3.Controls.Add(btnresetsudu);
			groupBox3.Controls.Add(txtfeng);
			groupBox3.Controls.Add(txtsudu);
			groupBox3.Controls.Add(label5);
			groupBox3.Controls.Add(label4);
			groupBox3.Controls.Add(txtjin);
			groupBox3.Controls.Add(sfnEqZowcK);
			groupBox3.Controls.Add(label6);
			groupBox3.Controls.Add(label3);
			groupBox3.Controls.Add(txtzong);
			groupBox3.Controls.Add(txtsid);
			groupBox3.Controls.Add(label7);
			groupBox3.Controls.Add(label2);
			groupBox3.Controls.Add(label1);
			groupBox3.Location = new System.Drawing.Point(701, 38);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new System.Drawing.Size(211, 92);
			groupBox3.TabIndex = 3;
			groupBox3.TabStop = false;
			groupBox3.Text = "频道信息";
			btnresetsudu.Location = new System.Drawing.Point(77, 65);
			btnresetsudu.Name = "btnresetsudu";
			btnresetsudu.Size = new System.Drawing.Size(40, 23);
			btnresetsudu.TabIndex = 13;
			btnresetsudu.Text = "重置";
			btnresetsudu.UseVisualStyleBackColor = true;
			btnresetsudu.Click += new System.EventHandler(btnresetsudu_Click);
			txtfeng.Enabled = false;
			txtfeng.Location = new System.Drawing.Point(147, 66);
			txtfeng.Name = "txtfeng";
			txtfeng.Size = new System.Drawing.Size(60, 21);
			txtfeng.TabIndex = 12;
			txtsudu.Location = new System.Drawing.Point(28, 66);
			txtsudu.Name = "txtsudu";
			txtsudu.Size = new System.Drawing.Size(41, 21);
			txtsudu.TabIndex = 6;
			txtsudu.Text = "500";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(127, 70);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(17, 12);
			label5.TabIndex = 11;
			label5.Text = "封";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(7, 69);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(17, 12);
			label4.TabIndex = 5;
			label4.Text = "速";
			txtjin.Enabled = false;
			txtjin.Location = new System.Drawing.Point(146, 42);
			txtjin.Name = "txtjin";
			txtjin.Size = new System.Drawing.Size(60, 21);
			txtjin.TabIndex = 10;
			sfnEqZowcK.Location = new System.Drawing.Point(27, 42);
			sfnEqZowcK.Name = "txtsubid";
			sfnEqZowcK.Size = new System.Drawing.Size(90, 21);
			sfnEqZowcK.TabIndex = 4;
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(126, 46);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(17, 12);
			label6.TabIndex = 9;
			label6.Text = "进";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(6, 45);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(17, 12);
			label3.TabIndex = 3;
			label3.Text = "子";
			txtzong.Enabled = false;
			txtzong.Location = new System.Drawing.Point(146, 18);
			txtzong.Name = "txtzong";
			txtzong.Size = new System.Drawing.Size(60, 21);
			txtzong.TabIndex = 8;
			txtsid.Location = new System.Drawing.Point(27, 18);
			txtsid.Name = "txtsid";
			txtsid.Size = new System.Drawing.Size(90, 21);
			txtsid.TabIndex = 2;
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(126, 22);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(17, 12);
			label7.TabIndex = 7;
			label7.Text = "总";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(6, 21);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(17, 12);
			label2.TabIndex = 1;
			label2.Text = "主";
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(6, 21);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(0, 12);
			label1.TabIndex = 0;
			groupBox4.Controls.Add(ckbhttplocal);
			groupBox4.Controls.Add(ckbhttpurl);
			groupBox4.Location = new System.Drawing.Point(702, 131);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new System.Drawing.Size(101, 40);
			groupBox4.TabIndex = 4;
			groupBox4.TabStop = false;
			groupBox4.Text = "HTTP代理";
			ckbhttplocal.AutoSize = true;
			ckbhttplocal.Location = new System.Drawing.Point(52, 18);
			ckbhttplocal.Name = "ckbhttplocal";
			ckbhttplocal.Size = new System.Drawing.Size(48, 16);
			ckbhttplocal.TabIndex = 2;
			ckbhttplocal.Text = "本地";
			ckbhttplocal.UseVisualStyleBackColor = true;
			ckbhttplocal.CheckedChanged += new System.EventHandler(ckbhttplocal_CheckedChanged);
			ckbhttpurl.AutoSize = true;
			ckbhttpurl.Location = new System.Drawing.Point(6, 18);
			ckbhttpurl.Name = "ckbhttpurl";
			ckbhttpurl.Size = new System.Drawing.Size(42, 16);
			ckbhttpurl.TabIndex = 1;
			ckbhttpurl.Text = "URL";
			ckbhttpurl.UseVisualStyleBackColor = true;
			ckbhttpurl.CheckedChanged += new System.EventHandler(ckbhttpurl_CheckedChanged);
			checkBox_0.AutoSize = true;
			checkBox_0.Location = new System.Drawing.Point(62, 18);
			checkBox_0.Name = "ckbs5local";
			checkBox_0.Size = new System.Drawing.Size(36, 16);
			checkBox_0.TabIndex = 5;
			checkBox_0.Text = "S5";
			checkBox_0.UseVisualStyleBackColor = true;
			checkBox_0.CheckedChanged += new System.EventHandler(checkBox_0_CheckedChanged);
			checkBox_1.AutoSize = true;
			checkBox_1.Location = new System.Drawing.Point(4, 18);
			checkBox_1.Name = "ckbs5spoof";
			checkBox_1.Size = new System.Drawing.Size(54, 16);
			checkBox_1.TabIndex = 5;
			checkBox_1.Text = "spoof";
			checkBox_1.UseVisualStyleBackColor = true;
			checkBox_1.CheckedChanged += new System.EventHandler(checkBox_1_CheckedChanged);
			groupBox5.Controls.Add(txthanhuajiange);
			groupBox5.Controls.Add(label8);
			groupBox5.Controls.Add(btndaoruhanhua);
			groupBox5.Controls.Add(ckbhanhua);
			groupBox5.Controls.Add(ckbxianche);
			groupBox5.Controls.Add(ckbqutubiao);
			groupBox5.Controls.Add(ckbgongneng);
			groupBox5.Location = new System.Drawing.Point(702, 171);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new System.Drawing.Size(210, 67);
			groupBox5.TabIndex = 5;
			groupBox5.TabStop = false;
			groupBox5.Text = "扩展功能";
			txthanhuajiange.Enabled = false;
			txthanhuajiange.Location = new System.Drawing.Point(163, 39);
			txthanhuajiange.Name = "txthanhuajiange";
			txthanhuajiange.Size = new System.Drawing.Size(45, 21);
			txthanhuajiange.TabIndex = 8;
			txthanhuajiange.Text = "5000";
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(110, 44);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(53, 12);
			label8.TabIndex = 7;
			label8.Text = "喊话间隔";
			btndaoruhanhua.Enabled = false;
			btndaoruhanhua.Location = new System.Drawing.Point(56, 38);
			btndaoruhanhua.Name = "btndaoruhanhua";
			btndaoruhanhua.Size = new System.Drawing.Size(50, 23);
			btndaoruhanhua.TabIndex = 6;
			btndaoruhanhua.Text = "导入";
			btndaoruhanhua.UseVisualStyleBackColor = true;
			btndaoruhanhua.Click += new System.EventHandler(btndaoruhanhua_Click);
			ckbhanhua.AutoSize = true;
			ckbhanhua.Enabled = false;
			ckbhanhua.Location = new System.Drawing.Point(8, 42);
			ckbhanhua.Name = "ckbhanhua";
			ckbhanhua.Size = new System.Drawing.Size(48, 16);
			ckbhanhua.TabIndex = 5;
			ckbhanhua.Text = "喊话";
			ckbhanhua.UseVisualStyleBackColor = true;
			ckbhanhua.CheckedChanged += new System.EventHandler(ckbhanhua_CheckedChanged);
			ckbxianche.AutoSize = true;
			ckbxianche.Enabled = false;
			ckbxianche.Location = new System.Drawing.Point(150, 17);
			ckbxianche.Name = "ckbxianche";
			ckbxianche.Size = new System.Drawing.Size(48, 16);
			ckbxianche.TabIndex = 4;
			ckbxianche.Text = "显车";
			ckbxianche.UseVisualStyleBackColor = true;
			ckbqutubiao.AutoSize = true;
			ckbqutubiao.Enabled = false;
			ckbqutubiao.Location = new System.Drawing.Point(82, 17);
			ckbqutubiao.Name = "ckbqutubiao";
			ckbqutubiao.Size = new System.Drawing.Size(60, 16);
			ckbqutubiao.TabIndex = 3;
			ckbqutubiao.Text = "去图标";
			ckbqutubiao.UseVisualStyleBackColor = true;
			ckbgongneng.AutoSize = true;
			ckbgongneng.ForeColor = System.Drawing.Color.DarkRed;
			ckbgongneng.Location = new System.Drawing.Point(8, 17);
			ckbgongneng.Name = "ckbgongneng";
			ckbgongneng.Size = new System.Drawing.Size(72, 16);
			ckbgongneng.TabIndex = 2;
			ckbgongneng.Text = "功能开启";
			ckbgongneng.UseVisualStyleBackColor = true;
			ckbgongneng.CheckedChanged += new System.EventHandler(ckbgongneng_CheckedChanged);
			groupBox6.Controls.Add(ckbhunhe);
			groupBox6.Controls.Add(btntingzhixiugai);
			groupBox6.Controls.Add(btnchonglian);
			groupBox6.Controls.Add(btnsuijixingbie);
			groupBox6.Controls.Add(btndaoruqianming);
			groupBox6.Controls.Add(btndaorumajia);
			groupBox6.Controls.Add(btnqiehuan);
			groupBox6.Controls.Add(btntuichu);
			groupBox6.Controls.Add(btnjoin);
			groupBox6.Controls.Add(btndaochu);
			groupBox6.Controls.Add(btndaoru);
			groupBox6.Location = new System.Drawing.Point(702, 240);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new System.Drawing.Size(210, 150);
			groupBox6.TabIndex = 6;
			groupBox6.TabStop = false;
			groupBox6.Text = "控制";
			ckbhunhe.AutoSize = true;
			ckbhunhe.Location = new System.Drawing.Point(143, 122);
			ckbhunhe.Name = "ckbhunhe";
			ckbhunhe.Size = new System.Drawing.Size(60, 16);
			ckbhunhe.TabIndex = 21;
			ckbhunhe.Text = "混合进";
			ckbhunhe.UseVisualStyleBackColor = true;
			btntingzhixiugai.Location = new System.Drawing.Point(142, 48);
			btntingzhixiugai.Name = "btntingzhixiugai";
			btntingzhixiugai.Size = new System.Drawing.Size(65, 30);
			btntingzhixiugai.TabIndex = 20;
			btntingzhixiugai.Text = "停止修改";
			btntingzhixiugai.UseVisualStyleBackColor = true;
			btntingzhixiugai.Click += new System.EventHandler(btntingzhixiugai_Click);
			btnchonglian.Location = new System.Drawing.Point(142, 15);
			btnchonglian.Name = "btnchonglian";
			btnchonglian.Size = new System.Drawing.Size(65, 30);
			btnchonglian.TabIndex = 19;
			btnchonglian.Text = "重连";
			btnchonglian.UseVisualStyleBackColor = true;
			btnchonglian.Click += new System.EventHandler(btnchonglian_Click);
			btnsuijixingbie.Enabled = false;
			btnsuijixingbie.Location = new System.Drawing.Point(74, 114);
			btnsuijixingbie.Name = "btnsuijixingbie";
			btnsuijixingbie.Size = new System.Drawing.Size(65, 30);
			btnsuijixingbie.TabIndex = 18;
			btnsuijixingbie.Text = "随机性别";
			btnsuijixingbie.UseVisualStyleBackColor = true;
			btnsuijixingbie.Click += new System.EventHandler(btnsuijixingbie_Click);
			btndaoruqianming.Enabled = false;
			btndaoruqianming.Location = new System.Drawing.Point(74, 81);
			btndaoruqianming.Name = "btndaoruqianming";
			btndaoruqianming.Size = new System.Drawing.Size(65, 30);
			btndaoruqianming.TabIndex = 17;
			btndaoruqianming.Text = "导入签名";
			btndaoruqianming.UseVisualStyleBackColor = true;
			btndaoruqianming.Click += new System.EventHandler(btndaoruqianming_Click);
			btndaorumajia.Enabled = false;
			btndaorumajia.Location = new System.Drawing.Point(74, 48);
			btndaorumajia.Name = "btndaorumajia";
			btndaorumajia.Size = new System.Drawing.Size(65, 30);
			btndaorumajia.TabIndex = 15;
			btndaorumajia.Text = "导入马甲";
			btndaorumajia.UseVisualStyleBackColor = true;
			btndaorumajia.Click += new System.EventHandler(btndaorumajia_Click);
			btnqiehuan.Enabled = false;
			btnqiehuan.Location = new System.Drawing.Point(6, 81);
			btnqiehuan.Name = "btnqiehuan";
			btnqiehuan.Size = new System.Drawing.Size(65, 30);
			btnqiehuan.TabIndex = 14;
			btnqiehuan.Text = "切换频道";
			btnqiehuan.UseVisualStyleBackColor = true;
			btnqiehuan.Click += new System.EventHandler(btnqiehuan_Click);
			btntuichu.Enabled = false;
			btntuichu.Location = new System.Drawing.Point(6, 114);
			btntuichu.Name = "btntuichu";
			btntuichu.Size = new System.Drawing.Size(65, 30);
			btntuichu.TabIndex = 13;
			btntuichu.Text = "退出频道";
			btntuichu.UseVisualStyleBackColor = true;
			btntuichu.Click += new System.EventHandler(btntuichu_Click);
			btnjoin.Location = new System.Drawing.Point(6, 48);
			btnjoin.Name = "btnjoin";
			btnjoin.Size = new System.Drawing.Size(65, 30);
			btnjoin.TabIndex = 12;
			btnjoin.Text = "进入频道";
			btnjoin.UseVisualStyleBackColor = true;
			btnjoin.Click += new System.EventHandler(btnjoin_Click);
			btndaochu.Location = new System.Drawing.Point(74, 15);
			btndaochu.Name = "btndaochu";
			btndaochu.Size = new System.Drawing.Size(65, 30);
			btndaochu.TabIndex = 11;
			btndaochu.Text = "导出用户";
			btndaochu.UseVisualStyleBackColor = true;
			btndaochu.Click += new System.EventHandler(btndaochu_Click);
			btndaoru.Location = new System.Drawing.Point(6, 15);
			btndaoru.Name = "btndaoru";
			btndaoru.Size = new System.Drawing.Size(65, 30);
			btndaoru.TabIndex = 10;
			btndaoru.Text = "导入用户";
			btndaoru.UseVisualStyleBackColor = true;
			btndaoru.Click += new System.EventHandler(btndaoru_Click);
			groupBox7.Controls.Add(label12);
			groupBox7.Controls.Add(label13);
			groupBox7.Controls.Add(label14);
			groupBox7.Controls.Add(xhfen);
			groupBox7.Controls.Add(xhshi);
			groupBox7.Controls.Add(xhtian);
			groupBox7.Controls.Add(label11);
			groupBox7.Controls.Add(label10);
			groupBox7.Controls.Add(label9);
			groupBox7.Controls.Add(shfen);
			groupBox7.Controls.Add(shshi);
			groupBox7.Controls.Add(shtian);
			groupBox7.Controls.Add(ckbdsxh);
			groupBox7.Controls.Add(ckbdssh);
			groupBox7.Location = new System.Drawing.Point(702, 392);
			groupBox7.Name = "groupBox7";
			groupBox7.Size = new System.Drawing.Size(210, 69);
			groupBox7.TabIndex = 7;
			groupBox7.TabStop = false;
			groupBox7.Text = "定时上下号";
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(191, 46);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(17, 12);
			label12.TabIndex = 20;
			label12.Text = "分";
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(136, 46);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(17, 12);
			label13.TabIndex = 19;
			label13.Text = "时";
			label14.AutoSize = true;
			label14.Location = new System.Drawing.Point(82, 46);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(17, 12);
			label14.TabIndex = 18;
			label14.Text = "天";
			xhfen.Location = new System.Drawing.Point(154, 41);
			xhfen.Maximum = new decimal(new int[4]
			{
				59,
				0,
				0,
				0
			});
			xhfen.Name = "xhfen";
			xhfen.Size = new System.Drawing.Size(35, 21);
			xhfen.TabIndex = 17;
			xhshi.Location = new System.Drawing.Point(100, 41);
			xhshi.Maximum = new decimal(new int[4]
			{
				23,
				0,
				0,
				0
			});
			xhshi.Name = "xhshi";
			xhshi.Size = new System.Drawing.Size(35, 21);
			xhshi.TabIndex = 16;
			xhtian.Location = new System.Drawing.Point(40, 41);
			xhtian.Maximum = new decimal(new int[4]
			{
				999,
				0,
				0,
				0
			});
			xhtian.Name = "xhtian";
			xhtian.Size = new System.Drawing.Size(40, 21);
			xhtian.TabIndex = 15;
			xhtian.Value = new decimal(new int[4]
			{
				30,
				0,
				0,
				0
			});
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(191, 21);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(17, 12);
			label11.TabIndex = 14;
			label11.Text = "分";
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(136, 21);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(17, 12);
			label10.TabIndex = 13;
			label10.Text = "时";
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(82, 21);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(17, 12);
			label9.TabIndex = 12;
			label9.Text = "天";
			shfen.Location = new System.Drawing.Point(154, 16);
			shfen.Maximum = new decimal(new int[4]
			{
				59,
				0,
				0,
				0
			});
			shfen.Name = "shfen";
			shfen.Size = new System.Drawing.Size(35, 21);
			shfen.TabIndex = 11;
			shshi.Location = new System.Drawing.Point(100, 16);
			shshi.Maximum = new decimal(new int[4]
			{
				23,
				0,
				0,
				0
			});
			shshi.Name = "shshi";
			shshi.Size = new System.Drawing.Size(35, 21);
			shshi.TabIndex = 10;
			shtian.Location = new System.Drawing.Point(40, 16);
			shtian.Maximum = new decimal(new int[4]
			{
				999,
				0,
				0,
				0
			});
			shtian.Name = "shtian";
			shtian.Size = new System.Drawing.Size(40, 21);
			shtian.TabIndex = 9;
			ckbdsxh.AutoSize = true;
			ckbdsxh.Location = new System.Drawing.Point(5, 44);
			ckbdsxh.Name = "ckbdsxh";
			ckbdsxh.Size = new System.Drawing.Size(36, 16);
			ckbdsxh.TabIndex = 8;
			ckbdsxh.Text = "下";
			ckbdsxh.UseVisualStyleBackColor = true;
			ckbdsxh.CheckedChanged += new System.EventHandler(ckbdsxh_CheckedChanged);
			ckbdsxh.Click += new System.EventHandler(ckbdsxh_Click);
			ckbdssh.AutoSize = true;
			ckbdssh.Location = new System.Drawing.Point(5, 19);
			ckbdssh.Name = "ckbdssh";
			ckbdssh.Size = new System.Drawing.Size(36, 16);
			ckbdssh.TabIndex = 6;
			ckbdssh.Text = "上";
			ckbdssh.UseVisualStyleBackColor = true;
			ckbdssh.CheckedChanged += new System.EventHandler(ckbdssh_CheckedChanged);
			groupBox8.Controls.Add(txtshanghao);
			groupBox8.Location = new System.Drawing.Point(0, 465);
			groupBox8.Name = "groupBox8";
			groupBox8.Size = new System.Drawing.Size(350, 40);
			groupBox8.TabIndex = 8;
			groupBox8.TabStop = false;
			groupBox8.Text = "上号链接";
			txtshanghao.Location = new System.Drawing.Point(6, 13);
			txtshanghao.Name = "txtshanghao";
			txtshanghao.Size = new System.Drawing.Size(338, 21);
			txtshanghao.TabIndex = 0;
			groupBox9.Controls.Add(txtxiahao);
			groupBox9.Location = new System.Drawing.Point(350, 465);
			groupBox9.Name = "groupBox9";
			groupBox9.Size = new System.Drawing.Size(350, 40);
			groupBox9.TabIndex = 9;
			groupBox9.TabStop = false;
			groupBox9.Text = "下号链接";
			txtxiahao.Location = new System.Drawing.Point(6, 13);
			txtxiahao.Name = "txtxiahao";
			txtxiahao.Size = new System.Drawing.Size(338, 21);
			txtxiahao.TabIndex = 1;
			groupBox_0.Controls.Add(ckbduoip);
			groupBox_0.Controls.Add(lblshijizaixian);
			groupBox_0.Location = new System.Drawing.Point(702, 465);
			groupBox_0.Name = "groupBox10";
			groupBox_0.Size = new System.Drawing.Size(101, 40);
			groupBox_0.TabIndex = 10;
			groupBox_0.TabStop = false;
			groupBox_0.Text = "监控";
			ckbduoip.AutoSize = true;
			ckbduoip.Checked = true;
			ckbduoip.CheckState = System.Windows.Forms.CheckState.Checked;
			ckbduoip.Location = new System.Drawing.Point(4, 19);
			ckbduoip.Name = "ckbduoip";
			ckbduoip.Size = new System.Drawing.Size(48, 16);
			ckbduoip.TabIndex = 6;
			ckbduoip.Text = "多IP";
			ckbduoip.UseVisualStyleBackColor = true;
			lblshijizaixian.AutoSize = true;
			lblshijizaixian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			lblshijizaixian.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			lblshijizaixian.ForeColor = System.Drawing.Color.DarkGreen;
			lblshijizaixian.Location = new System.Drawing.Point(53, 19);
			lblshijizaixian.Name = "lblshijizaixian";
			lblshijizaixian.Size = new System.Drawing.Size(14, 14);
			lblshijizaixian.TabIndex = 3;
			lblshijizaixian.Text = "0";
			lblauthtime.AutoSize = true;
			lblauthtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			lblauthtime.Location = new System.Drawing.Point(610, 8);
			lblauthtime.Name = "lblauthtime";
			lblauthtime.Size = new System.Drawing.Size(37, 14);
			lblauthtime.TabIndex = 7;
			lblauthtime.Text = "00:00";
			lbllastbuhao.AutoSize = true;
			lbllastbuhao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			lbllastbuhao.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			lbllastbuhao.ForeColor = System.Drawing.Color.Black;
			lbllastbuhao.Location = new System.Drawing.Point(707, 8);
			lbllastbuhao.Name = "lbllastbuhao";
			lbllastbuhao.Size = new System.Drawing.Size(13, 14);
			lbllastbuhao.TabIndex = 5;
			lbllastbuhao.Text = "0";
			panel2.Controls.Add(lblauthtime);
			panel2.Controls.Add(lbllastbuhao);
			panel2.Controls.Add(lblver);
			panel2.Controls.Add(lbldaoqi);
			panel2.Controls.Add(lblpath);
			panel2.Location = new System.Drawing.Point(0, 506);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(912, 26);
			panel2.TabIndex = 11;
			lblver.AutoSize = true;
			lblver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			lblver.Location = new System.Drawing.Point(650, 8);
			lblver.Name = "lblver";
			lblver.Size = new System.Drawing.Size(55, 14);
			lblver.TabIndex = 2;
			lblver.Text = "1.16.0.2";
			lbldaoqi.AutoSize = true;
			lbldaoqi.Dock = System.Windows.Forms.DockStyle.Right;
			lbldaoqi.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
			lbldaoqi.ForeColor = System.Drawing.Color.Black;
			lbldaoqi.Location = new System.Drawing.Point(858, 0);
			lbldaoqi.Name = "lbldaoqi";
			lbldaoqi.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			lbldaoqi.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lbldaoqi.Size = new System.Drawing.Size(54, 20);
			lbldaoqi.TabIndex = 1;
			lbldaoqi.Text = "label10";
			lblpath.AutoSize = true;
			lblpath.Location = new System.Drawing.Point(4, 7);
			lblpath.Name = "lblpath";
			lblpath.Size = new System.Drawing.Size(41, 12);
			lblpath.TabIndex = 0;
			lblpath.Text = "label9";
			openFileDialog_0.FileName = "openFileDialog1";
			groupBox_1.Controls.Add(checkBox_0);
			groupBox_1.Controls.Add(checkBox_1);
			groupBox_1.Location = new System.Drawing.Point(803, 131);
			groupBox_1.Name = "groupBox11";
			groupBox_1.Size = new System.Drawing.Size(109, 40);
			groupBox_1.TabIndex = 6;
			groupBox_1.TabStop = false;
			groupBox_1.Text = "FF";
			groupBox_2.Controls.Add(txtzuishaoshuliang);
			groupBox_2.Controls.Add(ckbzhinenghuanhao);
			groupBox_2.Location = new System.Drawing.Point(806, 465);
			groupBox_2.Name = "groupBox12";
			groupBox_2.Size = new System.Drawing.Size(106, 40);
			groupBox_2.TabIndex = 12;
			groupBox_2.TabStop = false;
			groupBox_2.Text = "智能换号";
			txtzuishaoshuliang.Enabled = false;
			txtzuishaoshuliang.Location = new System.Drawing.Point(42, 14);
			txtzuishaoshuliang.Name = "txtzuishaoshuliang";
			txtzuishaoshuliang.Size = new System.Drawing.Size(56, 21);
			txtzuishaoshuliang.TabIndex = 7;
			txtzuishaoshuliang.Text = "0";
			ckbzhinenghuanhao.AutoSize = true;
			ckbzhinenghuanhao.Enabled = false;
			ckbzhinenghuanhao.Location = new System.Drawing.Point(4, 19);
			ckbzhinenghuanhao.Name = "ckbzhinenghuanhao";
			ckbzhinenghuanhao.Size = new System.Drawing.Size(36, 16);
			ckbzhinenghuanhao.TabIndex = 6;
			ckbzhinenghuanhao.Text = "开";
			ckbzhinenghuanhao.UseVisualStyleBackColor = true;
			序号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			序号.DataPropertyName = "index";
			序号.FillWeight = 106.599f;
			序号.Frozen = true;
			序号.HeaderText = "序号";
			序号.Name = "序号";
			序号.ReadOnly = true;
			序号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			序号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			序号.Width = 40;
			用户名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			用户名.DataPropertyName = "passport";
			用户名.FillWeight = 76.98668f;
			用户名.Frozen = true;
			用户名.HeaderText = "用户名";
			用户名.Name = "用户名";
			用户名.ReadOnly = true;
			用户名.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			状态.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			状态.DataPropertyName = "statusstr";
			状态.FillWeight = 76.98668f;
			状态.Frozen = true;
			状态.HeaderText = "状态";
			状态.Name = "状态";
			状态.ReadOnly = true;
			状态.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			状态.Width = 42;
			当前频道.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			当前频道.DataPropertyName = "sid";
			当前频道.FillWeight = 77.84281f;
			当前频道.Frozen = true;
			当前频道.HeaderText = "当前频道";
			当前频道.Name = "当前频道";
			当前频道.ReadOnly = true;
			当前频道.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			当前频道.Width = 75;
			CF.DataPropertyName = "currentflag";
			CF.HeaderText = "CF";
			CF.Name = "CF";
			CF.ReadOnly = true;
			CF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			CF.Width = 44;
			验证码.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			验证码.DataPropertyName = "yanzhengma";
			验证码.FillWeight = 253.0257f;
			验证码.HeaderText = "验证码";
			验证码.Name = "验证码";
			验证码.ReadOnly = true;
			验证码.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			验证码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			验证码.Width = 50;
			心跳.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			心跳.DataPropertyName = "heartbeat";
			心跳.FillWeight = 76.98668f;
			心跳.HeaderText = "心跳";
			心跳.Name = "心跳";
			心跳.ReadOnly = true;
			心跳.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			心跳.Width = 43;
			CKI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			CKI.DataPropertyName = "lol";
			CKI.HeaderText = "LOL";
			CKI.Name = "CKI";
			CKI.ReadOnly = true;
			CKI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			CKI.Visible = false;
			CKI.Width = 42;
			Trace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			Trace.DataPropertyName = "mytrace";
			Trace.HeaderText = "Trace";
			Trace.Name = "Trace";
			Trace.ReadOnly = true;
			Trace.Width = 80;
			马甲.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			马甲.DataPropertyName = "nicheng";
			马甲.FillWeight = 76.98668f;
			马甲.HeaderText = "马甲";
			马甲.Name = "马甲";
			马甲.ReadOnly = true;
			马甲.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			连接IP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			连接IP.DataPropertyName = "dailistr";
			连接IP.HeaderText = "代理";
			连接IP.Name = "连接IP";
			连接IP.ReadOnly = true;
			连接IP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(914, 533);
			base.Controls.Add(groupBox_2);
			base.Controls.Add(groupBox_1);
			base.Controls.Add(panel2);
			base.Controls.Add(groupBox_0);
			base.Controls.Add(groupBox9);
			base.Controls.Add(groupBox8);
			base.Controls.Add(groupBox7);
			base.Controls.Add(groupBox6);
			base.Controls.Add(groupBox5);
			base.Controls.Add(groupBox4);
			base.Controls.Add(groupBox3);
			base.Controls.Add(groupBox2);
			base.Controls.Add(groupBox1);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "MainForm";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Load += new System.EventHandler(MainForm_Load);
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)mygrid).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			groupBox7.ResumeLayout(false);
			groupBox7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)xhfen).EndInit();
			((System.ComponentModel.ISupportInitialize)xhshi).EndInit();
			((System.ComponentModel.ISupportInitialize)xhtian).EndInit();
			((System.ComponentModel.ISupportInitialize)shfen).EndInit();
			((System.ComponentModel.ISupportInitialize)shshi).EndInit();
			((System.ComponentModel.ISupportInitialize)shtian).EndInit();
			groupBox8.ResumeLayout(false);
			groupBox8.PerformLayout();
			groupBox9.ResumeLayout(false);
			groupBox9.PerformLayout();
			groupBox_0.ResumeLayout(false);
			groupBox_0.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			groupBox_1.ResumeLayout(false);
			groupBox_1.PerformLayout();
			groupBox_2.ResumeLayout(false);
			groupBox_2.PerformLayout();
			ResumeLayout(false);
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
				lbldaoqi.Text = string.Format("到期：{0}", timetool.getstr(int_0));
				if (int_0 > 1440)
				{
					lbldaoqi.ForeColor = Color.Green;
				}
				else
				{
					lbldaoqi.ForeColor = Color.Red;
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
					IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate(MyUser1225 p)
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
					IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate(MyUser1225 p)
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
				IEnumerable<MyUser1225> enumerable = concurrentBag_0.Where(delegate(MyUser1225 p)
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
			foreach (MyUser1225 item in concurrentBag_0.Where(delegate(MyUser1225 uu)
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
	}
}
