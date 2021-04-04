using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000132 RID: 306
	public class CmdCellIs : StatementCommand, IBotCommand
	{
		// Token: 0x0600085C RID: 2140 RVA: 0x000071FF File Offset: 0x000053FF
		public CmdCellIs()
		{
			base.Tag = "Map";
			base.Text = "Cell is";
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00030DEC File Offset: 0x0002EFEC
		public Task Execute(IBotEngine instance)
		{
			if (!base.Value1.Equals(Player.Cell, StringComparison.OrdinalIgnoreCase))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0000721D File Offset: 0x0000541D
		public override string ToString()
		{
			return "Cell is: " + base.Value1;
		}
	}
}
