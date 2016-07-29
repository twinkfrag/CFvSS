using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace net.twinkfrag.CFvSS
{
	public static class NativeMethods
	{
		[DllImport("user32.dll")]
		public extern static int RegisterHotKey(IntPtr hWnd, int id, int modKey, int key);

		[DllImport("user32.dll")]
		public extern static int UnregisterHotKey(IntPtr hWnd, int id);

		[DllImport("user32.dll")]
		public static extern int GetWindowRect(IntPtr hWnd, out Rect rect);

		[DllImport("user32.dll")]
		public extern static IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		public extern static int GetWindowText(IntPtr hWnd, StringBuilder str, int nMaxCount);

		[DllImport("user32.dll")]
		public extern static int GetWindowThreadProcessId(IntPtr hWnd, out int pid);

		[DllImport("kernel32.dll")]
		public extern static int GetModuleFileName(IntPtr hWnd, out StringBuilder str, int nMaxCount);

		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct Rect
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}

		private const string dwmapi = "dwmapi.dll";

		[DllImport(dwmapi)]
		public static extern int DwmGetWindowAttribute(IntPtr hwnd, DwmWindowAttribute dwAttibute, out Rect pvAttribute, int cbAttribute);

		public enum DwmWindowAttribute
		{
			DwmWaExtendedFrameBounds = 9
		}
	}
}
