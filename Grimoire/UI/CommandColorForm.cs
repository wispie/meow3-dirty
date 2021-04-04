using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Grimoire.Botting;

namespace Grimoire.UI
{
	// Token: 0x0200001F RID: 31
	public partial class CommandColorForm : Form
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00002B20 File Offset: 0x00000D20
		public CommandColorForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00017D24 File Offset: 0x00015F24
		private void btnLabelColor_Click(object sender, EventArgs e)
		{
			if (this.colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Config config = Config.Load(Application.StartupPath + "\\config.cfg");
				string key = this.comboBox1.SelectedItem.ToString().Replace("Cmd", "") + "Color";
				config.Set(key, this.colorDialog1.Color.ToArgb().ToString("X"));
				config.Save();
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00017DAC File Offset: 0x00015FAC
		private void CommandColorForm_Load(object sender, EventArgs e)
		{
			Type type = typeof(IBotCommand);
			IEnumerable<Type> enumerable = from p in AppDomain.CurrentDomain.GetAssemblies().SelectMany((Assembly s) => s.GetTypes())
			where type.IsAssignableFrom(p) && !p.IsInterface
			select p;
			Type[] array = (enumerable as Type[]) ?? enumerable.ToArray<Type>();
			this.comboBox1.Items.Clear();
			foreach (Type type2 in array)
			{
				string[] array3 = type2.ToString().Split(new char[]
				{
					'.'
				});
				this.comboBox1.Items.Add(array3[array3.Count<string>() - 1]);
			}
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			string text = config.Get("font");
			if (text != null)
			{
				this.Font = new Font(text, 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
			this.trackBar1.Value = int.Parse(config.Get("lstCommandsFontSize") ?? "60");
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00017EE4 File Offset: 0x000160E4
		private int GetColor(Control ctr)
		{
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			string key = ctr.Name.ToString().Remove(0, 3);
			string text = SystemColors.WindowText.ToArgb().ToString("X");
			try
			{
				return int.Parse(config.Get(key) ?? text, NumberStyles.HexNumber);
			}
			catch
			{
			}
			return int.Parse(SystemColors.WindowText.ToString());
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00017F80 File Offset: 0x00016180
		private int GetColor(string ctr)
		{
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			string text = SystemColors.WindowText.ToArgb().ToString("X");
			try
			{
				return int.Parse(config.Get(ctr) ?? text, NumberStyles.HexNumber);
			}
			catch
			{
			}
			return int.Parse(SystemColors.WindowText.ToString());
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00018004 File Offset: 0x00016204
		private bool GetChecked(CheckBox ctr)
		{
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			string str = ctr.Name.ToString().Remove(0, 3);
			try
			{
				return bool.Parse(config.Get(str + "Centered") ?? "false");
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00018074 File Offset: 0x00016274
		private bool GetChecked(string ctr)
		{
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			try
			{
				return bool.Parse(config.Get(ctr + "Centered") ?? "false");
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002190 File Offset: 0x00000390
		private void CommandColorForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				base.Hide();
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000180D0 File Offset: 0x000162D0
		private void chkLabelCentered_CheckedChanged(object sender, EventArgs e)
		{
			string key = "";
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			string a = ((CheckBox)sender).Name.Replace("chk", "");
			if (!(a == "Label"))
			{
				if (!(a == "Kill"))
				{
					if (a == "Index")
					{
						key = "IndexCentered";
					}
				}
				else
				{
					key = "KillCentered";
				}
			}
			else
			{
				key = "LabelCentered";
			}
			config.Set(key, ((CheckBox)sender).Checked.ToString());
			config.Save();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00018174 File Offset: 0x00016374
		private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index <= -1)
			{
				return;
			}
			int index = e.Index;
			try
			{
				e.DrawBackground();
				SolidBrush brush = new SolidBrush(Color.FromArgb(this.GetColor(this.comboBox1.Items[index].ToString().Replace("Cmd", "") + "Color")));
				e.Graphics.DrawString(this.comboBox1.Items[index].ToString(), this.Font, brush, e.Bounds);
			}
			catch
			{
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00018220 File Offset: 0x00016420
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.checkBox1.Checked = this.GetChecked(this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString().Replace("Cmd", ""));
			}
			catch
			{
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00018284 File Offset: 0x00016484
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			string key = this.comboBox1.SelectedItem.ToString().Replace("Cmd", "") + "Centered";
			config.Set(key, ((CheckBox)sender).Checked.ToString());
			config.Save();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000182F0 File Offset: 0x000164F0
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			try
			{
				BotManager.Instance.lstCommands.ItemHeight = this.trackBar1.Value / 4;
				BotManager.Instance.lstCommands.Font = new Font(BotManager.Instance.lstCommands.Font.FontFamily, (float)BotManager.Instance.lstCommands.ItemHeight - 6.5f, FontStyle.Regular);
			}
			catch
			{
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00018370 File Offset: 0x00016570
		private void btnSave_Click(object sender, EventArgs e)
		{
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			config.Set("CommandsSize", this.trackBar1.Value.ToString());
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000183B0 File Offset: 0x000165B0
		private void btnRandomColors_Click(object sender, EventArgs e)
		{
			Type type = typeof(IBotCommand);
			IEnumerable<Type> enumerable = from p in AppDomain.CurrentDomain.GetAssemblies().SelectMany((Assembly s) => s.GetTypes())
			where type.IsAssignableFrom(p) && !p.IsInterface
			select p;
			Type[] array = (enumerable as Type[]) ?? enumerable.ToArray<Type>();
			this.comboBox1.Items.Clear();
			Random random = new Random();
			Config config = Config.Load(Application.StartupPath + "\\config.cfg");
			int mixR = 255;
			int mixG = 255;
			int mixB = 255;
			try
			{
				if (this.txtRGB.Text.Contains("#"))
				{
					Color color = ColorTranslator.FromHtml(this.txtRGB.Text);
					mixR = (int)Convert.ToInt16(color.R);
					mixG = (int)Convert.ToInt16(color.G);
					mixB = (int)Convert.ToInt16(color.B);
				}
				else if (this.txtRGB.Text.Contains(","))
				{
					try
					{
						string[] array2 = this.txtRGB.Text.Split(new char[]
						{
							','
						});
						int.TryParse(array2[0], out mixR);
						int.TryParse(array2[1], out mixG);
						int.TryParse(array2[2], out mixB);
					}
					catch
					{
					}
				}
			}
			catch (Exception ex)
			{
			}
			foreach (Type type2 in array)
			{
				string[] array4 = type2.ToString().Split(new char[]
				{
					'.'
				});
				string text = array4[array4.Count<string>() - 1];
				string key = text.Replace("Cmd", "") + "Color";
				config.Set(key, Extensions.generatePastelHex(random, mixR, mixG, mixB));
			}
			config.Save();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000185B8 File Offset: 0x000167B8
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			Type type = typeof(IBotCommand);
			IEnumerable<Type> enumerable = from p in AppDomain.CurrentDomain.GetAssemblies().SelectMany((Assembly s) => s.GetTypes())
			where type.IsAssignableFrom(p) && !p.IsInterface
			select p;
			Type[] array = (enumerable as Type[]) ?? enumerable.ToArray<Type>();
			this.comboBox1.Items.Clear();
			foreach (Type type2 in array)
			{
				string[] array3 = type2.ToString().Split(new char[]
				{
					'.'
				});
				this.comboBox1.Items.Add(array3[array3.Count<string>() - 1]);
			}
		}

		// Token: 0x0400012D RID: 301
		public static CommandColorForm Instance = new CommandColorForm();
	}
}
