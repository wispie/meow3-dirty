using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000162 RID: 354
	public class CmdQuestNotAvailable : StatementCommand, IBotCommand
	{
		// Token: 0x060008F2 RID: 2290 RVA: 0x00007B67 File Offset: 0x00005D67
		public CmdQuestNotAvailable()
		{
			base.Tag = "Quest";
			base.Text = "Quest is not available";
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00031924 File Offset: 0x0002FB24
		public Task Execute(IBotEngine instance)
		{
			if (Player.Quests.IsAvailable(int.Parse(base.Value1)))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00007B85 File Offset: 0x00005D85
		public override string ToString()
		{
			return "Quest is not available: " + base.Value1;
		}
	}
}
