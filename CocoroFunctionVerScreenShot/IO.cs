using System;
using System.Runtime.InteropServices;
using System.Text;
using net.twinkfrag.CFvSS.Properties;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace net.twinkfrag.CFvSS
{
	class IO
	{
		public enum FileType
		{
			Png, Jpg, Bmp
		}

		/// <summary>
		/// win32API呼び出し
		/// </summary>
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}

		[DllImport("user32.dll")]
		public extern static int RegisterHotKey(IntPtr HWnd, int ID, int MOD_KEY, int KEY);

		[DllImport("user32.dll")]
		public extern static int UnregisterHotKey(IntPtr HWnd, int ID);

		[DllImport("user32.dll")]
		public static extern int GetWindowRect(IntPtr hWnd, out RECT rect);

		[DllImport("user32.dll")]
		public extern static IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		public extern static int GetWindowText(IntPtr hWnd, StringBuilder str, int nMaxCount);

		[DllImport("user32.dll")]
		public extern static int GetWindowThreadProcessId(IntPtr hWnd, out int pid);

		[DllImport("kernel32.dll")]
		public extern static int GetModuleFileName(IntPtr hWnd, out StringBuilder str, int nMaxCount);

		public IntPtr active;
		public string fullPath;
		public ImageFormat imageFormat;
		public string imageFormatExt;

		public IO()
		{
			active = GetForegroundWindow();
			string fileDirectory = Settings.Default.Path;
			string fileName;
			string windowText = "";
			string windowPath = "";

			int nMaxCount = 255;
			StringBuilder str = new StringBuilder(nMaxCount);
			GetWindowText(active, str, nMaxCount);
			if (str != null) windowText = str.ToString();

			StringBuilder str2 = new StringBuilder(nMaxCount);
			GetModuleFileName(active, out str2, nMaxCount);
			if (str2 != null) windowPath = str2.ToString();

			Console.WriteLine(windowText);
			Console.WriteLine(windowPath);

			string yyyy = DateTime.Now.ToString("yyyy");
			string yy = DateTime.Now.ToString("yy");
			string MM = DateTime.Now.ToString("MM");
			string dd = DateTime.Now.ToString("dd");
			string HH = DateTime.Now.ToString("HH");
			string mm = DateTime.Now.ToString("mm");
			string ss = DateTime.Now.ToString("ss");

			fileName = Settings.Default.FileName.Replace(@"%yyyy", yyyy)
				.Replace(@"%yy", yy).Replace(@"%MM", MM).Replace(@"%dd", dd)
				.Replace(@"%HH", HH).Replace(@"%mm", mm).Replace(@"%ss", ss)
				.Replace(@"%wt", windowText);
			fileName = Regex.Replace(fileName, "[\\/\":*<>|]", "_");
			fileName = Regex.Replace(fileName, Settings.Default.Regex_in, Settings.Default.Regex_out);
			Console.WriteLine(fileName);

			switch (Settings.Default.FileType)
			{
				case (int)FileType.Png:
					imageFormat = ImageFormat.Png;
					imageFormatExt = ".png";
					break;
				case (int)FileType.Jpg:
					imageFormat = ImageFormat.Jpeg;
					imageFormatExt = ".jpg";
					break;
				case (int)FileType.Bmp:
					imageFormat = ImageFormat.Bmp;
					imageFormatExt = ".bmp";
					break;
			}

			if (!Regex.IsMatch(fileDirectory, @"\\$")) fileDirectory = fileDirectory + @"\";

			fullPath = fileDirectory + fileName + imageFormatExt;
		}
	}
}
