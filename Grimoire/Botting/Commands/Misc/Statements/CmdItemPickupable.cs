using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000147 RID: 327
	public class CmdItemPickupable : StatementCommand, IBotCommand
	{
		// Token: 0x0600089E RID: 2206 RVA: 0x00007644 File Offset: 0x00005844
		public CmdItemPickupable()
		{
			base.Tag = "Item";
			base.Text = "Has dropped";
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000312D0 File Offset: 0x0002F4D0
		public Task Execute(IBotEngine instance)
		{
			if (!World.DropStack.Contains(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00007662 File Offset: 0x00005862
		public override string ToString()
		{
			return "Item has dropped: " + base.Value1;
		}
	}
}
