using System;
using System.Windows.Forms;

namespace CocoroFunctionVerScreenShot
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HKObject = new HotKey();
            HKObject.RegisterHotKey();
            Console.WriteLine("起動しました");
            Application.Run(new Form1());
        }
        public static HotKey HKObject;
        public static IO InObject;

        internal static void Closing()
        {
            HKObject.UnregisterHotKey();
        }
    }
}
