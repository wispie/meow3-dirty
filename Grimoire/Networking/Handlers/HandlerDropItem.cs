using System;
using System.Collections.Generic;
using System.Linq;
using Grimoire.Botting;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.UI;
using Newtonsoft.Json.Linq;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x020000A3 RID: 163
	public class HandlerDropItem : IJsonMessageHandler
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000046B9 File Offset: 0x000028B9
		public string[] HandledCommands { get; } = new string[]
		{
			"dropItem"
		};

		// Token: 0x060003CA RID: 970 RVA: 0x0002B734 File Offset: 0x00029934
		public void Handle(JsonMessage message)
		{
			JToken dataObject = message.DataObject;
			JToken jtoken = (dataObject != null) ? dataObject["items"] : null;
			if (jtoken != null)
			{
				InventoryItem item = jtoken.ToObject<Dictionary<int, InventoryItem>>().First<KeyValuePair<int, InventoryItem>>().Value;
				if (BotManager.Instance.ActiveBotEngine.IsRunning)
				{
					Configuration configuration = BotManager.Instance.ActiveBotEngine.Configuration;
					message.Send = (!configuration.EnableRejection || !configuration.Drops.All((string d) => !d.Equals(item.Name, StringComparison.OrdinalIgnoreCase)));
				}
				World.OnItemDropped(item);
			}
		}
	}
}
