using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200014F RID: 335
	public class CmdMapIs : StatementCommand, IBotCommand
	{
		// Token: 0x060008B6 RID: 2230 RVA: 0x000077A7 File Offset: 0x000059A7
		public CmdMapIs()
		{
			base.Tag = "Map";
			base.Text = "Map is";
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00031474 File Offset: 0x0002F674
		public Task Execute(IBotEngine instance)
		{
			if (!(base.Value1.Contains("-") ? base.Value1.Split(new char[]
			{
				'-'
			})[0] : base.Value1).Equals(Player.Map, StringComparison.OrdinalIgnoreCase))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000077C5 File Offset: 0x000059C5
		public override string ToString()
		{
			return "Map is: " + base.Value1;
		}
	}
}
