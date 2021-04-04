using System;
using System.Xml;

namespace Grimoire.Networking
{
	// Token: 0x02000097 RID: 151
	public class XmlMessage : Message
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0000446B File Offset: 0x0000266B
		public XmlDocument Body { get; }

		// Token: 0x060003A6 RID: 934 RVA: 0x0002B08C File Offset: 0x0002928C
		public XmlMessage(string raw)
		{
			try
			{
				base.RawContent = raw;
				this.Body = new XmlDocument();
				this.Body.LoadXml(raw);
				string command;
				if (!raw.Contains("cross-domain-policy"))
				{
					XmlElement documentElement = this.Body.DocumentElement;
					if (documentElement == null)
					{
						command = null;
					}
					else
					{
						XmlElement xmlElement = documentElement["body"];
						if (xmlElement == null)
						{
							command = null;
						}
						else
						{
							XmlAttribute xmlAttribute = xmlElement.Attributes["action"];
							command = ((xmlAttribute != null) ? xmlAttribute.Value : null);
						}
					}
				}
				else
				{
					command = "policy";
				}
				base.Command = command;
			}
			catch (XmlException)
			{
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00004473 File Offset: 0x00002673
		public override string ToString()
		{
			return this.Body.OuterXml;
		}
	}
}
