using System;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting.Commands.Item
{
	// Token: 0x02000184 RID: 388
	public class CmdBuyFast : IBotCommand
	{
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00008095 File Offset: 0x00006295
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x0000809D File Offset: 0x0000629D
		public string ItemName { get; set; }

		// Token: 0x06000991 RID: 2449 RVA: 0x00033AB4 File Offset: 0x00031CB4
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Transaction;
			await instance.WaitUntil(() => World.IsActionAvailable(LockActions.BuyItem), null, 15);
			Shop.BuyItem(this.ItemName);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000080A6 File Offset: 0x000062A6
		public override string ToString()
		{
			return "Buy item fast: " + this.ItemName;
		}
	}
}
