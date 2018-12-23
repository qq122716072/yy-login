using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using ZHANHUO.Common;
using ZHANHUO.Model;

namespace 战火协议
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            try
            {
                try
                {
                    string path = Application.StartupPath + "\\WCache";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
                catch
                {
                }
                try
                {
                    string path2 = Application.StartupPath + "\\PCache";
                    if (!Directory.Exists(path2))
                    {
                        Directory.CreateDirectory(path2);
                    }
                }
                catch
                {
                }
                try
                {
                    string path3 = Application.StartupPath + "\\Help";
                    if (!Directory.Exists(path3))
                    {
                        Directory.CreateDirectory(path3);
                    }
                }
                catch
                {
                }
                try
                {
                    string path4 = Application.StartupPath + "\\Help\\DSXH";
                    if (!Directory.Exists(path4))
                    {
                        Directory.CreateDirectory(path4);
                    }
                }
                catch
                {
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                DateTime now = DateTime.Now;
                string info = HardwareInfo.GetInfo();
                checkinfo obj5 = new checkinfo
                {
                    mac = info,
                    minitues = 9999999,
                    createtime = DateTime.Now
                };
                logtool.logauth(MyEncrypt.AesEncryptor(JsonConvert.SerializeObject(obj5)));
                Application.Run(new MainForm(obj5.minitues, now, true));
            }
            catch
            {
            }
        }
    }
}
