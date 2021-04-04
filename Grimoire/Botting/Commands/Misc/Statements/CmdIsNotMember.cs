using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000145 RID: 325
	public class CmdIsNotMember : StatementCommand, IBotCommand
	{
		// Token: 0x06000898 RID: 2200 RVA: 0x000075EF File Offset: 0x000057EF
		public CmdIsNotMember()
		{
			base.Tag = "This player";
			base.Text = "Is Not Member";
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0003126C File Offset: 0x0002F46C
		public Task Execute(IBotEngine instance)
		{
			if (Player.IsMember)
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0000760D File Offset: 0x0000580D
		public override string ToString()
		{
			return "Is Not Member";
		}
	}
}
