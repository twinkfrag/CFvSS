using System;
using System.Windows.Forms;

namespace net.twinkfrag.CFvSS
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
            mainForm = new NotifyIconForm();
            Application.Run(mainForm);
        }
        public static NotifyIconForm mainForm;
        public static HotKey HKObject;
        public static IO InObject;

        internal static void Closing()
        {
            HKObject.UnregisterHotKey();
        }
    }
}
