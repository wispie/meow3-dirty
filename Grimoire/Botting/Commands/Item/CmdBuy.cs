using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting.Commands.Item
{
	// Token: 0x0200017D RID: 381
	public class CmdBuy : IBotCommand
	{
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x00007FCF File Offset: 0x000061CF
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00007FD7 File Offset: 0x000061D7
		public int ShopId { get; set; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00007FE0 File Offset: 0x000061E0
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00007FE8 File Offset: 0x000061E8
		public string ItemName { get; set; }

		// Token: 0x06000974 RID: 2420 RVA: 0x00033460 File Offset: 0x00031660
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Transaction;
			await instance.WaitUntil(() => World.IsActionAvailable(LockActions.BuyItem), null, 15);
			Shop.ResetShopInfo();
			Shop.Load(this.ShopId);
			await instance.WaitUntil(() => Shop.IsShopLoaded, null, 15);
			InventoryItem i = Player.Inventory.Items.FirstOrDefault((InventoryItem item) => item.Name.Equals(this.ItemName, StringComparison.OrdinalIgnoreCase));
			if (i != null)
			{
				Shop.BuyItem(this.ItemName);
				Func<InventoryItem, bool> <>9__5;
				await instance.WaitUntil(delegate
				{
					IEnumerable<InventoryItem> items = Player.Inventory.Items;
					Func<InventoryItem, bool> predicate;
					if ((predicate = <>9__5) == null)
					{
						predicate = (<>9__5 = ((InventoryItem it) => it.Name.Equals(this.ItemName, StringComparison.OrdinalIgnoreCase)));
					}
					return items.FirstOrDefault(predicate).Quantity != i.Quantity;
				}, null, 15);
			}
			else
			{
				Shop.BuyItem(this.ItemName);
				Func<InventoryItem, bool> <>9__6;
				await instance.WaitUntil(delegate
				{
					IEnumerable<InventoryItem> items = Player.Inventory.Items;
					Func<InventoryItem, bool> predicate;
					if ((predicate = <>9__6) == null)
					{
						predicate = (<>9__6 = ((InventoryItem it) => it.Name.Equals(this.ItemName, StringComparison.OrdinalIgnoreCase)));
					}
					return items.FirstOrDefault(predicate) != null;
				}, null, 15);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00007FF1 File Offset: 0x000061F1
		public override string ToString()
		{
			return "Buy item: " + this.ItemName;
		}
	}
}
