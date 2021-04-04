using System;
using System.Collections.Generic;
using System.Linq;
using Grimoire.Tools;

namespace Grimoire.Game.Data
{
	// Token: 0x020000DC RID: 220
	public class TempInventory
	{
		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00006029 File Offset: 0x00004229
		public List<TempItem> Items
		{
			get
			{
				return Flash.Call<List<TempItem>>("GetTempItems", new string[0]);
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0002CB9C File Offset: 0x0002AD9C
		public bool ContainsItem(string name, string qty)
		{
			TempItem tempItem = this.Items.FirstOrDefault((TempItem i) => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
			return tempItem != null && (qty == "*" || tempItem.Quantity >= int.Parse(qty));
		}
	}
}
