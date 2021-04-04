using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000133 RID: 307
	public class CmdCellIsNot : StatementCommand, IBotCommand
	{
		// Token: 0x0600085F RID: 2143 RVA: 0x0000722F File Offset: 0x0000542F
		public CmdCellIsNot()
		{
			base.Tag = "Map";
			base.Text = "Cell is not";
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00030E24 File Offset: 0x0002F024
		public Task Execute(IBotEngine instance)
		{
			if (base.Value1.Equals(Player.Cell, StringComparison.OrdinalIgnoreCase))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0000724D File Offset: 0x0000544D
		public override string ToString()
		{
			return "Cell is not: " + base.Value1;
		}
	}
}
