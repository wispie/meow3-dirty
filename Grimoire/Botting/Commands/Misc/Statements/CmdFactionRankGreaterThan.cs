using System;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000135 RID: 309
	public class CmdFactionRankGreaterThan : StatementCommand, IBotCommand
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x000072A2 File Offset: 0x000054A2
		public CmdFactionRankGreaterThan()
		{
			base.Tag = "This player";
			base.Text = "Faction Rank is greater than";
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00030EAC File Offset: 0x0002F0AC
		public Task Execute(IBotEngine instance)
		{
			if (Player.Factions.Find((Faction m) => m.Name == base.Value1).Rank < int.Parse(base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000072C0 File Offset: 0x000054C0
		public override string ToString()
		{
			return base.Value1 + " Rank is greater than: " + base.Value2;
		}
	}
}
