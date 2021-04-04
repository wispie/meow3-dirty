using System;
using System.Collections.Generic;

namespace Grimoire.Utils
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class EmptyListProvider<T> : TypedValueProvider
	{
		// Token: 0x0600002B RID: 43 RVA: 0x0000217B File Offset: 0x0000037B
		public object Provide(Type type)
		{
			return new List<T>();
		}
	}
}
