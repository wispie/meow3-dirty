namespace Grimoire.UI
{
	// Token: 0x02000040 RID: 64
	public partial class PacketTamperer : global::System.Windows.Forms.Form
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x00003314 File Offset: 0x00001514
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0002147C File Offset: 0x0001F67C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.PacketTamperer));
			this.txtSend = new global::System.Windows.Forms.RichTextBox();
			this.txtReceive = new global::System.Windows.Forms.RichTextBox();
			this.btnToServer = new global::System.Windows.Forms.Button();
			this.chkFromClient = new global::System.Windows.Forms.CheckBox();
			this.chkFromServer = new global::System.Windows.Forms.CheckBox();
			this.btnToClient = new global::System.Windows.Forms.Button();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.txtSend.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtSend.Location = new global::System.Drawing.Point(0, 0);
			this.txtSend.Name = "txtSend";
			this.txtSend.Size = new global::System.Drawing.Size(536, 99);
			this.txtSend.TabIndex = 0;
			this.txtSend.Text = "";
			this.txtReceive.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtReceive.Location = new global::System.Drawing.Point(0, 0);
			this.txtReceive.Name = "txtReceive";
			this.txtReceive.Size = new global::System.Drawing.Size(536, 212);
			this.txtReceive.TabIndex = 1;
			this.txtReceive.Text = "";
			this.btnToServer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnToServer.Location = new global::System.Drawing.Point(448, 3);
			this.btnToServer.Name = "btnToServer";
			this.btnToServer.Size = new global::System.Drawing.Size(85, 23);
			this.btnToServer.TabIndex = 3;
			this.btnToServer.Text = "Send to server";
			this.btnToServer.UseVisualStyleBackColor = true;
			this.btnToServer.Click += new global::System.EventHandler(this.btnToServer_Click);
			this.chkFromClient.AutoSize = true;
			this.chkFromClient.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.chkFromClient.Location = new global::System.Drawing.Point(127, 3);
			this.chkFromClient.Name = "chkFromClient";
			this.chkFromClient.Size = new global::System.Drawing.Size(120, 23);
			this.chkFromClient.TabIndex = 4;
			this.chkFromClient.Text = "Capture from client";
			this.chkFromClient.UseVisualStyleBackColor = true;
			this.chkFromClient.CheckedChanged += new global::System.EventHandler(this.chkFromClient_CheckedChanged);
			this.chkFromServer.AutoSize = true;
			this.chkFromServer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.chkFromServer.Location = new global::System.Drawing.Point(0, 0);
			this.chkFromServer.Name = "chkFromServer";
			this.chkFromServer.Size = new global::System.Drawing.Size(118, 23);
			this.chkFromServer.TabIndex = 5;
			this.chkFromServer.Text = "Capture from server";
			this.chkFromServer.UseVisualStyleBackColor = true;
			this.chkFromServer.CheckedChanged += new global::System.EventHandler(this.chkFromServer_CheckedChanged);
			this.btnToClient.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnToClient.Location = new global::System.Drawing.Point(358, 3);
			this.btnToClient.Name = "btnToClient";
			this.btnToClient.Size = new global::System.Drawing.Size(84, 23);
			this.btnToClient.TabIndex = 6;
			this.btnToClient.Text = "Send to client";
			this.btnToClient.UseVisualStyleBackColor = true;
			this.btnToClient.Click += new global::System.EventHandler(this.btnToClient_Click);
			this.splitContainer1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.splitContainer1.Location = new global::System.Drawing.Point(16, 41);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.txtSend);
			this.splitContainer1.Panel2.Controls.Add(this.txtReceive);
			this.splitContainer1.Size = new global::System.Drawing.Size(536, 315);
			this.splitContainer1.SplitterDistance = 99;
			this.splitContainer1.TabIndex = 7;
			this.panel1.Controls.Add(this.chkFromServer);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(118, 23);
			this.panel1.TabIndex = 10;
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new global::System.Drawing.Point(253, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(99, 23);
			this.panel2.TabIndex = 11;
			this.tableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 130f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 120f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 90f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 90f));
			this.tableLayoutPanel1.Controls.Add(this.btnToClient, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnToServer, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.chkFromClient, 1, 0);
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(16, 6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(536, 29);
			this.tableLayoutPanel1.TabIndex = 12;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(561, 368);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Controls.Add(this.splitContainer1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "PacketTamperer";
			this.Text = "Packet Tamperer";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.PacketTamperer_FormClosing);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400020C RID: 524
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400020D RID: 525
		private global::System.Windows.Forms.RichTextBox txtSend;

		// Token: 0x0400020E RID: 526
		private global::System.Windows.Forms.RichTextBox txtReceive;

		// Token: 0x0400020F RID: 527
		private global::System.Windows.Forms.Button btnToServer;

		// Token: 0x04000210 RID: 528
		private global::System.Windows.Forms.CheckBox chkFromClient;

		// Token: 0x04000211 RID: 529
		private global::System.Windows.Forms.CheckBox chkFromServer;

		// Token: 0x04000212 RID: 530
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000213 RID: 531
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000214 RID: 532
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000215 RID: 533
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x04000216 RID: 534
		private global::System.Windows.Forms.Button btnToClient;
	}
}
