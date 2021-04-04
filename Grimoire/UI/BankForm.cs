using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grimoire.Game;
using Grimoire.Game.Data;

namespace Grimoire.UI
{
	// Token: 0x02000010 RID: 16
	public partial class BankForm : Form
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002182 File Offset: 0x00000382
		public BankForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00008B58 File Offset: 0x00006D58
		private void button2_ClickAsync(object sender, EventArgs e)
		{
			List<InventoryItem> items = Player.Inventory.Items;
			if (this.comboBox2.SelectedItem == null)
			{
				MessageBox.Show("Please select AC or Non-AC", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			foreach (InventoryItem inventoryItem in items)
			{
				if (inventoryItem.IsAcItem && this.comboBox2.SelectedIndex == 0 && !inventoryItem.IsEquipped)
				{
					Player.Bank.TransferToBank(inventoryItem.Name);
					Task.Delay(70);
				}
				else if (Player.Bank.AvailableSlots > 0 && !inventoryItem.IsAcItem && this.comboBox2.SelectedIndex == 1 && !inventoryItem.IsEquipped)
				{
					Player.Bank.TransferToBank(inventoryItem.Name);
					Task.Delay(70);
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00008C4C File Offset: 0x00006E4C
		private void button1_ClickAsync(object sender, EventArgs e)
		{
			List<InventoryItem> items = Player.Inventory.Items;
			string[] source = new string[]
			{
				"Sword",
				"Axe",
				"Dagger",
				"Gun",
				"Bow",
				"Mace",
				"Polearm",
				"Staff",
				"Wand"
			};
			object selectedItem = this.comboBox1.SelectedItem;
			object selectedItem2 = this.comboBox2.SelectedItem;
			bool flag = false;
			if (selectedItem == null)
			{
				MessageBox.Show("Please select Item type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (selectedItem2 == null)
			{
				MessageBox.Show("Please select AC or Non-AC", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (this.comboBox2.SelectedIndex == 0)
			{
				flag = true;
			}
			foreach (InventoryItem inventoryItem in items)
			{
				bool flag2 = inventoryItem.IsAcItem == flag && !inventoryItem.IsEquipped && inventoryItem.Name.ToLower() != "treasure potion";
				if (this.checkBox1.Checked)
				{
					if (selectedItem.ToString() == "Weapons" && !source.Contains(inventoryItem.Category) && flag2)
					{
						Player.Bank.TransferToBank(inventoryItem.Name);
						Task.Delay(70);
					}
					else if (inventoryItem.Category != selectedItem.ToString() && flag2)
					{
						Player.Bank.TransferToBank(inventoryItem.Name);
						Task.Delay(70);
					}
				}
				else if (selectedItem.ToString() == "Weapons" && source.Contains(inventoryItem.Category) && flag2)
				{
					Player.Bank.TransferToBank(inventoryItem.Name);
					Task.Delay(70);
				}
				else if (inventoryItem.Category == selectedItem.ToString() && flag2)
				{
					Player.Bank.TransferToBank(inventoryItem.Name);
					Task.Delay(70);
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002190 File Offset: 0x00000390
		private void BankForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x04000008 RID: 8
		public static BankForm Instance = new BankForm();
	}
}
