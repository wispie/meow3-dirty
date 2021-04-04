using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Grimoire.UI
{
	// Token: 0x0200003A RID: 58
	public partial class Notepad : Form
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x0001FB24 File Offset: 0x0001DD24
		public Notepad()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002190 File Offset: 0x00000390
		private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001FB84 File Offset: 0x0001DD84
		private void Notepad_Load(object sender, EventArgs e)
		{
			if (this.font != null && this.fontSize != null)
			{
				this.Font = new Font(this.font, this.fontSize.Value, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
			this.richTextBox1.ContextMenuStrip = this.Context();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
		private ContextMenuStrip Context()
		{
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
			{
				Text = "Font"
			};
			toolStripMenuItem.Click += delegate(object S, EventArgs E)
			{
				FontDialog fontDialog = new FontDialog();
				fontDialog.ShowDialog();
				if (this.richTextBox1.SelectedText == null)
				{
					this.richTextBox1.Font = fontDialog.Font;
					return;
				}
				this.richTextBox1.SelectionFont = fontDialog.Font;
			};
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem
			{
				Text = "Color"
			};
			toolStripMenuItem2.Click += delegate(object S, EventArgs E)
			{
				ColorDialog colorDialog = new ColorDialog();
				colorDialog.ShowDialog();
				if (this.richTextBox1.SelectedText == null)
				{
					this.richTextBox1.ForeColor = colorDialog.Color;
					return;
				}
				this.richTextBox1.SelectionColor = colorDialog.Color;
			};
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Items.Add(toolStripMenuItem2);
			return contextMenuStrip;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002FF9 File Offset: 0x000011F9
		private void Notepad_DragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Link;
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001FC4C File Offset: 0x0001DE4C
		private void Notepad_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
				foreach (string path in array)
				{
					if (File.Exists(path))
					{
						using (TextReader textReader = new StreamReader(path))
						{
							RichTextBox richTextBox = this.richTextBox1;
							richTextBox.Text = richTextBox.Text + "\r\n" + textReader.ReadToEnd() + "\r\n";
						}
					}
				}
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001FCEC File Offset: 0x0001DEEC
		private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
			{
				string text = this.richTextBox1.Text;
				SaveFileDialog saveFileDialog = new SaveFileDialog
				{
					Filter = "txt files (*.txt)|*.txt|gbot files (*.gbot)|*.gbot|All files (*.*)|*.*",
					FilterIndex = 1,
					RestoreDirectory = true
				};
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(saveFileDialog.FileName, text);
				}
			}
			if (e.KeyCode == Keys.Back && this.richTextBox1.Text.Length < 1)
			{
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x040001E8 RID: 488
		private string font = ConfigurationManager.AppSettings.Get("Font");

		// Token: 0x040001E9 RID: 489
		private float? fontSize = new float?(float.Parse(ConfigurationManager.AppSettings.Get("FontSize") ?? "8.25", CultureInfo.InvariantCulture.NumberFormat));

		// Token: 0x040001EA RID: 490
		public static Notepad Instance = new Notepad();
	}
}
