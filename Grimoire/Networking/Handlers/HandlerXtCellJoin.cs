using System;
using Grimoire.Botting;
using Grimoire.Game;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x0200009E RID: 158
	public class HandlerXtCellJoin : IXtMessageHandler
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060003BB RID: 955 RVA: 0x000045C3 File Offset: 0x000027C3
		public string[] HandledCommands { get; } = new string[]
		{
			"moveToCell"
		};

		// Token: 0x060003BC RID: 956 RVA: 0x000045CB File Offset: 0x000027CB
		public void Handle(XtMessage message)
		{
			if (Player.Map.ToLower() == "yulgar" && Player.Cell.ToLower() == "upstairs" && OptionsManager.HideYulgar)
			{
				OptionsManager.DestroyPlayers();
			}
		}
	}
}
