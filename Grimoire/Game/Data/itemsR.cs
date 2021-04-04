using System;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000D3 RID: 211
	public class itemsR
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x000059CC File Offset: 0x00003BCC
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x000059D4 File Offset: 0x00003BD4
		[JsonProperty("sIcon")]
		public string Icon { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x000059DD File Offset: 0x00003BDD
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x000059E5 File Offset: 0x00003BE5
		[JsonProperty("ItemID")]
		public int ItemId { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x000059EE File Offset: 0x00003BEE
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x000059F6 File Offset: 0x00003BF6
		[JsonProperty("iLvl")]
		public int Level { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x000059FF File Offset: 0x00003BFF
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00005A07 File Offset: 0x00003C07
		[JsonProperty("sLink")]
		public string Link { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00005A10 File Offset: 0x00003C10
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00005A18 File Offset: 0x00003C18
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bTemp")]
		public bool Temp { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00005A21 File Offset: 0x00003C21
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00005A29 File Offset: 0x00003C29
		[JsonProperty("sElmt")]
		public string sElmt { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00005A32 File Offset: 0x00003C32
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00005A3A File Offset: 0x00003C3A
		[JsonProperty("bStaff")]
		public bool Staff { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00005A43 File Offset: 0x00003C43
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00005A4B File Offset: 0x00003C4B
		[JsonProperty("iRng")]
		public int iRng { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00005A54 File Offset: 0x00003C54
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00005A5C File Offset: 0x00003C5C
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bCoins")]
		public bool Coins { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00005A65 File Offset: 0x00003C65
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00005A6D File Offset: 0x00003C6D
		[JsonProperty("iDPS")]
		public int iDPS { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00005A76 File Offset: 0x00003C76
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00005A7E File Offset: 0x00003C7E
		[JsonProperty("sES")]
		public string sES { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00005A87 File Offset: 0x00003C87
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00005A8F File Offset: 0x00003C8F
		[JsonProperty("bPTR")]
		public int bPTR { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00005A98 File Offset: 0x00003C98
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00005AA0 File Offset: 0x00003CA0
		[JsonProperty("iQSIndex")]
		public int iQSIndex { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00005AA9 File Offset: 0x00003CA9
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00005AB1 File Offset: 0x00003CB1
		[JsonProperty("sType")]
		public string Category { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00005ABA File Offset: 0x00003CBA
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00005AC2 File Offset: 0x00003CC2
		[JsonProperty("sDesc")]
		public string Description { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00005ACB File Offset: 0x00003CCB
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00005AD3 File Offset: 0x00003CD3
		[JsonProperty("iStk")]
		public int MaxStack { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00005ADC File Offset: 0x00003CDC
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00005AE4 File Offset: 0x00003CE4
		[JsonProperty("iCost")]
		public int Cost { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00005AED File Offset: 0x00003CED
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00005AF5 File Offset: 0x00003CF5
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bUpg")]
		public bool Upgrade { get; set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00005AFE File Offset: 0x00003CFE
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00005B06 File Offset: 0x00003D06
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bHouse")]
		public bool HouseItem { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00005B0F File Offset: 0x00003D0F
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00005B17 File Offset: 0x00003D17
		[JsonProperty("iRty")]
		public int iRty { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00005B20 File Offset: 0x00003D20
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00005B28 File Offset: 0x00003D28
		[JsonProperty("bQuest")]
		public int Quest { get; set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00005B31 File Offset: 0x00003D31
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00005B39 File Offset: 0x00003D39
		[JsonProperty("sName")]
		public string Name { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00005B42 File Offset: 0x00003D42
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00005B4A File Offset: 0x00003D4A
		[JsonProperty("iQSValue")]
		public int iQSValue { get; set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00005B53 File Offset: 0x00003D53
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00005B5B File Offset: 0x00003D5B
		[JsonProperty("sReqQuests")]
		public int RequiredQuest { get; set; }
	}
}
