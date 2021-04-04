using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Grimoire.Botting;
using Unity3.Eyedropper;

namespace Grimoire.UI
{
	// Token: 0x02000027 RID: 39
	public partial class EyeDropper : Form
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00002C66 File Offset: 0x00000E66
		public EyeDropper()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0001BF34 File Offset: 0x0001A134
		private void eyeDropper1_ScreenCaptured(Bitmap capturedPixels, Color capturedColor)
		{
			string text = string.Format(Environment.NewLine + "#{0} / {1}, {2}, {3} / #{4}", new object[]
			{
				this.eyeDropper1.SelectedColor.ToArgb().ToString("X2"),
				this.eyeDropper1.SelectedColor.R,
				this.eyeDropper1.SelectedColor.G,
				this.eyeDropper1.SelectedColor.B,
				this.eyeDropper1.SelectedColor.ToArgb().ToString("X2").Substring(2)
			});
			this.textBox1.BackColor = this.eyeDropper1.SelectedColor;
			this.textBox1.ForeColor = (((double)this.textBox1.BackColor.GetBrightness() > 0.7) ? Color.Black : Color.White);
			this.textBox1.Text = text;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0001C054 File Offset: 0x0001A254
		private void eyeDropper1_EndScreenCapture(object sender, EventArgs e)
		{
			string text = string.Format("#{0} / {1}, {2}, {3} / #{4}\n", new object[]
			{
				this.eyeDropper1.SelectedColor.ToArgb().ToString("X2"),
				this.eyeDropper1.SelectedColor.R,
				this.eyeDropper1.SelectedColor.G,
				this.eyeDropper1.SelectedColor.B,
				this.eyeDropper1.SelectedColor.ToArgb().ToString("X2").Substring(2)
			});
			this.richTextBox1.AppendText(text, this.eyeDropper1.SelectedColor);
		}

		// Token: 0x04000177 RID: 375
		public static EyeDropper Instance = new EyeDropper();
	}
}
