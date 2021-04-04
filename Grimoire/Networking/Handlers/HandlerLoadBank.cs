using System;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x020000A7 RID: 167
	public class HandlerLoadBank : IJsonMessageHandler
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0000472D File Offset: 0x0000292D
		public string[] HandledCommands { get; } = new string[]
		{
			"loadBank"
		};

		// Token: 0x060003D5 RID: 981 RVA: 0x00002839 File Offset: 0x00000A39
		public void Handle(JsonMessage message)
		{
		}
	}
}
