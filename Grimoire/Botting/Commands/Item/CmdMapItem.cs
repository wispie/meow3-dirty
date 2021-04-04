using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Item
{
	// Token: 0x02000196 RID: 406
	public class CmdMapItem : IBotCommand
	{
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0000825E File Offset: 0x0000645E
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x00008266 File Offset: 0x00006466
		public int ItemId { get; set; }

		// Token: 0x060009CB RID: 2507 RVA: 0x000347C0 File Offset: 0x000329C0
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Others;
			await instance.WaitUntil(() => World.IsActionAvailable(LockActions.GetMapItem), null, 15);
			Player.GetMapItem(this.ItemId);
			await Task.Delay(2000);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0000826F File Offset: 0x0000646F
		public override string ToString()
		{
			return string.Format("Get map item: {0}", this.ItemId);
		}
	}
}
