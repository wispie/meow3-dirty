using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.Tools;
using Grimoire.UI;

namespace Grimoire.Botting
{
	// Token: 0x020000DF RID: 223
	public class Bot : IBotEngine
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00006115 File Offset: 0x00004315
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x0000611D File Offset: 0x0000431D
		public int Index
		{
			get
			{
				return this._index;
			}
			set
			{
				this._index = ((value < this.Configuration.Commands.Count) ? value : 0);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0000613C File Offset: 0x0000433C
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00006144 File Offset: 0x00004344
		public Configuration Configuration
		{
			get
			{
				return this._config;
			}
			set
			{
				if (value != this._config)
				{
					this._config = value;
					Action<Configuration> configurationChanged = this.ConfigurationChanged;
					if (configurationChanged == null)
					{
						return;
					}
					configurationChanged(this._config);
				}
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0000616C File Offset: 0x0000436C
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00006174 File Offset: 0x00004374
		public bool IsRunning
		{
			get
			{
				return this._isRunning;
			}
			set
			{
				this._isRunning = value;
				Action<bool> isRunningChanged = this.IsRunningChanged;
				if (isRunningChanged == null)
				{
					return;
				}
				isRunningChanged(this._isRunning);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600067B RID: 1659 RVA: 0x0002CBF4 File Offset: 0x0002ADF4
		// (remove) Token: 0x0600067C RID: 1660 RVA: 0x0002CC2C File Offset: 0x0002AE2C
		public event Action<bool> IsRunningChanged;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600067D RID: 1661 RVA: 0x0002CC64 File Offset: 0x0002AE64
		// (remove) Token: 0x0600067E RID: 1662 RVA: 0x0002CC9C File Offset: 0x0002AE9C
		public event Action<int> IndexChanged;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600067F RID: 1663 RVA: 0x0002CCD4 File Offset: 0x0002AED4
		// (remove) Token: 0x06000680 RID: 1664 RVA: 0x0002CD0C File Offset: 0x0002AF0C
		public event Action<Configuration> ConfigurationChanged;

		// Token: 0x06000681 RID: 1665 RVA: 0x0002CD44 File Offset: 0x0002AF44
		public void Start(Configuration config)
		{
			this.IsRunning = true;
			this.Configuration = config;
			this.Index = 0;
			BotData.BotState = BotData.State.Others;
			this._ctsBot = new CancellationTokenSource();
			this._questDelayCounter = new Stopwatch();
			this._boostDelayCounter = new Stopwatch();
			World.ItemDropped += this.OnItemDropped;
			Player.Quests.QuestsLoaded += this.OnQuestsLoaded;
			Player.Quests.QuestCompleted += this.OnQuestCompleted;
			this._questDelayCounter.Start();
			this.LoadAllQuests();
			this.LoadBankItems();
			this.CheckBoosts();
			this._boostDelayCounter.Start();
			OptionsManager.Start();
			Task.Factory.StartNew<Task>(new Func<Task>(this.Activate), this._ctsBot.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
			BotData.BotMap = null;
			BotData.BotCell = null;
			BotData.BotPad = null;
			BotData.BotSkill = null;
			BotData.BotState = BotData.State.Others;
			BotData.SkillSet.Clear();
			for (int j = 0; j < this.Configuration.Skills.Count; j++)
			{
				if (this.Configuration.Skills[j].Type == Skill.SkillType.Label)
				{
					BotData.SkillSet.Add(this.Configuration.Skills[j].Text.ToUpper(), j);
				}
			}
			if (config.Items.Count > 0)
			{
				Player.Bank.LoadItems();
				foreach (string text in config.Items)
				{
					if (!Player.Inventory.ContainsItem(text, "*") && Player.Bank.ContainsItem(text, "*"))
					{
						Player.Bank.TransferFromBank(text);
						Task.Delay(70);
						LogForm.Instance.AppendDebug("Transferred from Bank: " + text + "\r\n");
					}
					else if (Player.Inventory.ContainsItem(text, "*"))
					{
						LogForm.Instance.AppendDebug("Item Already exists in Inventory: " + text + "\r\n");
					}
				}
			}
			List<InventoryItem> inventory = Player.Inventory.Items;
			int num = (from i in Enumerable.Range(0, config.Items.Count)
			where inventory.Find((InventoryItem x) => x.Name.ToLower() == config.Items[i].ToLower()) == null
			select i).Count<int>();
			if (config.Items != null && num > Player.Inventory.AvailableSlots)
			{
				int num2 = config.Items.Count - num - Player.Inventory.AvailableSlots;
				MessageBox.Show(string.Concat(new object[]
				{
					"You don't have enough available inventory slots to use this bot, please bank some items, you need ",
					config.Items.Count,
					" Free Inventory spots in total (you need ",
					num2,
					" more),"
				}), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0002D070 File Offset: 0x0002B270
		public void Stop()
		{
			CancellationTokenSource ctsBot = this._ctsBot;
			if (ctsBot != null)
			{
				ctsBot.Cancel(false);
			}
			World.ItemDropped -= this.OnItemDropped;
			Player.Quests.QuestsLoaded -= this.OnQuestsLoaded;
			Player.Quests.QuestCompleted -= this.OnQuestCompleted;
			this._questDelayCounter.Stop();
			this._boostDelayCounter.Stop();
			OptionsManager.Stop();
			this.IsRunning = false;
			BotData.BotState = BotData.State.Others;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0002D0F4 File Offset: 0x0002B2F4
		private async Task Activate()
		{
			while (!this._ctsBot.IsCancellationRequested)
			{
				if (!Player.IsLoggedIn)
				{
					if (!this.Configuration.AutoRelogin)
					{
						this.Stop();
						break;
					}
					OptionsManager.Stop();
					await AutoRelogin.Login(this.Configuration.Server, this.Configuration.RelogDelay, this._ctsBot, this.Configuration.RelogRetryUponFailure);
					this.Index = 0;
					this.LoadAllQuests();
					this.LoadBankItems();
					OptionsManager.Start();
				}
				if (!this._ctsBot.IsCancellationRequested)
				{
					if (Player.IsLoggedIn && !Player.IsAlive)
					{
						World.SetSpawnPoint();
						await this.WaitUntil(() => Player.IsAlive, () => this.IsRunning && Player.IsLoggedIn, -1);
						this.Index = ((!this.Configuration.RestartUponDeath) ? (this.Index - 1) : 0);
					}
					if (!this._ctsBot.IsCancellationRequested)
					{
						if (Player.IsAfk)
						{
							Player.MoveToCell(Player.Cell, Player.Pad);
							int index;
							if (this.Index <= 0)
							{
								index = this.Index;
							}
							else
							{
								int index2 = this.Index;
								this.Index = index2 - 1;
								index = index2;
							}
							this.Index = index;
						}
						if (this.Configuration.RestIfHp)
						{
							await this.RestHealth();
						}
						if (!this._ctsBot.IsCancellationRequested)
						{
							if (this.Configuration.RestIfMp)
							{
								await this.RestMana();
							}
							if (!this._ctsBot.IsCancellationRequested)
							{
								Action<int> indexChanged = this.IndexChanged;
								if (indexChanged != null)
								{
									indexChanged(this.Index);
								}
								IBotCommand cmd = this.Configuration.Commands[this.Index];
								await cmd.Execute(this);
								if (!this._ctsBot.IsCancellationRequested)
								{
									if (this.Configuration.BotDelay > 0 && (!this.Configuration.SkipDelayIndexIf || (this.Configuration.SkipDelayIndexIf && cmd.RequiresDelay())))
									{
										await Task.Delay(this._config.BotDelay);
									}
									if (!this._ctsBot.IsCancellationRequested)
									{
										if (this.Configuration.Quests.Count > 0)
										{
											await this.CheckQuests();
										}
										if (!this._ctsBot.IsCancellationRequested)
										{
											if (this.Configuration.Boosts.Count > 0)
											{
												this.CheckBoosts();
											}
											if (!this._ctsBot.IsCancellationRequested)
											{
												this.Index++;
												continue;
											}
										}
									}
								}
							}
						}
					}
				}
				return;
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0002D13C File Offset: 0x0002B33C
		private async Task RestHealth()
		{
			if ((double)Player.Health / (double)Player.HealthMax <= (double)this.Configuration.RestHp / 100.0)
			{
				BotData.State TempState = BotData.BotState;
				BotData.BotState = BotData.State.Rest;
				if (this.Configuration.ExitCombatBeforeRest)
				{
					Player.MoveToCell(Player.Cell, Player.Pad);
					await Task.Delay(500);
				}
				Player.Rest();
				await this.WaitUntil(() => Player.Health >= Player.HealthMax, null, 15);
				BotData.BotState = TempState;
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0002D184 File Offset: 0x0002B384
		private async Task RestMana()
		{
			if ((double)Player.Mana / (double)Player.ManaMax <= (double)this.Configuration.RestMp / 100.0)
			{
				BotData.State TempState = BotData.BotState;
				BotData.BotState = BotData.State.Rest;
				if (this.Configuration.ExitCombatBeforeRest)
				{
					Player.MoveToCell(Player.Cell, Player.Pad);
					await Task.Delay(500);
				}
				Player.Rest();
				await this.WaitUntil(() => Player.Mana >= Player.ManaMax, null, 15);
				BotData.BotState = TempState;
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0002D1CC File Offset: 0x0002B3CC
		private void CheckBoosts()
		{
			if (this._boostDelayCounter.ElapsedMilliseconds >= 10000L)
			{
				foreach (InventoryItem inventoryItem in this.Configuration.Boosts)
				{
					if (!Player.HasActiveBoost(inventoryItem.Name))
					{
						Player.UseBoost(inventoryItem.Id);
					}
				}
				this._boostDelayCounter.Restart();
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0002D254 File Offset: 0x0002B454
		private async Task CheckQuests()
		{
			if (World.IsActionAvailable(LockActions.TryQuestComplete) && this._questDelayCounter.ElapsedMilliseconds >= 3000L)
			{
				Quest quest = this.Configuration.Quests.FirstOrDefault((Quest q) => q.CanComplete);
				if (quest != null)
				{
					BotData.State TempState = BotData.BotState;
					BotData.BotState = BotData.State.Quest;
					string pCell = Player.Cell;
					string pPad = Player.Pad;
					if (this._config.ExitCombatBeforeQuest)
					{
						while (Player.CurrentState == Player.State.InCombat)
						{
							Player.MoveToCell("Blank", "Left");
							await Task.Delay(2200);
						}
					}
					quest.Complete();
					if (this._config.ExitCombatBeforeQuest && Player.Cell != pCell)
					{
						Player.MoveToCell(pCell, pPad);
					}
					BotData.BotState = TempState;
					this._questDelayCounter.Restart();
				}
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00006193 File Offset: 0x00004393
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x0000619B File Offset: 0x0000439B
		public int DropDelay { get; set; } = 1000;

		// Token: 0x0600068A RID: 1674 RVA: 0x0002D29C File Offset: 0x0002B49C
		private void OnItemDropped(InventoryItem drop)
		{
			this.NotifyDrop(drop);
			bool flag = this.Configuration.Drops.Any((string d) => d.Equals(drop.Name, StringComparison.OrdinalIgnoreCase));
			if (this.Configuration.EnablePickupAll)
			{
				Task.Delay(this.DropDelay);
				World.DropStack.GetDrop(drop.Id);
				return;
			}
			if (this.Configuration.EnablePickup && flag)
			{
				Task.Delay(this.DropDelay);
				World.DropStack.GetDrop(drop.Id);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0002D340 File Offset: 0x0002B540
		private void NotifyDrop(InventoryItem drop)
		{
			if (this.Configuration.NotifyUponDrop.Count > 0 && this.Configuration.NotifyUponDrop.Any((string d) => d.Equals(drop.Name, StringComparison.OrdinalIgnoreCase)))
			{
				for (int i = 0; i < 10; i++)
				{
					Console.Beep();
				}
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0002D3A0 File Offset: 0x0002B5A0
		private void OnQuestsLoaded(List<Quest> quests)
		{
			Bot.<>c__DisplayClass38_0 CS$<>8__locals1 = new Bot.<>c__DisplayClass38_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.qs = (from q in quests
			where CS$<>8__locals1.<>4__this.Configuration.Quests.Any((Quest qq) => qq.Id == q.Id)
			select q).ToList<Quest>();
			int count = CS$<>8__locals1.qs.Count;
			if (CS$<>8__locals1.qs.Count <= 0)
			{
				return;
			}
			if (count == 1)
			{
				CS$<>8__locals1.qs[0].Accept();
				return;
			}
			for (int i = 0; i < count; i++)
			{
				Bot.<>c__DisplayClass38_2 CS$<>8__locals2 = new Bot.<>c__DisplayClass38_2();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				CS$<>8__locals2.ii = i;
				Task.Run(delegate()
				{
					Bot.<>c__DisplayClass38_2.<<OnQuestsLoaded>b__2>d <<OnQuestsLoaded>b__2>d;
					<<OnQuestsLoaded>b__2>d.<>4__this = CS$<>8__locals2;
					<<OnQuestsLoaded>b__2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
					<<OnQuestsLoaded>b__2>d.<>1__state = -1;
					AsyncTaskMethodBuilder <>t__builder = <<OnQuestsLoaded>b__2>d.<>t__builder;
					<>t__builder.Start<Bot.<>c__DisplayClass38_2.<<OnQuestsLoaded>b__2>d>(ref <<OnQuestsLoaded>b__2>d);
					return <<OnQuestsLoaded>b__2>d.<>t__builder.Task;
				});
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0002D43C File Offset: 0x0002B63C
		private void OnQuestCompleted(CompletedQuest quest)
		{
			Quest quest2 = this.Configuration.Quests.FirstOrDefault((Quest q) => q.Id == quest.Id);
			if (quest2 == null)
			{
				return;
			}
			quest2.Accept();
		}

		// Token: 0x04000492 RID: 1170
		public static Bot Instance = new Bot();

		// Token: 0x04000493 RID: 1171
		private int _index;

		// Token: 0x04000494 RID: 1172
		private Configuration _config;

		// Token: 0x04000495 RID: 1173
		private bool _isRunning;

		// Token: 0x04000496 RID: 1174
		private CancellationTokenSource _ctsBot;

		// Token: 0x04000497 RID: 1175
		private Stopwatch _questDelayCounter;

		// Token: 0x04000498 RID: 1176
		private Stopwatch _boostDelayCounter;
	}
}
