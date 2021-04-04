using System;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000C7 RID: 199
	public class Faction
	{
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00005141 File Offset: 0x00003341
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00005149 File Offset: 0x00003349
		[JsonProperty("FactionID")]
		public int ID { get; set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00005152 File Offset: 0x00003352
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x0000515A File Offset: 0x0000335A
		[JsonProperty("sName")]
		public string Name { get; set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00005163 File Offset: 0x00003363
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x0000516B File Offset: 0x0000336B
		[JsonProperty("iRank")]
		public int Rank { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00005174 File Offset: 0x00003374
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x0000517C File Offset: 0x0000337C
		[JsonProperty("iRep")]
		public int TotalRep { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00005185 File Offset: 0x00003385
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x0000518D File Offset: 0x0000338D
		[JsonProperty("iSpillRep")]
		public int Rep { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00005196 File Offset: 0x00003396
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x0000519E File Offset: 0x0000339E
		[JsonProperty("iRepToRank")]
		public int RequiredRep { get; set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x000051A7 File Offset: 0x000033A7
		public int RemainingRep
		{
			get
			{
				return this.RequiredRep - this.Rep;
			}
		}
	}
}
