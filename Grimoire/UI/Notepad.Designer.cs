namespace Grimoire.UI
{
	// Token: 0x0200003A RID: 58
	public partial class Notepad : global::System.Windows.Forms.Form
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x0000301C File Offset: 0x0000121C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001FD7C File Offset: 0x0001DF7C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.Notepad));
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.richTextBox1.AllowDrop = true;
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new global::System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(480, 227);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.richTextBox1.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.Notepad_DragDrop);
			this.richTextBox1.DragOver += new global::System.Windows.Forms.DragEventHandler(this.Notepad_DragOver);
			this.richTextBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
			this.panel1.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(480, 227);
			this.panel1.TabIndex = 4;
			this.panel1.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.Notepad_DragDrop);
			this.panel1.DragOver += new global::System.Windows.Forms.DragEventHandler(this.Notepad_DragOver);
			this.AllowDrop = true;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.ClientSize = new global::System.Drawing.Size(480, 227);
			base.Controls.Add(this.panel1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MinimizeBox = false;
			base.Name = "Notepad";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Notepad";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
			base.Load += new global::System.EventHandler(this.Notepad_Load);
			base.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.Notepad_DragDrop);
			base.DragOver += new global::System.Windows.Forms.DragEventHandler(this.Notepad_DragOver);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040001EB RID: 491
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001EC RID: 492
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x040001ED RID: 493
		private global::System.Windows.Forms.Panel panel1;
	}
}
