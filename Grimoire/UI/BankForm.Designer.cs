namespace Grimoire.UI
{
	// Token: 0x02000010 RID: 16
	public partial class BankForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000021A8 File Offset: 0x000003A8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00008E88 File Offset: 0x00007088
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.BankForm));
			this.label1 = new global::System.Windows.Forms.Label();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(13, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(118, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "What to bank (optional)";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[]
			{
				"Weapons",
				"Sword",
				"Axe",
				"Dagger",
				"Gun",
				"Bow",
				"Mace",
				"Polearm",
				"Staff",
				"Wand",
				"Class",
				"Armor",
				"Helm",
				"Cape",
				"Item"
			});
			this.comboBox1.Location = new global::System.Drawing.Point(12, 26);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(170, 21);
			this.comboBox1.TabIndex = 1;
			this.button1.Location = new global::System.Drawing.Point(12, 122);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(83, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Bank";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_ClickAsync);
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[]
			{
				"ACs",
				"Non-ACs"
			});
			this.comboBox2.Location = new global::System.Drawing.Point(12, 67);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(170, 21);
			this.comboBox2.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 51);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(73, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "AC or Non-AC";
			this.button2.Location = new global::System.Drawing.Point(101, 122);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(81, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Bank All";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_ClickAsync);
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new global::System.Drawing.Point(24, 97);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(142, 17);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Bank all except selected";
			this.checkBox1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(194, 151);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.comboBox2);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(210, 173);
			base.Name = "BankForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = " Bank";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.BankForm_FormClosing);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000009 RID: 9
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.CheckBox checkBox1;
	}
}
