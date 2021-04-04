using System;
using Grimoire.Game;
using Grimoire.Game.Data;
using Newtonsoft.Json.Linq;

namespace Grimoire.Networking.Handlers
{
	// Token: 0x020000A8 RID: 168
	public class HandlerLoadShop : IJsonMessageHandler
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00004751 File Offset: 0x00002951
		public string[] HandledCommands { get; } = new string[]
		{
			"loadShop"
		};

		// Token: 0x060003D8 RID: 984 RVA: 0x0002B848 File Offset: 0x00029A48
		public void Handle(JsonMessage message)
		{
			JToken jtoken = message.DataObject["shopinfo"];
			if (jtoken != null)
			{
				World.OnShopLoaded(jtoken.ToObject<ShopInfo>());
			}
		}
	}
}
