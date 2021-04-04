using System;
using System.Collections.Generic;
using System.Linq;
using Grimoire.Game.Data;
using Grimoire.Tools;
using Grimoire.UI;
using Newtonsoft.Json;

namespace Grimoire.Game
{
	// Token: 0x020000C2 RID: 194
	public static class World
	{
		// Token: 0x0600046E RID: 1134 RVA: 0x00004F1D File Offset: 0x0000311D
		public static void RefreshDictionary()
		{
			World._players = JsonConvert.DeserializeObject<Dictionary<string, PlayerInfo>>(Flash.Call("Players", new object[0]));
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00004F39 File Offset: 0x00003139
		public static List<PlayerInfo> Players
		{
			get
			{
				return World._players.Values.ToList<PlayerInfo>();
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00004F4A File Offset: 0x0000314A
		public static List<Monster> AvailableMonsters
		{
			get
			{
				return Flash.Call<List<Monster>>("GetMonstersInCell", new string[0]);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00004F5C File Offset: 0x0000315C
		public static bool IsMapLoading
		{
			get
			{
				return !Flash.Call<bool>("MapLoadComplete", new string[0]);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00004F71 File Offset: 0x00003171
		public static List<string> PlayersInMap
		{
			get
			{
				return Flash.Call<List<string>>("PlayersInMap", new string[0]);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00004F83 File Offset: 0x00003183
		public static List<InventoryItem> ItemTree
		{
			get
			{
				return Flash.Call<List<InventoryItem>>("GetItemTree", new string[0]);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00004F95 File Offset: 0x00003195
		public static string[] Cells
		{
			get
			{
				return Flash.Call<string[]>("GetCells", new string[0]);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00004FA7 File Offset: 0x000031A7
		public static int RoomId
		{
			get
			{
				return Flash.Call<int>("RoomId", new string[0]);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00004FB9 File Offset: 0x000031B9
		public static int RoomNumber
		{
			get
			{
				return Flash.Call<int>("RoomNumber", new string[0]);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000477 RID: 1143 RVA: 0x0002C39C File Offset: 0x0002A59C
		// (remove) Token: 0x06000478 RID: 1144 RVA: 0x0002C3D0 File Offset: 0x0002A5D0
		public static event Action<InventoryItem> ItemDropped;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000479 RID: 1145 RVA: 0x0002C404 File Offset: 0x0002A604
		// (remove) Token: 0x0600047A RID: 1146 RVA: 0x0002C438 File Offset: 0x0002A638
		public static event Action<ShopInfo> ShopLoaded;

		// Token: 0x0600047B RID: 1147 RVA: 0x0002C46C File Offset: 0x0002A66C
		public static void OnItemDropped(InventoryItem drop)
		{
			Action<InventoryItem> itemDropped = World.ItemDropped;
			if (itemDropped != null)
			{
				string text = string.Format("{0}", (Player.Inventory.Items.Find((InventoryItem x) => x.Name == drop.Name) ?? new InventoryItem()).Quantity);
				LogForm.Instance.AppendDrops(string.Format("[Item Drop] {0} {1} at {2:hh:mm:ss tt} [{3}] \r\n", new object[]
				{
					drop.Quantity,
					drop.Name,
					DateTime.Now,
					text
				}));
				itemDropped(drop);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0002C524 File Offset: 0x0002A724
		public static void OnShopLoaded(ShopInfo shopInfo)
		{
			Action<ShopInfo> shopLoaded = World.ShopLoaded;
			if (shopLoaded != null)
			{
				shopLoaded(shopInfo);
			}
			World.LoadedShops.Add(shopInfo);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00004FCB File Offset: 0x000031CB
		public static bool IsActionAvailable(LockActions action)
		{
			return Flash.Call<bool>("IsActionAvailable", new string[]
			{
				World.LockedActions[action]
			});
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00004C7E File Offset: 0x00002E7E
		public static void SetSpawnPoint()
		{
			Flash.Call("SetSpawnPoint", new string[0]);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00004FEB File Offset: 0x000031EB
		public static bool IsMonsterAvailable(string name)
		{
			return Flash.Call<bool>("IsMonsterAvailable", new string[]
			{
				name
			});
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00005001 File Offset: 0x00003201
		public static bool PlayerInCurrentCell(string Username)
		{
			Console.WriteLine(Flash.Call<string>("CheckPlayerInMyCell", new string[]
			{
				Username.ToLower()
			}));
			return true;
		}

		// Token: 0x040003C8 RID: 968
		private static Dictionary<string, PlayerInfo> _players;

		// Token: 0x040003C9 RID: 969
		public static List<ShopInfo> LoadedShops = new List<ShopInfo>();

		// Token: 0x040003CA RID: 970
		public static DropStack DropStack = new DropStack();

		// Token: 0x040003CB RID: 971
		private static readonly Dictionary<LockActions, string> LockedActions = new Dictionary<LockActions, string>(14)
		{
			{
				LockActions.LoadShop,
				"loadShop"
			},
			{
				LockActions.LoadEnhShop,
				"loadEnhShop"
			},
			{
				LockActions.LoadHairShop,
				"loadHairShop"
			},
			{
				LockActions.EquipItem,
				"equipItem"
			},
			{
				LockActions.UnequipItem,
				"unequipItem"
			},
			{
				LockActions.BuyItem,
				"buyItem"
			},
			{
				LockActions.SellItem,
				"sellItem"
			},
			{
				LockActions.GetMapItem,
				"getMapItem"
			},
			{
				LockActions.TryQuestComplete,
				"tryQuestComplete"
			},
			{
				LockActions.AcceptQuest,
				"acceptQuest"
			},
			{
				LockActions.DoIA,
				"doIA"
			},
			{
				LockActions.Rest,
				"rest"
			},
			{
				LockActions.Who,
				"who"
			},
			{
				LockActions.Transfer,
				"tfer"
			}
		};

		// Token: 0x040003CC RID: 972
		public static List<Monster> VisibleMonsters = Flash.Call<List<Monster>>("GetVisibleMonstersInCell", new string[0]);
	}
}
