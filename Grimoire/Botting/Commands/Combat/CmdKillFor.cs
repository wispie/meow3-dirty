using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Combat
{
	// Token: 0x020001A4 RID: 420
	public class CmdKillFor : IBotCommand
	{
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x000083C2 File Offset: 0x000065C2
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x000083CA File Offset: 0x000065CA
		public string Monster { get; set; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x000083D3 File Offset: 0x000065D3
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x000083DB File Offset: 0x000065DB
		public string ItemName { get; set; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x000083E4 File Offset: 0x000065E4
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x000083EC File Offset: 0x000065EC
		public ItemType ItemType { get; set; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x000083F5 File Offset: 0x000065F5
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x000083FD File Offset: 0x000065FD
		public string Quantity { get; set; }

		// Token: 0x06000A01 RID: 2561 RVA: 0x000355E8 File Offset: 0x000337E8
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Combat;
			CmdKill kill = new CmdKill
			{
				Monster = this.Monster
			};
			if (this.ItemType == ItemType.Items)
			{
				while (instance.IsRunning && Player.IsLoggedIn && Player.IsAlive)
				{
					if (Player.Inventory.ContainsItem(this.ItemName, this.Quantity))
					{
						break;
					}
					await kill.Execute(instance);
					await Task.Delay(1000);
				}
			}
			else
			{
				while (instance.IsRunning && Player.IsLoggedIn && Player.IsAlive && !Player.TempInventory.ContainsItem(this.ItemName, this.Quantity))
				{
					await kill.Execute(instance);
					await Task.Delay(1000);
				}
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00008406 File Offset: 0x00006606
		public override string ToString()
		{
			return "Kill for " + ((this.ItemType == ItemType.Items) ? "items" : "tempitems") + ": " + this.Monster;
		}
	}
}
