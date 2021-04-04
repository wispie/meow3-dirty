using System;
using System.Threading;
using System.Threading.Tasks;
using Grimoire.Botting;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.UI;

namespace Grimoire.Tools
{
	// Token: 0x02000058 RID: 88
	public static class AutoRelogin
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000038C3 File Offset: 0x00001AC3
		public static bool IsTemporarilyKicked
		{
			get
			{
				return Flash.Call<bool>("IsTemporarilyKicked", new string[0]);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600026C RID: 620 RVA: 0x000038D5 File Offset: 0x00001AD5
		public static bool AreServersLoaded
		{
			get
			{
				return Flash.Call<bool>("AreServersLoaded", new string[0]);
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000038E7 File Offset: 0x00001AE7
		public static void Login()
		{
			Flash.Call("Login", new string[0]);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000038F9 File Offset: 0x00001AF9
		public static bool ResetServers()
		{
			return Flash.Call<bool>("ResetServers", new string[0]);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000390B File Offset: 0x00001B0B
		public static void Connect(Server server)
		{
			Flash.Call("Connect", new string[]
			{
				server.Name
			});
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000262B4 File Offset: 0x000244B4
		public static async Task Login(Server server, int relogDelay, CancellationTokenSource cts, bool ensureSuccess)
		{
			bool killLag = OptionsManager.LagKiller;
			bool disableAnims = OptionsManager.DisableAnimations;
			bool hidePlayers = OptionsManager.HidePlayers;
			if (killLag)
			{
				OptionsManager.LagKiller = false;
			}
			if (disableAnims)
			{
				OptionsManager.DisableAnimations = false;
			}
			if (hidePlayers)
			{
				OptionsManager.HidePlayers = false;
			}
			if (AutoRelogin.IsTemporarilyKicked)
			{
				await BotManager.Instance.ActiveBotEngine.WaitUntil(() => !AutoRelogin.IsTemporarilyKicked, () => !cts.IsCancellationRequested, 65);
			}
			if (!cts.IsCancellationRequested)
			{
				AutoRelogin.ResetServers();
				AutoRelogin.Login();
				await BotManager.Instance.ActiveBotEngine.WaitUntil(() => AutoRelogin.AreServersLoaded, () => !cts.IsCancellationRequested, 30);
				if (!cts.IsCancellationRequested)
				{
					AutoRelogin.Connect(server);
					await BotManager.Instance.ActiveBotEngine.WaitUntil(() => !World.IsMapLoading, () => !cts.IsCancellationRequested, 40);
					if (!cts.IsCancellationRequested)
					{
						await Task.Delay(relogDelay);
						if (ensureSuccess)
						{
							Task.Run(() => AutoRelogin.EnsureLoginSuccess(cts));
						}
						if (killLag)
						{
							OptionsManager.LagKiller = true;
						}
						if (disableAnims)
						{
							OptionsManager.DisableAnimations = true;
						}
						if (hidePlayers)
						{
							OptionsManager.HidePlayers = true;
						}
					}
				}
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00026314 File Offset: 0x00024514
		private static async Task EnsureLoginSuccess(CancellationTokenSource cts)
		{
			for (int i = 0; i < 20; i++)
			{
				await Task.Delay(1000);
				if (cts.IsCancellationRequested)
				{
					return;
				}
				string map = Player.Map;
				if (!string.IsNullOrEmpty(map) && !map.Equals("name", StringComparison.OrdinalIgnoreCase) && !map.Equals("battleon", StringComparison.OrdinalIgnoreCase))
				{
					break;
				}
			}
			if (Player.Map.Equals("battleon", StringComparison.OrdinalIgnoreCase))
			{
				Player.Logout();
			}
		}
	}
}
