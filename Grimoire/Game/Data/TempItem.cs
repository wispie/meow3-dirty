using System;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000DE RID: 222
	public class TempItem
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0000604F File Offset: 0x0000424F
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00006057 File Offset: 0x00004257
		[JsonProperty("sName")]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = ((value != null) ? value.Trim() : null);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0000606B File Offset: 0x0000426B
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00006073 File Offset: 0x00004273
		[JsonProperty("sDesc")]
		public string Description { get; set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0000607C File Offset: 0x0000427C
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00006084 File Offset: 0x00004284
		[JsonProperty("ItemID")]
		public int Id { get; set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0000608D File Offset: 0x0000428D
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00006095 File Offset: 0x00004295
		[JsonProperty("iLvl")]
		public int Level { get; set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0000609E File Offset: 0x0000429E
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x000060A6 File Offset: 0x000042A6
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bCoins")]
		public bool IsAcItem { get; set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x000060AF File Offset: 0x000042AF
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x000060B7 File Offset: 0x000042B7
		[JsonProperty("sLink")]
		public string Link { get; set; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x000060C0 File Offset: 0x000042C0
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x000060C8 File Offset: 0x000042C8
		[JsonProperty("iQty")]
		public int Quantity { get; set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x000060D1 File Offset: 0x000042D1
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x000060D9 File Offset: 0x000042D9
		[JsonProperty("sType")]
		public string Type { get; set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x000060E2 File Offset: 0x000042E2
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x000060EA File Offset: 0x000042EA
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bUpg")]
		public bool IsMemberOnly { get; set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000060F3 File Offset: 0x000042F3
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x000060FB File Offset: 0x000042FB
		[JsonProperty("iCost")]
		public int Cost { get; set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00006104 File Offset: 0x00004304
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x0000610C File Offset: 0x0000430C
		[JsonProperty("iStk")]
		public int MaxStack { get; set; }

		// Token: 0x0600066C RID: 1644 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeDescription()
		{
			return false;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeLevel()
		{
			return false;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsAcItem()
		{
			return false;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeLink()
		{
			return false;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeType()
		{
			return false;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsMemberOnly()
		{
			return false;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeCost()
		{
			return false;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeMaxStack()
		{
			return false;
		}

		// Token: 0x04000487 RID: 1159
		private string _name;
	}
}
