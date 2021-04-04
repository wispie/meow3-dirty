using System;
using System.Windows.Forms;

namespace Grimoire.Utils
{
	// Token: 0x02000006 RID: 6
	public static class ControlUtils
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000088D0 File Offset: 0x00006AD0
		public static bool CheckedInvoke(this Control c, Action a)
		{
			bool invokeRequired = c.InvokeRequired;
			(invokeRequired ? delegate()
			{
				c.Invoke(a);
			} : a)();
			return invokeRequired;
		}
	}
}
