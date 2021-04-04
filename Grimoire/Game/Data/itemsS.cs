using System;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000D2 RID: 210
	public class itemsS
	{
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00005834 File Offset: 0x00003A34
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x0000583C File Offset: 0x00003A3C
		[JsonProperty("sIcon")]
		public string Icon { get; set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00005845 File Offset: 0x00003A45
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x0000584D File Offset: 0x00003A4D
		[JsonProperty("ItemID")]
		public int ItemId { get; set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00005856 File Offset: 0x00003A56
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x0000585E File Offset: 0x00003A5E
		[JsonProperty("iLvl")]
		public int Level { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00005867 File Offset: 0x00003A67
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x0000586F File Offset: 0x00003A6F
		[JsonProperty("sLink")]
		public string Link { get; set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00005878 File Offset: 0x00003A78
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00005880 File Offset: 0x00003A80
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bTemp")]
		public bool Temp { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00005889 File Offset: 0x00003A89
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00005891 File Offset: 0x00003A91
		[JsonProperty("sElmt")]
		public string sElmt { get; set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0000589A File Offset: 0x00003A9A
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x000058A2 File Offset: 0x00003AA2
		[JsonProperty("bStaff")]
		public bool Staff { get; set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x000058AB File Offset: 0x00003AAB
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x000058B3 File Offset: 0x00003AB3
		[JsonProperty("iRng")]
		public int iRng { get; set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x000058BC File Offset: 0x00003ABC
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x000058C4 File Offset: 0x00003AC4
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bCoins")]
		public bool Coins { get; set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x000058CD File Offset: 0x00003ACD
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x000058D5 File Offset: 0x00003AD5
		[JsonProperty("iDPS")]
		public int iDPS { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x000058DE File Offset: 0x00003ADE
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x000058E6 File Offset: 0x00003AE6
		[JsonProperty("sES")]
		public string sES { get; set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x000058EF File Offset: 0x00003AEF
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x000058F7 File Offset: 0x00003AF7
		[JsonProperty("bPTR")]
		public int bPTR { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00005900 File Offset: 0x00003B00
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00005908 File Offset: 0x00003B08
		[JsonProperty("iQSIndex")]
		public int iQSIndex { get; set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00005911 File Offset: 0x00003B11
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00005919 File Offset: 0x00003B19
		[JsonProperty("sType")]
		public string Category { get; set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00005922 File Offset: 0x00003B22
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0000592A File Offset: 0x00003B2A
		[JsonProperty("sDesc")]
		public string Description { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00005933 File Offset: 0x00003B33
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x0000593B File Offset: 0x00003B3B
		[JsonProperty("iStk")]
		public int MaxStack { get; set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00005944 File Offset: 0x00003B44
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x0000594C File Offset: 0x00003B4C
		[JsonProperty("iCost")]
		public int Cost { get; set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00005955 File Offset: 0x00003B55
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x0000595D File Offset: 0x00003B5D
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bUpg")]
		public bool Upgrade { get; set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00005966 File Offset: 0x00003B66
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x0000596E File Offset: 0x00003B6E
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bHouse")]
		public bool HouseItem { get; set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00005977 File Offset: 0x00003B77
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0000597F File Offset: 0x00003B7F
		[JsonProperty("iRty")]
		public int iRty { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00005988 File Offset: 0x00003B88
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x00005990 File Offset: 0x00003B90
		[JsonProperty("bQuest")]
		public int Quest { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00005999 File Offset: 0x00003B99
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x000059A1 File Offset: 0x00003BA1
		[JsonProperty("sName")]
		public string Name { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x000059AA File Offset: 0x00003BAA
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x000059B2 File Offset: 0x00003BB2
		[JsonProperty("iQSValue")]
		public int iQSValue { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x000059BB File Offset: 0x00003BBB
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x000059C3 File Offset: 0x00003BC3
		[JsonProperty("sReqQuests")]
		public int RequiredQuest { get; set; }
	}
}
