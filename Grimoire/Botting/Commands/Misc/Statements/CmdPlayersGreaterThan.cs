using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200015D RID: 349
	public class CmdPlayersGreaterThan : StatementCommand, IBotCommand
	{
		// Token: 0x060008E3 RID: 2275 RVA: 0x00007A77 File Offset: 0x00005C77
		public CmdPlayersGreaterThan()
		{
			base.Tag = "Player";
			base.Text = "Count is greater than";
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000317F8 File Offset: 0x0002F9F8
		public Task Execute(IBotEngine instance)
		{
			if (World.PlayersInMap.Count <= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00007A95 File Offset: 0x00005C95
		public override string ToString()
		{
			return "Player count is greater than: " + base.Value1;
		}
	}
}
