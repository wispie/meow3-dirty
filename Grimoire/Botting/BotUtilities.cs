using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using AxShockwaveFlashObjects;
using Grimoire.Botting.Commands.Combat;
using Grimoire.Botting.Commands.Item;
using Grimoire.Botting.Commands.Misc;
using Grimoire.Botting.Commands.Misc.Statements;
using Grimoire.Botting.Commands.Quest;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.Botting
{
	// Token: 0x020000EE RID: 238
	public static class BotUtilities
	{
		// Token: 0x060006B1 RID: 1713 RVA: 0x0002E0BC File Offset: 0x0002C2BC
		public static async Task WaitUntil(this IBotEngine instance, Func<bool> condition, Func<bool> prerequisite = null, int timeout = 15)
		{
			int iterations = 0;
			while ((prerequisite ?? (() => instance.IsRunning && Player.IsLoggedIn && Player.IsAlive))() && !condition() && (iterations < timeout || timeout == -1))
			{
				await Task.Delay(1000);
				iterations++;
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000062D3 File Offset: 0x000044D3
		public static bool RequiresDelay(this IBotCommand cmd)
		{
			return !(cmd is StatementCommand) && !(cmd is CmdIndex) && !(cmd is CmdLabel) && !(cmd is CmdGotoLabel) && !(cmd is CmdBlank) && !(cmd is CmdSkillSet);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0002E11C File Offset: 0x0002C31C
		public static void LoadAllQuests(this IBotEngine instance)
		{
			List<int> list = new List<int>();
			foreach (IBotCommand botCommand in instance.Configuration.Commands)
			{
				CmdAcceptQuest cmdAcceptQuest;
				CmdCompleteQuest cmdCompleteQuest;
				if ((cmdAcceptQuest = (botCommand as CmdAcceptQuest)) != null)
				{
					list.Add(cmdAcceptQuest.Quest.Id);
				}
				else if ((cmdCompleteQuest = (botCommand as CmdCompleteQuest)) != null)
				{
					list.Add(cmdCompleteQuest.Quest.Id);
				}
			}
			list.AddRange(from q in instance.Configuration.Quests
			select q.Id);
			if (list.Count > 0)
			{
				Player.Quests.Get(list);
			}
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00006308 File Offset: 0x00004508
		public static void LoadBankItems(this IBotEngine instance)
		{
			if (instance.Configuration.Commands.Any((IBotCommand c) => c is CmdBankSwap || c is CmdBankTransfer))
			{
				Player.Bank.LoadItems();
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0002E1F8 File Offset: 0x0002C3F8
		public static string Call(string function, bool base64 = false)
		{
			string result;
			try
			{
				string request = "<invoke name=\"" + function + "\"returntype=\"xml\"></invoke>";
				XNode firstNode = XElement.Parse(BotUtilities.flash.CallFunction(request)).FirstNode;
				string text = (firstNode != null) ? firstNode.ToString() : null;
				if (text == null)
				{
					result = string.Empty;
				}
				else if (!base64)
				{
					result = text.Correct().SanitizeXml();
				}
				else
				{
					result = text.FromBase64().Correct().SanitizeXml();
				}
			}
			catch (Exception)
			{
				result = "";
			}
			return result;
		}

		// Token: 0x040004C9 RID: 1225
		public static ManualResetEvent BankLoadEvent = new ManualResetEvent(false);

		// Token: 0x040004CA RID: 1226
		public static AxShockwaveFlash flash;
	}
}
