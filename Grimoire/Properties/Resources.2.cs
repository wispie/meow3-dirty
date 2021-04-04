using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Grimoire.Properties
{
	// Token: 0x02000085 RID: 133
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000352 RID: 850 RVA: 0x000041D6 File Offset: 0x000023D6
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("Grimoire.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00004202 File Offset: 0x00002402
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00004209 File Offset: 0x00002409
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00004211 File Offset: 0x00002411
		internal static string defaulttext
		{
			get
			{
				return Resources.ResourceManager.GetString("defaulttext", Resources.resourceCulture);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00004227 File Offset: 0x00002427
		internal static string statementcmds
		{
			get
			{
				return Resources.ResourceManager.GetString("statementcmds", Resources.resourceCulture);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0000423D File Offset: 0x0000243D
		internal static byte[] aqlitegrimoire
		{
			get
			{
				return File.ReadAllBytes(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "catgirl.swf"));
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000208C File Offset: 0x0000028C
		internal Resources()
		{
		}

		// Token: 0x04000307 RID: 775
		private static ResourceManager resourceMan;

		// Token: 0x04000308 RID: 776
		private static CultureInfo resourceCulture;
	}
}
