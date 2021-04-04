using System;
using Newtonsoft.Json.Linq;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x020000A2 RID: 162
	public class HandlerAnimations : IJsonMessageHandler
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00004695 File Offset: 0x00002895
		public string[] HandledCommands { get; } = new string[]
		{
			"ct"
		};

		// Token: 0x060003C7 RID: 967 RVA: 0x0002B6D8 File Offset: 0x000298D8
		public void Handle(JsonMessage message)
		{
			if (message.DataObject["anims"] != null)
			{
				message.DataObject["anims"] = new JArray();
			}
			if (message.DataObject["a"] != null)
			{
				message.DataObject["a"] = new JArray();
			}
		}
	}
}
