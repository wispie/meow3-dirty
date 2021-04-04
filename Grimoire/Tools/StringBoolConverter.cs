using System;
using Newtonsoft.Json;

namespace Grimoire.Tools
{
	// Token: 0x02000079 RID: 121
	public class StringBoolConverter : JsonConverter
	{
		// Token: 0x06000322 RID: 802 RVA: 0x00003FDE File Offset: 0x000021DE
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteValue(((bool)value) ? "1" : "0");
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00003FFA File Offset: 0x000021FA
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return reader.Value.ToString() == "1" || reader.Value.ToString() == "true";
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000039B6 File Offset: 0x00001BB6
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(bool);
		}
	}
}
