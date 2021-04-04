using System;
using System.Collections.Generic;
using System.Linq;
using Grimoire.Game;
using Grimoire.Game.Data;
using Newtonsoft.Json.Linq;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x020000A5 RID: 165
	public class HandlerGetQuests : IJsonMessageHandler
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000046F4 File Offset: 0x000028F4
		public string[] HandledCommands { get; } = new string[]
		{
			"getQuests"
		};

		// Token: 0x060003CF RID: 975 RVA: 0x0002B7D4 File Offset: 0x000299D4
		public void Handle(JsonMessage message)
		{
			JToken dataObject = message.DataObject;
			Dictionary<int, Quest> dictionary;
			if (dataObject == null)
			{
				dictionary = null;
			}
			else
			{
				JToken jtoken = dataObject["quests"];
				dictionary = ((jtoken != null) ? jtoken.ToObject<Dictionary<int, Quest>>() : null);
			}
			Dictionary<int, Quest> dictionary2 = dictionary;
			if (dictionary2 != null && dictionary2.Count > 0)
			{
				Player.Quests.OnQuestsLoaded((from q in dictionary2
				select q.Value).ToList<Quest>());
			}
		}
	}
}
