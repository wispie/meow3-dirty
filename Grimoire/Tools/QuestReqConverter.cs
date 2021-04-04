using System;
using System.Collections.Generic;
using System.Linq;
using Grimoire.Game.Data;
using Newtonsoft.Json;

namespace Grimoire.Tools
{
	// Token: 0x02000074 RID: 116
	public class QuestReqConverter : JsonConverter
	{
		// Token: 0x0600030D RID: 781 RVA: 0x00003F15 File Offset: 0x00002115
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(List<ItemBase>);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00003F27 File Offset: 0x00002127
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return serializer.Deserialize<Dictionary<int, ItemBase>>(reader).ToList<KeyValuePair<int, ItemBase>>();
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002839 File Offset: 0x00000A39
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}
	}
}
