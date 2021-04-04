using System;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting.Commands.Item
{
	// Token: 0x02000193 RID: 403
	public class CmdLoad : IBotCommand
	{
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x00008214 File Offset: 0x00006414
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x0000821C File Offset: 0x0000641C
		public int ShopId { get; set; }

		// Token: 0x060009C0 RID: 2496 RVA: 0x000345E8 File Offset: 0x000327E8
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Transaction;
			await instance.WaitUntil(() => World.IsActionAvailable(LockActions.LoadShop), null, 15);
			Shop.ResetShopInfo();
			Shop.Load(this.ShopId);
			await instance.WaitUntil(() => Shop.IsShopLoaded, null, 15);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00008225 File Offset: 0x00006425
		public override string ToString()
		{
			return "Load Shop: " + this.ShopId;
		}
	}
}
