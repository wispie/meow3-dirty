using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Item
{
	// Token: 0x02000179 RID: 377
	public class CmdBankSwap : IBotCommand
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00007EA8 File Offset: 0x000060A8
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00007EB0 File Offset: 0x000060B0
		public string BankItemName { get; set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00007EB9 File Offset: 0x000060B9
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00007EC1 File Offset: 0x000060C1
		public string InventoryItemName { get; set; }

		// Token: 0x0600095E RID: 2398 RVA: 0x0003311C File Offset: 0x0003131C
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Others;
			if (this.<Execute>g__CanExecute|8_1())
			{
				Player.Bank.Swap(this.InventoryItemName, this.BankItemName);
				await instance.WaitUntil(() => !this.<Execute>g__CanExecute|8_1(), null, 15);
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00007ECA File Offset: 0x000060CA
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Bank swap {",
				this.BankItemName,
				", ",
				this.InventoryItemName,
				"}"
			});
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00007F0C File Offset: 0x0000610C
		[CompilerGenerated]
		private bool <Execute>g__CanExecute|8_1()
		{
			return Player.Bank.ContainsItem(this.BankItemName, "*") && Player.Inventory.ContainsItem(this.InventoryItemName, "*");
		}
	}
}
