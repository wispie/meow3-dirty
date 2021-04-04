using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x02000130 RID: 304
	public class CmdToggleProvoke : IBotCommand
	{
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x000071E0 File Offset: 0x000053E0
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x000071E8 File Offset: 0x000053E8
		public int Type { get; set; }

		// Token: 0x06000857 RID: 2135 RVA: 0x00030CF0 File Offset: 0x0002EEF0
		public async Task Execute(IBotEngine instance)
		{
			bool flag = OptionsManager.ProvokeMonsters;
			int type = this.Type;
			flag = (type != 0 && (type == 1 || !flag));
			OptionsManager.ProvokeMonsters = flag;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00030D38 File Offset: 0x0002EF38
		public override string ToString()
		{
			int type = this.Type;
			if (type == 0)
			{
				return "Provoke Off";
			}
			if (type != 1)
			{
				return "Provoke Toggle";
			}
			return "Provoke On";
		}
	}
}
