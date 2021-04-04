using System;

namespace Grimoire.Botting
{
	// Token: 0x020000FD RID: 253
	public interface IBotEngine
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000757 RID: 1879
		// (set) Token: 0x06000758 RID: 1880
		bool IsRunning { get; set; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000759 RID: 1881
		// (set) Token: 0x0600075A RID: 1882
		int Index { get; set; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600075B RID: 1883
		// (set) Token: 0x0600075C RID: 1884
		Configuration Configuration { get; set; }

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600075D RID: 1885
		// (remove) Token: 0x0600075E RID: 1886
		event Action<bool> IsRunningChanged;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600075F RID: 1887
		// (remove) Token: 0x06000760 RID: 1888
		event Action<int> IndexChanged;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000761 RID: 1889
		// (remove) Token: 0x06000762 RID: 1890
		event Action<Configuration> ConfigurationChanged;

		// Token: 0x06000763 RID: 1891
		void Start(Configuration config);

		// Token: 0x06000764 RID: 1892
		void Stop();
	}
}
