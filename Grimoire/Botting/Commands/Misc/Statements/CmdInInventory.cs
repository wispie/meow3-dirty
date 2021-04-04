using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200013E RID: 318
	public class CmdInInventory : StatementCommand, IBotCommand
	{
		// Token: 0x06000883 RID: 2179 RVA: 0x0000747C File Offset: 0x0000567C
		public CmdInInventory()
		{
			base.Tag = "Item";
			base.Text = "Is in inventory";
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000310C8 File Offset: 0x0002F2C8
		public Task Execute(IBotEngine instance)
		{
			if (!Player.Inventory.ContainsItem(base.Value1, base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0000749A File Offset: 0x0000569A
		public override string ToString()
		{
			return "Is in inventory: " + base.Value1 + ", " + base.Value2;
		}
	}
}
