using System;
using Grimoire.Tools;

namespace Grimoire.Game.Data
{
	// Token: 0x020000DA RID: 218
	public class Skill
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00005FBE File Offset: 0x000041BE
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00005FC6 File Offset: 0x000041C6
		public string Text { get; set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00005FCF File Offset: 0x000041CF
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00005FD7 File Offset: 0x000041D7
		public Skill.SkillType Type { get; set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00005FE0 File Offset: 0x000041E0
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00005FE8 File Offset: 0x000041E8
		public string Index { get; set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00005FF1 File Offset: 0x000041F1
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00005FF9 File Offset: 0x000041F9
		public int SafeHealth { get; set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00006002 File Offset: 0x00004202
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x0000600A File Offset: 0x0000420A
		public bool SafeMp { get; set; }

		// Token: 0x0600064F RID: 1615 RVA: 0x00006013 File Offset: 0x00004213
		public static string GetSkillName(string index)
		{
			return Flash.Call<string>("GetSkillName", new string[]
			{
				index
			});
		}

		// Token: 0x020000DB RID: 219
		public enum SkillType
		{
			// Token: 0x04000483 RID: 1155
			Normal,
			// Token: 0x04000484 RID: 1156
			Safe,
			// Token: 0x04000485 RID: 1157
			Label
		}
	}
}
