using System;
using System.Collections.Generic;
using Grimoire.Game.Data;

namespace Grimoire.Botting
{
	// Token: 0x020000F4 RID: 244
	public class Configuration
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00006468 File Offset: 0x00004668
		public static Configuration Instance
		{
			get
			{
				Configuration result;
				if ((result = Configuration._instance) == null)
				{
					result = (Configuration._instance = new Configuration());
				}
				return result;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0000647E File Offset: 0x0000467E
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00006486 File Offset: 0x00004686
		public List<IBotCommand> Commands { get; set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0000648F File Offset: 0x0000468F
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00006497 File Offset: 0x00004697
		public List<Skill> Skills { get; set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x000064A0 File Offset: 0x000046A0
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x000064A8 File Offset: 0x000046A8
		public List<Quest> Quests { get; set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x000064B1 File Offset: 0x000046B1
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x000064B9 File Offset: 0x000046B9
		public string Author { get; set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x000064C2 File Offset: 0x000046C2
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x000064CA File Offset: 0x000046CA
		public string Description { get; set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x000064D3 File Offset: 0x000046D3
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x000064DB File Offset: 0x000046DB
		public List<InventoryItem> Boosts { get; set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x000064E4 File Offset: 0x000046E4
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x000064EC File Offset: 0x000046EC
		public List<string> Drops { get; set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x000064F5 File Offset: 0x000046F5
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x000064FD File Offset: 0x000046FD
		public Server Server { get; set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00006506 File Offset: 0x00004706
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x0000650E File Offset: 0x0000470E
		public int SkillDelay { get; set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00006517 File Offset: 0x00004717
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0000651F File Offset: 0x0000471F
		public bool ExitCombatBeforeRest { get; set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00006528 File Offset: 0x00004728
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x00006530 File Offset: 0x00004730
		public bool ExitCombatBeforeQuest { get; set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00006539 File Offset: 0x00004739
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00006541 File Offset: 0x00004741
		public bool EnablePickup { get; set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0000654A File Offset: 0x0000474A
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00006552 File Offset: 0x00004752
		public bool EnableRejection { get; set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0000655B File Offset: 0x0000475B
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00006563 File Offset: 0x00004763
		public bool EnablePickupAll { get; set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0000656C File Offset: 0x0000476C
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00006574 File Offset: 0x00004774
		public bool EnableRejectAll { get; set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0000657D File Offset: 0x0000477D
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00006585 File Offset: 0x00004785
		public bool AutoRelogin { get; set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0000658E File Offset: 0x0000478E
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00006596 File Offset: 0x00004796
		public int RelogDelay { get; set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0000659F File Offset: 0x0000479F
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x000065A7 File Offset: 0x000047A7
		public bool RelogRetryUponFailure { get; set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x000065B0 File Offset: 0x000047B0
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x000065B8 File Offset: 0x000047B8
		public int BotDelay { get; set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x000065C1 File Offset: 0x000047C1
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x000065C9 File Offset: 0x000047C9
		public bool WaitForAllSkills { get; set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x000065D2 File Offset: 0x000047D2
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x000065DA File Offset: 0x000047DA
		public bool WaitForSkill { get; set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x000065E3 File Offset: 0x000047E3
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x000065EB File Offset: 0x000047EB
		public bool SkipDelayIndexIf { get; set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000065F4 File Offset: 0x000047F4
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x000065FC File Offset: 0x000047FC
		public bool InfiniteAttackRange { get; set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00006605 File Offset: 0x00004805
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x0000660D File Offset: 0x0000480D
		public bool ProvokeMonsters { get; set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00006616 File Offset: 0x00004816
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x0000661E File Offset: 0x0000481E
		public bool Untarget { get; set; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00006627 File Offset: 0x00004827
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x0000662F File Offset: 0x0000482F
		public bool EnemyMagnet { get; set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00006638 File Offset: 0x00004838
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00006640 File Offset: 0x00004840
		public bool LagKiller { get; set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00006649 File Offset: 0x00004849
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00006651 File Offset: 0x00004851
		public bool HidePlayers { get; set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0000665A File Offset: 0x0000485A
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00006662 File Offset: 0x00004862
		public bool SkipCutscenes { get; set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0000666B File Offset: 0x0000486B
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00006673 File Offset: 0x00004873
		public bool DisableAnimations { get; set; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0000667C File Offset: 0x0000487C
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00006684 File Offset: 0x00004884
		public int WalkSpeed { get; set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0000668D File Offset: 0x0000488D
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00006695 File Offset: 0x00004895
		public List<string> NotifyUponDrop { get; set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0000669E File Offset: 0x0000489E
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x000066A6 File Offset: 0x000048A6
		public bool RestIfMp { get; set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x000066AF File Offset: 0x000048AF
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x000066B7 File Offset: 0x000048B7
		public bool RestIfHp { get; set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x000066C0 File Offset: 0x000048C0
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x000066C8 File Offset: 0x000048C8
		public int RestMp { get; set; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x000066D1 File Offset: 0x000048D1
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x000066D9 File Offset: 0x000048D9
		public int RestHp { get; set; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000066E2 File Offset: 0x000048E2
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x000066EA File Offset: 0x000048EA
		public bool RestartUponDeath { get; set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x000066F3 File Offset: 0x000048F3
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x000066FB File Offset: 0x000048FB
		public List<string> Items { get; set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00006704 File Offset: 0x00004904
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0000670C File Offset: 0x0000490C
		public bool Packet { get; set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00006715 File Offset: 0x00004915
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x0000671D File Offset: 0x0000491D
		public bool BankOnStop { get; set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00006726 File Offset: 0x00004926
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0000672E File Offset: 0x0000492E
		public bool EnsureComplete { get; set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00006737 File Offset: 0x00004937
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x0000673F File Offset: 0x0000493F
		public int EnsureTries { get; set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00006748 File Offset: 0x00004948
		public static List<string> BlockedPlayers { get; } = new List<string>();

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x0000674F File Offset: 0x0000494F
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00006757 File Offset: 0x00004957
		public bool AFK { get; set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00006760 File Offset: 0x00004960
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00006768 File Offset: 0x00004968
		public int DropDelay { get; set; }

		// Token: 0x06000729 RID: 1833 RVA: 0x0002E47C File Offset: 0x0002C67C
		public Configuration()
		{
			this.Commands = new List<IBotCommand>();
			this.Skills = new List<Skill>();
			this.Quests = new List<Quest>();
			this.Boosts = new List<InventoryItem>();
			this.Drops = new List<string>();
			this.Items = new List<string>();
			this.NotifyUponDrop = new List<string>();
		}

		// Token: 0x040004E0 RID: 1248
		private static Configuration _instance;

		// Token: 0x0400050E RID: 1294
		public static Dictionary<string, int> Tempvalues = new Dictionary<string, int>();
	}
}
