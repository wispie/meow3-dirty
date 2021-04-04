namespace Grimoire.UI
{
	// Token: 0x0200004A RID: 74
	public partial class RawCommandEditor : global::System.Windows.Forms.Form
	{
		// Token: 0x06000202 RID: 514 RVA: 0x000034CB File Offset: 0x000016CB
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00022A3C File Offset: 0x00020C3C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.RawCommandEditor));
			this.btnOK = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.txtCmd = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.btnOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new global::System.Drawing.Point(197, 166);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(116, 166);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.txtCmd.Location = new global::System.Drawing.Point(12, 12);
			this.txtCmd.Multiline = true;
			this.txtCmd.Name = "txtCmd";
			this.txtCmd.Size = new global::System.Drawing.Size(260, 148);
			this.txtCmd.TabIndex = 2;
			this.txtCmd.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtCmd_KeyDown);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 201);
			base.Controls.Add(this.txtCmd);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOK);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "RawCommandEditor";
			this.Text = "Raw Command Editor";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.RawCommandEditor_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000236 RID: 566
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000237 RID: 567
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x04000238 RID: 568
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000239 RID: 569
		private global::System.Windows.Forms.TextBox txtCmd;
	}
}
