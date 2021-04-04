using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x02000114 RID: 276
	public class CmdGotoLabel : IBotCommand
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00006E3E File Offset: 0x0000503E
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00006E46 File Offset: 0x00005046
		public string Label { get; set; }

		// Token: 0x060007EA RID: 2026 RVA: 0x0002FAA8 File Offset: 0x0002DCA8
		public Task Execute(IBotEngine instance)
		{
			int num = instance.Configuration.Commands.FindIndex((IBotCommand c) => c is CmdLabel && ((CmdLabel)c).Name.Equals(this.Label, StringComparison.OrdinalIgnoreCase));
			if (num > -1)
			{
				instance.Index = num;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00006E4F File Offset: 0x0000504F
		public override string ToString()
		{
			return "Goto label: " + this.Label;
		}
	}
}
