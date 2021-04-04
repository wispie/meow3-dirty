using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Grimoire.Tools
{
	// Token: 0x02000072 RID: 114
	public class KeyboardHook : IDisposable
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060002FF RID: 767 RVA: 0x00003EBA File Offset: 0x000020BA
		public static KeyboardHook Instance { get; } = new KeyboardHook();

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000300 RID: 768 RVA: 0x000289EC File Offset: 0x00026BEC
		// (remove) Token: 0x06000301 RID: 769 RVA: 0x00028A24 File Offset: 0x00026C24
		public event Action<Keys> KeyDown;

		// Token: 0x06000302 RID: 770
		[DllImport("user32", CallingConvention = CallingConvention.StdCall)]
		private static extern int SetWindowsHookEx(int idHook, KeyboardHook.CallbackDelegate lpfn, int hInstance, int threadId);

		// Token: 0x06000303 RID: 771
		[DllImport("user32", CallingConvention = CallingConvention.StdCall)]
		private static extern bool UnhookWindowsHookEx(int idHook);

		// Token: 0x06000304 RID: 772
		[DllImport("user32", CallingConvention = CallingConvention.StdCall)]
		private static extern int CallNextHookEx(int idHook, int nCode, int wParam, int lParam);

		// Token: 0x06000305 RID: 773 RVA: 0x00003EC1 File Offset: 0x000020C1
		private KeyboardHook()
		{
			this.hookCallback = new KeyboardHook.CallbackDelegate(this.HookProc);
			this._hookId = KeyboardHook.SetWindowsHookEx(13, this.hookCallback, 0, 0);
			this.TargetedKeys = new List<Keys>();
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00028A5C File Offset: 0x00026C5C
		private int HookProc(int code, int wParam, int lParam)
		{
			if (code < 0)
			{
				return KeyboardHook.CallNextHookEx(this._hookId, code, wParam, lParam);
			}
			if (wParam == 256 || wParam == 260)
			{
				Keys keys = (Keys)Marshal.ReadInt32((IntPtr)lParam);
				if (this.TargetedKeys.Contains(keys))
				{
					Action<Keys> keyDown = this.KeyDown;
					if (keyDown != null)
					{
						keyDown(keys);
					}
				}
			}
			return KeyboardHook.CallNextHookEx(this._hookId, code, wParam, lParam);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00003EFB File Offset: 0x000020FB
		public void Dispose()
		{
			KeyboardHook.UnhookWindowsHookEx(this._hookId);
		}

		// Token: 0x040002CA RID: 714
		private const int WH_KEYBOARD_LL = 13;

		// Token: 0x040002CB RID: 715
		private const int WM_KEYDOWN = 256;

		// Token: 0x040002CC RID: 716
		private const int WM_SYSKEYDOWN = 260;

		// Token: 0x040002CD RID: 717
		private readonly KeyboardHook.CallbackDelegate hookCallback;

		// Token: 0x040002CE RID: 718
		public readonly List<Keys> TargetedKeys;

		// Token: 0x040002CF RID: 719
		private readonly int _hookId;

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x0600030A RID: 778
		public delegate int CallbackDelegate(int code, int wParam, int lParam);
	}
}
