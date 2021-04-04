using System;
using Grimoire.Botting;
using Grimoire.UI;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x020000A1 RID: 161
	public class HandlerLogin : IXtMessageHandler
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00004642 File Offset: 0x00002842
		public string[] HandledCommands { get; } = new string[]
		{
			"loginResponse"
		};

		// Token: 0x060003C4 RID: 964 RVA: 0x0000464A File Offset: 0x0000284A
		public void Handle(XtMessage message)
		{
			LogForm.Instance.AppendDebug(string.Format("Relogin to server: {0} at {1:hh:mm:ss tt} \r\n", Configuration.Instance.Server.Name, DateTime.Now));
		}
	}
}
