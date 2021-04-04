using System;
using System.Xml;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x020000AB RID: 171
	public class HandlerPolicy : IXmlMessageHandler
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x000047E8 File Offset: 0x000029E8
		public string[] HandledCommands { get; } = new string[]
		{
			"policy"
		};

		// Token: 0x060003E1 RID: 993 RVA: 0x0002B8C4 File Offset: 0x00029AC4
		public void Handle(XmlMessage message)
		{
			XmlDocument body = message.Body;
			XmlElement xmlElement;
			if (body == null)
			{
				xmlElement = null;
			}
			else
			{
				XmlElement xmlElement2 = body["cross-domain-policy"];
				xmlElement = ((xmlElement2 != null) ? xmlElement2["allow-access-from"] : null);
			}
			XmlElement xmlElement3 = xmlElement;
			if (xmlElement3 != null)
			{
				xmlElement3.Attributes["to-ports"].Value = Proxy.Instance.ListenerPort.ToString();
			}
		}
	}
}
