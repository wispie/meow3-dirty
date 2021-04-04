using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Item
{
	// Token: 0x02000191 RID: 401
	public class CmdGetDrop : IBotCommand
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x000081CE File Offset: 0x000063CE
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x000081D6 File Offset: 0x000063D6
		public string ItemName { get; set; }

		// Token: 0x060009B8 RID: 2488 RVA: 0x000343E4 File Offset: 0x000325E4
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Others;
			await Task.Delay(500);
			await World.DropStack.GetDrop(this.ItemName);
			await instance.WaitUntil(() => !World.DropStack.Contains(this.ItemName), null, 15);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000081DF File Offset: 0x000063DF
		public override string ToString()
		{
			return "Get drop: " + this.ItemName;
		}
	}
}
