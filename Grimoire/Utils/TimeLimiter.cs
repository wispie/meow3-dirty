using System;
using System.Collections.Generic;

namespace Grimoire.Utils
{
	// Token: 0x0200000C RID: 12
	public class TimeLimiter
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00008AD8 File Offset: 0x00006CD8
		public bool LimitedRun(string name, int delay, Action action)
		{
			int num;
			bool flag = !this._last.TryGetValue(name, out num) || Environment.TickCount - num >= delay;
			if (flag)
			{
				action();
				this._last[name] = Environment.TickCount;
			}
			return flag;
		}

		// Token: 0x04000007 RID: 7
		private Dictionary<string, int> _last = new Dictionary<string, int>();
	}
}
