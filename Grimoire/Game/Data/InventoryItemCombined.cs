using System;
using System.Linq;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000CD RID: 205
	public class InventoryItemCombined
	{
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x000053F1 File Offset: 0x000035F1
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x000053F9 File Offset: 0x000035F9
		[JsonProperty("iLvl")]
		public int Level { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00005402 File Offset: 0x00003602
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x0000540A File Offset: 0x0000360A
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bCoins")]
		public bool IsAcItem { get; set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00005413 File Offset: 0x00003613
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x0000541B File Offset: 0x0000361B
		public int CharItemId { get; set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00005424 File Offset: 0x00003624
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x0000542C File Offset: 0x0000362C
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bEquip")]
		public bool IsEquipped { get; set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00005435 File Offset: 0x00003635
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x0000543D File Offset: 0x0000363D
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bUpg")]
		public bool IsMemberOnly { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00005446 File Offset: 0x00003646
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x0000544E File Offset: 0x0000364E
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bTemp")]
		public bool IsTemporary { get; set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00005457 File Offset: 0x00003657
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x0000545F File Offset: 0x0000365F
		[JsonProperty("iCost")]
		public int Cost { get; set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00005468 File Offset: 0x00003668
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00005470 File Offset: 0x00003670
		[JsonProperty("ItemID")]
		public int Id { get; set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00005479 File Offset: 0x00003679
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00005481 File Offset: 0x00003681
		[JsonProperty("ShopItemID")]
		public int ShopItemId { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0000548A File Offset: 0x0000368A
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00005492 File Offset: 0x00003692
		[JsonProperty("iRate")]
		public string DropChance { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0000549B File Offset: 0x0000369B
		public bool IsEquippable
		{
			get
			{
				return InventoryItemCombined.EquippableCategories.Contains(this.Category);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x000054AD File Offset: 0x000036AD
		public bool IsWeapon
		{
			get
			{
				return InventoryItemCombined.Weapons.Contains(this.Category);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x000054BF File Offset: 0x000036BF
		public bool IsEquippableNonItem
		{
			get
			{
				return InventoryItemCombined.EquippableNonWeapon.Contains(this.Category);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeDescription
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeMaxStack
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeLevel
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsAcItem
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeLink
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeFile
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsEquipped
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsMemberOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsTemporary()
		{
			return false;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeCost()
		{
			return false;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeCategory()
		{
			return false;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeShopItemId()
		{
			return false;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeDropChance()
		{
			return false;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x000054D1 File Offset: 0x000036D1
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x000054D9 File Offset: 0x000036D9
		[JsonProperty("ItemID")]
		public virtual int ID { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x000054E2 File Offset: 0x000036E2
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x000054EA File Offset: 0x000036EA
		[JsonProperty("sName")]
		[JsonConverter(typeof(TrimConverter))]
		public virtual string Name { get; set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x000054F3 File Offset: 0x000036F3
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x000054FB File Offset: 0x000036FB
		[JsonProperty("sDesc")]
		public virtual string Description { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00005504 File Offset: 0x00003704
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x0000550C File Offset: 0x0000370C
		[JsonProperty("iQty")]
		public virtual int Quantity { get; set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00005515 File Offset: 0x00003715
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x0000551D File Offset: 0x0000371D
		[JsonProperty("iStk")]
		public virtual int MaxStack { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00005526 File Offset: 0x00003726
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0000552E File Offset: 0x0000372E
		[JsonProperty("bUpg")]
		[JsonConverter(typeof(StringBoolConverter))]
		public virtual bool Upgrade { get; set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00005537 File Offset: 0x00003737
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x0000553F File Offset: 0x0000373F
		[JsonProperty("bCoins")]
		[JsonConverter(typeof(StringBoolConverter))]
		public virtual bool Coins { get; set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00005548 File Offset: 0x00003748
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00005550 File Offset: 0x00003750
		[JsonProperty("sType")]
		public virtual string Category { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00005559 File Offset: 0x00003759
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00005561 File Offset: 0x00003761
		[JsonProperty("bTemp")]
		[JsonConverter(typeof(StringBoolConverter))]
		public virtual bool Temp { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0000556A File Offset: 0x0000376A
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00005572 File Offset: 0x00003772
		[JsonProperty("sFile")]
		public virtual string File { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0000557B File Offset: 0x0000377B
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00005583 File Offset: 0x00003783
		[JsonProperty("sLink")]
		public virtual string Link { get; set; }

		// Token: 0x040003F1 RID: 1009
		public static readonly string[] EquippableCategories = new string[]
		{
			"Sword",
			"Axe",
			"Dagger",
			"Gun",
			"Bow",
			"Mace",
			"Polearm",
			"Staff",
			"Wand",
			"Class",
			"Armor",
			"Helm",
			"Cape",
			"Item"
		};

		// Token: 0x040003F2 RID: 1010
		public static readonly string[] Weapons = new string[]
		{
			"Sword",
			"Axe",
			"Dagger",
			"Gun",
			"Bow",
			"Mace",
			"Polearm",
			"Staff",
			"Wand"
		};

		// Token: 0x040003F3 RID: 1011
		public static readonly string[] EquippableNonWeapon = new string[]
		{
			"Class",
			"Armor",
			"Helm",
			"Cape",
			"Pet"
		};
	}
}
