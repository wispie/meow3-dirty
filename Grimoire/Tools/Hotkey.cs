using System;
using System.Windows.Forms;

namespace Grimoire.Tools
{
	// Token: 0x02000071 RID: 113
	public class Hotkey
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00003E58 File Offset: 0x00002058
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00003E60 File Offset: 0x00002060
		public string Text { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00003E69 File Offset: 0x00002069
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00003E71 File Offset: 0x00002071
		public Keys Key { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00003E7A File Offset: 0x0000207A
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00003E82 File Offset: 0x00002082
		public int ActionIndex { get; set; }

		// Token: 0x060002FC RID: 764 RVA: 0x00003E8B File Offset: 0x0000208B
		public void Install()
		{
			KeyboardHook.Instance.TargetedKeys.Add(this.Key);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00003EA2 File Offset: 0x000020A2
		public void Uninstall()
		{
			KeyboardHook.Instance.TargetedKeys.Remove(this.Key);
		}
	}
}
