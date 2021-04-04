namespace Grimoire.UI
{
	// Token: 0x02000034 RID: 52
	public partial class LogForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00002F39 File Offset: 0x00001139
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001F19C File Offset: 0x0001D39C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.LogForm));
			this.txtLogDebug = new global::System.Windows.Forms.TextBox();
			this.btnClear = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.tabLogs = new global::System.Windows.Forms.TabControl();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.changeFontToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.changeColorToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tabLogDebug = new global::System.Windows.Forms.TabPage();
			this.tabLogScript = new global::System.Windows.Forms.TabPage();
			this.txtLogScript = new global::System.Windows.Forms.TextBox();
			this.tabLogDrops = new global::System.Windows.Forms.TabPage();
			this.txtLogDrops = new global::System.Windows.Forms.TextBox();
			this.tabLogChat = new global::System.Windows.Forms.TabPage();
			this.txtLogChat = new global::System.Windows.Forms.TextBox();
			this.colorDialog1 = new global::System.Windows.Forms.ColorDialog();
			this.tabLogs.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.tabLogDebug.SuspendLayout();
			this.tabLogScript.SuspendLayout();
			this.tabLogDrops.SuspendLayout();
			this.tabLogChat.SuspendLayout();
			base.SuspendLayout();
			this.txtLogDebug.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtLogDebug.Location = new global::System.Drawing.Point(3, 3);
			this.txtLogDebug.Multiline = true;
			this.txtLogDebug.Name = "txtLogDebug";
			this.txtLogDebug.ReadOnly = true;
			this.txtLogDebug.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.txtLogDebug.Size = new global::System.Drawing.Size(414, 211);
			this.txtLogDebug.TabIndex = 0;
			this.btnClear.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnClear.Location = new global::System.Drawing.Point(12, 249);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(199, 23);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			this.btnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSave.Location = new global::System.Drawing.Point(217, 249);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(199, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.tabLogs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabLogs.ContextMenuStrip = this.contextMenuStrip1;
			this.tabLogs.Controls.Add(this.tabLogDebug);
			this.tabLogs.Controls.Add(this.tabLogScript);
			this.tabLogs.Controls.Add(this.tabLogDrops);
			this.tabLogs.Controls.Add(this.tabLogChat);
			this.tabLogs.Location = new global::System.Drawing.Point(0, 0);
			this.tabLogs.Name = "tabLogs";
			this.tabLogs.SelectedIndex = 0;
			this.tabLogs.Size = new global::System.Drawing.Size(428, 243);
			this.tabLogs.TabIndex = 3;
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.changeFontToolStripMenuItem,
				this.changeColorToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(148, 48);
			this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
			this.changeFontToolStripMenuItem.Size = new global::System.Drawing.Size(147, 22);
			this.changeFontToolStripMenuItem.Text = "Change Font";
			this.changeFontToolStripMenuItem.Click += new global::System.EventHandler(this.changeFontToolStripMenuItem_Click);
			this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
			this.changeColorToolStripMenuItem.Size = new global::System.Drawing.Size(147, 22);
			this.changeColorToolStripMenuItem.Text = "Change Color";
			this.changeColorToolStripMenuItem.Click += new global::System.EventHandler(this.changeColorToolStripMenuItem_Click);
			this.tabLogDebug.Controls.Add(this.txtLogDebug);
			this.tabLogDebug.Location = new global::System.Drawing.Point(4, 22);
			this.tabLogDebug.Name = "tabLogDebug";
			this.tabLogDebug.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabLogDebug.Size = new global::System.Drawing.Size(420, 217);
			this.tabLogDebug.TabIndex = 0;
			this.tabLogDebug.Text = "Debug";
			this.tabLogDebug.UseVisualStyleBackColor = true;
			this.tabLogScript.Controls.Add(this.txtLogScript);
			this.tabLogScript.Location = new global::System.Drawing.Point(4, 22);
			this.tabLogScript.Name = "tabLogScript";
			this.tabLogScript.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabLogScript.Size = new global::System.Drawing.Size(420, 217);
			this.tabLogScript.TabIndex = 1;
			this.tabLogScript.Text = "Script";
			this.tabLogScript.UseVisualStyleBackColor = true;
			this.txtLogScript.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtLogScript.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.txtLogScript.Location = new global::System.Drawing.Point(3, 3);
			this.txtLogScript.Multiline = true;
			this.txtLogScript.Name = "txtLogScript";
			this.txtLogScript.ReadOnly = true;
			this.txtLogScript.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.txtLogScript.Size = new global::System.Drawing.Size(414, 211);
			this.txtLogScript.TabIndex = 1;
			this.tabLogDrops.Controls.Add(this.txtLogDrops);
			this.tabLogDrops.Location = new global::System.Drawing.Point(4, 22);
			this.tabLogDrops.Name = "tabLogDrops";
			this.tabLogDrops.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabLogDrops.Size = new global::System.Drawing.Size(420, 217);
			this.tabLogDrops.TabIndex = 2;
			this.tabLogDrops.Text = "Drops";
			this.tabLogDrops.UseVisualStyleBackColor = true;
			this.txtLogDrops.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtLogDrops.Location = new global::System.Drawing.Point(3, 3);
			this.txtLogDrops.Multiline = true;
			this.txtLogDrops.Name = "txtLogDrops";
			this.txtLogDrops.ReadOnly = true;
			this.txtLogDrops.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.txtLogDrops.Size = new global::System.Drawing.Size(414, 211);
			this.txtLogDrops.TabIndex = 2;
			this.tabLogChat.Controls.Add(this.txtLogChat);
			this.tabLogChat.Location = new global::System.Drawing.Point(4, 22);
			this.tabLogChat.Name = "tabLogChat";
			this.tabLogChat.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabLogChat.Size = new global::System.Drawing.Size(420, 217);
			this.tabLogChat.TabIndex = 3;
			this.tabLogChat.Text = "Chat";
			this.tabLogChat.UseVisualStyleBackColor = true;
			this.txtLogChat.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtLogChat.Location = new global::System.Drawing.Point(3, 3);
			this.txtLogChat.Multiline = true;
			this.txtLogChat.Name = "txtLogChat";
			this.txtLogChat.ReadOnly = true;
			this.txtLogChat.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.txtLogChat.Size = new global::System.Drawing.Size(414, 211);
			this.txtLogChat.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(428, 284);
			this.ContextMenuStrip = this.contextMenuStrip1;
			base.Controls.Add(this.tabLogs);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.btnClear);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "LogForm";
			this.Text = "Debug Log";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.LogForm_Load);
			this.tabLogs.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.tabLogDebug.ResumeLayout(false);
			this.tabLogDebug.PerformLayout();
			this.tabLogScript.ResumeLayout(false);
			this.tabLogScript.PerformLayout();
			this.tabLogDrops.ResumeLayout(false);
			this.tabLogDrops.PerformLayout();
			this.tabLogChat.ResumeLayout(false);
			this.tabLogChat.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040001CD RID: 461
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001CF RID: 463
		private global::System.Windows.Forms.Button btnClear;

		// Token: 0x040001D0 RID: 464
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x040001D1 RID: 465
		private global::System.Windows.Forms.TabControl tabLogs;

		// Token: 0x040001D2 RID: 466
		private global::System.Windows.Forms.TabPage tabLogDebug;

		// Token: 0x040001D3 RID: 467
		private global::System.Windows.Forms.TabPage tabLogScript;

		// Token: 0x040001D4 RID: 468
		public global::System.Windows.Forms.TextBox txtLogDebug;

		// Token: 0x040001D5 RID: 469
		public global::System.Windows.Forms.TextBox txtLogScript;

		// Token: 0x040001D6 RID: 470
		private global::System.Windows.Forms.TabPage tabLogDrops;

		// Token: 0x040001D7 RID: 471
		private global::System.Windows.Forms.TabPage tabLogChat;

		// Token: 0x040001D8 RID: 472
		private global::System.Windows.Forms.TextBox txtLogDrops;

		// Token: 0x040001D9 RID: 473
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040001DA RID: 474
		private global::System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;

		// Token: 0x040001DB RID: 475
		private global::System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;

		// Token: 0x040001DC RID: 476
		private global::System.Windows.Forms.ColorDialog colorDialog1;

		// Token: 0x040001DD RID: 477
		private global::System.Windows.Forms.TextBox txtLogChat;
	}
}
