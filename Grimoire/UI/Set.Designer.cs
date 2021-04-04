namespace Grimoire.UI
{
	// Token: 0x0200004E RID: 78
	public partial class Set : global::System.Windows.Forms.Form
	{
		// Token: 0x06000242 RID: 578 RVA: 0x0000370E File Offset: 0x0000190E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00024EF8 File Offset: 0x000230F8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.Set));
			this.btnSave = new global::System.Windows.Forms.Button();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.saveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.btnLoad = new global::System.Windows.Forms.Button();
			this.btnClear = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.btnSave.Location = new global::System.Drawing.Point(10, 355);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(112, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(10, 65);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(352, 121);
			this.listBox1.TabIndex = 1;
			this.comboBox1.DisplayMember = "Name";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(58, 13);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(206, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.openFileDialog1.FileName = "openFileDialog1";
			this.btnAdd.Location = new global::System.Drawing.Point(270, 11);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(98, 23);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.btnRefresh.Location = new global::System.Drawing.Point(12, 12);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new global::System.Drawing.Size(40, 23);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.Text = "R";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			this.btnLoad.Location = new global::System.Drawing.Point(250, 355);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new global::System.Drawing.Size(112, 23);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new global::System.EventHandler(this.btnLoad_Click);
			this.btnClear.Location = new global::System.Drawing.Point(270, 36);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(98, 23);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(374, 387);
			base.Controls.Add(this.btnRefresh);
			base.Controls.Add(this.btnClear);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.btnLoad);
			base.Controls.Add(this.btnSave);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Set";
			this.Text = "Set";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Set_FormClosing);
			base.Load += new global::System.EventHandler(this.Set_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400026A RID: 618
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400026B RID: 619
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x0400026C RID: 620
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400026D RID: 621
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x0400026E RID: 622
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;

		// Token: 0x0400026F RID: 623
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x04000270 RID: 624
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000271 RID: 625
		private global::System.Windows.Forms.Button btnRefresh;

		// Token: 0x04000272 RID: 626
		private global::System.Windows.Forms.Button btnLoad;

		// Token: 0x04000273 RID: 627
		private global::System.Windows.Forms.Button btnClear;
	}
}
