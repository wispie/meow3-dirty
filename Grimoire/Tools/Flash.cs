using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using AxShockwaveFlashObjects;
using Grimoire.Game.Data;
using Grimoire.Networking;
using Grimoire.UI;
using Grimoire.Utils;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

namespace Grimoire.Tools
{
	// Token: 0x02000060 RID: 96
	public class Flash
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000039D0 File Offset: 0x00001BD0
		public static Flash Instance
		{
			get
			{
				Flash result;
				if ((result = Flash._instance) == null)
				{
					result = (Flash._instance = new Flash());
				}
				return result;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600028D RID: 653 RVA: 0x00026838 File Offset: 0x00024A38
		// (remove) Token: 0x0600028E RID: 654 RVA: 0x0002686C File Offset: 0x00024A6C
		public static event FlashCallHandler FlashCall;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600028F RID: 655 RVA: 0x000268A0 File Offset: 0x00024AA0
		// (remove) Token: 0x06000290 RID: 656 RVA: 0x000268D4 File Offset: 0x00024AD4
		public static event FlashErrorHandler FlashError;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000291 RID: 657 RVA: 0x00026908 File Offset: 0x00024B08
		// (remove) Token: 0x06000292 RID: 658 RVA: 0x0002693C File Offset: 0x00024B3C
		public static event Action<int> SwfLoadProgress;

		// Token: 0x06000293 RID: 659 RVA: 0x00026970 File Offset: 0x00024B70
		public static void ProcessFlashCall(object sender, _IShockwaveFlashEvents_FlashCallEvent e)
		{
			XElement xelement = XElement.Parse(e.request);
			XAttribute xattribute = xelement.Attribute("name");
			string text = (xattribute != null) ? xattribute.Value : null;
			XElement xelement2 = xelement.Element("arguments");
			string text2 = (xelement2 != null) ? xelement2.Value : null;
			if (text == null)
			{
				return;
			}
			if (!(text == "progress"))
			{
				if (text == "modifyServers")
				{
					Root.Instance.Client.SetReturnValue("<string>" + Flash.ModifyServerList(text2.Trim()) + "</string>");
					return;
				}
			}
			else
			{
				Action<int> swfLoadProgress = Flash.SwfLoadProgress;
				if (swfLoadProgress == null)
				{
					return;
				}
				swfLoadProgress(int.Parse(text2));
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000039E6 File Offset: 0x00001BE6
		public string GetGameObject(string path)
		{
			return Flash.Call<string>("getGameObject", new string[]
			{
				path
			});
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000039FC File Offset: 0x00001BFC
		public string GetGameObjectStatic(string path)
		{
			return Flash.Call<string>("getGameObjectS", new string[]
			{
				path
			});
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00026A20 File Offset: 0x00024C20
		public T GetGameObject<T>(string path, T def = default(T))
		{
			T result;
			try
			{
				result = JsonConvert.DeserializeObject<T>(this.GetGameObject(path));
			}
			catch
			{
				result = def;
			}
			return result;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00003A12 File Offset: 0x00001C12
		public string CallGameFunction(string path, params object[] args)
		{
			if (args.Length == 0)
			{
				return Flash.Call<string>("callGameFunction0", new string[]
				{
					path
				});
			}
			return Flash.Call("callGameFunction", new object[]
			{
				path
			}.Concat(args).ToArray<object>());
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00003A4C File Offset: 0x00001C4C
		public void SetGameObject(string path, object value)
		{
			Flash.Call("setGameObject", new object[]
			{
				path,
				value
			});
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00003A67 File Offset: 0x00001C67
		public static string Call(string function, params object[] args)
		{
			return Flash.Call<string>(function, args);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00026A54 File Offset: 0x00024C54
		public static T Call<T>(string function, params object[] args)
		{
			T result;
			try
			{
				result = (T)((object)Flash.Call(function, typeof(T), args));
			}
			catch
			{
				result = default(T);
			}
			return result;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00026A98 File Offset: 0x00024C98
		public static object Call(string function, Type type, params object[] args)
		{
			object result;
			try
			{
				StringBuilder req = new StringBuilder().Append("<invoke name=\"" + function + "\" returntype=\"xml\">");
				if (args.Length != 0)
				{
					req.Append("<arguments>");
					args.ForEach(delegate(object o)
					{
						req.Append(Flash.ToFlashXml(o));
					});
					req.Append("</arguments>");
				}
				req.Append("</invoke>");
				string text = Flash.flash.CallFunction(req.ToString());
				XElement xelement = XElement.Parse(text);
				result = ((xelement == null || xelement.FirstNode == null) ? null : Convert.ChangeType(xelement.FirstNode.ToString(), type));
			}
			catch (Exception e)
			{
				FlashErrorHandler flashError = Flash.FlashError;
				if (flashError != null)
				{
					flashError(Flash.flash, e, function, args);
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003A70 File Offset: 0x00001C70
		public static T Call<T>(string function, params string[] args)
		{
			return Flash.TryDeserialize<T>(Flash.GetResponse(Flash.BuildRequest(function, args)));
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00003A83 File Offset: 0x00001C83
		public static void Call(string function, params string[] args)
		{
			Flash.Call<string>(function, args);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001D0D8 File Offset: 0x0001B2D8
		public static string BuildRequest(string method, params string[] args)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<invoke name=\"" + method + "\" returntype=\"xml\">");
			if (args != null && args.Length != 0)
			{
				stringBuilder.Append("<arguments>");
				foreach (string str in args)
				{
					stringBuilder.Append("<string>" + str + "</string>");
				}
				stringBuilder.Append("</arguments>");
			}
			stringBuilder.Append("</invoke>");
			return stringBuilder.ToString();
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0001D160 File Offset: 0x0001B360
		public static string GetResponse(string request)
		{
			string result;
			try
			{
				XNode firstNode = XElement.Parse(Root.Instance.Client.CallFunction(request)).FirstNode;
				result = HttpUtility.HtmlDecode(((firstNode != null) ? firstNode.ToString() : null) ?? string.Empty);
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00026B84 File Offset: 0x00024D84
		private static T TryDeserialize<T>(string str)
		{
			T result;
			try
			{
				result = JsonConvert.DeserializeObject<T>(str);
			}
			catch
			{
				result = default(T);
			}
			return result;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00026BB8 File Offset: 0x00024DB8
		public static string ToFlashXml(object o)
		{
			if (o == null)
			{
				return "<null/>";
			}
			if (o is bool)
			{
				bool flag = (bool)o;
				return "<" + o.ToString().ToLower() + "/>";
			}
			if (o is double)
			{
				double num = (double)o;
			}
			else if (o is float)
			{
				float num2 = (float)o;
			}
			else if (o is long)
			{
				long num3 = (long)o;
			}
			else if (o is int)
			{
				int num4 = (int)o;
			}
			else
			{
				if (o is ExpandoObject)
				{
					StringBuilder stringBuilder = new StringBuilder().Append("<object>");
					foreach (KeyValuePair<string, object> keyValuePair in (o as IDictionary<string, object>))
					{
						stringBuilder.Append(string.Concat(new string[]
						{
							"<property id=\"",
							keyValuePair.Key,
							"\">",
							Flash.ToFlashXml(keyValuePair.Value),
							"</property>"
						}));
					}
					return stringBuilder.Append("</object>").ToString();
				}
				if (o is Array)
				{
					StringBuilder stringBuilder2 = new StringBuilder().Append("<array>");
					int num5 = 0;
					foreach (object o2 in (o as Array))
					{
						stringBuilder2.Append(string.Format("<property id=\"{0}\">{1}</property>", num5++, Flash.ToFlashXml(o2)));
					}
					return stringBuilder2.Append("</array>").ToString();
				}
				return "<string>" + SecurityElement.Escape(o.ToString()) + "</string>";
			}
			return string.Format("<number>{0}</number>", o);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00026DCC File Offset: 0x00024FCC
		private static string ModifyServerList(string xml)
		{
			if (!xml.StartsWith("<login") || !xml.EndsWith("</login>"))
			{
				return xml;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			XmlElement xmlElement = xmlDocument["login"];
			Server[] array = new Server[xmlElement.ChildNodes.Count];
			for (int i = 0; i < xmlElement.ChildNodes.Count; i++)
			{
				XmlElement xmlElement2 = (XmlElement)xmlElement.ChildNodes[i];
				XmlAttribute xmlAttribute = xmlElement2.Attributes["sIP"];
				if (xmlAttribute == null)
				{
					return xml;
				}
				XmlAttribute xmlAttribute2 = xmlElement2.Attributes["iPort"];
				xmlElement2.Attributes.Append(xmlDocument.CreateAttribute("RealAddress")).Value = xmlAttribute.Value;
				xmlElement2.Attributes.Append(xmlDocument.CreateAttribute("RealPort")).Value = xmlAttribute2.Value;
				xmlElement2.Attributes["iPort"].Value = Proxy.Instance.ListenerPort.ToString();
				xmlAttribute.Value = "127.0.0.1";
				array[i] = new Server
				{
					IsChatRestricted = (xmlElement2.Attributes["iChat"].Value == "0"),
					PlayerCount = int.Parse(xmlElement2.Attributes["iCount"].Value),
					IsMemberOnly = (xmlElement2.Attributes["bUpg"].Value == "1"),
					IsOnline = (xmlElement2.Attributes["bOnline"].Value == "1"),
					Name = xmlElement2.Attributes["sName"].Value,
					Port = int.Parse(xmlElement2.Attributes["iPort"].Value)
				};
			}
			BotManager.Instance.OnServersLoaded(array);
			return xmlDocument.OuterXml;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00026FE0 File Offset: 0x000251E0
		public static object FromFlashXml(XElement el)
		{
			string a = el.Name.ToString();
			if (a == "number")
			{
				int num;
				float num2;
				return int.TryParse(el.Value, out num) ? ((float)num) : (float.TryParse(el.Value, out num2) ? num2 : 0f);
			}
			if (a == "true")
			{
				return true;
			}
			if (a == "false")
			{
				return false;
			}
			if (a == "null")
			{
				return null;
			}
			if (a == "array")
			{
				return (from e in el.Elements()
				select Flash.FromFlashXml(e)).ToArray<object>();
			}
			if (!(a == "object"))
			{
				return el.Value;
			}
			dynamic d = new ExpandoObject();
			el.Elements().ForEach(delegate(XElement e)
			{
				if (Flash.<>o__29.<>p__0 == null)
				{
					Flash.<>o__29.<>p__0 = CallSite<Func<CallSite, object, string, object, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(Flash), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Flash.<>o__29.<>p__0.Target(Flash.<>o__29.<>p__0, d, e.Attribute("id").Value, Flash.FromFlashXml(e.Elements().First<XElement>()));
			});
			return d;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000270F4 File Offset: 0x000252F4
		public static void CallHandler(object sender, _IShockwaveFlashEvents_FlashCallEvent e)
		{
			XElement xelement = XElement.Parse(e.request);
			string value = xelement.Attribute("name").Value;
			object[] args = (from x in xelement.Elements()
			select Flash.FromFlashXml(x)).ToArray<object>();
			FlashCallHandler flashCall = Flash.FlashCall;
			if (flashCall == null)
			{
				return;
			}
			flashCall(Flash.flash, value, args);
		}

		// Token: 0x040002A6 RID: 678
		private static Flash _instance;

		// Token: 0x040002A7 RID: 679
		public static AxShockwaveFlash flash;
	}
}
