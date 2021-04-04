using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Grimoire.Botting;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.Tools;

namespace Grimoire.UI
{
	// Token: 0x02000031 RID: 49
	public partial class Loaders : Form
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00002E9C File Offset: 0x0000109C
		public static Loaders Instance { get; } = new Loaders();

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00002EA3 File Offset: 0x000010A3
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002EAA File Offset: 0x000010AA
		public static Loaders.Type TreeType { get; set; }

		// Token: 0x06000175 RID: 373 RVA: 0x0001DF80 File Offset: 0x0001C180
		private Loaders()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0001E000 File Offset: 0x0001C200
		private void btnLoad_Click(object sender, EventArgs e)
		{
			switch (this.cbLoad.SelectedIndex)
			{
			case 0:
			{
				int id;
				if (int.TryParse(this.txtLoaders.Text, out id))
				{
					Shop.LoadHairShop(id);
					return;
				}
				break;
			}
			case 1:
			{
				int id;
				if (int.TryParse(this.txtLoaders.Text, out id))
				{
					Shop.Load(id);
					return;
				}
				break;
			}
			case 2:
			{
				if (this.txtLoaders.Text.Contains(","))
				{
					this.LoadQuests(this.txtLoaders.Text);
					return;
				}
				int id;
				if (int.TryParse(this.txtLoaders.Text, out id))
				{
					Player.Quests.Load(id);
					return;
				}
				break;
			}
			case 3:
				Shop.LoadArmorCustomizer();
				break;
			default:
				return;
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0001E0B4 File Offset: 0x0001C2B4
		private void LoadQuests(string str)
		{
			string[] source = str.Split(new char[]
			{
				','
			});
			if (source.All((string s) => s.All(new Func<char, bool>(char.IsDigit))))
			{
				Player.Quests.Load(source.Select(new Func<string, int>(int.Parse)).ToList<int>());
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0001E11C File Offset: 0x0001C31C
		private void btnSave_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Title = "Save grabber data",
				CheckFileExists = false,
				Filter = "XML files|*.xml"
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				XmlTextWriter xmlTextWriter = new XmlTextWriter(openFileDialog.FileName, Encoding.ASCII)
				{
					Formatting = Formatting.Indented
				};
				xmlTextWriter.WriteStartDocument();
				xmlTextWriter.WriteRaw("\r\n");
				xmlTextWriter.WriteStartElement("TreeView");
				this.SaveNodes(this.treeGrabbed.Nodes, xmlTextWriter);
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.Close();
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0001E1A8 File Offset: 0x0001C3A8
		private void SaveNodes(TreeNodeCollection nodesCollection, XmlTextWriter textWriter)
		{
			for (int i = 0; i < nodesCollection.Count; i++)
			{
				TreeNode treeNode = nodesCollection[i];
				textWriter.WriteStartElement("n");
				try
				{
					string text = "";
					int num = treeNode.Text.Split(new char[]
					{
						':'
					})[0].Length;
					while (9 > num)
					{
						text += " ";
						num++;
					}
					textWriter.WriteAttributeString("t", treeNode.Text.Split(new char[]
					{
						':'
					})[0] + ":" + text + treeNode.Text.Split(new char[]
					{
						':'
					})[1]);
				}
				catch
				{
					textWriter.WriteAttributeString("t", treeNode.Text ?? "");
				}
				if (treeNode.Tag != null)
				{
					textWriter.WriteAttributeString("tg", treeNode.Tag.ToString());
				}
				if (treeNode.Nodes.Count > 0)
				{
					this.SaveNodes(treeNode.Nodes, textWriter);
				}
				textWriter.WriteEndElement();
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
		private void btnGrab_Click(object sender, EventArgs e)
		{
			this.treeGrabbed.BeginUpdate();
			this.treeGrabbed.Nodes.Clear();
			switch (this.cbGrab.SelectedIndex)
			{
			case 0:
				Grabber.GrabShopItems(this.treeGrabbed);
				break;
			case 1:
				Grabber.GrabQuestIds(this.treeGrabbed);
				break;
			case 2:
				Grabber.GrabQuests(this.treeGrabbed);
				break;
			case 3:
				Grabber.GrabInventoryItems(this.treeGrabbed);
				break;
			case 4:
				Grabber.GrabTempItems(this.treeGrabbed);
				break;
			case 5:
				Grabber.GrabBankItems(this.treeGrabbed);
				break;
			case 6:
				Grabber.GrabMonsters(this.treeGrabbed);
				break;
			}
			this.treeGrabbed.EndUpdate();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002190 File Offset: 0x00000390
		private void Loaders_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0001ED68 File Offset: 0x0001CF68
		private void Loaders_Load(object sender, EventArgs e)
		{
			base.FormClosing += this.Loaders_FormClosing;
			if (this.font != null && this.fontSize != null)
			{
				this.Font = new Font(this.font, this.fontSize.Value, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0001EDBC File Offset: 0x0001CFBC
		private void cbLoad_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbLoad.SelectedIndex == this.cbLoad.Items.Count - 2)
			{
				this.btnLoad.Visible = false;
				this.tableLayoutPanel1.Visible = true;
				return;
			}
			this.btnLoad.Visible = true;
			this.tableLayoutPanel1.Visible = false;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001EE1C File Offset: 0x0001D01C
		private void btnForceAccept_Click(object sender, EventArgs e)
		{
			try
			{
				Player.Quests.Accept(int.Parse(this.txtLoaders.Text));
			}
			catch
			{
			}
		}

		// Token: 0x040001BC RID: 444
		private const string XmlNodeTag = "n";

		// Token: 0x040001BD RID: 445
		private const string XmlNodeTextAtt = "t";

		// Token: 0x040001BE RID: 446
		private const string XmlNodeTagAtt = "tg";

		// Token: 0x040001BF RID: 447
		private const string XmlNodeImageIndexAtt = "imageindex";

		// Token: 0x040001C0 RID: 448
		private readonly string font = Config.Load(Application.StartupPath + "\\config.cfg").Get("font");

		// Token: 0x040001C1 RID: 449
		private readonly float? fontSize = new float?(float.Parse(Config.Load(Application.StartupPath + "\\config.cfg").Get("fontSize") ?? "8.25", CultureInfo.InvariantCulture.NumberFormat));

		// Token: 0x02000032 RID: 50
		public enum Type
		{
			// Token: 0x040001C3 RID: 451
			ShopItems,
			// Token: 0x040001C4 RID: 452
			QuestIDs,
			// Token: 0x040001C5 RID: 453
			Quests,
			// Token: 0x040001C6 RID: 454
			InventoryItems,
			// Token: 0x040001C7 RID: 455
			TempItems,
			// Token: 0x040001C8 RID: 456
			BankItems,
			// Token: 0x040001C9 RID: 457
			Monsters
		}
	}
}
