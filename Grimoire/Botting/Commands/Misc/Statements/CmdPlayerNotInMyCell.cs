using System;
using System.Threading.Tasks;
using Grimoire.Tools;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x020001B8 RID: 440
	public class CmdPlayerNotInMyCell : StatementCommand, IBotCommand
	{
		// Token: 0x06000A43 RID: 2627 RVA: 0x00008650 File Offset: 0x00006850
		public CmdPlayerNotInMyCell()
		{
			base.Tag = "Player";
			base.Text = "Player is not in my cell";
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00035F30 File Offset: 0x00034130
		public Task Execute(IBotEngine instance)
		{
			if (bool.Parse(Flash.GetResponse(Flash.BuildRequest("GetCellPlayers", new string[]
			{
				base.Value1
			}))))
			{
				Console.WriteLine("Player exists in current cell");
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0000866E File Offset: 0x0000686E
		public override string ToString()
		{
			return "Player is not in my cell: " + base.Value1;
		}
	}
}
