using System;
using System.Linq;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x02000112 RID: 274
	public class CmdDelay : IBotCommand
	{
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00006DCB File Offset: 0x00004FCB
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00006DD3 File Offset: 0x00004FD3
		public int Delay { get; set; }

		// Token: 0x060007E3 RID: 2019 RVA: 0x0002F9A8 File Offset: 0x0002DBA8
		public async Task Execute(IBotEngine instance)
		{
			await Task.Delay(this.Delay);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00006DDC File Offset: 0x00004FDC
		public override string ToString()
		{
			return "Delay: " + (this.badnumbers.Contains(this.Delay) ? (this.Delay + 1) : this.Delay);
		}

		// Token: 0x0400057A RID: 1402
		private readonly int[] badnumbers = new int[]
		{
			420,
			69,
			666,
			6969,
			1337,
			1111,
			2222,
			3333,
			4444,
			5555,
			6666,
			7777,
			8888,
			9999,
			10000
		};
	}
}
