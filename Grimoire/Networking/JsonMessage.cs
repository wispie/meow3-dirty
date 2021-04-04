using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Grimoire.Networking
{
	// Token: 0x0200008A RID: 138
	public class JsonMessage : Message
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0000428B File Offset: 0x0000248B
		public JToken Object { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00004293 File Offset: 0x00002493
		public JToken DataObject
		{
			get
			{
				JToken @object = this.Object;
				if (@object == null)
				{
					return null;
				}
				JToken jtoken = @object["b"];
				if (jtoken == null)
				{
					return null;
				}
				return jtoken["o"];
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0002991C File Offset: 0x00027B1C
		public JsonMessage(string raw)
		{
			try
			{
				base.RawContent = raw;
				this.Object = JObject.Parse(raw);
				JToken dataObject = this.DataObject;
				string command;
				if (dataObject == null)
				{
					command = null;
				}
				else
				{
					JToken jtoken = dataObject["cmd"];
					command = ((jtoken != null) ? jtoken.Value<string>() : null);
				}
				base.Command = command;
			}
			catch (JsonReaderException)
			{
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000042BB File Offset: 0x000024BB
		public override string ToString()
		{
			return this.Object.ToString(Formatting.None, new JsonConverter[0]);
		}
	}
}
