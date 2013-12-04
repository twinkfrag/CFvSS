using System;
using System.Runtime.InteropServices;
using System.Text;
using CocoroFunctionVerScreenShot.Properties;
using System.Text.RegularExpressions;

namespace CocoroFunctionVerScreenShot
{
    class IO
    {
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

        public IO()
        {
            active = GetForegroundWindow();
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
            /*
        int pid = 0;
        GetWindowThreadProcessId(active, out pid);
        System.Diagnostics.Process pr = System.Diagnostics.Process.GetProcessById(pid);
        windowPath = pr.MainModule.FileName.ToString();
         */
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
            fileName = Regex.Replace(fileName, Settings.Default.Regex_in, Settings.Default.Regex_out);
            Console.WriteLine(fileName);

            fullPath = Settings.Default.Path + fileName + ".png";
        }

        public static void LoadHotKeySettings(out bool ModKey_Alt, out bool ModKey_Ctrl, out bool ModKey_Shift, out bool ModKey_Win, out int HotKey){
            ModKey_Alt = Settings.Default.ModKey_Alt;
            ModKey_Ctrl = Settings.Default.ModKey_Ctrl;
            ModKey_Shift = Settings.Default.ModKey_Shift;
            ModKey_Win = Settings.Default.ModKey_Win;
            HotKey = (int)Settings.Default.HotKey;
        }
    }
}
