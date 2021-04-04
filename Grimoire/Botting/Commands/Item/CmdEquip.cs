using System;
using System.Linq;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting.Commands.Item
{
	// Token: 0x02000187 RID: 391
	public class CmdEquip : IBotCommand
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x000080D2 File Offset: 0x000062D2
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x000080DA File Offset: 0x000062DA
		public string ItemName { get; set; }

		// Token: 0x0600099B RID: 2459 RVA: 0x00033BF0 File Offset: 0x00031DF0
		public async Task Execute(IBotEngine instance)
		{
			InventoryItem item = Player.Inventory.Items.FirstOrDefault((InventoryItem i) => i.Name.Equals(this.ItemName, StringComparison.OrdinalIgnoreCase) && i.IsEquippable);
			if (item != null)
			{
				while (instance.IsRunning && !this.IsEquipped(item.Id))
				{
					BotData.BotState = BotData.State.Transaction;
					while (instance.IsRunning && Player.CurrentState == Player.State.InCombat)
					{
						Player.MoveToCell(Player.Cell, Player.Pad);
						await Task.Delay(1000);
					}
					await instance.WaitUntil(() => World.IsActionAvailable(LockActions.EquipItem), null, 15);
					if (item.Category == "Item")
					{
						Player.EquipPotion(item.Id, item.Description, item.File, item.Name);
					}
					else
					{
						Player.Equip(item.Id);
					}
				}
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00033C40 File Offset: 0x00031E40
		public bool IsEquipped(int ItemID)
		{
			return Player.Inventory.Items.FirstOrDefault((InventoryItem it) => it.IsEquipped && it.Id == ItemID) != null;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000080E3 File Offset: 0x000062E3
		public override string ToString()
		{
			return "Equip: " + this.ItemName;
		}
	}
}
