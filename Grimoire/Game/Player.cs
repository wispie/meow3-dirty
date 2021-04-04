using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grimoire.Botting;
using Grimoire.Botting.Commands.Map;
using Grimoire.Game.Data;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game
{
	// Token: 0x020000BE RID: 190
	public static class Player
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00004A5A File Offset: 0x00002C5A
		public static int UserID
		{
			get
			{
				return Flash.Call<int>("UserID", new object[0]);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00004A6C File Offset: 0x00002C6C
		public static Bank Bank { get; } = new Bank();

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00004A73 File Offset: 0x00002C73
		public static Inventory Inventory { get; } = new Inventory();

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00004A7A File Offset: 0x00002C7A
		public static TempInventory TempInventory { get; } = new TempInventory();

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00004A81 File Offset: 0x00002C81
		public static House House { get; } = new House();

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00004A88 File Offset: 0x00002C88
		public static List<Faction> Factions
		{
			get
			{
				return JsonConvert.DeserializeObject<List<Faction>>(Flash.Call("GetFactions", new object[0]));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00004A9F File Offset: 0x00002C9F
		public static Quests Quests { get; } = new Quests();

		// Token: 0x06000425 RID: 1061 RVA: 0x00002CC5 File Offset: 0x00000EC5
		public static CmdTravel CreateJoinCommand(string map, string cell = "Enter", string pad = "Spawn")
		{
			return new CmdTravel
			{
				Map = map,
				Cell = cell,
				Pad = pad
			};
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0002C174 File Offset: 0x0002A374
		public static async void ExecuteTravel(List<IBotCommand> cmds)
		{
			foreach (IBotCommand botCommand in cmds)
			{
				await botCommand.Execute(null);
				await Task.Delay(1000);
			}
			List<IBotCommand>.Enumerator enumerator = default(List<IBotCommand>.Enumerator);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0002C1B0 File Offset: 0x0002A3B0
		public static string Username
		{
			get
			{
				if (!Player.IsLoggedIn)
				{
					return "";
				}
				string text = Flash.Call<string>("GetUsername", new string[0]);
				if (text == "null" && Player.usernamecheck)
				{
					MessageBox.Show("Your Username is currently null meaning some bots that utilize your username (like packet bots)\r\n will not work correctly, to refresh it try restarting grimoire");
					Player.usernamecheck = false;
				}
				return text;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00004116 File Offset: 0x00002316
		public static string Password
		{
			get
			{
				return Flash.Call<string>("GetPassword", new string[0]);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00004AA6 File Offset: 0x00002CA6
		public static bool IsLoggedIn
		{
			get
			{
				return Flash.Call<bool>("IsLoggedIn", new string[0]);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00004AB8 File Offset: 0x00002CB8
		public static string Cell
		{
			get
			{
				return Flash.Call<string>("Cell", new string[0]);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00004ACA File Offset: 0x00002CCA
		public static string Pad
		{
			get
			{
				return Flash.Call<string>("Pad", new string[0]);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00004ADC File Offset: 0x00002CDC
		public static Player.State CurrentState
		{
			get
			{
				return (Player.State)Flash.Call<int>("State", new string[0]);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00004AEE File Offset: 0x00002CEE
		public static int Health
		{
			get
			{
				return Flash.Call<int>("Health", new string[0]);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00004B00 File Offset: 0x00002D00
		public static int HealthMax
		{
			get
			{
				return Flash.Call<int>("HealthMax", new string[0]);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00004B12 File Offset: 0x00002D12
		public static bool IsAlive
		{
			get
			{
				return Player.Health > 0;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00004B1C File Offset: 0x00002D1C
		public static int Mana
		{
			get
			{
				return Flash.Call<int>("Mana", new string[0]);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00004B2E File Offset: 0x00002D2E
		public static int ManaMax
		{
			get
			{
				return Flash.Call<int>("ManaMax", new string[0]);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00004B40 File Offset: 0x00002D40
		public static string Map
		{
			get
			{
				return Flash.Call<string>("Map", new string[0]);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00004B52 File Offset: 0x00002D52
		public static int Level
		{
			get
			{
				return Flash.Call<int>("Level", new string[0]);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00004B64 File Offset: 0x00002D64
		public static int Gold
		{
			get
			{
				return Flash.Call<int>("Gold", new string[0]);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00004B76 File Offset: 0x00002D76
		public static bool HasTarget
		{
			get
			{
				return Flash.Call<bool>("HasTarget", new string[0]);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00004B88 File Offset: 0x00002D88
		public static int AllSkillsAvailable
		{
			get
			{
				return Flash.Call<int>("AllSkillsAvailable", new string[0]);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00004B9A File Offset: 0x00002D9A
		public static bool IsAfk
		{
			get
			{
				return Flash.Call<bool>("IsAfk", new string[0]);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00004BAC File Offset: 0x00002DAC
		public static float[] Position
		{
			get
			{
				return Flash.Call<float[]>("Position", new string[0]);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00004BBE File Offset: 0x00002DBE
		public static bool IsMember
		{
			get
			{
				return Flash.Call<bool>("IsMember", new string[0]);
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00004BD0 File Offset: 0x00002DD0
		public static int SkillAvailable(string index)
		{
			return Flash.Call<int>("SkillAvailable", new string[]
			{
				index
			});
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00004BE6 File Offset: 0x00002DE6
		public static void ToggleMute(bool b)
		{
			Flash.Call("MuteToggle", new object[]
			{
				b
			});
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00004C02 File Offset: 0x00002E02
		public static void ChangeAccessLevel(string level)
		{
			Flash.Call("ChangeAccessLevel", new string[]
			{
				level
			});
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00004C18 File Offset: 0x00002E18
		public static void WalkToPoint(string x, string y)
		{
			Flash.Call("WalkToPoint", new string[]
			{
				x,
				y
			});
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00004C32 File Offset: 0x00002E32
		public static void CancelTarget()
		{
			Flash.Call("CancelTarget", new string[0]);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00004C44 File Offset: 0x00002E44
		public static void CancelTargetSelf()
		{
			Flash.Call("CancelTargetSelf", new string[0]);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00004C56 File Offset: 0x00002E56
		public static void SetBuff()
		{
			Flash.Call("Buff", new string[0]);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00004C68 File Offset: 0x00002E68
		public static void AttackMonster(string name)
		{
			Flash.Call("AttackMonster", new string[]
			{
				name
			});
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00004C7E File Offset: 0x00002E7E
		public static void SetSpawnPoint()
		{
			Flash.Call("SetSpawnPoint", new string[0]);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00004C90 File Offset: 0x00002E90
		public static void MoveToCell(string cell, string pad = "Spawn")
		{
			Flash.Call("Jump", new string[]
			{
				cell,
				pad
			});
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00004CAA File Offset: 0x00002EAA
		public static void Rest()
		{
			Flash.Call("Rest", new string[0]);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00004CBC File Offset: 0x00002EBC
		public static void JoinMap(string map, string cell = "Enter", string pad = "Spawn")
		{
			Flash.Call("Join", new string[]
			{
				map,
				cell,
				pad
			});
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00004CDA File Offset: 0x00002EDA
		public static void Equip(string id)
		{
			Flash.Call("Equip", new string[]
			{
				id
			});
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00004CF0 File Offset: 0x00002EF0
		public static void Equip(int id)
		{
			Flash.Call("Equip", new string[]
			{
				id.ToString()
			});
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00004D0C File Offset: 0x00002F0C
		public static void EquipPotion(int id, string desc, string file, string name)
		{
			Flash.Call("EquipPotion", new string[]
			{
				id.ToString(),
				desc,
				file,
				name
			});
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00004D34 File Offset: 0x00002F34
		public static void GoToPlayer(string name)
		{
			Flash.Call("GoTo", new string[]
			{
				name
			});
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00004D4A File Offset: 0x00002F4A
		public static bool HasActiveBoost(string name)
		{
			return Flash.Call<bool>("HasActiveBoost", new string[]
			{
				name
			});
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00004D60 File Offset: 0x00002F60
		public static void UseBoost(string id)
		{
			Flash.Call("UseBoost", new string[]
			{
				id
			});
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00004D76 File Offset: 0x00002F76
		public static void UseBoost(int id)
		{
			Flash.Call("UseBoost", new string[]
			{
				id.ToString()
			});
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00004D92 File Offset: 0x00002F92
		public static void UseSkill(string index)
		{
			Flash.Call("UseSkill", new string[]
			{
				index
			});
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00004DA8 File Offset: 0x00002FA8
		public static void GetMapItem(string id)
		{
			Flash.Call("GetMapItem", new string[]
			{
				id
			});
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00004DBE File Offset: 0x00002FBE
		public static void GetMapItem(int id)
		{
			Flash.Call("GetMapItem", new string[]
			{
				id.ToString()
			});
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00004DDA File Offset: 0x00002FDA
		public static void Logout()
		{
			Flash.Call("Logout", new string[0]);
		}

		// Token: 0x040003B2 RID: 946
		private static bool usernamecheck = true;

		// Token: 0x020000BF RID: 191
		public enum State
		{
			// Token: 0x040003B4 RID: 948
			Dead,
			// Token: 0x040003B5 RID: 949
			Idle,
			// Token: 0x040003B6 RID: 950
			InCombat
		}
	}
}
