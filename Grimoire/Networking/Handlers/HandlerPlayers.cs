using System;
using Grimoire.Botting;
using Grimoire.Game;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x020000AA RID: 170
	public class HandlerPlayers : IXtMessageHandler
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060003DD RID: 989 RVA: 0x000047BC File Offset: 0x000029BC
		public string[] HandledCommands { get; } = new string[]
		{
			"retrieveUserData",
			"retrieveUserDatas"
		};

		// Token: 0x060003DE RID: 990 RVA: 0x0002B874 File Offset: 0x00029A74
		public void Handle(XtMessage message)
		{
			if (OptionsManager.HidePlayers && Player.Inventory.Items.Count > 0)
			{
				message.Send = message.RawContent.Contains(Player.UserID.ToString());
				OptionsManager.DestroyPlayers();
			}
		}
	}
}
