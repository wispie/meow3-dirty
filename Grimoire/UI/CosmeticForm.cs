using System;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Grimoire.Botting;
using Grimoire.Game;
using Grimoire.Tools;
using Grimoire.Utils;
using Microsoft.CSharp.RuntimeBinder;

namespace Grimoire.UI
{
	// Token: 0x02000024 RID: 36
	public partial class CosmeticForm : Form
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002BBE File Offset: 0x00000DBE
		public static CosmeticForm Instance { get; } = new CosmeticForm();

		// Token: 0x0600011B RID: 283 RVA: 0x00002BC5 File Offset: 0x00000DC5
		public CosmeticForm()
		{
			this.InitializeComponent();
			this.lbItems.SelectionMode = SelectionMode.MultiExtended;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00018CB8 File Offset: 0x00016EB8
		private void lnkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!Player.IsLoggedIn)
			{
				return;
			}
			this.cbPlayer.Items.Clear();
			World.RefreshDictionary();
			ComboBox.ObjectCollection items = this.cbPlayer.Items;
			object[] items2 = World.Players.ToArray();
			items.AddRange(items2);
			this.cbPlayer.SelectedItem = ((this.cbPlayer.Items.Count > 0) ? this.cbPlayer.Items[0] : null);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00018D30 File Offset: 0x00016F30
		private void btnGrabCosm_Click(object sender, EventArgs e)
		{
			if (this.cbPlayer.SelectedIndex > -1)
			{
				try
				{
					try
					{
						if (this.lbItems.Items[this.lbItems.Items.Count - 1].ToString() != " ")
						{
							this.lbItems.Items.Add(" ");
						}
					}
					catch
					{
					}
					ListBox.ObjectCollection items = this.lbItems.Items;
					object[] items2 = CosmeticEquipment.Get(((PlayerInfo)this.cbPlayer.SelectedItem).EntID).ToArray();
					items.AddRange(items2);
					this.lbItems.Items.Add(" ");
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002BDF File Offset: 0x00000DDF
		private void btnCopyAll_Click(object sender, EventArgs e)
		{
			this.lbItems.Items.Cast<CosmeticEquipment>().ForEach(delegate(CosmeticEquipment x)
			{
				x.Equip();
			});
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00018E04 File Offset: 0x00017004
		private void btnEquipSelected_Click(object sender, EventArgs e)
		{
			try
			{
				this.lbItems.SelectedItems.Cast<CosmeticEquipment>().ForEach(delegate(CosmeticEquipment x)
				{
					x.Equip();
				});
			}
			catch
			{
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00018E5C File Offset: 0x0001705C
		private void lnkGrabTarget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.lbItems.Items.Clear();
			ListBox.ObjectCollection items = this.lbItems.Items;
			object[] items2 = CosmeticEquipment.Get(Flash.Instance.GetGameObject<int>("world.myAvatar.target.uid", 0)).ToArray();
			items.AddRange(items2);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002190 File Offset: 0x00000390
		private void CosmeticForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00018CB8 File Offset: 0x00016EB8
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			if (!Player.IsLoggedIn)
			{
				return;
			}
			this.cbPlayer.Items.Clear();
			World.RefreshDictionary();
			ComboBox.ObjectCollection items = this.cbPlayer.Items;
			object[] items2 = World.Players.ToArray();
			items.AddRange(items2);
			this.cbPlayer.SelectedItem = ((this.cbPlayer.Items.Count > 0) ? this.cbPlayer.Items[0] : null);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00018EA8 File Offset: 0x000170A8
		private void btnClear_Click(object sender, EventArgs e)
		{
			this.lbItems.Items.Clear();
			TextBox[] array = new TextBox[]
			{
				this.txtHelm1,
				this.txtHelm2,
				this.txtArmor1,
				this.txtArmor2,
				this.txtClass1,
				this.txtClass2,
				this.txtWeapon1,
				this.txtWeapon2,
				this.txtPet1,
				this.txtPet2,
				this.txtCape1,
				this.txtCape2,
				this.txtOff1,
				this.txtOff2
			};
			foreach (TextBox textBox in array)
			{
				textBox.Text = "";
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00018F70 File Offset: 0x00017170
		private void linkItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.cbPlayer.SelectedIndex > -1)
			{
				try
				{
					string text = ((LinkLabel)sender).Text.Split(new char[]
					{
						' '
					})[1].Replace("Wep", "Weapon");
					object[] array = CosmeticEquipment.Get(((PlayerInfo)this.cbPlayer.SelectedItem).EntID).ToArray();
					object[] array2 = array;
					int num = 0;
					while (array2.Length > num)
					{
						if (array2[num].ToString().StartsWith(text))
						{
							this.lbItems.Items.Add(array2[num]);
							string[] array3 = array2[num].ToString().Replace(text + ": ", "").Split(new char[]
							{
								';'
							});
							if (text == "Cape" && this.txtCape1.Text != (this.txtCape1.Text.NullIfEmpty() ?? array3[0]))
							{
								this.txtCape1.Text = array3[0];
								this.txtCape2.Text = array3[1];
							}
							else if (text == "Class" && this.txtClass1.Text != (this.txtClass1.Text.NullIfEmpty() ?? array3[0]))
							{
								this.txtClass1.Text = array3[0];
								this.txtClass2.Text = array3[1];
							}
							else if (text == "Pet" && this.txtPet2.Text != (this.txtPet1.Text.NullIfEmpty() ?? array3[0]))
							{
								this.txtPet1.Text = array3[0];
								this.txtPet2.Text = array3[1];
							}
							else if (text == "Weapon" && this.txtWeapon1.Text != (this.txtWeapon1.Text.NullIfEmpty() ?? array3[0]))
							{
								this.txtWeapon1.Text = array3[0];
								this.txtWeapon2.Text = array3[1];
							}
							else if (text == "Helm" && this.txtHelm1.Text != (this.txtHelm1.Text.NullIfEmpty() ?? array3[0]))
							{
								this.txtHelm1.Text = array3[0];
								this.txtHelm2.Text = array3[1];
							}
							else if (text == "Armor" && this.txtArmor1.Text != (this.txtArmor1.Text.NullIfEmpty() ?? array3[0]))
							{
								this.txtArmor1.Text = array3[0];
								this.txtArmor2.Text = array3[1];
							}
						}
						num++;
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0001927C File Offset: 0x0001747C
		private void lbItems_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && this.lbItems.SelectedItem != null)
			{
				int selectedIndex = this.lbItems.SelectedIndex;
				if (selectedIndex > -1)
				{
					for (int i = this.lbItems.SelectedIndices.Count - 1; i >= 0; i--)
					{
						int index = this.lbItems.SelectedIndices[i];
						this.lbItems.Items.RemoveAt(index);
					}
					this.lbItems.EndUpdate();
				}
			}
			if (e.KeyCode == Keys.Return && this.lbItems.SelectedIndex > -1)
			{
				ListBox.SelectedObjectCollection selectedItems = this.lbItems.SelectedItems;
				int num = 0;
				while (selectedItems.Count > num)
				{
					string text = selectedItems[num].ToString().Split(new char[]
					{
						':'
					})[0];
					if (!(selectedItems[num].ToString() == " "))
					{
						string[] array = selectedItems[num].ToString().Replace(text + ": ", "").Split(new char[]
						{
							';'
						});
						if (!(text == "Cape"))
						{
							if (!(text == "Pet"))
							{
								if (!(text == "Class"))
								{
									if (!(text == "Helm"))
									{
										if (!(text == "Armor"))
										{
											this.txtWeapon1.Text = array[0];
											this.txtWeapon2.Text = array[1];
										}
										else
										{
											this.txtArmor1.Text = array[0];
											this.txtArmor2.Text = array[1];
										}
									}
									else
									{
										this.txtHelm1.Text = array[0];
										this.txtHelm2.Text = array[1];
									}
								}
								else
								{
									this.txtClass1.Text = array[0];
									this.txtClass2.Text = array[1];
								}
							}
							else
							{
								this.txtPet1.Text = array[0];
								this.txtPet2.Text = array[1];
							}
						}
						else
						{
							this.txtCape1.Text = array[0];
							this.txtCape2.Text = array[1];
						}
					}
					num++;
				}
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000194C4 File Offset: 0x000176C4
		private void btnSet_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			string text = button.Name.Replace("btn", "").Replace("Set", "");
			string text2;
			string text3;
			if (!(text == "Cape"))
			{
				if (!(text == "Class"))
				{
					if (!(text == "Pet"))
					{
						if (!(text == "Helm"))
						{
							if (!(text == "Armor"))
							{
								if (!(text == "Offhand"))
								{
									text = "Weapon";
									text2 = this.txtWeapon1.Text;
									text3 = this.txtWeapon2.Text;
								}
								else
								{
									text = "Off";
									text2 = this.txtOff1.Text;
									text3 = this.txtOff2.Text;
								}
							}
							else
							{
								text = "co";
								text2 = this.txtArmor1.Text;
								text3 = this.txtArmor2.Text;
							}
						}
						else
						{
							text = "he";
							text2 = this.txtHelm1.Text;
							text3 = this.txtHelm2.Text;
						}
					}
					else
					{
						text = "pe";
						text2 = this.txtPet1.Text;
						text3 = this.txtPet2.Text;
					}
				}
				else
				{
					text = "ar";
					text2 = this.txtClass1.Text;
					text3 = this.txtClass2.Text;
				}
			}
			else
			{
				text = "ba";
				text2 = this.txtCape1.Text;
				text3 = this.txtCape2.Text;
			}
			object obj = new ExpandoObject();
			if (CosmeticForm.<>o__14.<>p__0 == null)
			{
				CosmeticForm.<>o__14.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sFile", typeof(CosmeticForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			CosmeticForm.<>o__14.<>p__0.Target(CosmeticForm.<>o__14.<>p__0, obj, text2);
			if (CosmeticForm.<>o__14.<>p__1 == null)
			{
				CosmeticForm.<>o__14.<>p__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sLink", typeof(CosmeticForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			CosmeticForm.<>o__14.<>p__1.Target(CosmeticForm.<>o__14.<>p__1, obj, text3.ReplaceLink());
			if (CosmeticForm.<>o__14.<>p__2 == null)
			{
				CosmeticForm.<>o__14.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sType", typeof(CosmeticForm), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			CosmeticForm.<>o__14.<>p__2.Target(CosmeticForm.<>o__14.<>p__2, obj, text);
			Flash.Call("SetEquip", new object[]
			{
				text,
				obj
			});
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0001976C File Offset: 0x0001796C
		private void btnSaveSet_Click(object sender, EventArgs e)
		{
			string[] contents = new string[]
			{
				"Helmet:",
				"he file:" + (this.txtHelm1.Text ?? "None"),
				"he link:" + (this.txtHelm2.Text ?? "None"),
				"\r\nArmor:",
				"co file:" + (this.txtArmor1.Text ?? "None"),
				"co link:" + (this.txtArmor2.Text ?? "None"),
				"\r\nClass:",
				"ar file:" + (this.txtClass1.Text ?? "None"),
				"ar link:" + (this.txtClass2.Text ?? "None") + "\r\n",
				"\r\nWeapon:",
				"Weapon file:" + (this.txtWeapon1.Text ?? "None"),
				"Weapon link:" + (this.txtWeapon2.Text ?? "None") + "\r\n",
				"\r\nPet:",
				"pe file:" + (this.txtPet1.Text ?? "None"),
				"pe link:" + (this.txtPet2.Text ?? "None"),
				"\r\nCape:",
				"ba file:" + (this.txtCape1.Text ?? "None"),
				"ba link:" + (this.txtCape2.Text ?? "None"),
				"\r\nOff:",
				"off file:" + (this.txtOff1.Text ?? "None"),
				"off link:" + (this.txtOff2.Text ?? "None")
			};
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				InitialDirectory = Application.StartupPath + "\\Sets",
				Filter = "Grimoire sets|*.gset"
			};
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllLines(saveFileDialog.FileName, contents);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000199D8 File Offset: 0x00017BD8
		private void btnLoadSet_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				InitialDirectory = Application.StartupPath + "\\Sets",
				Filter = "Grimoire sets|*.gset"
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string[] array = (from empty in File.ReadAllLines(openFileDialog.FileName)
				where empty.Trim() != string.Empty
				select empty).ToArray<string>();
				try
				{
					this.txtHelm1.Text = array[1].Split(new char[]
					{
						':'
					})[1];
					this.txtHelm2.Text = array[2].Split(new char[]
					{
						':'
					})[1];
					this.txtArmor1.Text = array[4].Split(new char[]
					{
						':'
					})[1];
					this.txtArmor2.Text = array[5].Split(new char[]
					{
						':'
					})[1];
					this.txtClass1.Text = array[7].Split(new char[]
					{
						':'
					})[1];
					this.txtClass2.Text = array[8].Split(new char[]
					{
						':'
					})[1];
					this.txtWeapon1.Text = array[10].Split(new char[]
					{
						':'
					})[1];
					this.txtWeapon2.Text = array[11].Split(new char[]
					{
						':'
					})[1];
					this.txtPet1.Text = array[13].Split(new char[]
					{
						':'
					})[1];
					this.txtPet2.Text = array[14].Split(new char[]
					{
						':'
					})[1];
					this.txtCape1.Text = array[16].Split(new char[]
					{
						':'
					})[1];
					this.txtCape2.Text = array[17].Split(new char[]
					{
						':'
					})[1];
					this.txtOff1.Text = array[19].Split(new char[]
					{
						':'
					})[1];
					this.txtOff2.Text = array[20].Split(new char[]
					{
						':'
					})[1];
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00019C38 File Offset: 0x00017E38
		private void lbItems_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.lbItems.SelectedItem.ToString() == " ")
			{
				return;
			}
			string text = this.lbItems.SelectedItem.ToString().Split(new char[]
			{
				':'
			})[0];
			string[] array = this.lbItems.SelectedItem.ToString().Replace(text + ": ", "").Split(new char[]
			{
				';'
			});
			if (text == "Cape")
			{
				this.txtCape1.Text = array[0];
				this.txtCape2.Text = array[1];
				return;
			}
			if (text == "Pet")
			{
				this.txtPet1.Text = array[0];
				this.txtPet2.Text = array[1];
				return;
			}
			if (text == "Class")
			{
				this.txtClass1.Text = array[0];
				this.txtClass2.Text = array[1];
				return;
			}
			if (text == "Helm")
			{
				this.txtHelm1.Text = array[0];
				this.txtHelm2.Text = array[1];
				return;
			}
			if (!(text == "Armor"))
			{
				this.txtWeapon1.Text = array[0];
				this.txtWeapon2.Text = array[1];
				return;
			}
			this.txtArmor1.Text = array[0];
			this.txtArmor2.Text = array[1];
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00019DB0 File Offset: 0x00017FB0
		private void btnRemove_Click(object sender, EventArgs e)
		{
			try
			{
				ListBox.SelectedIndexCollection selectedIndices = this.lbItems.SelectedIndices;
				for (int i = selectedIndices.Count - 1; i >= 0; i--)
				{
					int index = selectedIndices[i];
					this.lbItems.Items.RemoveAt(index);
				}
			}
			catch
			{
			}
		}
	}
}
