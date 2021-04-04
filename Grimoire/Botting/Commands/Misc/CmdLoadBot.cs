using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x0200011C RID: 284
	public class CmdLoadBot : IBotCommand
	{
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00006F72 File Offset: 0x00005172
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00006F7A File Offset: 0x0000517A
		public string BotFileName { get; set; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00006F83 File Offset: 0x00005183
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00006F8B File Offset: 0x0000518B
		public string BotFilePath { get; set; }

		// Token: 0x06000811 RID: 2065 RVA: 0x0002FEBC File Offset: 0x0002E0BC
		public async Task Execute(IBotEngine instance)
		{
			string botFileName = this.BotFileName;
			string botFilePath = this.BotFilePath;
			if (File.Exists(botFilePath))
			{
				try
				{
					string value;
					using (TextReader reader = new StreamReader(botFilePath))
					{
						string text = await reader.ReadToEndAsync();
						value = text;
					}
					TextReader reader = null;
					Configuration configuration = JsonConvert.DeserializeObject<Configuration>(value, new JsonSerializerSettings
					{
						DefaultValueHandling = DefaultValueHandling.Ignore,
						NullValueHandling = NullValueHandling.Ignore,
						TypeNameHandling = TypeNameHandling.All
					});
					if (configuration != null && configuration.Commands.Count > 0)
					{
						instance.Configuration = configuration;
						instance.Index = -1;
						instance.LoadBankItems();
						instance.LoadAllQuests();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00006F94 File Offset: 0x00005194
		public override string ToString()
		{
			return "Load bot: " + this.BotFileName;
		}
	}
}
