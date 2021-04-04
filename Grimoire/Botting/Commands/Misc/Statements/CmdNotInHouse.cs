using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000158 RID: 344
	public class CmdNotInHouse : StatementCommand, IBotCommand
	{
		// Token: 0x060008D2 RID: 2258 RVA: 0x00007957 File Offset: 0x00005B57
		public CmdNotInHouse()
		{
			base.Tag = "Item";
			base.Text = "Is not in house";
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000316CC File Offset: 0x0002F8CC
		public Task Execute(IBotEngine instance)
		{
			if (Player.House.ContainsItem(base.Value1, base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00007975 File Offset: 0x00005B75
		public override string ToString()
		{
			return "Item is not in house: " + base.Value1 + ", " + base.Value2;
		}
	}
}
