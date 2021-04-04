using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Grimoire.Game;
using Grimoire.Game.Data;
using Newtonsoft.Json;

namespace Grimoire.UI
{
	// Token: 0x0200004E RID: 78
	public partial class Set : Form
	{
		// Token: 0x06000230 RID: 560 RVA: 0x00024500 File Offset: 0x00022700
		public Set()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00024550 File Offset: 0x00022750
		private void ApplyConfig(SetItem config)
		{
			this.listBox1.Items.Clear();
			List<ISetInterface> set = config.Set;
			if (set != null && set.Count > 0)
			{
				ListBox.ObjectCollection items = this.listBox1.Items;
				object[] array = config.Set.ToArray();
				object[] items2 = array;
				items.AddRange(items2);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000036C6 File Offset: 0x000018C6
		private SetItem GenerateConfig()
		{
			return new SetItem
			{
				Set = this.listBox1.Items.Cast<ISetInterface>().ToList<ISetInterface>()
			};
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000245A4 File Offset: 0x000227A4
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (this.comboBox1.SelectedItem == null)
			{
				return;
			}
			string name = ((InventoryItem)this.comboBox1.SelectedItem).Name;
			string text = ((InventoryItem)this.comboBox1.SelectedItem).Category;
			if (InventoryItem.Weapons.Contains(text))
			{
				text = "Weapon";
			}
			this.AddSetItem(new Item
			{
				Name = name,
				Type = text
			});
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002839 File Offset: 0x00000A39
		private void Set_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00024618 File Offset: 0x00022818
		private void AddTreeNodes(TreeNode node, string path)
		{
			foreach (string text in Directory.EnumerateDirectories(path, "*", SearchOption.TopDirectoryOnly))
			{
				string add = Path.GetFileName(text);
				if (node.Nodes.Cast<TreeNode>().ToList<TreeNode>().All((TreeNode n) => n.Text != add))
				{
					node.Nodes.Add(add).Nodes.Add("Loading...");
				}
			}
			foreach (string text2 in Directory.EnumerateFiles(path, "*.gset", SearchOption.TopDirectoryOnly))
			{
				string add2 = Path.GetFileName(text2);
				if (node.Nodes.Cast<TreeNode>().ToList<TreeNode>().All((TreeNode n) => n.Text != add2))
				{
					node.Nodes.Add(add2);
				}
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00024744 File Offset: 0x00022944
		private void AddTreeNodes(TreeView tree, string path)
		{
			foreach (string text in Directory.EnumerateDirectories(path, "*", SearchOption.TopDirectoryOnly))
			{
				string add = Path.GetFileName(text);
				if (tree.Nodes.Cast<TreeNode>().ToList<TreeNode>().All((TreeNode n) => n.Text != add))
				{
					tree.Nodes.Add(add).Nodes.Add("Loading...");
				}
			}
			foreach (string text2 in Directory.EnumerateFiles(path, "*.gset", SearchOption.TopDirectoryOnly))
			{
				string add2 = Path.GetFileName(text2);
				if (tree.Nodes.Cast<TreeNode>().ToList<TreeNode>().All((TreeNode n) => n.Text != add2))
				{
					tree.Nodes.Add(add2);
				}
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002839 File Offset: 0x00000A39
		private void UpdateTree()
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00024870 File Offset: 0x00022A70
		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string text;
			if (File.Exists(text = Path.Combine(this.path, e.Node.FullPath)))
			{
				SetItem config;
				this.TryDeserialize(File.ReadAllText(text), out config);
				this.ApplyConfig(config);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000248B4 File Offset: 0x00022AB4
		private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
		{
			string text;
			if (Directory.Exists(text = Path.Combine(this.path, e.Node.FullPath)))
			{
				this.AddTreeNodes(e.Node, text);
				if (e.Node.Nodes.Count > 0 && e.Node.Nodes[0].Text == "Loading...")
				{
					e.Node.Nodes.RemoveAt(0);
				}
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002190 File Offset: 0x00000390
		private void Set_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00024934 File Offset: 0x00022B34
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			if (!Player.IsLoggedIn || Player.Inventory.Items == null)
			{
				return;
			}
			if (this.comboBox1.Items.Count > 0)
			{
				this.comboBox1.Items.Clear();
			}
			this.comboBox1.Items.Add("");
			this.comboBox1.Items.Add("[Weapons]");
			this.comboBox1.Items.Add("");
			foreach (InventoryItem inventoryItem in Player.Inventory.Items)
			{
				if (inventoryItem.IsWeapon)
				{
					this.comboBox1.Items.Add(inventoryItem);
				}
			}
			this.comboBox1.Items.Add("");
			this.comboBox1.Items.Add("[Classes]");
			this.comboBox1.Items.Add("");
			foreach (InventoryItem inventoryItem2 in Player.Inventory.Items)
			{
				if (inventoryItem2.Category == "Class")
				{
					this.comboBox1.Items.Add(inventoryItem2);
				}
			}
			this.comboBox1.Items.Add("");
			this.comboBox1.Items.Add("[Armors]");
			this.comboBox1.Items.Add("");
			foreach (InventoryItem inventoryItem3 in Player.Inventory.Items)
			{
				if (inventoryItem3.Category == "Armor")
				{
					this.comboBox1.Items.Add(inventoryItem3);
				}
			}
			this.comboBox1.Items.Add("");
			this.comboBox1.Items.Add("[Helmets]");
			this.comboBox1.Items.Add("");
			foreach (InventoryItem inventoryItem4 in Player.Inventory.Items)
			{
				if (inventoryItem4.Category == "Helm")
				{
					this.comboBox1.Items.Add(inventoryItem4);
				}
			}
			this.comboBox1.Items.Add("");
			this.comboBox1.Items.Add("[Capes]");
			this.comboBox1.Items.Add("");
			foreach (InventoryItem inventoryItem5 in Player.Inventory.Items)
			{
				if (inventoryItem5.Category == "Cape")
				{
					this.comboBox1.Items.Add(inventoryItem5);
				}
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00024CB8 File Offset: 0x00022EB8
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.saveFileDialog1.Title = "Save Set";
			if (!Directory.Exists(Application.StartupPath + "\\Sets"))
			{
				Directory.CreateDirectory(Application.StartupPath + "\\Sets");
			}
			this.saveFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "Sets");
			this.saveFileDialog1.DefaultExt = ".gset";
			this.saveFileDialog1.Filter = "Grimoire sets|*.gset";
			this.saveFileDialog1.CheckFileExists = false;
			if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				SetItem value = this.GenerateConfig();
				try
				{
					File.WriteAllText(this.saveFileDialog1.FileName, JsonConvert.SerializeObject(value, Formatting.Indented, this._serializerSettings));
				}
				catch (Exception ex)
				{
					MessageBox.Show("Unable to save bot: " + ex.Message);
				}
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00024DA4 File Offset: 0x00022FA4
		private bool TryDeserialize(string json, out SetItem config)
		{
			try
			{
				config = JsonConvert.DeserializeObject<SetItem>(json);
				return true;
			}
			catch
			{
			}
			config = null;
			return false;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00024DD8 File Offset: 0x00022FD8
		private void btnLoad_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.Title = "Load Set";
			if (!Directory.Exists(Application.StartupPath + "\\Sets"))
			{
				Directory.CreateDirectory(Application.StartupPath + "\\Sets");
			}
			this.openFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "Sets");
			this.openFileDialog1.DefaultExt = ".gset";
			this.openFileDialog1.Filter = "Grimoire sets|*.gset";
			SetItem config;
			if (this.openFileDialog1.ShowDialog() == DialogResult.OK && this.TryDeserialize(File.ReadAllText(this.openFileDialog1.FileName), out config))
			{
				this.ApplyConfig(config);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00024E8C File Offset: 0x0002308C
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox1.SelectedItem.ToString() == "" || this.comboBox1.SelectedItem.ToString().Contains("["))
			{
				ComboBox comboBox = this.comboBox1;
				ComboBox comboBox2 = this.comboBox1;
				int selectedIndex = comboBox2.SelectedIndex;
				comboBox2.SelectedIndex = selectedIndex + 1;
				comboBox.SelectedItem = selectedIndex;
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000036E8 File Offset: 0x000018E8
		private void AddSetItem(ISetInterface cmd)
		{
			this.listBox1.Items.Add(cmd);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000036FC File Offset: 0x000018FC
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
		}

		// Token: 0x04000267 RID: 615
		private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
		{
			DefaultValueHandling = DefaultValueHandling.Ignore,
			NullValueHandling = NullValueHandling.Ignore,
			TypeNameHandling = TypeNameHandling.All
		};

		// Token: 0x04000268 RID: 616
		private string path = Application.StartupPath + "\\Sets";

		// Token: 0x04000269 RID: 617
		public static Set Instance = new Set();
	}
}
