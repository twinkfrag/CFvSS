using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace CocoroFunctionVerScreenShot
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
            System.Text.RegularExpressions.Regex dirEx = new System.Text.RegularExpressions.Regex(@".*\\");
            string dir = dirEx.Match(filename).ToString();
            if (!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);

            using (System.IO.FileStream file = new System.IO.FileStream(filename, System.IO.FileMode.Create))
            {
                bmp.Save(file, ImageFormat.Png);
            }
        }
    }
}
