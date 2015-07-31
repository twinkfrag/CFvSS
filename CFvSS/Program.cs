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

			HkObject = new HotKey();
			HkObject.RegisterHotKey();
			MainForm = new NotifyIconForm();
			Application.Run(MainForm);
		}

		internal static NotifyIconForm MainForm { get; private set; }
		internal static HotKey HkObject { get; set; }
		internal static IO IoObject { get; set; }

		internal static void Closing()
		{
			HkObject.UnregisterHotKey();
		}
	}
}
