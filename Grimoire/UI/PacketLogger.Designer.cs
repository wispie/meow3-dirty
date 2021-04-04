namespace Grimoire.UI
{
	// Token: 0x0200003B RID: 59
	public partial class PacketLogger : global::System.Windows.Forms.Form
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x000030D6 File Offset: 0x000012D6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000200F0 File Offset: 0x0001E2F0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.PacketLogger));
			this.txtPackets = new global::System.Windows.Forms.TextBox();
			this.btnStart = new global::System.Windows.Forms.Button();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.btnCopy = new global::System.Windows.Forms.Button();
			this.btnClear = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.txtPackets.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtPackets.Location = new global::System.Drawing.Point(12, 12);
			this.txtPackets.Multiline = true;
			this.txtPackets.Name = "txtPackets";
			this.txtPackets.Size = new global::System.Drawing.Size(420, 160);
			this.txtPackets.TabIndex = 15;
			this.btnStart.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnStart.Location = new global::System.Drawing.Point(318, 3);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new global::System.Drawing.Size(99, 24);
			this.btnStart.TabIndex = 16;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new global::System.EventHandler(this.btnStart_Click);
			this.btnStop.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnStop.Location = new global::System.Drawing.Point(213, 3);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(99, 24);
			this.btnStop.TabIndex = 17;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new global::System.EventHandler(this.btnStop_Click);
			this.btnCopy.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnCopy.Location = new global::System.Drawing.Point(108, 3);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new global::System.Drawing.Size(99, 24);
			this.btnCopy.TabIndex = 18;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new global::System.EventHandler(this.btnCopy_Click);
			this.btnClear.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnClear.Location = new global::System.Drawing.Point(3, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(99, 24);
			this.btnClear.TabIndex = 19;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			this.tableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel1.Controls.Add(this.btnClear, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnStart, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnStop, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnCopy, 1, 0);
			this.tableLayoutPanel1.GrowStyle = global::System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(12, 175);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(420, 30);
			this.tableLayoutPanel1.TabIndex = 20;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(449, 207);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Controls.Add(this.txtPackets);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MinimizeBox = false;
			base.Name = "PacketLogger";
			this.Text = "Packet logger";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.PacketLogger_FormClosing);
			this.tableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001EE RID: 494
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001EF RID: 495
		private global::System.Windows.Forms.TextBox txtPackets;

		// Token: 0x040001F0 RID: 496
		private global::System.Windows.Forms.Button btnStart;

		// Token: 0x040001F1 RID: 497
		private global::System.Windows.Forms.Button btnStop;

		// Token: 0x040001F2 RID: 498
		private global::System.Windows.Forms.Button btnCopy;

		// Token: 0x040001F3 RID: 499
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x040001F4 RID: 500
		private global::System.Windows.Forms.Button btnClear;
	}
}
