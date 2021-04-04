namespace Grimoire.UI
{
	// Token: 0x0200001F RID: 31
	public partial class CommandColorForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00002B2E File Offset: 0x00000D2E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001868C File Offset: 0x0001688C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.CommandColorForm));
			this.colorDialog1 = new global::System.Windows.Forms.ColorDialog();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.btnSetColor = new global::System.Windows.Forms.Button();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.trackBar1 = new global::System.Windows.Forms.TrackBar();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.btnRandomColors = new global::System.Windows.Forms.Button();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.txtRGB = new global::System.Windows.Forms.TextBox();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
			base.SuspendLayout();
			this.colorDialog1.AnyColor = true;
			this.comboBox1.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.comboBox1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(20, 30);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(186, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.DrawItem += new global::System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.btnSetColor.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnSetColor.Location = new global::System.Drawing.Point(20, 57);
			this.btnSetColor.Name = "btnSetColor";
			this.btnSetColor.Size = new global::System.Drawing.Size(209, 21);
			this.btnSetColor.TabIndex = 4;
			this.btnSetColor.Text = "Set Color of Selected";
			this.btnSetColor.UseVisualStyleBackColor = true;
			this.btnSetColor.Click += new global::System.EventHandler(this.btnLabelColor_Click);
			this.checkBox1.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new global::System.Drawing.Point(54, 86);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(145, 17);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Set Selected to Centered";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.trackBar1.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.trackBar1.Cursor = global::System.Windows.Forms.Cursors.SizeWE;
			this.trackBar1.Location = new global::System.Drawing.Point(20, 114);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Minimum = 20;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new global::System.Drawing.Size(210, 45);
			this.trackBar1.TabIndex = 6;
			this.trackBar1.TickStyle = global::System.Windows.Forms.TickStyle.None;
			this.trackBar1.Value = 60;
			this.trackBar1.Scroll += new global::System.EventHandler(this.trackBar1_Scroll);
			this.btnSave.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnSave.Location = new global::System.Drawing.Point(20, 153);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(209, 23);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save Size";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnRandomColors.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnRandomColors.Location = new global::System.Drawing.Point(20, 182);
			this.btnRandomColors.Name = "btnRandomColors";
			this.btnRandomColors.Size = new global::System.Drawing.Size(209, 23);
			this.btnRandomColors.TabIndex = 7;
			this.btnRandomColors.Text = "Random Colors based on RGB";
			this.btnRandomColors.UseVisualStyleBackColor = true;
			this.btnRandomColors.Click += new global::System.EventHandler(this.btnRandomColors_Click);
			this.btnRefresh.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnRefresh.Location = new global::System.Drawing.Point(209, 30);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new global::System.Drawing.Size(20, 21);
			this.btnRefresh.TabIndex = 8;
			this.btnRefresh.Text = "R";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			this.txtRGB.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.txtRGB.Location = new global::System.Drawing.Point(20, 210);
			this.txtRGB.Name = "txtRGB";
			this.txtRGB.Size = new global::System.Drawing.Size(209, 20);
			this.txtRGB.TabIndex = 9;
			this.txtRGB.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(245, 256);
			base.Controls.Add(this.txtRGB);
			base.Controls.Add(this.btnRefresh);
			base.Controls.Add(this.btnRandomColors);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.trackBar1);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.btnSetColor);
			base.Controls.Add(this.comboBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CommandColorForm";
			this.Text = "Colors";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.CommandColorForm_FormClosing);
			base.Load += new global::System.EventHandler(this.CommandColorForm_Load);
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400012E RID: 302
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400012F RID: 303
		private global::System.Windows.Forms.ColorDialog colorDialog1;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.Button btnSetColor;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.TrackBar trackBar1;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.Button btnRandomColors;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.Button btnRefresh;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.TextBox txtRGB;
	}
}
