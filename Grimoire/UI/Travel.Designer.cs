namespace Grimoire.UI
{
	// Token: 0x02000056 RID: 86
	public partial class Travel : global::System.Windows.Forms.Form
	{
		// Token: 0x06000261 RID: 609 RVA: 0x00003854 File Offset: 0x00001A54
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000255E8 File Offset: 0x000237E8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.Travel));
			this.btnDage = new global::System.Windows.Forms.Button();
			this.btnEscherion = new global::System.Windows.Forms.Button();
			this.btnBinky = new global::System.Windows.Forms.Button();
			this.btnNulgath = new global::System.Windows.Forms.Button();
			this.btnSwindle = new global::System.Windows.Forms.Button();
			this.btnTaro = new global::System.Windows.Forms.Button();
			this.btnTwins = new global::System.Windows.Forms.Button();
			this.btnTercess = new global::System.Windows.Forms.Button();
			this.grpTravel = new global::System.Windows.Forms.GroupBox();
			this.numPriv = new global::System.Windows.Forms.NumericUpDown();
			this.chkPriv = new global::System.Windows.Forms.CheckBox();
			this.btnCarnage = new global::System.Windows.Forms.Button();
			this.btnLae = new global::System.Windows.Forms.Button();
			this.btnPolish = new global::System.Windows.Forms.Button();
			this.grpTravel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPriv).BeginInit();
			base.SuspendLayout();
			this.btnDage.Location = new global::System.Drawing.Point(6, 305);
			this.btnDage.Name = "btnDage";
			this.btnDage.Size = new global::System.Drawing.Size(152, 23);
			this.btnDage.TabIndex = 0;
			this.btnDage.Text = "Dage";
			this.btnDage.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnDage.UseVisualStyleBackColor = true;
			this.btnDage.Click += new global::System.EventHandler(this.btnDage_Click);
			this.btnEscherion.Location = new global::System.Drawing.Point(6, 334);
			this.btnEscherion.Name = "btnEscherion";
			this.btnEscherion.Size = new global::System.Drawing.Size(152, 23);
			this.btnEscherion.TabIndex = 1;
			this.btnEscherion.Text = "Escherion";
			this.btnEscherion.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnEscherion.UseVisualStyleBackColor = true;
			this.btnEscherion.Click += new global::System.EventHandler(this.btnEscherion_Click);
			this.btnBinky.Location = new global::System.Drawing.Point(6, 276);
			this.btnBinky.Name = "btnBinky";
			this.btnBinky.Size = new global::System.Drawing.Size(152, 23);
			this.btnBinky.TabIndex = 2;
			this.btnBinky.Text = "Binky (doomvault)";
			this.btnBinky.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnBinky.UseVisualStyleBackColor = true;
			this.btnBinky.Click += new global::System.EventHandler(this.btnBinky_Click);
			this.btnNulgath.Location = new global::System.Drawing.Point(6, 160);
			this.btnNulgath.Name = "btnNulgath";
			this.btnNulgath.Size = new global::System.Drawing.Size(152, 23);
			this.btnNulgath.TabIndex = 3;
			this.btnNulgath.Text = "Nulgath / Skew (tercess)";
			this.btnNulgath.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnNulgath.UseVisualStyleBackColor = true;
			this.btnNulgath.Click += new global::System.EventHandler(this.btnNulgath_Click);
			this.btnSwindle.Location = new global::System.Drawing.Point(6, 131);
			this.btnSwindle.Name = "btnSwindle";
			this.btnSwindle.Size = new global::System.Drawing.Size(152, 23);
			this.btnSwindle.TabIndex = 4;
			this.btnSwindle.Text = "Swindle (tercess)";
			this.btnSwindle.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnSwindle.UseVisualStyleBackColor = true;
			this.btnSwindle.Click += new global::System.EventHandler(this.btnSwindle_Click);
			this.btnTaro.Location = new global::System.Drawing.Point(6, 102);
			this.btnTaro.Name = "btnTaro";
			this.btnTaro.Size = new global::System.Drawing.Size(152, 23);
			this.btnTaro.TabIndex = 5;
			this.btnTaro.Text = "VHL/Taro/Zee (tercess)";
			this.btnTaro.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnTaro.UseVisualStyleBackColor = true;
			this.btnTaro.Click += new global::System.EventHandler(this.btnTaro_Click);
			this.btnTwins.Location = new global::System.Drawing.Point(6, 73);
			this.btnTwins.Name = "btnTwins";
			this.btnTwins.Size = new global::System.Drawing.Size(152, 23);
			this.btnTwins.TabIndex = 6;
			this.btnTwins.Text = "Twins (tercess)";
			this.btnTwins.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnTwins.UseVisualStyleBackColor = true;
			this.btnTwins.Click += new global::System.EventHandler(this.btnTwins_Click);
			this.btnTercess.Location = new global::System.Drawing.Point(6, 44);
			this.btnTercess.Name = "btnTercess";
			this.btnTercess.Size = new global::System.Drawing.Size(152, 23);
			this.btnTercess.TabIndex = 7;
			this.btnTercess.Text = "Oblivion (tercess)";
			this.btnTercess.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnTercess.UseVisualStyleBackColor = true;
			this.btnTercess.Click += new global::System.EventHandler(this.btnTercess_Click);
			this.grpTravel.Controls.Add(this.numPriv);
			this.grpTravel.Controls.Add(this.btnPolish);
			this.grpTravel.Controls.Add(this.btnLae);
			this.grpTravel.Controls.Add(this.btnCarnage);
			this.grpTravel.Controls.Add(this.btnDage);
			this.grpTravel.Controls.Add(this.btnEscherion);
			this.grpTravel.Controls.Add(this.btnBinky);
			this.grpTravel.Controls.Add(this.btnNulgath);
			this.grpTravel.Controls.Add(this.btnSwindle);
			this.grpTravel.Controls.Add(this.btnTaro);
			this.grpTravel.Controls.Add(this.btnTwins);
			this.grpTravel.Controls.Add(this.btnTercess);
			this.grpTravel.Controls.Add(this.chkPriv);
			this.grpTravel.Location = new global::System.Drawing.Point(13, 13);
			this.grpTravel.Name = "grpTravel";
			this.grpTravel.Size = new global::System.Drawing.Size(164, 365);
			this.grpTravel.TabIndex = 8;
			this.grpTravel.TabStop = false;
			this.grpTravel.Text = "Fast travels";
			this.numPriv.Enabled = false;
			this.numPriv.Location = new global::System.Drawing.Point(64, 18);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numPriv;
			int[] array = new int[4];
			array[0] = 1000000;
			numericUpDown.Maximum = new decimal(array);
			this.numPriv.Name = "numPriv";
			this.numPriv.Size = new global::System.Drawing.Size(94, 20);
			this.numPriv.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numPriv;
			int[] array2 = new int[4];
			array2[0] = 100000;
			numericUpDown2.Value = new decimal(array2);
			this.chkPriv.AutoSize = true;
			this.chkPriv.Location = new global::System.Drawing.Point(6, 19);
			this.chkPriv.Name = "chkPriv";
			this.chkPriv.Size = new global::System.Drawing.Size(59, 17);
			this.chkPriv.TabIndex = 0;
			this.chkPriv.Text = "Private";
			this.chkPriv.UseVisualStyleBackColor = true;
			this.chkPriv.CheckedChanged += new global::System.EventHandler(this.chkPriv_CheckedChanged);
			this.btnCarnage.Location = new global::System.Drawing.Point(6, 218);
			this.btnCarnage.Name = "btnCarnage";
			this.btnCarnage.Size = new global::System.Drawing.Size(152, 23);
			this.btnCarnage.TabIndex = 0;
			this.btnCarnage.Text = "Carnage / Ninja (tercess)";
			this.btnCarnage.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnCarnage.UseVisualStyleBackColor = true;
			this.btnCarnage.Click += new global::System.EventHandler(this.btnCarnage_Click);
			this.btnLae.Location = new global::System.Drawing.Point(6, 247);
			this.btnLae.Name = "btnLae";
			this.btnLae.Size = new global::System.Drawing.Size(152, 23);
			this.btnLae.TabIndex = 0;
			this.btnLae.Text = "Lae (tercess)";
			this.btnLae.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnLae.UseVisualStyleBackColor = true;
			this.btnLae.Click += new global::System.EventHandler(this.btnLae_Click);
			this.btnPolish.Location = new global::System.Drawing.Point(6, 189);
			this.btnPolish.Name = "btnPolish";
			this.btnPolish.Size = new global::System.Drawing.Size(152, 23);
			this.btnPolish.TabIndex = 0;
			this.btnPolish.Text = "Polish (tercess)";
			this.btnPolish.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnPolish.UseVisualStyleBackColor = true;
			this.btnPolish.Click += new global::System.EventHandler(this.btnPolish_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(189, 390);
			base.Controls.Add(this.grpTravel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Travel";
			this.Text = "Fast travels";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Travel_FormClosing);
			this.grpTravel.ResumeLayout(false);
			this.grpTravel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPriv).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400027B RID: 635
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400027C RID: 636
		private global::System.Windows.Forms.Button btnDage;

		// Token: 0x0400027D RID: 637
		private global::System.Windows.Forms.Button btnEscherion;

		// Token: 0x0400027E RID: 638
		private global::System.Windows.Forms.Button btnNulgath;

		// Token: 0x0400027F RID: 639
		private global::System.Windows.Forms.Button btnSwindle;

		// Token: 0x04000280 RID: 640
		private global::System.Windows.Forms.Button btnTaro;

		// Token: 0x04000281 RID: 641
		private global::System.Windows.Forms.Button btnTwins;

		// Token: 0x04000282 RID: 642
		private global::System.Windows.Forms.Button btnTercess;

		// Token: 0x04000283 RID: 643
		private global::System.Windows.Forms.GroupBox grpTravel;

		// Token: 0x04000284 RID: 644
		private global::System.Windows.Forms.NumericUpDown numPriv;

		// Token: 0x04000285 RID: 645
		private global::System.Windows.Forms.CheckBox chkPriv;

		// Token: 0x04000286 RID: 646
		private global::System.Windows.Forms.Button btnPolish;

		// Token: 0x04000287 RID: 647
		private global::System.Windows.Forms.Button btnLae;

		// Token: 0x04000288 RID: 648
		private global::System.Windows.Forms.Button btnCarnage;

		// Token: 0x04000289 RID: 649
		private global::System.Windows.Forms.Button btnBinky;
	}
}
