using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000160 RID: 352
	public class CmdQuestCompleted : StatementCommand, IBotCommand
	{
		// Token: 0x060008EC RID: 2284 RVA: 0x00007B07 File Offset: 0x00005D07
		public CmdQuestCompleted()
		{
			base.Tag = "Quest";
			base.Text = "Quest can be turned in";
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x000318AC File Offset: 0x0002FAAC
		public Task Execute(IBotEngine instance)
		{
			if (!Player.Quests.CanComplete(int.Parse(base.Value1)))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00007B25 File Offset: 0x00005D25
		public override string ToString()
		{
			return "Quest can be turned in: " + base.Value1;
		}
	}
}
