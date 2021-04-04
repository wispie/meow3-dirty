using System;
using System.Collections.Generic;
using System.Linq;
using Grimoire.Tools;

namespace Grimoire.Game.Data
{
	// Token: 0x020000D5 RID: 213
	public class Quests
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00005BA8 File Offset: 0x00003DA8
		public List<Quest> QuestTree
		{
			get
			{
				return Flash.Call<List<Quest>>("GetQuestTree", new string[0]);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00005BBA File Offset: 0x00003DBA
		public List<Quest> AcceptedQuests
		{
			get
			{
				return (from q in this.QuestTree
				where q.IsInProgress
				select q).ToList<Quest>();
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00005BEB File Offset: 0x00003DEB
		public List<Quest> UnacceptedQuests
		{
			get
			{
				return (from q in this.QuestTree
				where !q.IsInProgress
				select q).ToList<Quest>();
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00005C1C File Offset: 0x00003E1C
		public List<Quest> CompletedQuests
		{
			get
			{
				return (from q in this.QuestTree
				where q.CanComplete
				select q).ToList<Quest>();
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060005F9 RID: 1529 RVA: 0x0002CA6C File Offset: 0x0002AC6C
		// (remove) Token: 0x060005FA RID: 1530 RVA: 0x0002CAA4 File Offset: 0x0002ACA4
		public event Action<List<Quest>> QuestsLoaded;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060005FB RID: 1531 RVA: 0x0002CADC File Offset: 0x0002ACDC
		// (remove) Token: 0x060005FC RID: 1532 RVA: 0x0002CB14 File Offset: 0x0002AD14
		public event Action<CompletedQuest> QuestCompleted;

		// Token: 0x060005FD RID: 1533 RVA: 0x00005C4D File Offset: 0x00003E4D
		public void OnQuestsLoaded(List<Quest> quests)
		{
			Action<List<Quest>> questsLoaded = this.QuestsLoaded;
			if (questsLoaded == null)
			{
				return;
			}
			questsLoaded(quests);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00005C60 File Offset: 0x00003E60
		public void OnQuestCompleted(CompletedQuest quest)
		{
			Action<CompletedQuest> questCompleted = this.QuestCompleted;
			if (questCompleted == null)
			{
				return;
			}
			questCompleted(quest);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00005C73 File Offset: 0x00003E73
		public void Accept(int questId)
		{
			Flash.Call("Accept", new string[]
			{
				questId.ToString()
			});
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00005C8F File Offset: 0x00003E8F
		public void Accept(string questId)
		{
			Flash.Call("Accept", new string[]
			{
				questId
			});
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00005CA5 File Offset: 0x00003EA5
		public void Complete(int questId)
		{
			Flash.Call("Complete", new string[]
			{
				questId.ToString()
			});
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00005CC1 File Offset: 0x00003EC1
		public void Complete(string questId)
		{
			Flash.Call("Complete", new string[]
			{
				questId
			});
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00005CD7 File Offset: 0x00003ED7
		public void Complete(string questId, string itemId)
		{
			Flash.Call("Complete", new string[]
			{
				itemId,
				bool.TrueString
			});
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00005CF5 File Offset: 0x00003EF5
		public void Load(int id)
		{
			Flash.Call("LoadQuest", new string[]
			{
				id.ToString()
			});
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00005D11 File Offset: 0x00003F11
		public void Load(List<int> ids)
		{
			Flash.Call("LoadQuests", new string[]
			{
				string.Join<int>(",", ids)
			});
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0002CB4C File Offset: 0x0002AD4C
		public void Get(List<int> ids)
		{
			string function = "GetQuests";
			string[] array = new string[1];
			array[0] = string.Join(",", from i in ids
			select i.ToString());
			Flash.Call(function, array);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00005D31 File Offset: 0x00003F31
		public bool IsInProgress(int id)
		{
			return Flash.Call<bool>("IsInProgress", new string[]
			{
				id.ToString()
			});
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00005D4D File Offset: 0x00003F4D
		public bool IsInProgress(string id)
		{
			return Flash.Call<bool>("IsInProgress", new string[]
			{
				id
			});
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00005D63 File Offset: 0x00003F63
		public bool CanComplete(int id)
		{
			return Flash.Call<bool>("CanComplete", new string[]
			{
				id.ToString()
			});
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00005D7F File Offset: 0x00003F7F
		public bool CanComplete(string id)
		{
			return Flash.Call<bool>("CanComplete", new string[]
			{
				id
			});
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00005D95 File Offset: 0x00003F95
		public bool IsAvailable(int id)
		{
			return Flash.Call<bool>("IsAvailable", new string[]
			{
				id.ToString()
			});
		}
	}
}
