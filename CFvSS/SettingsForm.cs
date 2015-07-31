using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using net.twinkfrag.CFvSS.Properties;

namespace net.twinkfrag.CFvSS
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
			FormClosing += SettingsForm_FormClosing;

			SettingLoad();
		}

		public new void Hide()
		{
			WindowState = FormWindowState.Minimized;
			ShowInTaskbar = false;
			base.Hide();
		}
		public new void Show()
		{
			WindowState = FormWindowState.Normal;
			ShowInTaskbar = true;
			base.Show();
		}

		public static void LoadHotKeySettings(out bool isModKeyAlt, out bool isModKeyCtrl, out bool isModKeyShift, out bool isModKeyWin, out int keyCode)
		{
			isModKeyAlt = Settings.Default.ModKey_Alt;
			isModKeyCtrl = Settings.Default.ModKey_Ctrl;
			isModKeyShift = Settings.Default.ModKey_Shift;
			isModKeyWin = Settings.Default.ModKey_Win;
			keyCode = (int)Settings.Default.HotKey;
		}

		private void SettingLoad()
		{
			checkBoxAlt.Checked = Settings.Default.ModKey_Alt;
			checkBoxCtrl.Checked = Settings.Default.ModKey_Ctrl;
			checkBoxShift.Checked = Settings.Default.ModKey_Shift;
			checkBoxWin.Checked = Settings.Default.ModKey_Win;
			HotKeyBox.Text = ((char)Settings.Default.HotKey).ToString();
			folderBox.Text = Settings.Default.Path;
			fileNameBox.Text = Settings.Default.FileName;
			regexInBox.Text = Settings.Default.Regex_in;
			regexOutBox.Text = Settings.Default.Regex_out;
			fileTypeComboBox.SelectedIndex = (int)(IO.FileType)Settings.Default.FileType;
		}

		private void SettingSave()
		{
			Settings.Default.ModKey_Alt = checkBoxAlt.Checked;
			Settings.Default.ModKey_Ctrl = checkBoxCtrl.Checked;
			Settings.Default.ModKey_Shift = checkBoxShift.Checked;
			Settings.Default.ModKey_Win = checkBoxWin.Checked;
			Settings.Default.HotKey = (Keys)HotKeyBox.Text.ToCharArray()[0];
			Settings.Default.Path = folderBox.Text;
			Settings.Default.FileName = fileNameBox.Text;
			Settings.Default.Regex_in = regexInBox.Text;
			Settings.Default.Regex_out = regexOutBox.Text;
			Settings.Default.FileType = (int)(IO.FileType)fileTypeComboBox.SelectedIndex;

			Program.HkObject.UnregisterHotKey();
			Settings.Default.Save();
			Program.HkObject = new HotKey();
			Program.HkObject.RegisterHotKey();
		}

		void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
			Application.Exit();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			SettingSave();
		}

		private void FolderSelect_Click(object sender, EventArgs e)
		{
			folderBrowserDialog.SelectedPath = folderBox.Text;
			folderBrowserDialog.ShowDialog();
			folderBox.Text = folderBrowserDialog.SelectedPath;
		}

		private void regexTestInBox_TextChanged(object sender, EventArgs e)
		{
			// ReSharper disable InconsistentNaming
			var yyyy = DateTime.Now.ToString("yyyy");
			var yy = DateTime.Now.ToString("yy");
			var MM = DateTime.Now.ToString("MM");
			var dd = DateTime.Now.ToString("dd");
			var HH = DateTime.Now.ToString("HH");
			var mm = DateTime.Now.ToString("mm");
			var ss = DateTime.Now.ToString("ss");
			// ReSharper restore InconsistentNaming

			var wt = ((TextBox)sender).Text;
			var fileName = fileNameBox.Text.Replace(@"%yyyy", yyyy)
										 .Replace(@"%yy", yy).Replace(@"%MM", MM).Replace(@"%dd", dd)
										 .Replace(@"%HH", HH).Replace(@"%mm", mm).Replace(@"%ss", ss)
										 .Replace(@"%wt", wt);
			fileName = Regex.Replace(fileName, "[\\/\":*<>|]", "_");
			fileName = Regex.Replace(fileName, Settings.Default.Regex_in, Settings.Default.Regex_out);

			regexTestOutBox.Text = fileName;
		}

		private void ResetButton_Click(object sender, EventArgs e)
		{
			SettingLoad();
		}
	}
}
