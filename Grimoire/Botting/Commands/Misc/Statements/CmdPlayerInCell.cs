using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x020001B3 RID: 435
	public class CmdPlayerInCell : StatementCommand, IBotCommand
	{
		// Token: 0x06000A37 RID: 2615 RVA: 0x000085F0 File Offset: 0x000067F0
		public CmdPlayerInCell()
		{
			base.Tag = "Player";
			base.Text = "Player is in cell";
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00035D6C File Offset: 0x00033F6C
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
			if (!IsExists)
			{
				int index = instance.Index;
				instance.Index = index + 1;
				Console.WriteLine("-> ?");
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0000860E File Offset: 0x0000680E
		public override string ToString()
		{
			return "Player is in cell: " + base.Value1;
		}
	}
}
