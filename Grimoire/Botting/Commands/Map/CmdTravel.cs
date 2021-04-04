using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Map
{
	// Token: 0x0200016F RID: 367
	public class CmdTravel : IBotCommand
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00007D76 File Offset: 0x00005F76
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00007D7E File Offset: 0x00005F7E
		public string Map { get; set; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00007D87 File Offset: 0x00005F87
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00007D8F File Offset: 0x00005F8F
		public string Cell { get; set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x00007D98 File Offset: 0x00005F98
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x00007DA0 File Offset: 0x00005FA0
		public string Pad { get; set; }

		// Token: 0x06000935 RID: 2357 RVA: 0x00032688 File Offset: 0x00030888
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Others;
			await this.WaitUntil(() => World.IsActionAvailable(LockActions.Transfer), 15);
			string cmdMap = this.Map.Contains("-") ? this.Map.Split(new char[]
			{
				'-'
			})[0] : this.Map;
			string map = Player.Map;
			if (!cmdMap.Equals(map, StringComparison.OrdinalIgnoreCase))
			{
				await this.WaitUntil(() => World.IsActionAvailable(LockActions.Transfer), 15);
				if (Player.CurrentState == Player.State.InCombat)
				{
					Player.MoveToCell(Player.Cell, Player.Pad);
					await this.WaitUntil(() => Player.CurrentState != Player.State.InCombat, 15);
				}
				Player.JoinMap(this.Map, this.Cell, this.Pad);
				await this.WaitUntil(() => Player.Map.Equals(cmdMap, StringComparison.OrdinalIgnoreCase), 15);
				await this.WaitUntil(() => !World.IsMapLoading, 40);
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000326D0 File Offset: 0x000308D0
		private async Task WaitUntil(Func<bool> condition, int timeout = 15)
		{
			int iterations = 0;
			while (!condition() && (iterations < timeout || timeout == -1))
			{
				await Task.Delay(1000);
				iterations++;
			}
		}
	}
}
