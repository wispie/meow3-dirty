using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000142 RID: 322
	public class CmdIntIsNot : StatementCommand, IBotCommand
	{
		// Token: 0x0600088F RID: 2191 RVA: 0x0000755E File Offset: 0x0000575E
		public CmdIntIsNot()
		{
			base.Tag = "Misc";
			base.Text = "Int is not";
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000311C0 File Offset: 0x0002F3C0
		public Task Execute(IBotEngine instance)
		{
			if (Configuration.Tempvalues[base.Value1] == int.Parse(base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0000757C File Offset: 0x0000577C
		public override string ToString()
		{
			return base.Value1 + " != " + base.Value2;
		}
	}
}
