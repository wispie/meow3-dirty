using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Grimoire.Networking;

namespace Grimoire.UI
{
	// Token: 0x0200003B RID: 59
	public partial class PacketLogger : Form
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00003047 File Offset: 0x00001247
		public static PacketLogger Instance { get; } = new PacketLogger();

		// Token: 0x060001AD RID: 429 RVA: 0x0000304E File Offset: 0x0000124E
		private PacketLogger()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000305C File Offset: 0x0000125C
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.txtPackets.Clear();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00003069 File Offset: 0x00001269
		private void btnCopy_Click(object sender, EventArgs e)
		{
			if (this.txtPackets.Text.Length > 0)
			{
				Clipboard.SetText(this.txtPackets.Text);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000308E File Offset: 0x0000128E
		private void btnStop_Click(object sender, EventArgs e)
		{
			Proxy.Instance.ReceivedFromClient -= this.PacketCaptured;
			this.btnStart.Enabled = true;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000030B2 File Offset: 0x000012B2
		private void btnStart_Click(object sender, EventArgs e)
		{
			this.btnStart.Enabled = false;
			Proxy.Instance.ReceivedFromClient += this.PacketCaptured;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00020090 File Offset: 0x0001E290
		private void PacketCaptured(Grimoire.Networking.Message msg)
		{
			if (msg.RawContent != null && msg.RawContent.Contains("%xt%zm%"))
			{
				this.txtPackets.Invoke(new Action(delegate()
				{
					this.txtPackets.AppendText(msg.RawContent + Environment.NewLine);
				}));
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002190 File Offset: 0x00000390
		private void PacketLogger_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}
	}
}
