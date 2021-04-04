using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Combat
{
	// Token: 0x020001A6 RID: 422
	public class CmdRest : IBotCommand
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0000843F File Offset: 0x0000663F
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00008447 File Offset: 0x00006647
		public bool Full { get; set; }

		// Token: 0x06000A08 RID: 2568 RVA: 0x000358EC File Offset: 0x00033AEC
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Rest;
			await instance.WaitUntil(() => World.IsActionAvailable(LockActions.Rest), () => instance.IsRunning && Player.IsLoggedIn, 15);
			if (instance.Configuration.ExitCombatBeforeRest)
			{
				while (Player.CurrentState == Player.State.InCombat)
				{
					Player.MoveToCell(Player.Cell, Player.Pad);
					await Task.Delay(1250);
				}
			}
			Player.Rest();
			if (this.Full)
			{
				await instance.WaitUntil(() => Player.Mana >= Player.ManaMax && Player.Health >= Player.HealthMax, null, 15);
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00008450 File Offset: 0x00006650
		public override string ToString()
		{
			if (!this.Full)
			{
				return "Rest";
			}
			return "Rest fully";
		}
	}
}
