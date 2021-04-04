using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Grimoire.Tools.Buyback
{
	// Token: 0x0200007F RID: 127
	public class AutoBuyBack : IDisposable
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00004104 File Offset: 0x00002304
		protected internal string Username
		{
			get
			{
				return Flash.Call<string>("GetUsername", new string[0]);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00004116 File Offset: 0x00002316
		protected internal string Password
		{
			get
			{
				return Flash.Call<string>("GetPassword", new string[0]);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00004128 File Offset: 0x00002328
		public AutoBuyBack()
		{
			this._client = new HttpClient(new HttpClientHandler
			{
				AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate),
				CookieContainer = new CookieContainer()
			})
			{
				BaseAddress = new Uri("https://account.aq.com")
			};
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00028EDC File Offset: 0x000270DC
		public async Task Perform(string item, int pageCap)
		{
			bool flag = !string.IsNullOrEmpty(this.Username) && !string.IsNullOrEmpty(this.Password);
			bool flag2 = flag;
			string lastRequestedPage;
			if (flag2)
			{
				string text = await this.SendPost(string.Empty, string.Concat(new string[]
				{
					"uuu=",
					this.Username,
					"&pps=",
					this.Password,
					"&submit="
				}));
				flag2 = !string.IsNullOrEmpty(lastRequestedPage = text);
			}
			bool flag3 = flag2;
			string[] array;
			if (flag3)
			{
				flag3 = ((array = await this.GetItemHtml(lastRequestedPage, item, pageCap)).Length >= 2);
			}
			if (flag3)
			{
				BuyBackPage buyBackPage = new BuyBackPage(array[0]);
				BuyBackPage buyBackPage2 = new BuyBackPage(array[1]);
				string text2 = await this.SendPost("inventory.aspx?tab=buyback", string.Concat(new string[]
				{
					"__EVENTTARGET=GridBuyBack&__EVENTARGUMENT=",
					buyBackPage.EventArgument,
					"&__VIEWSTATE=",
					buyBackPage2.ViewState,
					"&__VIEWSTATEGENERATOR=",
					buyBackPage2.ViewStateGenerator,
					"&__VIEWSTATEENCRYPTED=&__EVENTVALIDATION=",
					buyBackPage2.EventValidation
				}));
				if (!string.IsNullOrEmpty(text2))
				{
					BuyBackPage buyBackPage3 = new BuyBackPage(text2);
					await this.SendPost("inventory.aspx?tab=buyback", string.Concat(new string[]
					{
						"__VIEWSTATE=",
						buyBackPage3.ViewState,
						"&__VIEWSTATEGENERATOR=",
						buyBackPage3.ViewStateGenerator,
						"&__VIEWSTATEENCRYPTED=&__EVENTVALIDATION=",
						buyBackPage3.EventValidation,
						"&btnConfirmYes=YES%2c+GET+NOW+FOR+FREE"
					}));
				}
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00028F34 File Offset: 0x00027134
		private async Task<string[]> GetItemHtml(string lastRequestedPage, string item, int cap)
		{
			string[] ret = new string[2];
			for (int i = 1; i <= cap; i++)
			{
				BuyBackPage buyBackPage = new BuyBackPage(lastRequestedPage);
				string postData = string.Concat(new string[]
				{
					string.Format("__EVENTTARGET={0}&__EVENTARGUMENT=Page%24{1}&", "GridBuyBack", i),
					"__VIEWSTATE=",
					buyBackPage.ViewState,
					"&__VIEWSTATEGENERATOR=",
					buyBackPage.ViewStateGenerator,
					"&__VIEWSTATEENCRYPTED=&__EVENTVALIDATION=",
					buyBackPage.EventValidation
				});
				string text = await this.SendPost("inventory.aspx?tab=buyback", postData);
				string text2 = text;
				lastRequestedPage = text2;
				string[] array = text2.Split(new char[]
				{
					'\n'
				});
				foreach (string text3 in array)
				{
					if (text3.IndexOf(item, StringComparison.OrdinalIgnoreCase) > -1)
					{
						ret[0] = text3;
						ret[1] = text2;
						return ret;
					}
				}
			}
			return ret;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00028F94 File Offset: 0x00027194
		private async Task<string> SendPost(string url, string postData)
		{
			string result;
			try
			{
				string s = await this._client.PostAsync(url, new StringContent(postData, Encoding.UTF8, "application/x-www-form-urlencoded")).Result.Content.ReadAsStringAsync();
				result = HttpUtility.HtmlDecode(s);
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00028FEC File Offset: 0x000271EC
		private async Task<string> SendGet(string url)
		{
			string result;
			try
			{
				string s = await this._client.GetStringAsync(url);
				result = HttpUtility.HtmlDecode(s);
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00004162 File Offset: 0x00002362
		public void Dispose()
		{
			this.SendGet("logout.aspx").Wait();
			this._client.Dispose();
		}

		// Token: 0x040002E6 RID: 742
		private const string UrlBuyBack = "inventory.aspx?tab=buyback";

		// Token: 0x040002E7 RID: 743
		private readonly HttpClient _client;
	}
}
