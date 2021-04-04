using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Item
{
	// Token: 0x0200017B RID: 379
	public class CmdBankTransfer : IBotCommand
	{
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00007F4A File Offset: 0x0000614A
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00007F52 File Offset: 0x00006152
		public bool TransferFromBank { get; set; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x00007F5B File Offset: 0x0000615B
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00007F63 File Offset: 0x00006163
		public string ItemName { get; set; }

		// Token: 0x06000969 RID: 2409 RVA: 0x0003325C File Offset: 0x0003145C
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Others;
			if (this.TransferFromBank)
			{
				if (Player.Bank.ContainsItem(this.ItemName, "*"))
				{
					Player.Bank.TransferFromBank(this.ItemName);
					await instance.WaitUntil(() => !Player.Bank.ContainsItem(this.ItemName, "*"), null, 15);
				}
			}
			else if (Player.Inventory.ContainsItem(this.ItemName, "*"))
			{
				Player.Bank.TransferToBank(this.ItemName);
				await instance.WaitUntil(() => !Player.Inventory.ContainsItem(this.ItemName, "*"), null, 15);
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00007F6C File Offset: 0x0000616C
		public override string ToString()
		{
			return (this.TransferFromBank ? "Bank -> Inv: " : "Inv -> Bank: ") + this.ItemName;
		}
	}
}
