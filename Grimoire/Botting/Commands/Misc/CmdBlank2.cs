using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x0200010D RID: 269
	public class CmdBlank2 : IBotCommand
	{
		// Token: 0x060007CC RID: 1996 RVA: 0x0002F84C File Offset: 0x0002DA4C
		public async Task Execute(IBotEngine instance)
		{
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00006CFF File Offset: 0x00004EFF
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x00006D07 File Offset: 0x00004F07
		public string Text { get; set; }

		// Token: 0x060007CF RID: 1999 RVA: 0x00006D10 File Offset: 0x00004F10
		public override string ToString()
		{
			return this.Text ?? "";
		}
	}
}
