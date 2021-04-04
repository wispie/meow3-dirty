using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200015A RID: 346
	public class CmdNotInTemp : StatementCommand, IBotCommand
	{
		// Token: 0x060008D8 RID: 2264 RVA: 0x000079CD File Offset: 0x00005BCD
		public CmdNotInTemp()
		{
			base.Tag = "Item";
			base.Text = "Is not in temp";
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00031744 File Offset: 0x0002F944
		public Task Execute(IBotEngine instance)
		{
			if (Player.TempInventory.ContainsItem(base.Value1, base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x000079EB File Offset: 0x00005BEB
		public override string ToString()
		{
			return "Item is not in temp inventory: " + base.Value1 + ", " + base.Value2;
		}
	}
}
