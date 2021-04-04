using System;
using System.Linq;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting.Commands.Quest
{
	// Token: 0x02000101 RID: 257
	public class CmdAcceptQuest : IBotCommand
	{
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00006BD0 File Offset: 0x00004DD0
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00006BD8 File Offset: 0x00004DD8
		public Quest Quest { get; set; }

		// Token: 0x060007A5 RID: 1957 RVA: 0x0002F098 File Offset: 0x0002D298
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Quest;
			await instance.WaitUntil(() => Player.Quests.QuestTree.Any((Quest q) => q.Id == this.Quest.Id), null, 15);
			await instance.WaitUntil(() => World.IsActionAvailable(LockActions.AcceptQuest), null, 15);
			this.Quest.Accept();
			await instance.WaitUntil(() => Player.Quests.IsInProgress(this.Quest.Id), null, 15);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00006BE1 File Offset: 0x00004DE1
		public override string ToString()
		{
			return string.Format("Accept quest: {0}", this.Quest.Id);
		}
	}
}
