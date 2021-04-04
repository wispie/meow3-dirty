using System;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000CF RID: 207
	public class Monster
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0000566F File Offset: 0x0000386F
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00005677 File Offset: 0x00003877
		[JsonProperty("sRace")]
		public string Race { get; set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00005680 File Offset: 0x00003880
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00005688 File Offset: 0x00003888
		[JsonProperty("strMonName")]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = ((value != null) ? value.Trim() : null);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0000569C File Offset: 0x0000389C
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x000056A4 File Offset: 0x000038A4
		[JsonProperty("MonID")]
		public int Id { get; set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x000056AD File Offset: 0x000038AD
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x000056B5 File Offset: 0x000038B5
		[JsonProperty("iLvl")]
		public int Level { get; set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x000056BE File Offset: 0x000038BE
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x000056C6 File Offset: 0x000038C6
		[JsonProperty("intState")]
		public int State { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x000056CF File Offset: 0x000038CF
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x000056D7 File Offset: 0x000038D7
		[JsonProperty("intHP")]
		public int Health { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x000056E0 File Offset: 0x000038E0
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x000056E8 File Offset: 0x000038E8
		[JsonProperty("intHPMax")]
		public int MaxHealth { get; set; }

		// Token: 0x04000414 RID: 1044
		private string _name;
	}
}
