using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Grimoire.Tools.Plugins
{
	// Token: 0x0200007B RID: 123
	public class GrimoirePlugin
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000405A File Offset: 0x0000225A
		public string Name { get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00004062 File Offset: 0x00002262
		public string Author
		{
			get
			{
				IGrimoirePlugin plugin = this._plugin;
				return ((plugin != null) ? plugin.Author : null) ?? string.Empty;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000407F File Offset: 0x0000227F
		public string Description
		{
			get
			{
				IGrimoirePlugin plugin = this._plugin;
				return ((plugin != null) ? plugin.Description : null) ?? string.Empty;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0000409C File Offset: 0x0000229C
		// (set) Token: 0x0600032E RID: 814 RVA: 0x000040A4 File Offset: 0x000022A4
		public string LastError { get; private set; }

		// Token: 0x0600032F RID: 815 RVA: 0x000040AD File Offset: 0x000022AD
		public GrimoirePlugin(string dllFilePath)
		{
			this._pluginPath = dllFilePath;
			this.Name = Path.GetFileName(dllFilePath);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00028D1C File Offset: 0x00026F1C
		private Type[] TryGetTypes(Assembly asm)
		{
			Type[] result;
			try
			{
				result = asm.GetTypes();
			}
			catch (ReflectionTypeLoadException ex)
			{
				result = (from t in ex.Types
				where t != null
				select t).ToArray<Type>();
			}
			return result;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00028D78 File Offset: 0x00026F78
		public bool Load()
		{
			bool result;
			try
			{
				if (!File.Exists(this._pluginPath))
				{
					this.LastError = "Could not find file: " + this._pluginPath;
					result = false;
				}
				else
				{
					Assembly asm = Assembly.LoadFile(this._pluginPath);
					Type[] source;
					Type type;
					if ((source = this.TryGetTypes(asm)) == null)
					{
						this.LastError = "Unable to retrieve any types in the assembly.";
						result = false;
					}
					else if ((type = source.FirstOrDefault((Type t) => t.IsDefined(typeof(GrimoirePluginEntry), true))) == null)
					{
						this.LastError = "Could not find a class marked with the GrimoirePluginEntry attribute.";
						result = false;
					}
					else
					{
						this._plugin = (IGrimoirePlugin)Activator.CreateInstance(type);
						this._plugin.Load();
						GrimoirePlugin.LoadedPlugins.Add(this);
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				this.LastError = "Failure! This is either not a Grimoire plugin, or its code does not conform to the Grimoire standard.\n" + ex.Message + "\n" + ex.StackTrace;
				result = false;
			}
			return result;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00028E7C File Offset: 0x0002707C
		public bool Unload()
		{
			bool result;
			try
			{
				this._plugin.Unload();
				GrimoirePlugin.LoadedPlugins.Remove(this);
				result = true;
			}
			catch (Exception ex)
			{
				this.LastError = "Failed to unload plugin!\n" + ex.Message + "\n" + ex.StackTrace;
				result = false;
			}
			return result;
		}

		// Token: 0x040002DE RID: 734
		public static List<GrimoirePlugin> LoadedPlugins = new List<GrimoirePlugin>();

		// Token: 0x040002DF RID: 735
		private readonly string _pluginPath;

		// Token: 0x040002E0 RID: 736
		private IGrimoirePlugin _plugin;
	}
}
