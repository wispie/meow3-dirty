using System;

namespace Grimoire.Networking
{
	// Token: 0x02000088 RID: 136
	public interface IXmlMessageHandler
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000360 RID: 864
		string[] HandledCommands { get; }

		// Token: 0x06000361 RID: 865
		void Handle(XmlMessage message);
	}
}
