using System;

namespace Grimoire.UI
{
	// Token: 0x02000055 RID: 85
	public class Item : ISetInterface
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00003798 File Offset: 0x00001998
		// (set) Token: 0x0600024F RID: 591 RVA: 0x000037A0 File Offset: 0x000019A0
		public string Type { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000037A9 File Offset: 0x000019A9
		// (set) Token: 0x06000251 RID: 593 RVA: 0x000037B1 File Offset: 0x000019B1
		public string Name { get; set; }

		// Token: 0x06000252 RID: 594 RVA: 0x000037BA File Offset: 0x000019BA
		public override string ToString()
		{
			return "[" + this.Type + "] : " + this.Name;
		}
	}
}
