using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000151 RID: 337
	public class CmdMonsterInRoom : StatementCommand, IBotCommand
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x00007807 File Offset: 0x00005A07
		public CmdMonsterInRoom()
		{
			base.Tag = "Monster";
			base.Text = "Is in room";
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0003153C File Offset: 0x0002F73C
		public Task Execute(IBotEngine instance)
		{
			if (!World.IsMonsterAvailable(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00007825 File Offset: 0x00005A25
		public override string ToString()
		{
			return "Monster is in room: " + base.Value1;
		}
	}
}
