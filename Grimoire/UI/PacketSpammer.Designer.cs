namespace Grimoire.UI
{
	// Token: 0x0200003D RID: 61
	public partial class PacketSpammer : global::System.Windows.Forms.Form
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x00003219 File Offset: 0x00001419
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00020944 File Offset: 0x0001EB44
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.PacketSpammer));
			this.lstPackets = new global::System.Windows.Forms.ListBox();
			this.txtPacket = new global::System.Windows.Forms.TextBox();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.btnClear = new global::System.Windows.Forms.Button();
			this.btnLoad = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.btnStart = new global::System.Windows.Forms.Button();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.numDelay = new global::System.Windows.Forms.NumericUpDown();
			this.btnSend = new global::System.Windows.Forms.Button();
			this.btnRemove = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			((global::System.ComponentModel.ISupportInitialize)this.numDelay).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.lstPackets.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lstPackets.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstPackets.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lstPackets.FormattingEnabled = true;
			this.lstPackets.Location = new global::System.Drawing.Point(12, 12);
			this.lstPackets.Name = "lstPackets";
			this.lstPackets.Size = new global::System.Drawing.Size(276, 93);
			this.lstPackets.TabIndex = 0;
			this.txtPacket.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtPacket.Location = new global::System.Drawing.Point(12, 111);
			this.txtPacket.Name = "txtPacket";
			this.txtPacket.Size = new global::System.Drawing.Size(276, 20);
			this.txtPacket.TabIndex = 27;
			this.btnAdd.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnAdd.Location = new global::System.Drawing.Point(208, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(64, 23);
			this.btnAdd.TabIndex = 28;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.btnClear.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnClear.Location = new global::System.Drawing.Point(140, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(62, 23);
			this.btnClear.TabIndex = 29;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			this.btnLoad.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnLoad.Location = new global::System.Drawing.Point(140, 32);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new global::System.Drawing.Size(62, 23);
			this.btnLoad.TabIndex = 30;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new global::System.EventHandler(this.btnLoad_Click);
			this.btnSave.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnSave.Location = new global::System.Drawing.Point(208, 32);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(64, 23);
			this.btnSave.TabIndex = 31;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnStart.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnStart.Location = new global::System.Drawing.Point(208, 61);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new global::System.Drawing.Size(64, 25);
			this.btnStart.TabIndex = 32;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new global::System.EventHandler(this.btnStart_Click);
			this.btnStop.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnStop.Location = new global::System.Drawing.Point(140, 61);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(62, 25);
			this.btnStop.TabIndex = 33;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new global::System.EventHandler(this.btnStop_Click);
			this.numDelay.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.numDelay.Location = new global::System.Drawing.Point(3, 3);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numDelay;
			int[] array = new int[4];
			array[0] = 61000;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numDelay;
			int[] array2 = new int[4];
			array2[0] = 100;
			numericUpDown2.Minimum = new decimal(array2);
			this.numDelay.Name = "numDelay";
			this.numDelay.Size = new global::System.Drawing.Size(68, 20);
			this.numDelay.TabIndex = 34;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numDelay;
			int[] array3 = new int[4];
			array3[0] = 2000;
			numericUpDown3.Value = new decimal(array3);
			this.btnSend.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnSend.ImageAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.btnSend.Location = new global::System.Drawing.Point(3, 61);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new global::System.Drawing.Size(68, 25);
			this.btnSend.TabIndex = 35;
			this.btnSend.Text = "Send once";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new global::System.EventHandler(this.btnSend_Click);
			this.btnRemove.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnRemove.Location = new global::System.Drawing.Point(77, 3);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new global::System.Drawing.Size(57, 23);
			this.btnRemove.TabIndex = 36;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new global::System.EventHandler(this.btnRemove_Click);
			this.tableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 27f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 23f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRemove, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.numDelay, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnLoad, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnStart, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnStop, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnSend, 0, 2);
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(12, 137);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(275, 89);
			this.tableLayoutPanel1.TabIndex = 37;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(299, 228);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Controls.Add(this.txtPacket);
			base.Controls.Add(this.lstPackets);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "PacketSpammer";
			this.Text = "Packet spammer";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.PacketSpammer_FormClosing);
			((global::System.ComponentModel.ISupportInitialize)this.numDelay).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001F8 RID: 504
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001F9 RID: 505
		private global::System.Windows.Forms.ListBox lstPackets;

		// Token: 0x040001FA RID: 506
		private global::System.Windows.Forms.TextBox txtPacket;

		// Token: 0x040001FB RID: 507
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040001FC RID: 508
		private global::System.Windows.Forms.Button btnClear;

		// Token: 0x040001FD RID: 509
		private global::System.Windows.Forms.Button btnLoad;

		// Token: 0x040001FE RID: 510
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x040001FF RID: 511
		private global::System.Windows.Forms.Button btnStart;

		// Token: 0x04000200 RID: 512
		private global::System.Windows.Forms.Button btnStop;

		// Token: 0x04000201 RID: 513
		private global::System.Windows.Forms.NumericUpDown numDelay;

		// Token: 0x04000202 RID: 514
		private global::System.Windows.Forms.Button btnSend;

		// Token: 0x04000203 RID: 515
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x04000204 RID: 516
		private global::System.Windows.Forms.Button btnRemove;
	}
}
