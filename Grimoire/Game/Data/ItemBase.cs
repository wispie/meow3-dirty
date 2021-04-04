using System;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000CE RID: 206
	public class ItemBase
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0000558C File Offset: 0x0000378C
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00005594 File Offset: 0x00003794
		[JsonProperty("ItemID")]
		public virtual int ID { get; set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0000559D File Offset: 0x0000379D
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x000055A5 File Offset: 0x000037A5
		[JsonProperty("sName")]
		[JsonConverter(typeof(TrimConverter))]
		public virtual string Name { get; set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x000055AE File Offset: 0x000037AE
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x000055B6 File Offset: 0x000037B6
		[JsonProperty("sDesc")]
		public virtual string Description { get; set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x000055BF File Offset: 0x000037BF
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x000055C7 File Offset: 0x000037C7
		[JsonProperty("iQty")]
		public virtual int Quantity { get; set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000055D0 File Offset: 0x000037D0
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000055D8 File Offset: 0x000037D8
		[JsonProperty("iStk")]
		public virtual int MaxStack { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x000055E1 File Offset: 0x000037E1
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x000055E9 File Offset: 0x000037E9
		[JsonProperty("bUpg")]
		[JsonConverter(typeof(StringBoolConverter))]
		public virtual bool Upgrade { get; set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x000055F2 File Offset: 0x000037F2
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x000055FA File Offset: 0x000037FA
		[JsonProperty("bCoins")]
		[JsonConverter(typeof(StringBoolConverter))]
		public virtual bool Coins { get; set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00005603 File Offset: 0x00003803
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x0000560B File Offset: 0x0000380B
		[JsonProperty("sType")]
		public virtual string Category { get; set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00005614 File Offset: 0x00003814
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x0000561C File Offset: 0x0000381C
		[JsonProperty("bTemp")]
		[JsonConverter(typeof(StringBoolConverter))]
		public virtual bool Temp { get; set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00005625 File Offset: 0x00003825
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x0000562D File Offset: 0x0000382D
		[JsonProperty("sFile")]
		public virtual string File { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00005636 File Offset: 0x00003836
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0000563E File Offset: 0x0000383E
		[JsonProperty("sLink")]
		public virtual string Link { get; set; }

		// Token: 0x0600053D RID: 1341 RVA: 0x00005647 File Offset: 0x00003847
		public override string ToString()
		{
			return string.Format("{0} [{1}] x {2}", this.Name, this.ID, this.Quantity);
		}
	}
}
