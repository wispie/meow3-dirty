using System;
using System.Threading.Tasks;
using Grimoire.UI;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x02000110 RID: 272
	public class CmdChange : IBotCommand
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00006D70 File Offset: 0x00004F70
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x00006D78 File Offset: 0x00004F78
		public bool Guild { get; set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00006D81 File Offset: 0x00004F81
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x00006D89 File Offset: 0x00004F89
		public string Text { get; set; }

		// Token: 0x060007DC RID: 2012 RVA: 0x0002F8DC File Offset: 0x0002DADC
		public async Task Execute(IBotEngine instance)
		{
			if (this.Guild)
			{
				BotManager.Instance.CustomGuild = this.Text;
			}
			else
			{
				BotManager.Instance.CustomName = this.Text;
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00006D92 File Offset: 0x00004F92
		public override string ToString()
		{
			if (this.Guild)
			{
				return "Guild: " + this.Text;
			}
			return "Name: " + this.Text;
		}
	}
}
