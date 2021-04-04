using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000139 RID: 313
	public class CmdHealthGreaterThan : StatementCommand, IBotCommand
	{
		// Token: 0x06000874 RID: 2164 RVA: 0x00007381 File Offset: 0x00005581
		public CmdHealthGreaterThan()
		{
			base.Tag = "This player";
			base.Text = "Health is greater than";
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00030FB4 File Offset: 0x0002F1B4
		public Task Execute(IBotEngine instance)
		{
			if (Player.Health <= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0000739F File Offset: 0x0000559F
		public override string ToString()
		{
			return "Health is greater than: " + base.Value1;
		}
	}
}
