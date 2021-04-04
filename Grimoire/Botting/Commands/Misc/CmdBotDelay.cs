using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x0200010F RID: 271
	public class CmdBotDelay : IBotCommand
	{
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00006D2F File Offset: 0x00004F2F
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x00006D37 File Offset: 0x00004F37
		public int Delay { get; set; }

		// Token: 0x060007D5 RID: 2005 RVA: 0x00006D40 File Offset: 0x00004F40
		public Task Execute(IBotEngine instance)
		{
			instance.Configuration.BotDelay = this.Delay;
			return Task.FromResult<object>(null);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00006D59 File Offset: 0x00004F59
		public override string ToString()
		{
			return string.Format("Set bot delay: {0}", this.Delay);
		}
	}
}
