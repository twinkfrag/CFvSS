using System;
using System.Windows.Forms;

namespace net.twinkfrag.CFvSS
{
	class HotKey : Form
	{
		int c;

		public void RegisterHotKey()
		{
			SettingsForm.LoadHotKeySettings(out isModKeyAlt, out isModKeyCtrl, out isModKeyShift, out isModKeyWin, out keyCode);
			if (isModKeyAlt) modKey += MOD_ALT;
			if (isModKeyCtrl) modKey += MOD_CONTROL;
			if (isModKeyShift) modKey += MOD_SHIFT;
			if (isModKeyWin) modKey += MOD_WIN;

			Console.WriteLine(modKey);

			hotKeyId = (modKey * 0x100) | keyCode;
			hotKeyLParam = new IntPtr(modKey | (keyCode * 0x10000));

			IO.RegisterHotKey(Handle, WM_HOTKEY, modKey, keyCode);
		}

		public void UnregisterHotKey()
		{
			IO.UnregisterHotKey(Handle, WM_HOTKEY);
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == WM_HOTKEY)
			{
				if (m.LParam == hotKeyLParam)
				{
					// ホットキーが押されたときの処理
					Console.WriteLine(@"HOTキーが押されました" + c++);
					Program.IoObject = new IO();
					ScreenShot.Shot();
				}
			}
		}

		const int MOD_ALT = 0x0001;
		const int MOD_CONTROL = 0x0002;
		const int MOD_SHIFT = 0x0004;
		const int MOD_WIN = 0x0008;
		const int WM_HOTKEY = 0x0312;
		private int modKey;
		private int keyCode;
		// ReSharper disable once NotAccessedField.Local
		private int hotKeyId;
		private IntPtr hotKeyLParam;

		private bool isModKeyAlt, isModKeyCtrl, isModKeyShift, isModKeyWin;
	}
}
