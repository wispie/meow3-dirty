using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x02000119 RID: 281
	public class CmdInt : IBotCommand
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00006F0A File Offset: 0x0000510A
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x00006F12 File Offset: 0x00005112
		public CmdInt.Types type { get; set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00006F1B File Offset: 0x0000511B
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x00006F23 File Offset: 0x00005123
		public string Int { get; set; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00006F2C File Offset: 0x0000512C
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00006F34 File Offset: 0x00005134
		public int Value { get; set; }

		// Token: 0x06000805 RID: 2053 RVA: 0x0002FDAC File Offset: 0x0002DFAC
		public Task Execute(IBotEngine instance)
		{
			switch (this.type)
			{
			case CmdInt.Types.Set:
				if (Configuration.Tempvalues.ContainsKey(this.Int))
				{
					Configuration.Tempvalues[this.Int] = this.Value;
				}
				else
				{
					Configuration.Tempvalues.Add(this.Int, this.Value);
				}
				break;
			case CmdInt.Types.Upper:
			{
				Dictionary<string, int> tempvalues = Configuration.Tempvalues;
				string @int = this.Int;
				int num = tempvalues[@int];
				tempvalues[@int] = num + 1;
				break;
			}
			case CmdInt.Types.Lower:
			{
				Dictionary<string, int> tempvalues2 = Configuration.Tempvalues;
				string @int = this.Int;
				int num = tempvalues2[@int];
				tempvalues2[@int] = num - 1;
				break;
			}
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0002FE58 File Offset: 0x0002E058
		public override string ToString()
		{
			CmdInt.Types type = this.type;
			if (type == CmdInt.Types.Set)
			{
				return string.Format("Set {0}: {1}", this.Int, this.Value);
			}
			if (type != CmdInt.Types.Upper)
			{
				return "Decrease " + this.Int + " by 1";
			}
			return "Increase " + this.Int + " by 1";
		}

		// Token: 0x0200011A RID: 282
		public enum Types
		{
			// Token: 0x04000590 RID: 1424
			Set,
			// Token: 0x04000591 RID: 1425
			Upper,
			// Token: 0x04000592 RID: 1426
			Lower
		}
	}
}
