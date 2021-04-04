using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Map
{
	// Token: 0x0200016B RID: 363
	public class CmdMoveToCell : IBotCommand
	{
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00007D14 File Offset: 0x00005F14
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00007D1C File Offset: 0x00005F1C
		public string Cell { get; set; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00007D25 File Offset: 0x00005F25
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00007D2D File Offset: 0x00005F2D
		public string Pad { get; set; }

		// Token: 0x06000925 RID: 2341 RVA: 0x000324B0 File Offset: 0x000306B0
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Others;
			while (!Player.Cell.Equals(this.Cell, StringComparison.OrdinalIgnoreCase))
			{
				Player.MoveToCell(this.Cell, this.Pad);
				await Task.Delay(500);
			}
			BotData.BotCell = this.Cell;
			BotData.BotPad = this.Pad;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00007D36 File Offset: 0x00005F36
		public override string ToString()
		{
			return "Move to cell: " + this.Cell + ", " + this.Pad;
		}
	}
}
