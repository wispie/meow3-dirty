using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000150 RID: 336
	public class CmdMapIsNot : StatementCommand, IBotCommand
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x000077D7 File Offset: 0x000059D7
		public CmdMapIsNot()
		{
			base.Tag = "Map";
			base.Text = "Map is not";
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000314D8 File Offset: 0x0002F6D8
		public Task Execute(IBotEngine instance)
		{
			if ((base.Value1.Contains("-") ? base.Value1.Split(new char[]
			{
				'-'
			})[0] : base.Value1).Equals(Player.Map, StringComparison.OrdinalIgnoreCase))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x000077F5 File Offset: 0x000059F5
		public override string ToString()
		{
			return "Map is not: " + base.Value1;
		}
	}
}
