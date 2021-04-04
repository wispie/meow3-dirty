using System;

namespace Grimoire.Networking
{
	// Token: 0x0200008B RID: 139
	public class Message
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000368 RID: 872 RVA: 0x000042CF File Offset: 0x000024CF
		// (set) Token: 0x06000369 RID: 873 RVA: 0x000042D7 File Offset: 0x000024D7
		public string RawContent { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000042E0 File Offset: 0x000024E0
		// (set) Token: 0x0600036B RID: 875 RVA: 0x000042E8 File Offset: 0x000024E8
		public string Command { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000042F1 File Offset: 0x000024F1
		// (set) Token: 0x0600036D RID: 877 RVA: 0x000042F9 File Offset: 0x000024F9
		public bool Send { get; set; } = true;
	}
}
