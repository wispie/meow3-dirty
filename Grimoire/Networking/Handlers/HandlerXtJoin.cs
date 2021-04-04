using System;
using System.Windows.Forms;
using Grimoire.Botting;
using Grimoire.UI;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x0200009D RID: 157
	public class HandlerXtJoin : IXtMessageHandler
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000459F File Offset: 0x0000279F
		public string[] HandledCommands { get; } = new string[]
		{
			"server"
		};

		// Token: 0x060003B9 RID: 953 RVA: 0x0002B1B4 File Offset: 0x000293B4
		public void Handle(XtMessage message)
		{
			if (!message.RawContent.Contains("You joined "))
			{
				return;
			}
			if (BotManager.Instance.CustomName != null)
			{
				BotManager.Instance.CustomName = BotManager.Instance.CustomName;
			}
			if (BotManager.Instance.CustomGuild != null)
			{
				BotManager.Instance.CustomGuild = BotManager.Instance.CustomGuild;
			}
			if (OptionsManager.HideRoom)
			{
				Config config = Config.Load(Application.StartupPath + "\\config.cfg");
				message.Arguments[4] = (config.Get("JoinMessage") ?? "You joined a place but... where?");
			}
			LogForm.Instance.AppendChat(string.Format("[{0:hh:mm:ss}] {1} \r\n", DateTime.Now, message.Arguments[4]));
		}
	}
}
