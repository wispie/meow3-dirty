using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x02000109 RID: 265
	public class CmdBeep : IBotCommand
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00006CCB File Offset: 0x00004ECB
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00006CD3 File Offset: 0x00004ED3
		public int Times { get; set; }

		// Token: 0x060007C2 RID: 1986 RVA: 0x0002F6DC File Offset: 0x0002D8DC
		public async Task Execute(IBotEngine instance)
		{
			for (int i = 0; i < this.Times; i++)
			{
				Console.Beep();
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0002F724 File Offset: 0x0002D924
		public override string ToString()
		{
			return string.Format("Beep {0} Times ", this.Times.ToString());
		}
	}
}
