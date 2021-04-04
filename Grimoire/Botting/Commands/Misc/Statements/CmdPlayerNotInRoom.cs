using System;
using System.Linq;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200015C RID: 348
	public class CmdPlayerNotInRoom : StatementCommand, IBotCommand
	{
		// Token: 0x060008DF RID: 2271 RVA: 0x00007A47 File Offset: 0x00005C47
		public CmdPlayerNotInRoom()
		{
			base.Tag = "Player";
			base.Text = "Player is not in room";
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000317BC File Offset: 0x0002F9BC
		public Task Execute(IBotEngine instance)
		{
			if (World.PlayersInMap.FirstOrDefault((string p) => p.Equals(base.Value1, StringComparison.OrdinalIgnoreCase)) != null)
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00007A65 File Offset: 0x00005C65
		public override string ToString()
		{
			return "Player is not in room: " + base.Value1;
		}
	}
}
