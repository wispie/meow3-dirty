using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Grimoire.Properties
{
	// Token: 0x02000086 RID: 134
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000425D File Offset: 0x0000245D
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000309 RID: 777
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
