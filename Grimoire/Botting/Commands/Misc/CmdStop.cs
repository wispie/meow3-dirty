using System;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.UI;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x0200012F RID: 303
	public class CmdStop : IBotCommand
	{
		// Token: 0x06000852 RID: 2130 RVA: 0x00030BDC File Offset: 0x0002EDDC
		public Task Execute(IBotEngine instance)
		{
			if (Configuration.Instance.BankOnStop)
			{
				foreach (InventoryItem inventoryItem in Player.Inventory.Items)
				{
					if (!inventoryItem.IsEquipped && inventoryItem.IsAcItem && inventoryItem.Category != "Class" && inventoryItem.Name.ToLower() != "treasure potion" && Configuration.Instance.Items.Contains(inventoryItem.Name))
					{
						Player.Bank.TransferToBank(inventoryItem.Name);
						Task.Delay(70);
						LogForm.Instance.AppendDebug("Transferred to Bank: " + inventoryItem.Name + "\r\n");
					}
				}
				LogForm.Instance.AppendDebug("Banked all AC Items in Items list \r\n");
			}
			Task.Delay(2000);
			instance.Stop();
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000071D9 File Offset: 0x000053D9
		public override string ToString()
		{
			return "Stop bot";
		}
	}
}
