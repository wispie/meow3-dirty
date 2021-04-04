using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000138 RID: 312
	public class CmdGoldLessThan : StatementCommand, IBotCommand
	{
		// Token: 0x06000871 RID: 2161 RVA: 0x00007351 File Offset: 0x00005551
		public CmdGoldLessThan()
		{
			base.Tag = "This player";
			base.Text = "Gold is less than";
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00030F7C File Offset: 0x0002F17C
		public Task Execute(IBotEngine instance)
		{
			if (Player.Gold >= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0000736F File Offset: 0x0000556F
		public override string ToString()
		{
			return "Gold is less than: " + base.Value1;
		}
	}
}
