using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000146 RID: 326
	public class CmdItemNotPickupable : StatementCommand, IBotCommand
	{
		// Token: 0x0600089B RID: 2203 RVA: 0x00007614 File Offset: 0x00005814
		public CmdItemNotPickupable()
		{
			base.Tag = "Item";
			base.Text = "Has not dropped";
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00031298 File Offset: 0x0002F498
		public Task Execute(IBotEngine instance)
		{
			if (World.DropStack.Contains(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00007632 File Offset: 0x00005832
		public override string ToString()
		{
			return "Item has not dropped: " + base.Value1;
		}
	}
}
