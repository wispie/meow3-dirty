using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000140 RID: 320
	public class CmdIntGreaterThan : StatementCommand, IBotCommand
	{
		// Token: 0x06000889 RID: 2185 RVA: 0x000074F2 File Offset: 0x000056F2
		public CmdIntGreaterThan()
		{
			base.Tag = "Misc";
			base.Text = "Int Greater Than";
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00031140 File Offset: 0x0002F340
		public Task Execute(IBotEngine instance)
		{
			if (Configuration.Tempvalues[base.Value1] < int.Parse(base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00007510 File Offset: 0x00005710
		public override string ToString()
		{
			return base.Value1 + " > " + base.Value2;
		}
	}
}
