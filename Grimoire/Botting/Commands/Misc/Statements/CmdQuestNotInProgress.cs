using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000164 RID: 356
	public class CmdQuestNotInProgress : StatementCommand, IBotCommand
	{
		// Token: 0x060008F8 RID: 2296 RVA: 0x00007BC7 File Offset: 0x00005DC7
		public CmdQuestNotInProgress()
		{
			base.Tag = "Quest";
			base.Text = "Quest is not in progress";
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0003199C File Offset: 0x0002FB9C
		public Task Execute(IBotEngine instance)
		{
			if (Player.Quests.IsInProgress(int.Parse(base.Value1)))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00007BE5 File Offset: 0x00005DE5
		public override string ToString()
		{
			return "Quest is not in progress: " + base.Value1;
		}
	}
}
