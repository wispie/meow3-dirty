using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Grimoire.Game.Data;
using Grimoire.Networking;

namespace Grimoire.Game
{
	// Token: 0x020000B0 RID: 176
	public class DropStack : IReadOnlyList<InventoryItem>, IReadOnlyCollection<InventoryItem>, IEnumerable<InventoryItem>, IEnumerable
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000048E2 File Offset: 0x00002AE2
		public int Count
		{
			get
			{
				return this._drops.Count;
			}
		}

		// Token: 0x17000065 RID: 101
		public InventoryItem this[int index]
		{
			get
			{
				if (index >= this._drops.Count)
				{
					return null;
				}
				return this._drops[index];
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000490D File Offset: 0x00002B0D
		public DropStack()
		{
			World.ItemDropped += this.OnItemDropped;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000493C File Offset: 0x00002B3C
		public IEnumerator<InventoryItem> GetEnumerator()
		{
			return this._drops.GetEnumerator();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000494E File Offset: 0x00002B4E
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0002BB2C File Offset: 0x00029D2C
		private void OnItemDropped(InventoryItem item)
		{
			if (this._drops.All((InventoryItem d) => d.Id != item.Id))
			{
				this._drops.Add(item);
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0002BB70 File Offset: 0x00029D70
		public async Task<bool> GetDrop(InventoryItem item)
		{
			return await this.GetDrop(item.Id);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0002BBC0 File Offset: 0x00029DC0
		public async Task<bool> GetDrop(string itemName)
		{
			InventoryItem inventoryItem = this._drops.FirstOrDefault((InventoryItem d) => d.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
			bool flag = inventoryItem != null;
			if (flag)
			{
				bool flag2 = await this.GetDrop(inventoryItem.Id);
				flag = flag2;
			}
			return flag;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0002BC10 File Offset: 0x00029E10
		public async Task<bool> RemoveAll(int itemId)
		{
			bool result;
			if (this.Contains(itemId))
			{
				this._drops.RemoveAll((InventoryItem d) => d.Id == itemId);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0002BC60 File Offset: 0x00029E60
		public async Task<bool> GetDrop(int itemId)
		{
			if (this.Contains(itemId))
			{
				this._cooldown.RemoveAll((KeyValuePair<int, Stopwatch> c) => c.Value.ElapsedMilliseconds >= 3000L);
				if (!this.IsCoolingDown(itemId))
				{
					await Proxy.Instance.SendToServer(string.Format("%xt%zm%getDrop%{0}%{1}%", World.RoomId, itemId));
					this._cooldown.Add(new KeyValuePair<int, Stopwatch>(itemId, Stopwatch.StartNew()));
					this._drops.RemoveAll((InventoryItem d) => d.Id == itemId);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00004956 File Offset: 0x00002B56
		public void Clear()
		{
			this._drops.Clear();
			this._cooldown.Clear();
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0002BCB0 File Offset: 0x00029EB0
		private bool IsCoolingDown(int itemId)
		{
			KeyValuePair<int, Stopwatch> keyValuePair = this._cooldown.FirstOrDefault((KeyValuePair<int, Stopwatch> i) => i.Key == itemId);
			return keyValuePair.Key != 0 && (int)keyValuePair.Value.ElapsedMilliseconds < 3000;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000496E File Offset: 0x00002B6E
		public bool Contains(InventoryItem item)
		{
			return this.Contains(item.Id);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0002BD04 File Offset: 0x00029F04
		public bool Contains(int itemId)
		{
			return this._drops.FirstOrDefault((InventoryItem d) => d.Id == itemId) != null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0002BD38 File Offset: 0x00029F38
		public bool Contains(string itemName)
		{
			return this._drops.FirstOrDefault((InventoryItem d) => d.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase)) != null;
		}

		// Token: 0x0400037F RID: 895
		private readonly List<InventoryItem> _drops = new List<InventoryItem>();

		// Token: 0x04000380 RID: 896
		private readonly List<KeyValuePair<int, Stopwatch>> _cooldown = new List<KeyValuePair<int, Stopwatch>>();
	}
}
