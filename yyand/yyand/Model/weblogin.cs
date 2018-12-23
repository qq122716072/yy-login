using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using ZHANHUO.Common;

namespace ZHANHUO.Model
{
	public class weblogin
	{
		private CookieContainer cookieContainer_0;

		private MyUser1225 myUser1225_0;

		private string string_0 = "";

		private string string_1 = "";

		private string string_2 = "";

		private string string_3 = "";

		public weblogin(MyUser1225 u, string dl = "")
		{
			myUser1225_0 = u;
			cookieContainer_0 = new CookieContainer();
			string_0 = dl;
			cookieContainer_0.Add(new Cookie("hiido_ui", rdomhelper.GetRandom(), "/", "www.yy.com"));
			cookieContainer_0.Add(new Cookie("hd_newui", rdomhelper.GetRandom(), "/", ".yy.com"));
			cookieContainer_0.Add(new Cookie("hdjs_session_id", rdomhelper.GetRandom(), "/", "www.yy.com"));
			cookieContainer_0.Add(new Cookie("hdjs_session_time", timetool.GetTms(), "/", "www.yy.com"));
			cookieContainer_0.Add(new Cookie("Hm_lvt_ce8c6560ab1225fc5d2f56ded20e175c", timetool.GetTs(), "/", "www.yy.com"));
			cookieContainer_0.Add(new Cookie("Hm_lpvt_ce8c6560ab1225fc5d2f56ded20e175c", timetool.GetTs(), "/", "www.yy.com"));
			cookieContainer_0.Add(new Cookie("wyy", Guid.NewGuid().ToString("N"), "/", "www.yy.com"));
		}

		private void method_0(HttpWebRequest httpWebRequest_0)
		{
			if (string_0.Length > 0)
			{
				string[] array = string_0.Split(':');
				WebProxy webProxy2 = (WebProxy)(httpWebRequest_0.Proxy = new WebProxy(array[0], Convert.ToInt32(array[1])));
				httpWebRequest_0.Timeout = 3000;
			}
			else
			{
				httpWebRequest_0.Proxy = null;
				httpWebRequest_0.Timeout = 3000;
			}
		}

		public bool userlogin(loginret ret)
		{
			HttpWebRequest httpWebRequest = null;
			HttpWebResponse httpWebResponse = null;
			Stream stream = null;
			StreamReader streamReader = null;
			string text = string.Empty;
			string empty = string.Empty;
			string text2 = null;
			byte[] array = null;
			try
			{
				if (httpWebRequest != null)
				{
					httpWebRequest.Abort();
					httpWebRequest = null;
				}
				empty = string.Format("http://www.yy.com/index/wakeudblogin");
				httpWebRequest = (WebRequest.Create(empty) as HttpWebRequest);
				httpWebRequest.Host = "www.yy.com";
				httpWebRequest.KeepAlive = false;
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.75 Safari/537.36";
				httpWebRequest.Accept = "application/json, text/javascript, */*; q=0.01";
				httpWebRequest.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
				httpWebRequest.Method = "POST";
				httpWebRequest.ServicePoint.Expect100Continue = false;
				httpWebRequest.ServicePoint.UseNagleAlgorithm = false;
				method_0(httpWebRequest);
				using (httpWebResponse = (httpWebRequest.GetResponse() as HttpWebResponse))
				{
					if (httpWebResponse.StatusCode != HttpStatusCode.OK)
					{
						return false;
					}
					using (stream = httpWebResponse.GetResponseStream())
					{
						using (streamReader = new StreamReader(stream))
						{
							text = streamReader.ReadToEnd();
						}
					}
					dynamic val = JsonConvert.DeserializeObject<object>(text);
					dynamic val2 = val.success == 1;
					dynamic val3 = (val2) ? val2 : (val2 | (val.success == "1"));
					if (!(val3 ? true : false) && !((val3 | (val.success == "true")) ? true : false))
					{
						return false;
					}
					empty = (string)val.url;
					string value = (string)val.ttokensec;
					cookieContainer_0.Add(new Cookie("udboauthtmptokensec", value, "/", "www.yy.com"));
				}
				string_1 = empty;
				if (httpWebRequest != null)
				{
					httpWebRequest.Abort();
					httpWebRequest = null;
				}
				empty = (string_1 += string.Format("&rdm={0}&UIStyle=xqlogin", new Random().NextDouble().ToString()));
				string text3 = empty.Substring(empty.IndexOf("oauth_token="), empty.IndexOf("&denyCallbackURL") - empty.IndexOf("oauth_token="));
				string_2 = text3.Replace("oauth_token=", "");
				httpWebRequest = (WebRequest.Create(empty) as HttpWebRequest);
				httpWebRequest.Host = "lgn.yy.com";
				httpWebRequest.KeepAlive = false;
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.75 Safari/537.36";
				httpWebRequest.Accept = "application/json, text/javascript, */*";
				httpWebRequest.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
				httpWebRequest.Method = "GET";
				httpWebRequest.ServicePoint.Expect100Continue = false;
				httpWebRequest.ServicePoint.UseNagleAlgorithm = false;
				method_0(httpWebRequest);
				using (httpWebResponse = (httpWebRequest.GetResponse() as HttpWebResponse))
				{
					if (httpWebResponse.StatusCode != HttpStatusCode.OK)
					{
						return false;
					}
					string text4 = httpWebResponse.Headers["Set-Cookie"];
					if (text4 != null)
					{
						string[] array2 = text4.Split(',');
						for (int i = 0; i < array2.Length; i++)
						{
							string[] array3 = array2[i].Split(';');
							foreach (string text5 in array3)
							{
								if (text5.Contains("token"))
								{
									cookieContainer_0.Add(new Cookie("token", text5.Replace("token=", "").Trim(), "/", "lgn.yy.com"));
								}
								else if (text5.Contains("LGNJSESSIONID"))
								{
									cookieContainer_0.Add(new Cookie("LGNJSESSIONID", text5.Replace("LGNJSESSIONID=", "").Trim(), "/", "lgn.yy.com"));
								}
							}
						}
					}
				}
				if (httpWebRequest != null)
				{
					httpWebRequest.Abort();
					httpWebRequest = null;
				}
				text2 = string_1;
				empty = "https://lgn.yy.com/lgn/oauth/x2/s/login_asyn.do";
				httpWebRequest = (WebRequest.Create(empty) as HttpWebRequest);
				httpWebRequest.Host = "lgn.yy.com";
				httpWebRequest.KeepAlive = true;
				httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.75 Safari/537.36";
				httpWebRequest.Accept = "*/*";
				httpWebRequest.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
				httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest.Method = "POST";
				httpWebRequest.CookieContainer = cookieContainer_0;
				httpWebRequest.Referer = text2;
				httpWebRequest.ServicePoint.Expect100Continue = false;
				httpWebRequest.ServicePoint.UseNagleAlgorithm = false;
				method_0(httpWebRequest);
				string s = string.Format("username={0}&pwdencrypt={1}&oauth_token={2}&denyCallbackURL=&UIStyle=xqlogin&appid=5077&cssid=5077&mxc=&vk=&isRemMe=0&mmc=&vv=&hiido=1", myUser1225_0.passport, jstool.Encrypt(myUser1225_0.pwd), string_2);
				array = Encoding.UTF8.GetBytes(s);
				using (stream = httpWebRequest.GetRequestStream())
				{
					stream.Write(array, 0, array.Length);
				}
				array = null;
				using (httpWebResponse = (httpWebRequest.GetResponse() as HttpWebResponse))
				{
					if (httpWebResponse.StatusCode != HttpStatusCode.OK)
					{
						return false;
					}
					using (stream = httpWebResponse.GetResponseStream())
					{
						using (streamReader = new StreamReader(stream))
						{
							text = streamReader.ReadToEnd();
						}
					}
				}
				if (!string.IsNullOrWhiteSpace(text))
				{
					dynamic val4 = JsonConvert.DeserializeObject<object>(text);
					if (!((val4.code == "0") ? true : false))
					{
						dynamic val3 = val4.code == "1000004";
						if (!(val3 ? true : false) && !((val3 | (val4.code == "1000010")) ? true : false))
						{
							val3 = (val4.code == "1000001");
							if (!(((val3 ? false : true) ? val3 : (val3 & (val4.obj.vk == "sv"))) ? true : false))
							{
								try
								{
									myUser1225_0.mytrace = (string)("webl:3-temp:" + val4.code + val4.obj.vk);
								}
								catch
								{
								}
								ret.ucode = (string)val4.code;
								return false;
							}
							ret.ucode = "1000001";
							return false;
						}
						myUser1225_0.status = 3;
						return false;
					}
					ret.uid = (string)val4.obj.yyuid;
					ret.ucode = "0";
					empty = (string)val4.obj.callbackURL;
					if (httpWebRequest != null)
					{
						httpWebRequest.Abort();
						httpWebRequest = null;
					}
					httpWebRequest = (WebRequest.Create(empty) as HttpWebRequest);
					httpWebRequest.Host = "www.yy.com";
					httpWebRequest.KeepAlive = false;
					httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.75 Safari/537.36";
					httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
					httpWebRequest.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
					httpWebRequest.Method = "GET";
					httpWebRequest.CookieContainer = cookieContainer_0;
					httpWebRequest.ServicePoint.Expect100Continue = false;
					httpWebRequest.ServicePoint.UseNagleAlgorithm = false;
					method_0(httpWebRequest);
					using (httpWebResponse = (httpWebRequest.GetResponse() as HttpWebResponse))
					{
						if (httpWebResponse.StatusCode != HttpStatusCode.OK)
						{
							return false;
						}
						using (stream = httpWebResponse.GetResponseStream())
						{
							using (streamReader = new StreamReader(stream))
							{
								text = streamReader.ReadToEnd();
							}
						}
					}
					if (!string.IsNullOrWhiteSpace(text))
					{
						if (text.Contains("wck_n.do"))
						{
							int num = text.IndexOf("writeCrossmainCookieWithCallBack");
							int num2 = text.IndexOf("',function");
							string_3 = text.Substring(num, num2 - num);
							string_3 = string_3.Replace("writeCrossmainCookieWithCallBack('", "");
							string_3 += string.Format("&rdm={0}", new Random().NextDouble());
							if (httpWebRequest != null)
							{
								httpWebRequest.Abort();
								httpWebRequest = null;
							}
							httpWebRequest = (WebRequest.Create(string_3) as HttpWebRequest);
							httpWebRequest.Host = "lgn.yy.com";
							httpWebRequest.KeepAlive = true;
							httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.75 Safari/537.36";
							httpWebRequest.Accept = "*/*";
							httpWebRequest.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
							httpWebRequest.Method = "GET";
							httpWebRequest.ServicePoint.Expect100Continue = false;
							httpWebRequest.ServicePoint.UseNagleAlgorithm = false;
							method_0(httpWebRequest);
							httpWebRequest.CookieContainer = cookieContainer_0;
							using (httpWebResponse = (httpWebRequest.GetResponse() as HttpWebResponse))
							{
								if (httpWebResponse.StatusCode != HttpStatusCode.OK)
								{
									return false;
								}
								string text6 = httpWebResponse.Headers["Set-Cookie"];
								if (text6 != null)
								{
									string[] array2 = text6.Split(',');
									for (int i = 0; i < array2.Length; i++)
									{
										string[] array3 = array2[i].Split(';');
										foreach (string text7 in array3)
										{
											if (text7.Contains("udb_l"))
											{
												ret.ck_udb_l = text7.Replace("udb_l=", "").Trim();
											}
											else if (text7.Contains("udb_n"))
											{
												ret.ck_udb_n = text7.Replace("udb_n=", "").Trim();
											}
											else if (text7.Contains("username"))
											{
												ret.ck_username = text7.Replace("username=", "").Trim();
												cookieContainer_0.Add(new Cookie("username", text7.Replace("username=", "").Trim(), "/", ".yy.com"));
											}
											else if (text7.Contains("password"))
											{
												cookieContainer_0.Add(new Cookie("password", text7.Replace("password=", "").Trim(), "/", ".yy.com"));
											}
											else if (text7.Contains("osinfo"))
											{
												cookieContainer_0.Add(new Cookie("osinfo", text7.Replace("osinfo=", "").Trim(), "/", ".yy.com"));
											}
											else if (text7.Contains("yyuid"))
											{
												cookieContainer_0.Add(new Cookie("yyuid", text7.Replace("yyuid=", "").Trim(), "/", ".yy.com"));
											}
											else if (text7.Contains("udb_oar"))
											{
												cookieContainer_0.Add(new Cookie("udb_oar", text7.Replace("udb_oar=", "").Trim(), "/", ".yy.com"));
											}
										}
									}
								}
							}
							ret.issuccess = true;
							return true;
						}
						return false;
					}
					return false;
				}
				return false;
			}
			catch
			{
				return false;
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
	}
}
