using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Grimoire.Networking;

namespace Grimoire.UI
{
	// Token: 0x02000040 RID: 64
	public partial class PacketTamperer : Form
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000326A File Offset: 0x0000146A
		public static PacketTamperer Instance { get; } = new PacketTamperer();

		// Token: 0x060001D0 RID: 464 RVA: 0x00003271 File Offset: 0x00001471
		private PacketTamperer()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002190 File Offset: 0x00000390
		private void PacketTamperer_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000327F File Offset: 0x0000147F
		private void chkFromServer_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkFromServer.Checked)
			{
				Proxy.Instance.ReceivedFromServer += this.ReceivedFromServer;
				return;
			}
			Proxy.Instance.ReceivedFromServer -= this.ReceivedFromServer;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000032BB File Offset: 0x000014BB
		private void chkFromClient_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkFromClient.Checked)
			{
				Proxy.Instance.ReceivedFromClient += this.ReceivedFromClient;
				return;
			}
			Proxy.Instance.ReceivedFromClient -= this.ReceivedFromClient;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0002138C File Offset: 0x0001F58C
		private async void btnToClient_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.txtSend.Text))
			{
				this.btnToClient.Enabled = false;
				await Proxy.Instance.SendToClient(this.txtSend.Text);
				this.btnToClient.Enabled = true;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000213C8 File Offset: 0x0001F5C8
		private async void btnToServer_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.txtSend.Text))
			{
				this.btnToServer.Enabled = false;
				await Proxy.Instance.SendToServer(this.txtSend.Text);
				this.btnToServer.Enabled = true;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00021404 File Offset: 0x0001F604
		private void ReceivedFromClient(Grimoire.Networking.Message message)
		{
			this.txtSend.Invoke(new Action(delegate()
			{
				this.Append("From client: " + message.RawContent);
			}));
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00021440 File Offset: 0x0001F640
		private void ReceivedFromServer(Grimoire.Networking.Message message)
		{
			this.txtSend.Invoke(new Action(delegate()
			{
				this.Append("From server: " + message.RawContent);
			}));
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000032F7 File Offset: 0x000014F7
		private void Append(string text)
		{
			this.txtReceive.AppendText(text + Environment.NewLine + Environment.NewLine);
		}
	}
}
