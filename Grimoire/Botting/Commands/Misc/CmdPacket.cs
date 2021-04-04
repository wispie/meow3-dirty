using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Networking;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x0200012A RID: 298
	public class CmdPacket : IBotCommand
	{
		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00007159 File Offset: 0x00005359
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x00007161 File Offset: 0x00005361
		public string Packet { get; set; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x0000716A File Offset: 0x0000536A
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x00007172 File Offset: 0x00005372
		public bool Client { get; set; }

		// Token: 0x06000844 RID: 2116 RVA: 0x000307D8 File Offset: 0x0002E9D8
		public async Task Execute(IBotEngine instance)
		{
			string text = this.Packet.Replace("{ROOM_ID}", World.RoomId.ToString()).Replace("{ROOM_NUMBER}", World.RoomNumber.ToString()).Replace("PLAYERNAME", Player.Username);
			text = text.Replace("{GETMAP}", Player.Map);
			while (text.Contains("--"))
			{
				text = new Regex("-{1,}", RegexOptions.IgnoreCase).Replace(text, (Match m) => "-");
			}
			text = new Regex("(1e)[0-9]{1,}", RegexOptions.IgnoreCase).Replace(text, (Match m) => "100000");
			if (this.Client)
			{
				await Proxy.Instance.SendToClient(text);
			}
			else
			{
				await Proxy.Instance.SendToServer(text);
			}
			if (text.Contains("%xt%zm%gar%"))
			{
				await Task.Delay(700);
			}
			else
			{
				await Task.Delay(2000);
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0000717B File Offset: 0x0000537B
		public override string ToString()
		{
			return (this.Client ? "Send client packet: " : "Send packet: ") + this.Packet;
		}
	}
}
