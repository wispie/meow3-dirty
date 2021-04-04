using System;
using System.Collections.Generic;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000D8 RID: 216
	public class Shop
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00005E58 File Offset: 0x00004058
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x00005E60 File Offset: 0x00004060
		[JsonProperty("sName")]
		public string Name { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00005E69 File Offset: 0x00004069
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00005E71 File Offset: 0x00004071
		[JsonProperty("ShopID")]
		public int Id { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00005E7A File Offset: 0x0000407A
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00005E82 File Offset: 0x00004082
		[JsonProperty("items")]
		public List<InventoryItem> Items { get; set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00005E8B File Offset: 0x0000408B
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00005E93 File Offset: 0x00004093
		public string Location { get; set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00005E9C File Offset: 0x0000409C
		public static bool IsShopLoaded
		{
			get
			{
				return Flash.Call<bool>("IsShopLoaded", new string[0]);
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00005EAE File Offset: 0x000040AE
		public static void BuyItem(string name)
		{
			Flash.Call("BuyItem", new string[]
			{
				name
			});
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00005EC4 File Offset: 0x000040C4
		public static void ResetShopInfo()
		{
			Flash.Call("ResetShopInfo", new string[0]);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00005ED6 File Offset: 0x000040D6
		public static void Load(int id)
		{
			Flash.Call("LoadShop", new string[]
			{
				id.ToString()
			});
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00005EF2 File Offset: 0x000040F2
		public static void SellItem(string name)
		{
			Flash.Call("SellItem", new string[]
			{
				name
			});
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00005F08 File Offset: 0x00004108
		public static void LoadHairShop(string id)
		{
			Flash.Call("LoadHairShop", new string[]
			{
				id
			});
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00005F1E File Offset: 0x0000411E
		public static void LoadHairShop(int id)
		{
			Flash.Call("LoadHairShop", new string[]
			{
				id.ToString()
			});
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00005F3A File Offset: 0x0000413A
		public static void LoadArmorCustomizer()
		{
			Flash.Call("LoadArmorCustomizer", new string[0]);
		}

		// Token: 0x04000472 RID: 1138
		public static Shop Instance = new Shop();
	}
}
