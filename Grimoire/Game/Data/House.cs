using System;
using System.Collections.Generic;
using System.Linq;
using Grimoire.Tools;

namespace Grimoire.Game.Data
{
	// Token: 0x020000C8 RID: 200
	public class House
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x000051B6 File Offset: 0x000033B6
		public List<InventoryItem> Items
		{
			get
			{
				return Flash.Call<List<InventoryItem>>("GetHouseItems", new string[0]);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x000051C8 File Offset: 0x000033C8
		public int TotalSlots
		{
			get
			{
				return Flash.Call<int>("HouseSlots", new string[0]);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0002C694 File Offset: 0x0002A894
		public bool ContainsItem(string itemName, string quantity = "*")
		{
			InventoryItem inventoryItem = this.Items.FirstOrDefault((InventoryItem i) => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
			return inventoryItem != null && (quantity == "*" || inventoryItem.Quantity >= int.Parse(quantity));
		}
	}
}
