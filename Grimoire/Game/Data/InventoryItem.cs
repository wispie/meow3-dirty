using System;
using System.Linq;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000CC RID: 204
	public class InventoryItem
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00005247 File Offset: 0x00003447
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x0000524F File Offset: 0x0000344F
		[JsonProperty("iQty")]
		public int Quantity { get; set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00005258 File Offset: 0x00003458
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00005260 File Offset: 0x00003460
		[JsonProperty("sDesc")]
		public string Description { get; set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00005269 File Offset: 0x00003469
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00005271 File Offset: 0x00003471
		[JsonProperty("iStk")]
		public int MaxStack { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0000527A File Offset: 0x0000347A
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00005282 File Offset: 0x00003482
		[JsonProperty("iLvl")]
		public int Level { get; set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000528B File Offset: 0x0000348B
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00005293 File Offset: 0x00003493
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bCoins")]
		public bool IsAcItem { get; set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0000529C File Offset: 0x0000349C
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x000052A4 File Offset: 0x000034A4
		public int CharItemId { get; set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000052AD File Offset: 0x000034AD
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x000052B5 File Offset: 0x000034B5
		[JsonProperty("sLink")]
		public string Link { get; set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x000052BE File Offset: 0x000034BE
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x000052C6 File Offset: 0x000034C6
		[JsonProperty("sFile")]
		public string File { get; set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x000052CF File Offset: 0x000034CF
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x000052D7 File Offset: 0x000034D7
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bEquip")]
		public bool IsEquipped { get; set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x000052E0 File Offset: 0x000034E0
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x000052E8 File Offset: 0x000034E8
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bUpg")]
		public bool IsMemberOnly { get; set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x000052F1 File Offset: 0x000034F1
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x000052F9 File Offset: 0x000034F9
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bTemp")]
		public bool IsTemporary { get; set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00005302 File Offset: 0x00003502
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x0000530A File Offset: 0x0000350A
		[JsonProperty("iCost")]
		public int Cost { get; set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00005313 File Offset: 0x00003513
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x0000531B File Offset: 0x0000351B
		[JsonProperty("sType")]
		public string Category { get; set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00005324 File Offset: 0x00003524
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x0000532C File Offset: 0x0000352C
		[JsonProperty("ItemID")]
		public int Id { get; set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00005335 File Offset: 0x00003535
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00005372 File Offset: 0x00003572
		[JsonProperty("sName")]
		public string Name
		{
			get
			{
				if (string.IsNullOrEmpty(this._name))
				{
					InventoryItem inventoryItem = World.ItemTree.FirstOrDefault((InventoryItem i) => i.Id == this.Id);
					this._name = ((inventoryItem != null) ? inventoryItem.Name : null);
				}
				return this._name;
			}
			set
			{
				this._name = ((value != null) ? value.Trim() : null);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00005386 File Offset: 0x00003586
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x0000538E File Offset: 0x0000358E
		[JsonProperty("ShopItemID")]
		public int ShopItemId { get; set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00005397 File Offset: 0x00003597
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000539F File Offset: 0x0000359F
		[JsonProperty("iRate")]
		public string DropChance { get; set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x000053A8 File Offset: 0x000035A8
		public bool IsEquippable
		{
			get
			{
				return InventoryItem.EquippableCategories.Contains(this.Category);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x000053BA File Offset: 0x000035BA
		public bool IsWeapon
		{
			get
			{
				return InventoryItem.Weapons.Contains(this.Category);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x000053CC File Offset: 0x000035CC
		public bool IsEquippableNonItem
		{
			get
			{
				return InventoryItem.EquippableNonWeapon.Contains(this.Category);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeDescription
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeMaxStack
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeLevel
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsAcItem
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeLink
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeFile
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsEquipped
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsMemberOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsTemporary()
		{
			return false;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeCost()
		{
			return false;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeCategory()
		{
			return false;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeShopItemId()
		{
			return false;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeDropChance()
		{
			return false;
		}

		// Token: 0x040003DD RID: 989
		private string _name;

		// Token: 0x040003DE RID: 990
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

		// Token: 0x040003DF RID: 991
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

		// Token: 0x040003E0 RID: 992
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
