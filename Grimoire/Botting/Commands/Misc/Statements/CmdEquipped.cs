using System;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000134 RID: 308
	public class CmdEquipped : StatementCommand, IBotCommand
	{
		// Token: 0x06000862 RID: 2146 RVA: 0x0000725F File Offset: 0x0000545F
		public CmdEquipped()
		{
			base.Tag = "Item";
			base.Text = "Is equipped";
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00030E5C File Offset: 0x0002F05C
		public Task Execute(IBotEngine instance)
		{
			if (!(Player.Inventory.Items.Find((InventoryItem x) => x.Name == base.Value1) ?? new InventoryItem()).IsEquipped)
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0000727D File Offset: 0x0000547D
		public override string ToString()
		{
			return "Item is equipped: " + base.Value1;
		}
	}
}
