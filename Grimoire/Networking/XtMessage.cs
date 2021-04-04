using System;

namespace Grimoire.Networking
{
	// Token: 0x02000098 RID: 152
	public class XtMessage : Message
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00004480 File Offset: 0x00002680
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00004488 File Offset: 0x00002688
		public string[] Arguments { get; set; }

		// Token: 0x060003AA RID: 938 RVA: 0x0002B12C File Offset: 0x0002932C
		public XtMessage(string raw)
		{
			if (raw != null)
			{
				base.RawContent = raw;
				if ((this.Arguments = raw.Split(new char[]
				{
					'%'
				})).Length >= 4)
				{
					base.Command = ((this.Arguments[2] != "zm") ? this.Arguments[2] : ((this.Arguments[3] == "cmd") ? this.Arguments[5] : this.Arguments[3]));
				}
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00004491 File Offset: 0x00002691
		public override string ToString()
		{
			return string.Join("%", this.Arguments);
		}
	}
}
