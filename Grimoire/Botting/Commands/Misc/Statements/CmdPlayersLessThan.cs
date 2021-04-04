using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200015E RID: 350
	public class CmdPlayersLessThan : StatementCommand, IBotCommand
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x00007AA7 File Offset: 0x00005CA7
		public CmdPlayersLessThan()
		{
			base.Tag = "Player";
			base.Text = "Count is less than";
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00031834 File Offset: 0x0002FA34
		public Task Execute(IBotEngine instance)
		{
			if (World.PlayersInMap.Count >= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00007AC5 File Offset: 0x00005CC5
		public override string ToString()
		{
			return "Player count is less than: " + base.Value1;
		}
	}
}
