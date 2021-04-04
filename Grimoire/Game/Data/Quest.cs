using System;
using System.Collections.Generic;
using Grimoire.Tools;
using Newtonsoft.Json;

namespace Grimoire.Game.Data
{
	// Token: 0x020000D0 RID: 208
	public class Quest
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x000056F1 File Offset: 0x000038F1
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x000056F9 File Offset: 0x000038F9
		[JsonProperty("sFaction")]
		public string Faction { get; set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00005702 File Offset: 0x00003902
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x0000570A File Offset: 0x0000390A
		[JsonProperty("iClass")]
		public int ClassPointsReward { get; set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00005713 File Offset: 0x00003913
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x0000571B File Offset: 0x0000391B
		[JsonProperty("oRewards")]
		[JsonConverter(typeof(QuestRewardConverter))]
		public List<ItemBase> oRewards { get; set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00005724 File Offset: 0x00003924
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x0000572C File Offset: 0x0000392C
		[JsonProperty("sDesc")]
		public string Description { get; set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00005735 File Offset: 0x00003935
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x0000573D File Offset: 0x0000393D
		[JsonProperty("iReqRep")]
		public int RequiredReputation { get; set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00005746 File Offset: 0x00003946
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x0000574E File Offset: 0x0000394E
		[JsonProperty("iRep")]
		public int ReputationReward { get; set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00005757 File Offset: 0x00003957
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x0000575F File Offset: 0x0000395F
		[JsonProperty("iLvl")]
		public int Level { get; set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00005768 File Offset: 0x00003968
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00005770 File Offset: 0x00003970
		[JsonProperty("turnin")]
		public List<InventoryItem> RequiredItems { get; set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00005779 File Offset: 0x00003979
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00005781 File Offset: 0x00003981
		[JsonProperty("iGold")]
		public int GoldReward { get; set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0000578A File Offset: 0x0000398A
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00005792 File Offset: 0x00003992
		[JsonProperty("iReqCP")]
		public int RequiredClassPoints { get; set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0000579B File Offset: 0x0000399B
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x000057A3 File Offset: 0x000039A3
		[JsonProperty("QuestID")]
		public int Id { get; set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x000057AC File Offset: 0x000039AC
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x000057B4 File Offset: 0x000039B4
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bOnce")]
		public bool IsNotRepeatable { get; set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x000057BD File Offset: 0x000039BD
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x000057C5 File Offset: 0x000039C5
		[JsonProperty("iExp")]
		public int ExperienceReward { get; set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x000057CE File Offset: 0x000039CE
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x000057D6 File Offset: 0x000039D6
		[JsonProperty("reward")]
		public List<InventoryItem> Rewards { get; set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x000057DF File Offset: 0x000039DF
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x000057E7 File Offset: 0x000039E7
		[JsonProperty("sName")]
		public string Name { get; set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x000057F0 File Offset: 0x000039F0
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x000057F8 File Offset: 0x000039F8
		[JsonConverter(typeof(BoolConverter))]
		[JsonProperty("bUpg")]
		public bool IsMemberOnly { get; set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00005801 File Offset: 0x00003A01
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00005809 File Offset: 0x00003A09
		[JsonProperty("FactionID")]
		public int FactionId { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00005812 File Offset: 0x00003A12
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x0000581A File Offset: 0x00003A1A
		public string ItemId { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00005823 File Offset: 0x00003A23
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x0000582B File Offset: 0x00003A2B
		public string Text { get; set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0002C974 File Offset: 0x0002AB74
		public bool IsInProgress
		{
			get
			{
				return Flash.Call<bool>("IsInProgress", new string[]
				{
					this.Id.ToString()
				});
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0002C9A4 File Offset: 0x0002ABA4
		public bool CanComplete
		{
			get
			{
				return Flash.Call<bool>("CanComplete", new string[]
				{
					this.Id.ToString()
				});
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0002C9D4 File Offset: 0x0002ABD4
		public void Accept()
		{
			Flash.Call("Accept", new string[]
			{
				this.Id.ToString()
			});
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0002CA04 File Offset: 0x0002AC04
		public void Complete()
		{
			if (!string.IsNullOrEmpty(this.ItemId))
			{
				Flash.Call("Complete", new string[]
				{
					this.Id.ToString(),
					this.ItemId
				});
				return;
			}
			Flash.Call("Complete", new string[]
			{
				this.Id.ToString()
			});
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeFaction()
		{
			return false;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeClassPointsReward()
		{
			return false;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeDescription()
		{
			return false;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeRequiredReputation()
		{
			return false;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeReputationReward()
		{
			return false;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeLevel()
		{
			return false;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeGoldReward
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeRequiredClassPoints
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsNotRepeatable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeExperienceReward
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeRewards
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeName
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsMemberOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeFactionId
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeIsInProgress
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x000053DE File Offset: 0x000035DE
		public bool ShouldSerializeCanComplete
		{
			get
			{
				return false;
			}
		}
	}
}
