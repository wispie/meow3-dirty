using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000149 RID: 329
	public class CmdLevelIs : StatementCommand, IBotCommand
	{
		// Token: 0x060008A4 RID: 2212 RVA: 0x000076A4 File Offset: 0x000058A4
		public CmdLevelIs()
		{
			base.Tag = "This player";
			base.Text = "Level is";
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00031340 File Offset: 0x0002F540
		public Task Execute(IBotEngine instance)
		{
			if (Player.Level != int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x000076C2 File Offset: 0x000058C2
		public override string ToString()
		{
			return "Level is: " + base.Value1;
		}
	}
}
