using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grimoire.Game;
using Grimoire.Game.Data;
using Grimoire.UI;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

namespace Grimoire.Botting.Commands.Item
{
	// Token: 0x0200018B RID: 395
	public class CmdEquipSet : IBotCommand
	{
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0000814F File Offset: 0x0000634F
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x00008157 File Offset: 0x00006357
		public string ItemName { get; set; }

		// Token: 0x060009A9 RID: 2473 RVA: 0x00033EA8 File Offset: 0x000320A8
		public async Task Execute(IBotEngine instance)
		{
			object arg = JsonConvert.DeserializeObject<SetItem>(Application.StartupPath + this.ItemName, this._serializerSettings);
			if (CmdEquipSet.<>o__5.<>p__6 == null)
			{
				CmdEquipSet.<>o__5.<>p__6 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(CmdEquipSet)));
			}
			Func<CallSite, object, IEnumerable> target = CmdEquipSet.<>o__5.<>p__6.Target;
			CallSite <>p__ = CmdEquipSet.<>o__5.<>p__6;
			if (CmdEquipSet.<>o__5.<>p__0 == null)
			{
				CmdEquipSet.<>o__5.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Set", typeof(CmdEquipSet), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			using (IEnumerator enumerator = target(<>p__, CmdEquipSet.<>o__5.<>p__0.Target(CmdEquipSet.<>o__5.<>p__0, arg)).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					dynamic obj = enumerator.Current;
					InventoryItem item = Player.Inventory.Items.FirstOrDefault(delegate(InventoryItem i)
					{
						if (CmdEquipSet.<>o__5.<>p__5 == null)
						{
							CmdEquipSet.<>o__5.<>p__5 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(CmdEquipSet)));
						}
						Func<CallSite, object, bool> target2 = CmdEquipSet.<>o__5.<>p__5.Target;
						CallSite <>p__2 = CmdEquipSet.<>o__5.<>p__5;
						if (CmdEquipSet.<>o__5.<>p__2 == null)
						{
							CmdEquipSet.<>o__5.<>p__2 = CallSite<Func<CallSite, string, object, StringComparison, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Equals", null, typeof(CmdEquipSet), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, string, object, StringComparison, object> target3 = CmdEquipSet.<>o__5.<>p__2.Target;
						CallSite <>p__3 = CmdEquipSet.<>o__5.<>p__2;
						string name = i.Name;
						if (CmdEquipSet.<>o__5.<>p__1 == null)
						{
							CmdEquipSet.<>o__5.<>p__1 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(CmdEquipSet), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						object obj = target3(<>p__3, name, CmdEquipSet.<>o__5.<>p__1.Target(CmdEquipSet.<>o__5.<>p__1, obj), StringComparison.OrdinalIgnoreCase);
						if (CmdEquipSet.<>o__5.<>p__4 == null)
						{
							CmdEquipSet.<>o__5.<>p__4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(CmdEquipSet), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						object arg2;
						if (!CmdEquipSet.<>o__5.<>p__4.Target(CmdEquipSet.<>o__5.<>p__4, obj))
						{
							if (CmdEquipSet.<>o__5.<>p__3 == null)
							{
								CmdEquipSet.<>o__5.<>p__3 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(CmdEquipSet), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
								}));
							}
							arg2 = CmdEquipSet.<>o__5.<>p__3.Target(CmdEquipSet.<>o__5.<>p__3, obj, i.IsEquippable);
						}
						else
						{
							arg2 = obj;
						}
						return target2(<>p__2, arg2);
					});
					while (instance.IsRunning && !this.IsEquipped(item.Id))
					{
						BotData.BotState = BotData.State.Transaction;
						while (instance.IsRunning && Player.CurrentState == Player.State.InCombat)
						{
							Player.MoveToCell(Player.Cell, Player.Pad);
							await Task.Delay(1000);
						}
						await instance.WaitUntil(() => World.IsActionAvailable(LockActions.EquipItem), null, 15);
						Player.Equip(item.Name);
					}
					item = null;
				}
			}
			IEnumerator enumerator = null;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00033EF8 File Offset: 0x000320F8
		public bool IsEquipped(int ItemID)
		{
			return Player.Inventory.Items.FirstOrDefault((InventoryItem it) => it.IsEquipped && it.Id == ItemID) != null;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00008160 File Offset: 0x00006360
		public override string ToString()
		{
			return "Equip Set: " + this.ItemName;
		}

		// Token: 0x04000651 RID: 1617
		private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
		{
			DefaultValueHandling = DefaultValueHandling.Ignore,
			NullValueHandling = NullValueHandling.Ignore,
			TypeNameHandling = TypeNameHandling.All
		};
	}
}
