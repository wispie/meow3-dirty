using System;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting.Commands.Quest
{
	// Token: 0x02000104 RID: 260
	public class CmdCompleteQuest : IBotCommand
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00006C69 File Offset: 0x00004E69
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00006C71 File Offset: 0x00004E71
		public Quest Quest { get; set; }

		// Token: 0x060007B2 RID: 1970 RVA: 0x0002F2D0 File Offset: 0x0002D4D0
		public async Task Execute(IBotEngine instance)
		{
			await instance.WaitUntil(() => World.IsActionAvailable(LockActions.TryQuestComplete), null, 15);
			if (Player.Quests.CanComplete(this.Quest.Id))
			{
				string cell = Player.Cell;
				string pad = Player.Pad;
				if (instance.Configuration.ExitCombatBeforeQuest)
				{
					while (instance.IsRunning && Player.CurrentState == Player.State.InCombat)
					{
						BotData.BotState = BotData.State.Quest;
						Player.MoveToCell(Player.Cell, Player.Pad);
						await Task.Delay(1000);
					}
				}
				if (Player.CurrentState == Player.State.InCombat)
				{
					await Task.Delay(1250);
				}
				this.Quest.Complete();
				await instance.WaitUntil(() => !Player.Quests.IsInProgress(this.Quest.Id), null, 15);
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0002F320 File Offset: 0x0002D520
		public override string ToString()
		{
			return "Complete quest: " + ((this.Quest.ItemId != null && this.Quest.ItemId != "0") ? string.Format("{0}:{1}", this.Quest.Id, this.Quest.ItemId) : this.Quest.Id.ToString());
		}
	}
}
