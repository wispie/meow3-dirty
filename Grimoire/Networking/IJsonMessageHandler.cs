using System;

namespace Grimoire.Networking
{
	// Token: 0x02000087 RID: 135
	public interface IJsonMessageHandler
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600035E RID: 862
		string[] HandledCommands { get; }

		// Token: 0x0600035F RID: 863
		void Handle(JsonMessage message);
	}
}
