using System;
using System.Windows.Forms;

namespace net.twinkfrag.CFvSS
{
    class HotKey : Form
    {
        int c;

        public void RegisterHotKey()
        {
            SettingsForm.LoadHotKeySettings(out modKey_alt, out modKey_ctrl, out modKey_shift, out modKey_win, out key);
            if (modKey_alt) this.modKey += MOD_ALT;
            if (modKey_ctrl) this.modKey += MOD_CONTROL;
            if (modKey_shift) this.modKey += MOD_SHIFT;
            if (modKey_win) this.modKey += MOD_WIN;

            Console.WriteLine(modKey);

            this.hotKeyId = (int)((modKey * 0x100) | key);
            this.hotKeyLParam = new IntPtr(modKey | (key * 0x10000));

            IO.RegisterHotKey(this.Handle , WM_HOTKEY, modKey, key);
        }

        public void UnregisterHotKey()
        {
            IO.UnregisterHotKey(this.Handle, WM_HOTKEY);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                if (m.LParam == this.hotKeyLParam)
                {
                    // ホットキーが押されたときの処理
                    Console.WriteLine("HOTキーが押されました" + c++);
                    Program.InObject = new IO();
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
        private int key;
        private int hotKeyId;
        private IntPtr hotKeyLParam;

        private bool modKey_alt, modKey_ctrl, modKey_shift, modKey_win;
    }
}
