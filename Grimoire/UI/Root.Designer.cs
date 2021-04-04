namespace Grimoire.UI
{
	// Token: 0x0200004B RID: 75
	public partial class Root : global::System.Windows.Forms.Form
	{
		// Token: 0x06000218 RID: 536 RVA: 0x000035AD File Offset: 0x000017AD
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00022EEC File Offset: 0x000210EC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.Root));
			this.nTray = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.cbPads = new global::System.Windows.Forms.ComboBox();
			this.cbCells = new global::System.Windows.Forms.ComboBox();
			this.btnBank = new global::System.Windows.Forms.Button();
			this.btnBankReload = new global::System.Windows.Forms.Button();
			this.prgLoader = new global::System.Windows.Forms.ProgressBar();
			this.MenuMain = new global::System.Windows.Forms.MenuStrip();
			this.botToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fastTravelsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.loadersgrabbersToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.hotkeysToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pluginManagerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cosmeticsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bankToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.browserToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.setsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.packetsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.snifferToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.spammerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tampererToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.logsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.notepadToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.discordToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.botRequestToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.grimoireSuggestionsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.numFPS = new global::System.Windows.Forms.NumericUpDown();
			this.btnFPS = new global::System.Windows.Forms.Button();
			this.flashPlayer = new global::AxShockwaveFlashObjects.AxShockwaveFlash();
			this.btnJump = new global::System.Windows.Forms.Button();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.btnStart = new global::System.Windows.Forms.Button();
			this.eyeDropper1 = new global::Unity3.Eyedropper.EyeDropper();
			this.eyeDropperToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MenuMain.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numFPS).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.flashPlayer).BeginInit();
			base.SuspendLayout();
			this.nTray.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("nTray.Icon");
			this.nTray.Text = "Grimoire";
			this.nTray.Visible = true;
			this.nTray.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.nTray_MouseClick);
			this.cbPads.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.cbPads.FormattingEnabled = true;
			this.cbPads.Items.AddRange(new object[]
			{
				"Center",
				"Spawn",
				"Left",
				"Right",
				"Top",
				"Bottom",
				"Up",
				"Down"
			});
			this.cbPads.Location = new global::System.Drawing.Point(786, 2);
			this.cbPads.Name = "cbPads";
			this.cbPads.Size = new global::System.Drawing.Size(91, 21);
			this.cbPads.TabIndex = 17;
			this.cbCells.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.cbCells.FormattingEnabled = true;
			this.cbCells.Location = new global::System.Drawing.Point(689, 2);
			this.cbCells.Name = "cbCells";
			this.cbCells.Size = new global::System.Drawing.Size(91, 21);
			this.cbCells.TabIndex = 18;
			this.cbCells.Click += new global::System.EventHandler(this.cbCells_Click);
			this.btnBank.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBank.Location = new global::System.Drawing.Point(882, 1);
			this.btnBank.Name = "btnBank";
			this.btnBank.Size = new global::System.Drawing.Size(75, 23);
			this.btnBank.TabIndex = 20;
			this.btnBank.Text = "Bank";
			this.btnBank.UseVisualStyleBackColor = true;
			this.btnBank.Click += new global::System.EventHandler(this.btnBank_Click);
			this.btnBankReload.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBankReload.Location = new global::System.Drawing.Point(957, 1);
			this.btnBankReload.Name = "btnBankReload";
			this.btnBankReload.Size = new global::System.Drawing.Size(5, 23);
			this.btnBankReload.TabIndex = 25;
			this.btnBankReload.UseVisualStyleBackColor = true;
			this.btnBankReload.Click += new global::System.EventHandler(this.btnBankReload_Click);
			this.prgLoader.Location = new global::System.Drawing.Point(12, 276);
			this.prgLoader.Name = "prgLoader";
			this.prgLoader.Size = new global::System.Drawing.Size(936, 23);
			this.prgLoader.TabIndex = 21;
			this.MenuMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.botToolStripMenuItem,
				this.toolsToolStripMenuItem,
				this.packetsToolStripMenuItem,
				this.logsToolStripMenuItem,
				this.notepadToolStripMenuItem,
				this.helpToolStripMenuItem
			});
			this.MenuMain.Location = new global::System.Drawing.Point(0, 0);
			this.MenuMain.Name = "MenuMain";
			this.MenuMain.Size = new global::System.Drawing.Size(960, 24);
			this.MenuMain.TabIndex = 22;
			this.MenuMain.Text = "menuStrip";
			this.botToolStripMenuItem.Name = "botToolStripMenuItem";
			this.botToolStripMenuItem.Size = new global::System.Drawing.Size(37, 20);
			this.botToolStripMenuItem.Text = "Bot";
			this.botToolStripMenuItem.Click += new global::System.EventHandler(this.botToolStripMenuItem_Click);
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fastTravelsToolStripMenuItem,
				this.loadersgrabbersToolStripMenuItem,
				this.hotkeysToolStripMenuItem,
				this.pluginManagerToolStripMenuItem,
				this.cosmeticsToolStripMenuItem,
				this.bankToolStripMenuItem,
				this.browserToolStripMenuItem,
				this.setsToolStripMenuItem,
				this.eyeDropperToolStripMenuItem
			});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new global::System.Drawing.Size(46, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			this.fastTravelsToolStripMenuItem.Name = "fastTravelsToolStripMenuItem";
			this.fastTravelsToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.fastTravelsToolStripMenuItem.Text = "Fast travels";
			this.fastTravelsToolStripMenuItem.Click += new global::System.EventHandler(this.fastTravelsToolStripMenuItem_Click);
			this.loadersgrabbersToolStripMenuItem.Name = "loadersgrabbersToolStripMenuItem";
			this.loadersgrabbersToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.loadersgrabbersToolStripMenuItem.Text = "Loaders/grabbers";
			this.loadersgrabbersToolStripMenuItem.Click += new global::System.EventHandler(this.loadersgrabbersToolStripMenuItem_Click);
			this.hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
			this.hotkeysToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.hotkeysToolStripMenuItem.Text = "Hotkeys";
			this.hotkeysToolStripMenuItem.Click += new global::System.EventHandler(this.hotkeysToolStripMenuItem_Click);
			this.pluginManagerToolStripMenuItem.Name = "pluginManagerToolStripMenuItem";
			this.pluginManagerToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.pluginManagerToolStripMenuItem.Text = "Plugin manager";
			this.pluginManagerToolStripMenuItem.Click += new global::System.EventHandler(this.pluginManagerToolStripMenuItem_Click);
			this.cosmeticsToolStripMenuItem.Name = "cosmeticsToolStripMenuItem";
			this.cosmeticsToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.cosmeticsToolStripMenuItem.Text = "Cosmetics";
			this.cosmeticsToolStripMenuItem.Click += new global::System.EventHandler(this.cosmeticsToolStripMenuItem_Click);
			this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
			this.bankToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.bankToolStripMenuItem.Text = "Bank";
			this.bankToolStripMenuItem.Click += new global::System.EventHandler(this.bankToolStripMenuItem_Click);
			this.browserToolStripMenuItem.Enabled = false;
			this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
			this.browserToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.browserToolStripMenuItem.Text = "Browser";
			this.browserToolStripMenuItem.Visible = false;
			this.setsToolStripMenuItem.Enabled = false;
			this.setsToolStripMenuItem.Name = "setsToolStripMenuItem";
			this.setsToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.setsToolStripMenuItem.Text = "Sets";
			this.setsToolStripMenuItem.Click += new global::System.EventHandler(this.setsToolStripMenuItem_Click);
			this.packetsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.snifferToolStripMenuItem,
				this.spammerToolStripMenuItem,
				this.tampererToolStripMenuItem
			});
			this.packetsToolStripMenuItem.Name = "packetsToolStripMenuItem";
			this.packetsToolStripMenuItem.Size = new global::System.Drawing.Size(59, 20);
			this.packetsToolStripMenuItem.Text = "Packets";
			this.snifferToolStripMenuItem.Name = "snifferToolStripMenuItem";
			this.snifferToolStripMenuItem.Size = new global::System.Drawing.Size(125, 22);
			this.snifferToolStripMenuItem.Text = "Sniffer";
			this.snifferToolStripMenuItem.Click += new global::System.EventHandler(this.snifferToolStripMenuItem_Click);
			this.spammerToolStripMenuItem.Name = "spammerToolStripMenuItem";
			this.spammerToolStripMenuItem.Size = new global::System.Drawing.Size(125, 22);
			this.spammerToolStripMenuItem.Text = "Spammer";
			this.spammerToolStripMenuItem.Click += new global::System.EventHandler(this.spammerToolStripMenuItem_Click);
			this.tampererToolStripMenuItem.Name = "tampererToolStripMenuItem";
			this.tampererToolStripMenuItem.Size = new global::System.Drawing.Size(125, 22);
			this.tampererToolStripMenuItem.Text = "Tamperer";
			this.tampererToolStripMenuItem.Click += new global::System.EventHandler(this.tampererToolStripMenuItem_Click);
			this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
			this.logsToolStripMenuItem.Size = new global::System.Drawing.Size(44, 20);
			this.logsToolStripMenuItem.Text = "Logs";
			this.logsToolStripMenuItem.Click += new global::System.EventHandler(this.logsToolStripMenuItem_Click);
			this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
			this.notepadToolStripMenuItem.Size = new global::System.Drawing.Size(65, 20);
			this.notepadToolStripMenuItem.Text = "Notepad";
			this.notepadToolStripMenuItem.Click += new global::System.EventHandler(this.notepadToolStripMenuItem_Click);
			this.helpToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.discordToolStripMenuItem,
				this.botRequestToolStripMenuItem,
				this.grimoireSuggestionsToolStripMenuItem
			});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new global::System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
			this.discordToolStripMenuItem.Size = new global::System.Drawing.Size(187, 22);
			this.discordToolStripMenuItem.Text = "Discord";
			this.discordToolStripMenuItem.Click += new global::System.EventHandler(this.discordToolStripMenuItem_Click);
			this.botRequestToolStripMenuItem.Name = "botRequestToolStripMenuItem";
			this.botRequestToolStripMenuItem.Size = new global::System.Drawing.Size(187, 22);
			this.botRequestToolStripMenuItem.Text = "Bot Request";
			this.botRequestToolStripMenuItem.Click += new global::System.EventHandler(this.botRequestToolStripMenuItem_Click);
			this.grimoireSuggestionsToolStripMenuItem.Name = "grimoireSuggestionsToolStripMenuItem";
			this.grimoireSuggestionsToolStripMenuItem.Size = new global::System.Drawing.Size(187, 22);
			this.grimoireSuggestionsToolStripMenuItem.Text = "Grimoire Suggestions";
			this.grimoireSuggestionsToolStripMenuItem.Click += new global::System.EventHandler(this.grimoireSuggestionsToolStripMenuItem_Click);
			this.numFPS.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.numFPS.Location = new global::System.Drawing.Point(586, 3);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numFPS;
			int[] array = new int[4];
			array[0] = 200;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numFPS;
			int[] array2 = new int[4];
			array2[0] = 10;
			numericUpDown2.Minimum = new decimal(array2);
			this.numFPS.Name = "numFPS";
			this.numFPS.Size = new global::System.Drawing.Size(43, 20);
			this.numFPS.TabIndex = 23;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numFPS;
			int[] array3 = new int[4];
			array3[0] = 60;
			numericUpDown3.Value = new decimal(array3);
			this.btnFPS.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnFPS.Location = new global::System.Drawing.Point(526, 2);
			this.btnFPS.Name = "btnFPS";
			this.btnFPS.Size = new global::System.Drawing.Size(57, 23);
			this.btnFPS.TabIndex = 24;
			this.btnFPS.Text = "Set FPS";
			this.btnFPS.UseVisualStyleBackColor = true;
			this.btnFPS.Click += new global::System.EventHandler(this.btnFPS_Click);
			this.flashPlayer.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flashPlayer.Enabled = true;
			this.flashPlayer.Location = new global::System.Drawing.Point(0, 25);
			this.flashPlayer.Name = "flashPlayer";
			this.flashPlayer.OcxState = (global::System.Windows.Forms.AxHost.State)componentResourceManager.GetObject("flashPlayer.OcxState");
			this.flashPlayer.Size = new global::System.Drawing.Size(960, 550);
			this.flashPlayer.TabIndex = 2;
			this.flashPlayer.Visible = false;
			this.btnJump.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnJump.ImageAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.btnJump.Location = new global::System.Drawing.Point(630, 1);
			this.btnJump.Name = "btnJump";
			this.btnJump.Size = new global::System.Drawing.Size(53, 23);
			this.btnJump.TabIndex = 28;
			this.btnJump.Text = "Jump";
			this.btnJump.UseVisualStyleBackColor = true;
			this.btnJump.Click += new global::System.EventHandler(this.btnJump_Click);
			this.btnStop.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnStop.Location = new global::System.Drawing.Point(470, 2);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(57, 23);
			this.btnStop.TabIndex = 24;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new global::System.EventHandler(this.btnStop_ClickAsync);
			this.btnStart.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnStart.Location = new global::System.Drawing.Point(469, 2);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new global::System.Drawing.Size(57, 23);
			this.btnStart.TabIndex = 24;
			this.btnStart.Text = "Start bot";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new global::System.EventHandler(this.btnStart_Click);
			this.eyeDropper1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.eyeDropper1.Location = new global::System.Drawing.Point(445, 3);
			this.eyeDropper1.MaximumSize = new global::System.Drawing.Size(22, 22);
			this.eyeDropper1.MinimumSize = new global::System.Drawing.Size(22, 22);
			this.eyeDropper1.Name = "eyeDropper1";
			this.eyeDropper1.PixelPreviewSize = new global::System.Drawing.Size(100, 50);
			this.eyeDropper1.PixelPreviewZoom = 5f;
			this.eyeDropper1.PreviewLocation = new global::System.Drawing.Point(0, 0);
			this.eyeDropper1.PreviewPositionStyle = global::Unity3.Eyedropper.EyeDropper.ePreviewPositionStyle.Centered;
			this.eyeDropper1.SelectedColor = global::System.Drawing.Color.Empty;
			this.eyeDropper1.Size = new global::System.Drawing.Size(22, 22);
			this.eyeDropper1.TabIndex = 29;
			this.eyeDropper1.Text = "eyeDropper1";
			this.eyeDropperToolStripMenuItem.Name = "eyeDropperToolStripMenuItem";
			this.eyeDropperToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.eyeDropperToolStripMenuItem.Text = "Eye Dropper";
			this.eyeDropperToolStripMenuItem.Click += new global::System.EventHandler(this.eyeDropperToolStripMenuItem_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(960, 575);
			base.Controls.Add(this.eyeDropper1);
			base.Controls.Add(this.btnJump);
			base.Controls.Add(this.btnStart);
			base.Controls.Add(this.btnStop);
			base.Controls.Add(this.btnFPS);
			base.Controls.Add(this.numFPS);
			base.Controls.Add(this.prgLoader);
			base.Controls.Add(this.btnBank);
			base.Controls.Add(this.btnBankReload);
			base.Controls.Add(this.cbCells);
			base.Controls.Add(this.cbPads);
			base.Controls.Add(this.flashPlayer);
			base.Controls.Add(this.MenuMain);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Root";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GrimLite 1";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Root_FormClosing);
			base.Load += new global::System.EventHandler(this.Root_Load);
			this.MenuMain.ResumeLayout(false);
			this.MenuMain.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numFPS).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.flashPlayer).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400023A RID: 570
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400023B RID: 571
		private global::System.Windows.Forms.NotifyIcon nTray;

		// Token: 0x0400023C RID: 572
		private global::AxShockwaveFlashObjects.AxShockwaveFlash flashPlayer;

		// Token: 0x0400023D RID: 573
		private global::System.Windows.Forms.ComboBox cbPads;

		// Token: 0x0400023E RID: 574
		private global::System.Windows.Forms.ComboBox cbCells;

		// Token: 0x0400023F RID: 575
		private global::System.Windows.Forms.Button btnBank;

		// Token: 0x04000240 RID: 576
		private global::System.Windows.Forms.ProgressBar prgLoader;

		// Token: 0x04000241 RID: 577
		private global::System.Windows.Forms.ToolStripMenuItem botToolStripMenuItem;

		// Token: 0x04000242 RID: 578
		private global::System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;

		// Token: 0x04000243 RID: 579
		private global::System.Windows.Forms.ToolStripMenuItem fastTravelsToolStripMenuItem;

		// Token: 0x04000244 RID: 580
		private global::System.Windows.Forms.ToolStripMenuItem loadersgrabbersToolStripMenuItem;

		// Token: 0x04000245 RID: 581
		private global::System.Windows.Forms.ToolStripMenuItem hotkeysToolStripMenuItem;

		// Token: 0x04000246 RID: 582
		public global::System.Windows.Forms.MenuStrip MenuMain;

		// Token: 0x04000247 RID: 583
		private global::System.Windows.Forms.ToolStripMenuItem pluginManagerToolStripMenuItem;

		// Token: 0x04000248 RID: 584
		private global::System.Windows.Forms.NumericUpDown numFPS;

		// Token: 0x04000249 RID: 585
		private global::System.Windows.Forms.Button btnFPS;

		// Token: 0x0400024A RID: 586
		private global::System.Windows.Forms.ToolStripMenuItem packetsToolStripMenuItem;

		// Token: 0x0400024B RID: 587
		private global::System.Windows.Forms.ToolStripMenuItem snifferToolStripMenuItem;

		// Token: 0x0400024C RID: 588
		private global::System.Windows.Forms.ToolStripMenuItem spammerToolStripMenuItem;

		// Token: 0x0400024D RID: 589
		private global::System.Windows.Forms.ToolStripMenuItem tampererToolStripMenuItem;

		// Token: 0x0400024E RID: 590
		private global::System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;

		// Token: 0x0400024F RID: 591
		private global::System.Windows.Forms.Button btnJump;

		// Token: 0x04000250 RID: 592
		private global::System.Windows.Forms.ToolStripMenuItem cosmeticsToolStripMenuItem;

		// Token: 0x04000251 RID: 593
		private global::System.Windows.Forms.ToolStripMenuItem bankToolStripMenuItem;

		// Token: 0x04000252 RID: 594
		private global::System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;

		// Token: 0x04000253 RID: 595
		private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

		// Token: 0x04000254 RID: 596
		private global::System.Windows.Forms.ToolStripMenuItem discordToolStripMenuItem;

		// Token: 0x04000255 RID: 597
		private global::System.Windows.Forms.ToolStripMenuItem botRequestToolStripMenuItem;

		// Token: 0x04000256 RID: 598
		private global::System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;

		// Token: 0x04000257 RID: 599
		private global::System.Windows.Forms.ToolStripMenuItem setsToolStripMenuItem;

		// Token: 0x04000258 RID: 600
		private global::System.Windows.Forms.ToolStripMenuItem grimoireSuggestionsToolStripMenuItem;

		// Token: 0x04000259 RID: 601
		private global::System.Windows.Forms.Button btnStop;

		// Token: 0x0400025A RID: 602
		private global::System.Windows.Forms.Button btnStart;

		// Token: 0x0400025B RID: 603
		private global::Unity3.Eyedropper.EyeDropper eyeDropper1;

		// Token: 0x0400025C RID: 604
		private global::System.Windows.Forms.ToolStripMenuItem eyeDropperToolStripMenuItem;

		// Token: 0x0400025D RID: 605
		private global::System.Windows.Forms.Button btnBankReload;
	}
}
