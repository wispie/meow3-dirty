using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.UI;

namespace Grimoire.Botting.Commands.Misc
{
	// Token: 0x0200011E RID: 286
	public class CmdLog : IBotCommand
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00006FB4 File Offset: 0x000051B4
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00006FBC File Offset: 0x000051BC
		public string Text { get; set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00006FC5 File Offset: 0x000051C5
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00006FCD File Offset: 0x000051CD
		public bool Debug { get; set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00006FD6 File Offset: 0x000051D6
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00006FDE File Offset: 0x000051DE
		private bool Clear { get; set; }

		// Token: 0x0600081C RID: 2076 RVA: 0x000300C8 File Offset: 0x0002E2C8
		public async Task Execute(IBotEngine instance)
		{
			string text = this.Text;
			text = text.Replace("{USERNAME}", Player.Username);
			text = text.Replace("{MAP}", Player.Map).Replace("{ROOM_ID}", World.RoomId.ToString());
			text = text.Replace("{GOLD}", Player.Gold.ToString());
			text = text.Replace("{LEVEL}", Player.Level.ToString());
			text = text.Replace("{CELL}", Player.Cell).Replace("{PAD}", Player.Pad);
			text = text.Replace("{HEALTH}", Player.Health.ToString()).Replace("{MANA}", Player.Mana.ToString());
			text = text.Replace("{TIME}", string.Format("{0:HH:mm:ss}", DateTime.Now));
			text = text.Replace("{TIME: 12}", string.Format("{0:hh:mm:ss tt}", DateTime.Now));
			text = text.Replace("{TIME: 24}", string.Format("{0:HH:mm:ss}", DateTime.Now));
			text = new Regex("{ITEM:\\s*(.*?)}", RegexOptions.IgnoreCase).Replace(text, (Match m) => string.Format("{0}", (Player.Inventory.Items.Find((InventoryItem x) => x.Name == m.Groups[1].Value) ?? new InventoryItem()).Quantity));
			text = new Regex("{ITEM MAX:\\s*(.*?)}", RegexOptions.IgnoreCase).Replace(text, (Match m) => string.Format("{0}", (Player.Inventory.Items.Find((InventoryItem x) => x.Name == m.Groups[1].Value) ?? new InventoryItem()).MaxStack));
			text = new Regex("{REP XP:\\s*(.*?)}", RegexOptions.IgnoreCase).Replace(text, (Match m) => string.Format("{0}/", (Player.Factions.Find((Faction x) => x.Name == m.Groups[1].Value) ?? new Faction()).Rep) + string.Format("{0}", (Player.Factions.Find((Faction x) => x.Name == m.Groups[1].Value) ?? new Faction()).RequiredRep));
			text = new Regex("{REP CURRENT:\\s*(.*?)}", RegexOptions.IgnoreCase).Replace(text, (Match m) => string.Format("{0}", (Player.Factions.Find((Faction x) => x.Name == m.Groups[1].Value) ?? new Faction()).Rep));
			text = new Regex("{REP REMAINING:\\s*(.*?)}", RegexOptions.IgnoreCase).Replace(text, (Match m) => string.Format("{0}", (Player.Factions.Find((Faction x) => x.Name == m.Groups[1].Value) ?? new Faction()).RemainingRep));
			text = new Regex("{REP REQUIRED:\\s*(.*?)}", RegexOptions.IgnoreCase).Replace(text, (Match m) => string.Format("{0}", (Player.Factions.Find((Faction x) => x.Name == m.Groups[1].Value) ?? new Faction()).RequiredRep));
			text = new Regex("{REP RANK:\\s*(.*?)}", RegexOptions.IgnoreCase).Replace(text, (Match m) => string.Format("{0}", (Player.Factions.Find((Faction x) => x.Name == m.Groups[1].Value) ?? new Faction()).Rank));
			text = new Regex("{REP TOTAL:\\s*(.*?)}", RegexOptions.IgnoreCase).Replace(text, (Match m) => string.Format("{0}", (Player.Factions.Find((Faction x) => x.Name == m.Groups[1].Value) ?? new Faction()).TotalRep));
			text = new Regex("{INT VALUE:\\s*(.*?)}", RegexOptions.IgnoreCase).Replace(text, (Match m) => string.Format("{0}", Configuration.Tempvalues[m.Groups[1].Value]));
			text += "\r\n";
			if (this.Debug)
			{
				if (this.Clear)
				{
					LogForm.Instance.txtLogDebug.Clear();
				}
				else
				{
					LogForm.Instance.AppendDebug(text);
				}
			}
			else if (this.Clear)
			{
				LogForm.Instance.txtLogScript.Clear();
			}
			else
			{
				LogForm.Instance.AppendScript(text, false);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00030110 File Offset: 0x0002E310
		public override string ToString()
		{
			string str = this.Debug ? "Debug" : "Script";
			this.Clear = this.Text.Contains("{CLEAR}");
			if (!this.Clear)
			{
				return "Log " + str + ": " + this.Text;
			}
			return "Clear " + str;
		}
	}
}
