using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Combat
{
	// Token: 0x020001AC RID: 428
	public class CmdSkillSet : IBotCommand
	{
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00008532 File Offset: 0x00006732
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x0000853A File Offset: 0x0000673A
		public string Name { get; set; }

		// Token: 0x06000A24 RID: 2596 RVA: 0x00008543 File Offset: 0x00006743
		public Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Combat;
			BotData.BotSkill = this.Name;
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0000855C File Offset: 0x0000675C
		public override string ToString()
		{
			return "Skill Set: " + this.Name;
		}
	}
}
