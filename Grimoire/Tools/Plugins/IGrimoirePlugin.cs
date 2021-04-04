using System;

namespace Grimoire.Tools.Plugins
{
	// Token: 0x0200007E RID: 126
	public interface IGrimoirePlugin
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000339 RID: 825
		string Author { get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600033A RID: 826
		string Description { get; }

		// Token: 0x0600033B RID: 827
		void Load();

		// Token: 0x0600033C RID: 828
		void Unload();
	}
}
