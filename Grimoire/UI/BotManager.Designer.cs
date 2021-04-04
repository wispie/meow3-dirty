namespace Grimoire.UI
{
	// Token: 0x02000011 RID: 17
	public partial class BotManager : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009D RID: 157 RVA: 0x000025D4 File Offset: 0x000007D4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000C280 File Offset: 0x0000A480
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.BotManager));
			this.lstCommands = new global::System.Windows.Forms.ListBox();
			this.lstBoosts = new global::System.Windows.Forms.ListBox();
			this.lstDrops = new global::System.Windows.Forms.ListBox();
			this.lstItems = new global::System.Windows.Forms.ListBox();
			this.lstQuests = new global::System.Windows.Forms.ListBox();
			this.lstSkills = new global::System.Windows.Forms.ListBox();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabCombat = new global::System.Windows.Forms.TabPage();
			this.pnlCombat = new global::System.Windows.Forms.Panel();
			this.btnUseSkillSet = new global::System.Windows.Forms.Button();
			this.btnAddSkillSet = new global::System.Windows.Forms.Button();
			this.txtSkillSet = new global::System.Windows.Forms.TextBox();
			this.chkSafeMp = new global::System.Windows.Forms.CheckBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.btnRest = new global::System.Windows.Forms.Button();
			this.btnRestF = new global::System.Windows.Forms.Button();
			this.chkSkillCD = new global::System.Windows.Forms.CheckBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.btnAttack = new global::System.Windows.Forms.Button();
			this.btnKill = new global::System.Windows.Forms.Button();
			this.label13 = new global::System.Windows.Forms.Label();
			this.chkExistQuest = new global::System.Windows.Forms.CheckBox();
			this.numRestMP = new global::System.Windows.Forms.NumericUpDown();
			this.chkMP = new global::System.Windows.Forms.CheckBox();
			this.numRest = new global::System.Windows.Forms.NumericUpDown();
			this.chkHP = new global::System.Windows.Forms.CheckBox();
			this.chkPacket = new global::System.Windows.Forms.CheckBox();
			this.numSkillD = new global::System.Windows.Forms.NumericUpDown();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numSafe = new global::System.Windows.Forms.NumericUpDown();
			this.btnAddSafe = new global::System.Windows.Forms.Button();
			this.btnSkillCmd = new global::System.Windows.Forms.Button();
			this.btnAddSkill = new global::System.Windows.Forms.Button();
			this.numSkill = new global::System.Windows.Forms.NumericUpDown();
			this.chkExitRest = new global::System.Windows.Forms.CheckBox();
			this.chkAllSkillsCD = new global::System.Windows.Forms.CheckBox();
			this.txtKillFQ = new global::System.Windows.Forms.TextBox();
			this.txtKillFItem = new global::System.Windows.Forms.TextBox();
			this.txtKillFMon = new global::System.Windows.Forms.TextBox();
			this.rbTemp = new global::System.Windows.Forms.RadioButton();
			this.rbItems = new global::System.Windows.Forms.RadioButton();
			this.btnKillF = new global::System.Windows.Forms.Button();
			this.txtMonster = new global::System.Windows.Forms.TextBox();
			this.tabItem = new global::System.Windows.Forms.TabPage();
			this.pnlItem = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.numDropDelay = new global::System.Windows.Forms.NumericUpDown();
			this.chkRejectAll = new global::System.Windows.Forms.CheckBox();
			this.chkPickupAll = new global::System.Windows.Forms.CheckBox();
			this.chkBankOnStop = new global::System.Windows.Forms.CheckBox();
			this.txtShopItem = new global::System.Windows.Forms.TextBox();
			this.numShopId = new global::System.Windows.Forms.NumericUpDown();
			this.label15 = new global::System.Windows.Forms.Label();
			this.btnBuy = new global::System.Windows.Forms.Button();
			this.btnBuyFast = new global::System.Windows.Forms.Button();
			this.btnLoadShop = new global::System.Windows.Forms.Button();
			this.btnBoost = new global::System.Windows.Forms.Button();
			this.cbBoosts = new global::System.Windows.Forms.ComboBox();
			this.numMapItem = new global::System.Windows.Forms.NumericUpDown();
			this.btnMapItem = new global::System.Windows.Forms.Button();
			this.btnSwap = new global::System.Windows.Forms.Button();
			this.txtSwapInv = new global::System.Windows.Forms.TextBox();
			this.txtSwapBank = new global::System.Windows.Forms.TextBox();
			this.chkReject = new global::System.Windows.Forms.CheckBox();
			this.chkPickup = new global::System.Windows.Forms.CheckBox();
			this.btnWhitelist = new global::System.Windows.Forms.Button();
			this.btnBoth = new global::System.Windows.Forms.Button();
			this.txtWhitelist = new global::System.Windows.Forms.TextBox();
			this.btnItem = new global::System.Windows.Forms.Button();
			this.btnUnbanklst = new global::System.Windows.Forms.Button();
			this.txtItem = new global::System.Windows.Forms.TextBox();
			this.cbItemCmds = new global::System.Windows.Forms.ComboBox();
			this.tabMap = new global::System.Windows.Forms.TabPage();
			this.pnlMap = new global::System.Windows.Forms.Panel();
			this.btnCurrBlank = new global::System.Windows.Forms.Button();
			this.btnSetSpawn = new global::System.Windows.Forms.Button();
			this.btnWalkRdm = new global::System.Windows.Forms.Button();
			this.btnYulgar = new global::System.Windows.Forms.Button();
			this.btnWalkCur = new global::System.Windows.Forms.Button();
			this.btnWalk = new global::System.Windows.Forms.Button();
			this.numWalkY = new global::System.Windows.Forms.NumericUpDown();
			this.numWalkX = new global::System.Windows.Forms.NumericUpDown();
			this.button2 = new global::System.Windows.Forms.Button();
			this.btnCellSwap = new global::System.Windows.Forms.Button();
			this.btnJump = new global::System.Windows.Forms.Button();
			this.btnCurrCell = new global::System.Windows.Forms.Button();
			this.txtPad = new global::System.Windows.Forms.TextBox();
			this.txtCell = new global::System.Windows.Forms.TextBox();
			this.btnJoin = new global::System.Windows.Forms.Button();
			this.txtJoinPad = new global::System.Windows.Forms.TextBox();
			this.txtJoinCell = new global::System.Windows.Forms.TextBox();
			this.txtJoin = new global::System.Windows.Forms.TextBox();
			this.tabQuest = new global::System.Windows.Forms.TabPage();
			this.pnlQuest = new global::System.Windows.Forms.Panel();
			this.label14 = new global::System.Windows.Forms.Label();
			this.numEnsureTries = new global::System.Windows.Forms.NumericUpDown();
			this.chkEnsureComplete = new global::System.Windows.Forms.CheckBox();
			this.btnQuestAccept = new global::System.Windows.Forms.Button();
			this.btnQuestComplete = new global::System.Windows.Forms.Button();
			this.btnQuestAdd = new global::System.Windows.Forms.Button();
			this.numQuestItem = new global::System.Windows.Forms.NumericUpDown();
			this.chkQuestItem = new global::System.Windows.Forms.CheckBox();
			this.numQuestID = new global::System.Windows.Forms.NumericUpDown();
			this.label4 = new global::System.Windows.Forms.Label();
			this.tabMisc = new global::System.Windows.Forms.TabPage();
			this.pnlMisc = new global::System.Windows.Forms.Panel();
			this.label19 = new global::System.Windows.Forms.Label();
			this.btnDecreaseInt = new global::System.Windows.Forms.Button();
			this.btnIncreaseInt = new global::System.Windows.Forms.Button();
			this.numSetInt = new global::System.Windows.Forms.NumericUpDown();
			this.txtSetInt = new global::System.Windows.Forms.TextBox();
			this.btnSetInt = new global::System.Windows.Forms.Button();
			this.label18 = new global::System.Windows.Forms.Label();
			this.btnGoDownIndex = new global::System.Windows.Forms.Button();
			this.btnGoUpIndex = new global::System.Windows.Forms.Button();
			this.btnGotoIndex = new global::System.Windows.Forms.Button();
			this.numIndexCmd = new global::System.Windows.Forms.NumericUpDown();
			this.btnBlank = new global::System.Windows.Forms.Button();
			this.btnProvokeOff = new global::System.Windows.Forms.Button();
			this.btnProvokeOn = new global::System.Windows.Forms.Button();
			this.btnProvoke = new global::System.Windows.Forms.Button();
			this.labelProvoke = new global::System.Windows.Forms.Label();
			this.chkRestartDeath = new global::System.Windows.Forms.CheckBox();
			this.chkMerge = new global::System.Windows.Forms.CheckBox();
			this.btnLogout = new global::System.Windows.Forms.Button();
			this.txtLabel = new global::System.Windows.Forms.TextBox();
			this.btnGotoLabel = new global::System.Windows.Forms.Button();
			this.btnAddLabel = new global::System.Windows.Forms.Button();
			this.txtDescription = new global::System.Windows.Forms.TextBox();
			this.txtAuthor = new global::System.Windows.Forms.TextBox();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.btnBeep = new global::System.Windows.Forms.Button();
			this.numBeepTimes = new global::System.Windows.Forms.NumericUpDown();
			this.btnDelay = new global::System.Windows.Forms.Button();
			this.numDelay = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			this.numBotDelay = new global::System.Windows.Forms.NumericUpDown();
			this.btnBotDelay = new global::System.Windows.Forms.Button();
			this.txtPlayer = new global::System.Windows.Forms.TextBox();
			this.btnGoto = new global::System.Windows.Forms.Button();
			this.btnLoad = new global::System.Windows.Forms.Button();
			this.btnRestart = new global::System.Windows.Forms.Button();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.btnLoadCmd = new global::System.Windows.Forms.Button();
			this.chkSkip = new global::System.Windows.Forms.CheckBox();
			this.btnStatementAdd = new global::System.Windows.Forms.Button();
			this.txtStatement2 = new global::System.Windows.Forms.TextBox();
			this.txtStatement1 = new global::System.Windows.Forms.TextBox();
			this.cbStatement = new global::System.Windows.Forms.ComboBox();
			this.cbCategories = new global::System.Windows.Forms.ComboBox();
			this.txtPacket = new global::System.Windows.Forms.TextBox();
			this.btnClientPacket = new global::System.Windows.Forms.Button();
			this.btnPacket = new global::System.Windows.Forms.Button();
			this.tabOptions = new global::System.Windows.Forms.TabPage();
			this.pnlOptions = new global::System.Windows.Forms.Panel();
			this.chkBuff = new global::System.Windows.Forms.CheckBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.numOptionsTimer = new global::System.Windows.Forms.NumericUpDown();
			this.label5 = new global::System.Windows.Forms.Label();
			this.chkUntarget = new global::System.Windows.Forms.CheckBox();
			this.lstLogText = new global::System.Windows.Forms.ListBox();
			this.btnLogDebug = new global::System.Windows.Forms.Button();
			this.btnLog = new global::System.Windows.Forms.Button();
			this.txtLog = new global::System.Windows.Forms.TextBox();
			this.chkEnableSettings = new global::System.Windows.Forms.CheckBox();
			this.chkDisableAnims = new global::System.Windows.Forms.CheckBox();
			this.txtSoundItem = new global::System.Windows.Forms.TextBox();
			this.btnSoundAdd = new global::System.Windows.Forms.Button();
			this.btnSoundDelete = new global::System.Windows.Forms.Button();
			this.btnSoundTest = new global::System.Windows.Forms.Button();
			this.lstSoundItems = new global::System.Windows.Forms.ListBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.numWalkSpeed = new global::System.Windows.Forms.NumericUpDown();
			this.label8 = new global::System.Windows.Forms.Label();
			this.chkSkipCutscenes = new global::System.Windows.Forms.CheckBox();
			this.chkHidePlayers = new global::System.Windows.Forms.CheckBox();
			this.chkLag = new global::System.Windows.Forms.CheckBox();
			this.chkMagnet = new global::System.Windows.Forms.CheckBox();
			this.chkProvoke = new global::System.Windows.Forms.CheckBox();
			this.chkInfiniteRange = new global::System.Windows.Forms.CheckBox();
			this.grpLogin = new global::System.Windows.Forms.GroupBox();
			this.chkAFK = new global::System.Windows.Forms.CheckBox();
			this.cbServers = new global::System.Windows.Forms.ComboBox();
			this.chkRelogRetry = new global::System.Windows.Forms.CheckBox();
			this.chkRelog = new global::System.Windows.Forms.CheckBox();
			this.numRelogDelay = new global::System.Windows.Forms.NumericUpDown();
			this.label7 = new global::System.Windows.Forms.Label();
			this.chkGender = new global::System.Windows.Forms.CheckBox();
			this.tabOptions2 = new global::System.Windows.Forms.TabPage();
			this.numSetLevel = new global::System.Windows.Forms.NumericUpDown();
			this.chkChangeRoomTag = new global::System.Windows.Forms.CheckBox();
			this.chkChangeChat = new global::System.Windows.Forms.CheckBox();
			this.chkSetJoinLevel = new global::System.Windows.Forms.CheckBox();
			this.chkHideYulgarPlayers = new global::System.Windows.Forms.CheckBox();
			this.chkAntiAfk = new global::System.Windows.Forms.CheckBox();
			this.grpAccessLevel = new global::System.Windows.Forms.GroupBox();
			this.chkToggleMute = new global::System.Windows.Forms.CheckBox();
			this.btnSetMem = new global::System.Windows.Forms.Button();
			this.btnSetModerator = new global::System.Windows.Forms.Button();
			this.btnSetNonMem = new global::System.Windows.Forms.Button();
			this.grpAlignment = new global::System.Windows.Forms.GroupBox();
			this.btnSetChaos = new global::System.Windows.Forms.Button();
			this.btnSetUndecided = new global::System.Windows.Forms.Button();
			this.btnSetGood = new global::System.Windows.Forms.Button();
			this.btnSetEvil = new global::System.Windows.Forms.Button();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.btnChangeNameCmd = new global::System.Windows.Forms.Button();
			this.btnchangeName = new global::System.Windows.Forms.Button();
			this.btnChangeGuildCmd = new global::System.Windows.Forms.Button();
			this.btnchangeGuild = new global::System.Windows.Forms.Button();
			this.txtGuild = new global::System.Windows.Forms.TextBox();
			this.tabBots = new global::System.Windows.Forms.TabPage();
			this.pnlSaved = new global::System.Windows.Forms.Panel();
			this.lblBoosts = new global::System.Windows.Forms.Label();
			this.lblDrops = new global::System.Windows.Forms.Label();
			this.lblQuests = new global::System.Windows.Forms.Label();
			this.lblSkills = new global::System.Windows.Forms.Label();
			this.lblCommands = new global::System.Windows.Forms.Label();
			this.lblItems = new global::System.Windows.Forms.Label();
			this.txtSavedDesc = new global::System.Windows.Forms.TextBox();
			this.txtSavedAuthor = new global::System.Windows.Forms.TextBox();
			this.lblBots = new global::System.Windows.Forms.Label();
			this.treeBots = new global::System.Windows.Forms.TreeView();
			this.txtSavedAdd = new global::System.Windows.Forms.TextBox();
			this.btnSavedAdd = new global::System.Windows.Forms.Button();
			this.txtSaved = new global::System.Windows.Forms.TextBox();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.btnDown = new global::System.Windows.Forms.Button();
			this.cbLists = new global::System.Windows.Forms.ComboBox();
			this.chkAll = new global::System.Windows.Forms.CheckBox();
			this.btnClear = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.btnUp = new global::System.Windows.Forms.Button();
			this.btnRemove = new global::System.Windows.Forms.Button();
			this.btnBotStop = new global::System.Windows.Forms.Button();
			this.btnBotStart = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.splitContainer2 = new global::System.Windows.Forms.SplitContainer();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.chkBuffup = new global::System.Windows.Forms.CheckBox();
			this.BotManagerMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.changeFontsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.multilineToggleToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toggleTabpagesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.commandColorsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1.SuspendLayout();
			this.tabCombat.SuspendLayout();
			this.pnlCombat.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numRestMP).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numRest).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numSkillD).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numSafe).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numSkill).BeginInit();
			this.tabItem.SuspendLayout();
			this.pnlItem.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numDropDelay).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numShopId).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numMapItem).BeginInit();
			this.tabMap.SuspendLayout();
			this.pnlMap.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numWalkY).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numWalkX).BeginInit();
			this.tabQuest.SuspendLayout();
			this.pnlQuest.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numEnsureTries).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numQuestItem).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numQuestID).BeginInit();
			this.tabMisc.SuspendLayout();
			this.pnlMisc.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numSetInt).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numIndexCmd).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBeepTimes).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numDelay).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBotDelay).BeginInit();
			this.tabOptions.SuspendLayout();
			this.pnlOptions.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numOptionsTimer).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numWalkSpeed).BeginInit();
			this.grpLogin.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numRelogDelay).BeginInit();
			this.tabOptions2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numSetLevel).BeginInit();
			this.grpAccessLevel.SuspendLayout();
			this.grpAlignment.SuspendLayout();
			this.tabBots.SuspendLayout();
			this.pnlSaved.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.BotManagerMenuStrip.SuspendLayout();
			base.SuspendLayout();
			this.lstCommands.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lstCommands.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.lstCommands.FormattingEnabled = true;
			this.lstCommands.HorizontalScrollbar = true;
			this.lstCommands.IntegralHeight = false;
			this.lstCommands.ItemHeight = 15;
			this.lstCommands.Location = new global::System.Drawing.Point(0, 0);
			this.lstCommands.Name = "lstCommands";
			this.lstCommands.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.lstCommands.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstCommands.Size = new global::System.Drawing.Size(238, 251);
			this.lstCommands.TabIndex = 1;
			this.lstCommands.Click += new global::System.EventHandler(this.lstCommands_Click);
			this.lstCommands.DrawItem += new global::System.Windows.Forms.DrawItemEventHandler(this.lstCommands_DrawItem);
			this.lstCommands.DoubleClick += new global::System.EventHandler(this.lstCommands_DoubleClick);
			this.lstCommands.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.lstBoxs_KeyPress);
			this.lstCommands.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.lstCommands_KeyPress);
			this.lstCommands.MouseEnter += new global::System.EventHandler(this.lstCommands_MouseEnter);
			this.lstCommands.MouseLeave += new global::System.EventHandler(this.lstCommands_MouseLeave);
			this.lstBoosts.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lstBoosts.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.lstBoosts.FormattingEnabled = true;
			this.lstBoosts.HorizontalScrollbar = true;
			this.lstBoosts.Location = new global::System.Drawing.Point(0, 0);
			this.lstBoosts.Name = "lstBoosts";
			this.lstBoosts.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstBoosts.Size = new global::System.Drawing.Size(238, 251);
			this.lstBoosts.TabIndex = 25;
			this.lstBoosts.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.lstBoxs_KeyPress);
			this.lstDrops.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lstDrops.FormattingEnabled = true;
			this.lstDrops.HorizontalScrollbar = true;
			this.lstDrops.Location = new global::System.Drawing.Point(0, 0);
			this.lstDrops.Name = "lstDrops";
			this.lstDrops.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstDrops.Size = new global::System.Drawing.Size(238, 251);
			this.lstDrops.TabIndex = 26;
			this.lstDrops.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.lstBoxs_KeyPress);
			this.lstItems.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lstItems.FormattingEnabled = true;
			this.lstItems.HorizontalScrollbar = true;
			this.lstItems.Location = new global::System.Drawing.Point(0, 0);
			this.lstItems.Name = "lstItems";
			this.lstItems.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstItems.Size = new global::System.Drawing.Size(238, 251);
			this.lstItems.TabIndex = 145;
			this.lstItems.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.lstBoxs_KeyPress);
			this.lstQuests.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lstQuests.FormattingEnabled = true;
			this.lstQuests.HorizontalScrollbar = true;
			this.lstQuests.Location = new global::System.Drawing.Point(0, 0);
			this.lstQuests.Name = "lstQuests";
			this.lstQuests.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstQuests.Size = new global::System.Drawing.Size(238, 251);
			this.lstQuests.TabIndex = 27;
			this.lstQuests.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.lstBoxs_KeyPress);
			this.lstSkills.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lstSkills.FormattingEnabled = true;
			this.lstSkills.HorizontalScrollbar = true;
			this.lstSkills.Location = new global::System.Drawing.Point(0, 0);
			this.lstSkills.Name = "lstSkills";
			this.lstSkills.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstSkills.Size = new global::System.Drawing.Size(238, 251);
			this.lstSkills.TabIndex = 28;
			this.lstSkills.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.lstBoxs_KeyPress);
			this.tabControl1.Controls.Add(this.tabCombat);
			this.tabControl1.Controls.Add(this.tabItem);
			this.tabControl1.Controls.Add(this.tabMap);
			this.tabControl1.Controls.Add(this.tabQuest);
			this.tabControl1.Controls.Add(this.tabMisc);
			this.tabControl1.Controls.Add(this.tabOptions);
			this.tabControl1.Controls.Add(this.tabOptions2);
			this.tabControl1.Controls.Add(this.tabBots);
			this.tabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(452, 325);
			this.tabControl1.TabIndex = 146;
			this.tabControl1.Selected += new global::System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
			this.tabCombat.Controls.Add(this.pnlCombat);
			this.tabCombat.Location = new global::System.Drawing.Point(4, 22);
			this.tabCombat.Name = "tabCombat";
			this.tabCombat.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabCombat.Size = new global::System.Drawing.Size(444, 299);
			this.tabCombat.TabIndex = 0;
			this.tabCombat.Text = "Combat";
			this.tabCombat.UseVisualStyleBackColor = true;
			this.pnlCombat.Controls.Add(this.btnUseSkillSet);
			this.pnlCombat.Controls.Add(this.btnAddSkillSet);
			this.pnlCombat.Controls.Add(this.txtSkillSet);
			this.pnlCombat.Controls.Add(this.chkSafeMp);
			this.pnlCombat.Controls.Add(this.label17);
			this.pnlCombat.Controls.Add(this.label16);
			this.pnlCombat.Controls.Add(this.btnRest);
			this.pnlCombat.Controls.Add(this.btnRestF);
			this.pnlCombat.Controls.Add(this.chkSkillCD);
			this.pnlCombat.Controls.Add(this.label12);
			this.pnlCombat.Controls.Add(this.label11);
			this.pnlCombat.Controls.Add(this.label10);
			this.pnlCombat.Controls.Add(this.btnAttack);
			this.pnlCombat.Controls.Add(this.btnKill);
			this.pnlCombat.Controls.Add(this.label13);
			this.pnlCombat.Controls.Add(this.chkExistQuest);
			this.pnlCombat.Controls.Add(this.numRestMP);
			this.pnlCombat.Controls.Add(this.chkMP);
			this.pnlCombat.Controls.Add(this.numRest);
			this.pnlCombat.Controls.Add(this.chkHP);
			this.pnlCombat.Controls.Add(this.chkPacket);
			this.pnlCombat.Controls.Add(this.numSkillD);
			this.pnlCombat.Controls.Add(this.label2);
			this.pnlCombat.Controls.Add(this.numSafe);
			this.pnlCombat.Controls.Add(this.btnAddSafe);
			this.pnlCombat.Controls.Add(this.btnSkillCmd);
			this.pnlCombat.Controls.Add(this.btnAddSkill);
			this.pnlCombat.Controls.Add(this.numSkill);
			this.pnlCombat.Controls.Add(this.chkExitRest);
			this.pnlCombat.Controls.Add(this.chkAllSkillsCD);
			this.pnlCombat.Controls.Add(this.txtKillFQ);
			this.pnlCombat.Controls.Add(this.txtKillFItem);
			this.pnlCombat.Controls.Add(this.txtKillFMon);
			this.pnlCombat.Controls.Add(this.rbTemp);
			this.pnlCombat.Controls.Add(this.rbItems);
			this.pnlCombat.Controls.Add(this.btnKillF);
			this.pnlCombat.Controls.Add(this.txtMonster);
			this.pnlCombat.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlCombat.Location = new global::System.Drawing.Point(3, 3);
			this.pnlCombat.Name = "pnlCombat";
			this.pnlCombat.Size = new global::System.Drawing.Size(438, 293);
			this.pnlCombat.TabIndex = 103;
			this.btnUseSkillSet.Location = new global::System.Drawing.Point(220, 53);
			this.btnUseSkillSet.Name = "btnUseSkillSet";
			this.btnUseSkillSet.Size = new global::System.Drawing.Size(115, 22);
			this.btnUseSkillSet.TabIndex = 65;
			this.btnUseSkillSet.Text = "Use Skill Set";
			this.btnUseSkillSet.UseVisualStyleBackColor = true;
			this.btnUseSkillSet.Click += new global::System.EventHandler(this.btnUseSkillSet_Click);
			this.btnAddSkillSet.Location = new global::System.Drawing.Point(220, 29);
			this.btnAddSkillSet.Name = "btnAddSkillSet";
			this.btnAddSkillSet.Size = new global::System.Drawing.Size(115, 22);
			this.btnAddSkillSet.TabIndex = 64;
			this.btnAddSkillSet.Text = "Add Skill Set";
			this.btnAddSkillSet.UseVisualStyleBackColor = true;
			this.btnAddSkillSet.Click += new global::System.EventHandler(this.btnAddSkillSet_Click);
			this.txtSkillSet.Location = new global::System.Drawing.Point(220, 7);
			this.txtSkillSet.Name = "txtSkillSet";
			this.txtSkillSet.Size = new global::System.Drawing.Size(115, 20);
			this.txtSkillSet.TabIndex = 63;
			this.txtSkillSet.Text = "Skill Set Name";
			this.txtSkillSet.Click += new global::System.EventHandler(this.TextboxEnter);
			this.txtSkillSet.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtSkillSet.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.chkSafeMp.AutoSize = true;
			this.chkSafeMp.Location = new global::System.Drawing.Point(170, 84);
			this.chkSafeMp.Name = "chkSafeMp";
			this.chkSafeMp.Size = new global::System.Drawing.Size(42, 17);
			this.chkSafeMp.TabIndex = 58;
			this.chkSafeMp.Text = "MP";
			this.chkSafeMp.UseVisualStyleBackColor = true;
			this.label17.AutoSize = true;
			this.label17.Location = new global::System.Drawing.Point(137, 85);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(34, 13);
			this.label17.TabIndex = 62;
			this.label17.Text = "HP or";
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(137, 101);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(59, 13);
			this.label16.TabIndex = 61;
			this.label16.Text = "is less than";
			this.btnRest.Location = new global::System.Drawing.Point(220, 101);
			this.btnRest.Name = "btnRest";
			this.btnRest.Size = new global::System.Drawing.Size(44, 22);
			this.btnRest.TabIndex = 43;
			this.btnRest.Text = "Rest";
			this.btnRest.UseVisualStyleBackColor = true;
			this.btnRest.Click += new global::System.EventHandler(this.btnRest_Click);
			this.btnRestF.Location = new global::System.Drawing.Point(264, 101);
			this.btnRestF.Name = "btnRestF";
			this.btnRestF.Size = new global::System.Drawing.Size(71, 22);
			this.btnRestF.TabIndex = 44;
			this.btnRestF.Text = "Rest fully";
			this.btnRestF.UseVisualStyleBackColor = true;
			this.btnRestF.Click += new global::System.EventHandler(this.btnRestF_Click);
			this.chkSkillCD.AutoSize = true;
			this.chkSkillCD.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f);
			this.chkSkillCD.Location = new global::System.Drawing.Point(172, 202);
			this.chkSkillCD.Name = "chkSkillCD";
			this.chkSkillCD.Size = new global::System.Drawing.Size(144, 17);
			this.chkSkillCD.TabIndex = 60;
			this.chkSkillCD.Text = "Wait for skill to cooldown";
			this.chkSkillCD.UseVisualStyleBackColor = true;
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(219, 124);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(37, 13);
			this.label12.TabIndex = 57;
			this.label12.Text = "Rest if";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(320, 156);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(15, 13);
			this.label11.TabIndex = 56;
			this.label11.Text = "%";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(320, 138);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(15, 13);
			this.label10.TabIndex = 55;
			this.label10.Text = "%";
			this.btnAttack.Location = new global::System.Drawing.Point(66, 29);
			this.btnAttack.Name = "btnAttack";
			this.btnAttack.Size = new global::System.Drawing.Size(62, 22);
			this.btnAttack.TabIndex = 54;
			this.btnAttack.Text = "Attack";
			this.btnAttack.UseVisualStyleBackColor = true;
			this.btnAttack.Click += new global::System.EventHandler(this.btnAttack_Click);
			this.btnKill.Location = new global::System.Drawing.Point(4, 29);
			this.btnKill.Name = "btnKill";
			this.btnKill.Size = new global::System.Drawing.Size(62, 22);
			this.btnKill.TabIndex = 54;
			this.btnKill.Text = "Kill";
			this.btnKill.UseVisualStyleBackColor = true;
			this.btnKill.Click += new global::System.EventHandler(this.btnKill_Click);
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(134, 139);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(54, 13);
			this.label13.TabIndex = 53;
			this.label13.Text = "Skill delay";
			this.chkExistQuest.AutoSize = true;
			this.chkExistQuest.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f);
			this.chkExistQuest.Location = new global::System.Drawing.Point(172, 227);
			this.chkExistQuest.Name = "chkExistQuest";
			this.chkExistQuest.Size = new global::System.Drawing.Size(197, 17);
			this.chkExistQuest.TabIndex = 51;
			this.chkExistQuest.Text = "Exit combat before completing quest";
			this.chkExistQuest.UseVisualStyleBackColor = true;
			this.numRestMP.Location = new global::System.Drawing.Point(284, 154);
			this.numRestMP.Name = "numRestMP";
			this.numRestMP.Size = new global::System.Drawing.Size(34, 20);
			this.numRestMP.TabIndex = 50;
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numRestMP;
			int[] array = new int[4];
			array[0] = 60;
			numericUpDown.Value = new decimal(array);
			this.chkMP.AutoSize = true;
			this.chkMP.Location = new global::System.Drawing.Point(222, 157);
			this.chkMP.Name = "chkMP";
			this.chkMP.Size = new global::System.Drawing.Size(57, 17);
			this.chkMP.TabIndex = 49;
			this.chkMP.Text = "MP <=";
			this.chkMP.UseVisualStyleBackColor = true;
			this.numRest.Location = new global::System.Drawing.Point(284, 135);
			this.numRest.Name = "numRest";
			this.numRest.Size = new global::System.Drawing.Size(34, 20);
			this.numRest.TabIndex = 48;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numRest;
			int[] array2 = new int[4];
			array2[0] = 60;
			numericUpDown2.Value = new decimal(array2);
			this.chkHP.AutoSize = true;
			this.chkHP.Location = new global::System.Drawing.Point(222, 140);
			this.chkHP.Name = "chkHP";
			this.chkHP.Size = new global::System.Drawing.Size(56, 17);
			this.chkHP.TabIndex = 47;
			this.chkHP.Text = "HP <=";
			this.chkHP.UseVisualStyleBackColor = true;
			this.chkPacket.AutoSize = true;
			this.chkPacket.Location = new global::System.Drawing.Point(222, 80);
			this.chkPacket.Name = "chkPacket";
			this.chkPacket.Size = new global::System.Drawing.Size(109, 17);
			this.chkPacket.TabIndex = 47;
			this.chkPacket.Text = "Use Skill Packets";
			this.chkPacket.UseVisualStyleBackColor = true;
			this.chkPacket.CheckStateChanged += new global::System.EventHandler(this.chkPacket_CheckChanged);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numSkillD;
			int[] array3 = new int[4];
			array3[0] = 100;
			numericUpDown3.Increment = new decimal(array3);
			this.numSkillD.Location = new global::System.Drawing.Point(135, 153);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numSkillD;
			int[] array4 = new int[4];
			array4[0] = 9000;
			numericUpDown4.Maximum = new decimal(array4);
			this.numSkillD.Name = "numSkillD";
			this.numSkillD.Size = new global::System.Drawing.Size(81, 20);
			this.numSkillD.TabIndex = 45;
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numSkillD;
			int[] array5 = new int[4];
			array5[0] = 500;
			numericUpDown5.Value = new decimal(array5);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(185, 119);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(15, 13);
			this.label2.TabIndex = 42;
			this.label2.Text = "%";
			this.numSafe.Location = new global::System.Drawing.Point(135, 117);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numSafe;
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Minimum = new decimal(array6);
			this.numSafe.Name = "numSafe";
			this.numSafe.Size = new global::System.Drawing.Size(44, 20);
			this.numSafe.TabIndex = 41;
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numSafe;
			int[] array7 = new int[4];
			array7[0] = 100;
			numericUpDown7.Value = new decimal(array7);
			this.btnAddSafe.Location = new global::System.Drawing.Point(135, 54);
			this.btnAddSafe.Name = "btnAddSafe";
			this.btnAddSafe.Size = new global::System.Drawing.Size(81, 22);
			this.btnAddSafe.TabIndex = 39;
			this.btnAddSafe.Text = "Safe skill";
			this.btnAddSafe.UseVisualStyleBackColor = true;
			this.btnAddSafe.Click += new global::System.EventHandler(this.btnAddSafe_Click);
			this.btnSkillCmd.Location = new global::System.Drawing.Point(135, 29);
			this.btnSkillCmd.Name = "btnSkillCmd";
			this.btnSkillCmd.Size = new global::System.Drawing.Size(81, 21);
			this.btnSkillCmd.TabIndex = 38;
			this.btnSkillCmd.Text = "Add (cmd)";
			this.btnSkillCmd.UseVisualStyleBackColor = true;
			this.btnSkillCmd.Click += new global::System.EventHandler(this.btnAddSkillCmd_Click);
			this.btnAddSkill.Location = new global::System.Drawing.Point(165, 4);
			this.btnAddSkill.Name = "btnAddSkill";
			this.btnAddSkill.Size = new global::System.Drawing.Size(51, 21);
			this.btnAddSkill.TabIndex = 38;
			this.btnAddSkill.Text = "Add skill";
			this.btnAddSkill.UseVisualStyleBackColor = true;
			this.btnAddSkill.Click += new global::System.EventHandler(this.btnAddSkill_Click);
			this.numSkill.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.numSkill.Location = new global::System.Drawing.Point(135, 5);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numSkill;
			int[] array8 = new int[4];
			array8[0] = 5;
			numericUpDown8.Maximum = new decimal(array8);
			this.numSkill.Name = "numSkill";
			this.numSkill.Size = new global::System.Drawing.Size(29, 20);
			this.numSkill.TabIndex = 37;
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numSkill;
			int[] array9 = new int[4];
			array9[0] = 1;
			numericUpDown9.Value = new decimal(array9);
			this.chkExitRest.AutoSize = true;
			this.chkExitRest.Checked = true;
			this.chkExitRest.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkExitRest.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f);
			this.chkExitRest.Location = new global::System.Drawing.Point(4, 227);
			this.chkExitRest.Name = "chkExitRest";
			this.chkExitRest.Size = new global::System.Drawing.Size(148, 17);
			this.chkExitRest.TabIndex = 36;
			this.chkExitRest.Text = "Exit combat before resting";
			this.chkExitRest.UseVisualStyleBackColor = true;
			this.chkAllSkillsCD.AutoSize = true;
			this.chkAllSkillsCD.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f);
			this.chkAllSkillsCD.Location = new global::System.Drawing.Point(4, 195);
			this.chkAllSkillsCD.Name = "chkAllSkillsCD";
			this.chkAllSkillsCD.Size = new global::System.Drawing.Size(165, 30);
			this.chkAllSkillsCD.TabIndex = 35;
			this.chkAllSkillsCD.Text = "Wait for all skills to cool down\r\nbefore attacking";
			this.chkAllSkillsCD.UseVisualStyleBackColor = true;
			this.txtKillFQ.Location = new global::System.Drawing.Point(4, 153);
			this.txtKillFQ.Name = "txtKillFQ";
			this.txtKillFQ.Size = new global::System.Drawing.Size(124, 20);
			this.txtKillFQ.TabIndex = 34;
			this.txtKillFQ.Text = "Quantity (* = any)";
			this.txtKillFQ.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtKillFQ.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.txtKillFItem.Location = new global::System.Drawing.Point(4, 129);
			this.txtKillFItem.Name = "txtKillFItem";
			this.txtKillFItem.Size = new global::System.Drawing.Size(124, 20);
			this.txtKillFItem.TabIndex = 33;
			this.txtKillFItem.Text = "Item name";
			this.txtKillFItem.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtKillFItem.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.txtKillFMon.Location = new global::System.Drawing.Point(4, 105);
			this.txtKillFMon.Name = "txtKillFMon";
			this.txtKillFMon.Size = new global::System.Drawing.Size(124, 20);
			this.txtKillFMon.TabIndex = 32;
			this.txtKillFMon.Text = "Monster (* = random)";
			this.txtKillFMon.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtKillFMon.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.rbTemp.AutoSize = true;
			this.rbTemp.Location = new global::System.Drawing.Point(52, 81);
			this.rbTemp.Name = "rbTemp";
			this.rbTemp.Size = new global::System.Drawing.Size(79, 17);
			this.rbTemp.TabIndex = 31;
			this.rbTemp.Text = "Temp items";
			this.rbTemp.UseVisualStyleBackColor = true;
			this.rbItems.AutoSize = true;
			this.rbItems.Checked = true;
			this.rbItems.Location = new global::System.Drawing.Point(4, 81);
			this.rbItems.Name = "rbItems";
			this.rbItems.Size = new global::System.Drawing.Size(50, 17);
			this.rbItems.TabIndex = 30;
			this.rbItems.TabStop = true;
			this.rbItems.Text = "Items";
			this.rbItems.UseVisualStyleBackColor = true;
			this.btnKillF.Location = new global::System.Drawing.Point(4, 54);
			this.btnKillF.Name = "btnKillF";
			this.btnKillF.Size = new global::System.Drawing.Size(123, 22);
			this.btnKillF.TabIndex = 29;
			this.btnKillF.Text = "Kill for...";
			this.btnKillF.UseVisualStyleBackColor = true;
			this.btnKillF.Click += new global::System.EventHandler(this.btnKillF_Click);
			this.txtMonster.Location = new global::System.Drawing.Point(4, 4);
			this.txtMonster.Name = "txtMonster";
			this.txtMonster.Size = new global::System.Drawing.Size(124, 20);
			this.txtMonster.TabIndex = 27;
			this.txtMonster.Text = "Monster (*  = random)";
			this.txtMonster.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtMonster.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.tabItem.Controls.Add(this.pnlItem);
			this.tabItem.Location = new global::System.Drawing.Point(4, 22);
			this.tabItem.Name = "tabItem";
			this.tabItem.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabItem.Size = new global::System.Drawing.Size(444, 299);
			this.tabItem.TabIndex = 1;
			this.tabItem.Text = "Item";
			this.tabItem.UseVisualStyleBackColor = true;
			this.pnlItem.Controls.Add(this.label1);
			this.pnlItem.Controls.Add(this.numDropDelay);
			this.pnlItem.Controls.Add(this.chkRejectAll);
			this.pnlItem.Controls.Add(this.chkPickupAll);
			this.pnlItem.Controls.Add(this.chkBankOnStop);
			this.pnlItem.Controls.Add(this.txtShopItem);
			this.pnlItem.Controls.Add(this.numShopId);
			this.pnlItem.Controls.Add(this.label15);
			this.pnlItem.Controls.Add(this.btnBuy);
			this.pnlItem.Controls.Add(this.btnBuyFast);
			this.pnlItem.Controls.Add(this.btnLoadShop);
			this.pnlItem.Controls.Add(this.btnBoost);
			this.pnlItem.Controls.Add(this.cbBoosts);
			this.pnlItem.Controls.Add(this.numMapItem);
			this.pnlItem.Controls.Add(this.btnMapItem);
			this.pnlItem.Controls.Add(this.btnSwap);
			this.pnlItem.Controls.Add(this.txtSwapInv);
			this.pnlItem.Controls.Add(this.txtSwapBank);
			this.pnlItem.Controls.Add(this.chkReject);
			this.pnlItem.Controls.Add(this.chkPickup);
			this.pnlItem.Controls.Add(this.btnWhitelist);
			this.pnlItem.Controls.Add(this.btnBoth);
			this.pnlItem.Controls.Add(this.txtWhitelist);
			this.pnlItem.Controls.Add(this.btnItem);
			this.pnlItem.Controls.Add(this.btnUnbanklst);
			this.pnlItem.Controls.Add(this.txtItem);
			this.pnlItem.Controls.Add(this.cbItemCmds);
			this.pnlItem.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlItem.Location = new global::System.Drawing.Point(3, 3);
			this.pnlItem.Name = "pnlItem";
			this.pnlItem.Size = new global::System.Drawing.Size(438, 293);
			this.pnlItem.TabIndex = 105;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(218, 220);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(60, 13);
			this.label1.TabIndex = 152;
			this.label1.Text = "Drop Delay";
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numDropDelay;
			int[] array10 = new int[4];
			array10[0] = 100;
			numericUpDown10.Increment = new decimal(array10);
			this.numDropDelay.Location = new global::System.Drawing.Point(147, 217);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numDropDelay;
			int[] array11 = new int[4];
			array11[0] = 3000;
			numericUpDown11.Maximum = new decimal(array11);
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numDropDelay;
			int[] array12 = new int[4];
			array12[0] = 500;
			numericUpDown12.Minimum = new decimal(array12);
			this.numDropDelay.Name = "numDropDelay";
			this.numDropDelay.Size = new global::System.Drawing.Size(65, 20);
			this.numDropDelay.TabIndex = 151;
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.numDropDelay;
			int[] array13 = new int[4];
			array13[0] = 1000;
			numericUpDown13.Value = new decimal(array13);
			this.numDropDelay.ValueChanged += new global::System.EventHandler(this.numDropDelay_ValueChanged);
			this.chkRejectAll.AutoSize = true;
			this.chkRejectAll.Enabled = false;
			this.chkRejectAll.Location = new global::System.Drawing.Point(296, 84);
			this.chkRejectAll.Name = "chkRejectAll";
			this.chkRejectAll.Size = new global::System.Drawing.Size(97, 17);
			this.chkRejectAll.TabIndex = 150;
			this.chkRejectAll.Text = "Reject all items";
			this.chkRejectAll.UseVisualStyleBackColor = true;
			this.chkRejectAll.Visible = false;
			this.chkPickupAll.AutoSize = true;
			this.chkPickupAll.Location = new global::System.Drawing.Point(296, 4);
			this.chkPickupAll.Name = "chkPickupAll";
			this.chkPickupAll.Size = new global::System.Drawing.Size(102, 17);
			this.chkPickupAll.TabIndex = 149;
			this.chkPickupAll.Text = "Pick up all items";
			this.chkPickupAll.UseVisualStyleBackColor = true;
			this.chkBankOnStop.AutoSize = true;
			this.chkBankOnStop.Location = new global::System.Drawing.Point(296, 64);
			this.chkBankOnStop.Name = "chkBankOnStop";
			this.chkBankOnStop.Size = new global::System.Drawing.Size(94, 17);
			this.chkBankOnStop.TabIndex = 148;
			this.chkBankOnStop.Text = "Bank on Stop ";
			this.chkBankOnStop.UseVisualStyleBackColor = true;
			this.chkBankOnStop.CheckedChanged += new global::System.EventHandler(this.chkBankOnStop_CheckedChanged);
			this.txtShopItem.Location = new global::System.Drawing.Point(5, 193);
			this.txtShopItem.Name = "txtShopItem";
			this.txtShopItem.Size = new global::System.Drawing.Size(137, 20);
			this.txtShopItem.TabIndex = 41;
			this.txtShopItem.Text = "Shop Item";
			this.txtShopItem.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtShopItem.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.numShopId.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.numShopId.Location = new global::System.Drawing.Point(5, 169);
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.numShopId;
			int[] array14 = new int[4];
			array14[0] = 100000;
			numericUpDown14.Maximum = new decimal(array14);
			global::System.Windows.Forms.NumericUpDown numericUpDown15 = this.numShopId;
			int[] array15 = new int[4];
			array15[0] = 1;
			numericUpDown15.Minimum = new decimal(array15);
			this.numShopId.Name = "numShopId";
			this.numShopId.Size = new global::System.Drawing.Size(65, 20);
			this.numShopId.TabIndex = 40;
			global::System.Windows.Forms.NumericUpDown numericUpDown16 = this.numShopId;
			int[] array16 = new int[4];
			array16[0] = 1;
			numericUpDown16.Value = new decimal(array16);
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(3, 156);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(46, 13);
			this.label15.TabIndex = 39;
			this.label15.Text = "Shop ID";
			this.btnBuy.Location = new global::System.Drawing.Point(4, 215);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.Size = new global::System.Drawing.Size(68, 22);
			this.btnBuy.TabIndex = 38;
			this.btnBuy.Text = "Buy item";
			this.btnBuy.UseVisualStyleBackColor = true;
			this.btnBuy.Click += new global::System.EventHandler(this.btnBuy_Click);
			this.btnBuyFast.Location = new global::System.Drawing.Point(74, 215);
			this.btnBuyFast.Name = "btnBuyFast";
			this.btnBuyFast.Size = new global::System.Drawing.Size(69, 22);
			this.btnBuyFast.TabIndex = 133;
			this.btnBuyFast.Text = "Buy fast";
			this.btnBuyFast.UseVisualStyleBackColor = true;
			this.btnBuyFast.Click += new global::System.EventHandler(this.btnBuyFast_Click);
			this.btnLoadShop.Location = new global::System.Drawing.Point(76, 168);
			this.btnLoadShop.Name = "btnLoadShop";
			this.btnLoadShop.Size = new global::System.Drawing.Size(66, 22);
			this.btnLoadShop.TabIndex = 134;
			this.btnLoadShop.Text = "Load Shop";
			this.btnLoadShop.UseVisualStyleBackColor = true;
			this.btnLoadShop.Click += new global::System.EventHandler(this.btnLoadShop_Click);
			this.btnBoost.Location = new global::System.Drawing.Point(146, 128);
			this.btnBoost.Name = "btnBoost";
			this.btnBoost.Size = new global::System.Drawing.Size(134, 22);
			this.btnBoost.TabIndex = 37;
			this.btnBoost.Text = "Add boost";
			this.btnBoost.UseVisualStyleBackColor = true;
			this.btnBoost.Click += new global::System.EventHandler(this.btnBoost_Click);
			this.cbBoosts.FormattingEnabled = true;
			this.cbBoosts.Location = new global::System.Drawing.Point(147, 104);
			this.cbBoosts.Name = "cbBoosts";
			this.cbBoosts.Size = new global::System.Drawing.Size(132, 21);
			this.cbBoosts.TabIndex = 36;
			this.cbBoosts.Click += new global::System.EventHandler(this.cbBoosts_Click);
			this.numMapItem.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.numMapItem.Location = new global::System.Drawing.Point(148, 170);
			global::System.Windows.Forms.NumericUpDown numericUpDown17 = this.numMapItem;
			int[] array17 = new int[4];
			array17[0] = 100000;
			numericUpDown17.Maximum = new decimal(array17);
			global::System.Windows.Forms.NumericUpDown numericUpDown18 = this.numMapItem;
			int[] array18 = new int[4];
			array18[0] = 1;
			numericUpDown18.Minimum = new decimal(array18);
			this.numMapItem.Name = "numMapItem";
			this.numMapItem.Size = new global::System.Drawing.Size(132, 20);
			this.numMapItem.TabIndex = 30;
			global::System.Windows.Forms.NumericUpDown numericUpDown19 = this.numMapItem;
			int[] array19 = new int[4];
			array19[0] = 1;
			numericUpDown19.Value = new decimal(array19);
			this.btnMapItem.Location = new global::System.Drawing.Point(147, 193);
			this.btnMapItem.Name = "btnMapItem";
			this.btnMapItem.Size = new global::System.Drawing.Size(134, 22);
			this.btnMapItem.TabIndex = 29;
			this.btnMapItem.Text = "Get map item";
			this.btnMapItem.UseVisualStyleBackColor = true;
			this.btnMapItem.Click += new global::System.EventHandler(this.btnMapItem_Click);
			this.btnSwap.Location = new global::System.Drawing.Point(3, 129);
			this.btnSwap.Name = "btnSwap";
			this.btnSwap.Size = new global::System.Drawing.Size(141, 22);
			this.btnSwap.TabIndex = 28;
			this.btnSwap.Text = "Bank swap";
			this.btnSwap.UseVisualStyleBackColor = true;
			this.btnSwap.Click += new global::System.EventHandler(this.btnSwap_Click);
			this.txtSwapInv.Location = new global::System.Drawing.Point(4, 105);
			this.txtSwapInv.Name = "txtSwapInv";
			this.txtSwapInv.Size = new global::System.Drawing.Size(139, 20);
			this.txtSwapInv.TabIndex = 27;
			this.txtSwapInv.Text = "Inventory item name";
			this.txtSwapBank.Location = new global::System.Drawing.Point(4, 80);
			this.txtSwapBank.Name = "txtSwapBank";
			this.txtSwapBank.Size = new global::System.Drawing.Size(139, 20);
			this.txtSwapBank.TabIndex = 26;
			this.txtSwapBank.Text = "Bank item name";
			this.chkReject.AutoSize = true;
			this.chkReject.Location = new global::System.Drawing.Point(296, 44);
			this.chkReject.Name = "chkReject";
			this.chkReject.Size = new global::System.Drawing.Size(130, 17);
			this.chkReject.TabIndex = 25;
			this.chkReject.Text = "Reject non-whitelisted";
			this.chkReject.UseVisualStyleBackColor = true;
			this.chkPickup.AutoSize = true;
			this.chkPickup.Checked = true;
			this.chkPickup.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkPickup.Location = new global::System.Drawing.Point(296, 24);
			this.chkPickup.Name = "chkPickup";
			this.chkPickup.Size = new global::System.Drawing.Size(114, 17);
			this.chkPickup.TabIndex = 24;
			this.chkPickup.Text = "Pick up whitelisted";
			this.chkPickup.UseVisualStyleBackColor = true;
			this.btnWhitelist.Location = new global::System.Drawing.Point(146, 54);
			this.btnWhitelist.Name = "btnWhitelist";
			this.btnWhitelist.Size = new global::System.Drawing.Size(132, 22);
			this.btnWhitelist.TabIndex = 23;
			this.btnWhitelist.Text = "Add to whitelist";
			this.btnWhitelist.UseVisualStyleBackColor = true;
			this.btnWhitelist.Click += new global::System.EventHandler(this.btnWhitelist_Click);
			this.btnBoth.Location = new global::System.Drawing.Point(146, 29);
			this.btnBoth.Name = "btnBoth";
			this.btnBoth.Size = new global::System.Drawing.Size(132, 22);
			this.btnBoth.TabIndex = 23;
			this.btnBoth.Text = "Add to both";
			this.btnBoth.UseVisualStyleBackColor = true;
			this.btnBoth.Click += new global::System.EventHandler(this.btnBoth_Click);
			this.txtWhitelist.Location = new global::System.Drawing.Point(148, 4);
			this.txtWhitelist.Name = "txtWhitelist";
			this.txtWhitelist.Size = new global::System.Drawing.Size(132, 20);
			this.txtWhitelist.TabIndex = 22;
			this.txtWhitelist.Text = "Item name";
			this.txtWhitelist.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtWhitelist.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.btnItem.Location = new global::System.Drawing.Point(3, 54);
			this.btnItem.Name = "btnItem";
			this.btnItem.Size = new global::System.Drawing.Size(141, 22);
			this.btnItem.TabIndex = 21;
			this.btnItem.Text = "Add command";
			this.btnItem.UseVisualStyleBackColor = true;
			this.btnItem.Click += new global::System.EventHandler(this.btnItem_Click);
			this.btnUnbanklst.Location = new global::System.Drawing.Point(146, 79);
			this.btnUnbanklst.Name = "btnUnbanklst";
			this.btnUnbanklst.Size = new global::System.Drawing.Size(132, 22);
			this.btnUnbanklst.TabIndex = 147;
			this.btnUnbanklst.Text = "Unbank";
			this.btnUnbanklst.UseVisualStyleBackColor = true;
			this.btnUnbanklst.Click += new global::System.EventHandler(this.btnUnbanklst_Click);
			this.txtItem.Location = new global::System.Drawing.Point(4, 29);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new global::System.Drawing.Size(139, 20);
			this.txtItem.TabIndex = 20;
			this.txtItem.Text = "Item name";
			this.txtItem.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtItem.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.cbItemCmds.FormattingEnabled = true;
			this.cbItemCmds.Items.AddRange(new object[]
			{
				"Get drop",
				"Sell",
				"Equip",
				"To bank from inv",
				"To inv from bank",
				"Equip Set"
			});
			this.cbItemCmds.Location = new global::System.Drawing.Point(4, 4);
			this.cbItemCmds.Name = "cbItemCmds";
			this.cbItemCmds.Size = new global::System.Drawing.Size(139, 21);
			this.cbItemCmds.TabIndex = 19;
			this.tabMap.Controls.Add(this.pnlMap);
			this.tabMap.Location = new global::System.Drawing.Point(4, 22);
			this.tabMap.Name = "tabMap";
			this.tabMap.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabMap.Size = new global::System.Drawing.Size(444, 299);
			this.tabMap.TabIndex = 2;
			this.tabMap.Text = "Map";
			this.tabMap.UseVisualStyleBackColor = true;
			this.pnlMap.Controls.Add(this.btnCurrBlank);
			this.pnlMap.Controls.Add(this.btnSetSpawn);
			this.pnlMap.Controls.Add(this.btnWalkRdm);
			this.pnlMap.Controls.Add(this.btnYulgar);
			this.pnlMap.Controls.Add(this.btnWalkCur);
			this.pnlMap.Controls.Add(this.btnWalk);
			this.pnlMap.Controls.Add(this.numWalkY);
			this.pnlMap.Controls.Add(this.numWalkX);
			this.pnlMap.Controls.Add(this.button2);
			this.pnlMap.Controls.Add(this.btnCellSwap);
			this.pnlMap.Controls.Add(this.btnJump);
			this.pnlMap.Controls.Add(this.btnCurrCell);
			this.pnlMap.Controls.Add(this.txtPad);
			this.pnlMap.Controls.Add(this.txtCell);
			this.pnlMap.Controls.Add(this.btnJoin);
			this.pnlMap.Controls.Add(this.txtJoinPad);
			this.pnlMap.Controls.Add(this.txtJoinCell);
			this.pnlMap.Controls.Add(this.txtJoin);
			this.pnlMap.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlMap.Location = new global::System.Drawing.Point(3, 3);
			this.pnlMap.Name = "pnlMap";
			this.pnlMap.Size = new global::System.Drawing.Size(438, 293);
			this.pnlMap.TabIndex = 104;
			this.btnCurrBlank.Location = new global::System.Drawing.Point(128, 29);
			this.btnCurrBlank.Name = "btnCurrBlank";
			this.btnCurrBlank.Size = new global::System.Drawing.Size(56, 23);
			this.btnCurrBlank.TabIndex = 143;
			this.btnCurrBlank.Text = "Blank";
			this.btnCurrBlank.UseVisualStyleBackColor = true;
			this.btnCurrBlank.Click += new global::System.EventHandler(this.btnCurrBlank_Click);
			this.btnSetSpawn.Location = new global::System.Drawing.Point(3, 200);
			this.btnSetSpawn.MaximumSize = new global::System.Drawing.Size(114, 22);
			this.btnSetSpawn.MinimumSize = new global::System.Drawing.Size(114, 22);
			this.btnSetSpawn.Name = "btnSetSpawn";
			this.btnSetSpawn.Size = new global::System.Drawing.Size(114, 22);
			this.btnSetSpawn.TabIndex = 142;
			this.btnSetSpawn.Text = "Set Spawnpoint";
			this.btnSetSpawn.UseVisualStyleBackColor = true;
			this.btnSetSpawn.Click += new global::System.EventHandler(this.btnSetSpawn_Click);
			this.btnWalkRdm.Location = new global::System.Drawing.Point(4, 172);
			this.btnWalkRdm.MaximumSize = new global::System.Drawing.Size(114, 22);
			this.btnWalkRdm.MinimumSize = new global::System.Drawing.Size(114, 22);
			this.btnWalkRdm.Name = "btnWalkRdm";
			this.btnWalkRdm.Size = new global::System.Drawing.Size(114, 22);
			this.btnWalkRdm.TabIndex = 142;
			this.btnWalkRdm.Text = "Walk Randomly";
			this.btnWalkRdm.UseVisualStyleBackColor = true;
			this.btnWalkRdm.Click += new global::System.EventHandler(this.btnWalkRdm_Click);
			this.btnYulgar.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btnYulgar.FlatAppearance.BorderSize = 0;
			this.btnYulgar.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnYulgar.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnYulgar.Location = new global::System.Drawing.Point(192, 82);
			this.btnYulgar.Name = "btnYulgar";
			this.btnYulgar.Size = new global::System.Drawing.Size(111, 28);
			this.btnYulgar.TabIndex = 141;
			this.btnYulgar.Text = "Yulgar?";
			this.btnYulgar.UseVisualStyleBackColor = true;
			this.btnYulgar.Click += new global::System.EventHandler(this.btnYulgar_Click);
			this.btnWalkCur.Location = new global::System.Drawing.Point(3, 144);
			this.btnWalkCur.MaximumSize = new global::System.Drawing.Size(114, 22);
			this.btnWalkCur.MinimumSize = new global::System.Drawing.Size(114, 22);
			this.btnWalkCur.Name = "btnWalkCur";
			this.btnWalkCur.Size = new global::System.Drawing.Size(114, 22);
			this.btnWalkCur.TabIndex = 38;
			this.btnWalkCur.Text = "Current position";
			this.btnWalkCur.UseVisualStyleBackColor = true;
			this.btnWalkCur.Click += new global::System.EventHandler(this.btnWalkCur_Click);
			this.btnWalk.Location = new global::System.Drawing.Point(3, 116);
			this.btnWalk.Name = "btnWalk";
			this.btnWalk.Size = new global::System.Drawing.Size(115, 22);
			this.btnWalk.TabIndex = 37;
			this.btnWalk.Text = "Walk to";
			this.btnWalk.UseVisualStyleBackColor = true;
			this.btnWalk.Click += new global::System.EventHandler(this.btnWalk_Click);
			this.numWalkY.Location = new global::System.Drawing.Point(65, 90);
			global::System.Windows.Forms.NumericUpDown numericUpDown20 = this.numWalkY;
			int[] array20 = new int[4];
			array20[0] = 2000;
			numericUpDown20.Maximum = new decimal(array20);
			global::System.Windows.Forms.NumericUpDown numericUpDown21 = this.numWalkY;
			int[] array21 = new int[4];
			array21[0] = 1;
			numericUpDown21.Minimum = new decimal(array21);
			this.numWalkY.Name = "numWalkY";
			this.numWalkY.Size = new global::System.Drawing.Size(52, 20);
			this.numWalkY.TabIndex = 36;
			global::System.Windows.Forms.NumericUpDown numericUpDown22 = this.numWalkY;
			int[] array22 = new int[4];
			array22[0] = 1;
			numericUpDown22.Value = new decimal(array22);
			this.numWalkX.Location = new global::System.Drawing.Point(6, 90);
			global::System.Windows.Forms.NumericUpDown numericUpDown23 = this.numWalkX;
			int[] array23 = new int[4];
			array23[0] = 2000;
			numericUpDown23.Maximum = new decimal(array23);
			global::System.Windows.Forms.NumericUpDown numericUpDown24 = this.numWalkX;
			int[] array24 = new int[4];
			array24[0] = 1;
			numericUpDown24.Minimum = new decimal(array24);
			this.numWalkX.Name = "numWalkX";
			this.numWalkX.Size = new global::System.Drawing.Size(54, 20);
			this.numWalkX.TabIndex = 35;
			global::System.Windows.Forms.NumericUpDown numericUpDown25 = this.numWalkX;
			int[] array25 = new int[4];
			array25[0] = 1;
			numericUpDown25.Value = new decimal(array25);
			this.button2.Location = new global::System.Drawing.Point(144, 4);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(21, 22);
			this.button2.TabIndex = 34;
			this.button2.Text = ">";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.btnCellSwap_Click);
			this.btnCellSwap.Location = new global::System.Drawing.Point(144, 53);
			this.btnCellSwap.Name = "btnCellSwap";
			this.btnCellSwap.Size = new global::System.Drawing.Size(21, 22);
			this.btnCellSwap.TabIndex = 34;
			this.btnCellSwap.Text = "<";
			this.btnCellSwap.UseVisualStyleBackColor = true;
			this.btnCellSwap.Click += new global::System.EventHandler(this.btnCellSwap_Click);
			this.btnJump.AutoSize = true;
			this.btnJump.Location = new global::System.Drawing.Point(192, 53);
			this.btnJump.Name = "btnJump";
			this.btnJump.Size = new global::System.Drawing.Size(111, 23);
			this.btnJump.TabIndex = 33;
			this.btnJump.Text = "Jump";
			this.btnJump.UseVisualStyleBackColor = true;
			this.btnJump.Click += new global::System.EventHandler(this.btnJump_Click);
			this.btnCurrCell.AutoSize = true;
			this.btnCurrCell.Location = new global::System.Drawing.Point(192, 29);
			this.btnCurrCell.Name = "btnCurrCell";
			this.btnCurrCell.Size = new global::System.Drawing.Size(111, 23);
			this.btnCurrCell.TabIndex = 32;
			this.btnCurrCell.Text = "Get current cell";
			this.btnCurrCell.UseVisualStyleBackColor = true;
			this.btnCurrCell.Click += new global::System.EventHandler(this.btnCurrCell_Click);
			this.txtPad.Location = new global::System.Drawing.Point(250, 4);
			this.txtPad.Name = "txtPad";
			this.txtPad.Size = new global::System.Drawing.Size(54, 20);
			this.txtPad.TabIndex = 31;
			this.txtPad.Text = "Pad";
			this.txtPad.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtPad.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.txtCell.Location = new global::System.Drawing.Point(192, 4);
			this.txtCell.Name = "txtCell";
			this.txtCell.Size = new global::System.Drawing.Size(54, 20);
			this.txtCell.TabIndex = 30;
			this.txtCell.Text = "Cell";
			this.txtCell.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtCell.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.btnJoin.Location = new global::System.Drawing.Point(6, 53);
			this.btnJoin.Name = "btnJoin";
			this.btnJoin.Size = new global::System.Drawing.Size(111, 22);
			this.btnJoin.TabIndex = 29;
			this.btnJoin.Text = "Join map";
			this.btnJoin.UseVisualStyleBackColor = true;
			this.btnJoin.Click += new global::System.EventHandler(this.btnJoin_Click);
			this.txtJoinPad.Location = new global::System.Drawing.Point(64, 29);
			this.txtJoinPad.Name = "txtJoinPad";
			this.txtJoinPad.Size = new global::System.Drawing.Size(54, 20);
			this.txtJoinPad.TabIndex = 28;
			this.txtJoinPad.Text = "Spawn";
			this.txtJoinCell.Location = new global::System.Drawing.Point(6, 29);
			this.txtJoinCell.Name = "txtJoinCell";
			this.txtJoinCell.Size = new global::System.Drawing.Size(54, 20);
			this.txtJoinCell.TabIndex = 27;
			this.txtJoinCell.Text = "Enter";
			this.txtJoin.Location = new global::System.Drawing.Point(6, 4);
			this.txtJoin.Name = "txtJoin";
			this.txtJoin.Size = new global::System.Drawing.Size(112, 20);
			this.txtJoin.TabIndex = 26;
			this.txtJoin.Text = "battleon-1e99";
			this.tabQuest.Controls.Add(this.pnlQuest);
			this.tabQuest.Location = new global::System.Drawing.Point(4, 22);
			this.tabQuest.Name = "tabQuest";
			this.tabQuest.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabQuest.Size = new global::System.Drawing.Size(444, 299);
			this.tabQuest.TabIndex = 3;
			this.tabQuest.Text = "Quest";
			this.tabQuest.UseVisualStyleBackColor = true;
			this.pnlQuest.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.pnlQuest.Controls.Add(this.label14);
			this.pnlQuest.Controls.Add(this.numEnsureTries);
			this.pnlQuest.Controls.Add(this.chkEnsureComplete);
			this.pnlQuest.Controls.Add(this.btnQuestAccept);
			this.pnlQuest.Controls.Add(this.btnQuestComplete);
			this.pnlQuest.Controls.Add(this.btnQuestAdd);
			this.pnlQuest.Controls.Add(this.numQuestItem);
			this.pnlQuest.Controls.Add(this.chkQuestItem);
			this.pnlQuest.Controls.Add(this.numQuestID);
			this.pnlQuest.Controls.Add(this.label4);
			this.pnlQuest.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlQuest.Location = new global::System.Drawing.Point(3, 3);
			this.pnlQuest.Name = "pnlQuest";
			this.pnlQuest.Size = new global::System.Drawing.Size(438, 293);
			this.pnlQuest.TabIndex = 106;
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(189, 95);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(30, 13);
			this.label14.TabIndex = 16;
			this.label14.Text = "Tries";
			this.label14.Visible = false;
			this.numEnsureTries.Enabled = false;
			this.numEnsureTries.Location = new global::System.Drawing.Point(143, 92);
			global::System.Windows.Forms.NumericUpDown numericUpDown26 = this.numEnsureTries;
			int[] array26 = new int[4];
			array26[0] = 1;
			numericUpDown26.Minimum = new decimal(array26);
			this.numEnsureTries.Name = "numEnsureTries";
			this.numEnsureTries.Size = new global::System.Drawing.Size(42, 20);
			this.numEnsureTries.TabIndex = 15;
			global::System.Windows.Forms.NumericUpDown numericUpDown27 = this.numEnsureTries;
			int[] array27 = new int[4];
			array27[0] = 20;
			numericUpDown27.Value = new decimal(array27);
			this.numEnsureTries.Visible = false;
			this.chkEnsureComplete.AutoSize = true;
			this.chkEnsureComplete.Location = new global::System.Drawing.Point(143, 75);
			this.chkEnsureComplete.Name = "chkEnsureComplete";
			this.chkEnsureComplete.Size = new global::System.Drawing.Size(59, 17);
			this.chkEnsureComplete.TabIndex = 14;
			this.chkEnsureComplete.Text = "Ensure";
			this.chkEnsureComplete.UseVisualStyleBackColor = true;
			this.chkEnsureComplete.Visible = false;
			this.chkEnsureComplete.CheckedChanged += new global::System.EventHandler(this.chkEnsureComplete_CheckedChanged);
			this.btnQuestAccept.Location = new global::System.Drawing.Point(8, 99);
			this.btnQuestAccept.Name = "btnQuestAccept";
			this.btnQuestAccept.Size = new global::System.Drawing.Size(129, 22);
			this.btnQuestAccept.TabIndex = 13;
			this.btnQuestAccept.Text = "Accept command";
			this.btnQuestAccept.UseVisualStyleBackColor = true;
			this.btnQuestAccept.Click += new global::System.EventHandler(this.btnQuestAccept_Click);
			this.btnQuestComplete.Location = new global::System.Drawing.Point(8, 72);
			this.btnQuestComplete.Name = "btnQuestComplete";
			this.btnQuestComplete.Size = new global::System.Drawing.Size(129, 22);
			this.btnQuestComplete.TabIndex = 12;
			this.btnQuestComplete.Text = "Complete command";
			this.btnQuestComplete.UseVisualStyleBackColor = true;
			this.btnQuestComplete.Click += new global::System.EventHandler(this.btnQuestComplete_Click);
			this.btnQuestAdd.Location = new global::System.Drawing.Point(8, 45);
			this.btnQuestAdd.Name = "btnQuestAdd";
			this.btnQuestAdd.Size = new global::System.Drawing.Size(129, 22);
			this.btnQuestAdd.TabIndex = 11;
			this.btnQuestAdd.Text = "Add to quest list";
			this.btnQuestAdd.UseVisualStyleBackColor = true;
			this.btnQuestAdd.Click += new global::System.EventHandler(this.btnQuestAdd_Click);
			this.numQuestItem.Enabled = false;
			this.numQuestItem.Location = new global::System.Drawing.Point(143, 21);
			global::System.Windows.Forms.NumericUpDown numericUpDown28 = this.numQuestItem;
			int[] array28 = new int[4];
			array28[0] = 100000;
			numericUpDown28.Maximum = new decimal(array28);
			global::System.Windows.Forms.NumericUpDown numericUpDown29 = this.numQuestItem;
			int[] array29 = new int[4];
			array29[0] = 1;
			numericUpDown29.Minimum = new decimal(array29);
			this.numQuestItem.Name = "numQuestItem";
			this.numQuestItem.Size = new global::System.Drawing.Size(76, 20);
			this.numQuestItem.TabIndex = 10;
			global::System.Windows.Forms.NumericUpDown numericUpDown30 = this.numQuestItem;
			int[] array30 = new int[4];
			array30[0] = 1;
			numericUpDown30.Value = new decimal(array30);
			this.chkQuestItem.AutoSize = true;
			this.chkQuestItem.Location = new global::System.Drawing.Point(143, 5);
			this.chkQuestItem.Name = "chkQuestItem";
			this.chkQuestItem.Size = new global::System.Drawing.Size(60, 17);
			this.chkQuestItem.TabIndex = 9;
			this.chkQuestItem.Text = "Item ID";
			this.chkQuestItem.UseVisualStyleBackColor = true;
			this.chkQuestItem.CheckedChanged += new global::System.EventHandler(this.chkQuestItem_CheckedChanged);
			this.numQuestID.Location = new global::System.Drawing.Point(8, 21);
			global::System.Windows.Forms.NumericUpDown numericUpDown31 = this.numQuestID;
			int[] array31 = new int[4];
			array31[0] = 100000;
			numericUpDown31.Maximum = new decimal(array31);
			global::System.Windows.Forms.NumericUpDown numericUpDown32 = this.numQuestID;
			int[] array32 = new int[4];
			array32[0] = 1;
			numericUpDown32.Minimum = new decimal(array32);
			this.numQuestID.Name = "numQuestID";
			this.numQuestID.Size = new global::System.Drawing.Size(129, 20);
			this.numQuestID.TabIndex = 8;
			global::System.Windows.Forms.NumericUpDown numericUpDown33 = this.numQuestID;
			int[] array33 = new int[4];
			array33[0] = 1;
			numericUpDown33.Value = new decimal(array33);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(5, 5);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(49, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Quest ID";
			this.tabMisc.Controls.Add(this.pnlMisc);
			this.tabMisc.Location = new global::System.Drawing.Point(4, 22);
			this.tabMisc.Name = "tabMisc";
			this.tabMisc.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabMisc.Size = new global::System.Drawing.Size(444, 299);
			this.tabMisc.TabIndex = 4;
			this.tabMisc.Text = "Misc";
			this.tabMisc.UseVisualStyleBackColor = true;
			this.pnlMisc.Controls.Add(this.label19);
			this.pnlMisc.Controls.Add(this.btnDecreaseInt);
			this.pnlMisc.Controls.Add(this.btnIncreaseInt);
			this.pnlMisc.Controls.Add(this.numSetInt);
			this.pnlMisc.Controls.Add(this.txtSetInt);
			this.pnlMisc.Controls.Add(this.btnSetInt);
			this.pnlMisc.Controls.Add(this.label18);
			this.pnlMisc.Controls.Add(this.btnGoDownIndex);
			this.pnlMisc.Controls.Add(this.btnGoUpIndex);
			this.pnlMisc.Controls.Add(this.btnGotoIndex);
			this.pnlMisc.Controls.Add(this.numIndexCmd);
			this.pnlMisc.Controls.Add(this.btnBlank);
			this.pnlMisc.Controls.Add(this.btnProvokeOff);
			this.pnlMisc.Controls.Add(this.btnProvokeOn);
			this.pnlMisc.Controls.Add(this.btnProvoke);
			this.pnlMisc.Controls.Add(this.labelProvoke);
			this.pnlMisc.Controls.Add(this.chkRestartDeath);
			this.pnlMisc.Controls.Add(this.chkMerge);
			this.pnlMisc.Controls.Add(this.btnLogout);
			this.pnlMisc.Controls.Add(this.txtLabel);
			this.pnlMisc.Controls.Add(this.btnGotoLabel);
			this.pnlMisc.Controls.Add(this.btnAddLabel);
			this.pnlMisc.Controls.Add(this.txtDescription);
			this.pnlMisc.Controls.Add(this.txtAuthor);
			this.pnlMisc.Controls.Add(this.btnSave);
			this.pnlMisc.Controls.Add(this.btnBeep);
			this.pnlMisc.Controls.Add(this.numBeepTimes);
			this.pnlMisc.Controls.Add(this.btnDelay);
			this.pnlMisc.Controls.Add(this.numDelay);
			this.pnlMisc.Controls.Add(this.label3);
			this.pnlMisc.Controls.Add(this.numBotDelay);
			this.pnlMisc.Controls.Add(this.btnBotDelay);
			this.pnlMisc.Controls.Add(this.txtPlayer);
			this.pnlMisc.Controls.Add(this.btnGoto);
			this.pnlMisc.Controls.Add(this.btnLoad);
			this.pnlMisc.Controls.Add(this.btnRestart);
			this.pnlMisc.Controls.Add(this.btnStop);
			this.pnlMisc.Controls.Add(this.btnLoadCmd);
			this.pnlMisc.Controls.Add(this.chkSkip);
			this.pnlMisc.Controls.Add(this.btnStatementAdd);
			this.pnlMisc.Controls.Add(this.txtStatement2);
			this.pnlMisc.Controls.Add(this.txtStatement1);
			this.pnlMisc.Controls.Add(this.cbStatement);
			this.pnlMisc.Controls.Add(this.cbCategories);
			this.pnlMisc.Controls.Add(this.txtPacket);
			this.pnlMisc.Controls.Add(this.btnClientPacket);
			this.pnlMisc.Controls.Add(this.btnPacket);
			this.pnlMisc.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlMisc.Location = new global::System.Drawing.Point(3, 3);
			this.pnlMisc.Name = "pnlMisc";
			this.pnlMisc.Size = new global::System.Drawing.Size(438, 293);
			this.pnlMisc.TabIndex = 107;
			this.label19.AutoSize = true;
			this.label19.Location = new global::System.Drawing.Point(42, 221);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(98, 13);
			this.label19.TabIndex = 159;
			this.label19.Text = "Temporary Integers";
			this.btnDecreaseInt.Location = new global::System.Drawing.Point(94, 262);
			this.btnDecreaseInt.Name = "btnDecreaseInt";
			this.btnDecreaseInt.Size = new global::System.Drawing.Size(78, 23);
			this.btnDecreaseInt.TabIndex = 158;
			this.btnDecreaseInt.Text = "Decrease";
			this.btnDecreaseInt.UseVisualStyleBackColor = true;
			this.btnDecreaseInt.Click += new global::System.EventHandler(this.btnDecreaseInt_Click);
			this.btnIncreaseInt.Location = new global::System.Drawing.Point(7, 262);
			this.btnIncreaseInt.Name = "btnIncreaseInt";
			this.btnIncreaseInt.Size = new global::System.Drawing.Size(81, 23);
			this.btnIncreaseInt.TabIndex = 158;
			this.btnIncreaseInt.Text = "Increase";
			this.btnIncreaseInt.UseVisualStyleBackColor = true;
			this.btnIncreaseInt.Click += new global::System.EventHandler(this.btnIncreaseInt_Click);
			this.numSetInt.Location = new global::System.Drawing.Point(70, 240);
			this.numSetInt.Name = "numSetInt";
			this.numSetInt.Size = new global::System.Drawing.Size(30, 20);
			this.numSetInt.TabIndex = 157;
			this.txtSetInt.Location = new global::System.Drawing.Point(7, 240);
			this.txtSetInt.Name = "txtSetInt";
			this.txtSetInt.Size = new global::System.Drawing.Size(57, 20);
			this.txtSetInt.TabIndex = 156;
			this.btnSetInt.Location = new global::System.Drawing.Point(104, 238);
			this.btnSetInt.Name = "btnSetInt";
			this.btnSetInt.Size = new global::System.Drawing.Size(68, 23);
			this.btnSetInt.TabIndex = 155;
			this.btnSetInt.Text = "Set";
			this.btnSetInt.UseVisualStyleBackColor = true;
			this.btnSetInt.Click += new global::System.EventHandler(this.btnSetInt_Click);
			this.label18.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label18.AutoSize = true;
			this.label18.Location = new global::System.Drawing.Point(352, 201);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(33, 13);
			this.label18.TabIndex = 154;
			this.label18.Text = "Index";
			this.btnGoDownIndex.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnGoDownIndex.Location = new global::System.Drawing.Point(371, 239);
			this.btnGoDownIndex.Name = "btnGoDownIndex";
			this.btnGoDownIndex.Size = new global::System.Drawing.Size(57, 23);
			this.btnGoDownIndex.TabIndex = 153;
			this.btnGoDownIndex.Text = "Down--";
			this.btnGoDownIndex.UseVisualStyleBackColor = true;
			this.btnGoDownIndex.Click += new global::System.EventHandler(this.btnGotoIndex_Click);
			this.btnGoUpIndex.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnGoUpIndex.Location = new global::System.Drawing.Point(311, 239);
			this.btnGoUpIndex.Name = "btnGoUpIndex";
			this.btnGoUpIndex.Size = new global::System.Drawing.Size(57, 23);
			this.btnGoUpIndex.TabIndex = 153;
			this.btnGoUpIndex.Text = "Up++";
			this.btnGoUpIndex.UseVisualStyleBackColor = true;
			this.btnGoUpIndex.Click += new global::System.EventHandler(this.btnGotoIndex_Click);
			this.btnGotoIndex.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnGotoIndex.Location = new global::System.Drawing.Point(371, 216);
			this.btnGotoIndex.Name = "btnGotoIndex";
			this.btnGotoIndex.Size = new global::System.Drawing.Size(57, 23);
			this.btnGotoIndex.TabIndex = 153;
			this.btnGotoIndex.Text = "Goto Index";
			this.btnGotoIndex.UseVisualStyleBackColor = true;
			this.btnGotoIndex.Click += new global::System.EventHandler(this.btnGotoIndex_Click);
			this.numIndexCmd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.numIndexCmd.Location = new global::System.Drawing.Point(311, 217);
			global::System.Windows.Forms.NumericUpDown numericUpDown34 = this.numIndexCmd;
			int[] array34 = new int[4];
			array34[0] = 10000;
			numericUpDown34.Maximum = new decimal(array34);
			this.numIndexCmd.Name = "numIndexCmd";
			this.numIndexCmd.Size = new global::System.Drawing.Size(57, 20);
			this.numIndexCmd.TabIndex = 152;
			this.btnBlank.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBlank.Location = new global::System.Drawing.Point(177, 153);
			this.btnBlank.Name = "btnBlank";
			this.btnBlank.Size = new global::System.Drawing.Size(128, 22);
			this.btnBlank.TabIndex = 151;
			this.btnBlank.Text = "Blank Command";
			this.btnBlank.UseVisualStyleBackColor = true;
			this.btnBlank.Click += new global::System.EventHandler(this.btnBlank_Click);
			this.btnProvokeOff.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnProvokeOff.AutoSize = true;
			this.btnProvokeOff.Location = new global::System.Drawing.Point(240, 239);
			this.btnProvokeOff.Name = "btnProvokeOff";
			this.btnProvokeOff.Size = new global::System.Drawing.Size(64, 23);
			this.btnProvokeOff.TabIndex = 150;
			this.btnProvokeOff.Text = "Off";
			this.btnProvokeOff.UseVisualStyleBackColor = true;
			this.btnProvokeOff.Click += new global::System.EventHandler(this.btnProvokeOff_Click);
			this.btnProvokeOn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnProvokeOn.AutoSize = true;
			this.btnProvokeOn.Location = new global::System.Drawing.Point(177, 239);
			this.btnProvokeOn.Name = "btnProvokeOn";
			this.btnProvokeOn.Size = new global::System.Drawing.Size(64, 23);
			this.btnProvokeOn.TabIndex = 149;
			this.btnProvokeOn.Text = "On";
			this.btnProvokeOn.UseVisualStyleBackColor = true;
			this.btnProvokeOn.Click += new global::System.EventHandler(this.btnProvokeOn_Click);
			this.btnProvoke.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnProvoke.AutoSize = true;
			this.btnProvoke.Location = new global::System.Drawing.Point(177, 216);
			this.btnProvoke.Name = "btnProvoke";
			this.btnProvoke.Size = new global::System.Drawing.Size(127, 23);
			this.btnProvoke.TabIndex = 148;
			this.btnProvoke.Text = "Toggle";
			this.btnProvoke.UseVisualStyleBackColor = true;
			this.btnProvoke.Click += new global::System.EventHandler(this.btnProvoke_Click);
			this.labelProvoke.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.labelProvoke.Location = new global::System.Drawing.Point(182, 202);
			this.labelProvoke.Name = "labelProvoke";
			this.labelProvoke.Size = new global::System.Drawing.Size(115, 13);
			this.labelProvoke.TabIndex = 147;
			this.labelProvoke.Text = "Provoke";
			this.labelProvoke.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.chkRestartDeath.AutoSize = true;
			this.chkRestartDeath.Checked = true;
			this.chkRestartDeath.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkRestartDeath.Location = new global::System.Drawing.Point(7, 198);
			this.chkRestartDeath.Name = "chkRestartDeath";
			this.chkRestartDeath.Size = new global::System.Drawing.Size(133, 17);
			this.chkRestartDeath.TabIndex = 116;
			this.chkRestartDeath.Text = "Restart bot upon dying";
			this.chkRestartDeath.UseVisualStyleBackColor = true;
			this.chkMerge.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.chkMerge.AutoSize = true;
			this.chkMerge.Location = new global::System.Drawing.Point(376, 57);
			this.chkMerge.Name = "chkMerge";
			this.chkMerge.Size = new global::System.Drawing.Size(56, 17);
			this.chkMerge.TabIndex = 115;
			this.chkMerge.Text = "Merge";
			this.chkMerge.UseVisualStyleBackColor = true;
			this.btnLogout.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnLogout.Location = new global::System.Drawing.Point(311, 54);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new global::System.Drawing.Size(58, 22);
			this.btnLogout.TabIndex = 114;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new global::System.EventHandler(this.btnLogout_Click);
			this.txtLabel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtLabel.Location = new global::System.Drawing.Point(311, 153);
			this.txtLabel.Name = "txtLabel";
			this.txtLabel.Size = new global::System.Drawing.Size(117, 20);
			this.txtLabel.TabIndex = 113;
			this.txtLabel.Text = "Label name";
			this.btnGotoLabel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnGotoLabel.Location = new global::System.Drawing.Point(310, 175);
			this.btnGotoLabel.Name = "btnGotoLabel";
			this.btnGotoLabel.Size = new global::System.Drawing.Size(58, 22);
			this.btnGotoLabel.TabIndex = 112;
			this.btnGotoLabel.Text = "Goto";
			this.btnGotoLabel.UseVisualStyleBackColor = true;
			this.btnGotoLabel.Click += new global::System.EventHandler(this.btnGotoLabel_Click);
			this.btnAddLabel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnAddLabel.Location = new global::System.Drawing.Point(371, 175);
			this.btnAddLabel.Name = "btnAddLabel";
			this.btnAddLabel.Size = new global::System.Drawing.Size(57, 22);
			this.btnAddLabel.TabIndex = 111;
			this.btnAddLabel.Text = "Add";
			this.btnAddLabel.UseVisualStyleBackColor = true;
			this.btnAddLabel.Click += new global::System.EventHandler(this.btnAddLabel_Click);
			this.txtDescription.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtDescription.Location = new global::System.Drawing.Point(311, 103);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new global::System.Drawing.Size(117, 48);
			this.txtDescription.TabIndex = 109;
			this.txtDescription.Text = "Description";
			this.txtDescription.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtDescription.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.txtAuthor.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtAuthor.Location = new global::System.Drawing.Point(311, 80);
			this.txtAuthor.Multiline = true;
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new global::System.Drawing.Size(117, 20);
			this.txtAuthor.TabIndex = 110;
			this.txtAuthor.Text = "Author";
			this.txtAuthor.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtAuthor.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.btnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSave.Location = new global::System.Drawing.Point(311, 28);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(58, 22);
			this.btnSave.TabIndex = 75;
			this.btnSave.Text = "Save bot";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnBeep.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBeep.Location = new global::System.Drawing.Point(177, 177);
			this.btnBeep.Name = "btnBeep";
			this.btnBeep.Size = new global::System.Drawing.Size(75, 22);
			this.btnBeep.TabIndex = 74;
			this.btnBeep.Text = "Play Sound";
			this.btnBeep.UseVisualStyleBackColor = true;
			this.btnBeep.Click += new global::System.EventHandler(this.btnBeep_Click);
			this.numBeepTimes.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.numBeepTimes.Location = new global::System.Drawing.Point(253, 178);
			global::System.Windows.Forms.NumericUpDown numericUpDown35 = this.numBeepTimes;
			int[] array35 = new int[4];
			array35[0] = 1;
			numericUpDown35.Minimum = new decimal(array35);
			this.numBeepTimes.Name = "numBeepTimes";
			this.numBeepTimes.Size = new global::System.Drawing.Size(52, 20);
			this.numBeepTimes.TabIndex = 73;
			global::System.Windows.Forms.NumericUpDown numericUpDown36 = this.numBeepTimes;
			int[] array36 = new int[4];
			array36[0] = 10;
			numericUpDown36.Value = new decimal(array36);
			this.btnDelay.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnDelay.Location = new global::System.Drawing.Point(177, 78);
			this.btnDelay.Name = "btnDelay";
			this.btnDelay.Size = new global::System.Drawing.Size(75, 22);
			this.btnDelay.TabIndex = 74;
			this.btnDelay.Text = "Delay";
			this.btnDelay.UseVisualStyleBackColor = true;
			this.btnDelay.Click += new global::System.EventHandler(this.btnDelay_Click);
			this.numDelay.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.numDelay.Location = new global::System.Drawing.Point(253, 79);
			global::System.Windows.Forms.NumericUpDown numericUpDown37 = this.numDelay;
			int[] array37 = new int[4];
			array37[0] = 71000;
			numericUpDown37.Maximum = new decimal(array37);
			global::System.Windows.Forms.NumericUpDown numericUpDown38 = this.numDelay;
			int[] array38 = new int[4];
			array38[0] = 100;
			numericUpDown38.Minimum = new decimal(array38);
			this.numDelay.Name = "numDelay";
			this.numDelay.Size = new global::System.Drawing.Size(52, 20);
			this.numDelay.TabIndex = 73;
			global::System.Windows.Forms.NumericUpDown numericUpDown39 = this.numDelay;
			int[] array39 = new int[4];
			array39[0] = 1500;
			numericUpDown39.Value = new decimal(array39);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(5, 157);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(51, 13);
			this.label3.TabIndex = 72;
			this.label3.Text = "Bot delay";
			global::System.Windows.Forms.NumericUpDown numericUpDown40 = this.numBotDelay;
			int[] array40 = new int[4];
			array40[0] = 100;
			numericUpDown40.Increment = new decimal(array40);
			this.numBotDelay.Location = new global::System.Drawing.Point(53, 156);
			global::System.Windows.Forms.NumericUpDown numericUpDown41 = this.numBotDelay;
			int[] array41 = new int[4];
			array41[0] = 9000;
			numericUpDown41.Maximum = new decimal(array41);
			this.numBotDelay.Name = "numBotDelay";
			this.numBotDelay.Size = new global::System.Drawing.Size(48, 20);
			this.numBotDelay.TabIndex = 71;
			global::System.Windows.Forms.NumericUpDown numericUpDown42 = this.numBotDelay;
			int[] array42 = new int[4];
			array42[0] = 1000;
			numericUpDown42.Value = new decimal(array42);
			this.btnBotDelay.Location = new global::System.Drawing.Point(102, 155);
			this.btnBotDelay.Name = "btnBotDelay";
			this.btnBotDelay.Size = new global::System.Drawing.Size(70, 23);
			this.btnBotDelay.TabIndex = 70;
			this.btnBotDelay.Text = "Set delay";
			this.btnBotDelay.UseVisualStyleBackColor = true;
			this.btnBotDelay.Click += new global::System.EventHandler(this.btnBotDelay_Click);
			this.txtPlayer.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtPlayer.Location = new global::System.Drawing.Point(178, 104);
			this.txtPlayer.Name = "txtPlayer";
			this.txtPlayer.Size = new global::System.Drawing.Size(127, 20);
			this.txtPlayer.TabIndex = 69;
			this.txtPlayer.Text = "Player name";
			this.txtPlayer.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtPlayer.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.btnGoto.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnGoto.Location = new global::System.Drawing.Point(177, 129);
			this.btnGoto.Name = "btnGoto";
			this.btnGoto.Size = new global::System.Drawing.Size(128, 22);
			this.btnGoto.TabIndex = 68;
			this.btnGoto.Text = "Goto Command";
			this.btnGoto.UseVisualStyleBackColor = true;
			this.btnGoto.Click += new global::System.EventHandler(this.btnGoto_Click);
			this.btnLoad.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnLoad.Location = new global::System.Drawing.Point(370, 28);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new global::System.Drawing.Size(59, 22);
			this.btnLoad.TabIndex = 67;
			this.btnLoad.Text = "Load bot";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new global::System.EventHandler(this.btnLoad_Click);
			this.btnRestart.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRestart.Location = new global::System.Drawing.Point(370, 3);
			this.btnRestart.Name = "btnRestart";
			this.btnRestart.Size = new global::System.Drawing.Size(59, 22);
			this.btnRestart.TabIndex = 66;
			this.btnRestart.Text = "Restart bot";
			this.btnRestart.UseVisualStyleBackColor = true;
			this.btnRestart.Click += new global::System.EventHandler(this.btnRestart_Click);
			this.btnStop.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnStop.Location = new global::System.Drawing.Point(311, 3);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(58, 22);
			this.btnStop.TabIndex = 65;
			this.btnStop.Text = "Stop bot";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new global::System.EventHandler(this.btnStop_Click);
			this.btnLoadCmd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnLoadCmd.Location = new global::System.Drawing.Point(177, 53);
			this.btnLoadCmd.Name = "btnLoadCmd";
			this.btnLoadCmd.Size = new global::System.Drawing.Size(129, 22);
			this.btnLoadCmd.TabIndex = 63;
			this.btnLoadCmd.Text = "Load bot (command)";
			this.btnLoadCmd.UseVisualStyleBackColor = true;
			this.btnLoadCmd.Click += new global::System.EventHandler(this.btnLoadCmd_Click);
			this.chkSkip.AutoSize = true;
			this.chkSkip.Checked = true;
			this.chkSkip.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkSkip.Location = new global::System.Drawing.Point(7, 179);
			this.chkSkip.Name = "chkSkip";
			this.chkSkip.Size = new global::System.Drawing.Size(174, 17);
			this.chkSkip.TabIndex = 62;
			this.chkSkip.Text = "Skip bot delay for index/if cmds";
			this.chkSkip.UseVisualStyleBackColor = true;
			this.btnStatementAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnStatementAdd.Location = new global::System.Drawing.Point(5, 129);
			this.btnStatementAdd.MaximumSize = new global::System.Drawing.Size(197, 20);
			this.btnStatementAdd.MinimumSize = new global::System.Drawing.Size(167, 20);
			this.btnStatementAdd.Name = "btnStatementAdd";
			this.btnStatementAdd.Size = new global::System.Drawing.Size(167, 20);
			this.btnStatementAdd.TabIndex = 61;
			this.btnStatementAdd.Text = "Add statement";
			this.btnStatementAdd.UseVisualStyleBackColor = true;
			this.btnStatementAdd.Click += new global::System.EventHandler(this.btnStatementAdd_Click);
			this.txtStatement2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtStatement2.Location = new global::System.Drawing.Point(5, 105);
			this.txtStatement2.MaximumSize = new global::System.Drawing.Size(197, 20);
			this.txtStatement2.MinimumSize = new global::System.Drawing.Size(167, 20);
			this.txtStatement2.Name = "txtStatement2";
			this.txtStatement2.Size = new global::System.Drawing.Size(167, 20);
			this.txtStatement2.TabIndex = 60;
			this.txtStatement1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtStatement1.Location = new global::System.Drawing.Point(5, 80);
			this.txtStatement1.MaximumSize = new global::System.Drawing.Size(197, 20);
			this.txtStatement1.MinimumSize = new global::System.Drawing.Size(167, 20);
			this.txtStatement1.Name = "txtStatement1";
			this.txtStatement1.Size = new global::System.Drawing.Size(167, 20);
			this.txtStatement1.TabIndex = 59;
			this.cbStatement.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.cbStatement.FormattingEnabled = true;
			this.cbStatement.Location = new global::System.Drawing.Point(5, 55);
			this.cbStatement.MaximumSize = new global::System.Drawing.Size(197, 0);
			this.cbStatement.MinimumSize = new global::System.Drawing.Size(167, 0);
			this.cbStatement.Name = "cbStatement";
			this.cbStatement.Size = new global::System.Drawing.Size(167, 21);
			this.cbStatement.TabIndex = 58;
			this.cbStatement.SelectedIndexChanged += new global::System.EventHandler(this.cbStatement_SelectedIndexChanged);
			this.cbCategories.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.cbCategories.FormattingEnabled = true;
			this.cbCategories.Items.AddRange(new object[]
			{
				"Item",
				"This player",
				"Player",
				"Map",
				"Monster",
				"Quest",
				"Misc"
			});
			this.cbCategories.Location = new global::System.Drawing.Point(5, 30);
			this.cbCategories.MaximumSize = new global::System.Drawing.Size(197, 0);
			this.cbCategories.MinimumSize = new global::System.Drawing.Size(167, 0);
			this.cbCategories.Name = "cbCategories";
			this.cbCategories.Size = new global::System.Drawing.Size(167, 21);
			this.cbCategories.TabIndex = 57;
			this.cbCategories.SelectedIndexChanged += new global::System.EventHandler(this.cbCategories_SelectedIndexChanged);
			this.txtPacket.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtPacket.Location = new global::System.Drawing.Point(4, 4);
			this.txtPacket.Name = "txtPacket";
			this.txtPacket.Size = new global::System.Drawing.Size(248, 20);
			this.txtPacket.TabIndex = 53;
			this.txtPacket.Text = "%xt%zm%cmd%1%tfer%PLAYERNAME%MAP-1e99%";
			this.btnClientPacket.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnClientPacket.Location = new global::System.Drawing.Point(178, 28);
			this.btnClientPacket.Name = "btnClientPacket";
			this.btnClientPacket.Size = new global::System.Drawing.Size(127, 22);
			this.btnClientPacket.TabIndex = 52;
			this.btnClientPacket.Text = "Client Packet";
			this.btnClientPacket.UseVisualStyleBackColor = true;
			this.btnClientPacket.Click += new global::System.EventHandler(this.btnClientPacket_Click);
			this.btnPacket.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnPacket.Location = new global::System.Drawing.Point(253, 3);
			this.btnPacket.Name = "btnPacket";
			this.btnPacket.Size = new global::System.Drawing.Size(52, 22);
			this.btnPacket.TabIndex = 52;
			this.btnPacket.Text = "Packet";
			this.btnPacket.UseVisualStyleBackColor = true;
			this.btnPacket.Click += new global::System.EventHandler(this.btnPacket_Click);
			this.tabOptions.Controls.Add(this.pnlOptions);
			this.tabOptions.Location = new global::System.Drawing.Point(4, 22);
			this.tabOptions.Name = "tabOptions";
			this.tabOptions.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabOptions.Size = new global::System.Drawing.Size(444, 299);
			this.tabOptions.TabIndex = 5;
			this.tabOptions.Text = "Options";
			this.tabOptions.UseVisualStyleBackColor = true;
			this.pnlOptions.Controls.Add(this.chkBuff);
			this.pnlOptions.Controls.Add(this.label6);
			this.pnlOptions.Controls.Add(this.numOptionsTimer);
			this.pnlOptions.Controls.Add(this.label5);
			this.pnlOptions.Controls.Add(this.chkUntarget);
			this.pnlOptions.Controls.Add(this.lstLogText);
			this.pnlOptions.Controls.Add(this.btnLogDebug);
			this.pnlOptions.Controls.Add(this.btnLog);
			this.pnlOptions.Controls.Add(this.txtLog);
			this.pnlOptions.Controls.Add(this.chkEnableSettings);
			this.pnlOptions.Controls.Add(this.chkDisableAnims);
			this.pnlOptions.Controls.Add(this.txtSoundItem);
			this.pnlOptions.Controls.Add(this.btnSoundAdd);
			this.pnlOptions.Controls.Add(this.btnSoundDelete);
			this.pnlOptions.Controls.Add(this.btnSoundTest);
			this.pnlOptions.Controls.Add(this.lstSoundItems);
			this.pnlOptions.Controls.Add(this.label9);
			this.pnlOptions.Controls.Add(this.numWalkSpeed);
			this.pnlOptions.Controls.Add(this.label8);
			this.pnlOptions.Controls.Add(this.chkSkipCutscenes);
			this.pnlOptions.Controls.Add(this.chkHidePlayers);
			this.pnlOptions.Controls.Add(this.chkLag);
			this.pnlOptions.Controls.Add(this.chkMagnet);
			this.pnlOptions.Controls.Add(this.chkProvoke);
			this.pnlOptions.Controls.Add(this.chkInfiniteRange);
			this.pnlOptions.Controls.Add(this.grpLogin);
			this.pnlOptions.Controls.Add(this.chkGender);
			this.pnlOptions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlOptions.Location = new global::System.Drawing.Point(3, 3);
			this.pnlOptions.Name = "pnlOptions";
			this.pnlOptions.Size = new global::System.Drawing.Size(438, 293);
			this.pnlOptions.TabIndex = 108;
			this.chkBuff.AutoSize = true;
			this.chkBuff.Location = new global::System.Drawing.Point(150, 184);
			this.chkBuff.Name = "chkBuff";
			this.chkBuff.Size = new global::System.Drawing.Size(60, 17);
			this.chkBuff.TabIndex = 158;
			this.chkBuff.Text = "Buff up";
			this.chkBuff.UseVisualStyleBackColor = true;
			this.chkBuff.CheckedChanged += new global::System.EventHandler(this.chkBuffup_CheckedChanged);
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(195, 254);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(72, 13);
			this.label6.TabIndex = 157;
			this.label6.Text = "Options Timer";
			this.numOptionsTimer.Location = new global::System.Drawing.Point(150, 251);
			global::System.Windows.Forms.NumericUpDown numericUpDown43 = this.numOptionsTimer;
			int[] array43 = new int[4];
			array43[0] = 10000;
			numericUpDown43.Maximum = new decimal(array43);
			global::System.Windows.Forms.NumericUpDown numericUpDown44 = this.numOptionsTimer;
			int[] array44 = new int[4];
			array44[0] = 1;
			numericUpDown44.Minimum = new decimal(array44);
			this.numOptionsTimer.Name = "numOptionsTimer";
			this.numOptionsTimer.Size = new global::System.Drawing.Size(42, 20);
			this.numOptionsTimer.TabIndex = 156;
			global::System.Windows.Forms.NumericUpDown numericUpDown45 = this.numOptionsTimer;
			int[] array45 = new int[4];
			array45[0] = 250;
			numericUpDown45.Value = new decimal(array45);
			this.numOptionsTimer.ValueChanged += new global::System.EventHandler(this.numOptionsTimer_ValueChanged);
			this.label5.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(289, 109);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(115, 13);
			this.label5.TabIndex = 155;
			this.label5.Text = "Viable Log References";
			this.chkUntarget.AutoSize = true;
			this.chkUntarget.Location = new global::System.Drawing.Point(150, 165);
			this.chkUntarget.Name = "chkUntarget";
			this.chkUntarget.Size = new global::System.Drawing.Size(86, 17);
			this.chkUntarget.TabIndex = 154;
			this.chkUntarget.Text = "Untarget self";
			this.chkUntarget.UseVisualStyleBackColor = true;
			this.chkUntarget.CheckedChanged += new global::System.EventHandler(this.chkUntarget_CheckedChanged);
			this.lstLogText.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lstLogText.FormattingEnabled = true;
			this.lstLogText.Items.AddRange(new object[]
			{
				"{USERNAME}",
				"{MAP}",
				"{GOLD}",
				"{LEVEL}",
				"{CELL}",
				"{HEALTH}",
				"{TIME: 12}",
				"{TIME: 24}",
				"{CLEAR}",
				"{ITEM: item name}",
				"{ITEM MAX: item name}",
				"{REP XP: faction}",
				"{REP RANK: faction}",
				"{REP TOTAL: faction}",
				"{REP REMAINING: faction}",
				"{REP REQUIRED: faction}",
				"{REP CURRENT: faction}",
				"{INT VALUE: int}"
			});
			this.lstLogText.Location = new global::System.Drawing.Point(281, 123);
			this.lstLogText.Name = "lstLogText";
			this.lstLogText.Size = new global::System.Drawing.Size(141, 147);
			this.lstLogText.TabIndex = 153;
			this.lstLogText.DoubleClick += new global::System.EventHandler(this.lstLogText_DoubleClick);
			this.lstLogText.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.lstLogText_KeyDown);
			this.btnLogDebug.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnLogDebug.AutoSize = true;
			this.btnLogDebug.Location = new global::System.Drawing.Point(348, 86);
			this.btnLogDebug.Name = "btnLogDebug";
			this.btnLogDebug.Size = new global::System.Drawing.Size(74, 23);
			this.btnLogDebug.TabIndex = 152;
			this.btnLogDebug.Text = "Log Debug";
			this.btnLogDebug.UseVisualStyleBackColor = true;
			this.btnLogDebug.Click += new global::System.EventHandler(this.logDebug);
			this.btnLog.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnLog.AutoSize = true;
			this.btnLog.Location = new global::System.Drawing.Point(280, 86);
			this.btnLog.Name = "btnLog";
			this.btnLog.Size = new global::System.Drawing.Size(68, 23);
			this.btnLog.TabIndex = 148;
			this.btnLog.Text = "Log Script";
			this.btnLog.UseVisualStyleBackColor = true;
			this.btnLog.Click += new global::System.EventHandler(this.logScript);
			this.txtLog.AcceptsReturn = true;
			this.txtLog.AcceptsTab = true;
			this.txtLog.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtLog.AutoCompleteCustomSource.AddRange(new string[]
			{
				"{USERNAME}",
				"{MAP}",
				"{GOLD}",
				"{LEVEL}",
				"{CELL}",
				"{HEALTH}",
				"{TIME: 12}",
				"{TIME: 24}",
				"{CLEAR}",
				"{ITEM: item name}",
				"{ITEM MAX: item name}",
				"{REP XP: faction}",
				"{REP RANK: faction}",
				"{REP TOTAL: faction}",
				"{REP REMAINING: faction}",
				"{REP REQUIRED: faction}",
				"{REP CURRENT: faction}"
			});
			this.txtLog.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtLog.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtLog.Location = new global::System.Drawing.Point(281, 5);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.txtLog.Size = new global::System.Drawing.Size(141, 79);
			this.txtLog.TabIndex = 147;
			this.txtLog.Text = "Logs";
			this.chkEnableSettings.AutoSize = true;
			this.chkEnableSettings.Location = new global::System.Drawing.Point(151, 221);
			this.chkEnableSettings.Name = "chkEnableSettings";
			this.chkEnableSettings.Size = new global::System.Drawing.Size(97, 30);
			this.chkEnableSettings.TabIndex = 132;
			this.chkEnableSettings.Text = "Enable options\r\nwithout starting";
			this.chkEnableSettings.UseVisualStyleBackColor = true;
			this.chkEnableSettings.Click += new global::System.EventHandler(this.chkEnableSettings_Click);
			this.chkDisableAnims.AutoSize = true;
			this.chkDisableAnims.Location = new global::System.Drawing.Point(150, 127);
			this.chkDisableAnims.Name = "chkDisableAnims";
			this.chkDisableAnims.Size = new global::System.Drawing.Size(122, 17);
			this.chkDisableAnims.TabIndex = 131;
			this.chkDisableAnims.Text = "Disable player anims";
			this.chkDisableAnims.UseVisualStyleBackColor = true;
			this.chkDisableAnims.CheckedChanged += new global::System.EventHandler(this.chkDisableAnims_CheckedChanged);
			this.txtSoundItem.Location = new global::System.Drawing.Point(6, 228);
			this.txtSoundItem.Name = "txtSoundItem";
			this.txtSoundItem.Size = new global::System.Drawing.Size(139, 20);
			this.txtSoundItem.TabIndex = 130;
			this.txtSoundItem.Enter += new global::System.EventHandler(this.TextboxEnter);
			this.txtSoundItem.Leave += new global::System.EventHandler(this.TextboxLeave);
			this.btnSoundAdd.Location = new global::System.Drawing.Point(51, 250);
			this.btnSoundAdd.Name = "btnSoundAdd";
			this.btnSoundAdd.Size = new global::System.Drawing.Size(43, 22);
			this.btnSoundAdd.TabIndex = 129;
			this.btnSoundAdd.Text = "Add";
			this.btnSoundAdd.UseVisualStyleBackColor = true;
			this.btnSoundAdd.Click += new global::System.EventHandler(this.btnSoundAdd_Click);
			this.btnSoundDelete.Location = new global::System.Drawing.Point(96, 250);
			this.btnSoundDelete.Name = "btnSoundDelete";
			this.btnSoundDelete.Size = new global::System.Drawing.Size(50, 22);
			this.btnSoundDelete.TabIndex = 128;
			this.btnSoundDelete.Text = "Delete";
			this.btnSoundDelete.UseVisualStyleBackColor = true;
			this.btnSoundDelete.Click += new global::System.EventHandler(this.btnSoundDelete_Click);
			this.btnSoundTest.Location = new global::System.Drawing.Point(5, 250);
			this.btnSoundTest.Name = "btnSoundTest";
			this.btnSoundTest.Size = new global::System.Drawing.Size(43, 22);
			this.btnSoundTest.TabIndex = 126;
			this.btnSoundTest.Text = "Test";
			this.btnSoundTest.UseVisualStyleBackColor = true;
			this.btnSoundTest.Click += new global::System.EventHandler(this.btnSoundTest_Click);
			this.lstSoundItems.FormattingEnabled = true;
			this.lstSoundItems.Location = new global::System.Drawing.Point(6, 168);
			this.lstSoundItems.Name = "lstSoundItems";
			this.lstSoundItems.Size = new global::System.Drawing.Size(139, 56);
			this.lstSoundItems.TabIndex = 125;
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(10, 141);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(134, 26);
			this.label9.TabIndex = 124;
			this.label9.Text = "If any of the following items\r\nare dropped, play a sound";
			this.numWalkSpeed.Location = new global::System.Drawing.Point(214, 201);
			global::System.Windows.Forms.NumericUpDown numericUpDown46 = this.numWalkSpeed;
			int[] array46 = new int[4];
			array46[0] = 99;
			numericUpDown46.Maximum = new decimal(array46);
			global::System.Windows.Forms.NumericUpDown numericUpDown47 = this.numWalkSpeed;
			int[] array47 = new int[4];
			array47[0] = 1;
			numericUpDown47.Minimum = new decimal(array47);
			this.numWalkSpeed.Name = "numWalkSpeed";
			this.numWalkSpeed.Size = new global::System.Drawing.Size(28, 20);
			this.numWalkSpeed.TabIndex = 123;
			global::System.Windows.Forms.NumericUpDown numericUpDown48 = this.numWalkSpeed;
			int[] array48 = new int[4];
			array48[0] = 8;
			numericUpDown48.Value = new decimal(array48);
			this.numWalkSpeed.ValueChanged += new global::System.EventHandler(this.numWalkSpeed_ValueChanged);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(148, 205);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(64, 13);
			this.label8.TabIndex = 122;
			this.label8.Text = "Walk speed";
			this.chkSkipCutscenes.AutoSize = true;
			this.chkSkipCutscenes.Location = new global::System.Drawing.Point(150, 107);
			this.chkSkipCutscenes.Name = "chkSkipCutscenes";
			this.chkSkipCutscenes.Size = new global::System.Drawing.Size(99, 17);
			this.chkSkipCutscenes.TabIndex = 121;
			this.chkSkipCutscenes.Text = "Skip cutscenes";
			this.chkSkipCutscenes.UseVisualStyleBackColor = true;
			this.chkSkipCutscenes.CheckedChanged += new global::System.EventHandler(this.chkSkipCutscenes_CheckedChanged);
			this.chkHidePlayers.AutoSize = true;
			this.chkHidePlayers.Location = new global::System.Drawing.Point(150, 87);
			this.chkHidePlayers.Name = "chkHidePlayers";
			this.chkHidePlayers.Size = new global::System.Drawing.Size(84, 17);
			this.chkHidePlayers.TabIndex = 120;
			this.chkHidePlayers.Text = "Hide players";
			this.chkHidePlayers.UseVisualStyleBackColor = true;
			this.chkHidePlayers.CheckedChanged += new global::System.EventHandler(this.chkHidePlayers_CheckedChanged);
			this.chkLag.AutoSize = true;
			this.chkLag.Location = new global::System.Drawing.Point(150, 66);
			this.chkLag.Name = "chkLag";
			this.chkLag.Size = new global::System.Drawing.Size(68, 17);
			this.chkLag.TabIndex = 119;
			this.chkLag.Text = "Lag killer";
			this.chkLag.UseVisualStyleBackColor = true;
			this.chkLag.CheckedChanged += new global::System.EventHandler(this.chkLag_CheckedChanged);
			this.chkMagnet.AutoSize = true;
			this.chkMagnet.Location = new global::System.Drawing.Point(150, 46);
			this.chkMagnet.Name = "chkMagnet";
			this.chkMagnet.Size = new global::System.Drawing.Size(96, 17);
			this.chkMagnet.TabIndex = 118;
			this.chkMagnet.Text = "Enemy magnet";
			this.chkMagnet.UseVisualStyleBackColor = true;
			this.chkMagnet.CheckedChanged += new global::System.EventHandler(this.chkMagnet_CheckedChanged);
			this.chkProvoke.AutoSize = true;
			this.chkProvoke.Location = new global::System.Drawing.Point(150, 25);
			this.chkProvoke.Name = "chkProvoke";
			this.chkProvoke.Size = new global::System.Drawing.Size(111, 17);
			this.chkProvoke.TabIndex = 117;
			this.chkProvoke.Text = "Provoke monsters";
			this.chkProvoke.UseVisualStyleBackColor = true;
			this.chkProvoke.CheckedChanged += new global::System.EventHandler(this.chkProvoke_CheckedChanged);
			this.chkInfiniteRange.AutoSize = true;
			this.chkInfiniteRange.Location = new global::System.Drawing.Point(150, 4);
			this.chkInfiniteRange.Name = "chkInfiniteRange";
			this.chkInfiniteRange.Size = new global::System.Drawing.Size(120, 17);
			this.chkInfiniteRange.TabIndex = 116;
			this.chkInfiniteRange.Text = "Infinite attack range";
			this.chkInfiniteRange.UseVisualStyleBackColor = true;
			this.chkInfiniteRange.CheckedChanged += new global::System.EventHandler(this.chkInfiniteRange_CheckedChanged);
			this.grpLogin.Controls.Add(this.chkAFK);
			this.grpLogin.Controls.Add(this.cbServers);
			this.grpLogin.Controls.Add(this.chkRelogRetry);
			this.grpLogin.Controls.Add(this.chkRelog);
			this.grpLogin.Controls.Add(this.numRelogDelay);
			this.grpLogin.Controls.Add(this.label7);
			this.grpLogin.Location = new global::System.Drawing.Point(4, 3);
			this.grpLogin.Name = "grpLogin";
			this.grpLogin.Size = new global::System.Drawing.Size(141, 138);
			this.grpLogin.TabIndex = 115;
			this.grpLogin.TabStop = false;
			this.grpLogin.Text = "Auto relogin";
			this.chkAFK.AutoSize = true;
			this.chkAFK.Enabled = false;
			this.chkAFK.Location = new global::System.Drawing.Point(4, 62);
			this.chkAFK.Name = "chkAFK";
			this.chkAFK.Size = new global::System.Drawing.Size(100, 17);
			this.chkAFK.TabIndex = 159;
			this.chkAFK.Text = "Relogin on AFK";
			this.chkAFK.UseVisualStyleBackColor = true;
			this.chkAFK.CheckedChanged += new global::System.EventHandler(this.chkAFK_CheckedChanged);
			this.cbServers.FormattingEnabled = true;
			this.cbServers.Location = new global::System.Drawing.Point(4, 17);
			this.cbServers.Name = "cbServers";
			this.cbServers.Size = new global::System.Drawing.Size(123, 21);
			this.cbServers.TabIndex = 0;
			this.chkRelogRetry.AutoSize = true;
			this.chkRelogRetry.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f);
			this.chkRelogRetry.Location = new global::System.Drawing.Point(3, 120);
			this.chkRelogRetry.Name = "chkRelogRetry";
			this.chkRelogRetry.Size = new global::System.Drawing.Size(143, 17);
			this.chkRelogRetry.TabIndex = 88;
			this.chkRelogRetry.Text = "Relog again if in battleon";
			this.chkRelogRetry.UseVisualStyleBackColor = true;
			this.chkRelog.AutoSize = true;
			this.chkRelog.Location = new global::System.Drawing.Point(4, 43);
			this.chkRelog.Name = "chkRelog";
			this.chkRelog.Size = new global::System.Drawing.Size(82, 17);
			this.chkRelog.TabIndex = 1;
			this.chkRelog.Text = "Auto relogin";
			this.chkRelog.UseVisualStyleBackColor = true;
			this.chkRelog.CheckedChanged += new global::System.EventHandler(this.chkRelog_CheckedChanged);
			global::System.Windows.Forms.NumericUpDown numericUpDown49 = this.numRelogDelay;
			int[] array49 = new int[4];
			array49[0] = 1000;
			numericUpDown49.Increment = new decimal(array49);
			this.numRelogDelay.Location = new global::System.Drawing.Point(3, 98);
			global::System.Windows.Forms.NumericUpDown numericUpDown50 = this.numRelogDelay;
			int[] array50 = new int[4];
			array50[0] = 20000;
			numericUpDown50.Maximum = new decimal(array50);
			global::System.Windows.Forms.NumericUpDown numericUpDown51 = this.numRelogDelay;
			int[] array51 = new int[4];
			array51[0] = 1000;
			numericUpDown51.Minimum = new decimal(array51);
			this.numRelogDelay.Name = "numRelogDelay";
			this.numRelogDelay.Size = new global::System.Drawing.Size(46, 20);
			this.numRelogDelay.TabIndex = 86;
			global::System.Windows.Forms.NumericUpDown numericUpDown52 = this.numRelogDelay;
			int[] array52 = new int[4];
			array52[0] = 5000;
			numericUpDown52.Value = new decimal(array52);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8f);
			this.label7.Location = new global::System.Drawing.Point(0, 82);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(140, 13);
			this.label7.TabIndex = 87;
			this.label7.Text = "Delay before starting the bot";
			this.chkGender.AutoSize = true;
			this.chkGender.Location = new global::System.Drawing.Point(150, 146);
			this.chkGender.Name = "chkGender";
			this.chkGender.Size = new global::System.Drawing.Size(89, 17);
			this.chkGender.TabIndex = 137;
			this.chkGender.Text = "Gender swap";
			this.chkGender.UseVisualStyleBackColor = true;
			this.chkGender.CheckedChanged += new global::System.EventHandler(this.changeGenderAsync);
			this.tabOptions2.Controls.Add(this.numSetLevel);
			this.tabOptions2.Controls.Add(this.chkChangeRoomTag);
			this.tabOptions2.Controls.Add(this.chkChangeChat);
			this.tabOptions2.Controls.Add(this.chkSetJoinLevel);
			this.tabOptions2.Controls.Add(this.chkHideYulgarPlayers);
			this.tabOptions2.Controls.Add(this.chkAntiAfk);
			this.tabOptions2.Controls.Add(this.grpAccessLevel);
			this.tabOptions2.Controls.Add(this.grpAlignment);
			this.tabOptions2.Controls.Add(this.txtUsername);
			this.tabOptions2.Controls.Add(this.btnChangeNameCmd);
			this.tabOptions2.Controls.Add(this.btnchangeName);
			this.tabOptions2.Controls.Add(this.btnChangeGuildCmd);
			this.tabOptions2.Controls.Add(this.btnchangeGuild);
			this.tabOptions2.Controls.Add(this.txtGuild);
			this.tabOptions2.Location = new global::System.Drawing.Point(4, 22);
			this.tabOptions2.Name = "tabOptions2";
			this.tabOptions2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabOptions2.Size = new global::System.Drawing.Size(444, 299);
			this.tabOptions2.TabIndex = 7;
			this.tabOptions2.Text = "Client";
			this.tabOptions2.UseVisualStyleBackColor = true;
			this.numSetLevel.Enabled = false;
			this.numSetLevel.Location = new global::System.Drawing.Point(12, 195);
			global::System.Windows.Forms.NumericUpDown numericUpDown53 = this.numSetLevel;
			int[] array53 = new int[4];
			array53[0] = 10000;
			numericUpDown53.Maximum = new decimal(array53);
			global::System.Windows.Forms.NumericUpDown numericUpDown54 = this.numSetLevel;
			int[] array54 = new int[4];
			array54[0] = 1;
			numericUpDown54.Minimum = new decimal(array54);
			this.numSetLevel.Name = "numSetLevel";
			this.numSetLevel.Size = new global::System.Drawing.Size(51, 20);
			this.numSetLevel.TabIndex = 145;
			global::System.Windows.Forms.NumericUpDown numericUpDown55 = this.numSetLevel;
			int[] array55 = new int[4];
			array55[0] = 1;
			numericUpDown55.Value = new decimal(array55);
			this.chkChangeRoomTag.AutoSize = true;
			this.chkChangeRoomTag.Location = new global::System.Drawing.Point(12, 221);
			this.chkChangeRoomTag.Name = "chkChangeRoomTag";
			this.chkChangeRoomTag.Size = new global::System.Drawing.Size(107, 17);
			this.chkChangeRoomTag.TabIndex = 144;
			this.chkChangeRoomTag.Text = "Anonymous room";
			this.chkChangeRoomTag.UseVisualStyleBackColor = true;
			this.chkChangeRoomTag.CheckedChanged += new global::System.EventHandler(this.chkChangeRoomTag_CheckedChanged);
			this.chkChangeChat.AutoSize = true;
			this.chkChangeChat.Location = new global::System.Drawing.Point(12, 243);
			this.chkChangeChat.Name = "chkChangeChat";
			this.chkChangeChat.Size = new global::System.Drawing.Size(105, 17);
			this.chkChangeChat.TabIndex = 144;
			this.chkChangeChat.Text = "Anonymous chat";
			this.chkChangeChat.UseVisualStyleBackColor = true;
			this.chkChangeChat.CheckedChanged += new global::System.EventHandler(this.chkChangeChat_CheckedChanged);
			this.chkSetJoinLevel.AutoSize = true;
			this.chkSetJoinLevel.Enabled = false;
			this.chkSetJoinLevel.Location = new global::System.Drawing.Point(69, 197);
			this.chkSetJoinLevel.Name = "chkSetJoinLevel";
			this.chkSetJoinLevel.Size = new global::System.Drawing.Size(110, 17);
			this.chkSetJoinLevel.TabIndex = 144;
			this.chkSetJoinLevel.Text = "Toggle Join Level";
			this.chkSetJoinLevel.UseVisualStyleBackColor = true;
			this.chkSetJoinLevel.CheckedChanged += new global::System.EventHandler(this.chkSetJoinLevel_CheckedChanged);
			this.chkHideYulgarPlayers.AutoSize = true;
			this.chkHideYulgarPlayers.Location = new global::System.Drawing.Point(12, 266);
			this.chkHideYulgarPlayers.Name = "chkHideYulgarPlayers";
			this.chkHideYulgarPlayers.Size = new global::System.Drawing.Size(126, 17);
			this.chkHideYulgarPlayers.TabIndex = 144;
			this.chkHideYulgarPlayers.Text = "Hide Players Upstairs";
			this.chkHideYulgarPlayers.UseVisualStyleBackColor = true;
			this.chkHideYulgarPlayers.CheckedChanged += new global::System.EventHandler(this.chkHideYulgarPlayers_CheckedChanged);
			this.chkAntiAfk.AutoSize = true;
			this.chkAntiAfk.Location = new global::System.Drawing.Point(121, 221);
			this.chkAntiAfk.Name = "chkAntiAfk";
			this.chkAntiAfk.Size = new global::System.Drawing.Size(67, 17);
			this.chkAntiAfk.TabIndex = 144;
			this.chkAntiAfk.Text = "Anti-AFK";
			this.chkAntiAfk.UseVisualStyleBackColor = true;
			this.chkAntiAfk.CheckedChanged += new global::System.EventHandler(this.chkAntiAfk_CheckedChanged);
			this.grpAccessLevel.Controls.Add(this.chkToggleMute);
			this.grpAccessLevel.Controls.Add(this.btnSetMem);
			this.grpAccessLevel.Controls.Add(this.btnSetModerator);
			this.grpAccessLevel.Controls.Add(this.btnSetNonMem);
			this.grpAccessLevel.Location = new global::System.Drawing.Point(98, 6);
			this.grpAccessLevel.Name = "grpAccessLevel";
			this.grpAccessLevel.Size = new global::System.Drawing.Size(86, 131);
			this.grpAccessLevel.TabIndex = 6;
			this.grpAccessLevel.TabStop = false;
			this.grpAccessLevel.Text = "Access";
			this.chkToggleMute.AutoSize = true;
			this.chkToggleMute.Location = new global::System.Drawing.Point(4, 107);
			this.chkToggleMute.Name = "chkToggleMute";
			this.chkToggleMute.Size = new global::System.Drawing.Size(86, 17);
			this.chkToggleMute.TabIndex = 6;
			this.chkToggleMute.Text = "Toggle Mute";
			this.chkToggleMute.UseVisualStyleBackColor = true;
			this.chkToggleMute.CheckedChanged += new global::System.EventHandler(this.chkToggleMute_CheckedChanged);
			this.btnSetMem.Location = new global::System.Drawing.Point(6, 19);
			this.btnSetMem.Name = "btnSetMem";
			this.btnSetMem.Size = new global::System.Drawing.Size(75, 23);
			this.btnSetMem.TabIndex = 3;
			this.btnSetMem.Text = "Member";
			this.btnSetMem.UseVisualStyleBackColor = true;
			this.btnSetMem.Click += new global::System.EventHandler(this.btnSetHero_Click);
			this.btnSetModerator.Location = new global::System.Drawing.Point(6, 77);
			this.btnSetModerator.Name = "btnSetModerator";
			this.btnSetModerator.Size = new global::System.Drawing.Size(75, 23);
			this.btnSetModerator.TabIndex = 5;
			this.btnSetModerator.Text = "Moderator";
			this.btnSetModerator.UseVisualStyleBackColor = true;
			this.btnSetModerator.Click += new global::System.EventHandler(this.btnSetHero_Click);
			this.btnSetNonMem.Location = new global::System.Drawing.Point(6, 48);
			this.btnSetNonMem.Name = "btnSetNonMem";
			this.btnSetNonMem.Size = new global::System.Drawing.Size(75, 23);
			this.btnSetNonMem.TabIndex = 4;
			this.btnSetNonMem.Text = "Non-Mem";
			this.btnSetNonMem.UseVisualStyleBackColor = true;
			this.btnSetNonMem.Click += new global::System.EventHandler(this.btnSetHero_Click);
			this.grpAlignment.Controls.Add(this.btnSetChaos);
			this.grpAlignment.Controls.Add(this.btnSetUndecided);
			this.grpAlignment.Controls.Add(this.btnSetGood);
			this.grpAlignment.Controls.Add(this.btnSetEvil);
			this.grpAlignment.Location = new global::System.Drawing.Point(6, 6);
			this.grpAlignment.Name = "grpAlignment";
			this.grpAlignment.Size = new global::System.Drawing.Size(86, 131);
			this.grpAlignment.TabIndex = 1;
			this.grpAlignment.TabStop = false;
			this.grpAlignment.Text = "Alignment";
			this.btnSetChaos.Location = new global::System.Drawing.Point(6, 74);
			this.btnSetChaos.Name = "btnSetChaos";
			this.btnSetChaos.Size = new global::System.Drawing.Size(75, 23);
			this.btnSetChaos.TabIndex = 0;
			this.btnSetChaos.Text = "Chaos";
			this.btnSetChaos.UseVisualStyleBackColor = true;
			this.btnSetChaos.Click += new global::System.EventHandler(this.btnSetHero_Click);
			this.btnSetUndecided.Location = new global::System.Drawing.Point(6, 103);
			this.btnSetUndecided.Name = "btnSetUndecided";
			this.btnSetUndecided.Size = new global::System.Drawing.Size(75, 23);
			this.btnSetUndecided.TabIndex = 0;
			this.btnSetUndecided.Text = "Undecided";
			this.btnSetUndecided.UseVisualStyleBackColor = true;
			this.btnSetUndecided.Click += new global::System.EventHandler(this.btnSetHero_Click);
			this.btnSetGood.Location = new global::System.Drawing.Point(6, 16);
			this.btnSetGood.Name = "btnSetGood";
			this.btnSetGood.Size = new global::System.Drawing.Size(75, 23);
			this.btnSetGood.TabIndex = 0;
			this.btnSetGood.Text = "Good";
			this.btnSetGood.UseVisualStyleBackColor = true;
			this.btnSetGood.Click += new global::System.EventHandler(this.btnSetHero_Click);
			this.btnSetEvil.Location = new global::System.Drawing.Point(6, 45);
			this.btnSetEvil.Name = "btnSetEvil";
			this.btnSetEvil.Size = new global::System.Drawing.Size(75, 23);
			this.btnSetEvil.TabIndex = 0;
			this.btnSetEvil.Text = "Evil";
			this.btnSetEvil.UseVisualStyleBackColor = true;
			this.btnSetEvil.Click += new global::System.EventHandler(this.btnSetHero_Click);
			this.txtUsername.Location = new global::System.Drawing.Point(10, 146);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(78, 20);
			this.txtUsername.TabIndex = 135;
			this.txtUsername.Text = "Username";
			this.btnChangeNameCmd.AutoSize = true;
			this.btnChangeNameCmd.Location = new global::System.Drawing.Point(136, 145);
			this.btnChangeNameCmd.Name = "btnChangeNameCmd";
			this.btnChangeNameCmd.Size = new global::System.Drawing.Size(45, 23);
			this.btnChangeNameCmd.TabIndex = 142;
			this.btnChangeNameCmd.Text = "(cmd)";
			this.btnChangeNameCmd.Click += new global::System.EventHandler(this.btnChangeCmd_Click);
			this.btnchangeName.AutoSize = true;
			this.btnchangeName.Location = new global::System.Drawing.Point(90, 145);
			this.btnchangeName.Name = "btnchangeName";
			this.btnchangeName.Size = new global::System.Drawing.Size(45, 23);
			this.btnchangeName.TabIndex = 142;
			this.btnchangeName.Text = "Set";
			this.btnchangeName.Click += new global::System.EventHandler(this.btnchangeName_Click);
			this.btnChangeGuildCmd.AutoSize = true;
			this.btnChangeGuildCmd.Location = new global::System.Drawing.Point(136, 168);
			this.btnChangeGuildCmd.Name = "btnChangeGuildCmd";
			this.btnChangeGuildCmd.Size = new global::System.Drawing.Size(45, 23);
			this.btnChangeGuildCmd.TabIndex = 143;
			this.btnChangeGuildCmd.Text = "(cmd)";
			this.btnChangeGuildCmd.Click += new global::System.EventHandler(this.btnChangeCmd_Click);
			this.btnchangeGuild.AutoSize = true;
			this.btnchangeGuild.Location = new global::System.Drawing.Point(90, 168);
			this.btnchangeGuild.Name = "btnchangeGuild";
			this.btnchangeGuild.Size = new global::System.Drawing.Size(45, 23);
			this.btnchangeGuild.TabIndex = 143;
			this.btnchangeGuild.Text = "Set";
			this.btnchangeGuild.Click += new global::System.EventHandler(this.btnchangeGuild_Click);
			this.txtGuild.Location = new global::System.Drawing.Point(10, 169);
			this.txtGuild.Name = "txtGuild";
			this.txtGuild.Size = new global::System.Drawing.Size(78, 20);
			this.txtGuild.TabIndex = 136;
			this.txtGuild.Text = "Guild";
			this.tabBots.Controls.Add(this.pnlSaved);
			this.tabBots.Location = new global::System.Drawing.Point(4, 22);
			this.tabBots.Name = "tabBots";
			this.tabBots.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabBots.Size = new global::System.Drawing.Size(444, 299);
			this.tabBots.TabIndex = 6;
			this.tabBots.Text = "Bots";
			this.tabBots.UseVisualStyleBackColor = true;
			this.pnlSaved.Controls.Add(this.lblBoosts);
			this.pnlSaved.Controls.Add(this.lblDrops);
			this.pnlSaved.Controls.Add(this.lblQuests);
			this.pnlSaved.Controls.Add(this.lblSkills);
			this.pnlSaved.Controls.Add(this.lblCommands);
			this.pnlSaved.Controls.Add(this.lblItems);
			this.pnlSaved.Controls.Add(this.txtSavedDesc);
			this.pnlSaved.Controls.Add(this.txtSavedAuthor);
			this.pnlSaved.Controls.Add(this.lblBots);
			this.pnlSaved.Controls.Add(this.treeBots);
			this.pnlSaved.Controls.Add(this.txtSavedAdd);
			this.pnlSaved.Controls.Add(this.btnSavedAdd);
			this.pnlSaved.Controls.Add(this.txtSaved);
			this.pnlSaved.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlSaved.Location = new global::System.Drawing.Point(3, 3);
			this.pnlSaved.Name = "pnlSaved";
			this.pnlSaved.Size = new global::System.Drawing.Size(438, 293);
			this.pnlSaved.TabIndex = 109;
			this.lblBoosts.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.lblBoosts.AutoSize = true;
			this.lblBoosts.Location = new global::System.Drawing.Point(251, 260);
			this.lblBoosts.Name = "lblBoosts";
			this.lblBoosts.Size = new global::System.Drawing.Size(42, 13);
			this.lblBoosts.TabIndex = 25;
			this.lblBoosts.Text = "Boosts:";
			this.lblBoosts.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.lblDrops.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.lblDrops.AutoSize = true;
			this.lblDrops.Location = new global::System.Drawing.Point(195, 260);
			this.lblDrops.Name = "lblDrops";
			this.lblDrops.Size = new global::System.Drawing.Size(38, 13);
			this.lblDrops.TabIndex = 24;
			this.lblDrops.Text = "Drops:";
			this.lblDrops.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.lblQuests.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.lblQuests.AutoSize = true;
			this.lblQuests.Location = new global::System.Drawing.Point(137, 260);
			this.lblQuests.Name = "lblQuests";
			this.lblQuests.Size = new global::System.Drawing.Size(43, 13);
			this.lblQuests.TabIndex = 23;
			this.lblQuests.Text = "Quests:";
			this.lblQuests.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.lblSkills.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.lblSkills.AutoSize = true;
			this.lblSkills.Location = new global::System.Drawing.Point(87, 260);
			this.lblSkills.Name = "lblSkills";
			this.lblSkills.Size = new global::System.Drawing.Size(34, 13);
			this.lblSkills.TabIndex = 22;
			this.lblSkills.Text = "Skills:";
			this.lblSkills.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.lblCommands.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.lblCommands.AutoSize = true;
			this.lblCommands.Location = new global::System.Drawing.Point(6, 247);
			this.lblCommands.Name = "lblCommands";
			this.lblCommands.Size = new global::System.Drawing.Size(62, 26);
			this.lblCommands.TabIndex = 21;
			this.lblCommands.Text = "Number of\r\nCommands:";
			this.lblCommands.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.lblItems.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.lblItems.AutoSize = true;
			this.lblItems.Location = new global::System.Drawing.Point(313, 260);
			this.lblItems.Name = "lblItems";
			this.lblItems.Size = new global::System.Drawing.Size(35, 13);
			this.lblItems.TabIndex = 146;
			this.lblItems.Text = "Items:";
			this.lblItems.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.txtSavedDesc.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtSavedDesc.Location = new global::System.Drawing.Point(247, 85);
			this.txtSavedDesc.Multiline = true;
			this.txtSavedDesc.Name = "txtSavedDesc";
			this.txtSavedDesc.Size = new global::System.Drawing.Size(188, 157);
			this.txtSavedDesc.TabIndex = 20;
			this.txtSavedDesc.Text = "Description";
			this.txtSavedAuthor.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtSavedAuthor.Location = new global::System.Drawing.Point(247, 64);
			this.txtSavedAuthor.Name = "txtSavedAuthor";
			this.txtSavedAuthor.Size = new global::System.Drawing.Size(188, 20);
			this.txtSavedAuthor.TabIndex = 19;
			this.txtSavedAuthor.Text = "Author";
			this.lblBots.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblBots.AutoSize = true;
			this.lblBots.Location = new global::System.Drawing.Point(242, 50);
			this.lblBots.Name = "lblBots";
			this.lblBots.Size = new global::System.Drawing.Size(83, 13);
			this.lblBots.TabIndex = 18;
			this.lblBots.Text = "Number of Bots:";
			this.treeBots.AllowDrop = true;
			this.treeBots.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.treeBots.Location = new global::System.Drawing.Point(4, 27);
			this.treeBots.Name = "treeBots";
			this.treeBots.Size = new global::System.Drawing.Size(237, 215);
			this.treeBots.TabIndex = 17;
			this.treeBots.AfterExpand += new global::System.Windows.Forms.TreeViewEventHandler(this.treeBots_AfterExpand);
			this.treeBots.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeBots_AfterSelect);
			this.txtSavedAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtSavedAdd.Location = new global::System.Drawing.Point(247, 27);
			this.txtSavedAdd.Name = "txtSavedAdd";
			this.txtSavedAdd.Size = new global::System.Drawing.Size(121, 20);
			this.txtSavedAdd.TabIndex = 16;
			this.btnSavedAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSavedAdd.Location = new global::System.Drawing.Point(371, 27);
			this.btnSavedAdd.Name = "btnSavedAdd";
			this.btnSavedAdd.Size = new global::System.Drawing.Size(64, 22);
			this.btnSavedAdd.TabIndex = 15;
			this.btnSavedAdd.Text = "Add folder";
			this.btnSavedAdd.UseVisualStyleBackColor = true;
			this.btnSavedAdd.Click += new global::System.EventHandler(this.btnSavedAdd_Click);
			this.txtSaved.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtSaved.Location = new global::System.Drawing.Point(4, 4);
			this.txtSaved.Name = "txtSaved";
			this.txtSaved.Size = new global::System.Drawing.Size(431, 20);
			this.txtSaved.TabIndex = 13;
			this.txtSaved.TextChanged += new global::System.EventHandler(this.txtSaved_TextChanged);
			this.splitContainer1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 252);
			this.splitContainer1.Margin = new global::System.Windows.Forms.Padding(4);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.panel3);
			this.splitContainer1.Panel1.Controls.Add(this.cbLists);
			this.splitContainer1.Panel1.Controls.Add(this.chkAll);
			this.splitContainer1.Panel1.Controls.Add(this.btnClear);
			this.splitContainer1.Panel1MinSize = 0;
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Panel2.Controls.Add(this.btnRemove);
			this.splitContainer1.Panel2.Controls.Add(this.btnBotStop);
			this.splitContainer1.Panel2.Controls.Add(this.btnBotStart);
			this.splitContainer1.Panel2MinSize = 0;
			this.splitContainer1.Size = new global::System.Drawing.Size(238, 75);
			this.splitContainer1.SplitterDistance = 118;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 149;
			this.panel3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel3.Controls.Add(this.btnDown);
			this.panel3.Location = new global::System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(116, 22);
			this.panel3.TabIndex = 148;
			this.btnDown.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnDown.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnDown.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnDown.Location = new global::System.Drawing.Point(0, 0);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new global::System.Drawing.Size(116, 22);
			this.btnDown.TabIndex = 166;
			this.btnDown.Text = "▼";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new global::System.EventHandler(this.btnDown_Click);
			this.cbLists.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.cbLists.FormattingEnabled = true;
			this.cbLists.Items.AddRange(new object[]
			{
				"Commands",
				"Skills",
				"Quests",
				"Drops",
				"Boosts",
				"Items"
			});
			this.cbLists.Location = new global::System.Drawing.Point(1, 51);
			this.cbLists.Name = "cbLists";
			this.cbLists.Size = new global::System.Drawing.Size(115, 21);
			this.cbLists.TabIndex = 169;
			this.cbLists.SelectedIndexChanged += new global::System.EventHandler(this.cbLists_SelectedIndexChanged);
			this.chkAll.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.chkAll.AutoSize = true;
			this.chkAll.Location = new global::System.Drawing.Point(79, 29);
			this.chkAll.Name = "chkAll";
			this.chkAll.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.chkAll.Size = new global::System.Drawing.Size(36, 17);
			this.chkAll.TabIndex = 168;
			this.chkAll.Text = "all";
			this.chkAll.UseVisualStyleBackColor = true;
			this.btnClear.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnClear.Location = new global::System.Drawing.Point(0, 26);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(79, 22);
			this.btnClear.TabIndex = 167;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			this.panel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel2.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel2.Controls.Add(this.btnUp);
			this.panel2.Location = new global::System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(116, 22);
			this.panel2.TabIndex = 147;
			this.btnUp.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnUp.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnUp.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnUp.Location = new global::System.Drawing.Point(0, 0);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new global::System.Drawing.Size(116, 22);
			this.btnUp.TabIndex = 165;
			this.btnUp.Text = "▲";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new global::System.EventHandler(this.btnUp_Click);
			this.btnRemove.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRemove.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnRemove.Location = new global::System.Drawing.Point(1, 25);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new global::System.Drawing.Size(115, 22);
			this.btnRemove.TabIndex = 166;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new global::System.EventHandler(this.btnRemove_Click);
			this.btnBotStop.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBotStop.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnBotStop.Location = new global::System.Drawing.Point(1, 50);
			this.btnBotStop.Name = "btnBotStop";
			this.btnBotStop.Size = new global::System.Drawing.Size(115, 22);
			this.btnBotStop.TabIndex = 168;
			this.btnBotStop.Text = "Stop";
			this.btnBotStop.UseVisualStyleBackColor = true;
			this.btnBotStop.Visible = false;
			this.btnBotStop.Click += new global::System.EventHandler(this.btnBotStop_Click);
			this.btnBotStart.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBotStart.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnBotStart.Location = new global::System.Drawing.Point(1, 50);
			this.btnBotStart.Name = "btnBotStart";
			this.btnBotStart.Size = new global::System.Drawing.Size(115, 22);
			this.btnBotStart.TabIndex = 167;
			this.btnBotStart.Text = "Start";
			this.btnBotStart.UseVisualStyleBackColor = true;
			this.btnBotStart.Click += new global::System.EventHandler(this.btnBotStart_ClickAsync);
			this.panel1.Controls.Add(this.splitContainer1);
			this.panel1.Controls.Add(this.lstCommands);
			this.panel1.Controls.Add(this.lstDrops);
			this.panel1.Controls.Add(this.lstBoosts);
			this.panel1.Controls.Add(this.lstQuests);
			this.panel1.Controls.Add(this.lstSkills);
			this.panel1.Controls.Add(this.lstItems);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(238, 325);
			this.panel1.TabIndex = 150;
			this.splitContainer2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new global::System.Drawing.Point(7, 7);
			this.splitContainer2.Margin = new global::System.Windows.Forms.Padding(10);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Panel1.Controls.Add(this.panel1);
			this.splitContainer2.Panel1MinSize = 30;
			this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer2.Size = new global::System.Drawing.Size(694, 325);
			this.splitContainer2.SplitterDistance = 238;
			this.splitContainer2.TabIndex = 150;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Enabled = false;
			this.checkBox1.Location = new global::System.Drawing.Point(150, 184);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(82, 17);
			this.checkBox1.TabIndex = 158;
			this.checkBox1.Text = "Placeholder";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.chkBuffup.Location = new global::System.Drawing.Point(0, 0);
			this.chkBuffup.Name = "chkBuffup";
			this.chkBuffup.Size = new global::System.Drawing.Size(104, 24);
			this.chkBuffup.TabIndex = 0;
			this.BotManagerMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.changeFontsToolStripMenuItem,
				this.multilineToggleToolStripMenuItem,
				this.toggleTabpagesToolStripMenuItem,
				this.commandColorsToolStripMenuItem
			});
			this.BotManagerMenuStrip.Name = "contextMenuStrip1";
			this.BotManagerMenuStrip.Size = new global::System.Drawing.Size(195, 92);
			this.changeFontsToolStripMenuItem.Name = "changeFontsToolStripMenuItem";
			this.changeFontsToolStripMenuItem.Size = new global::System.Drawing.Size(194, 22);
			this.changeFontsToolStripMenuItem.Text = "Change Fonts";
			this.changeFontsToolStripMenuItem.Click += new global::System.EventHandler(this.changeFontsToolStripMenuItem_Click);
			this.multilineToggleToolStripMenuItem.Name = "multilineToggleToolStripMenuItem";
			this.multilineToggleToolStripMenuItem.Size = new global::System.Drawing.Size(194, 22);
			this.multilineToggleToolStripMenuItem.Text = "Multiline Toggle";
			this.multilineToggleToolStripMenuItem.Click += new global::System.EventHandler(this.multilineToggleToolStripMenuItem_Click);
			this.toggleTabpagesToolStripMenuItem.Name = "toggleTabpagesToolStripMenuItem";
			this.toggleTabpagesToolStripMenuItem.Size = new global::System.Drawing.Size(194, 22);
			this.toggleTabpagesToolStripMenuItem.Text = "Toggle Tabpages";
			this.toggleTabpagesToolStripMenuItem.Click += new global::System.EventHandler(this.toggleTabpagesToolStripMenuItem_Click);
			this.commandColorsToolStripMenuItem.Name = "commandColorsToolStripMenuItem";
			this.commandColorsToolStripMenuItem.Size = new global::System.Drawing.Size(194, 22);
			this.commandColorsToolStripMenuItem.Text = "Command Customizer";
			this.commandColorsToolStripMenuItem.Click += new global::System.EventHandler(this.commandColorsToolStripMenuItem_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(708, 339);
			this.ContextMenuStrip = this.BotManagerMenuStrip;
			base.Controls.Add(this.splitContainer2);
			this.ForeColor = global::System.Drawing.SystemColors.ControlText;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "BotManager";
			base.Padding = new global::System.Windows.Forms.Padding(7);
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Show;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = " Bot";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.BotManager_FormClosing);
			base.Load += new global::System.EventHandler(this.BotManager_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabCombat.ResumeLayout(false);
			this.pnlCombat.ResumeLayout(false);
			this.pnlCombat.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numRestMP).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numRest).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numSkillD).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numSafe).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numSkill).EndInit();
			this.tabItem.ResumeLayout(false);
			this.pnlItem.ResumeLayout(false);
			this.pnlItem.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numDropDelay).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numShopId).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numMapItem).EndInit();
			this.tabMap.ResumeLayout(false);
			this.pnlMap.ResumeLayout(false);
			this.pnlMap.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numWalkY).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numWalkX).EndInit();
			this.tabQuest.ResumeLayout(false);
			this.pnlQuest.ResumeLayout(false);
			this.pnlQuest.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numEnsureTries).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numQuestItem).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numQuestID).EndInit();
			this.tabMisc.ResumeLayout(false);
			this.pnlMisc.ResumeLayout(false);
			this.pnlMisc.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numSetInt).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numIndexCmd).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBeepTimes).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numDelay).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBotDelay).EndInit();
			this.tabOptions.ResumeLayout(false);
			this.pnlOptions.ResumeLayout(false);
			this.pnlOptions.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numOptionsTimer).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numWalkSpeed).EndInit();
			this.grpLogin.ResumeLayout(false);
			this.grpLogin.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numRelogDelay).EndInit();
			this.tabOptions2.ResumeLayout(false);
			this.tabOptions2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numSetLevel).EndInit();
			this.grpAccessLevel.ResumeLayout(false);
			this.grpAccessLevel.PerformLayout();
			this.grpAlignment.ResumeLayout(false);
			this.tabBots.ResumeLayout(false);
			this.pnlSaved.ResumeLayout(false);
			this.pnlSaved.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.BotManagerMenuStrip.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000015 RID: 21
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000017 RID: 23
		public global::System.Windows.Forms.ListBox lstCommands;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ListBox lstSkills;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ListBox lstQuests;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ListBox lstDrops;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ListBox lstBoosts;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ListBox lstItems;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.TabPage tabCombat;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Panel pnlCombat;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button btnUseSkillSet;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Button btnAddSkillSet;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.TextBox txtSkillSet;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.CheckBox chkSafeMp;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Button btnRest;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Button btnRestF;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.CheckBox chkSkillCD;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Button btnKill;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.CheckBox chkExistQuest;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.NumericUpDown numRestMP;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.CheckBox chkMP;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.NumericUpDown numRest;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.CheckBox chkHP;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.CheckBox chkPacket;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.NumericUpDown numSkillD;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.NumericUpDown numSafe;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Button btnAddSafe;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Button btnAddSkill;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.NumericUpDown numSkill;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.CheckBox chkExitRest;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.CheckBox chkAllSkillsCD;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.TextBox txtKillFQ;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.TextBox txtKillFItem;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.TextBox txtKillFMon;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.RadioButton rbTemp;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.RadioButton rbItems;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Button btnKillF;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.TextBox txtMonster;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Panel pnlItem;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.TextBox txtShopItem;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.NumericUpDown numShopId;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label15;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Button btnBuy;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Button btnBuyFast;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Button btnLoadShop;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Button btnBoost;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.ComboBox cbBoosts;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.NumericUpDown numMapItem;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Button btnMapItem;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Button btnSwap;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.TextBox txtSwapInv;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.TextBox txtSwapBank;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.CheckBox chkPickup;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Button btnBoth;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.TextBox txtWhitelist;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Button btnItem;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Button btnUnbanklst;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.TextBox txtItem;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.ComboBox cbItemCmds;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.TabPage tabMap;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Panel pnlMap;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Button btnWalkCur;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Button btnWalk;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.NumericUpDown numWalkY;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.NumericUpDown numWalkX;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Button btnCellSwap;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Button btnJump;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Button btnCurrCell;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.TextBox txtPad;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.TextBox txtCell;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Button btnJoin;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.TextBox txtJoinPad;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.TextBox txtJoinCell;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.TextBox txtJoin;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.TabPage tabQuest;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Panel pnlQuest;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Button btnQuestAccept;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Button btnQuestComplete;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Button btnQuestAdd;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.NumericUpDown numQuestItem;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.CheckBox chkQuestItem;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.NumericUpDown numQuestID;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.TabPage tabMisc;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Panel pnlMisc;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.CheckBox chkRestartDeath;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.CheckBox chkMerge;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Button btnLogout;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.TextBox txtLabel;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.Button btnGotoLabel;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Button btnAddLabel;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.TextBox txtDescription;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.TextBox txtAuthor;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Button btnDelay;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.NumericUpDown numDelay;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.NumericUpDown numBotDelay;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Button btnBotDelay;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.TextBox txtPlayer;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Button btnGoto;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Button btnLoad;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Button btnRestart;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Button btnStop;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Button btnLoadCmd;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.CheckBox chkSkip;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Button btnStatementAdd;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.TextBox txtStatement2;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.TextBox txtStatement1;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.ComboBox cbStatement;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.ComboBox cbCategories;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.TextBox txtPacket;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Button btnPacket;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.TabPage tabOptions;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Panel pnlOptions;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.CheckBox chkEnableSettings;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.CheckBox chkDisableAnims;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.TextBox txtSoundItem;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Button btnSoundAdd;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.Button btnSoundDelete;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Button btnSoundTest;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.ListBox lstSoundItems;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.NumericUpDown numWalkSpeed;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.CheckBox chkSkipCutscenes;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.CheckBox chkHidePlayers;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.CheckBox chkLag;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.CheckBox chkMagnet;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.CheckBox chkProvoke;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.CheckBox chkInfiniteRange;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.GroupBox grpLogin;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.ComboBox cbServers;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.CheckBox chkRelogRetry;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.CheckBox chkRelog;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.NumericUpDown numRelogDelay;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.TextBox txtUsername;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.TextBox txtGuild;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.Button btnchangeName;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.Button btnchangeGuild;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.CheckBox chkGender;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.TabPage tabBots;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Panel pnlSaved;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.Label lblBoosts;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Label lblDrops;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.Label lblQuests;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Label lblSkills;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.Label lblCommands;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.Label lblItems;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.TextBox txtSavedDesc;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.TextBox txtSavedAuthor;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Label lblBots;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.TreeView treeBots;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.TextBox txtSavedAdd;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.Button btnSavedAdd;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.TextBox txtSaved;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.CheckBox chkBankOnStop;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.Label labelProvoke;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.Button btnProvoke;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.Button btnProvokeOn;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.Button btnProvokeOff;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.Button btnYulgar;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.ListBox lstLogText;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.Button btnLogDebug;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.Button btnLog;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.TextBox txtLog;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.CheckBox chkUntarget;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.NumericUpDown numOptionsTimer;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.CheckBox chkEnsureComplete;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.NumericUpDown numEnsureTries;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Button btnWalkRdm;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.Button btnBlank;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.CheckBox chkRejectAll;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.CheckBox chkPickupAll;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.CheckBox chkReject;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.CheckBox chkBuff;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.CheckBox chkAFK;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.ComboBox cbLists;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.CheckBox chkAll;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Button btnClear;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Button btnDown;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.Button btnRemove;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.Button btnUp;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.Button btnBotStop;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Button btnBotStart;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.SplitContainer splitContainer2;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.Button btnCurrBlank;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.Button btnSetSpawn;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.Button btnBeep;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.NumericUpDown numBeepTimes;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.Button btnWhitelist;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.Button btnSkillCmd;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.TabPage tabItem;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.CheckBox chkBuffup;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.TabPage tabOptions2;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.Button btnSetUndecided;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.Button btnSetChaos;

		// Token: 0x040000EF RID: 239
		private global::System.Windows.Forms.Button btnSetEvil;

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.Forms.Button btnSetGood;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Forms.GroupBox grpAlignment;

		// Token: 0x040000F2 RID: 242
		private global::System.Windows.Forms.GroupBox grpAccessLevel;

		// Token: 0x040000F3 RID: 243
		private global::System.Windows.Forms.Button btnSetMem;

		// Token: 0x040000F4 RID: 244
		private global::System.Windows.Forms.Button btnSetModerator;

		// Token: 0x040000F5 RID: 245
		private global::System.Windows.Forms.Button btnSetNonMem;

		// Token: 0x040000F6 RID: 246
		private global::System.Windows.Forms.CheckBox chkToggleMute;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.ContextMenuStrip BotManagerMenuStrip;

		// Token: 0x040000F8 RID: 248
		private global::System.Windows.Forms.ToolStripMenuItem changeFontsToolStripMenuItem;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000FA RID: 250
		private global::System.Windows.Forms.NumericUpDown numDropDelay;

		// Token: 0x040000FB RID: 251
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040000FC RID: 252
		private global::System.Windows.Forms.Button btnGoDownIndex;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.Button btnGoUpIndex;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.Button btnGotoIndex;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.NumericUpDown numIndexCmd;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.ToolStripMenuItem multilineToggleToolStripMenuItem;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.ToolStripMenuItem toggleTabpagesToolStripMenuItem;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.ToolStripMenuItem commandColorsToolStripMenuItem;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.Button btnChangeNameCmd;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.Button btnChangeGuildCmd;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.CheckBox chkAntiAfk;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.CheckBox chkChangeRoomTag;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.CheckBox chkChangeChat;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.NumericUpDown numSetLevel;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.CheckBox chkSetJoinLevel;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.Button btnClientPacket;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.CheckBox chkHideYulgarPlayers;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.NumericUpDown numSetInt;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.TextBox txtSetInt;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.Button btnSetInt;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.Button btnDecreaseInt;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.Button btnIncreaseInt;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.Button btnAttack;
	}
}
