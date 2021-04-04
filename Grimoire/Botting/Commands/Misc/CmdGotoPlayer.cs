using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x02000115 RID: 277
	public class CmdGotoPlayer : IBotCommand
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00006E84 File Offset: 0x00005084
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00006E8C File Offset: 0x0000508C
		public string PlayerName { get; set; }

		// Token: 0x060007F0 RID: 2032 RVA: 0x0002FAE4 File Offset: 0x0002DCE4
		public async Task Execute(IBotEngine instance)
		{
			List<string> playersInMap = World.PlayersInMap;
			Player.GoToPlayer(this.PlayerName);
			if (playersInMap.Any((string p) => p.Equals(this.PlayerName, StringComparison.OrdinalIgnoreCase)))
			{
				await Task.Delay(500);
			}
			else
			{
				await instance.WaitUntil(() => World.PlayersInMap.Any((string p) => p.Equals(this.PlayerName, StringComparison.OrdinalIgnoreCase)) && !World.IsMapLoading, null, 40);
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00006E95 File Offset: 0x00005095
		public override string ToString()
		{
			return "Goto player: " + this.PlayerName;
		}
	}
}
