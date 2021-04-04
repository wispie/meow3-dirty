using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Grimoire.Networking;
using Grimoire.Tools;

namespace Grimoire.UI
{
	// Token: 0x0200003D RID: 61
	public partial class PacketSpammer : Form
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00003128 File Offset: 0x00001328
		public static PacketSpammer Instance { get; } = new PacketSpammer();

		// Token: 0x060001BA RID: 442 RVA: 0x0000312F File Offset: 0x0000132F
		private PacketSpammer()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000313D File Offset: 0x0000133D
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.lstPackets.Items.Clear();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000314F File Offset: 0x0000134F
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (this.txtPacket.Text.Length > 0)
			{
				this.lstPackets.Items.Add(this.txtPacket.Text);
				this.txtPacket.Clear();
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000318B File Offset: 0x0000138B
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (this.lstPackets.Items.Count > 0)
			{
				this.SaveConfig();
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000031A6 File Offset: 0x000013A6
		private void btnLoad_Click(object sender, EventArgs e)
		{
			this.lstPackets.Items.Clear();
			this.LoadConfig();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000031BE File Offset: 0x000013BE
		private void btnStop_Click(object sender, EventArgs e)
		{
			Spammer.Instance.Stop();
			Spammer.Instance.IndexChanged -= this.IndexChanged;
			this.SetButtonsEnabled(true);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000205F8 File Offset: 0x0001E7F8
		private void btnStart_Click(object sender, EventArgs e)
		{
			if (this.lstPackets.Items.Count > 0)
			{
				this.SetButtonsEnabled(false);
				List<string> packets = this.lstPackets.Items.Cast<string>().ToList<string>();
				int delay = (int)this.numDelay.Value;
				Spammer.Instance.IndexChanged += this.IndexChanged;
				Spammer.Instance.Start(packets, delay);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00020668 File Offset: 0x0001E868
		private async void btnSend_Click(object sender, EventArgs e)
		{
			if (this.txtPacket.TextLength > 0)
			{
				this.btnSend.Enabled = false;
				await Proxy.Instance.SendToServer(this.txtPacket.Text);
				this.btnSend.Enabled = true;
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002190 File Offset: 0x00000390
		private void PacketSpammer_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000206A4 File Offset: 0x0001E8A4
		private void SaveConfig()
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Save spammer file";
				openFileDialog.Filter = "XML files|*.xml";
				openFileDialog.CheckFileExists = false;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					using (XmlWriter xmlWriter = XmlWriter.Create(openFileDialog.FileName))
					{
						xmlWriter.WriteStartElement("autoer");
						foreach (object obj in this.lstPackets.Items)
						{
							string value = (string)obj;
							xmlWriter.WriteElementString("packet", value);
						}
						xmlWriter.WriteElementString("author", "Author");
						xmlWriter.WriteElementString("spamspeed", this.numDelay.Value.ToString());
						xmlWriter.WriteEndElement();
					}
				}
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000207B8 File Offset: 0x0001E9B8
		private void LoadConfig()
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Load spammer file";
				openFileDialog.Filter = "XML files|*.xml";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					foreach (XNode xnode in XElement.Load(openFileDialog.FileName).Nodes())
					{
						XElement xelement = (XElement)xnode;
						if (xelement.Name == "packet")
						{
							this.lstPackets.Items.Add(xelement.Value);
						}
						else if (xelement.Name == "spamspeed")
						{
							string text = xelement.Name.ToString();
							this.numDelay.Value = (text.All(new Func<char, bool>(char.IsDigit)) ? int.Parse(text) : 2000);
						}
					}
				}
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000031E7 File Offset: 0x000013E7
		private void SetButtonsEnabled(bool enabled)
		{
			this.btnStart.Enabled = enabled;
			this.btnAdd.Enabled = enabled;
			this.btnClear.Enabled = enabled;
			this.btnLoad.Enabled = enabled;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000208D8 File Offset: 0x0001EAD8
		private void IndexChanged(int index)
		{
			this.lstPackets.Invoke(new Action(delegate()
			{
				this.lstPackets.SelectedIndex = index;
			}));
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00020914 File Offset: 0x0001EB14
		private void btnRemove_Click(object sender, EventArgs e)
		{
			int selectedIndex = this.lstPackets.SelectedIndex;
			if (selectedIndex > -1)
			{
				this.lstPackets.Items.RemoveAt(selectedIndex);
			}
		}
	}
}
