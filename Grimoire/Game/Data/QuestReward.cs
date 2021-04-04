using System;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000D4 RID: 212
	public class QuestReward
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00005B64 File Offset: 0x00003D64
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00005B6C File Offset: 0x00003D6C
		[JsonProperty("iCP")]
		public int ClassPoints { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00005B75 File Offset: 0x00003D75
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x00005B7D File Offset: 0x00003D7D
		[JsonProperty("intGold")]
		public int Gold { get; set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00005B86 File Offset: 0x00003D86
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00005B8E File Offset: 0x00003D8E
		[JsonProperty("intExp")]
		public int Experience { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00005B97 File Offset: 0x00003D97
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00005B9F File Offset: 0x00003D9F
		[JsonProperty("typ")]
		public string Type { get; set; }
	}
}
