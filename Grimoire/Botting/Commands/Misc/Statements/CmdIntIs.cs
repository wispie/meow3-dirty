using System;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc.Statements
{
	// Token: 0x02000141 RID: 321
	public class CmdIntIs : StatementCommand, IBotCommand
	{
		// Token: 0x0600088C RID: 2188 RVA: 0x00007528 File Offset: 0x00005728
		public CmdIntIs()
		{
			base.Tag = "Misc";
			base.Text = "Int is";
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00031180 File Offset: 0x0002F380
		public Task Execute(IBotEngine instance)
		{
			if (Configuration.Tempvalues[base.Value1] != int.Parse(base.Value2))
			{
				int index = instance.Index;
				instance.Index = index + 1;
			}
			return Task.FromResult<object>(null);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00007546 File Offset: 0x00005746
		public override string ToString()
		{
			return base.Value1 + " == " + base.Value2;
		}
	}
}
