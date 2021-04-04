using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x020001B6 RID: 438
	public class CmdPlayerNotInCell : StatementCommand, IBotCommand
	{
		// Token: 0x06000A3E RID: 2622 RVA: 0x00008620 File Offset: 0x00006820
		public CmdPlayerNotInCell()
		{
			base.Tag = "Player";
			base.Text = "Player is not in cell";
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00035E78 File Offset: 0x00034078
		public Task Execute(IBotEngine instance)
		{
			bool IsExists = false;
			World.RefreshDictionary();
			World.Players.ForEach(delegate(PlayerInfo info)
			{
				if (info.Name == this.Value1.ToLower() && info.Cell.ToLower() == this.Value2.ToLower())
				{
					IsExists = true;
				}
			});
			if (IsExists)
			{
				int index = instance.Index;
				instance.Index = index + 1;
				Console.WriteLine("-> ?");
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0000863E File Offset: 0x0000683E
		public override string ToString()
		{
			return "Player is not in cell: " + base.Value1;
		}
	}
}
