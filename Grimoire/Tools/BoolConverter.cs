using System;
using Newtonsoft.Json;

namespace Grimoire.Tools
{
	// Token: 0x0200005D RID: 93
	public class BoolConverter : JsonConverter
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00003986 File Offset: 0x00001B86
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteValue(((bool)value) ? 1 : 0);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000399A File Offset: 0x00001B9A
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return reader.Value.ToString() == "1";
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000039B6 File Offset: 0x00001BB6
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(bool);
		}
	}
}
