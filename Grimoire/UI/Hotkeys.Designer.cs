namespace Grimoire.UI
{
	// Token: 0x02000028 RID: 40
	public partial class Hotkeys : global::System.Windows.Forms.Form
	{
		// Token: 0x06000149 RID: 329 RVA: 0x00002CF8 File Offset: 0x00000EF8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001C748 File Offset: 0x0001A948
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.Hotkeys));
			this.lstKeys = new global::System.Windows.Forms.ListBox();
			this.cbKeys = new global::System.Windows.Forms.ComboBox();
			this.cbActions = new global::System.Windows.Forms.ComboBox();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.btnRemove = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.lstKeys.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lstKeys.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstKeys.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lstKeys.FormattingEnabled = true;
			this.lstKeys.HorizontalScrollbar = true;
			this.lstKeys.Location = new global::System.Drawing.Point(12, 68);
			this.lstKeys.Name = "lstKeys";
			this.lstKeys.Size = new global::System.Drawing.Size(230, 80);
			this.lstKeys.TabIndex = 28;
			this.cbKeys.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.cbKeys.FormattingEnabled = true;
			this.cbKeys.Items.AddRange(new object[]
			{
				"Left",
				"Up",
				"Right",
				"Down",
				"D0",
				"D1",
				"D2",
				"D3",
				"D4",
				"D5",
				"D6",
				"D7",
				"D8",
				"D9",
				"A",
				"B",
				"C",
				"D",
				"E",
				"F",
				"G",
				"H",
				"I",
				"J",
				"K",
				"L",
				"M",
				"N",
				"O",
				"P",
				"Q",
				"R",
				"S",
				"T",
				"U",
				"V",
				"W",
				"X",
				"Y",
				"Z",
				"F1",
				"F2",
				"F3",
				"F4",
				"F5",
				"F6",
				"F7",
				"F8",
				"F9",
				"F10",
				"F11",
				"F12"
			});
			this.cbKeys.Location = new global::System.Drawing.Point(3, 3);
			this.cbKeys.Name = "cbKeys";
			this.cbKeys.Size = new global::System.Drawing.Size(109, 21);
			this.cbKeys.TabIndex = 29;
			this.cbActions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.cbActions.FormattingEnabled = true;
			this.cbActions.Items.AddRange(new object[]
			{
				"Show Bot",
				"Show Hotkeys",
				"Show Loaders",
				"Show Packet logger",
				"Show Packet spammer",
				"Show Fast travels",
				"Minimize to tray",
				"Show bank",
				"Show Cosmetics form",
				"Show Logs",
				"Show Notepad",
				"Load Hair shop",
				"Load Armor Customizer",
				"Yulgar Suite 42",
				"Relog",
				"Start/Stop Bot",
				"Toggle Options",
				"Debug Command"
			});
			this.cbActions.Location = new global::System.Drawing.Point(118, 3);
			this.cbActions.Name = "cbActions";
			this.cbActions.Size = new global::System.Drawing.Size(109, 21);
			this.cbActions.TabIndex = 30;
			this.btnAdd.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnAdd.Location = new global::System.Drawing.Point(3, 30);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(109, 21);
			this.btnAdd.TabIndex = 31;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.btnRemove.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnRemove.Location = new global::System.Drawing.Point(118, 30);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new global::System.Drawing.Size(109, 21);
			this.btnRemove.TabIndex = 32;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new global::System.EventHandler(this.btnRemove_Click);
			this.btnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSave.Location = new global::System.Drawing.Point(12, 154);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(230, 23);
			this.btnSave.TabIndex = 33;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.tableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.cbKeys, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.cbActions, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRemove, 1, 1);
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(12, 8);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(230, 54);
			this.tableLayoutPanel1.TabIndex = 34;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(255, 186);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.lstKeys);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Hotkeys";
			this.Text = "Hotkeys";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Hotkeys_FormClosing);
			base.Load += new global::System.EventHandler(this.Hotkeys_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400017F RID: 383
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.ListBox lstKeys;

		// Token: 0x04000181 RID: 385
		private global::System.Windows.Forms.ComboBox cbKeys;

		// Token: 0x04000182 RID: 386
		private global::System.Windows.Forms.ComboBox cbActions;

		// Token: 0x04000183 RID: 387
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000184 RID: 388
		private global::System.Windows.Forms.Button btnRemove;

		// Token: 0x04000185 RID: 389
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x04000186 RID: 390
		private global::System.Windows.Forms.Button btnSave;
	}
}
