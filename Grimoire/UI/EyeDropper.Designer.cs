namespace Grimoire.UI
{
	// Token: 0x02000027 RID: 39
	public partial class EyeDropper : global::System.Windows.Forms.Form
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00002C74 File Offset: 0x00000E74
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0001C128 File Offset: 0x0001A328
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.EyeDropper));
			this.eyeDropper1 = new global::Unity3.Eyedropper.EyeDropper();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.eyeDropper1.Location = new global::System.Drawing.Point(10, 8);
			this.eyeDropper1.MaximumSize = new global::System.Drawing.Size(22, 22);
			this.eyeDropper1.MinimumSize = new global::System.Drawing.Size(22, 22);
			this.eyeDropper1.Name = "eyeDropper1";
			this.eyeDropper1.PixelPreviewSize = new global::System.Drawing.Size(100, 50);
			this.eyeDropper1.PreviewLocation = new global::System.Drawing.Point(-130, 0);
			this.eyeDropper1.PreviewPositionStyle = global::Unity3.Eyedropper.EyeDropper.ePreviewPositionStyle.Manual;
			this.eyeDropper1.SelectedColor = global::System.Drawing.Color.Empty;
			this.eyeDropper1.Size = new global::System.Drawing.Size(22, 22);
			this.eyeDropper1.TabIndex = 0;
			this.eyeDropper1.Text = "eyeDropper1";
			this.eyeDropper1.ScreenCaptured += new global::Unity3.Eyedropper.EyeDropper.ScreenCapturedArgs(this.eyeDropper1_ScreenCaptured);
			this.eyeDropper1.EndScreenCapture += new global::System.EventHandler(this.eyeDropper1_EndScreenCapture);
			this.richTextBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.richTextBox1.Location = new global::System.Drawing.Point(0, 34);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(235, 104);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.textBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new global::System.Drawing.Point(43, -3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(192, 37);
			this.textBox1.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(235, 138);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.eyeDropper1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "EyeDropper";
			this.Text = " Eye Dropper";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000178 RID: 376
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000179 RID: 377
		private global::Unity3.Eyedropper.EyeDropper eyeDropper1;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.TextBox textBox1;
	}
}
