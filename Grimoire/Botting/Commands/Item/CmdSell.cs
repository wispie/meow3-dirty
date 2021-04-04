using System;
using System.Linq;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting.Commands.Item
{
	// Token: 0x02000199 RID: 409
	public class CmdSell : IBotCommand
	{
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x000082A8 File Offset: 0x000064A8
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x000082B0 File Offset: 0x000064B0
		public string ItemName { get; set; }

		// Token: 0x060009D5 RID: 2517 RVA: 0x00034964 File Offset: 0x00032B64
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Transaction;
			await instance.WaitUntil(() => World.IsActionAvailable(LockActions.SellItem), null, 15);
			InventoryItem item = Player.Inventory.Items.FirstOrDefault((InventoryItem i) => i.Name.Equals(this.ItemName, StringComparison.OrdinalIgnoreCase));
			if (item != null)
			{
				Shop.SellItem(this.ItemName);
				await instance.WaitUntil(() => !Player.Inventory.ContainsItem(item.Name, item.Quantity.ToString()), null, 15);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000082B9 File Offset: 0x000064B9
		public override string ToString()
		{
			return "Sell: " + this.ItemName;
		}
	}
}
