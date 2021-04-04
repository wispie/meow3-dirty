using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000154 RID: 340
	public class CmdMonstersLessThan : StatementCommand, IBotCommand
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x00007897 File Offset: 0x00005A97
		public CmdMonstersLessThan()
		{
			base.Tag = "Monster";
			base.Text = "Count is less than";
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000315D8 File Offset: 0x0002F7D8
		public Task Execute(IBotEngine instance)
		{
			if (World.VisibleMonsters.Count >= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000078B5 File Offset: 0x00005AB5
		public override string ToString()
		{
			return "Monster count is less than: " + base.Value1;
		}
	}
}
