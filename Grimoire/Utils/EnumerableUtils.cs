using System;
using System.Collections.Generic;

namespace Grimoire.Utils
{
	// Token: 0x02000009 RID: 9
	public static class EnumerableUtils
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000891C File Offset: 0x00006B1C
		public static void ForEach<T>(this IEnumerable<T> enumerable, Consumer<T> func)
		{
			foreach (T arg in enumerable)
			{
				func(arg);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00008964 File Offset: 0x00006B64
		public static bool Contains<T>(this IEnumerable<T> enumerable, Predicate<T> pred)
		{
			foreach (T obj in enumerable)
			{
				if (pred(obj))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000089B8 File Offset: 0x00006BB8
		public static IList<T> Swap<T>(this IList<T> list, int indexA, int indexB)
		{
			T value = list[indexA];
			list[indexA] = list[indexB];
			list[indexB] = value;
			return list;
		}
	}
}
