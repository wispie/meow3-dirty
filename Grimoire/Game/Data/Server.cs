using System;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000D7 RID: 215
	public class Server
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00005DE1 File Offset: 0x00003FE1
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00005DE9 File Offset: 0x00003FE9
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bOnline")]
		public bool IsOnline { get; set; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00005DF2 File Offset: 0x00003FF2
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00005DFA File Offset: 0x00003FFA
		[JsonProperty("bCount")]
		public int PlayerCount { get; set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00005E03 File Offset: 0x00004003
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00005E0B File Offset: 0x0000400B
		[JsonProperty("sName")]
		public string Name { get; set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00005E14 File Offset: 0x00004014
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00005E1C File Offset: 0x0000401C
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bUpg")]
		public bool IsMemberOnly { get; set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00005E25 File Offset: 0x00004025
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00005E2D File Offset: 0x0000402D
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("iChat")]
		public bool IsChatRestricted { get; set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00005E36 File Offset: 0x00004036
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00005E3E File Offset: 0x0000403E
		[JsonProperty("iPort")]
		public int Port { get; set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00005E47 File Offset: 0x00004047
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00005E4F File Offset: 0x0000404F
		[JsonProperty("sIP")]
		public string Ip { get; set; }

		// Token: 0x06000621 RID: 1569 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsOnline()
		{
			return false;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializePlayerCount()
		{
			return false;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsMemberOnly()
		{
			return false;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsChatRestricted()
		{
			return false;
		}
	}
}
