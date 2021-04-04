using System;
using Grimoire.UI;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x0200009B RID: 155
	public class HandlerWarningsXt : IXtMessageHandler
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000452F File Offset: 0x0000272F
		public string[] HandledCommands { get; } = new string[]
		{
			"logoutWarning"
		};

		// Token: 0x060003B3 RID: 947 RVA: 0x00004537 File Offset: 0x00002737
		public void Handle(XtMessage message)
		{
			LogForm.Instance.AppendChat(string.Format("[{0:hh:mm:ss}] {1} \r\n", DateTime.Now, message.Arguments[4]));
		}
	}
}
