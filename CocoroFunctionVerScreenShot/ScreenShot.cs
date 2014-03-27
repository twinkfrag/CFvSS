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
			IO.RECT r;
			IntPtr active = Program.InObject.active;
			IO.GetWindowRect(active, out r);
			Rectangle rect = new Rectangle(r.left, r.top, r.right - r.left, r.bottom - r.top);

			using (Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb))
			{
				using (Graphics g = Graphics.FromImage(bmp))
				{
					g.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
				}
				Save(bmp, Program.InObject.fullPath);
			}
		}

		public static void Save(Bitmap bmp, string filename)
		{
			//filenameからディレクトリを抜き出し存在チェック
			Regex dirEx = new Regex(@".*\\");
			string dir = dirEx.Match(filename).ToString();
			try
			{
				if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

				using (FileStream file = new FileStream(filename, FileMode.Create))
				{
					bmp.Save(file, Program.InObject.imageFormat);
				}
				Program.mainForm.ShowBalloonTip(10000, "CFvSS", "撮影に成功しました", ToolTipIcon.Info);
			}
			catch (ArgumentException e)
			{
				//ファイル名に * ? | < >
				Program.mainForm.ShowBalloonTip(10000, "CFvSS", "書き込み関数エラー", ToolTipIcon.Error);
				e.ToString();
			}
			catch (UnauthorizedAccessException e)
			{
				//書き込み権限不足
				Program.mainForm.ShowBalloonTip(10000, "CFvSS", "ファイルエラー", ToolTipIcon.Error);
				e.ToString();
			}
			catch (DirectoryNotFoundException e)
			{
				//ファイル名に / (\と違って処理していないため)
				Program.mainForm.ShowBalloonTip(10000, "CFvSS", "ディレクトリエラー", ToolTipIcon.Error);
				e.ToString();
			}
			catch (NotSupportedException e)
			{
				//ファイル名に :
				Program.mainForm.ShowBalloonTip(10000, "CFvSS", "書き込み失敗", ToolTipIcon.Error);
				e.ToString();
			}
		}
	}
}
