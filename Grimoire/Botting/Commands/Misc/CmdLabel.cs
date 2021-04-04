using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x0200011B RID: 283
	public class CmdLabel : IBotCommand
	{
		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00006F3D File Offset: 0x0000513D
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00006F45 File Offset: 0x00005145
		public string Name { get; set; }

		// Token: 0x0600080A RID: 2058 RVA: 0x00006F4E File Offset: 0x0000514E
		public Task Execute(IBotEngine instance)
		{
			return Task.FromResult<object>(null);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00006F56 File Offset: 0x00005156
		public override string ToString()
		{
			return "[" + this.Name.ToUpper() + "]";
		}
	}
}
