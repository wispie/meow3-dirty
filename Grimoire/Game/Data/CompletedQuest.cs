using System;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000C6 RID: 198
	public class CompletedQuest
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x000050FD File Offset: 0x000032FD
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00005105 File Offset: 0x00003305
		[JsonProperty("QuestID")]
		public int Id { get; set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0000510E File Offset: 0x0000330E
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00005116 File Offset: 0x00003316
		[JsonProperty("sName")]
		public string Name { get; set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0000511F File Offset: 0x0000331F
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00005127 File Offset: 0x00003327
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bSuccess")]
		public bool Success { get; set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00005130 File Offset: 0x00003330
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00005138 File Offset: 0x00003338
		[JsonProperty("rewardObj")]
		public QuestReward Reward { get; set; }
	}
}
