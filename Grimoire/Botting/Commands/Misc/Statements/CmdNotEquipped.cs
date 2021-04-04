using System;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000155 RID: 341
	public class CmdNotEquipped : StatementCommand, IBotCommand
	{
		// Token: 0x060008C8 RID: 2248 RVA: 0x000078C7 File Offset: 0x00005AC7
		public CmdNotEquipped()
		{
			base.Tag = "Item";
			base.Text = "Is not equipped";
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00031614 File Offset: 0x0002F814
		public Task Execute(IBotEngine instance)
		{
			if ((Player.Inventory.Items.Find((InventoryItem x) => x.Name == base.Value1) ?? new InventoryItem()).IsEquipped)
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000078E5 File Offset: 0x00005AE5
		public override string ToString()
		{
			return "Item is not equipped: " + base.Value1;
		}
	}
}
