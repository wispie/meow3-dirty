namespace Grimoire.UI
{
	// Token: 0x02000031 RID: 49
	public partial class Loaders : global::System.Windows.Forms.Form
	{
		// Token: 0x0600017C RID: 380 RVA: 0x00002EB2 File Offset: 0x000010B2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0001E38C File Offset: 0x0001C58C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.Loaders));
			this.txtLoaders = new global::System.Windows.Forms.TextBox();
			this.cbLoad = new global::System.Windows.Forms.ComboBox();
			this.btnLoad = new global::System.Windows.Forms.Button();
			this.cbGrab = new global::System.Windows.Forms.ComboBox();
			this.btnGrab = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.treeGrabbed = new global::System.Windows.Forms.TreeView();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.btnLoad1 = new global::System.Windows.Forms.Button();
			this.btnForceAccept = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.txtLoaders.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtLoaders.Location = new global::System.Drawing.Point(52, 12);
			this.txtLoaders.Name = "txtLoaders";
			this.txtLoaders.Size = new global::System.Drawing.Size(136, 20);
			this.txtLoaders.TabIndex = 29;
			this.cbLoad.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.cbLoad.FormattingEnabled = true;
			this.cbLoad.Items.AddRange(new object[]
			{
				"Hair shop",
				"Shop",
				"Quest",
				"Armor customizer"
			});
			this.cbLoad.Location = new global::System.Drawing.Point(52, 38);
			this.cbLoad.Name = "cbLoad";
			this.cbLoad.Size = new global::System.Drawing.Size(136, 21);
			this.cbLoad.TabIndex = 30;
			this.cbLoad.SelectedIndexChanged += new global::System.EventHandler(this.cbLoad_SelectedIndexChanged);
			this.btnLoad.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnLoad.Location = new global::System.Drawing.Point(52, 65);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new global::System.Drawing.Size(136, 23);
			this.btnLoad.TabIndex = 31;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new global::System.EventHandler(this.btnLoad_Click);
			this.cbGrab.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.cbGrab.FormattingEnabled = true;
			this.cbGrab.Items.AddRange(new object[]
			{
				"Shop items",
				"Quest IDs",
				"Quest items, drop rates",
				"Inventory items",
				"Temp inventory items",
				"Bank items",
				"Monsters"
			});
			this.cbGrab.Location = new global::System.Drawing.Point(12, 301);
			this.cbGrab.Name = "cbGrab";
			this.cbGrab.Size = new global::System.Drawing.Size(217, 21);
			this.cbGrab.TabIndex = 33;
			this.btnGrab.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnGrab.Location = new global::System.Drawing.Point(0, 0);
			this.btnGrab.Name = "btnGrab";
			this.btnGrab.Size = new global::System.Drawing.Size(108, 26);
			this.btnGrab.TabIndex = 34;
			this.btnGrab.Text = "Grab";
			this.btnGrab.UseVisualStyleBackColor = true;
			this.btnGrab.Click += new global::System.EventHandler(this.btnGrab_Click);
			this.btnSave.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnSave.Location = new global::System.Drawing.Point(0, 0);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(108, 26);
			this.btnSave.TabIndex = 35;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.treeGrabbed.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.treeGrabbed.LabelEdit = true;
			this.treeGrabbed.Location = new global::System.Drawing.Point(12, 94);
			this.treeGrabbed.Name = "treeGrabbed";
			this.treeGrabbed.Size = new global::System.Drawing.Size(217, 201);
			this.treeGrabbed.TabIndex = 38;
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(108, 26);
			this.panel1.TabIndex = 39;
			this.panel2.Controls.Add(this.btnGrab);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new global::System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(108, 26);
			this.panel2.TabIndex = 40;
			this.splitContainer1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new global::System.Drawing.Point(12, 329);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Size = new global::System.Drawing.Size(217, 26);
			this.splitContainer1.SplitterDistance = 108;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 41;
			this.btnLoad1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnLoad1.Location = new global::System.Drawing.Point(0, 0);
			this.btnLoad1.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.btnLoad1.Name = "btnLoad1";
			this.btnLoad1.Size = new global::System.Drawing.Size(108, 23);
			this.btnLoad1.TabIndex = 31;
			this.btnLoad1.Text = "Load";
			this.btnLoad1.UseVisualStyleBackColor = true;
			this.btnLoad1.Click += new global::System.EventHandler(this.btnLoad_Click);
			this.btnForceAccept.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnForceAccept.Location = new global::System.Drawing.Point(108, 0);
			this.btnForceAccept.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.btnForceAccept.Name = "btnForceAccept";
			this.btnForceAccept.Size = new global::System.Drawing.Size(108, 23);
			this.btnForceAccept.TabIndex = 31;
			this.btnForceAccept.Text = "Force Accept";
			this.btnForceAccept.UseVisualStyleBackColor = true;
			this.btnForceAccept.Click += new global::System.EventHandler(this.btnForceAccept_Click);
			this.tableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.btnLoad1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnForceAccept, 1, 0);
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(12, 62);
			this.tableLayoutPanel1.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(216, 23);
			this.tableLayoutPanel1.TabIndex = 42;
			this.tableLayoutPanel1.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(241, 360);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.treeGrabbed);
			base.Controls.Add(this.cbGrab);
			base.Controls.Add(this.btnLoad);
			base.Controls.Add(this.cbLoad);
			base.Controls.Add(this.txtLoaders);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MinimizeBox = false;
			base.Name = "Loaders";
			this.Text = "Loaders and grabbers";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Loaders_FormClosing);
			base.Load += new global::System.EventHandler(this.Loaders_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001AC RID: 428
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001AD RID: 429
		private global::System.Windows.Forms.TextBox txtLoaders;

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Forms.ComboBox cbLoad;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.Button btnLoad;

		// Token: 0x040001B0 RID: 432
		private global::System.Windows.Forms.ComboBox cbGrab;

		// Token: 0x040001B1 RID: 433
		private global::System.Windows.Forms.Button btnGrab;

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x040001B3 RID: 435
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040001B4 RID: 436
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040001B5 RID: 437
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Forms.Button btnLoad1;

		// Token: 0x040001B7 RID: 439
		private global::System.Windows.Forms.Button btnForceAccept;

		// Token: 0x040001B8 RID: 440
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x040001B9 RID: 441
		private global::System.Windows.Forms.TreeView treeGrabbed;
	}
}
