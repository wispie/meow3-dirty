using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x0200015F RID: 351
	public class CmdQuestAvailable : StatementCommand, IBotCommand
	{
		// Token: 0x060008E9 RID: 2281 RVA: 0x00007AD7 File Offset: 0x00005CD7
		public CmdQuestAvailable()
		{
			base.Tag = "Quest";
			base.Text = "Quest is available";
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00031870 File Offset: 0x0002FA70
		public Task Execute(IBotEngine instance)
		{
			if (!Player.Quests.IsAvailable(int.Parse(base.Value1)))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00007AF5 File Offset: 0x00005CF5
		public override string ToString()
		{
			return "Quest is available: " + base.Value1;
		}
	}
}
