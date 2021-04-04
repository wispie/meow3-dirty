using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using HtmlAgilityPack;

namespace Grimoire.Tools.Buyback
{
	// Token: 0x02000084 RID: 132
	public class BuyBackPage
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00029798 File Offset: 0x00027998
		public string EventArgument
		{
			get
			{
				string result;
				try
				{
					string value = this._doc.DocumentNode.SelectNodes("//input[@type]").First<HtmlNode>().Attributes["onclick"].Value;
					result = HttpUtility.UrlEncode(new Regex("BuyNow(\\$)\\d{1,2}", RegexOptions.IgnoreCase).Matches(value)[0].Value);
				}
				catch
				{
					result = string.Empty;
				}
				return result;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00029814 File Offset: 0x00027A14
		public string ViewState
		{
			get
			{
				string result;
				try
				{
					result = HttpUtility.UrlEncode(this._doc.DocumentNode.SelectSingleNode("//input[@id='__VIEWSTATE']").Attributes["value"].Value);
				}
				catch
				{
					result = string.Empty;
				}
				return result;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0002986C File Offset: 0x00027A6C
		public string ViewStateGenerator
		{
			get
			{
				string result;
				try
				{
					result = HttpUtility.UrlEncode(this._doc.DocumentNode.SelectSingleNode("//input[@id='__VIEWSTATEGENERATOR']").Attributes["value"].Value);
				}
				catch
				{
					result = string.Empty;
				}
				return result;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000350 RID: 848 RVA: 0x000298C4 File Offset: 0x00027AC4
		public string EventValidation
		{
			get
			{
				string result;
				try
				{
					result = HttpUtility.UrlEncode(this._doc.DocumentNode.SelectSingleNode("//input[@id='__EVENTVALIDATION']").Attributes["value"].Value);
				}
				catch
				{
					result = string.Empty;
				}
				return result;
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000041B7 File Offset: 0x000023B7
		public BuyBackPage(string html)
		{
			this._doc = new HtmlDocument();
			this._doc.LoadHtml(html);
		}

		// Token: 0x04000304 RID: 772
		private readonly HtmlDocument _doc;

		// Token: 0x04000305 RID: 773
		public const string EventTarget = "GridBuyBack";

		// Token: 0x04000306 RID: 774
		public const string Confirm = "YES%2c+GET+NOW+FOR+FREE";
	}
}
