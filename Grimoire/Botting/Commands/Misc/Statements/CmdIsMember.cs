using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000144 RID: 324
	public class CmdIsMember : StatementCommand, IBotCommand
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x000075CA File Offset: 0x000057CA
		public CmdIsMember()
		{
			base.Tag = "This player";
			base.Text = "Is Member";
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00031240 File Offset: 0x0002F440
		public Task Execute(IBotEngine instance)
		{
			if (!Player.IsMember)
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000075E8 File Offset: 0x000057E8
		public override string ToString()
		{
			return "Is Member";
		}
	}
}
