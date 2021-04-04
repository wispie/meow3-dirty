using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Grimoire.Tools.Plugins;

namespace Grimoire.UI
{
	// Token: 0x02000045 RID: 69
	public partial class PluginManager : Form
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000339F File Offset: 0x0000159F
		public static PluginManager Instance { get; } = new PluginManager();

		// Token: 0x060001E5 RID: 485 RVA: 0x000033A6 File Offset: 0x000015A6
		public PluginManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000033C9 File Offset: 0x000015C9
		private void PluginManager_Load(object sender, EventArgs e)
		{
			this.lstLoaded.DisplayMember = "Name";
			if (!Directory.Exists(this.path))
			{
				Directory.CreateDirectory(this.path);
			}
			this.UpdateTree();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00021E0C File Offset: 0x0002000C
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
			foreach (string text2 in Directory.EnumerateFiles(path, "*.dll", SearchOption.TopDirectoryOnly))
			{
				string add2 = Path.GetFileName(text2);
				if (node.Nodes.Cast<TreeNode>().ToList<TreeNode>().All((TreeNode n) => n.Text != add2))
				{
					node.Nodes.Add(add2);
				}
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00021F38 File Offset: 0x00020138
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
			foreach (string text2 in Directory.EnumerateFiles(path, "*.dll", SearchOption.TopDirectoryOnly))
			{
				string add2 = Path.GetFileName(text2);
				if (tree.Nodes.Cast<TreeNode>().ToList<TreeNode>().All((TreeNode n) => n.Text != add2))
				{
					tree.Nodes.Add(add2);
				}
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000033FA File Offset: 0x000015FA
		private void UpdateTree()
		{
			this.treePlugins.Nodes.Clear();
			this.AddTreeNodes(this.treePlugins, this.path);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00022064 File Offset: 0x00020264
		private void treePlugins_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string dllFilePath;
			if (File.Exists(dllFilePath = Path.Combine(this.path, e.Node.FullPath)))
			{
				GrimoirePlugin grimoirePlugin = new GrimoirePlugin(dllFilePath);
				if (grimoirePlugin.Load())
				{
					this.txtPlugin.Clear();
					this.lstLoaded.Items.Clear();
					ListBox.ObjectCollection items = this.lstLoaded.Items;
					object[] array = GrimoirePlugin.LoadedPlugins.ToArray();
					object[] items2 = array;
					items.AddRange(items2);
					this.lstLoaded.SelectedItem = grimoirePlugin;
					return;
				}
				MessageBox.Show(grimoirePlugin.LastError, "Grimoire", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00022100 File Offset: 0x00020300
		private void treePlugins_AfterExpand(object sender, TreeViewEventArgs e)
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

		// Token: 0x060001EC RID: 492 RVA: 0x00022180 File Offset: 0x00020380
		private void btnBrowse_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Load Grimoire plugin";
				openFileDialog.Filter = "Dynamic Link Library|*.dll";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.txtPlugin.Text = openFileDialog.SafeFileName;
					this.Plugintext = openFileDialog.FileName;
				}
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000221EC File Offset: 0x000203EC
		private void btnLoad_Click(object sender, EventArgs e)
		{
			string plugintext;
			if (File.Exists(plugintext = this.Plugintext))
			{
				GrimoirePlugin grimoirePlugin = new GrimoirePlugin(plugintext);
				if (grimoirePlugin.Load())
				{
					this.txtPlugin.Clear();
					this.lstLoaded.Items.Clear();
					ListBox.ObjectCollection items = this.lstLoaded.Items;
					object[] array = GrimoirePlugin.LoadedPlugins.ToArray();
					object[] items2 = array;
					items.AddRange(items2);
					this.lstLoaded.SelectedItem = grimoirePlugin;
					return;
				}
				MessageBox.Show(grimoirePlugin.LastError, "Grimoire", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00022278 File Offset: 0x00020478
		private void btnUnload_Click(object sender, EventArgs e)
		{
			int selectedIndex;
			if ((selectedIndex = this.lstLoaded.SelectedIndex) > -1)
			{
				GrimoirePlugin grimoirePlugin = GrimoirePlugin.LoadedPlugins[selectedIndex];
				if (grimoirePlugin.Unload())
				{
					this.lstLoaded.Items.RemoveAt(selectedIndex);
					this.lblAuthor.Text = "Plugin created by:";
					this.txtDesc.Clear();
					return;
				}
				MessageBox.Show(grimoirePlugin.LastError, "Grimoire", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000222EC File Offset: 0x000204EC
		private void lstLoaded_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex;
			if ((selectedIndex = this.lstLoaded.SelectedIndex) > -1)
			{
				GrimoirePlugin grimoirePlugin = GrimoirePlugin.LoadedPlugins[selectedIndex];
				this.lblAuthor.Text = "Plugin created by: " + grimoirePlugin.Author;
				this.txtDesc.Text = grimoirePlugin.Description;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002190 File Offset: 0x00000390
		private void PluginManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x04000230 RID: 560
		private string path = Application.StartupPath + "\\Plugins";

		// Token: 0x04000231 RID: 561
		private string Plugintext;
	}
}
