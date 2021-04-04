using System;

namespace Grimoire.Utils
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public class DefaultTypedValueProvider : TypedValueProvider
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00008B24 File Offset: 0x00006D24
		public object Provide(Type type)
		{
			object result;
			try
			{
				result = Activator.CreateInstance(type);
			}
			catch
			{
				result = type.GetDefaultValue();
			}
			return result;
		}
	}
}
