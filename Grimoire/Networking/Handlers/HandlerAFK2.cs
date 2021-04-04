using System;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x0200009A RID: 154
	public class HandlerAFK2 : IXtMessageHandler
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060003AF RID: 943 RVA: 0x000044EE File Offset: 0x000026EE
		public string[] HandledCommands { get; } = new string[]
		{
			"afk"
		};

		// Token: 0x060003B0 RID: 944 RVA: 0x000044F6 File Offset: 0x000026F6
		public void Handle(XtMessage message)
		{
			if (message.Arguments[5] == "true")
			{
				message.Send = false;
			}
		}
	}
}
