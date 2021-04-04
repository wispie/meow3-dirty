using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000156 RID: 342
	public class CmdNotInBank : StatementCommand, IBotCommand
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x000078F7 File Offset: 0x00005AF7
		public CmdNotInBank()
		{
			base.Tag = "Item";
			base.Text = "Is not in bank";
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00031664 File Offset: 0x0002F864
		public Task Execute(IBotEngine instance)
		{
			if (Player.Bank.ContainsItem(base.Value1, base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00007915 File Offset: 0x00005B15
		public override string ToString()
		{
			return "Item is not in bank: " + base.Value1 + ", " + base.Value2;
		}
	}
}
