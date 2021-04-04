using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000159 RID: 345
	public class CmdNotInInventory : StatementCommand, IBotCommand
	{
		// Token: 0x060008D5 RID: 2261 RVA: 0x00007992 File Offset: 0x00005B92
		public CmdNotInInventory()
		{
			base.Tag = "Item";
			base.Text = "Is not in inventory";
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00031708 File Offset: 0x0002F908
		public Task Execute(IBotEngine instance)
		{
			if (Player.Inventory.ContainsItem(base.Value1, base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000079B0 File Offset: 0x00005BB0
		public override string ToString()
		{
			return "Item is not in inventory: " + base.Value1 + ", " + base.Value2;
		}
	}
}
