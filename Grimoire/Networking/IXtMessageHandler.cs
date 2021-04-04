using System;

namespace Grimoire.Networking
{
	// Token: 0x02000089 RID: 137
	public interface IXtMessageHandler
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000362 RID: 866
		string[] HandledCommands { get; }

		// Token: 0x06000363 RID: 867
		void Handle(XtMessage message);
	}
}
