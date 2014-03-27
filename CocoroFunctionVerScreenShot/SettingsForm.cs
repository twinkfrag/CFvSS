using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using net.twinkfrag.CFvSS.Properties;
using System.Text.RegularExpressions;

namespace net.twinkfrag.CFvSS
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
			this.FormClosing += SettingsForm_FormClosing;

			settingLoad();
		}

		public new void Hide()
		{
			this.WindowState = FormWindowState.Minimized;
			ShowInTaskbar = false;
			base.Hide();
		}
		public new void Show()
		{
			this.WindowState = FormWindowState.Normal;
			ShowInTaskbar = true;
			base.Show();
		}

		public static void LoadHotKeySettings(out bool ModKey_Alt, out bool ModKey_Ctrl, out bool ModKey_Shift, out bool ModKey_Win, out int HotKey)
		{
			ModKey_Alt = Settings.Default.ModKey_Alt;
			ModKey_Ctrl = Settings.Default.ModKey_Ctrl;
			ModKey_Shift = Settings.Default.ModKey_Shift;
			ModKey_Win = Settings.Default.ModKey_Win;
			HotKey = (int)Settings.Default.HotKey;
		}

		private void settingLoad()
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

		private void settingSave()
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

			Program.HKObject.UnregisterHotKey();
			Settings.Default.Save();
			Program.HKObject = new HotKey();
			Program.HKObject.RegisterHotKey();
		}

		void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			settingSave();
		}

		private void FolderSelect_Click(object sender, EventArgs e)
		{
			folderBrowserDialog.SelectedPath = folderBox.Text;
			folderBrowserDialog.ShowDialog();
			folderBox.Text = folderBrowserDialog.SelectedPath;
		}

		private void regexTestInBox_TextChanged(object sender, EventArgs e)
		{
			string yyyy = DateTime.Now.ToString("yyyy");
			string yy = DateTime.Now.ToString("yy");
			string MM = DateTime.Now.ToString("MM");
			string dd = DateTime.Now.ToString("dd");
			string HH = DateTime.Now.ToString("HH");
			string mm = DateTime.Now.ToString("mm");
			string ss = DateTime.Now.ToString("ss");

			string fileName = "";
			string wt = ((TextBox)sender).Text;
			fileName = fileNameBox.Text.Replace(@"%yyyy", yyyy)
				.Replace(@"%yy", yy).Replace(@"%MM", MM).Replace(@"%dd", dd)
				.Replace(@"%HH", HH).Replace(@"%mm", mm).Replace(@"%ss", ss)
				.Replace(@"%wt", wt);
			fileName = Regex.Replace(fileName, "[\\/\":*<>|]", "_");
			fileName = Regex.Replace(fileName, Settings.Default.Regex_in, Settings.Default.Regex_out);

			regexTestOutBox.Text = fileName;
		}

		private void ResetButton_Click(object sender, EventArgs e)
		{
			settingLoad();
		}
	}
}
