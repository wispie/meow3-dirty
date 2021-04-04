using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Grimoire.Botting
{
	// Token: 0x020000F2 RID: 242
	public class Config
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0000639E File Offset: 0x0000459E
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x000063A6 File Offset: 0x000045A6
		public string file { get; set; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x000063AF File Offset: 0x000045AF
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x000063B7 File Offset: 0x000045B7
		public Dictionary<string, string> Contents { get; set; } = new Dictionary<string, string>();

		// Token: 0x060006C4 RID: 1732 RVA: 0x0002E3B8 File Offset: 0x0002C5B8
		public string Get(string key)
		{
			string result;
			if (!this.Contents.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000063D3 File Offset: 0x000045D3
		public void Set(string key, string value)
		{
			this.Contents[key] = value;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000063E2 File Offset: 0x000045E2
		public void Save()
		{
			File.WriteAllLines(this.file, from kvp in this.Contents
			select kvp.Key + "=" + kvp.Value);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0002E3D8 File Offset: 0x0002C5D8
		public static Config Load(string path)
		{
			if (!File.Exists(path))
			{
				File.Create(path);
				Task.Delay(100);
			}
			Config config = new Config();
			config.file = path;
			config.Contents = (from l in File.ReadLines(path)
			select l.Split(new char[]
			{
				'='
			})).ToDictionary((string[] a) => a[0], (string[] a) => a[1]);
			return config;
		}

		// Token: 0x040004DA RID: 1242
		public static Config Instance = new Config();
	}
}
