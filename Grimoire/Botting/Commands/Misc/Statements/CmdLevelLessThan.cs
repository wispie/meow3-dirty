using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200014A RID: 330
	public class CmdLevelLessThan : StatementCommand, IBotCommand
	{
		// Token: 0x060008A7 RID: 2215 RVA: 0x000076D4 File Offset: 0x000058D4
		public CmdLevelLessThan()
		{
			base.Tag = "This player";
			base.Text = "Level is less than";
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00031378 File Offset: 0x0002F578
		public Task Execute(IBotEngine instance)
		{
			if (Player.Level >= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000076F2 File Offset: 0x000058F2
		public override string ToString()
		{
			return "Level is less than: " + base.Value1;
		}
	}
}
