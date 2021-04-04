using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200014D RID: 333
	public class CmdManaGreaterThan : StatementCommand, IBotCommand
	{
		// Token: 0x060008B0 RID: 2224 RVA: 0x00007747 File Offset: 0x00005947
		public CmdManaGreaterThan()
		{
			base.Tag = "This player";
			base.Text = "Mana is greater than";
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00031404 File Offset: 0x0002F604
		public Task Execute(IBotEngine instance)
		{
			if (Player.Mana <= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00007765 File Offset: 0x00005965
		public override string ToString()
		{
			return "Mana is greater than: " + base.Value1;
		}
	}
}
