namespace Grimoire.UI
{
	// Token: 0x02000045 RID: 69
	public partial class PluginManager : global::System.Windows.Forms.Form
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x0000341E File Offset: 0x0000161E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00022344 File Offset: 0x00020544
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.PluginManager));
			this.gbLoaded = new global::System.Windows.Forms.GroupBox();
			this.btnUnload = new global::System.Windows.Forms.Button();
			this.txtDesc = new global::System.Windows.Forms.TextBox();
			this.lblAuthor = new global::System.Windows.Forms.Label();
			this.lstLoaded = new global::System.Windows.Forms.ListBox();
			this.gbLoad = new global::System.Windows.Forms.GroupBox();
			this.btnBrowse = new global::System.Windows.Forms.Button();
			this.btnLoad = new global::System.Windows.Forms.Button();
			this.txtPlugin = new global::System.Windows.Forms.TextBox();
			this.treePlugins = new global::System.Windows.Forms.TreeView();
			this.gbLoaded.SuspendLayout();
			this.gbLoad.SuspendLayout();
			base.SuspendLayout();
			this.gbLoaded.Controls.Add(this.btnUnload);
			this.gbLoaded.Controls.Add(this.txtDesc);
			this.gbLoaded.Controls.Add(this.lblAuthor);
			this.gbLoaded.Controls.Add(this.lstLoaded);
			this.gbLoaded.Location = new global::System.Drawing.Point(12, 213);
			this.gbLoaded.Name = "gbLoaded";
			this.gbLoaded.Size = new global::System.Drawing.Size(292, 267);
			this.gbLoaded.TabIndex = 12;
			this.gbLoaded.TabStop = false;
			this.gbLoaded.Text = "Loaded plugins";
			this.btnUnload.Location = new global::System.Drawing.Point(155, 238);
			this.btnUnload.Name = "btnUnload";
			this.btnUnload.Size = new global::System.Drawing.Size(128, 23);
			this.btnUnload.TabIndex = 3;
			this.btnUnload.Text = "Unload selected plugin";
			this.btnUnload.UseVisualStyleBackColor = true;
			this.btnUnload.Click += new global::System.EventHandler(this.btnUnload_Click);
			this.txtDesc.Location = new global::System.Drawing.Point(6, 120);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtDesc.Size = new global::System.Drawing.Size(277, 112);
			this.txtDesc.TabIndex = 2;
			this.lblAuthor.AutoSize = true;
			this.lblAuthor.Location = new global::System.Drawing.Point(6, 104);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new global::System.Drawing.Size(92, 13);
			this.lblAuthor.TabIndex = 1;
			this.lblAuthor.Text = "Plugin created by:";
			this.lstLoaded.FormattingEnabled = true;
			this.lstLoaded.Location = new global::System.Drawing.Point(6, 19);
			this.lstLoaded.Name = "lstLoaded";
			this.lstLoaded.ScrollAlwaysVisible = true;
			this.lstLoaded.Size = new global::System.Drawing.Size(277, 82);
			this.lstLoaded.TabIndex = 0;
			this.lstLoaded.SelectedIndexChanged += new global::System.EventHandler(this.lstLoaded_SelectedIndexChanged);
			this.gbLoad.Controls.Add(this.btnBrowse);
			this.gbLoad.Controls.Add(this.btnLoad);
			this.gbLoad.Controls.Add(this.txtPlugin);
			this.gbLoad.Location = new global::System.Drawing.Point(12, 12);
			this.gbLoad.Name = "gbLoad";
			this.gbLoad.Size = new global::System.Drawing.Size(292, 51);
			this.gbLoad.TabIndex = 11;
			this.gbLoad.TabStop = false;
			this.gbLoad.Text = "Load plugin";
			this.btnBrowse.Location = new global::System.Drawing.Point(200, 17);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new global::System.Drawing.Size(25, 23);
			this.btnBrowse.TabIndex = 7;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new global::System.EventHandler(this.btnBrowse_Click);
			this.btnLoad.Location = new global::System.Drawing.Point(231, 17);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new global::System.Drawing.Size(55, 23);
			this.btnLoad.TabIndex = 8;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new global::System.EventHandler(this.btnLoad_Click);
			this.txtPlugin.Location = new global::System.Drawing.Point(6, 19);
			this.txtPlugin.Name = "txtPlugin";
			this.txtPlugin.Size = new global::System.Drawing.Size(188, 20);
			this.txtPlugin.TabIndex = 4;
			this.treePlugins.Location = new global::System.Drawing.Point(12, 70);
			this.treePlugins.Name = "treePlugins";
			this.treePlugins.Size = new global::System.Drawing.Size(292, 136);
			this.treePlugins.TabIndex = 13;
			this.treePlugins.AfterExpand += new global::System.Windows.Forms.TreeViewEventHandler(this.treePlugins_AfterExpand);
			this.treePlugins.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treePlugins_AfterSelect);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(316, 485);
			base.Controls.Add(this.treePlugins);
			base.Controls.Add(this.gbLoaded);
			base.Controls.Add(this.gbLoad);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "PluginManager";
			this.Text = "Plugin Manager";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.PluginManager_FormClosing);
			base.Load += new global::System.EventHandler(this.PluginManager_Load);
			this.gbLoaded.ResumeLayout(false);
			this.gbLoaded.PerformLayout();
			this.gbLoad.ResumeLayout(false);
			this.gbLoad.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000224 RID: 548
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000225 RID: 549
		public global::System.Windows.Forms.GroupBox gbLoaded;

		// Token: 0x04000226 RID: 550
		public global::System.Windows.Forms.Button btnUnload;

		// Token: 0x04000227 RID: 551
		public global::System.Windows.Forms.TextBox txtDesc;

		// Token: 0x04000228 RID: 552
		public global::System.Windows.Forms.Label lblAuthor;

		// Token: 0x04000229 RID: 553
		public global::System.Windows.Forms.ListBox lstLoaded;

		// Token: 0x0400022A RID: 554
		public global::System.Windows.Forms.GroupBox gbLoad;

		// Token: 0x0400022B RID: 555
		public global::System.Windows.Forms.Button btnBrowse;

		// Token: 0x0400022C RID: 556
		public global::System.Windows.Forms.Button btnLoad;

		// Token: 0x0400022D RID: 557
		private global::System.Windows.Forms.TreeView treePlugins;

		// Token: 0x0400022E RID: 558
		public global::System.Windows.Forms.TextBox txtPlugin;
	}
}
