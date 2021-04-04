namespace Grimoire.UI
{
	// Token: 0x02000024 RID: 36
	public partial class CosmeticForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00002C15 File Offset: 0x00000E15
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00019E0C File Offset: 0x0001800C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Grimoire.UI.CosmeticForm));
			this.cbPlayer = new global::System.Windows.Forms.ComboBox();
			this.btnGrabCosm = new global::System.Windows.Forms.Button();
			this.lbItems = new global::System.Windows.Forms.ListBox();
			this.btnCopyAll = new global::System.Windows.Forms.Button();
			this.btnEquipSelected = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.btnClear = new global::System.Windows.Forms.Button();
			this.btnRemove = new global::System.Windows.Forms.Button();
			this.linkHelm = new global::System.Windows.Forms.LinkLabel();
			this.linkArmor = new global::System.Windows.Forms.LinkLabel();
			this.linkWeapon = new global::System.Windows.Forms.LinkLabel();
			this.linkPet = new global::System.Windows.Forms.LinkLabel();
			this.linkCape = new global::System.Windows.Forms.LinkLabel();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.linkClass = new global::System.Windows.Forms.LinkLabel();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.txtArmor1 = new global::System.Windows.Forms.TextBox();
			this.txtHelm1 = new global::System.Windows.Forms.TextBox();
			this.txtWeapon1 = new global::System.Windows.Forms.TextBox();
			this.txtClass1 = new global::System.Windows.Forms.TextBox();
			this.txtCape1 = new global::System.Windows.Forms.TextBox();
			this.txtPet1 = new global::System.Windows.Forms.TextBox();
			this.btnHelmSet = new global::System.Windows.Forms.Button();
			this.btnArmorSet = new global::System.Windows.Forms.Button();
			this.btnClassSet = new global::System.Windows.Forms.Button();
			this.btnWeaponSet = new global::System.Windows.Forms.Button();
			this.btnPetSet = new global::System.Windows.Forms.Button();
			this.btnCapeSet = new global::System.Windows.Forms.Button();
			this.txtHelm2 = new global::System.Windows.Forms.TextBox();
			this.txtArmor2 = new global::System.Windows.Forms.TextBox();
			this.txtClass2 = new global::System.Windows.Forms.TextBox();
			this.txtWeapon2 = new global::System.Windows.Forms.TextBox();
			this.txtPet2 = new global::System.Windows.Forms.TextBox();
			this.txtCape2 = new global::System.Windows.Forms.TextBox();
			this.tableLayoutPanel3 = new global::System.Windows.Forms.TableLayoutPanel();
			this.txtOff2 = new global::System.Windows.Forms.TextBox();
			this.txtOff1 = new global::System.Windows.Forms.TextBox();
			this.btnSetOffhand = new global::System.Windows.Forms.Button();
			this.label7 = new global::System.Windows.Forms.Label();
			this.btnSaveSet = new global::System.Windows.Forms.Button();
			this.btnLoadSet = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			base.SuspendLayout();
			this.cbPlayer.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.cbPlayer.FormattingEnabled = true;
			this.cbPlayer.Location = new global::System.Drawing.Point(42, 14);
			this.cbPlayer.Name = "cbPlayer";
			this.cbPlayer.Size = new global::System.Drawing.Size(220, 21);
			this.cbPlayer.TabIndex = 0;
			this.btnGrabCosm.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnGrabCosm.Location = new global::System.Drawing.Point(264, 13);
			this.btnGrabCosm.Name = "btnGrabCosm";
			this.btnGrabCosm.Size = new global::System.Drawing.Size(94, 23);
			this.btnGrabCosm.TabIndex = 1;
			this.btnGrabCosm.Text = "Grab";
			this.btnGrabCosm.UseVisualStyleBackColor = true;
			this.btnGrabCosm.Click += new global::System.EventHandler(this.btnGrabCosm_Click);
			this.lbItems.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lbItems.FormattingEnabled = true;
			this.lbItems.Location = new global::System.Drawing.Point(12, 245);
			this.lbItems.Name = "lbItems";
			this.lbItems.Size = new global::System.Drawing.Size(466, 199);
			this.lbItems.TabIndex = 2;
			this.lbItems.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.lbItems_KeyDown);
			this.lbItems.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.lbItems_MouseDoubleClick);
			this.btnCopyAll.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnCopyAll.Location = new global::System.Drawing.Point(3, 3);
			this.btnCopyAll.Name = "btnCopyAll";
			this.btnCopyAll.Size = new global::System.Drawing.Size(110, 23);
			this.btnCopyAll.TabIndex = 4;
			this.btnCopyAll.Text = "Equip All";
			this.btnCopyAll.UseVisualStyleBackColor = true;
			this.btnCopyAll.Click += new global::System.EventHandler(this.btnCopyAll_Click);
			this.btnEquipSelected.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnEquipSelected.Location = new global::System.Drawing.Point(119, 3);
			this.btnEquipSelected.Name = "btnEquipSelected";
			this.btnEquipSelected.Size = new global::System.Drawing.Size(110, 23);
			this.btnEquipSelected.TabIndex = 5;
			this.btnEquipSelected.Text = "Equip Selected";
			this.btnEquipSelected.UseVisualStyleBackColor = true;
			this.btnEquipSelected.Click += new global::System.EventHandler(this.btnEquipSelected_Click);
			this.tableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel1.Controls.Add(this.btnCopyAll, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnEquipSelected, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRemove, 3, 0);
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(12, 448);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(466, 29);
			this.tableLayoutPanel1.TabIndex = 7;
			this.btnClear.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnClear.Location = new global::System.Drawing.Point(235, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new global::System.Drawing.Size(110, 23);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Clear All";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
			this.btnRemove.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnRemove.Location = new global::System.Drawing.Point(351, 3);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new global::System.Drawing.Size(112, 23);
			this.btnRemove.TabIndex = 6;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new global::System.EventHandler(this.btnRemove_Click);
			this.linkHelm.AutoSize = true;
			this.linkHelm.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.linkHelm.LinkColor = global::System.Drawing.SystemColors.ControlText;
			this.linkHelm.Location = new global::System.Drawing.Point(3, 0);
			this.linkHelm.Name = "linkHelm";
			this.linkHelm.Size = new global::System.Drawing.Size(70, 14);
			this.linkHelm.TabIndex = 8;
			this.linkHelm.TabStop = true;
			this.linkHelm.Text = "Grab Helm";
			this.linkHelm.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.linkHelm.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkItems_LinkClicked);
			this.linkArmor.AutoSize = true;
			this.linkArmor.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.linkArmor.LinkColor = global::System.Drawing.SystemColors.ControlText;
			this.linkArmor.Location = new global::System.Drawing.Point(79, 0);
			this.linkArmor.Name = "linkArmor";
			this.linkArmor.Size = new global::System.Drawing.Size(71, 14);
			this.linkArmor.TabIndex = 8;
			this.linkArmor.TabStop = true;
			this.linkArmor.Text = "Grab Armor";
			this.linkArmor.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.linkArmor.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkItems_LinkClicked);
			this.linkWeapon.AutoSize = true;
			this.linkWeapon.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.linkWeapon.LinkColor = global::System.Drawing.SystemColors.ControlText;
			this.linkWeapon.Location = new global::System.Drawing.Point(232, 0);
			this.linkWeapon.Name = "linkWeapon";
			this.linkWeapon.Size = new global::System.Drawing.Size(73, 14);
			this.linkWeapon.TabIndex = 8;
			this.linkWeapon.TabStop = true;
			this.linkWeapon.Text = "Grab Wep";
			this.linkWeapon.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.linkWeapon.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkItems_LinkClicked);
			this.linkPet.AutoSize = true;
			this.linkPet.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.linkPet.LinkColor = global::System.Drawing.SystemColors.ControlText;
			this.linkPet.Location = new global::System.Drawing.Point(311, 0);
			this.linkPet.Name = "linkPet";
			this.linkPet.Size = new global::System.Drawing.Size(70, 14);
			this.linkPet.TabIndex = 8;
			this.linkPet.TabStop = true;
			this.linkPet.Text = "Grab Pet";
			this.linkPet.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.linkPet.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkItems_LinkClicked);
			this.linkCape.AutoSize = true;
			this.linkCape.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.linkCape.LinkColor = global::System.Drawing.SystemColors.ControlText;
			this.linkCape.Location = new global::System.Drawing.Point(387, 0);
			this.linkCape.Name = "linkCape";
			this.linkCape.Size = new global::System.Drawing.Size(72, 14);
			this.linkCape.TabIndex = 8;
			this.linkCape.TabStop = true;
			this.linkCape.Text = "Grab Cape";
			this.linkCape.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.linkCape.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkItems_LinkClicked);
			this.btnRefresh.Location = new global::System.Drawing.Point(12, 13);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new global::System.Drawing.Size(24, 23);
			this.btnRefresh.TabIndex = 9;
			this.btnRefresh.Text = "⟳";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			this.linkClass.AutoSize = true;
			this.linkClass.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.linkClass.LinkColor = global::System.Drawing.SystemColors.ControlText;
			this.linkClass.Location = new global::System.Drawing.Point(156, 0);
			this.linkClass.Name = "linkClass";
			this.linkClass.Size = new global::System.Drawing.Size(70, 14);
			this.linkClass.TabIndex = 8;
			this.linkClass.TabStop = true;
			this.linkClass.Text = "Grab Class";
			this.linkClass.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.linkClass.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkItems_LinkClicked);
			this.tableLayoutPanel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel2.ColumnCount = 6;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 16.50471f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 16.83479f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 16.5047f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 17.1464f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 16.5047f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 16.5047f));
			this.tableLayoutPanel2.Controls.Add(this.linkHelm, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.linkArmor, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.linkCape, 5, 0);
			this.tableLayoutPanel2.Controls.Add(this.linkClass, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.linkPet, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.linkWeapon, 3, 0);
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(12, 41);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(462, 14);
			this.tableLayoutPanel2.TabIndex = 10;
			this.label1.AutoSize = true;
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new global::System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(52, 24);
			this.label1.TabIndex = 11;
			this.label1.Text = "Helm";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.AutoSize = true;
			this.label2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new global::System.Drawing.Point(3, 24);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(52, 24);
			this.label2.TabIndex = 11;
			this.label2.Text = "Armor";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.AutoSize = true;
			this.label3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new global::System.Drawing.Point(3, 48);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(52, 24);
			this.label3.TabIndex = 11;
			this.label3.Text = "Class";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.AutoSize = true;
			this.label4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new global::System.Drawing.Point(3, 72);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(52, 24);
			this.label4.TabIndex = 11;
			this.label4.Text = "Weapon";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.AutoSize = true;
			this.label5.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new global::System.Drawing.Point(3, 120);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(52, 24);
			this.label5.TabIndex = 11;
			this.label5.Text = "Pet";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new global::System.Drawing.Point(3, 144);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(52, 24);
			this.label6.TabIndex = 11;
			this.label6.Text = "Cape";
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.txtArmor1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtArmor1.Location = new global::System.Drawing.Point(60, 26);
			this.txtArmor1.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtArmor1.Name = "txtArmor1";
			this.txtArmor1.Size = new global::System.Drawing.Size(185, 20);
			this.txtArmor1.TabIndex = 12;
			this.txtHelm1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtHelm1.Location = new global::System.Drawing.Point(60, 2);
			this.txtHelm1.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtHelm1.Name = "txtHelm1";
			this.txtHelm1.Size = new global::System.Drawing.Size(185, 20);
			this.txtHelm1.TabIndex = 12;
			this.txtWeapon1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtWeapon1.Location = new global::System.Drawing.Point(60, 74);
			this.txtWeapon1.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtWeapon1.Name = "txtWeapon1";
			this.txtWeapon1.Size = new global::System.Drawing.Size(185, 20);
			this.txtWeapon1.TabIndex = 12;
			this.txtClass1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtClass1.Location = new global::System.Drawing.Point(60, 50);
			this.txtClass1.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtClass1.Name = "txtClass1";
			this.txtClass1.Size = new global::System.Drawing.Size(185, 20);
			this.txtClass1.TabIndex = 12;
			this.txtCape1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtCape1.Location = new global::System.Drawing.Point(60, 146);
			this.txtCape1.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtCape1.Name = "txtCape1";
			this.txtCape1.Size = new global::System.Drawing.Size(185, 20);
			this.txtCape1.TabIndex = 12;
			this.txtPet1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtPet1.Location = new global::System.Drawing.Point(60, 122);
			this.txtPet1.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtPet1.Name = "txtPet1";
			this.txtPet1.Size = new global::System.Drawing.Size(185, 20);
			this.txtPet1.TabIndex = 12;
			this.btnHelmSet.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnHelmSet.Location = new global::System.Drawing.Point(364, 1);
			this.btnHelmSet.Margin = new global::System.Windows.Forms.Padding(1);
			this.btnHelmSet.Name = "btnHelmSet";
			this.btnHelmSet.Size = new global::System.Drawing.Size(101, 22);
			this.btnHelmSet.TabIndex = 1;
			this.btnHelmSet.Text = "Set";
			this.btnHelmSet.UseVisualStyleBackColor = true;
			this.btnHelmSet.Click += new global::System.EventHandler(this.btnSet_Click);
			this.btnArmorSet.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnArmorSet.Location = new global::System.Drawing.Point(364, 25);
			this.btnArmorSet.Margin = new global::System.Windows.Forms.Padding(1);
			this.btnArmorSet.Name = "btnArmorSet";
			this.btnArmorSet.Size = new global::System.Drawing.Size(101, 22);
			this.btnArmorSet.TabIndex = 1;
			this.btnArmorSet.Text = "Set";
			this.btnArmorSet.UseVisualStyleBackColor = true;
			this.btnArmorSet.Click += new global::System.EventHandler(this.btnSet_Click);
			this.btnClassSet.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnClassSet.Location = new global::System.Drawing.Point(364, 49);
			this.btnClassSet.Margin = new global::System.Windows.Forms.Padding(1);
			this.btnClassSet.Name = "btnClassSet";
			this.btnClassSet.Size = new global::System.Drawing.Size(101, 22);
			this.btnClassSet.TabIndex = 1;
			this.btnClassSet.Text = "Set";
			this.btnClassSet.UseVisualStyleBackColor = true;
			this.btnClassSet.Click += new global::System.EventHandler(this.btnSet_Click);
			this.btnWeaponSet.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnWeaponSet.Location = new global::System.Drawing.Point(364, 73);
			this.btnWeaponSet.Margin = new global::System.Windows.Forms.Padding(1);
			this.btnWeaponSet.Name = "btnWeaponSet";
			this.btnWeaponSet.Size = new global::System.Drawing.Size(101, 22);
			this.btnWeaponSet.TabIndex = 1;
			this.btnWeaponSet.Text = "Set";
			this.btnWeaponSet.UseVisualStyleBackColor = true;
			this.btnWeaponSet.Click += new global::System.EventHandler(this.btnSet_Click);
			this.btnPetSet.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnPetSet.Location = new global::System.Drawing.Point(364, 121);
			this.btnPetSet.Margin = new global::System.Windows.Forms.Padding(1);
			this.btnPetSet.Name = "btnPetSet";
			this.btnPetSet.Size = new global::System.Drawing.Size(101, 22);
			this.btnPetSet.TabIndex = 1;
			this.btnPetSet.Text = "Set";
			this.btnPetSet.UseVisualStyleBackColor = true;
			this.btnPetSet.Click += new global::System.EventHandler(this.btnSet_Click);
			this.btnCapeSet.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnCapeSet.Location = new global::System.Drawing.Point(364, 145);
			this.btnCapeSet.Margin = new global::System.Windows.Forms.Padding(1);
			this.btnCapeSet.Name = "btnCapeSet";
			this.btnCapeSet.Size = new global::System.Drawing.Size(101, 22);
			this.btnCapeSet.TabIndex = 1;
			this.btnCapeSet.Text = "Set";
			this.btnCapeSet.UseVisualStyleBackColor = true;
			this.btnCapeSet.Click += new global::System.EventHandler(this.btnSet_Click);
			this.txtHelm2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtHelm2.Location = new global::System.Drawing.Point(249, 2);
			this.txtHelm2.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtHelm2.Name = "txtHelm2";
			this.txtHelm2.Size = new global::System.Drawing.Size(112, 20);
			this.txtHelm2.TabIndex = 13;
			this.txtArmor2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtArmor2.Location = new global::System.Drawing.Point(249, 26);
			this.txtArmor2.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtArmor2.Name = "txtArmor2";
			this.txtArmor2.Size = new global::System.Drawing.Size(112, 20);
			this.txtArmor2.TabIndex = 13;
			this.txtClass2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtClass2.Location = new global::System.Drawing.Point(249, 50);
			this.txtClass2.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtClass2.Name = "txtClass2";
			this.txtClass2.Size = new global::System.Drawing.Size(112, 20);
			this.txtClass2.TabIndex = 13;
			this.txtWeapon2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtWeapon2.Location = new global::System.Drawing.Point(249, 74);
			this.txtWeapon2.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtWeapon2.Name = "txtWeapon2";
			this.txtWeapon2.Size = new global::System.Drawing.Size(112, 20);
			this.txtWeapon2.TabIndex = 13;
			this.txtPet2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtPet2.Location = new global::System.Drawing.Point(249, 122);
			this.txtPet2.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtPet2.Name = "txtPet2";
			this.txtPet2.Size = new global::System.Drawing.Size(112, 20);
			this.txtPet2.TabIndex = 13;
			this.txtCape2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtCape2.Location = new global::System.Drawing.Point(249, 146);
			this.txtCape2.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtCape2.Name = "txtCape2";
			this.txtCape2.Size = new global::System.Drawing.Size(112, 20);
			this.txtCape2.TabIndex = 13;
			this.tableLayoutPanel3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 58f));
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 62.06897f));
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 37.93103f));
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 102f));
			this.tableLayoutPanel3.Controls.Add(this.btnCapeSet, 3, 6);
			this.tableLayoutPanel3.Controls.Add(this.label6, 0, 6);
			this.tableLayoutPanel3.Controls.Add(this.txtCape1, 1, 6);
			this.tableLayoutPanel3.Controls.Add(this.label5, 0, 5);
			this.tableLayoutPanel3.Controls.Add(this.txtPet1, 1, 5);
			this.tableLayoutPanel3.Controls.Add(this.txtCape2, 2, 6);
			this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.txtClass1, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnPetSet, 3, 5);
			this.tableLayoutPanel3.Controls.Add(this.txtPet2, 2, 5);
			this.tableLayoutPanel3.Controls.Add(this.txtClass2, 2, 2);
			this.tableLayoutPanel3.Controls.Add(this.txtArmor1, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.txtHelm1, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnClassSet, 3, 2);
			this.tableLayoutPanel3.Controls.Add(this.txtArmor2, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this.btnArmorSet, 3, 1);
			this.tableLayoutPanel3.Controls.Add(this.btnHelmSet, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.txtHelm2, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.txtWeapon1, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.txtWeapon2, 2, 3);
			this.tableLayoutPanel3.Controls.Add(this.btnWeaponSet, 3, 3);
			this.tableLayoutPanel3.Controls.Add(this.txtOff2, 2, 4);
			this.tableLayoutPanel3.Controls.Add(this.txtOff1, 1, 4);
			this.tableLayoutPanel3.Controls.Add(this.btnSetOffhand, 3, 4);
			this.tableLayoutPanel3.Controls.Add(this.label7, 0, 4);
			this.tableLayoutPanel3.Location = new global::System.Drawing.Point(12, 67);
			this.tableLayoutPanel3.Margin = new global::System.Windows.Forms.Padding(1);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 6;
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel3.Size = new global::System.Drawing.Size(466, 168);
			this.tableLayoutPanel3.TabIndex = 14;
			this.txtOff2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtOff2.Location = new global::System.Drawing.Point(249, 98);
			this.txtOff2.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtOff2.Name = "txtOff2";
			this.txtOff2.Size = new global::System.Drawing.Size(112, 20);
			this.txtOff2.TabIndex = 13;
			this.txtOff1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtOff1.Location = new global::System.Drawing.Point(60, 98);
			this.txtOff1.Margin = new global::System.Windows.Forms.Padding(2);
			this.txtOff1.Name = "txtOff1";
			this.txtOff1.Size = new global::System.Drawing.Size(185, 20);
			this.txtOff1.TabIndex = 12;
			this.btnSetOffhand.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnSetOffhand.Location = new global::System.Drawing.Point(364, 97);
			this.btnSetOffhand.Margin = new global::System.Windows.Forms.Padding(1);
			this.btnSetOffhand.Name = "btnSetOffhand";
			this.btnSetOffhand.Size = new global::System.Drawing.Size(101, 22);
			this.btnSetOffhand.TabIndex = 1;
			this.btnSetOffhand.Text = "Set";
			this.btnSetOffhand.UseVisualStyleBackColor = true;
			this.btnSetOffhand.Click += new global::System.EventHandler(this.btnSet_Click);
			this.label7.AutoSize = true;
			this.label7.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new global::System.Drawing.Point(3, 96);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(52, 24);
			this.label7.TabIndex = 11;
			this.label7.Text = "Off.H";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSaveSet.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSaveSet.Location = new global::System.Drawing.Point(359, 13);
			this.btnSaveSet.Name = "btnSaveSet";
			this.btnSaveSet.Size = new global::System.Drawing.Size(59, 23);
			this.btnSaveSet.TabIndex = 15;
			this.btnSaveSet.Text = "Save";
			this.btnSaveSet.UseVisualStyleBackColor = true;
			this.btnSaveSet.Click += new global::System.EventHandler(this.btnSaveSet_Click);
			this.btnLoadSet.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnLoadSet.Location = new global::System.Drawing.Point(419, 13);
			this.btnLoadSet.Name = "btnLoadSet";
			this.btnLoadSet.Size = new global::System.Drawing.Size(59, 23);
			this.btnLoadSet.TabIndex = 15;
			this.btnLoadSet.Text = "Load";
			this.btnLoadSet.UseVisualStyleBackColor = true;
			this.btnLoadSet.Click += new global::System.EventHandler(this.btnLoadSet_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(490, 484);
			base.Controls.Add(this.btnLoadSet);
			base.Controls.Add(this.btnSaveSet);
			base.Controls.Add(this.tableLayoutPanel3);
			base.Controls.Add(this.tableLayoutPanel2);
			base.Controls.Add(this.btnRefresh);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Controls.Add(this.lbItems);
			base.Controls.Add(this.btnGrabCosm);
			base.Controls.Add(this.cbPlayer);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "CosmeticForm";
			this.Text = "SWF Cosmetics";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.CosmeticForm_FormClosing);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000140 RID: 320
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Forms.ComboBox cbPlayer;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.Button btnGrabCosm;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.ListBox lbItems;

		// Token: 0x04000144 RID: 324
		private global::System.Windows.Forms.Button btnCopyAll;

		// Token: 0x04000145 RID: 325
		private global::System.Windows.Forms.Button btnEquipSelected;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.Button btnClear;

		// Token: 0x04000148 RID: 328
		private global::System.Windows.Forms.LinkLabel linkHelm;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.LinkLabel linkArmor;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.LinkLabel linkWeapon;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.LinkLabel linkPet;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Forms.LinkLabel linkCape;

		// Token: 0x0400014D RID: 333
		private global::System.Windows.Forms.Button btnRefresh;

		// Token: 0x0400014E RID: 334
		private global::System.Windows.Forms.LinkLabel linkClass;

		// Token: 0x0400014F RID: 335
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000152 RID: 338
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000153 RID: 339
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000154 RID: 340
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000155 RID: 341
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000156 RID: 342
		private global::System.Windows.Forms.TextBox txtArmor1;

		// Token: 0x04000157 RID: 343
		private global::System.Windows.Forms.TextBox txtHelm1;

		// Token: 0x04000158 RID: 344
		private global::System.Windows.Forms.TextBox txtWeapon1;

		// Token: 0x04000159 RID: 345
		private global::System.Windows.Forms.TextBox txtClass1;

		// Token: 0x0400015A RID: 346
		private global::System.Windows.Forms.TextBox txtCape1;

		// Token: 0x0400015B RID: 347
		private global::System.Windows.Forms.TextBox txtPet1;

		// Token: 0x0400015C RID: 348
		private global::System.Windows.Forms.Button btnHelmSet;

		// Token: 0x0400015D RID: 349
		private global::System.Windows.Forms.Button btnArmorSet;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Forms.Button btnClassSet;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.Button btnWeaponSet;

		// Token: 0x04000160 RID: 352
		private global::System.Windows.Forms.Button btnPetSet;

		// Token: 0x04000161 RID: 353
		private global::System.Windows.Forms.Button btnCapeSet;

		// Token: 0x04000162 RID: 354
		private global::System.Windows.Forms.TextBox txtHelm2;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.TextBox txtArmor2;

		// Token: 0x04000164 RID: 356
		private global::System.Windows.Forms.TextBox txtClass2;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Forms.TextBox txtWeapon2;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.TextBox txtPet2;

		// Token: 0x04000167 RID: 359
		private global::System.Windows.Forms.TextBox txtCape2;

		// Token: 0x04000168 RID: 360
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

		// Token: 0x04000169 RID: 361
		private global::System.Windows.Forms.Button btnSaveSet;

		// Token: 0x0400016A RID: 362
		private global::System.Windows.Forms.Button btnLoadSet;

		// Token: 0x0400016B RID: 363
		private global::System.Windows.Forms.TextBox txtOff2;

		// Token: 0x0400016C RID: 364
		private global::System.Windows.Forms.TextBox txtOff1;

		// Token: 0x0400016D RID: 365
		private global::System.Windows.Forms.Button btnSetOffhand;

		// Token: 0x0400016E RID: 366
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400016F RID: 367
		private global::System.Windows.Forms.Button btnRemove;
	}
}
