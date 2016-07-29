using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace net.twinkfrag.CFvSS
{
	class ScreenShot
	{
		/// <summary>
		/// 撮影
		/// </summary>
		public static void Shot()
		{
			//アクティブウィンドウの取得
			var active = Program.IoObject.Active;
			var rect = WindowHelper.GetWindowRectangle(active);

			using (var bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb))
			{
				using (var g = Graphics.FromImage(bmp))
				{
					g.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
				}
				Save(bmp, Program.IoObject.FullPath);
			}
		}

		public static void Save(Bitmap bmp, string filename)
		{
			//filenameからディレクトリを抜き出し存在チェック
			var dirEx = new Regex(@".*\\");
			var dir = dirEx.Match(filename).ToString();
			try
			{
				if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

				using (var file = new FileStream(filename, FileMode.Create))
				{
					bmp.Save(file, Program.IoObject.ImageFormat);
				}
				Program.MainForm.ShowBalloonTip(10000, "CFvSS", "撮影に成功しました", ToolTipIcon.Info);
			}
			catch (ArgumentException)
			{
				//ファイル名に * ? | < >
				Program.MainForm.ShowBalloonTip(10000, "CFvSS", "書き込み関数エラー", ToolTipIcon.Error);
			}
			catch (UnauthorizedAccessException)
			{
				//書き込み権限不足
				Program.MainForm.ShowBalloonTip(10000, "CFvSS", "ファイルエラー", ToolTipIcon.Error);
			}
			catch (DirectoryNotFoundException)
			{
				//ファイル名に / 
				Program.MainForm.ShowBalloonTip(10000, "CFvSS", "ディレクトリエラー", ToolTipIcon.Error);
			}
			catch (NotSupportedException)
			{
				//ファイル名に :
				Program.MainForm.ShowBalloonTip(10000, "CFvSS", "書き込み失敗", ToolTipIcon.Error);
			}
		}
	}
}
