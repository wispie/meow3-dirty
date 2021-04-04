using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000143 RID: 323
	public class CmdIntLessThan : StatementCommand, IBotCommand
	{
		// Token: 0x06000892 RID: 2194 RVA: 0x00007594 File Offset: 0x00005794
		public CmdIntLessThan()
		{
			base.Tag = "Misc";
			base.Text = "Int Lesser Than";
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00031200 File Offset: 0x0002F400
		public Task Execute(IBotEngine instance)
		{
			if (Configuration.Tempvalues[base.Value1] > int.Parse(base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000075B2 File Offset: 0x000057B2
		public override string ToString()
		{
			return base.Value1 + " < " + base.Value2;
		}
	}
}
