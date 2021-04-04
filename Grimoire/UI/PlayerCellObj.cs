using System;
using Newtonsoft.Json;

namespace Grimoire.UI
{
	// Token: 0x020001B2 RID: 434
	public class PlayerCellObj
	{
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x000085CE File Offset: 0x000067CE
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x000085D6 File Offset: 0x000067D6
		[JsonProperty("strUsername")]
		public string StringUsername { get; set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x000085DF File Offset: 0x000067DF
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x000085E7 File Offset: 0x000067E7
		[JsonProperty("strFrame")]
		public string StringFrame { get; set; }
	}
}
