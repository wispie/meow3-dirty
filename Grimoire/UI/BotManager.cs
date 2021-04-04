using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grimoire.Botting;
using Grimoire.Botting.Commands;
using Grimoire.Botting.Commands.Combat;
using Grimoire.Botting.Commands.Item;
using Grimoire.Botting.Commands.Map;
using Grimoire.Botting.Commands.Misc;
using Grimoire.Botting.Commands.Misc.Statements;
using Grimoire.Botting.Commands.Quest;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.Networking;
using Grimoire.Properties;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.UI
{
	// Token: 0x02000011 RID: 17
	public partial class BotManager : Form
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000021D3 File Offset: 0x000003D3
		public static BotManager Instance { get; } = new BotManager();

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000021DA File Offset: 0x000003DA
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000021E2 File Offset: 0x000003E2
		public IBotEngine ActiveBotEngine
		{
			get
			{
				return this._activeBotEngine;
			}
			set
			{
				if (this._activeBotEngine.IsRunning)
				{
					throw new InvalidOperationException("Cannot set a new bot engine while the current one is running");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this._activeBotEngine = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000939C File Offset: 0x0000759C
		private ListBox SelectedList
		{
			get
			{
				switch (this.cbLists.SelectedIndex)
				{
				case 1:
					return this.lstSkills;
				case 2:
					return this.lstQuests;
				case 3:
					return this.lstDrops;
				case 4:
					return this.lstBoosts;
				case 5:
					return this.lstItems;
				default:
					return this.lstCommands;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002212 File Offset: 0x00000412
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000221A File Offset: 0x0000041A
		public string CustomName
		{
			get
			{
				return this._customName;
			}
			set
			{
				this._customName = value;
				Flash.Call("ChangeName", new string[]
				{
					this._customName
				});
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000223C File Offset: 0x0000043C
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002244 File Offset: 0x00000444
		public string CustomGuild
		{
			get
			{
				return this._customGuild;
			}
			set
			{
				this._customGuild = value;
				Flash.Call("ChangeGuild", new string[]
				{
					this.txtGuild.Text
				});
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000226B File Offset: 0x0000046B
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002272 File Offset: 0x00000472
		public static int SliderValue { get; set; }

		// Token: 0x0600003E RID: 62 RVA: 0x0000227A File Offset: 0x0000047A
		private BotManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000093FC File Offset: 0x000075FC
		private void BotManager_Load(object sender, EventArgs e)
		{
			this._panels = new Panel[]
			{
				this.pnlCombat,
				this.pnlMap,
				this.pnlQuest,
				this.pnlItem,
				this.pnlMisc,
				this.pnlOptions,
				this.pnlSaved
			};
			this.pnlCombat.Size = new Size(442, 315);
			this.pnlMap.Size = new Size(442, 315);
			this.pnlQuest.Size = new Size(442, 315);
			this.pnlItem.Size = new Size(442, 315);
			this.pnlMisc.Size = new Size(442, 315);
			this.pnlOptions.Size = new Size(442, 315);
			this.pnlSaved.Size = new Size(442, 315);
			this.lstBoosts.DisplayMember = "Text";
			this.lstQuests.DisplayMember = "Text";
			this.lstSkills.DisplayMember = "Text";
			this.cbBoosts.DisplayMember = "Name";
			this.cbServers.DisplayMember = "Name";
			this.lstItems.DisplayMember = "Text";
			this.cbStatement.DisplayMember = "Text";
			this.cbLists.SelectedIndex = 0;
			this._statementCommands = JsonConvert.DeserializeObject<List<StatementCommand>>(Resources.statementcmds, this._serializerSettings);
			this._defaultControlText = JsonConvert.DeserializeObject<Dictionary<string, string>>(Resources.defaulttext, this._serializerSettings);
			OptionsManager.StateChanged += this.OnOptionsStateChanged;
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			string text = config.Get("font");
			if (text != null)
			{
				this.Font = new Font(text, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
			this.lstCommands.ItemHeight = int.Parse(config.Get("CommandsSize") ?? "60");
			this.lstCommands.Font = new Font(text, (float)(this.lstCommands.ItemHeight / 4) - 6.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lstCommands.ItemHeight = this.lstCommands.ItemHeight / 4;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00009660 File Offset: 0x00007860
		private void TextboxEnter(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			textBox.Clear();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000967C File Offset: 0x0000787C
		private void TextboxLeave(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			string text;
			if (string.IsNullOrEmpty(textBox.Text) && this._defaultControlText.TryGetValue(textBox.Name, out text))
			{
				textBox.Text = text;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000096BC File Offset: 0x000078BC
		public void OnServersLoaded(Server[] servers)
		{
			if (servers != null && servers.Length != 0 && this.cbServers.Items.Count <= 1)
			{
				this.cbServers.Items.AddRange(servers);
				this.cbServers.SelectedIndex = 0;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00009704 File Offset: 0x00007904
		private void MoveListItem(int direction)
		{
			if (this.SelectedList.SelectedItem != null && this.SelectedList.SelectedIndex >= 0)
			{
				int num = this.SelectedList.SelectedIndex + direction;
				if (num >= 0 && num < this.SelectedList.Items.Count)
				{
					object selectedItem = this.SelectedList.SelectedItem;
					this.SelectedList.Items.Remove(selectedItem);
					this.SelectedList.Items.Insert(num, selectedItem);
					this.SelectedList.SetSelected(num, true);
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00009790 File Offset: 0x00007990
		private void MoveListItemByKey(int direction)
		{
			if (this.SelectedList.SelectedItem == null || this.SelectedList.SelectedIndex < 0)
			{
				return;
			}
			int num = this.SelectedList.SelectedIndex + direction;
			if (num >= 0 && num < this.SelectedList.Items.Count)
			{
				object selectedItem = this.SelectedList.SelectedItem;
				this.SelectedList.Items.Remove(selectedItem);
				this.SelectedList.Items.Insert(num, selectedItem);
				if (direction == 1)
				{
					this.SelectedList.SetSelected(num - 1, true);
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00009820 File Offset: 0x00007A20
		public Configuration GenerateConfiguration()
		{
			return new Configuration
			{
				Author = this.txtAuthor.Text,
				Description = this.txtDescription.Text,
				Commands = this.lstCommands.Items.Cast<IBotCommand>().ToList<IBotCommand>(),
				Skills = this.lstSkills.Items.Cast<Skill>().ToList<Skill>(),
				Quests = this.lstQuests.Items.Cast<Quest>().ToList<Quest>(),
				Boosts = this.lstBoosts.Items.Cast<InventoryItem>().ToList<InventoryItem>(),
				Drops = this.lstDrops.Items.Cast<string>().ToList<string>(),
				Items = this.lstItems.Items.Cast<string>().ToList<string>(),
				SkillDelay = (int)this.numSkillD.Value,
				ExitCombatBeforeRest = this.chkExitRest.Checked,
				ExitCombatBeforeQuest = this.chkExistQuest.Checked,
				Server = (Server)this.cbServers.SelectedItem,
				AutoRelogin = this.chkRelog.Checked,
				RelogDelay = (int)this.numRelogDelay.Value,
				RelogRetryUponFailure = this.chkRelogRetry.Checked,
				BotDelay = (int)this.numBotDelay.Value,
				EnablePickup = this.chkPickup.Checked,
				EnableRejection = this.chkReject.Checked,
				EnablePickupAll = this.chkPickupAll.Checked,
				EnableRejectAll = this.chkRejectAll.Checked,
				WaitForAllSkills = this.chkAllSkillsCD.Checked,
				WaitForSkill = this.chkSkillCD.Checked,
				SkipDelayIndexIf = this.chkSkip.Checked,
				InfiniteAttackRange = this.chkInfiniteRange.Checked,
				ProvokeMonsters = this.chkProvoke.Checked,
				EnemyMagnet = this.chkMagnet.Checked,
				LagKiller = this.chkLag.Checked,
				HidePlayers = this.chkHidePlayers.Checked,
				SkipCutscenes = this.chkSkipCutscenes.Checked,
				WalkSpeed = (int)this.numWalkSpeed.Value,
				NotifyUponDrop = this.lstSoundItems.Items.Cast<string>().ToList<string>(),
				RestIfMp = this.chkMP.Checked,
				RestIfHp = this.chkHP.Checked,
				EnsureTries = (int)this.numEnsureTries.Value,
				Untarget = this.chkUntarget.Checked,
				BankOnStop = this.chkBankOnStop.Checked,
				RestMp = (int)this.numRestMP.Value,
				RestHp = (int)this.numRest.Value,
				RestartUponDeath = this.chkRestartDeath.Checked,
				EnsureComplete = this.chkEnsureComplete.Checked,
				AFK = this.chkAFK.Checked,
				DropDelay = (int)this.numDropDelay.Value
			};
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00009B70 File Offset: 0x00007D70
		public void ApplyConfiguration(Configuration config)
		{
			if (config != null)
			{
				if (!this.chkMerge.Checked || this.ActiveBotEngine.IsRunning)
				{
					this.lstCommands.Items.Clear();
					this.lstBoosts.Items.Clear();
					this.lstDrops.Items.Clear();
					this.lstQuests.Items.Clear();
					this.lstSkills.Items.Clear();
					this.lstItems.Items.Clear();
					this.lstSoundItems.Items.Clear();
				}
				this.txtSavedAuthor.Text = (config.Author ?? "Author");
				this.txtSavedDesc.Text = (config.Description ?? "Description");
				List<IBotCommand> commands = config.Commands;
				if (commands != null && commands.Count > 0)
				{
					ListBox.ObjectCollection items = this.lstCommands.Items;
					object[] array = config.Commands.ToArray();
					object[] items2 = array;
					items.AddRange(items2);
				}
				List<Skill> skills = config.Skills;
				if (skills != null && skills.Count > 0)
				{
					ListBox.ObjectCollection items3 = this.lstSkills.Items;
					object[] array = config.Skills.ToArray();
					object[] items4 = array;
					items3.AddRange(items4);
				}
				List<Quest> quests = config.Quests;
				if (quests != null && quests.Count > 0)
				{
					ListBox.ObjectCollection items5 = this.lstQuests.Items;
					object[] array = config.Quests.ToArray();
					object[] items6 = array;
					items5.AddRange(items6);
				}
				List<InventoryItem> boosts = config.Boosts;
				if (boosts != null && boosts.Count > 0)
				{
					ListBox.ObjectCollection items7 = this.lstBoosts.Items;
					object[] array = config.Boosts.ToArray();
					object[] items8 = array;
					items7.AddRange(items8);
				}
				List<string> drops = config.Drops;
				if (drops != null && drops.Count > 0)
				{
					ListBox.ObjectCollection items9 = this.lstDrops.Items;
					object[] array = config.Drops.ToArray();
					object[] items10 = array;
					items9.AddRange(items10);
				}
				List<string> items11 = config.Items;
				if (items11 != null && items11.Count > 0)
				{
					ListBox.ObjectCollection items12 = this.lstItems.Items;
					object[] array = config.Items.ToArray();
					object[] items13 = array;
					items12.AddRange(items13);
				}
				this.numSkillD.Value = config.SkillDelay;
				this.chkExitRest.Checked = config.ExitCombatBeforeRest;
				this.chkExistQuest.Checked = config.ExitCombatBeforeQuest;
				if (config.Server != null)
				{
					this.cbServers.SelectedIndex = this.cbServers.Items.Cast<Server>().ToList<Server>().FindIndex((Server s) => s.Name == config.Server.Name);
				}
				this.chkRelog.Checked = config.AutoRelogin;
				this.numRelogDelay.Value = config.RelogDelay;
				this.chkRelogRetry.Checked = config.RelogRetryUponFailure;
				this.numBotDelay.Value = config.BotDelay;
				this.chkPickup.Checked = config.EnablePickup;
				this.chkReject.Checked = config.EnableRejection;
				this.chkPickupAll.Checked = config.EnablePickupAll;
				this.chkRejectAll.Checked = config.EnableRejectAll;
				this.chkAllSkillsCD.Checked = config.WaitForAllSkills;
				this.chkSkillCD.Checked = config.WaitForSkill;
				this.chkSkip.Checked = config.SkipDelayIndexIf;
				this.chkInfiniteRange.Checked = config.InfiniteAttackRange;
				this.chkProvoke.Checked = config.ProvokeMonsters;
				this.chkLag.Checked = config.LagKiller;
				this.chkMagnet.Checked = config.EnemyMagnet;
				this.chkHidePlayers.Checked = config.HidePlayers;
				this.chkSkipCutscenes.Checked = config.SkipCutscenes;
				this.numWalkSpeed.Value = ((config.WalkSpeed <= 0) ? 8 : config.WalkSpeed);
				List<string> notifyUponDrop = config.NotifyUponDrop;
				if (notifyUponDrop != null && notifyUponDrop.Count > 0)
				{
					ListBox.ObjectCollection items14 = this.lstSoundItems.Items;
					object[] array = config.NotifyUponDrop.ToArray();
					object[] array2 = array;
					object[] items15 = array2;
					items14.AddRange(items15);
				}
				this.numRestMP.Value = config.RestMp;
				this.numRest.Value = config.RestHp;
				this.chkMP.Checked = config.RestIfMp;
				this.chkHP.Checked = config.RestIfHp;
				this.numEnsureTries.Value = ((config.EnsureTries <= 0) ? 20 : config.EnsureTries);
				this.chkUntarget.Checked = config.Untarget;
				this.chkBankOnStop.Checked = config.BankOnStop;
				this.chkRestartDeath.Checked = config.RestartUponDeath;
				this.chkEnsureComplete.Checked = config.EnsureComplete;
				this.chkAFK.Checked = config.AFK;
				this.numDropDelay.Value = ((config.DropDelay <= 0) ? 1000 : config.DropDelay);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000A1A8 File Offset: 0x000083A8
		public void OnConfigurationChanged(Configuration config)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new Action(delegate()
				{
					this.ApplyConfiguration(config);
				}));
				return;
			}
			this.ApplyConfiguration(config);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000A1F4 File Offset: 0x000083F4
		public void OnIndexChanged(int index)
		{
			if (index > -1)
			{
				if (base.InvokeRequired)
				{
					base.Invoke(new Action(delegate()
					{
						this.lstCommands.SelectedIndex = index;
					}));
					return;
				}
				this.lstCommands.SelectedIndex = index;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000A24C File Offset: 0x0000844C
		public void OnSkillIndexChanged(int index)
		{
			if (index > -1 && index < this.lstSkills.Items.Count)
			{
				base.Invoke(new Action(delegate()
				{
					this.lstSkills.SelectedIndex = index;
				}));
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000A2A4 File Offset: 0x000084A4
		public void OnIsRunningChanged(bool IsRunning)
		{
			base.Invoke(new Action(delegate()
			{
				if (!IsRunning)
				{
					this.ActiveBotEngine.IsRunningChanged -= this.OnIsRunningChanged;
					this.ActiveBotEngine.IndexChanged -= this.OnIndexChanged;
					this.ActiveBotEngine.ConfigurationChanged -= this.OnConfigurationChanged;
				}
				this.BotStateChanged(IsRunning);
			}));
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000A2D8 File Offset: 0x000084D8
		private void lstCommands_DoubleClick(object sender, EventArgs e)
		{
			if (this.lstCommands.Items.Count <= 0)
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Title = "Load bot";
					openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "Bots");
					openFileDialog.Filter = "Grimoire bots|*.gbot";
					openFileDialog.DefaultExt = ".gbot";
					Configuration config;
					if (openFileDialog.ShowDialog() == DialogResult.OK && this.TryDeserialize(File.ReadAllText(openFileDialog.FileName), out config))
					{
						this.ApplyConfiguration(config);
					}
					return;
				}
			}
			if (this.lstCommands.SelectedIndex > -1)
			{
				int selectedIndex = this.lstCommands.SelectedIndex;
				object obj = this.lstCommands.Items[selectedIndex];
				string text = RawCommandEditor.Show(JsonConvert.SerializeObject(obj, Formatting.Indented, this._serializerSettings));
				if (text != null)
				{
					try
					{
						IBotCommand item = (IBotCommand)JsonConvert.DeserializeObject(text, obj.GetType());
						this.lstCommands.Items.Remove(obj);
						this.lstCommands.Items.Insert(selectedIndex, item);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000A408 File Offset: 0x00008608
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (this.SelectedList.SelectedItem != null)
			{
				int selectedIndex = this.SelectedList.SelectedIndex;
				if (selectedIndex > -1)
				{
					this._RemoveListBoxItem();
				}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000022B3 File Offset: 0x000004B3
		private void btnDown_Click(object sender, EventArgs e)
		{
			this._MoveListBoxDown();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000022BB File Offset: 0x000004BB
		private void btnUp_Click(object sender, EventArgs e)
		{
			this._MoveListBoxUp();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000A438 File Offset: 0x00008638
		private void _RemoveListBoxItem()
		{
			this.SelectedList.BeginUpdate();
			for (int i = this.SelectedList.SelectedIndices.Count - 1; i >= 0; i--)
			{
				int index = this.SelectedList.SelectedIndices[i];
				this.SelectedList.Items.RemoveAt(index);
			}
			this.SelectedList.EndUpdate();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000A49C File Offset: 0x0000869C
		private void _MoveListBoxUp()
		{
			this.SelectedList.BeginUpdate();
			int count = this.SelectedList.SelectedItems.Count;
			for (int i = 0; i < count; i++)
			{
				if (this.SelectedList.SelectedIndices[i] > 0)
				{
					int num = this.SelectedList.SelectedIndices[i] - 1;
					this.SelectedList.Items.Insert(num, this.SelectedList.SelectedItems[i]);
					this.SelectedList.Items.RemoveAt(num + 2);
					this.SelectedList.SelectedItem = this.SelectedList.Items[num];
				}
			}
			this.SelectedList.EndUpdate();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000A558 File Offset: 0x00008758
		private void _MoveListBoxDown()
		{
			this.SelectedList.BeginUpdate();
			int count = this.SelectedList.SelectedItems.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				if (this.SelectedList.SelectedIndices[i] < this.SelectedList.Items.Count - 1)
				{
					int num = this.SelectedList.SelectedIndices[i] + 2;
					this.SelectedList.Items.Insert(num, this.SelectedList.SelectedItems[i]);
					this.SelectedList.Items.RemoveAt(num - 2);
					this.SelectedList.SelectedItem = this.SelectedList.Items[num - 1];
				}
			}
			this.SelectedList.EndUpdate();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000A62C File Offset: 0x0000882C
		private void btnClear_Click(object sender, EventArgs e)
		{
			if (this.chkAll.Checked)
			{
				this.lstBoosts.Items.Clear();
				this.lstCommands.Items.Clear();
				this.lstDrops.Items.Clear();
				this.lstItems.Items.Clear();
				this.lstQuests.Items.Clear();
				this.lstSkills.Items.Clear();
				return;
			}
			this.SelectedList.Items.Clear();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000A6B8 File Offset: 0x000088B8
		private void cbLists_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.lstBoosts.Visible = (this.SelectedList == this.lstBoosts);
			this.lstCommands.Visible = (this.SelectedList == this.lstCommands);
			this.lstDrops.Visible = (this.SelectedList == this.lstDrops);
			this.lstItems.Visible = (this.SelectedList == this.lstItems);
			this.lstQuests.Visible = (this.SelectedList == this.lstQuests);
			this.lstSkills.Visible = (this.SelectedList == this.lstSkills);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002190 File Offset: 0x00000390
		private void BotManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000A75C File Offset: 0x0000895C
		private void btnKill_Click(object sender, EventArgs e)
		{
			string monster = string.IsNullOrEmpty(this.txtMonster.Text) ? "*" : this.txtMonster.Text;
			if (this.txtMonster.Text == "Monster (*  = random)")
			{
				monster = "*";
			}
			this.AddCommand(new CmdKill
			{
				Monster = monster
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000A7D0 File Offset: 0x000089D0
		private void btnKillF_Click(object sender, EventArgs e)
		{
			if (this.txtKillFItem.Text.Length > 0 && this.txtKillFQ.Text.Length > 0)
			{
				string monster = string.IsNullOrEmpty(this.txtKillFMon.Text) ? "*" : this.txtKillFMon.Text;
				string text = this.txtKillFItem.Text;
				string text2 = this.txtKillFQ.Text;
				this.AddCommand(new CmdKillFor
				{
					ItemType = ((!this.rbItems.Checked) ? ItemType.TempItems : ItemType.Items),
					Monster = monster,
					ItemName = text,
					Quantity = text2
				}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000A890 File Offset: 0x00008A90
		private void btnAddSkill_Click(object sender, EventArgs e)
		{
			string text = this.numSkill.Text;
			this.AddSkill(new Skill
			{
				Text = text + ": " + Skill.GetSkillName(text),
				Index = text,
				Type = Skill.SkillType.Normal
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000A8EC File Offset: 0x00008AEC
		private void btnAddSafe_Click(object sender, EventArgs e)
		{
			string text = this.numSkill.Text;
			int safeHealth = (int)this.numSafe.Value;
			this.AddSkill(new Skill
			{
				Text = "[S] " + text + ": " + Skill.GetSkillName(text),
				Index = text,
				SafeHealth = safeHealth,
				Type = Skill.SkillType.Safe,
				SafeMp = this.chkSafeMp.Checked
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022C3 File Offset: 0x000004C3
		private void btnRest_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdRest(), (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000022E2 File Offset: 0x000004E2
		private void btnRestF_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdRest
			{
				Full = true
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000A978 File Offset: 0x00008B78
		private void btnJoin_Click(object sender, EventArgs e)
		{
			string text = this.txtJoin.Text;
			string cell = string.IsNullOrEmpty(this.txtJoinCell.Text) ? "Enter" : this.txtJoinCell.Text;
			string pad = string.IsNullOrEmpty(this.txtJoinPad.Text) ? "Spawn" : this.txtJoinPad.Text;
			if (text.Length > 0)
			{
				this.AddCommand(new CmdJoin
				{
					Map = text,
					Cell = cell,
					Pad = pad
				}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000AA18 File Offset: 0x00008C18
		private void btnCellSwap_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			if (button.Text == "<")
			{
				this.txtJoin.Text = Player.Map + "-" + Flash.Call<string>("RoomNumber", new object[0]);
				this.txtJoinCell.Text = this.txtCell.Text;
				this.txtJoinPad.Text = this.txtPad.Text;
				return;
			}
			if (button.Text == ">")
			{
				this.txtCell.Text = this.txtJoinCell.Text;
				this.txtPad.Text = this.txtJoinPad.Text;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002308 File Offset: 0x00000508
		private void btnCurrCell_Click(object sender, EventArgs e)
		{
			this.txtCell.Text = Player.Cell;
			this.txtPad.Text = Player.Pad;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		private void btnJump_Click(object sender, EventArgs e)
		{
			string cell = string.IsNullOrEmpty(this.txtCell.Text) ? "Enter" : this.txtCell.Text;
			string pad = string.IsNullOrEmpty(this.txtPad.Text) ? "Spawn" : this.txtPad.Text;
			this.AddCommand(new CmdMoveToCell
			{
				Cell = cell,
				Pad = pad
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000AB58 File Offset: 0x00008D58
		private void btnWalk_Click(object sender, EventArgs e)
		{
			string x = this.numWalkX.Value.ToString();
			string y = this.numWalkY.Value.ToString();
			this.AddCommand(new CmdWalk
			{
				X = x,
				Y = y
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000ABB8 File Offset: 0x00008DB8
		private void btnWalkCur_Click(object sender, EventArgs e)
		{
			float[] position = Player.Position;
			this.numWalkX.Value = (decimal)position[0];
			this.numWalkY.Value = (decimal)position[1];
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000ABF4 File Offset: 0x00008DF4
		private void btnWalkRdm_Click(object sender, EventArgs e)
		{
			string x = this.numWalkX.Value.ToString();
			string y = this.numWalkY.Value.ToString();
			this.AddCommand(new CmdWalk
			{
				Type = "Random",
				X = x,
				Y = y
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000AC60 File Offset: 0x00008E60
		private void btnItem_Click(object sender, EventArgs e)
		{
			string text = this.txtItem.Text;
			if (text.Length > 0 && this.cbItemCmds.SelectedIndex > -1)
			{
				IBotCommand cmd;
				switch (this.cbItemCmds.SelectedIndex)
				{
				case 0:
					cmd = new CmdGetDrop
					{
						ItemName = text
					};
					break;
				case 1:
					cmd = new CmdSell
					{
						ItemName = text
					};
					break;
				case 2:
					cmd = new CmdEquip
					{
						ItemName = text
					};
					break;
				case 3:
					cmd = new CmdBankTransfer
					{
						ItemName = text,
						TransferFromBank = false
					};
					break;
				case 4:
					cmd = new CmdBankTransfer
					{
						ItemName = text,
						TransferFromBank = true
					};
					break;
				default:
					cmd = new CmdEquipSet
					{
						ItemName = text
					};
					break;
				}
				this.AddCommand(cmd, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000232A File Offset: 0x0000052A
		private void btnMapItem_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdMapItem
			{
				ItemId = (int)this.numMapItem.Value
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000AD40 File Offset: 0x00008F40
		private void btnBoth_Click(object sender, EventArgs e)
		{
			string text = this.txtWhitelist.Text;
			if (text.Length > 0)
			{
				this.AddDrop(text);
				this.AddItem(text);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000AD70 File Offset: 0x00008F70
		private void btnWhitelist_Click(object sender, EventArgs e)
		{
			string text = this.txtWhitelist.Text;
			if (text.Length > 0)
			{
				this.AddDrop(text);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000AD9C File Offset: 0x00008F9C
		private void btnSwap_Click(object sender, EventArgs e)
		{
			string text = this.txtSwapBank.Text;
			string text2 = this.txtSwapInv.Text;
			if (text.Length > 0 && text2.Length > 0)
			{
				this.AddCommand(new CmdBankSwap
				{
					InventoryItemName = text2,
					BankItemName = text
				}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000235F File Offset: 0x0000055F
		private void btnBoost_Click(object sender, EventArgs e)
		{
			if (this.cbBoosts.SelectedIndex > -1)
			{
				this.lstBoosts.Items.Add(this.cbBoosts.SelectedItem);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000AE00 File Offset: 0x00009000
		private void cbBoosts_Click(object sender, EventArgs e)
		{
			this.cbBoosts.Items.Clear();
			ComboBox.ObjectCollection items = this.cbBoosts.Items;
			object[] array = (from i in Player.Inventory.Items
			where i.Category == "ServerUse"
			select i).ToArray<InventoryItem>();
			object[] array2 = array;
			object[] items2 = array2;
			items.AddRange(items2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000AE68 File Offset: 0x00009068
		private void btnBuy_Click(object sender, EventArgs e)
		{
			if (this.txtShopItem.TextLength > 0)
			{
				this.AddCommand(new CmdBuy
				{
					ItemName = this.txtShopItem.Text,
					ShopId = (int)this.numShopId.Value
				}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000AEC8 File Offset: 0x000090C8
		private void btnQuestAdd_Click(object sender, EventArgs e)
		{
			this.AddQuest((int)this.numQuestID.Value, this.chkQuestItem.Checked ? this.numQuestItem.Value.ToString() : null);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000AF10 File Offset: 0x00009110
		private void btnQuestComplete_Click(object sender, EventArgs e)
		{
			Quest quest = new Quest();
			CmdCompleteQuest cmdCompleteQuest = new CmdCompleteQuest();
			quest.Id = (int)this.numQuestID.Value;
			if (this.chkQuestItem.Checked)
			{
				quest.ItemId = this.numQuestItem.Value.ToString();
			}
			cmdCompleteQuest.Quest = quest;
			this.AddCommand(cmdCompleteQuest, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000AF88 File Offset: 0x00009188
		private void btnQuestAccept_Click(object sender, EventArgs e)
		{
			Quest quest = new Quest
			{
				Id = (int)this.numQuestID.Value
			};
			this.AddCommand(new CmdAcceptQuest
			{
				Quest = quest
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000238B File Offset: 0x0000058B
		private void chkQuestItem_CheckedChanged(object sender, EventArgs e)
		{
			this.numQuestItem.Enabled = this.chkQuestItem.Checked;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000023A3 File Offset: 0x000005A3
		private void btnPacket_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdPacket
			{
				Packet = this.txtPacket.Text
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000AFD8 File Offset: 0x000091D8
		private void btnDelay_Click(object sender, EventArgs e)
		{
			int delay = (int)this.numDelay.Value;
			this.AddCommand(new CmdDelay
			{
				Delay = delay
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000B01C File Offset: 0x0000921C
		private void btnGoto_Click(object sender, EventArgs e)
		{
			string text = this.txtPlayer.Text;
			if (text.Length > 0)
			{
				this.AddCommand(new CmdGotoPlayer
				{
					PlayerName = text
				}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000B064 File Offset: 0x00009264
		private void btnBotDelay_Click(object sender, EventArgs e)
		{
			int delay = (int)this.numBotDelay.Value;
			this.AddCommand(new CmdBotDelay
			{
				Delay = delay
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000023D3 File Offset: 0x000005D3
		private void btnStop_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdStop(), (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000023F2 File Offset: 0x000005F2
		private void btnRestart_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdRestart(), (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000B0A8 File Offset: 0x000092A8
		private void btnLoad_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Load bot";
				openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "Bots");
				openFileDialog.Filter = "Grimoire bots|*.gbot";
				openFileDialog.DefaultExt = ".gbot";
				Configuration config;
				if (openFileDialog.ShowDialog() == DialogResult.OK && this.TryDeserialize(File.ReadAllText(openFileDialog.FileName), out config))
				{
					this.ApplyConfiguration(config);
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000B134 File Offset: 0x00009334
		private bool TryDeserialize(string json, out Configuration config)
		{
			try
			{
				config = JsonConvert.DeserializeObject<Configuration>(json, this._serializerSettings);
				return true;
			}
			catch
			{
			}
			config = null;
			return false;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000B16C File Offset: 0x0000936C
		private void btnSave_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Title = "Save bot";
				saveFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "Bots");
				saveFileDialog.DefaultExt = ".gbot";
				saveFileDialog.Filter = "Grimoire bots|*.gbot";
				saveFileDialog.CheckFileExists = false;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					Configuration value = this.GenerateConfiguration();
					try
					{
						File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(value, Formatting.Indented, this._serializerSettings));
					}
					catch (Exception ex)
					{
						MessageBox.Show("Unable to save bot: " + ex.Message);
					}
				}
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000B228 File Offset: 0x00009428
		private void btnLoadCmd_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				string initialDirectory = Path.Combine(Application.StartupPath, "Bots");
				openFileDialog.Title = "Select bot to load";
				openFileDialog.Filter = "Grimoire bots|*.gbot";
				openFileDialog.InitialDirectory = initialDirectory;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.AddCommand(new CmdLoadBot
					{
						BotFilePath = Extensions.MakeRelativePathFrom(Application.StartupPath, openFileDialog.FileName),
						BotFileName = Path.GetFileName(openFileDialog.FileName)
					}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000B2D4 File Offset: 0x000094D4
		private void cbStatement_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbCategories.SelectedIndex > -1 && this.cbStatement.SelectedIndex > -1)
			{
				StatementCommand statementCommand = (StatementCommand)this.cbStatement.SelectedItem;
				this.txtStatement1.Enabled = (statementCommand.Description1 != null);
				this.txtStatement2.Enabled = (statementCommand.Description2 != null);
				this.txtStatement1.Text = statementCommand.Description1;
				this.txtStatement2.Text = statementCommand.Description2;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000B358 File Offset: 0x00009558
		private void btnStatementAdd_Click(object sender, EventArgs e)
		{
			if (this.cbCategories.SelectedIndex > -1 && this.cbStatement.SelectedIndex > -1)
			{
				string text = this.txtStatement1.Text;
				string text2 = this.txtStatement2.Text;
				StatementCommand statementCommand = (StatementCommand)Activator.CreateInstance(this.cbStatement.SelectedItem.GetType());
				statementCommand.Value1 = text;
				statementCommand.Value2 = text2;
				this.AddCommand((IBotCommand)statementCommand, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000B3E0 File Offset: 0x000095E0
		private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbCategories.SelectedIndex > -1)
			{
				this.cbStatement.Items.Clear();
				string text = this.cbCategories.SelectedItem.ToString();
				ComboBox.ObjectCollection items = this.cbStatement.Items;
				object[] array = (from s in this._statementCommands
				where s.Tag == text
				select s).ToArray<StatementCommand>();
				object[] array2 = array;
				object[] items2 = array2;
				items.AddRange(items2);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002411 File Offset: 0x00000611
		private void btnGotoLabel_Click(object sender, EventArgs e)
		{
			if (this.txtLabel.TextLength > 0)
			{
				this.AddCommand(new CmdGotoLabel
				{
					Label = this.txtLabel.Text
				}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000244F File Offset: 0x0000064F
		private void btnAddLabel_Click(object sender, EventArgs e)
		{
			if (this.txtLabel.TextLength > 0)
			{
				this.AddCommand(new CmdLabel
				{
					Name = this.txtLabel.Text
				}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000248D File Offset: 0x0000068D
		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdLogout(), (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000B460 File Offset: 0x00009660
		private void UpdateTree()
		{
			if (!string.IsNullOrEmpty(this.txtSaved.Text) && Directory.Exists(this.txtSaved.Text))
			{
				this.lblBots.Text = string.Format("Number of Bots: {0}", Directory.EnumerateFiles(this.txtSaved.Text, "*.gbot", SearchOption.AllDirectories).Count<string>());
				this.treeBots.Nodes.Clear();
				this.AddTreeNodes(this.treeBots, this.txtSaved.Text);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000B4F0 File Offset: 0x000096F0
		private void treeBots_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string path = Path.Combine(this.txtSaved.Text, e.Node.FullPath);
			if (File.Exists(path))
			{
				Configuration config;
				if (!this.TryDeserialize(File.ReadAllText(path), out config))
				{
					return;
				}
				this.ApplyConfiguration(config);
			}
			this.lblCommands.Text = string.Format("Number of{0}Commands: {1}", Environment.NewLine, this.lstCommands.Items.Count);
			this.lblSkills.Text = string.Format("Skills: {0}", this.lstSkills.Items.Count);
			this.lblQuests.Text = string.Format("Quests: {0}", this.lstQuests.Items.Count);
			this.lblDrops.Text = string.Format("Drops: {0}", this.lstDrops.Items.Count);
			this.lblBoosts.Text = string.Format("Boosts: {0}", this.lstBoosts.Items.Count);
			this.lblItems.Text = string.Format("Items: {0}", this.lstItems.Items.Count);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000B63C File Offset: 0x0000983C
		private void treeBots_AfterExpand(object sender, TreeViewEventArgs e)
		{
			string path = Path.Combine(this.txtSaved.Text, e.Node.FullPath);
			if (Directory.Exists(path))
			{
				this.AddTreeNodes(e.Node, path);
				if (e.Node.Nodes.Count > 0 && e.Node.Nodes[0].Text == "Loading...")
				{
					e.Node.Nodes.RemoveAt(0);
				}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000B6C0 File Offset: 0x000098C0
		private void AddTreeNodes(TreeNode node, string path)
		{
			foreach (string path2 in Directory.EnumerateDirectories(path, "*", SearchOption.TopDirectoryOnly))
			{
				string add = Path.GetFileName(path2);
				if (node.Nodes.Cast<TreeNode>().ToList<TreeNode>().All((TreeNode n) => n.Text != add))
				{
					node.Nodes.Add(add).Nodes.Add("Loading...");
				}
			}
			foreach (string path3 in Directory.EnumerateFiles(path, "*.gbot", SearchOption.TopDirectoryOnly))
			{
				string add2 = Path.GetFileName(path3);
				if (node.Nodes.Cast<TreeNode>().ToList<TreeNode>().All((TreeNode n) => n.Text != add2))
				{
					node.Nodes.Add(add2);
				}
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000B7EC File Offset: 0x000099EC
		private void AddTreeNodes(TreeView tree, string path)
		{
			foreach (string path2 in Directory.EnumerateDirectories(path, "*", SearchOption.TopDirectoryOnly))
			{
				string add = Path.GetFileName(path2);
				if (tree.Nodes.Cast<TreeNode>().ToList<TreeNode>().All((TreeNode n) => n.Text != add))
				{
					tree.Nodes.Add(add).Nodes.Add("Loading...");
				}
			}
			foreach (string path3 in Directory.EnumerateFiles(path, "*.gbot", SearchOption.TopDirectoryOnly))
			{
				string add2 = Path.GetFileName(path3);
				if (tree.Nodes.Cast<TreeNode>().ToList<TreeNode>().All((TreeNode n) => n.Text != add2))
				{
					tree.Nodes.Add(add2);
				}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000B918 File Offset: 0x00009B18
		private void btnSavedAdd_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.txtSaved.Text))
			{
				string path = Path.Combine(this.txtSaved.Text, this.txtSavedAdd.Text);
				if (!Directory.Exists(path))
				{
					try
					{
						Directory.CreateDirectory(path);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Unable to create directory: " + ex.Message, "Grimoire", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				this.UpdateTree();
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000024AC File Offset: 0x000006AC
		private void btnSoundAdd_Click(object sender, EventArgs e)
		{
			if (this.txtSoundItem.TextLength > 0)
			{
				this.lstSoundItems.Items.Add(this.txtSoundItem.Text);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000B99C File Offset: 0x00009B9C
		private void btnSoundDelete_Click(object sender, EventArgs e)
		{
			int selectedIndex = this.lstSoundItems.SelectedIndex;
			if (selectedIndex > -1)
			{
				this.lstSoundItems.Items.RemoveAt(selectedIndex);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000024D8 File Offset: 0x000006D8
		private void btnSoundClear_Click(object sender, EventArgs e)
		{
			this.lstSoundItems.Items.Clear();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000B9CC File Offset: 0x00009BCC
		private void btnSoundTest_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 5; i++)
			{
				Console.Beep();
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000024EA File Offset: 0x000006EA
		private void chkInfiniteRange_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.InfiniteRange = this.chkInfiniteRange.Checked;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000024FC File Offset: 0x000006FC
		private void chkProvoke_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.ProvokeMonsters = this.chkProvoke.Checked;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000250E File Offset: 0x0000070E
		private void chkMagnet_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.EnemyMagnet = this.chkMagnet.Checked;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002520 File Offset: 0x00000720
		private void chkLag_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.LagKiller = this.chkLag.Checked;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002532 File Offset: 0x00000732
		private void chkHidePlayers_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.HidePlayers = this.chkHidePlayers.Checked;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002544 File Offset: 0x00000744
		private void chkSkipCutscenes_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.SkipCutscenes = this.chkSkipCutscenes.Checked;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002556 File Offset: 0x00000756
		private void numWalkSpeed_ValueChanged(object sender, EventArgs e)
		{
			OptionsManager.WalkSpeed = (int)this.numWalkSpeed.Value;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000256D File Offset: 0x0000076D
		private void chkDisableAnims_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.DisableAnimations = this.chkDisableAnims.Checked;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000B9EC File Offset: 0x00009BEC
		private void OnOptionsStateChanged(bool state)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new Action(delegate()
				{
					this.chkEnableSettings.Checked = state;
				}));
				return;
			}
			this.chkEnableSettings.Checked = state;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000257F File Offset: 0x0000077F
		private void chkEnableSettings_Click(object sender, EventArgs e)
		{
			if (this.chkEnableSettings.Checked)
			{
				OptionsManager.Start();
				return;
			}
			OptionsManager.Stop();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000BA3C File Offset: 0x00009C3C
		private void lstBoxs_KeyPress(object sender, KeyEventArgs e)
		{
			if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Up)
			{
				this._MoveListBoxUp();
				e.Handled = true;
				return;
			}
			if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Down)
			{
				this._MoveListBoxDown();
				e.Handled = true;
				return;
			}
			if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Delete)
			{
				this.btnRemove.PerformClick();
				e.Handled = true;
				return;
			}
			if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.D && this.SelectedList.SelectedIndex > -1)
			{
				ListBox.SelectedObjectCollection selectedItems = this.SelectedList.SelectedItems;
				int num = 0;
				while (selectedItems.Count > num)
				{
					this.SelectedList.Items.Insert(this.SelectedList.SelectedIndex + selectedItems.Count + num, selectedItems[num]);
					num++;
				}
				e.Handled = true;
				return;
			}
			if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.C && this.SelectedList.SelectedIndex > -1)
			{
				Clipboard.Clear();
				Configuration value = new Configuration
				{
					Commands = this.lstCommands.SelectedItems.Cast<IBotCommand>().ToList<IBotCommand>(),
					Skills = this.lstSkills.SelectedItems.Cast<Skill>().ToList<Skill>(),
					Quests = this.lstQuests.SelectedItems.Cast<Quest>().ToList<Quest>(),
					Boosts = this.lstBoosts.SelectedItems.Cast<InventoryItem>().ToList<InventoryItem>(),
					Drops = this.lstDrops.SelectedItems.Cast<string>().ToList<string>(),
					Items = this.lstItems.SelectedItems.Cast<string>().ToList<string>()
				};
				Clipboard.SetText(JsonConvert.SerializeObject(value, Formatting.Indented, this._serializerSettings));
				e.Handled = true;
				return;
			}
			if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.V)
			{
				Configuration configuration;
				this.TryDeserialize(Clipboard.GetText(), out configuration);
				List<IBotCommand> commands = configuration.Commands;
				if (commands != null && commands.Count > 0)
				{
					ListBox.ObjectCollection items = this.lstCommands.Items;
					object[] array = configuration.Commands.ToArray();
					object[] array2 = array;
					int selectedIndex = this.lstCommands.SelectedIndex;
					this.lstCommands.SelectedIndex = -1;
					int num2 = 0;
					while (array2.Count<object>() > num2)
					{
						items.Insert(selectedIndex + num2 + 1, array2[num2]);
						this.lstCommands.SelectedIndex = selectedIndex + num2 + 1;
						num2++;
					}
				}
				List<Skill> skills = configuration.Skills;
				if (skills != null && skills.Count > 0)
				{
					ListBox.ObjectCollection items2 = this.lstSkills.Items;
					object[] array = configuration.Skills.ToArray();
					object[] items3 = array;
					items2.AddRange(items3);
				}
				List<Quest> quests = configuration.Quests;
				if (quests != null && quests.Count > 0)
				{
					ListBox.ObjectCollection items4 = this.lstQuests.Items;
					object[] array = configuration.Quests.ToArray();
					object[] items5 = array;
					items4.AddRange(items5);
				}
				List<InventoryItem> boosts = configuration.Boosts;
				if (boosts != null && boosts.Count > 0)
				{
					ListBox.ObjectCollection items6 = this.lstBoosts.Items;
					object[] array = configuration.Boosts.ToArray();
					object[] items7 = array;
					items6.AddRange(items7);
				}
				List<string> drops = configuration.Drops;
				if (drops != null && drops.Count > 0)
				{
					ListBox.ObjectCollection items8 = this.lstDrops.Items;
					object[] array = configuration.Drops.ToArray();
					object[] items9 = array;
					items8.AddRange(items9);
				}
				List<string> items10 = configuration.Items;
				if (items10 != null && items10.Count > 0)
				{
					ListBox.ObjectCollection items11 = this.lstItems.Items;
					object[] array = configuration.Items.ToArray();
					object[] items12 = array;
					items11.AddRange(items12);
				}
				e.Handled = true;
				return;
			}
			if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
			{
				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.Title = "Save bot";
					saveFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "Bots");
					saveFileDialog.DefaultExt = ".gbot";
					saveFileDialog.Filter = "Grimoire bots|*.gbot";
					saveFileDialog.CheckFileExists = false;
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						Configuration value2 = this.GenerateConfiguration();
						try
						{
							File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(value2, Formatting.Indented, this._serializerSettings));
						}
						catch (Exception ex)
						{
							MessageBox.Show("Unable to save bot: " + ex.Message);
						}
					}
				}
				e.Handled = true;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		private void AddCommand(IBotCommand cmd, bool Insert)
		{
			if (Insert)
			{
				this.lstCommands.Items.Insert((this.lstCommands.SelectedIndex > -1) ? this.lstCommands.SelectedIndex : this.lstCommands.Items.Count, cmd);
				return;
			}
			this.lstCommands.Items.Add(cmd);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000BF4C File Offset: 0x0000A14C
		private void AddSkill(Skill skill, bool Insert)
		{
			if (Insert)
			{
				this.lstSkills.Items.Insert((this.lstSkills.SelectedIndex > -1) ? this.lstSkills.SelectedIndex : this.lstSkills.Items.Count, skill);
				return;
			}
			this.lstSkills.Items.Add(skill);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000BFAC File Offset: 0x0000A1AC
		public void btnBotStart_ClickAsync(object sender, EventArgs e)
		{
			if (Player.IsAlive && Player.IsLoggedIn && this.lstCommands.Items.Count > 0)
			{
				this.lstCommands.SelectionMode = SelectionMode.One;
				this.lstItems.SelectionMode = SelectionMode.One;
				this.lstSkills.SelectionMode = SelectionMode.One;
				this.lstQuests.SelectionMode = SelectionMode.One;
				this.lstDrops.SelectionMode = SelectionMode.One;
				this.lstBoosts.SelectionMode = SelectionMode.One;
				this.ActiveBotEngine.IsRunningChanged += this.OnIsRunningChanged;
				this.ActiveBotEngine.IndexChanged += this.OnIndexChanged;
				this.ActiveBotEngine.ConfigurationChanged += this.OnConfigurationChanged;
				this.ActiveBotEngine.Start(this.GenerateConfiguration());
				this.BotStateChanged(true);
				Root.Instance.BotStateChanged(true);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000C094 File Offset: 0x0000A294
		public async void btnBotStop_Click(object sender, EventArgs e)
		{
			if (this.lstItems != null && this.chkBankOnStop.Checked)
			{
				foreach (InventoryItem item in Player.Inventory.Items)
				{
					if (!item.IsEquipped && item.IsAcItem && item.Category != "Class" && item.Name.ToLower() != "treasure potion" && this.lstItems.Items.Contains(item.Name))
					{
						Player.Bank.TransferToBank(item.Name);
						await Task.Delay(70);
						LogForm.Instance.AppendDebug("Transferred to Bank: " + item.Name + "\r\n");
					}
					item = null;
				}
				List<InventoryItem>.Enumerator enumerator = default(List<InventoryItem>.Enumerator);
				LogForm.Instance.AppendDebug("Banked all AC Items in Items list \r\n");
			}
			this.btnBotStart.Enabled = false;
			this.ActiveBotEngine.Stop();
			this.lstCommands.SelectionMode = SelectionMode.MultiExtended;
			this.lstItems.SelectionMode = SelectionMode.MultiExtended;
			this.lstSkills.SelectionMode = SelectionMode.MultiExtended;
			this.lstQuests.SelectionMode = SelectionMode.MultiExtended;
			this.lstDrops.SelectionMode = SelectionMode.MultiExtended;
			this.lstBoosts.SelectionMode = SelectionMode.MultiExtended;
			await Task.Delay(2000);
			this.BotStateChanged(false);
			Root.Instance.BotStateChanged(false);
			this.btnBotStart.Enabled = true;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		public void BotStateChanged(bool IsRunning)
		{
			if (IsRunning)
			{
				this.btnBotStart.Hide();
				this.btnBotStop.Show();
			}
			else
			{
				this.btnBotStop.Hide();
				this.btnBotStart.Show();
			}
			this.btnUp.Enabled = !IsRunning;
			this.btnDown.Enabled = !IsRunning;
			this.btnClear.Enabled = !IsRunning;
			this.btnRemove.Enabled = !IsRunning;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002599 File Offset: 0x00000799
		public void AddCommand(IBotCommand cmd)
		{
			this.lstCommands.Items.Add(cmd);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000C14C File Offset: 0x0000A34C
		public void AddQuest(int QuestID, string ItemID = null)
		{
			Quest quest = new Quest
			{
				Id = QuestID,
				ItemId = ItemID
			};
			quest.Text = ((quest.ItemId != null) ? string.Format("{0}:{1}", quest.Id, quest.ItemId) : quest.Id.ToString());
			if (!this.lstQuests.Items.Contains(quest))
			{
				this.lstQuests.Items.Add(quest);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000025AD File Offset: 0x000007AD
		public void AddDrop(string Name)
		{
			if (!this.lstDrops.Items.Contains(Name))
			{
				this.lstDrops.Items.Add(Name);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000C1CC File Offset: 0x0000A3CC
		private void btnAddSkillSet_Click(object sender, EventArgs e)
		{
			if (this.txtSkillSet.TextLength > 0)
			{
				this.AddSkill(new Skill
				{
					Text = "[" + this.txtSkillSet.Text.ToUpper() + "]",
					Type = Skill.SkillType.Label
				}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000C230 File Offset: 0x0000A430
		private void btnUseSkillSet_Click(object sender, EventArgs e)
		{
			if (this.txtSkillSet.TextLength > 0)
			{
				this.AddCommand(new CmdSkillSet
				{
					Name = this.txtSkillSet.Text.ToUpper()
				}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002609 File Offset: 0x00000809
		private void btnBuyFast_Click(object sender, EventArgs e)
		{
			if (this.txtShopItem.TextLength > 0)
			{
				this.AddCommand(new CmdBuyFast
				{
					ItemName = this.txtShopItem.Text
				}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002647 File Offset: 0x00000847
		private void btnLoadShop_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdLoad
			{
				ShopId = (int)this.numShopId.Value
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000166FC File Offset: 0x000148FC
		public void changeGenderAsync(object sender, EventArgs e)
		{
			int num = Flash.Call<int>("UserID", new string[0]);
			string text = Flash.Call<string>("Gender", new string[0]);
			text = ((!text.Contains("M")) ? "M" : "F");
			string data = string.Format("{{\"t\":\"xt\",\"b\":{{\"r\":-1,\"o\":{{\"cmd\":\"genderSwap\",\"bitSuccess\":1,\"gender\":\"{0}\",\"intCoins\":0,\"uid\":\"{1}\",\"strHairFileName\":\"\",\"HairID\":\"\",\"strHairName\":\"\"}}}}}}", text, num);
			Proxy.Instance.SendToClient(data);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000267C File Offset: 0x0000087C
		private void logScript(object sender, EventArgs e)
		{
			this.AddCommand(new CmdLog
			{
				Text = this.txtLog.Text
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000026AC File Offset: 0x000008AC
		private void logDebug(object sender, EventArgs e)
		{
			this.AddCommand(new CmdLog
			{
				Text = this.txtLog.Text,
				Debug = true
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000026E3 File Offset: 0x000008E3
		private void logsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LogForm.Instance.Show();
			LogForm.Instance.BringToFront();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000026F9 File Offset: 0x000008F9
		private void btnYulgar_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdYulgar(), (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002718 File Offset: 0x00000918
		private void btnProvoke_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdToggleProvoke
			{
				Type = 2
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00016764 File Offset: 0x00014964
		private void btnchangeName_Click(object sender, EventArgs e)
		{
			foreach (string b in Configuration.BlockedPlayers)
			{
				if (this.txtUsername.Text.ToLower() == b)
				{
					Environment.Exit(0);
				}
			}
			this.CustomName = this.txtUsername.Text;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000167E0 File Offset: 0x000149E0
		private void btnchangeGuild_Click(object sender, EventArgs e)
		{
			foreach (string b in Configuration.BlockedPlayers)
			{
				if (this.txtUsername.Text.ToLower() == b)
				{
					Environment.Exit(0);
				}
			}
			this.CustomGuild = this.txtGuild.Text;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000273E File Offset: 0x0000093E
		private void btnHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Join Discord", "discord.gg/aqwbots", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002753 File Offset: 0x00000953
		private void btnProvokeOn_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdToggleProvoke
			{
				Type = 1
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002779 File Offset: 0x00000979
		private void btnProvokeOff_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdToggleProvoke
			{
				Type = 0
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000279F File Offset: 0x0000099F
		public void AddItem(string Name)
		{
			if (!this.lstItems.Items.Contains(Name))
			{
				this.lstItems.Items.Add(Name);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0001685C File Offset: 0x00014A5C
		private void btnUnbanklst_Click(object sender, EventArgs e)
		{
			string text = this.txtWhitelist.Text;
			if (text.Length > 0)
			{
				this.AddItem(text);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000027C6 File Offset: 0x000009C6
		private void chkPacket_CheckChanged(object sender, EventArgs e)
		{
			OptionsManager.Packet = this.chkPacket.Checked;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00016888 File Offset: 0x00014A88
		private void lstLogText_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.Control && e.KeyCode == Keys.C;
			if (flag)
			{
				string data = this.lstLogText.SelectedItem.ToString();
				Clipboard.SetData(DataFormats.StringFormat, data);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000027D8 File Offset: 0x000009D8
		private void numOptionsTimer_ValueChanged(object sender, EventArgs e)
		{
			OptionsManager.Timer = (int)this.numOptionsTimer.Value;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000027EF File Offset: 0x000009EF
		private void tabControl1_Selected(object sender, TabControlEventArgs e)
		{
			if (e.TabPage == this.tabBots)
			{
				this.txtSaved.Text = Path.Combine(Application.StartupPath, "Bots");
				this.UpdateTree();
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000281F File Offset: 0x00000A1F
		private void txtSaved_TextChanged(object sender, EventArgs e)
		{
			this.UpdateTree();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000168CC File Offset: 0x00014ACC
		private void chkEnsureComplete_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkEnsureComplete.Checked;
			this.numEnsureTries.Enabled = @checked;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000168F4 File Offset: 0x00014AF4
		private void lstLogText_DoubleClick(object sender, EventArgs e)
		{
			string str = (this.txtLog.Text == "Logs") ? "" : (this.txtLog.Text + " ");
			string str2 = this.lstLogText.SelectedItem.ToString();
			this.txtLog.Text = str + str2;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00016958 File Offset: 0x00014B58
		public void MultiMode()
		{
			if (this.lstCommands.SelectionMode != SelectionMode.MultiExtended)
			{
				this.lstCommands.SelectionMode = SelectionMode.MultiExtended;
				this.lstItems.SelectionMode = SelectionMode.MultiExtended;
				this.lstSkills.SelectionMode = SelectionMode.MultiExtended;
				this.lstQuests.SelectionMode = SelectionMode.MultiExtended;
				this.lstDrops.SelectionMode = SelectionMode.MultiExtended;
				this.lstBoosts.SelectionMode = SelectionMode.MultiExtended;
				return;
			}
			this.lstCommands.SelectionMode = SelectionMode.One;
			this.lstItems.SelectionMode = SelectionMode.One;
			this.lstSkills.SelectionMode = SelectionMode.One;
			this.lstQuests.SelectionMode = SelectionMode.One;
			this.lstDrops.SelectionMode = SelectionMode.One;
			this.lstBoosts.SelectionMode = SelectionMode.One;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002827 File Offset: 0x00000A27
		private void chkUntarget_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.Untarget = this.chkUntarget.Checked;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002839 File Offset: 0x00000A39
		private void lstCommands_DragDrop(object sender, DragEventArgs e)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000283B File Offset: 0x00000A3B
		private void lstCommands_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002839 File Offset: 0x00000A39
		private void lstCommands_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00016A04 File Offset: 0x00014C04
		private void lstCommands_MouseEnter(object sender, EventArgs e)
		{
			if (this.lstCommands.Items.Count <= 0)
			{
				Color backColor = this.lstCommands.BackColor;
				Color backColor2 = Color.FromArgb((int)backColor.A, (int)((double)backColor.R * 0.8), (int)((double)backColor.G * 0.8), (int)((double)backColor.B * 0.8));
				this.lstCommands.BackColor = backColor2;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002848 File Offset: 0x00000A48
		private void lstCommands_MouseLeave(object sender, EventArgs e)
		{
			this.lstCommands.BackColor = Control.DefaultBackColor;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000285A File Offset: 0x00000A5A
		private void btnBlank_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdBlank2
			{
				Text = " "
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002884 File Offset: 0x00000A84
		private void chkAFK_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.AFK = this.chkAFK.Checked;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002896 File Offset: 0x00000A96
		private void chkRelog_CheckedChanged(object sender, EventArgs e)
		{
			this.chkAFK.Enabled = this.chkRelog.Checked;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00016A84 File Offset: 0x00014C84
		private void btnCurrBlank_Click(object sender, EventArgs e)
		{
			this.txtJoinCell.Text = "Blank";
			this.txtJoinPad.Text = "Satan";
			this.txtCell.Text = "Blank";
			this.txtPad.Text = "Satan";
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000028AE File Offset: 0x00000AAE
		private void btnSetSpawn_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdSetSpawn(), (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000028CD File Offset: 0x00000ACD
		private void btnBeep_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdBeep
			{
				Times = (int)this.numBeepTimes.Value
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00016AD4 File Offset: 0x00014CD4
		private void btnAddSkillCmd_Click(object sender, EventArgs e)
		{
			string text = this.numSkill.Text;
			this.AddCommand(new CmdUseSkill
			{
				Index = text,
				SafeHp = (int)this.numSafe.Value,
				SafeMp = (int)this.numSafe.Value,
				Wait = this.chkSkillCD.Checked,
				Skill = text + ": " + Skill.GetSkillName(text)
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002902 File Offset: 0x00000B02
		private void chkBuffup_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.Buff = this.chkBuffup.Checked;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00016B68 File Offset: 0x00014D68
		private void btnSetHero_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			string name = button.Name;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(name);
			if (num <= 1478381029U)
			{
				if (num != 244949655U)
				{
					if (num != 800626398U)
					{
						if (num != 1478381029U)
						{
							return;
						}
						if (!(name == "btnSetNonMem"))
						{
							return;
						}
						Player.ChangeAccessLevel("Non Member");
						return;
					}
					else
					{
						if (!(name == "btnSetUndecided"))
						{
							return;
						}
						Proxy.Instance.SendToServer("%xt%zm%updateQuest%218701%41%5%");
						return;
					}
				}
				else
				{
					if (!(name == "btnSetChaos"))
					{
						return;
					}
					Proxy.Instance.SendToServer("%xt%zm%updateQuest%218701%41%3%");
					return;
				}
			}
			else if (num <= 2497950848U)
			{
				if (num != 1815683084U)
				{
					if (num != 2497950848U)
					{
						return;
					}
					if (!(name == "btnSetGood"))
					{
						return;
					}
					Proxy.Instance.SendToServer("%xt%zm%updateQuest%218701%41%1%");
					return;
				}
				else
				{
					if (!(name == "btnSetModerator"))
					{
						return;
					}
					Player.ChangeAccessLevel("Moderator");
					return;
				}
			}
			else if (num != 3857540335U)
			{
				if (num != 4280178614U)
				{
					return;
				}
				if (!(name == "btnSetMem"))
				{
					return;
				}
				Player.ChangeAccessLevel("Member");
				return;
			}
			else
			{
				if (!(name == "btnSetEvil"))
				{
					return;
				}
				Proxy.Instance.SendToServer("%xt%zm%updateQuest%218701%41%2%");
				return;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002914 File Offset: 0x00000B14
		private void chkToggleMute_CheckedChanged(object sender, EventArgs e)
		{
			Player.ToggleMute(this.chkToggleMute.Checked);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00016C9C File Offset: 0x00014E9C
		private void changeFontsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog fontDialog = new FontDialog();
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				this.Font = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, FontStyle.Regular, GraphicsUnit.Point, 0);
				foreach (object obj in base.Controls)
				{
					Control control = (Control)obj;
					control.Font = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, FontStyle.Regular, GraphicsUnit.Point, 0);
				}
				DialogResult dialogResult = MessageBox.Show("Would you like to Save style and have it load on the next startup?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					Config config = Config.Load(Application.StartupPath + "\\config.cfg");
					config.Set("font", fontDialog.Font.FontFamily.Name.ToString());
					config.Set("fontSize", fontDialog.Font.Size.ToString());
					config.Save();
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002926 File Offset: 0x00000B26
		private void numDropDelay_ValueChanged(object sender, EventArgs e)
		{
			Bot.Instance.DropDelay = (int)this.numDropDelay.Value;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00016DC0 File Offset: 0x00014FC0
		private void btnAttack_Click(object sender, EventArgs e)
		{
			string text = string.IsNullOrEmpty(this.txtMonster.Text) ? "*" : this.txtMonster.Text;
			this.AddCommand(new CmdAttack
			{
				Monster = ((this.txtMonster.Text == "Monster (*  = random)") ? "*" : this.txtMonster.Text)
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002942 File Offset: 0x00000B42
		private void chkBankOnStop_CheckedChanged(object sender, EventArgs e)
		{
			Configuration.Instance.BankOnStop = this.chkBankOnStop.Checked;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00016E40 File Offset: 0x00015040
		private void btnGotoIndex_Click(object sender, EventArgs e)
		{
			string text = ((Button)sender).Text;
			IBotCommand cmd;
			if (!(text == "Up++"))
			{
				if (!(text == "Down--"))
				{
					cmd = new CmdIndex
					{
						Type = CmdIndex.IndexCommand.Goto,
						Index = (int)this.numIndexCmd.Value
					};
				}
				else
				{
					cmd = new CmdIndex
					{
						Type = CmdIndex.IndexCommand.Down,
						Index = (int)this.numIndexCmd.Value
					};
				}
			}
			else
			{
				cmd = new CmdIndex
				{
					Type = CmdIndex.IndexCommand.Up,
					Index = (int)this.numIndexCmd.Value
				};
			}
			this.AddCommand(cmd, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00016EFC File Offset: 0x000150FC
		private void TogglePages()
		{
			Size clientSize = this.splitContainer2.Panel1.ClientSize;
			int width = this.splitContainer2.Panel1.ClientSize.Width;
			Size clientSize2 = this.splitContainer2.Panel2.ClientSize;
			int width2 = this.splitContainer2.Panel2.ClientSize.Width;
			if (this.tabControl1.Visible)
			{
				base.ClientSize = new Size(width, base.ClientSize.Height);
				this.tabControl1.Visible = false;
				this.splitContainer2.Panel2Collapsed = true;
				return;
			}
			base.ClientSize = new Size(width + 500, base.ClientSize.Height);
			this.splitContainer2.Panel2Collapsed = false;
			this.tabControl1.Visible = true;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00016FDC File Offset: 0x000151DC
		private void lstCommands_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index <= -1)
			{
				return;
			}
			e.DrawBackground();
			IBotCommand botCommand = (IBotCommand)this.lstCommands.Items[e.Index];
			string[] array = botCommand.GetType().ToString().Split(new char[]
			{
				'.'
			});
			string text = array[array.Count<string>() - 1].Replace("Cmd", "");
			string text2 = SystemColors.WindowText.ToArgb().ToString();
			SolidBrush brush = new SolidBrush(Color.FromArgb(this.GetColor(text)));
			SolidBrush brush2 = new SolidBrush(Color.FromArgb(this.GetColor("Index")));
			RectangleF layoutRectangle = e.Bounds;
			Font font = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Regular);
			StringFormat format = new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};
			string[] source = new string[]
			{
				"Label",
				"GotoLabel",
				"Blank",
				"Blank2",
				"StatementCommand",
				"Index",
				"SkillSet"
			};
			if (botCommand is CmdBlank || botCommand is CmdBlank2)
			{
				string text3 = this.lstCommands.Items[e.Index].ToString();
				Font font2 = new Font("Arial", e.Font.Size + 6.5f, FontStyle.Bold, GraphicsUnit.Pixel);
				if (botCommand is CmdBlank2 && text3.Contains("[RGB]"))
				{
					using (Font font3 = new Font("Times New Roman", e.Font.Size + 6.5f, FontStyle.Bold, GraphicsUnit.Pixel))
					{
						FontInfo fontInfo = new FontInfo(e.Graphics, font3);
						SizeF sizeF = e.Graphics.MeasureString(text3, font3);
						int x = (int)(((float)base.ClientSize.Width - sizeF.Width) / 2f);
						int num = (int)(((float)base.ClientSize.Height - sizeF.Height) / 2f);
						int y = (int)((float)num + fontInfo.InternalLeadingPixels) + (int)fontInfo.InternalLeadingPixels;
						int y2 = (int)((float)num + fontInfo.AscentPixels) + 5;
						using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(x, y), new Point(x, y2), Color.Red, Color.Violet))
						{
							Color[] array2 = new Color[]
							{
								Color.FromArgb(255, 0, 0),
								Color.FromArgb(255, 0, 0),
								Color.FromArgb(255, 128, 0),
								Color.FromArgb(255, 255, 0),
								Color.FromArgb(0, 255, 0),
								Color.FromArgb(0, 255, 128),
								Color.FromArgb(0, 255, 255),
								Color.FromArgb(0, 128, 255),
								Color.FromArgb(0, 0, 255),
								Color.FromArgb(0, 0, 255)
							};
							int num2 = array2.Length;
							float[] array3 = new float[num2];
							for (int i = 0; i < num2; i++)
							{
								array3[i] = (float)i / ((float)num2 - 1f);
							}
							ColorBlend interpolationColors = new ColorBlend
							{
								Colors = array2,
								Positions = array3
							};
							linearGradientBrush.InterpolationColors = interpolationColors;
							text3 = text3.Replace("[RGB]", "");
							e.Graphics.DrawString(text3, font3, linearGradientBrush, e.Bounds, format);
							return;
						}
					}
				}
				if (botCommand is CmdBlank2 && text3.StartsWith("["))
				{
					try
					{
						string[] array4 = text3.Replace("[", "").Split(new char[]
						{
							']'
						})[0].Split(new char[]
						{
							','
						});
						SolidBrush brush3 = new SolidBrush(Color.FromArgb(int.Parse(array4[0]), int.Parse(array4[1]), int.Parse(array4[2])));
						text3 = Regex.Replace(text3, "\\[.*?\\]", "");
						if (text3.Contains("(TROLL)"))
						{
							e.Graphics.DrawString(text3.Replace("(TROLL)", ""), e.Font, brush3, e.Bounds, StringFormat.GenericDefault);
						}
						else
						{
							e.Graphics.DrawString(text3, font2, brush3, e.Bounds, format);
						}
						return;
					}
					catch
					{
						return;
					}
				}
				if (text3.Contains("(TROLL)"))
				{
					e.Graphics.DrawString(text3.Replace("(TROLL)", ""), e.Font, new SolidBrush(Color.White), e.Bounds, StringFormat.GenericDefault);
				}
				return;
			}
			if (!source.Contains(text))
			{
				Region region = this.DrawString(e.Graphics, "[" + e.Index.ToString() + "] ", font, brush2, layoutRectangle, StringFormat.GenericDefault);
				layoutRectangle = new RectangleF(layoutRectangle.X + region.GetBounds(e.Graphics).Width + 3f, layoutRectangle.Y, layoutRectangle.Width, layoutRectangle.Height);
			}
			if (this.GetBoolCentered(text))
			{
				e.Graphics.DrawString(this.lstCommands.Items[e.Index].ToString(), font, brush, e.Bounds, format);
				return;
			}
			this.DrawString(e.Graphics, this.lstCommands.Items[e.Index].ToString(), font, brush, layoutRectangle, StringFormat.GenericDefault);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00017640 File Offset: 0x00015840
		private int GetColor(string name)
		{
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			string text = SystemColors.WindowText.ToArgb().ToString("X");
			return int.Parse(config.Get(name + "Color") ?? text, NumberStyles.HexNumber);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000176A0 File Offset: 0x000158A0
		private bool GetBoolCentered(string name)
		{
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			return bool.Parse(config.Get(name + "Centered") ?? "false");
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000176E4 File Offset: 0x000158E4
		private Region DrawString(Graphics g, string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format)
		{
			format.SetMeasurableCharacterRanges(new CharacterRange[]
			{
				new CharacterRange(0, s.Length)
			});
			format.Alignment = StringAlignment.Near;
			g.DrawString(s, font, brush, layoutRectangle, format);
			return g.MeasureCharacterRanges(s, font, layoutRectangle, format)[0];
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00017738 File Offset: 0x00015938
		private Region DrawRTLString(Graphics g, string s, Font font, Brush brush, RectangleF layoutRectangle)
		{
			StringFormat stringFormat = new StringFormat
			{
				Alignment = StringAlignment.Near,
				FormatFlags = StringFormatFlags.DirectionRightToLeft
			};
			stringFormat.SetMeasurableCharacterRanges(new CharacterRange[]
			{
				new CharacterRange(0, s.Length)
			});
			Region region = g.MeasureCharacterRanges(s, font, layoutRectangle, stringFormat)[0];
			layoutRectangle = new RectangleF(layoutRectangle.Width, layoutRectangle.Y, region.GetBounds(g).Width, layoutRectangle.Height);
			this.DrawString(g, s, font, brush, layoutRectangle, stringFormat);
			return region;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002959 File Offset: 0x00000B59
		private void multilineToggleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MultiMode();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002961 File Offset: 0x00000B61
		private void toggleTabpagesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TogglePages();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002969 File Offset: 0x00000B69
		private void commandColorsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Root.Instance.ShowForm(CommandColorForm.Instance);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000177C4 File Offset: 0x000159C4
		private void btnChangeCmd_Click(object sender, EventArgs e)
		{
			string name = ((Button)sender).Name;
			IBotCommand cmd;
			if (name == "btnChangeGuildCmd")
			{
				cmd = new CmdChange
				{
					Guild = true,
					Text = this.txtGuild.Text
				};
			}
			else
			{
				cmd = new CmdChange
				{
					Guild = false,
					Text = this.txtUsername.Text
				};
			}
			this.AddCommand(cmd, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000297A File Offset: 0x00000B7A
		private void chkAntiAfk_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.AFK2 = this.chkAntiAfk.Checked;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000298C File Offset: 0x00000B8C
		private void treeBots_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000029A7 File Offset: 0x00000BA7
		private void chkChangeRoomTag_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.HideRoom = this.chkChangeRoomTag.Checked;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000029B9 File Offset: 0x00000BB9
		private void chkChangeChat_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.ChangeChat = this.chkChangeChat.Checked;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00017844 File Offset: 0x00015A44
		private void chkSetJoinLevel_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkSetJoinLevel.Checked)
			{
				OptionsManager.SetLevelOnJoin = new int?((int)this.numSetLevel.Value);
				return;
			}
			OptionsManager.SetLevelOnJoin = null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000029CB File Offset: 0x00000BCB
		private void btnClientPacket_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdPacket
			{
				Packet = this.txtPacket.Text,
				Client = true
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002A02 File Offset: 0x00000C02
		private void chkHideYulgarPlayers_CheckedChanged(object sender, EventArgs e)
		{
			OptionsManager.HideYulgar = this.chkHideYulgarPlayers.Checked;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00017888 File Offset: 0x00015A88
		private void btnSetInt_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdInt
			{
				Int = this.txtSetInt.Text,
				Value = (int)this.numSetInt.Value,
				type = CmdInt.Types.Set
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000178E0 File Offset: 0x00015AE0
		private void btnIncreaseInt_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdInt
			{
				Int = this.txtSetInt.Text,
				Value = (int)this.numSetInt.Value,
				type = CmdInt.Types.Upper
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00017938 File Offset: 0x00015B38
		private void btnDecreaseInt_Click(object sender, EventArgs e)
		{
			this.AddCommand(new CmdInt
			{
				Int = this.txtSetInt.Text,
				Value = (int)this.numSetInt.Value,
				type = CmdInt.Types.Lower
			}, (Control.ModifierKeys & Keys.Control) == Keys.Control);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002A14 File Offset: 0x00000C14
		private void lstCommands_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		// Token: 0x04000011 RID: 17
		private IBotEngine _activeBotEngine = new Bot();

		// Token: 0x04000012 RID: 18
		private List<StatementCommand> _statementCommands;

		// Token: 0x04000013 RID: 19
		private Dictionary<string, string> _defaultControlText;

		// Token: 0x04000014 RID: 20
		private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
		{
			DefaultValueHandling = DefaultValueHandling.Ignore,
			NullValueHandling = NullValueHandling.Ignore,
			TypeNameHandling = TypeNameHandling.All
		};

		// Token: 0x04000016 RID: 22
		private Panel[] _panels;

		// Token: 0x0400001C RID: 28
		public static LogForm Log = new LogForm();

		// Token: 0x0400001D RID: 29
		private string _customName;

		// Token: 0x0400001E RID: 30
		private string _customGuild;
	}
}
