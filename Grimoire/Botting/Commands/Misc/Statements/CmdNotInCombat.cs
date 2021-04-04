using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000157 RID: 343
	public class CmdNotInCombat : StatementCommand, IBotCommand
	{
		// Token: 0x060008CF RID: 2255 RVA: 0x00007932 File Offset: 0x00005B32
		public CmdNotInCombat()
		{
			base.Tag = "This player";
			base.Text = "Not in combat";
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000316A0 File Offset: 0x0002F8A0
		public Task Execute(IBotEngine instance)
		{
			if (Player.CurrentState == Player.State.InCombat)
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00007950 File Offset: 0x00005B50
		public override string ToString()
		{
			return "Is not in combat";
		}
	}
}
