using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200013D RID: 317
	public class CmdInHouse : StatementCommand, IBotCommand
	{
		// Token: 0x06000880 RID: 2176 RVA: 0x00007441 File Offset: 0x00005641
		public CmdInHouse()
		{
			base.Tag = "Item";
			base.Text = "Is in house";
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0003108C File Offset: 0x0002F28C
		public Task Execute(IBotEngine instance)
		{
			if (!Player.House.ContainsItem(base.Value1, base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0000745F File Offset: 0x0000565F
		public override string ToString()
		{
			return "Is in house: " + base.Value1 + ", " + base.Value2;
		}
	}
}
