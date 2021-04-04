using System;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.UI;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x020000AC RID: 172
	public class HandlerQuestComplete : IJsonMessageHandler
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0000480C File Offset: 0x00002A0C
		public string[] HandledCommands { get; } = new string[]
		{
			"ccqr"
		};

		// Token: 0x060003E4 RID: 996 RVA: 0x0002B924 File Offset: 0x00029B24
		public void Handle(JsonMessage message)
		{
			CompletedQuest completedQuest = message.DataObject.ToObject<CompletedQuest>();
			Player.Quests.OnQuestCompleted(completedQuest);
			LogForm.Instance.AppendDebug(string.Format("Quest: {0} Completed at {1}:HH:mm:ss} \r\n", completedQuest.ToString(), DateTime.Now));
		}
	}
}
