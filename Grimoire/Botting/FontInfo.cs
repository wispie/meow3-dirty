using System;
using System.Drawing;

namespace Grimoire.Botting
{
	// Token: 0x020000FB RID: 251
	public class FontInfo
	{
		// Token: 0x06000754 RID: 1876 RVA: 0x0002EAFC File Offset: 0x0002CCFC
		private float ConvertUnits(Graphics gr, float value, GraphicsUnit from_unit, GraphicsUnit to_unit)
		{
			if (from_unit == to_unit)
			{
				return value;
			}
			switch (from_unit)
			{
			case GraphicsUnit.Pixel:
				break;
			case GraphicsUnit.Point:
				value *= gr.DpiX / 72f;
				break;
			case GraphicsUnit.Inch:
				value *= gr.DpiX;
				break;
			case GraphicsUnit.Document:
				value *= gr.DpiX / 300f;
				break;
			case GraphicsUnit.Millimeter:
				value *= gr.DpiX / 25.4f;
				break;
			default:
				throw new Exception("Unknown input unit " + from_unit.ToString() + " in FontInfo.ConvertUnits");
			}
			switch (to_unit)
			{
			case GraphicsUnit.Pixel:
				break;
			case GraphicsUnit.Point:
				value /= gr.DpiX / 72f;
				break;
			case GraphicsUnit.Inch:
				value /= gr.DpiX;
				break;
			case GraphicsUnit.Document:
				value /= gr.DpiX / 300f;
				break;
			case GraphicsUnit.Millimeter:
				value /= gr.DpiX / 25.4f;
				break;
			default:
				throw new Exception("Unknown output unit " + to_unit.ToString() + " in FontInfo.ConvertUnits");
			}
			return value;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0002EC18 File Offset: 0x0002CE18
		public FontInfo(Graphics gr, Font the_font)
		{
			float num = (float)the_font.FontFamily.GetEmHeight(the_font.Style);
			this.EmHeightPixels = this.ConvertUnits(gr, the_font.Size, the_font.Unit, GraphicsUnit.Pixel);
			float num2 = this.EmHeightPixels / num;
			this.AscentPixels = num2 * (float)the_font.FontFamily.GetCellAscent(the_font.Style);
			this.DescentPixels = num2 * (float)the_font.FontFamily.GetCellDescent(the_font.Style);
			this.CellHeightPixels = this.AscentPixels + this.DescentPixels;
			this.InternalLeadingPixels = this.CellHeightPixels - this.EmHeightPixels;
			this.LineSpacingPixels = num2 * (float)the_font.FontFamily.GetLineSpacing(the_font.Style);
			this.ExternalLeadingPixels = this.LineSpacingPixels - this.CellHeightPixels;
			this.RelTop = this.InternalLeadingPixels;
			this.RelBaseline = this.AscentPixels;
			this.RelBottom = this.CellHeightPixels;
		}

		// Token: 0x0400052B RID: 1323
		public float EmHeightPixels;

		// Token: 0x0400052C RID: 1324
		public float AscentPixels;

		// Token: 0x0400052D RID: 1325
		public float DescentPixels;

		// Token: 0x0400052E RID: 1326
		public float CellHeightPixels;

		// Token: 0x0400052F RID: 1327
		public float InternalLeadingPixels;

		// Token: 0x04000530 RID: 1328
		public float LineSpacingPixels;

		// Token: 0x04000531 RID: 1329
		public float ExternalLeadingPixels;

		// Token: 0x04000532 RID: 1330
		public float RelTop;

		// Token: 0x04000533 RID: 1331
		public float RelBaseline;

		// Token: 0x04000534 RID: 1332
		public float RelBottom;
	}
}
