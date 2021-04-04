using System;
using System.Linq;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200015B RID: 347
	public class CmdPlayerInRoom : StatementCommand, IBotCommand
	{
		// Token: 0x060008DB RID: 2267 RVA: 0x00007A08 File Offset: 0x00005C08
		public CmdPlayerInRoom()
		{
			base.Tag = "Player";
			base.Text = "Player is in room";
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00031780 File Offset: 0x0002F980
		public Task Execute(IBotEngine instance)
		{
			if (World.PlayersInMap.FirstOrDefault((string p) => p.Equals(base.Value1, StringComparison.OrdinalIgnoreCase)) == null)
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00007A26 File Offset: 0x00005C26
		public override string ToString()
		{
			return "Player is in room: " + base.Value1;
		}
	}
}
