using System;
using System.Collections.Generic;
using System.Linq;
using Grimoire.Tools;

namespace Grimoire.Game.Data
{
	// Token: 0x020000C4 RID: 196
	public class Bank
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0000503A File Offset: 0x0000323A
		public List<InventoryItem> Items
		{
			get
			{
				return Flash.Call<List<InventoryItem>>("GetBankItems", new string[0]);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0000504C File Offset: 0x0000324C
		public int AvailableSlots
		{
			get
			{
				return this.TotalSlots - this.UsedSlots;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0000505B File Offset: 0x0000325B
		public int UsedSlots
		{
			get
			{
				return Flash.Call<int>("UsedBankSlots", new string[0]);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0000506D File Offset: 0x0000326D
		public int TotalSlots
		{
			get
			{
				return Flash.Call<int>("BankSlots", new string[0]);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000507F File Offset: 0x0000327F
		public void TransferToBank(string itemName)
		{
			Flash.Call("TransferToBank", new string[]
			{
				itemName
			});
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00005095 File Offset: 0x00003295
		public void TransferFromBank(string itemName)
		{
			Flash.Call("TransferToInventory", new string[]
			{
				itemName
			});
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x000050AB File Offset: 0x000032AB
		public void Swap(string invItemName, string bankItemName)
		{
			Flash.Call("BankSwap", new string[]
			{
				invItemName,
				bankItemName
			});
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0002C63C File Offset: 0x0002A83C
		public bool ContainsItem(string itemName, string quantity = "*")
		{
			InventoryItem inventoryItem = this.Items.FirstOrDefault((InventoryItem i) => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
			return inventoryItem != null && (quantity == "*" || inventoryItem.Quantity >= int.Parse(quantity));
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000050C5 File Offset: 0x000032C5
		public void Show()
		{
			Flash.Call("ShowBank", new string[0]);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000050D7 File Offset: 0x000032D7
		public void LoadItems()
		{
			Flash.Call("LoadBankItems", new string[0]);
		}
	}
}
