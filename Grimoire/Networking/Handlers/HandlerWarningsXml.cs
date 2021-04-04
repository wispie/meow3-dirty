using System;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x0200009C RID: 156
	public class HandlerWarningsXml : IXmlMessageHandler
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000457B File Offset: 0x0000277B
		public string[] HandledCommands { get; } = new string[]
		{
			"logout"
		};

		// Token: 0x060003B6 RID: 950 RVA: 0x00002839 File Offset: 0x00000A39
		public void Handle(XmlMessage message)
		{
		}
	}
}
