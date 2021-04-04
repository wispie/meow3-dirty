using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Grimoire.Botting;

namespace Grimoire.UI
{
	// Token: 0x02000034 RID: 52
	public partial class LogForm : Form
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0001EE58 File Offset: 0x0001D058
		public TextBox SelectedLog
		{
			get
			{
				if (this.tabLogs.SelectedIndex == 0)
				{
					return this.txtLogDebug;
				}
				if (this.tabLogs.SelectedIndex == 1)
				{
					return this.txtLogScript;
				}
				if (this.tabLogs.SelectedIndex == 2)
				{
					return this.txtLogDrops;
				}
				return this.txtLogChat;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00002EFD File Offset: 0x000010FD
		public static LogForm Instance { get; } = new LogForm();

		// Token: 0x06000187 RID: 391 RVA: 0x00002F04 File Offset: 0x00001104
		public LogForm()
		{
			this.InitializeComponent();
			LogForm.logRec = new LogForm.DebugLogger(this);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0001EEAC File Offset: 0x0001D0AC
		private void LogForm_Load(object sender, EventArgs e)
		{
			base.FormClosing += this.LogForm_FormClosing;
			string text = Config.Load(Application.StartupPath + "\\config.cfg").Get("font");
			float? num = new float?(float.Parse(Config.Load(Application.StartupPath + "\\config.cfg").Get("fontSize") ?? "8.25", CultureInfo.InvariantCulture.NumberFormat));
			if (text != null && num != null)
			{
				this.Font = new Font(text, num.Value, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002F1D File Offset: 0x0000111D
		private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.Hide();
			e.Cancel = true;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001EF4C File Offset: 0x0001D14C
		public void AppendDebug(string text)
		{
			if (base.Visible)
			{
				if (text.Contains("{CLEAR}"))
				{
					this.txtLogDebug.Clear();
				}
				if (this.txtLogDebug.InvokeRequired)
				{
					this.txtLogDebug.Invoke(new Action(delegate()
					{
						this.txtLogDebug.AppendText(text);
					}));
					return;
				}
				this.txtLogDebug.AppendText(text);
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0001EFCC File Offset: 0x0001D1CC
		public void AppendDrops(string text)
		{
			if (base.Visible)
			{
				if (text.Contains("{CLEAR}"))
				{
					this.txtLogDrops.Clear();
				}
				if (this.txtLogDrops.InvokeRequired)
				{
					this.txtLogDrops.Invoke(new Action(delegate()
					{
						this.txtLogDrops.AppendText(text);
					}));
					return;
				}
				this.txtLogDrops.AppendText(text);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0001F04C File Offset: 0x0001D24C
		public void AppendChat(string text)
		{
			if (base.Visible)
			{
				if (text.Contains("{CLEAR}"))
				{
					this.txtLogChat.Clear();
				}
				if (this.txtLogChat.InvokeRequired)
				{
					this.txtLogChat.Invoke(new Action(delegate()
					{
						this.txtLogChat.AppendText(text);
					}));
					return;
				}
				this.txtLogChat.AppendText(text);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0001F0CC File Offset: 0x0001D2CC
		public void AppendScript(string text, bool ignoreInvoke = false)
		{
			if (base.Visible)
			{
				if (text.Contains("{CLEAR}"))
				{
					this.txtLogScript.Clear();
				}
				if (this.txtLogScript.InvokeRequired)
				{
					this.txtLogScript.Invoke(new Action(delegate()
					{
						this.txtLogScript.AppendText(text);
					}));
					return;
				}
				this.txtLogScript.AppendText(text);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002F2C File Offset: 0x0000112C
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.SelectedLog.Clear();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001F14C File Offset: 0x0001D34C
		private void btnSave_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(saveFileDialog.FileName, this.SelectedLog.Text);
				}
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001FAD4 File Offset: 0x0001DCD4
		private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.ShowDialog();
			this.ForeColor = colorDialog.Color;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001FAFC File Offset: 0x0001DCFC
		private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog fontDialog = new FontDialog();
			fontDialog.ShowDialog();
			this.Font = fontDialog.Font;
		}

		// Token: 0x040001CC RID: 460
		public static LogForm.DebugLogger logRec;

		// Token: 0x040001CE RID: 462
		public TextBox iable;

		// Token: 0x02000035 RID: 53
		public class DebugLogger : TraceListener
		{
			// Token: 0x06000195 RID: 405 RVA: 0x00002F64 File Offset: 0x00001164
			public DebugLogger(LogForm log)
			{
				this.log = log;
			}

			// Token: 0x06000196 RID: 406 RVA: 0x00002F73 File Offset: 0x00001173
			public override void Write(string message)
			{
				this.log.AppendDebug(message);
			}

			// Token: 0x06000197 RID: 407 RVA: 0x00002F81 File Offset: 0x00001181
			public override void WriteLine(string message)
			{
				this.log.AppendDebug(message + "\r\n");
			}

			// Token: 0x040001DF RID: 479
			private LogForm log;
		}
	}
}
