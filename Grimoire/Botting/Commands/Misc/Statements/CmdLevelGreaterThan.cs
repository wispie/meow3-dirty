using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000148 RID: 328
	public class CmdLevelGreaterThan : StatementCommand, IBotCommand
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x00007674 File Offset: 0x00005874
		public CmdLevelGreaterThan()
		{
			base.Tag = "This player";
			base.Text = "Level is greater than";
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00031308 File Offset: 0x0002F508
		public Task Execute(IBotEngine instance)
		{
			if (Player.Level <= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00007692 File Offset: 0x00005892
		public override string ToString()
		{
			return "Level is greater than: " + base.Value1;
		}
	}
}
