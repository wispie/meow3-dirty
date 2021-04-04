using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x02000117 RID: 279
	public class CmdIndex : IBotCommand
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00006EE8 File Offset: 0x000050E8
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00006EF0 File Offset: 0x000050F0
		public CmdIndex.IndexCommand Type { get; set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00006EF9 File Offset: 0x000050F9
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00006F01 File Offset: 0x00005101
		public int Index { get; set; }

		// Token: 0x060007FC RID: 2044 RVA: 0x0002FC98 File Offset: 0x0002DE98
		public Task Execute(IBotEngine instance)
		{
			switch (this.Type)
			{
			case CmdIndex.IndexCommand.Up:
			{
				int num = this.Index + 1;
				if (num > 0)
				{
					int num2 = instance.Index -= num;
					if (num2 > -1)
					{
						instance.Index = num2;
					}
				}
				break;
			}
			case CmdIndex.IndexCommand.Down:
			{
				int num3 = this.Index - 1;
				if (num3 > 0)
				{
					int num4 = instance.Index += num3;
					if (num4 < instance.Configuration.Commands.Count)
					{
						instance.Index = num4;
					}
				}
				break;
			}
			case CmdIndex.IndexCommand.Goto:
			{
				int num5 = this.Index - 1;
				if (num5 > 0)
				{
					instance.Index = num5;
				}
				break;
			}
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0002FD50 File Offset: 0x0002DF50
		public override string ToString()
		{
			CmdIndex.IndexCommand type = this.Type;
			if (type == CmdIndex.IndexCommand.Up)
			{
				return string.Format("Index up: {0}", this.Index);
			}
			if (type == CmdIndex.IndexCommand.Down)
			{
				return string.Format("Index down: {0}", this.Index);
			}
			return string.Format("Goto index: {0}", this.Index);
		}

		// Token: 0x02000118 RID: 280
		public enum IndexCommand
		{
			// Token: 0x04000589 RID: 1417
			Up,
			// Token: 0x0400058A RID: 1418
			Down,
			// Token: 0x0400058B RID: 1419
			Goto
		}
	}
}
