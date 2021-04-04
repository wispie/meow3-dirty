using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000163 RID: 355
	public class CmdQuestNotCompleted : StatementCommand, IBotCommand
	{
		// Token: 0x060008F5 RID: 2293 RVA: 0x00007B97 File Offset: 0x00005D97
		public CmdQuestNotCompleted()
		{
			base.Tag = "Quest";
			base.Text = "Quest can not be turned in";
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00031960 File Offset: 0x0002FB60
		public Task Execute(IBotEngine instance)
		{
			if (Player.Quests.CanComplete(int.Parse(base.Value1)))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00007BB5 File Offset: 0x00005DB5
		public override string ToString()
		{
			return "Quest cannot be turned in: " + base.Value1;
		}
	}
}
