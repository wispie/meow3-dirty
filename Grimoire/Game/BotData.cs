using System;
using System.Collections.Generic;

namespace Grimoire.Game
{
	// Token: 0x020000AE RID: 174
	public static class BotData
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00004854 File Offset: 0x00002A54
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x0000485B File Offset: 0x00002A5B
		public static string BotMap { get; set; } = null;

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00004863 File Offset: 0x00002A63
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x0000486A File Offset: 0x00002A6A
		public static string BotCell { get; set; } = null;

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00004872 File Offset: 0x00002A72
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00004879 File Offset: 0x00002A79
		public static string BotPad { get; set; } = null;

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00004881 File Offset: 0x00002A81
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00004888 File Offset: 0x00002A88
		public static BotData.State BotState { get; set; } = BotData.State.Others;

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00004890 File Offset: 0x00002A90
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00004897 File Offset: 0x00002A97
		public static string BotSkill { get; set; } = null;

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000489F File Offset: 0x00002A9F
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x000048A6 File Offset: 0x00002AA6
		public static Dictionary<string, int> SkillSet { get; set; } = new Dictionary<string, int>();

		// Token: 0x04000371 RID: 881
		public static List<string> DropList = new List<string>();

		// Token: 0x020000AF RID: 175
		public enum State
		{
			// Token: 0x04000379 RID: 889
			Others,
			// Token: 0x0400037A RID: 890
			Transaction,
			// Token: 0x0400037B RID: 891
			Move,
			// Token: 0x0400037C RID: 892
			Combat,
			// Token: 0x0400037D RID: 893
			Rest,
			// Token: 0x0400037E RID: 894
			Quest
		}
	}
}
