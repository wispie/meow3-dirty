using System;
using System.Threading.Tasks;
using Grimoire.Game;
using Grimoire.Networking;
using Grimoire.Networking.Handlers;
using Grimoire.Tools;

namespace Grimoire.Botting
{
	// Token: 0x020000FE RID: 254
	public static class OptionsManager
	{
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00006912 File Offset: 0x00004B12
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00006919 File Offset: 0x00004B19
		public static bool InfMana
		{
			get
			{
				return OptionsManager._infMana;
			}
			set
			{
				OptionsManager._infMana = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00006921 File Offset: 0x00004B21
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00006928 File Offset: 0x00004B28
		public static bool IsRunning
		{
			get
			{
				return OptionsManager._isRunning;
			}
			private set
			{
				OptionsManager._isRunning = value;
				Action<bool> stateChanged = OptionsManager.StateChanged;
				if (stateChanged == null)
				{
					return;
				}
				stateChanged(value);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00006940 File Offset: 0x00004B40
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00006947 File Offset: 0x00004B47
		public static bool Buff { get; set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x0000694F File Offset: 0x00004B4F
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00006956 File Offset: 0x00004B56
		public static bool ProvokeMonsters { get; set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x0000695E File Offset: 0x00004B5E
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x00006965 File Offset: 0x00004B65
		public static bool EnemyMagnet { get; set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x0000696D File Offset: 0x00004B6D
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00006974 File Offset: 0x00004B74
		public static bool LagKiller { get; set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x0000697C File Offset: 0x00004B7C
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00006983 File Offset: 0x00004B83
		public static bool SkipCutscenes { get; set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0000698B File Offset: 0x00004B8B
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x00006992 File Offset: 0x00004B92
		public static bool DisableAnimations
		{
			get
			{
				return OptionsManager._disableAnimations;
			}
			set
			{
				OptionsManager._disableAnimations = value;
				if (value)
				{
					Proxy.Instance.RegisterHandler(OptionsManager.HandlerDisableAnimations);
					return;
				}
				Proxy.Instance.UnregisterHandler(OptionsManager.HandlerDisableAnimations);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x000069BC File Offset: 0x00004BBC
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x000069C3 File Offset: 0x00004BC3
		public static bool HidePlayers
		{
			get
			{
				return OptionsManager._hidePlayers;
			}
			set
			{
				OptionsManager._hidePlayers = value;
				if (value)
				{
					Proxy.Instance.RegisterHandler(OptionsManager.HandlerHidePlayers);
					OptionsManager.DestroyPlayers();
					return;
				}
				Proxy.Instance.UnregisterHandler(OptionsManager.HandlerHidePlayers);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x000069F2 File Offset: 0x00004BF2
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x000069F9 File Offset: 0x00004BF9
		public static bool InfiniteRange
		{
			get
			{
				return OptionsManager._infRange;
			}
			set
			{
				OptionsManager._infRange = value;
				if (value)
				{
					OptionsManager.SetInfiniteRange();
				}
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x00006A09 File Offset: 0x00004C09
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00006A10 File Offset: 0x00004C10
		public static int WalkSpeed { get; set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x00006A18 File Offset: 0x00004C18
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00006A1F File Offset: 0x00004C1F
		public static int Timer { get; set; } = 250;

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00006A27 File Offset: 0x00004C27
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x00006A2E File Offset: 0x00004C2E
		public static bool Packet { get; set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x00006A36 File Offset: 0x00004C36
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00006A3D File Offset: 0x00004C3D
		public static bool Untarget { get; set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00006A45 File Offset: 0x00004C45
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00006A4C File Offset: 0x00004C4C
		public static bool AFK
		{
			get
			{
				return OptionsManager._afk;
			}
			set
			{
				OptionsManager._afk = value;
				if (value)
				{
					Proxy.Instance.RegisterHandler(OptionsManager.HandlerAFK1);
					return;
				}
				Proxy.Instance.UnregisterHandler(OptionsManager.HandlerAFK1);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x00006A76 File Offset: 0x00004C76
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00006A7D File Offset: 0x00004C7D
		public static bool AFK2
		{
			get
			{
				return OptionsManager._afk2;
			}
			set
			{
				OptionsManager._afk2 = value;
				if (value)
				{
					Proxy.Instance.RegisterHandler(OptionsManager.HandlerAFK2);
					return;
				}
				Proxy.Instance.UnregisterHandler(OptionsManager.HandlerAFK2);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00006AA7 File Offset: 0x00004CA7
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00006AAE File Offset: 0x00004CAE
		public static bool HideRoom
		{
			get
			{
				return OptionsManager._hideRoom;
			}
			set
			{
				OptionsManager._hideRoom = value;
				if (value)
				{
					Proxy.Instance.RegisterHandler(OptionsManager.HandlerHideRoom);
					return;
				}
				Proxy.Instance.UnregisterHandler(OptionsManager.HandlerHideRoom);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00006AD8 File Offset: 0x00004CD8
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00006ADF File Offset: 0x00004CDF
		public static bool ChangeChat { get; set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00006AE7 File Offset: 0x00004CE7
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00006AEE File Offset: 0x00004CEE
		public static int? SetLevelOnJoin { get; set; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00006AF6 File Offset: 0x00004CF6
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x0002ED0C File Offset: 0x0002CF0C
		public static bool HideYulgar
		{
			get
			{
				return OptionsManager._hideYulgar;
			}
			set
			{
				OptionsManager._hideYulgar = value;
				if (value)
				{
					Proxy.Instance.RegisterHandler(OptionsManager.HandlerYulgar);
					if ((Player.Map.ToLower() ?? "") == "yulgar" && (Player.Cell.ToLower() ?? "") == "upstairs")
					{
						OptionsManager.DestroyPlayers();
						return;
					}
				}
				else
				{
					Proxy.Instance.UnregisterHandler(OptionsManager.HandlerYulgar);
				}
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600078D RID: 1933 RVA: 0x0002ED84 File Offset: 0x0002CF84
		// (remove) Token: 0x0600078E RID: 1934 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		public static event Action<bool> StateChanged;

		// Token: 0x0600078F RID: 1935 RVA: 0x00006AFD File Offset: 0x00004CFD
		private static void SetInfiniteRange()
		{
			Flash.Call("SetInfiniteRange", OptionsManager.empty);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00006B0E File Offset: 0x00004D0E
		private static void SetProvokeMonsters()
		{
			Flash.Call("SetProvokeMonsters", OptionsManager.empty);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00006B1F File Offset: 0x00004D1F
		private static void SetEnemyMagnet()
		{
			Flash.Call("SetEnemyMagnet", OptionsManager.empty);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00006B30 File Offset: 0x00004D30
		private static void SetLagKiller()
		{
			Flash.Call("SetLagKiller", new string[]
			{
				OptionsManager.LagKiller ? bool.TrueString : bool.FalseString
			});
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00006B58 File Offset: 0x00004D58
		public static void DestroyPlayers()
		{
			Flash.Call("DestroyPlayers", OptionsManager.empty);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00006B69 File Offset: 0x00004D69
		private static void SetSkipCutscenes()
		{
			Flash.Call("SetSkipCutscenes", OptionsManager.empty);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0002EDEC File Offset: 0x0002CFEC
		public static void SetWalkSpeed()
		{
			Flash.Call("SetWalkSpeed", new string[]
			{
				OptionsManager.WalkSpeed.ToString()
			});
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00006B7A File Offset: 0x00004D7A
		public static void Start()
		{
			if (!OptionsManager.IsRunning)
			{
				OptionsManager.ApplySettings();
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00006B89 File Offset: 0x00004D89
		public static void Stop()
		{
			OptionsManager.IsRunning = false;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0002EE1C File Offset: 0x0002D01C
		private static async Task ApplySettings()
		{
			OptionsManager.IsRunning = true;
			while (OptionsManager.IsRunning && Player.IsLoggedIn)
			{
				bool flag = OptionsManager.ProvokeMonsters && Player.IsAlive && BotData.BotState != BotData.State.Move && BotData.BotState != BotData.State.Rest && BotData.BotState != BotData.State.Transaction;
				if (flag)
				{
					if (BotData.BotState == BotData.State.Quest)
					{
						await Task.Delay(1500);
						OptionsManager.SetProvokeMonsters();
						BotData.BotState = BotData.State.Combat;
					}
					OptionsManager.SetProvokeMonsters();
				}
				if (OptionsManager.EnemyMagnet && Player.IsAlive)
				{
					OptionsManager.SetEnemyMagnet();
				}
				if (OptionsManager.Untarget)
				{
					Player.CancelTargetSelf();
				}
				if (OptionsManager.Buff)
				{
					Player.SetBuff();
				}
				if (OptionsManager.SkipCutscenes)
				{
					OptionsManager.SetSkipCutscenes();
				}
				OptionsManager.SetWalkSpeed();
				OptionsManager.SetLagKiller();
				await Task.Delay(OptionsManager.Timer);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00006B91 File Offset: 0x00004D91
		private static IJsonMessageHandler HandlerDisableAnimations { get; } = new HandlerAnimations();

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00006B98 File Offset: 0x00004D98
		private static IXtMessageHandler HandlerHidePlayers { get; } = new HandlerPlayers();

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00006B9F File Offset: 0x00004D9F
		private static IXtMessageHandler HandlerYulgar { get; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00006BA6 File Offset: 0x00004DA6
		private static IJsonMessageHandler HandlerHideRoom { get; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00006BAD File Offset: 0x00004DAD
		private static IJsonMessageHandler HandlerRange { get; } = new HandlerSkills();

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00006BB4 File Offset: 0x00004DB4
		private static IXtMessageHandler HandlerAFK1 { get; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00006BBB File Offset: 0x00004DBB
		private static IXtMessageHandler HandlerAFK2 { get; }

		// Token: 0x060007A0 RID: 1952 RVA: 0x0002EE5C File Offset: 0x0002D05C
		static OptionsManager()
		{
			OptionsManager.HandlerYulgar = new HandlerXtCellJoin();
			OptionsManager.HandlerHideRoom = new HandlerMapJoin();
			OptionsManager.HandlerAFK1 = new HandlerAFK();
			OptionsManager.HandlerAFK2 = new HandlerAFK2();
			OptionsManager.WalkSpeed = 8;
		}

		// Token: 0x04000535 RID: 1333
		private static bool _isRunning;

		// Token: 0x04000536 RID: 1334
		private static bool _disableAnimations;

		// Token: 0x04000537 RID: 1335
		private static bool _hidePlayers;

		// Token: 0x04000538 RID: 1336
		private static bool _infRange;

		// Token: 0x04000539 RID: 1337
		private static bool _hideYulgar;

		// Token: 0x0400053A RID: 1338
		private static bool _hideRoom;

		// Token: 0x0400053B RID: 1339
		private static bool _afk;

		// Token: 0x0400053C RID: 1340
		private static bool _afk2;

		// Token: 0x0400053D RID: 1341
		private static bool _infMana;

		// Token: 0x04000549 RID: 1353
		private static readonly string[] empty = new string[0];
	}
}
