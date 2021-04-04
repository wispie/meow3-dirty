using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Properties
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000208C File Offset: 0x0000028C
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00008680 File Offset: 0x00006880
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002094 File Offset: 0x00000294
		// (set) Token: 0x06000004 RID: 4 RVA: 0x0000209B File Offset: 0x0000029B
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000086BC File Offset: 0x000068BC
		internal static Icon big
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("big", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000086E4 File Offset: 0x000068E4
		internal static Bitmap join
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("join", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000870C File Offset: 0x0000690C
		internal static Bitmap nav_left_green
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("nav_left_green", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00008734 File Offset: 0x00006934
		internal static Bitmap nav_plain_green
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("nav_plain_green", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000875C File Offset: 0x0000695C
		internal static Bitmap nav_plain_red
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("nav_plain_red", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00008784 File Offset: 0x00006984
		internal static Bitmap nav_right_green
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("nav_right_green", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000087AC File Offset: 0x000069AC
		internal static Bitmap server
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("server", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000087D4 File Offset: 0x000069D4
		internal static Bitmap yulgar
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("yulgar", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000001 RID: 1
		private static ResourceManager resourceMan;

		// Token: 0x04000002 RID: 2
		private static CultureInfo resourceCulture;
	}
}
