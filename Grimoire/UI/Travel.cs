using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grimoire.Botting;
using Grimoire.Botting.Commands.Map;

namespace Grimoire.UI
{
	// Token: 0x02000056 RID: 86
	public partial class Travel : Form
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000037D7 File Offset: 0x000019D7
		public static Travel Instance { get; } = new Travel();

		// Token: 0x06000255 RID: 597 RVA: 0x000037DE File Offset: 0x000019DE
		private Travel()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002190 File Offset: 0x00000390
		private void Travel_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000037EC File Offset: 0x000019EC
		private void chkPriv_CheckedChanged(object sender, EventArgs e)
		{
			this.numPriv.Enabled = this.chkPriv.Checked;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000253BC File Offset: 0x000235BC
		private void btnTercess_Click(object sender, EventArgs e)
		{
			this.ExecuteTravel(new List<IBotCommand>
			{
				this.CreateJoinCommand("citadel", "m22", "Left"),
				this.CreateJoinCommand("tercessuinotlim", "Enter", "Spawn")
			});
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0002540C File Offset: 0x0002360C
		private void btnTwins_Click(object sender, EventArgs e)
		{
			this.ExecuteTravel(new List<IBotCommand>
			{
				this.CreateJoinCommand("citadel", "m22", "Left"),
				this.CreateJoinCommand("tercessuinotlim", "Twins", "Left")
			});
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0002545C File Offset: 0x0002365C
		private void btnTaro_Click(object sender, EventArgs e)
		{
			this.ExecuteTravel(new List<IBotCommand>
			{
				this.CreateJoinCommand("citadel", "m22", "Left"),
				this.CreateJoinCommand("tercessuinotlim", "Taro", "Left")
			});
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000254AC File Offset: 0x000236AC
		private void btnSwindle_Click(object sender, EventArgs e)
		{
			this.ExecuteTravel(new List<IBotCommand>
			{
				this.CreateJoinCommand("citadel", "m22", "Left"),
				this.CreateJoinCommand("tercessuinotlim", "Swindle", "Left")
			});
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000254FC File Offset: 0x000236FC
		private void btnNulgath_Click(object sender, EventArgs e)
		{
			this.ExecuteTravel(new List<IBotCommand>
			{
				this.CreateJoinCommand("citadel", "m22", "Left"),
				this.CreateJoinCommand("tercessuinotlim", "Boss2", "Right")
			});
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00003804 File Offset: 0x00001A04
		private void btnEscherion_Click(object sender, EventArgs e)
		{
			this.ExecuteTravel(new List<IBotCommand>
			{
				this.CreateJoinCommand("escherion", "Boss", "Left")
			});
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000382C File Offset: 0x00001A2C
		private void btnDage_Click(object sender, EventArgs e)
		{
			this.ExecuteTravel(new List<IBotCommand>
			{
				this.CreateJoinCommand("underworld", "s1", "Left")
			});
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0002554C File Offset: 0x0002374C
		private CmdTravel CreateJoinCommand(string map, string cell = "Enter", string pad = "Spawn")
		{
			return new CmdTravel
			{
				Map = (this.chkPriv.Checked ? (map + string.Format("-{0}", this.numPriv.Value)) : map),
				Cell = cell,
				Pad = pad
			};
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000255A4 File Offset: 0x000237A4
		private async void ExecuteTravel(List<IBotCommand> cmds)
		{
			this.grpTravel.Enabled = false;
			foreach (IBotCommand botCommand in cmds)
			{
				await botCommand.Execute(null);
				await Task.Delay(1000);
			}
			List<IBotCommand>.Enumerator enumerator = default(List<IBotCommand>.Enumerator);
			if (base.InvokeRequired)
			{
				base.Invoke(new Action(delegate()
				{
					this.grpTravel.Enabled = true;
				}));
			}
			else
			{
				this.grpTravel.Enabled = true;
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000387F File Offset: 0x00001A7F
		private void btnBinky_Click(object sender, EventArgs e)
		{
			this.ExecuteTravel(new List<IBotCommand>
			{
				this.CreateJoinCommand("doomvault", "r5", "Left")
			});
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00025FEC File Offset: 0x000241EC
		private void btnCarnage_Click(object sender, EventArgs e)
		{
			this.ExecuteTravel(new List<IBotCommand>
			{
				this.CreateJoinCommand("citadel", "m22", "Left"),
				this.CreateJoinCommand("tercessuinotlim", "m4", "Top")
			});
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0002603C File Offset: 0x0002423C
		private void btnLae_Click(object sender, EventArgs e)
		{
			this.ExecuteTravel(new List<IBotCommand>
			{
				this.CreateJoinCommand("citadel", "m22", "Left"),
				this.CreateJoinCommand("tercessuinotlim", "m5", "Top")
			});
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0002608C File Offset: 0x0002428C
		private void btnPolish_Click(object sender, EventArgs e)
		{
			this.ExecuteTravel(new List<IBotCommand>
			{
				this.CreateJoinCommand("citadel", "m22", "Left"),
				this.CreateJoinCommand("tercessuinotlim", "m12", "Top")
			});
		}
	}
}
