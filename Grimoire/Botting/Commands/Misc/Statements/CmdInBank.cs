using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200013B RID: 315
	public class CmdInBank : StatementCommand, IBotCommand
	{
		// Token: 0x0600087A RID: 2170 RVA: 0x000073E1 File Offset: 0x000055E1
		public CmdInBank()
		{
			base.Tag = "Item";
			base.Text = "Is in bank";
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00031024 File Offset: 0x0002F224
		public Task Execute(IBotEngine instance)
		{
			if (!Player.Bank.ContainsItem(base.Value1, base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000073FF File Offset: 0x000055FF
		public override string ToString()
		{
			return "Item is in bank: " + base.Value1 + ", " + base.Value2;
		}
	}
}
