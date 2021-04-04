using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Grimoire.Networking;

namespace Grimoire.Tools
{
	// Token: 0x02000077 RID: 119
	public class Spammer
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00003F82 File Offset: 0x00002182
		public static Spammer Instance { get; } = new Spammer();

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000319 RID: 793 RVA: 0x00028AC8 File Offset: 0x00026CC8
		// (remove) Token: 0x0600031A RID: 794 RVA: 0x00028B00 File Offset: 0x00026D00
		public event Action<int> IndexChanged;

		// Token: 0x0600031B RID: 795 RVA: 0x0000208C File Offset: 0x0000028C
		private Spammer()
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00003F89 File Offset: 0x00002189
		public void Start(List<string> packets, int delay)
		{
			this._packets = packets;
			this._delay = delay;
			this._cancellationTokenSource = new CancellationTokenSource();
			Task.Run(new Func<Task>(this.Spam));
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00003FB6 File Offset: 0x000021B6
		public void Stop()
		{
			this._cancellationTokenSource.Cancel(false);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00028B38 File Offset: 0x00026D38
		private async Task Spam()
		{
			int index = 0;
			while (!this._cancellationTokenSource.IsCancellationRequested)
			{
				if (index >= this._packets.Count)
				{
					index = 0;
				}
				Action<int> indexChanged = this.IndexChanged;
				if (indexChanged != null)
				{
					indexChanged(index);
				}
				await Proxy.Instance.SendToServer(this._packets[index++]);
				await Task.Delay(this._delay);
			}
		}

		// Token: 0x040002D4 RID: 724
		private List<string> _packets;

		// Token: 0x040002D5 RID: 725
		private int _delay;

		// Token: 0x040002D6 RID: 726
		private CancellationTokenSource _cancellationTokenSource;
	}
}
