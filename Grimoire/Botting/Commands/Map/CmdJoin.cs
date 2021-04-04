using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Networking;

namespace Grimoire.Botting.Commands.Map
{
	// Token: 0x02000166 RID: 358
	public class CmdJoin : IBotCommand
	{
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00007C5D File Offset: 0x00005E5D
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x00007C65 File Offset: 0x00005E65
		public string Map { get; set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00007C6E File Offset: 0x00005E6E
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00007C76 File Offset: 0x00005E76
		public string Cell { get; set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00007C7F File Offset: 0x00005E7F
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00007C87 File Offset: 0x00005E87
		public string Pad { get; set; }

		// Token: 0x0600090E RID: 2318 RVA: 0x000319D8 File Offset: 0x0002FBD8
		public async Task Execute(IBotEngine instance)
		{
			BotData.BotState = BotData.State.Move;
			await instance.WaitUntil(() => World.IsActionAvailable(LockActions.Transfer), null, 15);
			string cmdMap = this.Map.Contains("-") ? this.Map.Split(new char[]
			{
				'-'
			})[0] : this.Map;
			string text = this.Map.Substring(cmdMap.Length);
			if (text.Contains("Packet"))
			{
				await instance.WaitUntil(() => World.IsActionAvailable(LockActions.Transfer), null, 15);
				if (!instance.IsRunning || !Player.IsAlive || !Player.IsLoggedIn)
				{
					return;
				}
				string username = Player.Username;
				await Proxy.Instance.SendToServer(string.Concat(new string[]
				{
					"%xt%zm%cmd%1%tfer%",
					username,
					"%",
					cmdMap,
					"-100000"
				}));
				await instance.WaitUntil(() => !World.IsMapLoading, null, 40);
				await Task.Delay(1000);
			}
			if (!cmdMap.Equals(Player.Map, StringComparison.OrdinalIgnoreCase))
			{
				if (!text.Contains("Glitch"))
				{
					await this.TryJoin(instance, cmdMap, text);
				}
				else
				{
					int Max = 9999;
					int Min = 9990;
					if (text.Contains(":"))
					{
						Max = (int)Convert.ToInt16(text.Split(new char[]
						{
							':'
						})[1]);
						Min = (int)Convert.ToInt16(text.Split(new char[]
						{
							':'
						})[2]);
					}
					while (!cmdMap.Equals(Player.Map, StringComparison.OrdinalIgnoreCase) && Max >= Min)
					{
						if (!instance.IsRunning || !Player.IsAlive || !Player.IsLoggedIn)
						{
							return;
						}
						await this.TryJoin(instance, cmdMap, "-" + Max);
						Max--;
					}
					if (!cmdMap.Equals(Player.Map, StringComparison.OrdinalIgnoreCase) || (cmdMap.Equals(Player.Map, StringComparison.OrdinalIgnoreCase) && World.PlayersInMap.Count < 2))
					{
						await this.TryJoin(instance, cmdMap, "");
					}
				}
			}
			if (cmdMap.Equals(Player.Map, StringComparison.OrdinalIgnoreCase))
			{
				if (!Player.Cell.Equals(this.Cell, StringComparison.OrdinalIgnoreCase) && !text.Contains("Packet"))
				{
					Player.MoveToCell(this.Cell, this.Pad);
					await Task.Delay(500);
				}
				World.SetSpawnPoint();
				BotData.BotMap = cmdMap;
				BotData.BotCell = this.Cell;
				BotData.BotPad = this.Pad;
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00031A28 File Offset: 0x0002FC28
		public async Task TryJoin(IBotEngine instance, string MapName, string RoomProp = "")
		{
			await instance.WaitUntil(() => World.IsActionAvailable(LockActions.Transfer), null, 15);
			if (Player.CurrentState == Player.State.InCombat)
			{
				Player.MoveToCell(Player.Cell, Player.Pad);
				await Task.Delay(1250);
			}
			RoomProp = new Regex("-{1,}", RegexOptions.IgnoreCase).Replace(RoomProp, (Match m) => "-");
			RoomProp = new Regex("(1e)[0-9]{1,}", RegexOptions.IgnoreCase).Replace(RoomProp, (Match m) => "100000");
			Player.JoinMap(MapName + RoomProp, this.Cell, this.Pad);
			await instance.WaitUntil(() => Player.Map.Equals(MapName, StringComparison.OrdinalIgnoreCase), null, 5);
			await instance.WaitUntil(() => !World.IsMapLoading, null, 40);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00007C90 File Offset: 0x00005E90
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Join: ",
				this.Map,
				", ",
				this.Cell,
				", ",
				this.Pad
			});
		}
	}
}
