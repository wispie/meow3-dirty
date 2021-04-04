using System;
using Newtonsoft.Json;

namespace Grimoire.Game
{
	// Token: 0x020000C1 RID: 193
	public class PlayerInfo
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00004E34 File Offset: 0x00003034
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00004E3C File Offset: 0x0000303C
		[JsonProperty("uoName")]
		public string Name { get; set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00004E45 File Offset: 0x00003045
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00004E4D File Offset: 0x0000304D
		[JsonProperty("intHP")]
		public int HP { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00004E56 File Offset: 0x00003056
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00004E5E File Offset: 0x0000305E
		[JsonProperty("intHPMax")]
		public int MaxHP { get; set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00004E67 File Offset: 0x00003067
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00004E6F File Offset: 0x0000306F
		[JsonProperty("intMP")]
		public int MP { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00004E78 File Offset: 0x00003078
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00004E80 File Offset: 0x00003080
		[JsonProperty("afk")]
		public bool AFK { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00004E89 File Offset: 0x00003089
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00004E91 File Offset: 0x00003091
		[JsonProperty("entID")]
		public int EntID { get; set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00004E9A File Offset: 0x0000309A
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00004EA2 File Offset: 0x000030A2
		[JsonProperty("intLevel")]
		public int Level { get; set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00004EAB File Offset: 0x000030AB
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00004EB3 File Offset: 0x000030B3
		[JsonProperty("strFrame")]
		public string Cell { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00004EBC File Offset: 0x000030BC
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00004EC4 File Offset: 0x000030C4
		[JsonProperty("strPad")]
		public string Pad { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00004ECD File Offset: 0x000030CD
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00004ED5 File Offset: 0x000030D5
		[JsonProperty("tx")]
		public float X { get; set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00004EDE File Offset: 0x000030DE
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00004EE6 File Offset: 0x000030E6
		[JsonProperty("ty")]
		public float Y { get; set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00004EEF File Offset: 0x000030EF
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00004EF7 File Offset: 0x000030F7
		[JsonProperty("intState")]
		public int State { get; set; }

		// Token: 0x0600046C RID: 1132 RVA: 0x00004F00 File Offset: 0x00003100
		public override string ToString()
		{
			return string.Format("{0}: {1}", this.EntID, this.Name);
		}
	}
}
