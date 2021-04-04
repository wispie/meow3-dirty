using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using Grimoire.Botting;
using Grimoire.Botting.Commands.Map;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.UI
{
	// Token: 0x02000028 RID: 40
	public partial class Hotkeys : Form
	{
		// Token: 0x06000139 RID: 313 RVA: 0x0001C3C8 File Offset: 0x0001A5C8
		private static async void BotToggleAsync()
		{
			if (Player.IsAlive && Player.IsLoggedIn && BotManager.Instance.lstCommands.Items.Count > 0 && BotManager.Instance.ActiveBotEngine.IsRunning)
			{
				BotManager.Instance.MultiMode();
				BotManager.Instance.ActiveBotEngine.IsRunningChanged += BotManager.Instance.OnIsRunningChanged;
				BotManager.Instance.ActiveBotEngine.IndexChanged += BotManager.Instance.OnIndexChanged;
				BotManager.Instance.ActiveBotEngine.ConfigurationChanged += BotManager.Instance.OnConfigurationChanged;
				BotManager.Instance.ActiveBotEngine.Start(BotManager.Instance.GenerateConfiguration());
				BotManager.Instance.BotStateChanged(true);
			}
			else
			{
				if (Configuration.Instance.Items != null && Configuration.Instance.BankOnStop)
				{
					foreach (InventoryItem inventoryItem in Player.Inventory.Items)
					{
						InventoryItem itemL = inventoryItem;
						if (!itemL.IsEquipped && itemL.IsAcItem && itemL.Category != "Class" && itemL.Name.ToLower() != "treasure potion" && Configuration.Instance.Items.Contains(itemL.Name))
						{
							Player.Bank.TransferToBank(itemL.Name);
							await Task.Delay(70);
							LogForm.Instance.AppendDebug("Transferred to Bank: " + itemL.Name + "\r\n");
						}
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
						itemL = null;
					}
					List<InventoryItem>.Enumerator enumerator = default(List<InventoryItem>.Enumerator);
					LogForm.Instance.AppendDebug("Banked all AC Items in Items list \r\n");
				}
				BotManager.Instance.ActiveBotEngine.Stop();
				BotManager.Instance.MultiMode();
				await Task.Delay(2000);
				BotManager.Instance.BotStateChanged(false);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002C9F File Offset: 0x00000E9F
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002D17 File Offset: 0x00000F17
		public static Hotkeys Instance { get; set; } = new Hotkeys();

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002CA6 File Offset: 0x00000EA6
		private string configPath
		{
			get
			{
				return Path.Combine(Application.StartupPath, "hotkeys.json");
			}
		}

		// Token: 0x0600013C RID: 316
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x0600013D RID: 317
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

		// Token: 0x0600013E RID: 318 RVA: 0x00002CB7 File Offset: 0x00000EB7
		private Hotkeys()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0001C3FC File Offset: 0x0001A5FC
		private void Hotkeys_Load(object sender, EventArgs e)
		{
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			string text = config.Get("font");
			float? num = new float?(float.Parse(config.Get("fontSize") ?? "8.25", CultureInfo.InvariantCulture.NumberFormat));
			this.lstKeys.DisplayMember = "Text";
			this.cbActions.SelectedIndex = 0;
			this.cbKeys.SelectedIndex = 0;
			if (text != null && num != null)
			{
				this.Font = new Font(text, num.Value, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002CC5 File Offset: 0x00000EC5
		private static CmdTravel CreateJoinCommand(string map, string cell = "Enter", string pad = "Spawn")
		{
			return new CmdTravel
			{
				Map = map,
				Cell = cell,
				Pad = pad
			};
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
		private static async void ExecuteTravel(List<IBotCommand> cmds)
		{
			foreach (IBotCommand botCommand in cmds)
			{
				await botCommand.Execute(null);
				await Task.Delay(1000);
			}
			List<IBotCommand>.Enumerator enumerator = default(List<IBotCommand>.Enumerator);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0001C4DC File Offset: 0x0001A6DC
		private void btnRemove_Click(object sender, EventArgs e)
		{
			Hotkey hotkey = (Hotkey)this.lstKeys.SelectedItem;
			if (hotkey != null)
			{
				hotkey.Uninstall();
				Hotkeys.InstalledHotkeys.Remove(hotkey);
				this.lstKeys.Items.Remove(hotkey);
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0001C520 File Offset: 0x0001A720
		private void btnAdd_Click(object sender, EventArgs e)
		{
			int selectedIndex = this.cbActions.SelectedIndex;
			if (selectedIndex > -1 && this.cbKeys.SelectedIndex > -1)
			{
				Keys keys = (Keys)Enum.Parse(typeof(Keys), this.cbKeys.SelectedItem.ToString());
				if (!KeyboardHook.Instance.TargetedKeys.Contains(keys))
				{
					Hotkey hotkey = new Hotkey
					{
						ActionIndex = selectedIndex,
						Key = keys,
						Text = string.Format("{0}: {1}", keys, this.cbActions.Items[selectedIndex])
					};
					hotkey.Install();
					Hotkeys.InstalledHotkeys.Add(hotkey);
					this.lstKeys.Items.Add(hotkey);
				}
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002CE1 File Offset: 0x00000EE1
		private void btnSave_Click(object sender, EventArgs e)
		{
			File.WriteAllText(this.configPath, JsonConvert.SerializeObject(Hotkeys.InstalledHotkeys));
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0001C5E8 File Offset: 0x0001A7E8
		public void LoadHotkeys()
		{
			if (File.Exists(this.configPath))
			{
				Hotkey[] array = JsonConvert.DeserializeObject<Hotkey[]>(File.ReadAllText(this.configPath));
				if (array != null)
				{
					Hotkeys.InstalledHotkeys.AddRange(array);
					foreach (Hotkey hotkey in Hotkeys.InstalledHotkeys)
					{
						this.lstKeys.Items.Add(hotkey);
						hotkey.Install();
					}
				}
			}
			KeyboardHook.Instance.KeyDown += this.OnKeyDown;
			this._processId = Process.GetCurrentProcess().Id;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
		public void OnKeyDown(Keys key)
		{
			Hotkey hotkey = Hotkeys.InstalledHotkeys.First((Hotkey h) => h.Key == key);
			if (this.ApplicationContainsFocus() || (string)this.cbActions.Items[hotkey.ActionIndex] == "Minimize to tray")
			{
				Hotkeys.Actions[hotkey.ActionIndex]();
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001C714 File Offset: 0x0001A914
		public bool ApplicationContainsFocus()
		{
			IntPtr foregroundWindow = Hotkeys.GetForegroundWindow();
			if (foregroundWindow == IntPtr.Zero)
			{
				return false;
			}
			int num;
			Hotkeys.GetWindowThreadProcessId(foregroundWindow, out num);
			return num == this._processId;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002190 File Offset: 0x00000390
		private void Hotkeys_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001D0D8 File Offset: 0x0001B2D8
		private static string BuildRequest(string method, params string[] args)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<invoke name=\"" + method + "\" returntype=\"xml\">");
			if (args != null && args.Length != 0)
			{
				stringBuilder.Append("<arguments>");
				foreach (string str in args)
				{
					stringBuilder.Append("<string>" + str + "</string>");
				}
				stringBuilder.Append("</arguments>");
			}
			stringBuilder.Append("</invoke>");
			return stringBuilder.ToString();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0001D160 File Offset: 0x0001B360
		public static string GetResponse(string request)
		{
			string result;
			try
			{
				XNode firstNode = XElement.Parse(Root.Instance.Client.CallFunction(request)).FirstNode;
				result = HttpUtility.HtmlDecode(((firstNode != null) ? firstNode.ToString() : null) ?? string.Empty);
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
		public static void GetPlayerCell()
		{
			string text = Flash.BuildRequest("GetCellPlayers", new string[]
			{
				"Reneid"
			});
			string response = Flash.GetResponse(text);
			Console.WriteLine(text + "\n\n" + response);
		}

		// Token: 0x0400017C RID: 380
		public static readonly Action[] Actions = new Action[]
		{
			delegate()
			{
				Root.Instance.ShowForm(BotManager.Instance);
			},
			delegate()
			{
				Root.Instance.ShowForm(Hotkeys.Instance);
			},
			delegate()
			{
				Root.Instance.ShowForm(Loaders.Instance);
			},
			delegate()
			{
				Root.Instance.ShowForm(PacketLogger.Instance);
			},
			delegate()
			{
				Root.Instance.ShowForm(PacketSpammer.Instance);
			},
			delegate()
			{
				Root.Instance.ShowForm(Travel.Instance);
			},
			delegate()
			{
				Root.Instance.ShowForm(Root.Instance);
			},
			delegate()
			{
				Player.Bank.Show();
			},
			delegate()
			{
				Root.Instance.ShowForm(CosmeticForm.Instance);
			},
			delegate()
			{
				Root.Instance.ShowForm(LogForm.Instance);
			},
			delegate()
			{
				Root.Instance.ShowForm(Notepad.Instance);
			},
			delegate()
			{
				Shop.LoadHairShop(1);
			},
			delegate()
			{
				Shop.LoadArmorCustomizer();
			},
			delegate()
			{
				Hotkeys.ExecuteTravel(new List<IBotCommand>
				{
					Hotkeys.CreateJoinCommand("yulgar-100000", "Room", "Center")
				});
			},
			async delegate()
			{
				string map = Player.Map;
				string mapnumber = World.RoomNumber.ToString();
				string cell = Player.Cell;
				string pad = Player.Pad;
				Player.Logout();
				await AutoRelogin.Login(new Server
				{
					Name = "Safiria"
				}, 3000, new CancellationTokenSource(), true);
				Hotkeys.ExecuteTravel(new List<IBotCommand>
				{
					Hotkeys.CreateJoinCommand(map + "-" + mapnumber, cell, pad)
				});
			},
			delegate()
			{
				Hotkeys.BotToggleAsync();
			},
			delegate()
			{
				if (OptionsManager.IsRunning)
				{
					OptionsManager.Start();
					return;
				}
				OptionsManager.Stop();
			},
			delegate()
			{
				Hotkeys.GetPlayerCell();
			}
		};

		// Token: 0x0400017D RID: 381
		public static readonly List<Hotkey> InstalledHotkeys = new List<Hotkey>();

		// Token: 0x0400017E RID: 382
		private int _processId;
	}
}
