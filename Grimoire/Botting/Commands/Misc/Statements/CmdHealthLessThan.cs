using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200013A RID: 314
	public class CmdHealthLessThan : StatementCommand, IBotCommand
	{
		// Token: 0x06000877 RID: 2167 RVA: 0x000073B1 File Offset: 0x000055B1
		public CmdHealthLessThan()
		{
			base.Tag = "This player";
			base.Text = "Health is less than";
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00030FEC File Offset: 0x0002F1EC
		public Task Execute(IBotEngine instance)
		{
			if (Player.Health >= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000073CF File Offset: 0x000055CF
		public override string ToString()
		{
			return "Health is less than: " + base.Value1;
		}
	}
}
