using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Grimoire.UI
{
	// Token: 0x0200004A RID: 74
	public partial class RawCommandEditor : Form
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00003495 File Offset: 0x00001695
		public string Input
		{
			get
			{
				return this.txtCmd.Text;
			}
		}

		// Token: 0x1700001F RID: 31
		// (set) Token: 0x060001FD RID: 509 RVA: 0x000034A2 File Offset: 0x000016A2
		public string Content
		{
			set
			{
				this.txtCmd.Text = value;
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000034B0 File Offset: 0x000016B0
		private RawCommandEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000034BE File Offset: 0x000016BE
		private void RawCommandEditor_Load(object sender, EventArgs e)
		{
			this.txtCmd.Select();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000229B8 File Offset: 0x00020BB8
		private void txtCmd_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Return)
			{
				this.btnOK.PerformClick();
				return;
			}
			if (keyCode != Keys.Escape)
			{
				return;
			}
			this.btnCancel.PerformClick();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000229F0 File Offset: 0x00020BF0
		public static string Show(string content)
		{
			string result;
			using (RawCommandEditor rawCommandEditor = new RawCommandEditor
			{
				Content = content
			})
			{
				result = ((rawCommandEditor.ShowDialog() == DialogResult.OK) ? rawCommandEditor.Input : null);
			}
			return result;
		}
	}
}
