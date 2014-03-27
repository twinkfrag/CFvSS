using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net.twinkfrag.CFvSS
{
	public partial class NotifyIconForm : Form
	{
		SettingsForm st;

		public NotifyIconForm()
		{
			InitializeComponent();
			this.FormClosing += NotifyIconForm_FormClosing;
			ShowInTaskbar = false;
			WindowState = FormWindowState.Minimized;

			st = new SettingsForm();

			this.notifyIcon1.MouseClick += new MouseEventHandler(notifyIcon1_MouseClick);
		}

		public void ShowBalloonTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon)
		{
			notifyIcon1.ShowBalloonTip(timeout, tipTitle, tipText, tipIcon);
		}

		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
		{
			MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
			mi.Invoke(notifyIcon1, null);
		}

		void NotifyIconForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.notifyIcon1.Visible = false;
			Program.Closing();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		private void settingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			st.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Hide();
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			TopMost = false;
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			st.Show();
		}

	}
}
