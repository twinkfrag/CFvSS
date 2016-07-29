using System;
using System.Runtime.InteropServices;
using System.Text;
using net.twinkfrag.CFvSS.Properties;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using static net.twinkfrag.CFvSS.NativeMethods;
// ReSharper disable InconsistentNaming

namespace net.twinkfrag.CFvSS
{
	class IO
	{
		public enum FileType
		{
			Png, Jpg, Bmp
		}

		public IntPtr Active { get; private set; }
		public string FullPath { get; private set; }
		public ImageFormat ImageFormat { get; private set; }
		public string ImageFormatExt { get; private set; }

		public IO()
		{
			Active = GetForegroundWindow();
			var fileDirectory = Settings.Default.Path;

			const int nMaxCount = 255;
			var windowStr = new StringBuilder(nMaxCount);
			GetWindowText(Active, windowStr, nMaxCount);
			var windowText = windowStr.ToString();

			StringBuilder filenameStr;
			GetModuleFileName(Active, out filenameStr, nMaxCount);
			var windowPath = filenameStr?.ToString();

			Console.WriteLine(windowText);
			Console.WriteLine(windowPath);

			var yyyy = DateTime.Now.ToString("yyyy");
			var yy = DateTime.Now.ToString("yy");
			var MM = DateTime.Now.ToString("MM");
			var dd = DateTime.Now.ToString("dd");
			var HH = DateTime.Now.ToString("HH");
			var mm = DateTime.Now.ToString("mm");
			var ss = DateTime.Now.ToString("ss");

			var fileName = Settings.Default.FileName.Replace(@"%yyyy", yyyy)
									  .Replace(@"%yy", yy).Replace(@"%MM", MM).Replace(@"%dd", dd)
									  .Replace(@"%HH", HH).Replace(@"%mm", mm).Replace(@"%ss", ss)
									  .Replace(@"%wt", windowText);
			fileName = Regex.Replace(fileName, "[\\/\":*<>|]", "_");
			fileName = Regex.Replace(fileName, Settings.Default.Regex_in, Settings.Default.Regex_out);
			Console.WriteLine(fileName);

			switch (Settings.Default.FileType)
			{
				case (int)FileType.Png:
					ImageFormat = ImageFormat.Png;
					ImageFormatExt = ".png";
					break;
				case (int)FileType.Jpg:
					ImageFormat = ImageFormat.Jpeg;
					ImageFormatExt = ".jpg";
					break;
				case (int)FileType.Bmp:
					ImageFormat = ImageFormat.Bmp;
					ImageFormatExt = ".bmp";
					break;
			}

			if (!Regex.IsMatch(fileDirectory, @"\\$")) fileDirectory = fileDirectory + @"\";

			FullPath = fileDirectory + fileName + ImageFormatExt;
		}
	}
}
