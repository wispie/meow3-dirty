using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200014E RID: 334
	public class CmdManaLessThan : StatementCommand, IBotCommand
	{
		// Token: 0x060008B3 RID: 2227 RVA: 0x00007777 File Offset: 0x00005977
		public CmdManaLessThan()
		{
			base.Tag = "This player";
			base.Text = "Mana is less than";
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0003143C File Offset: 0x0002F63C
		public Task Execute(IBotEngine instance)
		{
			if (Player.Mana >= int.Parse(base.Value1))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00007795 File Offset: 0x00005995
		public override string ToString()
		{
			return "Mana is less than: " + base.Value1;
		}
	}
}
