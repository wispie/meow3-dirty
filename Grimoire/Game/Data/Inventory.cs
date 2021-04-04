using System;
using System.Collections.Generic;
using System.Linq;
using Grimoire.Tools;

namespace Grimoire.Game.Data
{
	// Token: 0x020000CA RID: 202
	public class Inventory
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000051EE File Offset: 0x000033EE
		public List<InventoryItem> Items
		{
			get
			{
				return Flash.Call<List<InventoryItem>>("GetInventoryItems", new string[0]);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00005200 File Offset: 0x00003400
		public int MaxSlots
		{
			get
			{
				return Flash.Call<int>("InventorySlots", new string[0]);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00005212 File Offset: 0x00003412
		public int UsedSlots
		{
			get
			{
				return Flash.Call<int>("UsedInventorySlots", new string[0]);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00005224 File Offset: 0x00003424
		public int AvailableSlots
		{
			get
			{
				return this.MaxSlots - this.UsedSlots;
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0002C6EC File Offset: 0x0002A8EC
		public bool ContainsItem(string name, string quantity)
		{
			InventoryItem inventoryItem = this.Items.FirstOrDefault((InventoryItem i) => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
			return inventoryItem != null && (quantity == "*" || inventoryItem.Quantity >= int.Parse(quantity));
		}
	}
}
