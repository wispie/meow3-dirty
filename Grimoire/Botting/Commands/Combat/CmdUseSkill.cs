using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Combat
{
	// Token: 0x020001AA RID: 426
	public class CmdUseSkill : IBotCommand
	{
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x000084BD File Offset: 0x000066BD
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x000084C5 File Offset: 0x000066C5
		public string Skill { get; set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x000084CE File Offset: 0x000066CE
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x000084D6 File Offset: 0x000066D6
		public string Index { get; set; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x000084DF File Offset: 0x000066DF
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x000084E7 File Offset: 0x000066E7
		public int SafeHp { get; set; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000084F0 File Offset: 0x000066F0
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x000084F8 File Offset: 0x000066F8
		public int SafeMp { get; set; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00008501 File Offset: 0x00006701
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00008509 File Offset: 0x00006709
		public bool Wait { get; set; }

		// Token: 0x06000A1D RID: 2589 RVA: 0x00035B94 File Offset: 0x00033D94
		public async Task Execute(IBotEngine instance)
		{
			if (this.Wait)
			{
				await Task.Delay(Player.SkillAvailable(this.Index));
			}
			if ((double)Player.Health / (double)Player.HealthMax * 100.0 <= (double)this.SafeHp && (double)Player.Mana / (double)Player.ManaMax * 100.0 <= (double)this.SafeMp)
			{
				if (this.Index != "5")
				{
					Player.AttackMonster("*");
				}
				Player.UseSkill(this.Index);
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00008512 File Offset: 0x00006712
		public override string ToString()
		{
			return "Skill " + this.Skill;
		}
	}
}
