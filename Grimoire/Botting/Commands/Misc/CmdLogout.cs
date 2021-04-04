using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x02000129 RID: 297
	public class CmdLogout : IBotCommand
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x00007145 File Offset: 0x00005345
		public Task Execute(IBotEngine instance)
		{
			Player.Logout();
			return Task.FromResult<object>(null);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00007152 File Offset: 0x00005352
		public override string ToString()
		{
			return "Logout";
		}
	}
}
