using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Combat
{
	// Token: 0x0200019D RID: 413
	public class CmdAttack : IBotCommand
	{
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00008306 File Offset: 0x00006506
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x0000830E File Offset: 0x0000650E
		public string Monster { get; set; }

		// Token: 0x060009E2 RID: 2530 RVA: 0x00034BB8 File Offset: 0x00032DB8
		public async Task Execute(IBotEngine instance)
		{
			Player.AttackMonster(this.Monster);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00008317 File Offset: 0x00006517
		public override string ToString()
		{
			return "Attack " + this.Monster;
		}
	}
}
