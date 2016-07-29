using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace net.twinkfrag.CFvSS
{
	public static class WindowHelper
	{
		public static Rectangle GetWindowRectangle(IntPtr handle)
		{
			NativeMethods.Rect r;

			if (Environment.OSVersion.Version.Major < 6 ||
				NativeMethods.DwmGetWindowAttribute(handle, NativeMethods.DwmWindowAttribute.DwmWaExtendedFrameBounds,
													out r, Marshal.SizeOf(typeof(NativeMethods.Rect))) < 0)
				NativeMethods.GetWindowRect(handle, out r);


			var rect = new Rectangle(r.left, r.top, r.right - r.left, r.bottom - r.top);

			return rect;
		}
	}
}
