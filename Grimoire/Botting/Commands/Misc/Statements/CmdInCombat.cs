using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200013C RID: 316
	public class CmdInCombat : StatementCommand, IBotCommand
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x0000741C File Offset: 0x0000561C
		public CmdInCombat()
		{
			base.Tag = "This player";
			base.Text = "Is in combat";
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00031060 File Offset: 0x0002F260
		public Task Execute(IBotEngine instance)
		{
			if (Player.CurrentState != Player.State.InCombat)
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0000743A File Offset: 0x0000563A
		public override string ToString()
		{
			return "Is in combat";
		}
	}
}
