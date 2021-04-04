using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxShockwaveFlashObjects;
using GrimEoLHook;
using Grimoire.Botting;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.Networking;
using Grimoire.Properties;
using Grimoire.Tools;
using Unity3.Eyedropper;

namespace Grimoire.UI
{
	// Token: 0x0200004B RID: 75
	public partial class Root : Form
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000204 RID: 516 RVA: 0x000034EA File Offset: 0x000016EA
		// (set) Token: 0x06000205 RID: 517 RVA: 0x000034F1 File Offset: 0x000016F1
		public static Root Instance { get; private set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000034F9 File Offset: 0x000016F9
		public AxShockwaveFlash Client
		{
			get
			{
				return this.flashPlayer;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00003501 File Offset: 0x00001701
		public Root()
		{
			EoLHook.Hook();
			this.InitializeComponent();
			Root.Instance = this;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00022C94 File Offset: 0x00020E94
		private void Root_Load(object sender, EventArgs e)
		{
			Task.Factory.StartNew<Task>(new Func<Task>(Proxy.Instance.Start), TaskCreationOptions.LongRunning);
			Flash.flash = this.flashPlayer;
			this.flashPlayer.FlashCall += Flash.ProcessFlashCall;
			this.flashPlayer.Visible = true;
			this.prgLoader.Visible = false;
			Hotkeys.Instance.LoadHotkeys();
			this.InitFlashMovie();
			Config.Load(Application.StartupPath + "\\config.cfg");
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000351A File Offset: 0x0000171A
		private void OnLoadProgress(int progress)
		{
			Flash.SwfLoadProgress -= this.OnLoadProgress;
			this.flashPlayer.Visible = true;
			this.prgLoader.Visible = false;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00003545 File Offset: 0x00001745
		private void botToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(BotManager.Instance);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00003552 File Offset: 0x00001752
		private void fastTravelsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(Travel.Instance);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000355F File Offset: 0x0000175F
		private void loadersgrabbersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(Loaders.Instance);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000356C File Offset: 0x0000176C
		private void hotkeysToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(Hotkeys.Instance);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00003579 File Offset: 0x00001779
		private void pluginManagerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(PluginManager.Instance);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00003586 File Offset: 0x00001786
		private void snifferToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(PacketLogger.Instance);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00003593 File Offset: 0x00001793
		private void spammerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(PacketSpammer.Instance);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000035A0 File Offset: 0x000017A0
		private void tampererToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(PacketTamperer.Instance);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00022D1C File Offset: 0x00020F1C
		public void ShowForm(Form form)
		{
			if (form.WindowState == FormWindowState.Minimized)
			{
				form.WindowState = FormWindowState.Normal;
				form.Show();
				form.BringToFront();
				form.Focus();
				return;
			}
			if (form.Visible)
			{
				form.Hide();
				return;
			}
			form.Show();
			form.BringToFront();
			form.Focus();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00022D70 File Offset: 0x00020F70
		private void InitFlashMovie()
		{
			byte[] aqlitegrimoire = Resources.aqlitegrimoire;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
				{
					binaryWriter.Write(8 + aqlitegrimoire.Length);
					binaryWriter.Write(1432769894);
					binaryWriter.Write(aqlitegrimoire.Length);
					binaryWriter.Write(aqlitegrimoire);
					memoryStream.Seek(0L, SeekOrigin.Begin);
					this.flashPlayer.OcxState = new AxHost.State(memoryStream, 1, false, null);
				}
			}
			EoLHook.Unhook();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002DA2 File Offset: 0x00000FA2
		private void btnBank_Click(object sender, EventArgs e)
		{
			Player.Bank.Show();
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00022E0C File Offset: 0x0002100C
		private void cbCells_Click(object sender, EventArgs e)
		{
			this.cbCells.Items.Clear();
			ComboBox.ObjectCollection items = this.cbCells.Items;
			object[] cells = World.Cells;
			object[] array = cells;
			object[] items2 = array;
			items.AddRange(items2);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00022E48 File Offset: 0x00021048
		private void btnFPS_Click(object sender, EventArgs e)
		{
			Flash.Call("SetFPS", new string[]
			{
				this.numFPS.Value.ToString()
			});
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00022E7C File Offset: 0x0002107C
		private void Root_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hotkeys.InstalledHotkeys.ForEach(delegate(Hotkey h)
			{
				h.Uninstall();
			});
			KeyboardHook.Instance.Dispose();
			Proxy.Instance.Stop(true);
			CommandColorForm.Instance.Dispose();
			this.nTray.Icon.Dispose();
			this.nTray.Dispose();
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000035CC File Offset: 0x000017CC
		private void Instance_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000035D3 File Offset: 0x000017D3
		private void btnBankReload_Click(object sender, EventArgs e)
		{
			Proxy.Instance.SendToServer(string.Format("%xt%zm%loadBank%{0}%All%", World.RoomId));
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000035F4 File Offset: 0x000017F4
		private void logsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(LogForm.Instance);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000240DC File Offset: 0x000222DC
		private void btnJump_Click(object sender, EventArgs e)
		{
			string text = (string)this.cbCells.SelectedItem;
			string text2 = (string)this.cbPads.SelectedItem;
			Player.MoveToCell(text ?? Player.Cell, text2 ?? Player.Pad);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00003601 File Offset: 0x00001801
		private void cosmeticsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(CosmeticForm.Instance);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000360E File Offset: 0x0000180E
		private void bankToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(BankForm.Instance);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000361B File Offset: 0x0000181B
		private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(Notepad.Instance);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00003628 File Offset: 0x00001828
		private void discordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.com/invite/aqwbots");
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00003635 File Offset: 0x00001835
		private void botRequestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSd2NSx1ezF-6bc2jRBuTniIka5z6kA2NbmC8CRCOFtpVxcRCA/viewform");
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00003642 File Offset: 0x00001842
		private void setsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowForm(Set.Instance);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000364F File Offset: 0x0000184F
		private void grimoireSuggestionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSetfV9zl18G9s7w_XReJ1yJNT9aZwxB1FLzU0l1UhdmXv5rIw/viewform?usp=sf_link");
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00024124 File Offset: 0x00022324
		private async void btnStop_ClickAsync(object sender, EventArgs e)
		{
			if (Configuration.Instance.Items != null && Configuration.Instance.BankOnStop)
			{
				foreach (InventoryItem item in Player.Inventory.Items)
				{
					if (!item.IsEquipped && item.IsAcItem && item.Category != "Class" && item.Name.ToLower() != "treasure potion" && Configuration.Instance.Items.Contains(item.Name))
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
			this.btnStart.Enabled = false;
			BotManager.Instance.ActiveBotEngine.Stop();
			BotManager.Instance.MultiMode();
			await Task.Delay(2000);
			BotManager.Instance.BotStateChanged(false);
			this.BotStateChanged(false);
			this.btnStart.Enabled = true;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000365C File Offset: 0x0000185C
		public void BotStateChanged(bool IsRunning)
		{
			if (IsRunning)
			{
				this.btnStart.Hide();
				this.btnStop.Show();
				return;
			}
			this.btnStop.Hide();
			this.btnStart.Show();
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00024160 File Offset: 0x00022360
		private void btnStart_Click(object sender, EventArgs e)
		{
			if (Player.IsAlive && Player.IsLoggedIn && BotManager.Instance.lstCommands.Items.Count > 0)
			{
				BotManager.Instance.MultiMode();
				BotManager.Instance.ActiveBotEngine.IsRunningChanged += BotManager.Instance.OnIsRunningChanged;
				BotManager.Instance.ActiveBotEngine.IndexChanged += BotManager.Instance.OnIndexChanged;
				BotManager.Instance.ActiveBotEngine.ConfigurationChanged += BotManager.Instance.OnConfigurationChanged;
				BotManager.Instance.ActiveBotEngine.Start(BotManager.Instance.GenerateConfiguration());
				BotManager.Instance.BotStateChanged(true);
				this.BotStateChanged(true);
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000368E File Offset: 0x0000188E
		private void nTray_MouseClick(object sender, MouseEventArgs e)
		{
			this.ShowForm(this);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002839 File Offset: 0x00000A39
		private void eyeDropperToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00003697 File Offset: 0x00001897
		private void eyeDropperToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.ShowForm(EyeDropper.Instance);
		}
	}
}
