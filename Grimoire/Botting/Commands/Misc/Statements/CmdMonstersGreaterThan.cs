using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000153 RID: 339
	public class CmdMonstersGreaterThan : StatementCommand, IBotCommand
	{
		// Token: 0x060008C2 RID: 2242 RVA: 0x00007867 File Offset: 0x00005A67
		public CmdMonstersGreaterThan()
		{
			base.Tag = "Monster";
			base.Text = "Count is greater than";
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0003159C File Offset: 0x0002F79C
		public Task Execute(IBotEngine instance)
		{
			if (World.VisibleMonsters.Count <= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00007885 File Offset: 0x00005A85
		public override string ToString()
		{
			return "Monster count is greater than: " + base.Value1;
		}
	}
}
