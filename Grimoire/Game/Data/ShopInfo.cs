using System;
using System.Collections.Generic;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000D9 RID: 217
	public class ShopInfo
	{
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00005F58 File Offset: 0x00004158
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x00005F60 File Offset: 0x00004160
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bUpgrd")]
		public bool IsMemberOnly { get; set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00005F69 File Offset: 0x00004169
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00005F71 File Offset: 0x00004171
		[JsonProperty("items")]
		public List<InventoryItem> Items { get; set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00005F7A File Offset: 0x0000417A
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00005F82 File Offset: 0x00004182
		[JsonProperty("ShopID")]
		public int Id { get; set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00005F8B File Offset: 0x0000418B
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00005F93 File Offset: 0x00004193
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bStaff")]
		public bool IsStaffOnly { get; set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00005F9C File Offset: 0x0000419C
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00005FA4 File Offset: 0x000041A4
		[JsonProperty("sName")]
		public string Name { get; set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00005FAD File Offset: 0x000041AD
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00005FB5 File Offset: 0x000041B5
		public string Location { get; set; }
	}
}
