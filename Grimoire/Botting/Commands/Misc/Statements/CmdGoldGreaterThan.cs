using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000137 RID: 311
	public class CmdGoldGreaterThan : StatementCommand, IBotCommand
	{
		// Token: 0x0600086E RID: 2158 RVA: 0x00007321 File Offset: 0x00005521
		public CmdGoldGreaterThan()
		{
			base.Tag = "This player";
			base.Text = "Gold is greater than";
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00030F44 File Offset: 0x0002F144
		public Task Execute(IBotEngine instance)
		{
			if (Player.Gold <= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0000733F File Offset: 0x0000553F
		public override string ToString()
		{
			return "Gold is greater than: " + base.Value1;
		}
	}
}
