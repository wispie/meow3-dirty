using System;
using Newtonsoft.Json;

namespace Grimoire.Tools
{
	// Token: 0x0200007A RID: 122
	public class TrimConverter : JsonConverter
	{
		// Token: 0x06000326 RID: 806 RVA: 0x00004030 File Offset: 0x00002230
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(string);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00004042 File Offset: 0x00002242
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			string text = (string)reader.Value;
			if (text == null)
			{
				return null;
			}
			return text.Trim();
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000035CC File Offset: 0x000017CC
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}
}
