using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200014B RID: 331
	public class CmdListInInv : StatementCommand, IBotCommand
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x00007704 File Offset: 0x00005904
		public CmdListInInv()
		{
			base.Tag = "Item";
			base.Text = "All in List is in inventory";
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000313B0 File Offset: 0x0002F5B0
		public Task Execute(IBotEngine instance)
		{
			if (!Configuration.Instance.Items.TrueForAll((string x) => Player.Inventory.ContainsItem(x, "1")))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00007722 File Offset: 0x00005922
		public override string ToString()
		{
			return "All in List is in inventory";
		}
	}
}
