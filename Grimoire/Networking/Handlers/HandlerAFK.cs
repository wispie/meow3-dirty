using System;
using Grimoire.Botting;
using Grimoire.Game;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x02000099 RID: 153
	public class HandlerAFK : IXtMessageHandler
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060003AC RID: 940 RVA: 0x000044A3 File Offset: 0x000026A3
		public string[] HandledCommands { get; } = new string[]
		{
			"afk"
		};

		// Token: 0x060003AD RID: 941 RVA: 0x000044AB File Offset: 0x000026AB
		public void Handle(XtMessage message)
		{
			if (message.Arguments[5] == "true" && Bot.Instance.IsRunning)
			{
				Player.Logout();
			}
		}
	}
}
