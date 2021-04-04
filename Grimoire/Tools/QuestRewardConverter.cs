using System;
using System.Collections.Generic;
using System.Linq;
using Grimoire.Game.Data;
using Newtonsoft.Json;

namespace Grimoire.Tools
{
	// Token: 0x02000075 RID: 117
	public class QuestRewardConverter : JsonConverter
	{
		// Token: 0x06000311 RID: 785 RVA: 0x00003F15 File Offset: 0x00002115
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(List<ItemBase>);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003F36 File Offset: 0x00002136
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return serializer.Deserialize<Dictionary<string, Dictionary<int, ItemBase>>>(reader).Values.SelectMany((Dictionary<int, ItemBase> x) => x.Values).ToList<ItemBase>();
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002839 File Offset: 0x00000A39
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}
	}
}
