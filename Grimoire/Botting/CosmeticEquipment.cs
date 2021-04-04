using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using Grimoire.Tools;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

namespace Grimoire.Botting
{
	// Token: 0x020000F5 RID: 245
	public class CosmeticEquipment
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00006787 File Offset: 0x00004987
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x0000678F File Offset: 0x0000498F
		public EquipType Slot { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00006798 File Offset: 0x00004998
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x000067A0 File Offset: 0x000049A0
		[JsonProperty("ItemID")]
		public int ID { get; set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x000067A9 File Offset: 0x000049A9
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x000067B1 File Offset: 0x000049B1
		[JsonProperty("sLink")]
		public string Link { get; set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x000067BA File Offset: 0x000049BA
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x000067C2 File Offset: 0x000049C2
		[JsonProperty("sMeta")]
		public string Meta { get; set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x000067CB File Offset: 0x000049CB
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x000067D3 File Offset: 0x000049D3
		[JsonProperty("sFile")]
		public string SWFFile { get; set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x000067DC File Offset: 0x000049DC
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x000067E4 File Offset: 0x000049E4
		[JsonProperty("sType")]
		public string Type { get; set; }

		// Token: 0x06000737 RID: 1847 RVA: 0x0002E4DC File Offset: 0x0002C6DC
		public void Equip()
		{
			string text = CosmeticEquipment._cosMap[this.Slot];
			object obj = new ExpandoObject();
			if (CosmeticEquipment.<>o__26.<>p__0 == null)
			{
				CosmeticEquipment.<>o__26.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sFile", typeof(CosmeticEquipment), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			CosmeticEquipment.<>o__26.<>p__0.Target(CosmeticEquipment.<>o__26.<>p__0, obj, this.SWFFile);
			if (CosmeticEquipment.<>o__26.<>p__1 == null)
			{
				CosmeticEquipment.<>o__26.<>p__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sLink", typeof(CosmeticEquipment), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			CosmeticEquipment.<>o__26.<>p__1.Target(CosmeticEquipment.<>o__26.<>p__1, obj, this.Link);
			if (CosmeticEquipment.<>o__26.<>p__2 == null)
			{
				CosmeticEquipment.<>o__26.<>p__2 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sType", typeof(CosmeticEquipment), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			CosmeticEquipment.<>o__26.<>p__2.Target(CosmeticEquipment.<>o__26.<>p__2, obj, this.Type);
			if (CosmeticEquipment.<>o__26.<>p__3 == null)
			{
				CosmeticEquipment.<>o__26.<>p__3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "sMeta", typeof(CosmeticEquipment), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			CosmeticEquipment.<>o__26.<>p__3.Target(CosmeticEquipment.<>o__26.<>p__3, obj, this.Meta);
			if (this.ID != 0)
			{
				if (CosmeticEquipment.<>o__26.<>p__4 == null)
				{
					CosmeticEquipment.<>o__26.<>p__4 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "ItemID", typeof(CosmeticEquipment), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				CosmeticEquipment.<>o__26.<>p__4.Target(CosmeticEquipment.<>o__26.<>p__4, obj, this.ID);
			}
			Flash.Call("SetEquip", new object[]
			{
				text,
				obj
			});
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000067ED File Offset: 0x000049ED
		public override string ToString()
		{
			return string.Format("{0}: {1};{2}", this.Slot, this.SWFFile, this.Link);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0002E6F0 File Offset: 0x0002C8F0
		public static List<CosmeticEquipment> Get(int id)
		{
			Dictionary<string, CosmeticEquipment> source = JsonConvert.DeserializeObject<Dictionary<string, CosmeticEquipment>>(Flash.Call("GetEquip", new object[]
			{
				id
			})) ?? new Dictionary<string, CosmeticEquipment>();
			return (from x in source.Select(delegate(KeyValuePair<string, CosmeticEquipment> kvp)
			{
				EquipType equipType;
				if ((kvp.Value.Slot = (CosmeticEquipment._backMap.TryGetValue(kvp.Key, out equipType) ? equipType : EquipType.None)) == EquipType.None)
				{
					return null;
				}
				return kvp.Value;
			})
			where x != null
			select x).ToList<CosmeticEquipment>();
		}

		// Token: 0x0400050F RID: 1295
		private static Dictionary<EquipType, string> _cosMap = new Dictionary<EquipType, string>
		{
			{
				EquipType.Helm,
				"he"
			},
			{
				EquipType.Cape,
				"ba"
			},
			{
				EquipType.Armor,
				"co"
			},
			{
				EquipType.Class,
				"ar"
			},
			{
				EquipType.Pet,
				"pe"
			},
			{
				EquipType.Weapon,
				"Weapon"
			}
		};

		// Token: 0x04000510 RID: 1296
		private static Dictionary<string, EquipType> _backMap = CosmeticEquipment._cosMap.ToDictionary((KeyValuePair<EquipType, string> kvp) => kvp.Value, (KeyValuePair<EquipType, string> kvp) => kvp.Key);
	}
}
