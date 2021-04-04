using System;
using Grimoire.Botting;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x020000A9 RID: 169
	public class HandlerMapJoin : IJsonMessageHandler
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00004775 File Offset: 0x00002975
		public string[] HandledCommands { get; } = new string[]
		{
			"moveToArea"
		};

		// Token: 0x060003DB RID: 987 RVA: 0x0000477D File Offset: 0x0000297D
		public void Handle(JsonMessage message)
		{
			if (OptionsManager.HideRoom)
			{
				message.DataObject["areaName"] = "discord.gg/aqwbots";
			}
		}
	}
}
