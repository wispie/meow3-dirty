using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Map
{
	// Token: 0x0200016D RID: 365
	public class CmdSetSpawn : IBotCommand
	{
		// Token: 0x0600092A RID: 2346 RVA: 0x000325F0 File Offset: 0x000307F0
		public async Task Execute(IBotEngine instance)
		{
			Player.SetSpawnPoint();
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00007D61 File Offset: 0x00005F61
		public override string ToString()
		{
			return "Set Spawnpoint";
		}
	}
}
