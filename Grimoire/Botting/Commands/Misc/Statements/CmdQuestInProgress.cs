using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000161 RID: 353
	public class CmdQuestInProgress : StatementCommand, IBotCommand
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x00007B37 File Offset: 0x00005D37
		public CmdQuestInProgress()
		{
			base.Tag = "Quest";
			base.Text = "Quest is in progress";
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000318E8 File Offset: 0x0002FAE8
		public Task Execute(IBotEngine instance)
		{
			if (!Player.Quests.IsInProgress(int.Parse(base.Value1)))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00007B55 File Offset: 0x00005D55
		public override string ToString()
		{
			return "Quest is in progress: " + base.Value1;
		}
	}
}
