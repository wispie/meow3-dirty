using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200013F RID: 319
	public class CmdInTemp : StatementCommand, IBotCommand
	{
		// Token: 0x06000886 RID: 2182 RVA: 0x000074B7 File Offset: 0x000056B7
		public CmdInTemp()
		{
			base.Tag = "Item";
			base.Text = "Is in temp inventory";
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00031104 File Offset: 0x0002F304
		public Task Execute(IBotEngine instance)
		{
			if (!Player.TempInventory.ContainsItem(base.Value1, base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000074D5 File Offset: 0x000056D5
		public override string ToString()
		{
			return "Is in temp inventory: " + base.Value1 + ", " + base.Value2;
		}
	}
}
