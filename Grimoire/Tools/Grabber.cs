using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.UI;
using Microsoft.CSharp.RuntimeBinder;

namespace Grimoire.Tools
{
	// Token: 0x02000065 RID: 101
	public static class Grabber
	{
		// Token: 0x060002AE RID: 686 RVA: 0x00027200 File Offset: 0x00025400
		public static void GrabQuests(TreeView tree)
		{
			List<Quest> questTree = Player.Quests.QuestTree;
			List<Quest> list;
			if (questTree == null)
			{
				list = null;
			}
			else
			{
				list = (from q in questTree
				orderby q.Id
				select q).ToList<Quest>();
			}
			List<Quest> list2 = list;
			if (list2 != null && list2.Count > 0)
			{
				foreach (Quest quest in list2)
				{
					TreeNode treeNode = tree.Nodes.Add(string.Format("{0} - {1}", quest.Id, quest.Name));
					treeNode.Nodes.Add(string.Format("ID: {0}", quest.Id));
					treeNode.Nodes.Add("Description: " + quest.Description);
					treeNode.ContextMenuStrip = Grabber.MenuQuest(quest.Id);
					List<InventoryItem> requiredItems = quest.RequiredItems;
					if (requiredItems != null && requiredItems.Count > 0)
					{
						TreeNode treeNode2 = treeNode.Nodes.Add("Required items");
						treeNode2.ContextMenuStrip = Grabber.MenuItems(quest.RequiredItems);
						foreach (InventoryItem inventoryItem in quest.RequiredItems)
						{
							TreeNode treeNode3 = treeNode2.Nodes.Add(inventoryItem.Name);
							treeNode3.ContextMenuStrip = Grabber.MenuItem(inventoryItem);
							treeNode3.Nodes.Add(string.Format("ID: {0}", inventoryItem.Id));
							treeNode3.Nodes.Add(string.Format("Quantity: {0}", inventoryItem.Quantity));
							treeNode3.Nodes.Add("Temporary: " + (inventoryItem.IsTemporary ? "Yes" : "No"));
							treeNode3.Nodes.Add("Description: " + inventoryItem.Description);
						}
					}
					List<InventoryItem> rewards = quest.Rewards;
					if (rewards != null && rewards.Count > 0)
					{
						TreeNode treeNode4 = treeNode.Nodes.Add("Rewards");
						treeNode4.ContextMenuStrip = Grabber.MenuItems(quest.Rewards);
						using (List<InventoryItem>.Enumerator enumerator3 = quest.Rewards.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								InventoryItem reward = enumerator3.Current;
								TreeNode treeNode5 = treeNode4.Nodes.Add(reward.Name);
								treeNode5.ContextMenuStrip = Grabber.MenuItem(reward);
								treeNode5.Nodes.Add(string.Format("ID: {0}", reward.Id));
								treeNode5.Nodes.Add(string.Format("Quantity: {0}", reward.Quantity));
								treeNode5.Nodes.Add("Drop chance: " + (reward.DropChance.Contains("100") ? "Guaranteed" : (reward.DropChance + "%")));
								ItemBase itemBase = quest.oRewards.Find((ItemBase x) => x.Name == reward.Name);
								treeNode5.Nodes.Add("Category: " + itemBase.Category);
								treeNode5.Nodes.Add("Description: " + itemBase.Description);
								if (!string.IsNullOrEmpty(itemBase.File))
								{
									treeNode5.ContextMenuStrip = Grabber.MenuItem(itemBase);
									treeNode5.Nodes.Add("sFile: " + itemBase.File);
									treeNode5.Nodes.Add("sLink: " + itemBase.Link);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00027670 File Offset: 0x00025870
		public static void GrabShopItems(TreeView tree)
		{
			List<ShopInfo> loadedShops = World.LoadedShops;
			List<ShopInfo> list;
			if (loadedShops == null)
			{
				list = null;
			}
			else
			{
				list = (from s in loadedShops
				orderby s.Name
				select s).ToList<ShopInfo>();
			}
			List<ShopInfo> list2 = list;
			if (list2 != null && list2.Count > 0)
			{
				foreach (ShopInfo shopInfo in list2)
				{
					TreeNode treeNode = tree.Nodes.Add(shopInfo.Name);
					treeNode.ContextMenuStrip = Grabber.Wiki(shopInfo);
					treeNode.Nodes.Add(string.Format("ID: {0}", shopInfo.Id));
					treeNode.Nodes.Add("Location: " + shopInfo.Location);
					List<InventoryItem> items = shopInfo.Items;
					if (items != null && items.Count > 0)
					{
						TreeNode treeNode2 = treeNode.Nodes.Add("Items");
						foreach (InventoryItem inventoryItem in shopInfo.Items)
						{
							TreeNode treeNode3 = treeNode2.Nodes.Add(inventoryItem.Name);
							treeNode3.ContextMenuStrip = Grabber.Wiki(inventoryItem);
							treeNode3.Nodes.Add(string.Format("Shop item ID: {0}", inventoryItem.ShopItemId));
							treeNode3.Nodes.Add(string.Format("ID: {0}", inventoryItem.Id));
							treeNode3.Nodes.Add(string.Format("Cost: {0} {1}", inventoryItem.Cost, inventoryItem.IsAcItem ? "AC" : "Gold"));
							treeNode3.Nodes.Add("Category: " + inventoryItem.Category);
							treeNode3.Nodes.Add("Description: " + inventoryItem.Description);
							if (inventoryItem.IsEquippableNonItem || inventoryItem.IsWeapon)
							{
								treeNode3.Nodes.Add("sFile: " + inventoryItem.File);
								treeNode3.Nodes.Add("sLink: " + inventoryItem.Link);
							}
						}
					}
				}
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00027914 File Offset: 0x00025B14
		public static void GrabQuestIds(TreeView tree)
		{
			List<Quest> questTree = Player.Quests.QuestTree;
			List<Quest> list;
			if (questTree == null)
			{
				list = null;
			}
			else
			{
				list = (from q in questTree
				orderby q.Id
				select q).ToList<Quest>();
			}
			List<Quest> list2 = list;
			if (list2 != null && list2.Count > 0)
			{
				foreach (Quest quest in list2)
				{
					tree.Nodes.Add(string.Format("{0} - {1}", quest.Id, quest.Name)).ContextMenuStrip = Grabber.MenuQuest(quest.Id);
				}
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00003AB5 File Offset: 0x00001CB5
		public static void GrabInventoryItems(TreeView tree)
		{
			Grabber.GrabItems(tree, true);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00003ABE File Offset: 0x00001CBE
		public static void GrabBankItems(TreeView tree)
		{
			Grabber.GrabItems(tree, false);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000279D8 File Offset: 0x00025BD8
		private static void GrabItems(TreeView tree, bool inventory)
		{
			List<InventoryItem> list = inventory ? Player.Inventory.Items : Player.Bank.Items;
			List<InventoryItem> list2;
			if (list == null)
			{
				list2 = null;
			}
			else
			{
				list2 = (from i in list
				orderby i.Name
				select i).ToList<InventoryItem>();
			}
			List<InventoryItem> list3 = list2;
			if (list3 != null && list3.Count > 0)
			{
				foreach (InventoryItem inventoryItem in list3)
				{
					TreeNode treeNode = tree.Nodes.Add(inventoryItem.Name);
					treeNode.ContextMenuStrip = Grabber.Wiki(inventoryItem);
					treeNode.Nodes.Add(string.Format("ID: {0}", inventoryItem.Id));
					treeNode.Nodes.Add(string.Format("Char item id: {0}", inventoryItem.CharItemId));
					treeNode.Nodes.Add(string.Format("Quantity: {0}/{1}", inventoryItem.Quantity, inventoryItem.MaxStack));
					treeNode.Nodes.Add(string.Format("AC tagged: {0}", inventoryItem.IsAcItem));
					treeNode.Nodes.Add("Category: " + inventoryItem.Category);
					treeNode.Nodes.Add("Description: " + inventoryItem.Description);
					if (inventoryItem.IsEquippableNonItem || inventoryItem.IsWeapon)
					{
						treeNode.Nodes.Add("sFile: " + inventoryItem.File);
						treeNode.Nodes.Add("sLink: " + inventoryItem.Link);
					}
				}
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00027BBC File Offset: 0x00025DBC
		public static void GrabTempItems(TreeView tree)
		{
			List<TempItem> items = Player.TempInventory.Items;
			List<TempItem> list;
			if (items == null)
			{
				list = null;
			}
			else
			{
				list = (from i in items
				orderby i.Name
				select i).ToList<TempItem>();
			}
			List<TempItem> list2 = list;
			if (list2 != null && list2.Count > 0)
			{
				foreach (TempItem tempItem in list2)
				{
					TreeNode treeNode = tree.Nodes.Add(tempItem.Name);
					treeNode.ContextMenuStrip = Grabber.Wiki(tempItem.Name);
					treeNode.Nodes.Add(string.Format("ID: {0}", tempItem.Id));
					treeNode.Nodes.Add(string.Format("Quantity: {0}", tempItem.Quantity));
				}
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00027CB8 File Offset: 0x00025EB8
		public static void GrabMonsters(TreeView tree)
		{
			List<Monster> availableMonsters = World.AvailableMonsters;
			IEnumerable<IGrouping<string, Monster>> source;
			if (availableMonsters == null)
			{
				source = null;
			}
			else
			{
				source = from m in availableMonsters
				group m by m.Name;
			}
			List<Monster> list = (from x in source
			select x.First<Monster>()).ToList<Monster>();
			if (list != null && list.Count > 0)
			{
				foreach (Monster monster in list)
				{
					TreeNode treeNode = tree.Nodes.Add(monster.Name);
					treeNode.ContextMenuStrip = Grabber.Wiki(monster.Name);
					treeNode.Nodes.Add(string.Format("ID: {0}", monster.Id));
					treeNode.Nodes.Add("Race: " + monster.Race);
					treeNode.Nodes.Add(string.Format("Level: {0}", monster.Level));
					treeNode.Nodes.Add(string.Format("Health: {0}/{1}", monster.Health, monster.MaxHealth));
				}
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00027E20 File Offset: 0x00026020
		private static ContextMenuStrip Wiki(string item)
		{
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
			{
				Text = "Go to Wikipage"
			};
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem
			{
				Text = "Search on Wiki"
			};
			toolStripMenuItem.Click += delegate(object S, EventArgs E)
			{
				Grabber.Search("https://aqwwiki.wikidot.com/" + item.Replace(" ", "+"));
			};
			toolStripMenuItem2.Click += delegate(object S, EventArgs E)
			{
				Grabber.Search("https://aqwwiki.wikidot.com/search:site/q/" + item.Replace(" ", "+"));
			};
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Items.Add(toolStripMenuItem2);
			return contextMenuStrip;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00027EA4 File Offset: 0x000260A4
		private static ContextMenuStrip Wiki(ShopInfo item)
		{
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
			{
				Text = "Go to Wikipage"
			};
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem
			{
				Text = "Search on Wiki"
			};
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem
			{
				Text = "Load Shop"
			};
			toolStripMenuItem.Click += delegate(object S, EventArgs E)
			{
				Grabber.Search("https://aqwwiki.wikidot.com/" + item.Name.Replace(" ", "+"));
			};
			toolStripMenuItem2.Click += delegate(object S, EventArgs E)
			{
				Grabber.Search("https://aqwwiki.wikidot.com/search:site/q/" + item.Name.Replace(" ", "+"));
			};
			toolStripMenuItem3.Click += delegate(object S, EventArgs E)
			{
				Shop.Load(item.Id);
			};
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Items.Add(toolStripMenuItem2);
			contextMenuStrip.Items.Add(toolStripMenuItem3);
			return contextMenuStrip;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00027F58 File Offset: 0x00026158
		private static ContextMenuStrip Wiki(InventoryItem Item)
		{
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
			{
				Text = "Go to Wikipage"
			};
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem
			{
				Text = "Search on Wiki"
			};
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem
			{
				Text = "Equip SWF"
			};
			toolStripMenuItem.Click += delegate(object S, EventArgs E)
			{
				Grabber.Search("https://aqwwiki.wikidot.com/" + Item.Name.Replace(" ", "+"));
			};
			toolStripMenuItem2.Click += delegate(object S, EventArgs E)
			{
				Grabber.Search("https://aqwwiki.wikidot.com/search:site/q/" + Item.Name.Replace(" ", "+"));
			};
			toolStripMenuItem3.Click += delegate(object <p0>, EventArgs <p1>)
			{
				string category = Item.Category;
				string text;
				if (category == "Cape")
				{
					text = "ba";
				}
				else if (category == "Pet")
				{
					text = "pe";
				}
				else if (category == "Armor" || category == "Class")
				{
					text = "co";
				}
				else if (category == "Helm")
				{
					text = "he";
				}
				else
				{
					text = "Weapon";
				}
				object obj = new ExpandoObject();
				if (Grabber.<>o__10.<>p__0 == null)
				{
					Grabber.<>o__10.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sFile", typeof(Grabber), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Grabber.<>o__10.<>p__0.Target(Grabber.<>o__10.<>p__0, obj, Item.File);
				if (Grabber.<>o__10.<>p__1 == null)
				{
					Grabber.<>o__10.<>p__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sLink", typeof(Grabber), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Grabber.<>o__10.<>p__1.Target(Grabber.<>o__10.<>p__1, obj, Item.Link);
				if (Grabber.<>o__10.<>p__2 == null)
				{
					Grabber.<>o__10.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sType", typeof(Grabber), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Grabber.<>o__10.<>p__2.Target(Grabber.<>o__10.<>p__2, obj, category);
				Flash.Call("SetEquip", new object[]
				{
					text,
					obj
				});
			};
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Items.Add(toolStripMenuItem2);
			if (Item.IsWeapon || Item.IsEquippableNonItem)
			{
				contextMenuStrip.Items.Add(toolStripMenuItem3);
			}
			return contextMenuStrip;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00028028 File Offset: 0x00026228
		private static ContextMenuStrip MenuQuest(int QuestID)
		{
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
			{
				Text = "Add to quest list"
			};
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem
			{
				Text = "Accept Quest"
			};
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem
			{
				Text = "Complete Quest"
			};
			ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem
			{
				Text = "Load Quest"
			};
			toolStripMenuItem.Click += delegate(object S, EventArgs E)
			{
				Grabber.AddQuest(S, E, QuestID);
			};
			toolStripMenuItem2.Click += delegate(object S, EventArgs E)
			{
				Player.Quests.Accept(QuestID);
			};
			toolStripMenuItem3.Click += delegate(object S, EventArgs E)
			{
				Player.Quests.Complete(QuestID);
			};
			toolStripMenuItem4.Click += delegate(object S, EventArgs E)
			{
				Player.Quests.Load(QuestID);
			};
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Items.Add(toolStripMenuItem2);
			contextMenuStrip.Items.Add(toolStripMenuItem3);
			contextMenuStrip.Items.Add(toolStripMenuItem4);
			return contextMenuStrip;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00028110 File Offset: 0x00026310
		private static ContextMenuStrip MenuItems(List<InventoryItem> Items)
		{
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
			{
				Text = "Add all to both"
			};
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem
			{
				Text = "Add all to whitelist"
			};
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem
			{
				Text = "Add all to unbank list"
			};
			ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem
			{
				Text = "Search all on Wiki"
			};
			toolStripMenuItem.Click += delegate(object S, EventArgs E)
			{
				Grabber.AddDrops(S, E, Items);
				Grabber.AddItems(S, E, Items);
			};
			toolStripMenuItem2.Click += delegate(object S, EventArgs E)
			{
				Grabber.AddDrops(S, E, Items);
			};
			toolStripMenuItem3.Click += delegate(object S, EventArgs E)
			{
				Grabber.AddDrops(S, E, Items);
			};
			toolStripMenuItem4.Click += delegate(object S, EventArgs E)
			{
				foreach (InventoryItem inventoryItem in Items)
				{
					Process.Start("https://aqwwiki.wikidot.com/search:site/q/" + inventoryItem.Name.Replace(" ", "+"));
				}
			};
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Items.Add(toolStripMenuItem2);
			contextMenuStrip.Items.Add(toolStripMenuItem3);
			contextMenuStrip.Items.Add(toolStripMenuItem4);
			return contextMenuStrip;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000281F8 File Offset: 0x000263F8
		private static ContextMenuStrip MenuItem(InventoryItem Item)
		{
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
			{
				Text = "Add to both"
			};
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem
			{
				Text = "Add to whitelist"
			};
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem
			{
				Text = "Add to unbank list"
			};
			ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem
			{
				Text = "Copy item name to clipboard"
			};
			ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem
			{
				Text = "Go to Wikipage"
			};
			ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem
			{
				Text = "Search on Wiki"
			};
			toolStripMenuItem.Click += delegate(object S, EventArgs E)
			{
				Grabber.AddDrop(S, E, Item);
				Grabber.AddItem(S, E, Item);
			};
			toolStripMenuItem2.Click += delegate(object S, EventArgs E)
			{
				Grabber.AddDrop(S, E, Item);
			};
			toolStripMenuItem3.Click += delegate(object S, EventArgs E)
			{
				Grabber.AddItem(S, E, Item);
			};
			toolStripMenuItem4.Click += delegate(object <p0>, EventArgs <p1>)
			{
				Clipboard.SetText(Item.Name);
			};
			toolStripMenuItem5.Click += delegate(object S, EventArgs E)
			{
				Grabber.Search("https://aqwwiki.wikidot.com/" + Item.Name.Replace(" ", "+"));
			};
			toolStripMenuItem6.Click += delegate(object S, EventArgs E)
			{
				Grabber.Search("https://aqwwiki.wikidot.com/search:site/q/" + Item.Name.Replace(" ", "+"));
			};
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Items.Add(toolStripMenuItem2);
			contextMenuStrip.Items.Add(toolStripMenuItem3);
			contextMenuStrip.Items.Add(toolStripMenuItem4);
			contextMenuStrip.Items.Add(toolStripMenuItem5);
			contextMenuStrip.Items.Add(toolStripMenuItem6);
			return contextMenuStrip;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00028348 File Offset: 0x00026548
		private static ContextMenuStrip MenuItem(ItemBase Item)
		{
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
			{
				Text = "Add to both"
			};
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem
			{
				Text = "Add to whitelist"
			};
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem
			{
				Text = "Add to unbank list"
			};
			ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem
			{
				Text = "Copy item name to clipboard"
			};
			ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem
			{
				Text = "Go to Wikipage"
			};
			ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem
			{
				Text = "Search on Wiki"
			};
			ToolStripMenuItem toolStripMenuItem7 = new ToolStripMenuItem
			{
				Text = "Equip SWF"
			};
			toolStripMenuItem.Click += delegate(object S, EventArgs E)
			{
				Grabber.AddDrop(S, E, Item);
				Grabber.AddItem(S, E, Item);
			};
			toolStripMenuItem2.Click += delegate(object S, EventArgs E)
			{
				Grabber.AddDrop(S, E, Item);
			};
			toolStripMenuItem3.Click += delegate(object S, EventArgs E)
			{
				Grabber.AddItem(S, E, Item);
			};
			toolStripMenuItem4.Click += delegate(object <p0>, EventArgs <p1>)
			{
				Clipboard.SetText(Item.Name);
			};
			toolStripMenuItem5.Click += delegate(object S, EventArgs E)
			{
				Grabber.Search("https://aqwwiki.wikidot.com/" + Item.Name.Replace(" ", "+"));
			};
			toolStripMenuItem6.Click += delegate(object S, EventArgs E)
			{
				Grabber.Search("https://aqwwiki.wikidot.com/search:site/q/" + Item.Name.Replace(" ", "+"));
			};
			toolStripMenuItem7.Click += delegate(object <p0>, EventArgs <p1>)
			{
				string category = Item.Category;
				string text;
				if (category == "Cape")
				{
					text = "ba";
				}
				else if (category == "Pet")
				{
					text = "pe";
				}
				else if (category == "Armor" || category == "Class")
				{
					text = "co";
				}
				else if (category == "Helm")
				{
					text = "he";
				}
				else
				{
					text = "Weapon";
				}
				object obj = new ExpandoObject();
				if (Grabber.<>o__14.<>p__0 == null)
				{
					Grabber.<>o__14.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sFile", typeof(Grabber), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Grabber.<>o__14.<>p__0.Target(Grabber.<>o__14.<>p__0, obj, Item.File);
				if (Grabber.<>o__14.<>p__1 == null)
				{
					Grabber.<>o__14.<>p__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sLink", typeof(Grabber), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Grabber.<>o__14.<>p__1.Target(Grabber.<>o__14.<>p__1, obj, Item.Link);
				if (Grabber.<>o__14.<>p__2 == null)
				{
					Grabber.<>o__14.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sType", typeof(Grabber), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Grabber.<>o__14.<>p__2.Target(Grabber.<>o__14.<>p__2, obj, category);
				Flash.Call("SetEquip", new object[]
				{
					text,
					obj
				});
			};
			contextMenuStrip.Items.Add(toolStripMenuItem);
			contextMenuStrip.Items.Add(toolStripMenuItem2);
			contextMenuStrip.Items.Add(toolStripMenuItem3);
			contextMenuStrip.Items.Add(toolStripMenuItem4);
			contextMenuStrip.Items.Add(toolStripMenuItem5);
			contextMenuStrip.Items.Add(toolStripMenuItem6);
			contextMenuStrip.Items.Add(toolStripMenuItem7);
			return contextMenuStrip;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00003AC7 File Offset: 0x00001CC7
		private static void Search(string Item)
		{
			Process.Start(Item);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00003AD0 File Offset: 0x00001CD0
		private static void AddDrop(object s, EventArgs e, InventoryItem Item)
		{
			if (!Item.IsTemporary)
			{
				BotManager.Instance.AddDrop(Item.Name);
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00003AEA File Offset: 0x00001CEA
		private static void AddItem(object s, EventArgs e, InventoryItem Item)
		{
			if (!Item.IsTemporary)
			{
				BotManager.Instance.AddItem(Item.Name);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000284C8 File Offset: 0x000266C8
		private static void AddDrops(object s, EventArgs e, List<InventoryItem> Items)
		{
			foreach (InventoryItem item in Items)
			{
				Grabber.AddDrop(s, e, item);
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00028518 File Offset: 0x00026718
		private static void AddItems(object s, EventArgs e, List<InventoryItem> Items)
		{
			foreach (InventoryItem item in Items)
			{
				Grabber.AddItem(s, e, item);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00003B04 File Offset: 0x00001D04
		private static void AddDrop(object s, EventArgs e, ItemBase Item)
		{
			if (!Item.Temp)
			{
				BotManager.Instance.AddDrop(Item.Name);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00003B1E File Offset: 0x00001D1E
		private static void AddItem(object s, EventArgs e, ItemBase Item)
		{
			if (!Item.Temp)
			{
				BotManager.Instance.AddItem(Item.Name);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00028568 File Offset: 0x00026768
		private static void AddDrops(object s, EventArgs e, List<ItemBase> Items)
		{
			foreach (ItemBase item in Items)
			{
				Grabber.AddDrop(s, e, item);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000285B8 File Offset: 0x000267B8
		private static void AddItems(object s, EventArgs e, List<ItemBase> Items)
		{
			foreach (ItemBase item in Items)
			{
				Grabber.AddItem(s, e, item);
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00003B38 File Offset: 0x00001D38
		private static void AddQuest(object s, EventArgs e, int ID)
		{
			BotManager.Instance.AddQuest(ID, null);
		}
	}
}
