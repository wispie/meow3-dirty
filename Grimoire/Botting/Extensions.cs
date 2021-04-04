using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Grimoire.Botting
{
	// Token: 0x020000F9 RID: 249
	public static class Extensions
	{
		// Token: 0x06000742 RID: 1858 RVA: 0x00006834 File Offset: 0x00004A34
		public static string Correct(this string str)
		{
			if (str.Contains("<false/>") || str.Contains("<true/>"))
			{
				return str.Replace("<false/>", bool.FalseString).Replace("<true/>", bool.TrueString);
			}
			return str;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0002E844 File Offset: 0x0002CA44
		public static string ReplaceLink(this string str)
		{
			return str.Replace(".swf", "").Replace("_skin", "");
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00006871 File Offset: 0x00004A71
		public static void AppendText(this RichTextBox box, string text, Color color)
		{
			box.SelectionStart = box.TextLength;
			box.SelectionLength = 0;
			box.SelectionColor = color;
			box.AppendText(text);
			box.SelectionColor = box.ForeColor;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000068A0 File Offset: 0x00004AA0
		public static string FromBase64(this string str)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(str));
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0002E874 File Offset: 0x0002CA74
		public static string generatePastelHex(Random random, int mixR, int mixG, int mixB)
		{
			int num = random.Next(256);
			int num2 = random.Next(256);
			int num3 = random.Next(256);
			num = (num + mixR) / 2;
			num2 = (num2 + mixG) / 2;
			num3 = (num3 + mixB) / 2;
			return string.Format("FF{0:X2}{1:X2}{2:X2}", num, num2, num3);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000068B2 File Offset: 0x00004AB2
		public static string SanitizeXml(this string str)
		{
			return str.Replace("&apos;", "'").Replace("&amp;", "&");
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000068D3 File Offset: 0x00004AD3
		public static string NullIfEmpty(this string s)
		{
			if (!string.IsNullOrEmpty(s))
			{
				return s;
			}
			return null;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000068E0 File Offset: 0x00004AE0
		public static string NullIfWhiteSpace(this string s)
		{
			if (!string.IsNullOrWhiteSpace(s))
			{
				return s;
			}
			return null;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0002E8D4 File Offset: 0x0002CAD4
		public static string MakeRelativePath(string fromPath, string toPath)
		{
			if (string.IsNullOrEmpty(fromPath))
			{
				throw new ArgumentNullException("fromPath");
			}
			if (string.IsNullOrEmpty(toPath))
			{
				throw new ArgumentNullException("toPath");
			}
			Uri uri = new Uri(fromPath);
			Uri uri2 = new Uri(toPath);
			if (uri.Scheme != uri2.Scheme)
			{
				return toPath;
			}
			Uri uri3 = uri.MakeRelativeUri(uri2);
			string text = Uri.UnescapeDataString(uri3.ToString());
			if (uri2.Scheme.Equals("file", StringComparison.InvariantCultureIgnoreCase))
			{
				text = text.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
			}
			return text;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0002E964 File Offset: 0x0002CB64
		public static string MakeRelativePathFrom(string fromPath, string toPath)
		{
			if (string.IsNullOrEmpty(fromPath))
			{
				throw new ArgumentNullException("fromPath");
			}
			if (string.IsNullOrEmpty(toPath))
			{
				throw new ArgumentNullException("toPath");
			}
			Uri uri = new Uri(fromPath);
			Uri uri2 = new Uri(toPath);
			if (uri.Scheme != uri2.Scheme)
			{
				return toPath;
			}
			Uri uri3 = uri.MakeRelativeUri(uri2);
			string text = Uri.UnescapeDataString(uri3.ToString());
			if (uri2.Scheme.Equals("file", StringComparison.InvariantCultureIgnoreCase))
			{
				text = text.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
			}
			string[] array = text.Split(new string[]
			{
				"\\"
			}, StringSplitOptions.RemoveEmptyEntries);
			return text.Replace(array[0] + "\\", "");
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0002EA24 File Offset: 0x0002CC24
		public static string[] JtoArray(string result)
		{
			return JsonConvert.DeserializeObject<string[]>(result);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0002EA3C File Offset: 0x0002CC3C
		public static string Base64Encode(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0002EA5C File Offset: 0x0002CC5C
		public static string Base64Decode(string base64EncodedData)
		{
			byte[] bytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000068ED File Offset: 0x00004AED
		public static void InvokeOnUiThreadIfRequired(this Control control, Action action)
		{
			if (control.InvokeRequired)
			{
				control.BeginInvoke(action);
				return;
			}
			action();
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00006906 File Offset: 0x00004B06
		public static float ToSingle(double value)
		{
			return (float)value;
		}

		// Token: 0x020000FA RID: 250
		public class Line : IComparable<Extensions.Line>
		{
			// Token: 0x06000751 RID: 1873 RVA: 0x0002EA7C File Offset: 0x0002CC7C
			public Line(string line)
			{
				int num = line.IndexOf(' ');
				string s = line.Substring(0, num);
				this._number = int.Parse(s);
				this._afterNumber = line.Substring(num);
				this._line = line;
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x0002EAC4 File Offset: 0x0002CCC4
			public int CompareTo(Extensions.Line other)
			{
				int num = this._number.CompareTo(other._number);
				if (num != 0)
				{
					return num;
				}
				return this._afterNumber.CompareTo(other._afterNumber);
			}

			// Token: 0x06000753 RID: 1875 RVA: 0x0000690A File Offset: 0x00004B0A
			public override string ToString()
			{
				return this._line;
			}

			// Token: 0x04000528 RID: 1320
			private int _number;

			// Token: 0x04000529 RID: 1321
			private string _afterNumber;

			// Token: 0x0400052A RID: 1322
			private readonly string _line;
		}
	}
}
