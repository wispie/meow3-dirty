using System;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Tools.Buyback;

namespace Grimoire.Botting.Commands.Item
{
	// Token: 0x02000181 RID: 385
	public class CmdBuyBack : IBotCommand
	{
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00008045 File Offset: 0x00006245
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x0000804D File Offset: 0x0000624D
		public string ItemName { get; set; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x00008056 File Offset: 0x00006256
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x0000805E File Offset: 0x0000625E
		public int PageNumberCap { get; set; }

		// Token: 0x06000987 RID: 2439 RVA: 0x00033830 File Offset: 0x00031A30
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Transaction;
			if (!Player.Inventory.ContainsItem(this.ItemName, "*"))
			{
				try
				{
					await Task.Run(async delegate()
					{
						using (AutoBuyBack abb = new AutoBuyBack())
						{
							await abb.Perform(this.ItemName, this.PageNumberCap);
						}
						AutoBuyBack abb = null;
					});
					Player.Logout();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00008067 File Offset: 0x00006267
		public override string ToString()
		{
			return "Buy back: " + this.ItemName;
		}
	}
}
