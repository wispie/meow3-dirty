using System;
using System.IO;
using System.Reflection;

namespace Grimoire.Utils
{
	// Token: 0x0200000B RID: 11
	public static class ReflectUtils
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002121 File Offset: 0x00000321
		public static object GetDefaultValue(this Type type)
		{
			if (!(type != typeof(void)) || !(type != null) || !type.IsValueType)
			{
				return null;
			}
			return Activator.CreateInstance(type);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000214E File Offset: 0x0000034E
		public static bool IsCompatible(this ProcessorArchitecture arch)
		{
			return arch == ProcessorArchitecture.MSIL || Assembly.GetExecutingAssembly().GetName().ProcessorArchitecture == arch;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00008A3C File Offset: 0x00006C3C
		public static DateTime GetLinkerTime(this Assembly assembly, TimeZoneInfo target = null)
		{
			string location = assembly.Location;
			byte[] array = new byte[2048];
			using (FileStream fileStream = new FileStream(location, FileMode.Open, FileAccess.Read))
			{
				fileStream.Read(array, 0, 2048);
			}
			int num = BitConverter.ToInt32(array, 60);
			int num2 = BitConverter.ToInt32(array, num + 8);
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			DateTime dateTime2 = dateTime.AddSeconds((double)num2);
			TimeZoneInfo destinationTimeZone = target ?? TimeZoneInfo.Local;
			return TimeZoneInfo.ConvertTimeFromUtc(dateTime2, destinationTimeZone);
		}
	}
}
