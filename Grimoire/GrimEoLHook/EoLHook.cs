using System;
using System.Runtime.InteropServices;
using EasyHook;

namespace GrimEoLHook
{
	// Token: 0x020001AF RID: 431
	public class EoLHook
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0000856E File Offset: 0x0000676E
		public static bool IsHooked
		{
			get
			{
				return EoLHook._hook != null;
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00008578 File Offset: 0x00006778
		public static void Hook()
		{
			EoLHook._hook = LocalHook.Create(LocalHook.GetProcAddress("kernel32.dll", "GetSystemTime"), new EoLHook.GetSystemTimeDelegate(EoLHook.GetSystemTimeHooked), null);
			EoLHook._hook.ThreadACL.SetInclusiveACL(new int[1]);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000085B7 File Offset: 0x000067B7
		public static void Unhook()
		{
			EoLHook._hook.Dispose();
		}

		// Token: 0x06000A2B RID: 2603
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern void GetSystemTime(IntPtr lpSystemTime);

		// Token: 0x06000A2C RID: 2604 RVA: 0x00035D44 File Offset: 0x00033F44
		private unsafe static void GetSystemTimeHooked(IntPtr lpSystemTime)
		{
			EoLHook.GetSystemTime(lpSystemTime);
			EoLHook._SYSTEMTIME* ptr = (EoLHook._SYSTEMTIME*)((void*)lpSystemTime);
			ptr->wYear = 2020;
		}

		// Token: 0x040006C2 RID: 1730
		private static LocalHook _hook;

		// Token: 0x020001B0 RID: 432
		// (Invoke) Token: 0x06000A2F RID: 2607
		[UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
		private delegate void GetSystemTimeDelegate(IntPtr lpSystemTime);

		// Token: 0x020001B1 RID: 433
		public struct _SYSTEMTIME
		{
			// Token: 0x040006C3 RID: 1731
			public ushort wYear;

			// Token: 0x040006C4 RID: 1732
			public ushort wMonth;

			// Token: 0x040006C5 RID: 1733
			public ushort wDayOfWeek;

			// Token: 0x040006C6 RID: 1734
			public ushort wDay;

			// Token: 0x040006C7 RID: 1735
			public ushort wHour;

			// Token: 0x040006C8 RID: 1736
			public ushort wMinute;

			// Token: 0x040006C9 RID: 1737
			public ushort wSecond;

			// Token: 0x040006CA RID: 1738
			public ushort wMilliseconds;
		}
	}
}
