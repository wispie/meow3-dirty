using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x0200012D RID: 301
	public class CmdRestart : IBotCommand
	{
		// Token: 0x0600084D RID: 2125 RVA: 0x00030B38 File Offset: 0x0002ED38
		public async Task Execute(IBotEngine instance)
		{
			instance.Index = -1;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000071C4 File Offset: 0x000053C4
		public override string ToString()
		{
			return "Restart bot";
		}
	}
}
