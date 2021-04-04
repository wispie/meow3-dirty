using System;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000136 RID: 310
	public class CmdFactionRankLessThan : StatementCommand, IBotCommand
	{
		// Token: 0x0600086A RID: 2154 RVA: 0x000072EB File Offset: 0x000054EB
		public CmdFactionRankLessThan()
		{
			base.Tag = "This player";
			base.Text = "Faction Rank is less than";
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00030EF8 File Offset: 0x0002F0F8
		public Task Execute(IBotEngine instance)
		{
			if (Player.Factions.Find((Faction m) => m.Name == base.Value1).Rank >= int.Parse(base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00007309 File Offset: 0x00005509
		public override string ToString()
		{
			return base.Value1 + " Rank is less than: " + base.Value2;
		}
	}
}
