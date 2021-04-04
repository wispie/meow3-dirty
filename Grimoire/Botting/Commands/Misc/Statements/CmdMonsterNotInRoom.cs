using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000152 RID: 338
	public class CmdMonsterNotInRoom : StatementCommand, IBotCommand
	{
		// Token: 0x060008BF RID: 2239 RVA: 0x00007837 File Offset: 0x00005A37
		public CmdMonsterNotInRoom()
		{
			base.Tag = "Monster";
			base.Text = "Is not in room";
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0003156C File Offset: 0x0002F76C
		public Task Execute(IBotEngine instance)
		{
			if (World.IsMonsterAvailable(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00007855 File Offset: 0x00005A55
		public override string ToString()
		{
			return "Monster is not in room: " + base.Value1;
		}
	}
}
