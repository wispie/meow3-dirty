using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Grimoire.Botting;
using Newtonsoft.Json.Linq;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x020000AD RID: 173
	public class HandlerSkills : IJsonMessageHandler
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00004830 File Offset: 0x00002A30
		public string[] HandledCommands { get; } = new string[]
		{
			"sAct"
		};

		// Token: 0x060003E7 RID: 999 RVA: 0x0002B96C File Offset: 0x00029B6C
		public void Handle(JsonMessage message)
		{
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			string a = "0";
			try
			{
				a = config.Get("mana");
			}
			catch
			{
			}
			JToken jtoken = message.DataObject["actions"];
			if (jtoken.Type != JTokenType.Null)
			{
				JToken jtoken2 = jtoken["passive"];
				if (jtoken2.Type != JTokenType.Null)
				{
					foreach (JToken jtoken3 in ((IEnumerable<JToken>)jtoken2))
					{
						jtoken3["range"] = (OptionsManager.InfiniteRange ? "20000" : jtoken3["range"]);
						jtoken3["mp"] = ((a == "1") ? "0" : jtoken3["mp"]);
					}
				}
				JToken jtoken4 = jtoken["active"];
				if (jtoken4.Type != JTokenType.Null)
				{
					foreach (JToken jtoken5 in ((IEnumerable<JToken>)jtoken4))
					{
						jtoken5["range"] = (OptionsManager.InfiniteRange ? "20000" : jtoken5["range"]);
						jtoken5["mp"] = ((a == "1") ? "0" : jtoken5["mp"]);
					}
				}
			}
		}
	}
}
